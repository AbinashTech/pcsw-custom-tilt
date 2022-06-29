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
    public partial class HighRangeCalib : Form
    {
        public HighRangeCalib()
        {
            InitializeComponent();
        }
        public string _protocol = string.Empty;
        public bool FlagXMinRead = false;
        public bool FlagXMaxRead = false;
        public bool FlagYMinRead = false;
        public bool FlagHighRangeTareX = false;
        public bool FlagHighRangeTareY = false;
        public bool FlagYMaxRead = false;
        public bool FlagZMinRead = false;
        public bool FlagZMaxRead = false;
        public bool FlagReadFlag = false;
        public bool ContinousReadXdata = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                TmrCommunication.Enabled = false;
                if (ComHighCalib.IsOpen)
                {
                    ComHighCalib.Close();
                }

                this.Close();
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }
        string Hex_Value;
        string ReceivedProtocol;
        string HexToDecimalValue;
        int data;
        private void ComCalib_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(100);
                ComHighCalib.Encoding = Encoding.Default;
                Hex_Value += ComHighCalib.ReadExisting();
                ReceivedProtocol = Modbus.GetHexString(Hex_Value, 7);
                HexToDecimalValue = Modbus.GetBinaryString(ReceivedProtocol);
                if (ContinousReadXdata == true)
                {
                    BeginInvoke((ThreadStart)delegate { UpdateCurrentAdc(HexToDecimalValue); });

                }
                else
                {
                    BeginInvoke((ThreadStart)delegate { UpdateReadModbusValue(HexToDecimalValue); });
                    Hex_Value = string.Empty;
                }
                Hex_Value = string.Empty;
            }
            catch (Exception ex)
            {
                Hex_Value = string.Empty;
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
        private void UpdateReadModbusValue(string HexToDecimalValue)
        {
            try
            {
                Object thisLock = new Object();
                lock (thisLock)
                {
                    if (FlagXMinRead == true)
                    {
                        txtXMin.Text = HexToDecimalValue;
                        FlagXMinRead = false;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagXMaxRead == true)
                    {
                        FlagXMaxRead = false;
                        txtXMax.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagYMinRead == true)
                    {
                        FlagYMinRead = false;
                        txtYMin.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagYMaxRead == true)
                    {
                        FlagYMaxRead = false;
                        txtYMax.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagZMinRead == true)
                    {
                        FlagZMinRead = false;
                        txtZMin.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagZMaxRead == true)
                    {
                        FlagZMaxRead = false;
                        txtZMax.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagHighRangeTareX == true)
                    {
                        FlagHighRangeTareX = false;
                        // txtTareX.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagHighRangeTareY == true)
                    {
                        FlagHighRangeTareY = false;
                        //  txtTareY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                }
            }
            catch (Exception ex)
            {
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
                    ComHighCalib.Write(sendBytes, 0, 8);
                    FlagReadFlag = false;

                }
                else
                {
                    ComHighCalib.Write(sendBytes, 0, 10);
                    Thread.Sleep(100);
                    lblMsg.Text = "Tare...!!!";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        private void btnTareEditY_Click(object sender, EventArgs e)
        {

        }

        private void btnXMinEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtXMin.ReadOnly = false;
                btnXMinRead.Enabled = false;
                txtXMin.Enabled = true;
                btnXMinWrite.Enabled = true;
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }



        private void btnXMinRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagXMinRead = true;
                txtXMin.Enabled = true;
                txtXMin.ReadOnly = true;
                SendParameterToModBus("Xmin", "010300790001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnXMaxRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagXMaxRead = true;
                txtXMax.Enabled = true;
                txtXMax.ReadOnly = true;
                SendParameterToModBus("Xmax", "010300800001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnYMinRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagYMinRead = true;
                txtYMin.Enabled = true;
                txtYMin.ReadOnly = true;
                SendParameterToModBus("ymin", "010300830001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnYMaxRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagYMaxRead = true;
                txtYMax.Enabled = true;
                txtYMax.ReadOnly = true;
                SendParameterToModBus("YMax", "010300820001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnZMinRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagZMinRead = true;
                txtZMin.Enabled = true;
                txtZMin.ReadOnly = true;
                SendParameterToModBus("Zmin", "0103008D0001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnZMaxRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagZMaxRead = true;
                txtZMax.Enabled = true;
                txtZMax.ReadOnly = true;
                SendParameterToModBus("Zmax", "0103008C0001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnTareXWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                string preAddress = "0106007D";
                preAddress = preAddress + GetHexForParamValues("0001");
                SendParameterToModBus("Tare", preAddress);
                lblMsg.Text = "Tare X";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnXMaxEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtXMax.ReadOnly = false;
                btnXMaxRead.Enabled = false;
                txtXMax.Enabled = true;
                btnXMaxWrite.Enabled = true;
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void btnYMinEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtYMin.ReadOnly = false;
                btnYMinRead.Enabled = false;
                txtYMin.Enabled = true;
                btnYMinWrite.Enabled = true;

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void btnYMaxEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtYMax.ReadOnly = false;
                btnYMaxRead.Enabled = false;
                txtYMax.Enabled = true;
                btnYMaxWrite.Enabled = true;
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void btnZMinEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtZMin.ReadOnly = false;
                btnZMinRead.Enabled = false;
                txtZMin.Enabled = true;
                btnZMinWrite.Enabled = true;

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void btnZMaxEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtZMax.ReadOnly = false;
                btnZMaxRead.Enabled = false;
                txtZMax.Enabled = true;
                btnZMaxWrite.Enabled = true;

            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
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
        private void btnXMinWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnXMinRead.Enabled = true;
                string preAddress = "01060079";
                preAddress = preAddress + GetHexForParamValues(txtXMin.Text);
                SendParameterToModBus("Xmin", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnXMaxWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnXMaxRead.Enabled = true;
                string preAddress = "01060080";
                preAddress = preAddress + GetHexForParamValues(txtXMax.Text);
                SendParameterToModBus("Xmax", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnYMinWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnYMinRead.Enabled = true;
                string preAddress = "01060083";
                preAddress = preAddress + GetHexForParamValues(txtYMin.Text);
                SendParameterToModBus("Ymin", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnYMaxWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnYMaxRead.Enabled = true;
                string preAddress = "01060082";
                preAddress = preAddress + GetHexForParamValues(txtYMax.Text);
                SendParameterToModBus("Ymax", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnZMinWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnZMinRead.Enabled = true;
                string preAddress = "0106008D";
                preAddress = preAddress + GetHexForParamValues(txtZMin.Text);
                SendParameterToModBus("ZminRead", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnZMaxWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnZMaxRead.Enabled = true;
                string preAddress = "0106008C";
                preAddress = preAddress + GetHexForParamValues(txtZMax.Text);
                SendParameterToModBus("Z max", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnTareYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                string preAddress = "01060087";
                preAddress = preAddress + GetHexForParamValues("0001");
                SendParameterToModBus("Tare", preAddress);
                lblMsg.Text = "Tare Y";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnTareBoth_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                string preAddress = "01060088";
                preAddress = preAddress + GetHexForParamValues("0001");
                SendParameterToModBus("Tare", preAddress);
                lblMsg.Text = "Both Tare";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void txtXMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtXMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtYMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtYMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtZMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtZMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtTareX_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void txtTareY_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
        private void HighRangeCalib_Load(object sender, EventArgs e)
        {
            try
            {
                Globals.InitiateApplication();
                btnStart.Text = "Start";
                btnstop.Text = "Stop";
                btnStart.ForeColor = Color.Chartreuse;
                TmrCommunication.Enabled = true;
                CommStatus();
                AvailInfo();
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }


        }
        private void CommStatus()
        {
            try
            {
                string[] availablePorts = SerialPort.GetPortNames();
                if (availablePorts.Contains(Globals.CommPort))
                {
                    if (ComHighCalib.IsOpen)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");
                    }
                    else
                    {
                        ComHighCalib.PortName = Globals.CommPort;
                        ComHighCalib.BaudRate = Globals.BaudRate;
                        ComHighCalib.Parity = Parity.None;
                        ComHighCalib.DataBits = 8;
                        ComHighCalib.StopBits = StopBits.One;
                        ComHighCalib.Handshake = Handshake.None;
                        ComHighCalib.Encoding = Encoding.ASCII;
                        ComHighCalib.Open();

                    }




                    Globals.FlagCommStatus = ComHighCalib.IsOpen;
                    if (!Globals.FlagCommStatus)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Red Button.png");
                    }
                    else
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");

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

        private void tmrContinousSendData_Tick(object sender, EventArgs e)
        {
                  try
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
                if (Globals.ZRawAdc == true)
                {
                    lblMsg.Text = string.Empty;
                    FlagReadFlag = true;
                    ContinousReadXdata = true;
                    SendParameterToModBus("Zmin", "010300900001");
                }


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
                if (selectedRAWADC == "Z")
                {

                    Globals.XRawAdc = false;
                    Globals.YRawAdc = false;
                    Globals.ZRawAdc = true;
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

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
                lblXRawadc.Text = "0000";
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
        public void ReadEnableTrue()
        {
            btnXMinRead.Enabled = true;
            btnXMaxRead.Enabled = true;
            btnYMinRead.Enabled = true;
            btnYMaxRead.Enabled = true;
            btnZMinRead.Enabled = true;
            btnZMaxRead.Enabled = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ComHighCalib.Write("[CALIB]");
                MessageBox.Show("Update Successfully");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        public void ReadEnableFalse()
        {
            btnXMinRead.Enabled = false;
            btnXMaxRead.Enabled = false;
            btnYMinRead.Enabled = false;
            btnYMaxRead.Enabled = false;
            btnZMinRead.Enabled = false;
            btnZMaxRead.Enabled = false;
        }

        private void lblXRawadc_Click(object sender, EventArgs e)
        {

        }


    }
}
