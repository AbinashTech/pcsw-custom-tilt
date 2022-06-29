using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Windows.Forms;
using Tilt_Switch_System.Views;
using Tilt_Switch_System.Utility;
using Tilt_Switch_System.Log;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.RegularExpressions;

namespace Tilt_Switch_System
{
    
    public partial class ViewMain : Form
    {

        public ViewMain()
        {
            InitializeComponent();
            blinker = new BackgroundWorker();
            blinker.DoWork += backgroundWorker1_DoWork;

        }
     
        
        BackgroundWorker blinker;
        public string _dataFromController;
        public string _protocol = string.Empty;
        public bool FlagReadFlag = false;
        public bool FlagLRTEST = false;
        public bool FlagHRTEST = false;
        public bool flagtare = false;
        public bool ContinousReadXdata = false;
        string _dataReceived = string.Empty;
        string Hex_Value;
        string ReceivedProtocol;
        string HexToDecimalValue;
        public static string StartChar = "%";
        public static string EndChar = "$";
        int TotalByte = 55;
        public int startPosition = 0;
        string LRXAngle = string.Empty;
        string LRYAngle = string.Empty;
        string HRXAngle = string.Empty;
        string HRYAngle = string.Empty;
        public string TestRange=string.Empty;
        public string currentXAngle = string.Empty;
        public string currentYAngle = string.Empty;
        public bool LRXTare = false;
        public bool LRYTare = false;
        public bool HRXTare = false;
        public bool HRYTare = false;
        int data;
        //public void ChangeHeader()
        //{
        //    lblHeader1.Text = Globals.Header1;
        //    lblHeader2.Text = Globals.HeaderLogo;
            
