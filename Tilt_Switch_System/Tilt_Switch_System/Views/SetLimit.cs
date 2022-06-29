using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tilt_Switch_System.Log;
using Tilt_Switch_System.Utility;
using System.Threading;
using System.IO.Ports;
using Tilt_Switch_System.Views;

namespace Tilt_Switch_System.Views
{
    public partial class SetLimit : Form
    {
        public SetLimit()
        {
            InitializeComponent();
        }
        ViewMain objConSetting = new ViewMain();
        public string _protocol = string.Empty;
        public bool FlagReadFlag = false; 
        public bool FlagSetLimitXRead = false;
        public bool FlagSetLowBandXRead = false;
        public bool FlagSetHighBandXRead = false;
        public bool FlagOffsetLsbRead = false;

        public bool FlagSetLimitYRead = false;
        public bool FlagSetLowBandYRead = false;
        public bool FlagSetHighBandYRead = false;
        public bool FlagOffsetMsbRead = false;


       

        private void btnClose_Click(object sender, EventArgs e)
        {
            TmrCommunication.Enabled = false; 
            if (ComSetLimt.IsOpen)
            {
                ComSetLimt.Close();               
            }
            Globals.IsSetLimit = true;
            this.Close();
        }

        private void btnSetLimitXRead_Click(object sender, EventArgs e)
        {
            try
            {
               
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagSetLimitXRead = true;
                txtSetLimitX.Enabled = true;
                txtSetLimitX.ReadOnly = true;
                SendParameterToModBus("CalCapacity", "010301F40001");
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
                    ComSetLimt.Write(sendBytes, 0, 8);
                    FlagReadFlag = false;

                }
                else
                {
                    ComSetLimt.Write(sendBytes, 0, 10);
                    Thread.Sleep(100);
                    lblMsg.Text = "Tare...!!!";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        private void btnSetLowBandYRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagSetLowBandYRead = true;
                txtSetLowBandY.Enabled = true;
                txtSetLowBandY.ReadOnly = true;
                SendParameterToModBus("SetLpwBandY", "010301F80001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
        string Hex_Value;
        string ReceivedProtocol;
        string HexToDecimalValue;
        private void ComSetLimt_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(300);
                ComSetLimt.Encoding = Encoding.Default;
                Hex_Value += ComSetLimt.ReadExisting();
                ReceivedProtocol = Modbus.GetHexString(Hex_Value, 7);
                HexToDecimalValue = Modbus.GetBinaryString(ReceivedProtocol);
                BeginInvoke((ThreadStart)delegate { UpdateReadModbusValue(HexToDecimalValue); });
                Hex_Value = string.Empty;
            }
            catch (Exception ex)
            {
                Hex_Value = string.Empty;
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
                    if (FlagSetLimitXRead == true)
                    {
                        txtSetLimitX.Text = HexToDecimalValue;
                        FlagSetLimitXRead = false;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagSetLowBandXRead == true)
                    {
                        FlagSetLowBandXRead = false;
                        txtSetLowBandX.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagSetHighBandXRead == true)
                    {
                        FlagSetHighBandXRead = false;
                        txtSetHighBandX.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagOffsetLsbRead == true)
                    {
                        FlagOffsetLsbRead = false;
                        txtOffsetLsb.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagSetLimitYRead == true)
                    {
                        FlagSetLimitYRead = false;
                        txtSetLimiY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagSetLowBandYRead == true)
                    {
                        FlagSetLowBandYRead = false;
                        txtSetLowBandY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagSetHighBandYRead == true)
                    {
                        FlagSetHighBandYRead = false;
                        txtHighbandY.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                    if (FlagOffsetMsbRead == true)
                    {
                        FlagOffsetMsbRead = false;
                        txtOffsetMsb.Text = HexToDecimalValue;
                        lblMsg.Text = "Retrive Data Successfully...!!!";
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }
        
        private void btnSetLowBandXRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagSetLowBandXRead = true;
                txtSetLowBandX.Enabled = true;
                txtSetLowBandX.ReadOnly = true;
                SendParameterToModBus("SetLowBandX", "010301F50001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnSetHighBandXRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagSetHighBandXRead = true;
                txtSetHighBandX.Enabled = true;
                txtSetHighBandX.ReadOnly = true;
                SendParameterToModBus("SetHighBandX", "010301F60001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnSetLimitYRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagSetLimitYRead = true;
                txtSetLimiY.Enabled = true;
                txtSetLimiY.ReadOnly = true;
                SendParameterToModBus("SetLimitY", "010301F70001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

        }

        private void btnSetHighBandYRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagSetHighBandYRead = true;
                txtHighbandY.Enabled = true;
                txtHighbandY.ReadOnly = true;
                SendParameterToModBus("SetHighLimitY", "010301F90001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnOffsetMsbRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagOffsetMsbRead = true;
                txtOffsetMsb.Enabled = true;
                txtHighbandY.ReadOnly = true;
                SendParameterToModBus("OffsetMSB", "010301910001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnOffsetLsbRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                FlagReadFlag = true;
                FlagOffsetLsbRead = true;
                txtOffsetLsb.Enabled = true;
                txtOffsetLsb.ReadOnly = true;
                SendParameterToModBus("OffsetLSB", "010301900001");
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }

        private void btnSetLimitXEdit_Click(object sender, EventArgs e)
        {
            txtSetLimitX.ReadOnly = false;
            btnSetLimitXRead.Enabled = false;
            txtSetLimitX.Enabled = true;
            btnSetLimitXWrite.Enabled = true;
        }

        private void btnSetLowBandXEdit_Click(object sender, EventArgs e)
        {
            txtSetLowBandX.ReadOnly = false;
            btnSetLowBandXRead.Enabled = false;
            txtSetLowBandX.Enabled = true;
            btnSetLowBandXWrite.Enabled = true;
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
        private void btnSetLimitXWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnSetLimitXRead.Enabled = true;
                string preAddress = "010601F4";
                preAddress = preAddress + GetHexForParamValues(txtSetLimitX.Text);
                SendParameterToModBus("Ymax", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnSetHighBandXEdit_Click(object sender, EventArgs e)
        {
            txtSetHighBandX.ReadOnly = false;
            btnSetHighBandXRead.Enabled = false;
            txtSetHighBandX.Enabled = true;
            btnSetHighBandXWrite.Enabled = true;
        }

        private void btnOffsetLsbEdit_Click(object sender, EventArgs e)
        {
            txtOffsetLsb.ReadOnly = false;
            btnOffsetLsbRead.Enabled = false;
            txtOffsetLsb.Enabled = true;
            btnOffsetLsbWrite.Enabled = true;
        }

        private void btnSetLimitYEdit_Click(object sender, EventArgs e)
        {

            txtSetLimiY.ReadOnly = false;
            btnSetLimitYRead.Enabled = false;
            txtSetLimiY.Enabled = true;
            btnSetLimitYWrite.Enabled = true;
        }

        private void btnSetLowBandYEdit_Click(object sender, EventArgs e)
        {
            txtSetLowBandY.ReadOnly = false;
            btnSetLowBandYRead.Enabled = false;
            txtSetLowBandY.Enabled = true;
            btnSetLowBandYWrite.Enabled = true;
        }

        private void btnSetHighBandYEdit_Click(object sender, EventArgs e)
        {
            txtHighbandY.ReadOnly = false;
            btnSetHighBandYRead.Enabled = false;
            txtHighbandY.Enabled = true;
            btnSetHighBandYWrite.Enabled = true;
        }

        private void btnOffsetMsbEdit_Click(object sender, EventArgs e)
        {
            txtOffsetMsb.ReadOnly = false;
            btnOffsetMsbRead.Enabled = false;
            txtOffsetMsb.Enabled = true;
            btnOffsetMsbWrite.Enabled = true;
        }

        private void btnSetLowBandXWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnSetLowBandXRead.Enabled = true;
                string preAddress = "010601F5";
                preAddress = preAddress + GetHexForParamValues(txtSetLowBandX.Text);
                SendParameterToModBus("XLowBand", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnSetHighBandXWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnSetHighBandXRead.Enabled = true;
                string preAddress = "010601F6";
                preAddress = preAddress + GetHexForParamValues(txtSetHighBandX.Text);
                SendParameterToModBus("XHighBand", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnOffsetLsbWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnOffsetLsbRead.Enabled = true;
                string preAddress = "01060190";
                preAddress = preAddress + GetHexForParamValues(txtOffsetLsb.Text);
                SendParameterToModBus("XoffSet", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnSetLimitYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnSetLimitYRead.Enabled = true;
                string preAddress = "010601F7";
                preAddress = preAddress + GetHexForParamValues(txtSetLimiY.Text);
                SendParameterToModBus("Ymax", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnSetLowBandYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnSetLowBandYRead.Enabled = true;
                string preAddress = "010601F8";
                preAddress = preAddress + GetHexForParamValues(txtSetLowBandY.Text);
                SendParameterToModBus("YLowBand", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnSetHighBandYWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnSetHighBandYRead.Enabled = true;
                string preAddress = "010601F9";
                preAddress = preAddress + GetHexForParamValues(txtHighbandY.Text);
                SendParameterToModBus("YHighBand", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void btnOffsetMsbWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FlagReadFlag = true;
                btnOffsetMsbRead.Enabled = true;
                string preAddress = "01060191";
                preAddress = preAddress + GetHexForParamValues(txtOffsetMsb.Text);
                SendParameterToModBus("YHighBand", preAddress);
                lblMsg.Text = "Updated Succesfully";
            }
            catch (Exception ex)
            {

                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "btnXAngleTare_Click()");
            }
        }

        private void txtSetLimitX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSetLowBandX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSetHighBandX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOffsetLsb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSetLimiY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSetLowBandY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHighbandY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOffsetMsb_KeyPress(object sender, KeyPressEventArgs e)
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
        private void CommStatus()
        {
            try
            {
                string[] availablePorts = SerialPort.GetPortNames();
                if (availablePorts.Contains(Globals.CommPort))
                {
                    if (ComSetLimt.IsOpen)
                    {
                        lblStatus.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\Green Button.png");
                    }
                    else
                    {
                        ComSetLimt.PortName = Globals.CommPort;
                        ComSetLimt.BaudRate = Globals.BaudRate;
                        ComSetLimt.Parity = Parity.None;
                        ComSetLimt.DataBits = 8;
                        ComSetLimt.StopBits = StopBits.One;
                        ComSetLimt.Handshake = Handshake.None;
                        ComSetLimt.Encoding = Encoding.ASCII;
                        ComSetLimt.Open();

                    }




                    Globals.FlagCommStatus = ComSetLimt.IsOpen;
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
        private void SetLimit_Load(object sender, EventArgs e)
        {
            Globals.InitiateApplication();
            TmrCommunication.Enabled = true;
            CommStatus();
            AvailInfo();
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

        private void TmrCommunication_Tick(object sender, EventArgs e)
        {
           CommStatus();
        }

        private void SetLimit_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  TmrCommunication.Enabled = true;
        }

       
       

    }
}
