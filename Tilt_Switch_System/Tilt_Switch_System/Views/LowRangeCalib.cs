using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tilt_Switch_System.Utility;
using System.Threading;
using Tilt_Switch_System.Log;
using System.IO.Ports;

namespace Tilt_Switch_System.Views
{
    public partial class LowRangeCalibration : Form
    {
        public string _protocol = string.Empty;
        public LowRangeCalibration()
        {
            InitializeComponent();
        }
        public bool FlagCalZeroRead = false;
        public bool FlagCalSpanRead = false;
        public bool FlagCalCapacityRead = false;
        public bool FlagLowRangeTareX = false;
        public bool FlagLowRangeTareY = false;
        public bool FlagCalZeroReadY = false;
        public bool FlagCalSpanReadY = false;
        public bool FlagCalCapacityReadY = false;
        public bool FlagReadFlag = false;
        public bool FlagTare = false;
        public bool ContinousReadXdata = false;
        private void btnCalZeroRead_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            FlagReadFlag = true;
            FlagCalZeroRead = true;
            txtCalZero.Enabled = true;
            txtCalZero.ReadOnly = true;
            SendParameterToModBus("CalZero", "010300640001");
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
                    ComCalib.Write(sendBytes, 0, 8);
                    FlagReadFlag = false;
                  
                }
                else
                {
                    ComCalib.Write(sendBytes, 0, 10);
                    Thread.Sleep(100);
                    lblMsg.Text = "Updated Successfully...!!!";
                }
            }
            catch (Exception ex)
            {
                
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
        private void UpdateReadModbusValue(string HexToDecimalValue)
        {
            try
            {
                Object thisLock = new Object();
                lock (thisLock)
                {
                    if (FlagCalZeroRead == true)
                    {
                        txtCalZero.Text = HexToDecimalValue;
                        FlagCalZeroRead = false;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagCalSpanRead == true)
                    {
                        FlagCalSpanRead = false;
                        txtCalSpan.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagCalCapacityRead == true)
                    {
                        FlagCalCapacityRead = false;
                        txtCalcapacity.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagLowRangeTareX == true)
                    {
                        FlagLowRangeTareX = false;
                        //txtLowRangeTareX.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagCalZeroReadY == true)
                    {
                        FlagCalZeroReadY = false;
                        txtCalZeroY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagCalSpanReadY == true)
                    {
                        FlagCalSpanReadY = false;
                        txtCalSpanY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagCalCapacityReadY == true)
                    {
                        FlagCalCapacityReadY = false;
                        txtCalCapacityY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagLowRangeTareY == true)
                    {
                        FlagLowRangeTareY = false;
                       // txtTareY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }
        private void UpdateCurrentAdc(string HexToDecimalValue)
        {
            try
            {
                Object thisLock = new Object();
                lock (thisLock)
                {
                    lblXRawadc.Text = HexToDecimalValue;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        string Hex_Value;
        string ReceivedProtocol;
        string HexToDecimalValue;
        private void ComCalib_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(100);
                ComCalib.Encoding = Encoding.Default;
                Hex_Value += ComCalib.ReadExisting();
                ReceivedProtocol = Modbus.GetHexString(Hex_Value, 7);
                HexToDecimalValue = Modbus.GetBinaryString(ReceivedProtocol);
                if (ContinousReadXdata == true)
                {
                    BeginInvoke((ThreadStart)delegate { UpdateCurrentAdc(HexToDecimalValue); });

                }
                else
                {
                    BeginInvoke((ThreadStart)delegate { UpdateReadModbusValue(HexToDecimalValue); });
                }
                Hex_Value = string.Empty;
            }
            catch (Exception ex)
            {
                Hex_Value = string.Empty;
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void TmrCommunication_Tick(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.LowRangeSelect = true;
                TmrCommunication.Enabled = false;
                if (ComCalib.IsOpen)
                {
                    ComCalib.Close();
                }
                this.Close();
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
       
        }

        private void LowRangeCalibration_Load(object sender, EventArgs e)
        {
            Globals.InitiateApplication();
            CommStatus();
            AvailInfo();
            TmrCommunication.Enabled = true;
        }
        private void CommStatus()
        {
            try
            {
                string[] availablePorts = SerialPort.GetPortNames();
                if (availablePorts.Contains(Globals.CommPort))
                {
                    if (ComCalib.IsOpen)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");
                    }
                    else
                    {
                        ComCalib.PortName = Globals.CommPort;
                        ComCalib.BaudRate = Globals.BaudRate;
                        ComCalib.Parity = Parity.None;
                        ComCalib.DataBits = 8;
                        ComCalib.StopBits = StopBits.One;
                        ComCalib.Handshake = Handshake.None;
                        ComCalib.Encoding = Encoding.ASCII;
                        ComCalib.Open();
                    }




                    Globals.FlagCommStatus = ComCalib.IsOpen;
                    if (!Globals.FlagCommStatus)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
                    }
                    else
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");
                        //Controller.Write("[UART2]");
                    }
                }
                else
                {
                    lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
                }

            }

            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
                lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
            }



        }
        private void btnCalSpanRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagCalSpanRead = true;
                txtCalSpan.Enabled = true;
                txtCalSpan.ReadOnly = true;
                SendParameterToModBus("CalSpan", "010300660001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
           
        }

        private void btnCalCapacityRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagCalCapacityRead = true;
                txtCalcapacity.Enabled = true;
                txtCalcapacity.ReadOnly = true;
                SendParameterToModBus("CalCapacity", "010300680001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
           

        }

        private void btnLowRangeTareWrite_Click(object sender, EventArgs e)
        {
            try
            {
               // objCobjConSetting
                FlagTare = true;
                FlagReadFlag = true;
                string preAddress = "0106006A";
                preAddress = preAddress + GetHexForParamValues("0001");
                SendParameterToModBus("TareX", preAddress);
                lblMsg.Text = "Tare Successfully";
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
        private void btnCalZeroEdit_Click(object sender, EventArgs e)
        {
            txtCalZero.ReadOnly = false;
            btnCalZeroRead.Enabled = false;
            txtCalZero.Enabled = true;
            btnCalZeroWrite.Enabled = true;
        }

        private void btnCalZeroWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCalZero.Text != string.Empty)
                {
                    FlagReadFlag = true;
                    btnCalZeroRead.Enabled = true;
                    //string preAddress = "0106006B";
                    string preAddress = "01060064";
                    preAddress = preAddress + GetHexForParamValues(txtCalZero.Text.ToString());
                    SendParameterToModBus("CalZeroWrite", preAddress);
                    
                }
                else
                {
                    btnCalZeroRead.Enabled = true;
                    MessageBox.Show("Empty Values Not Accepted Please Enter the values");
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnCalZeroY_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            FlagReadFlag = true;
            FlagCalZeroReadY = true;
            txtCalZeroY.Enabled = true;
            txtCalZeroY.ReadOnly = true;
            SendParameterToModBus("CalZeroY", "0103006E0001");
        }

        private void btnCalSpanY_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            FlagReadFlag = true;
            FlagCalSpanReadY = true;
            txtCalSpanY.Enabled = true;
            txtCalSpanY.ReadOnly = true;
            SendParameterToModBus("CalSpanY", "010300700001");
        }

        private void btnCalCapacityY_Click(object sender, EventArgs e)
        {

            lblMsg.Text = string.Empty;
            FlagReadFlag = true;
            FlagCalCapacityReadY = true;
            txtCalCapacityY.Enabled = true;
            txtCalCapacityY.ReadOnly = true;
            SendParameterToModBus("CalCapacityY", "010300720001");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Globals.LowRangeSelect = true;
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

      
        private void btnTareY_Click(object sender, EventArgs e)
        {
            try
            {
                FlagTare = true;
                FlagReadFlag = true;
                string preAddress = "01060074";
                preAddress = preAddress + GetHexForParamValues("0001");
                SendParameterToModBus("TareX", preAddress);
                lblMsg.Text = "Tare";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnYAngleTare_Click()");
            }
        }

        private void btnCalSpanEdit_Click(object sender, EventArgs e)
        {
            txtCalSpan.ReadOnly = false;
            btnCalSpanRead.Enabled = false;
            txtCalSpan.Enabled = true;
            btnCalSpanWrite.Enabled = true;
        }

        private void btnCalCapacityEdit_Click(object sender, EventArgs e)
        {
            txtCalcapacity.ReadOnly = false;
            btnCalCapacityRead.Enabled = false;
            txtCalcapacity.Enabled = true;
            btnCalCapacityWrite.Enabled = true;
        }

        private void btnCalZeroEditY_Click(object sender, EventArgs e)
        {
            txtCalZeroY.ReadOnly = false;
            btnCalZeroY.Enabled = false;
            txtCalZeroY.Enabled = true;
            btnCalZeroYWrite.Enabled = true;
        }

        private void btnCalSpanEditY_Click(object sender, EventArgs e)
        {
            txtCalSpanY.ReadOnly = false;
            btnCalSpanY.Enabled = false;
            txtCalSpanY.Enabled = true;
            btnCalSpanYWrite.Enabled = true;
        }

        private void btnCalCapacityEditY_Click(object sender, EventArgs e)
        {
            txtCalCapacityY.ReadOnly = false;
            btnCalCapacityY.Enabled = false;
            txtCalCapacityY.Enabled = true;
            btnCalCapacityYWrite.Enabled = true;
        }

        private void btnCalSpanWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnCalSpanRead.Enabled = true;
                string preAddress = "01060066";
                preAddress = preAddress + GetHexForParamValues(txtCalSpan.Text.ToString());
                SendParameterToModBus("CalSpanWrite", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnCalCapacityWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnCalCapacityRead.Enabled = true;
                string preAddress = "01060068";
                preAddress = preAddress + GetHexForParamValues(txtCalcapacity.Text.ToString());
                SendParameterToModBus("CalSpanWrite", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnCalZeroYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnCalZeroY.Enabled = true;
                string preAddress = "0106006E";
                preAddress = preAddress + GetHexForParamValues(txtCalZeroY.Text.ToString());
                SendParameterToModBus("CalZeroY", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnCalSpanYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnCalSpanY.Enabled = true;
                string preAddress = "01060070";
                preAddress = preAddress + GetHexForParamValues(txtCalSpanY.Text.ToString());
                SendParameterToModBus("CalSpanYWrite", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnCalCapacityYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnCalCapacityY.Enabled = true;
                string preAddress = "01060072";
                preAddress = preAddress + GetHexForParamValues(txtCalCapacityY.Text.ToString());
                SendParameterToModBus("CalCapacityY", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void txtCalZero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCalSpan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCalcapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCalZeroY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCalSpanY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void txtCalCapacityY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void LowRangeCalibration_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCalibSelect.SelectedItem != null)
                {
                    ReadEnableFalse();
                    btnStart.ForeColor = Color.Red;
                    btnstop.ForeColor = Color.Chartreuse;
                    tmrContinousSendData.Enabled = true;
                   
                }
                else { MessageBox.Show("Please Select a Value "); }


            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            try
            {
                ReadEnableTrue();
                //lblXRawadc.Text = "0000";
                ContinousReadXdata = false;
                btnstop.ForeColor = Color.Red;
                btnStart.ForeColor = Color.Chartreuse;
                tmrContinousSendData.Enabled = false;
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void CmbCalibSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedRAWADC = CmbCalibSelect.SelectedItem.ToString();
                if (selectedRAWADC == "X")
                {
                    Globals.XRawAdc = true;
                    Globals.YRawAdc = false;
                    Globals.ZRawAdc = false;
                }
                if (selectedRAWADC == "Y")
                {

                    Globals.XRawAdc = false;
                    Globals.YRawAdc = true;
                    Globals.ZRawAdc = false;
                }
              
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void tmrContinousSendData_Tick(object sender, EventArgs e)
        {
            if (Globals.XRawAdc == true)
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                ContinousReadXdata = true;
                SendParameterToModBus("Xmin", "0103006B0001");
            }
            if (Globals.YRawAdc == true)
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                ContinousReadXdata = true;
                SendParameterToModBus("Xmin", "010300750001");
            }
        }
        public void ReadEnableFalse()
        {
            btnCalZeroRead.Enabled = false;
            btnCalSpanRead.Enabled = false;
            btnCalCapacityRead.Enabled = false;
            btnCalZeroY.Enabled = false;
            btnCalSpanY.Enabled = false;
            btnCalCapacityY.Enabled = false;
        }
        public void ReadEnableTrue()
        {
            btnCalZeroRead.Enabled = true;
            btnCalSpanRead.Enabled = true;
            btnCalCapacityRead.Enabled = true;
            btnCalZeroY.Enabled = true;
            btnCalSpanY.Enabled = true;
            btnCalCapacityY.Enabled = true;
        }


    }
}