        //}

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.IsOpen)
                {
                    Controller.Close();
                }
                SettingScreen objSettingScreen = new SettingScreen();
                Globals.objSetting._updateHeaderUI += new MyDelegate(AvailInfo); 
                objSettingScreen.Show();
               
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString()); ;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.Close();
                tmrCheckCommunication.Enabled = false;
                this.Close();
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
         
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            try
            {
                tmrCheckCommunication.Enabled = false;
                Controller.Close();
                LowRangeCalibration objLowRangeCalib = new LowRangeCalibration();
                objLowRangeCalib.Show();
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }
        int Count = 1;
        private void CommStatus()
        {
            try
            {
              
                string[] availablePorts = SerialPort.GetPortNames();
                if (availablePorts.Contains(Globals.CommPort))
                {
                    if (Controller.IsOpen)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");
                        //if (Count > 5)
                        //{
                        //    Controller.Write("[UART1]");

                        //}
                        //Count++;


                    }
                    else
                    {
                        Controller.PortName = Globals.CommPort;
                        Controller.BaudRate = Globals.BaudRate;
                        Controller.Parity = Parity.None;
                        Controller.DataBits = 8;
                        Controller.StopBits = StopBits.One;
                        Controller.Handshake = Handshake.None;
                        Controller.Encoding = Encoding.ASCII;
                        Controller.Open();

                    }

                    
                  
                   
                    Globals.FlagCommStatus = Controller.IsOpen;
                    if (!Globals.FlagCommStatus)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
                        Count = 0;
                        lblXAngle.ForeColor = Color.Red;
                        lblYAngle.ForeColor = Color.Red;
                        lblXAngle.Text = "Comm Err";
                        lblYAngle.Text = "Comm Err";
                    }
                    else
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");
                        lblMsg.Visible = false;
                    }
                }
                else
                {
                    lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
                    Count = 0;
                    lblXAngle.ForeColor = Color.Red;
                    lblYAngle.ForeColor = Color.Red;
                    lblXAngle.Text = "Comm Err";
                    lblYAngle.Text = "Comm Err";
                }

            }

            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
                lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
            }



        }

        private void ViewMain_Load(object sender, EventArgs e)
        {

            try
            {
                Globals.InitiateApplication();
                tmrCheckCommunication.Enabled = true;
                tmrTestSelection.Enabled = true;
                CommStatus();
                AvailInfo();
                if (Controller.IsOpen)
                {
                    lblXAngle.Text = string.Empty;
                    lblYAngle.Text = string.Empty;
                    lblXAngle.Text = "00:00";
                    lblYAngle.Text = "00:00";
                    RbLowRange.Checked = true;
                  
                }
                
               
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        public void AvailInfo() //s
        {
            try
            {
                lblHeader1.Text = Globals.Header1;
              
                pblogo.Load(Globals.HeaderLogo);
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        private void btnSetLimit_Click(object sender, EventArgs e)
        {
             try
            {
                if (Controller.IsOpen)
                {
                    Controller.Write("[PCENABLE]");
                    Thread.Sleep(100);
                    string preAddress = "010601FF";
                    preAddress = preAddress + GetHexForParamValues("0001");
                    FlagReadFlag = true;
                    SendParameterToModBus("Ymax", preAddress);
                    RbLowRange.Checked = false;
                    Controller.Close();
                    SetLimit objSetLimit = new SetLimit();
                    objSetLimit.Show();
                }
                else
                {
                    if (blinker.IsBusy == false)
                    {
                        lblTareMsg.Visible = false;
                        lblMsg.Visible = true;
                        blinker.RunWorkerAsync();
                    }
                }
               
            }
             catch (Exception ex)
             {
                 Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
             }
        }
        private void UpdateLowRangeValue(string HexToDecimalValue)
        {
            try
            {
                Object thisLock = new Object();
                lock (thisLock)
                {
                    lblXAngle.Text = HexToDecimalValue;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        private void UpdateHighRangeValue(string HexToDecimalValue)
        {
            try
            {
                Object thisLock = new Object();
                lock (thisLock)
                {
                    lblXAngle.Text = HexToDecimalValue;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

       
        private void Controller_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            { 
                //Protocol Format
               //" %LR[XADC:3390*YADC:3455*ZADC:4095*XA: 55.63*YA: 42.92]$"
              // " %HR[XADC:3390*YADC:3454*ZADC:4095*XA:-57.68*YA:-56.99]$"
                //Controller.Encoding = Encoding.Default;
                Hex_Value += Controller.ReadExisting();
                int endCharLastIndex = Hex_Value.LastIndexOf(EndChar) + 1;
                string protocol = string.Empty;
                if (endCharLastIndex >=TotalByte)
                {
                    startPosition = endCharLastIndex - TotalByte;
                    protocol = Hex_Value.Substring(startPosition, TotalByte);
                    string SelectProtocol = Regex.Replace(protocol, @"\n|\r", "");
                    TestRange = SelectProtocol.Substring(1, 2);

                    if (TestRange == "LR")
                    {
                        FlagLRTEST = true;
                        LRXAngle = SelectProtocol.Substring(37, 6);
                        LRYAngle = SelectProtocol.Substring(47, 6);
                    }
                    if (TestRange == "HR")
                    {
                        FlagHRTEST = true;
                        HRXAngle = SelectProtocol.Substring(37, 6);
                        HRYAngle = SelectProtocol.Substring(47, 6);
                    }
                   Hex_Value = Hex_Value.Remove(0, Hex_Value.LastIndexOf(EndChar) + 1);
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "Controller_DataReceived()");
            }

        }

        private void btnHighRangeCalib_Click(object sender, EventArgs e)
        {
            try
            {
                HighRangeCalib objHighRangeCaib = new HighRangeCalib();
                objHighRangeCaib.Show();

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
           
        }

        private void tmrCheckCommunication_Tick(object sender, EventArgs e)
        {
            try
            {
                CommStatus();
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }
        public void SendParameterToModBus(string comType, string protocol)
        {
            try
            {
                byte[] sendBytes;
                _protocol = string.Empty;
                _protocol = Modbus.GenerateProtocolWithCrc(protocol);
                sendBytes = Modbus.StringToByteArrayFastest(_protocol);
                if (FlagReadFlag == true)
                {
                    Controller.Write(sendBytes, 0, 8);
                    FlagReadFlag = false;
                  
                }
                else
                {
                    Controller.Write(sendBytes, 0, 10);
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnXAngleTare_Click(object sender, EventArgs e)
        {
            try
            {

                if (Controller.IsOpen)
                {
                    Controller.Write("[LRTAREX]");
                    lblTareMsg.Visible = true;
                    lblTareMsg.Text = "Tare...!!!";
                }
                else
                {
                    MessageBox.Show("Check Communication");
                }
               
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
           
        }

        private void btnYAngleTare_Click(object sender, EventArgs e)
        {

            try
            {
                if (Controller.IsOpen)
                {
                    Controller.Write("[LRTAREY]");
                    lblTareMsg.Visible = true;
                    lblTareMsg.Text = "Tare..!!!";
                }
                else
                {
                    MessageBox.Show("Check Communication");
                }
            
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnYAngleTare_Click()");
            }
           
        }
        public string GetHexForParamValues(string value)
        {
            try
            {
                double doubleVal = Convert.ToDouble(value);
                int hexVal = Convert.ToInt32(doubleVal);
                string hexOutput = String.Format("{0:X4}", hexVal);
                return hexOutput;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void btnCalibration_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Controller.IsOpen)
                {
                    btnSetLimit.Enabled = false;
                    btnClose.Enabled = false;
                    lblTareMsg.Visible = false;
                    lblMsg.Visible = false;
                    Controller.Write("[PCENABLE]");//1
                    Thread.Sleep(100);
                    string preAddress = "010601FF";
                    FlagReadFlag = true;
                    preAddress = preAddress + GetHexForParamValues("0001");
                    SendParameterToModBus("Ymax", preAddress);
                    Controller.Close();
                    RbLowRange.Checked = false;
                    tmrCheckCommunication.Enabled = false;
                    pnlCalibScreen.Visible = true;
                    pnlCalibScreen.Location = new Point(50, 250);
                }
                else
                {
                    if (blinker.IsBusy == false)
                    {
                        lblTareMsg.Visible = false;
                        lblMsg.Visible = true;
                        blinker.RunWorkerAsync();
                    }
                }

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnYAngleTare_Click()");
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                pnlCalibScreen.Location = new Point(50, 25000);
                btnSetLimit.Enabled = true;
                btnClose.Enabled = true;
                tmrCheckCommunication.Enabled = true;
                if (Controller.IsOpen)
                {
                    Controller.Write("[UART1]");
                }
                else
                {
                    Controller.Open();
                    RbLowRange.Checked = true;
                }
               // RbLowRange.Checked = true;
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
           
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDateTime.Text = DateTime.Now.ToString();

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }

        private void tmrContinousSendData_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Globals.Iscomtrue)
                {
                    Controller.Close();
                    tmrCheckCommunication.Enabled = true;
                    Globals.Iscomtrue = false;
                  
                }

                if (Globals.IsSetLimit)
                {
                    if (Controller.IsOpen)
                    {
                        RbLowRange.Checked = true;
                        Globals.IsSetLimit = false;
                    }
                    else
                    {

                    }
                }
             
                if (FlagLRTEST == true)
                {
                    if (!string.IsNullOrEmpty(LRXAngle) && !string.IsNullOrEmpty(LRYAngle))
                    {
                        currentXAngle = LRXAngle;
                        currentYAngle = LRYAngle;
                        lblXAngle.ForeColor = Color.Chartreuse;
                        lblYAngle.ForeColor = Color.Chartreuse;
                        lblXAngle.Text = currentXAngle;
                        lblYAngle.Text = currentYAngle;
                        FlagLRTEST = false;
                    }
                }
                if (FlagHRTEST == true)
                {
                    if (!string.IsNullOrEmpty(HRXAngle) && !string.IsNullOrEmpty(HRYAngle))
                    {
                        FlagHRTEST = false;
                        currentXAngle = HRXAngle;
                        currentYAngle = HRYAngle;
                        lblXAngle.ForeColor = Color.Chartreuse;
                        lblYAngle.ForeColor = Color.Chartreuse;
                        lblXAngle.Text = currentXAngle;
                        lblYAngle.Text = currentYAngle;
                    }
                }
             
               
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
           
        }

        private void RbLowRange_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (RbLowRange.Checked == true)
                {
                    if (Controller.IsOpen)
                    {
                        lblTareMsg.Visible = false;
                        Globals.ModbusSelect = false;
                        string preAddress = "010601FF";
                        FlagReadFlag = true;
                        preAddress = preAddress + GetHexForParamValues("0000");
                        SendParameterToModBus("Ymax", preAddress);
                        Thread.Sleep(100);
                        Controller.Write("[UART2]");
                        btnXAngleHRTare.Visible = false;
                        btnYAngleHRTare.Visible = false;
                        btnXAngleTare.Visible = true;
                        btnYAngleTare.Visible = true;


                    }
                    else { MessageBox.Show("Check Communication"); }
                    lblDisplay.Text = "LowRangeSelect";
                    RbHighRange.Checked = false;
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
           
        }
        private void RbHighRange_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RbHighRange.Checked == true)
                {

                    if (Controller.IsOpen)
                    {
                        lblTareMsg.Visible = false;
                        Globals.ModbusSelect = false;
                        Controller.Write("[UART1]");
                        btnXAngleTare.Visible = false;
                        btnYAngleTare.Visible = false;
                        btnXAngleHRTare.Visible = true;
                        btnYAngleHRTare.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Check Communication");
                    }
                    lblDisplay.Text = "HighRangeSelect";
                    RbLowRange.Checked = false;
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }

        private void blinke_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void blink()
        {
            try
            {
                if (lblMsg.ForeColor == Color.Red)
                    lblMsg.ForeColor = Color.Black;
                else
                    lblMsg.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    System.Threading.Thread.Sleep(500); // Set fast to slow.

                    if (lblMsg.InvokeRequired)
                    {
                        lblMsg.Invoke((Action)blink);
                    }
                    else
                    {
                        blink();
                    }
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }

        private void tmrTestSelection_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Globals.ModbusSelect == true)
                {

                }
                if (Globals.Rs232Select == true)
                {

                }

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
            
        }

        private void btnXAngleHRTare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.IsOpen)
                {
                    Controller.Write("[HRTAREX]");
                    lblTareMsg.Visible = true;
                    lblTareMsg.Text = "Tare...!!!";
                }
                else
                {
                    MessageBox.Show("Check Communication");
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
                 
        }

        private void btnYAngleHRTare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.IsOpen)
                {
                    Controller.Write("[HRTAREY]");
                    lblTareMsg.Visible = true;
                    lblTareMsg.Text = "Tare...!!!";
                }
                else
                {
                    MessageBox.Show("Check Communication");
                }
 
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
             
        }

    }
}
