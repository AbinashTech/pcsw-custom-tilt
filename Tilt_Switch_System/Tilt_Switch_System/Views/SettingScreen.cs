using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tilt_Switch_System.Controller;
using System.IO.Ports;
using Tilt_Switch_System.Utility;
using Tilt_Switch_System.Log;
using System.IO;

namespace Tilt_Switch_System.Views
{
    public partial class SettingScreen : Form
    {
        ControllerSetting _objConSett = new ControllerSetting();
        public event MyDelegate _updateHeaderUI;
        public SettingScreen()
        {
            InitializeComponent();
           
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Availport();
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }

            MessageBox.Show("Searching Completed");
        }

        public void Availport()
        {
            cmbPorts.DataSource = null;
            string[] AvailablePorts = SerialPort.GetPortNames();
            cmbPorts.DataSource = AvailablePorts;
            if (AvailablePorts.Contains(Globals.CommPort))
            {
                cmbPorts.SelectedIndex = Array.IndexOf(AvailablePorts, Globals.CommPort);
            }

            int[] baudRate = {9600};
            CmbBaudRate.DataSource = null;
            CmbBaudRate.DataSource = baudRate;
            if (baudRate.Contains(Globals.BaudRate))
            {
                CmbBaudRate.SelectedItem = Globals.BaudRate;
            }
        }
        public void AvailInfo()
        {
            try
            {
                txth1.Text = Globals.Header1;
                txth2.Text = Globals.HeaderLogo;
                lblHeader1.Text = Globals.Header1;//s  
                pblogo.Load(Globals.HeaderLogo);//s
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }  
        }
        private void SettingScreen_Load(object sender, EventArgs e)
        {
            lblHeader1.Text = Globals.Header1;
            AvailInfo();
            Availport();
            HdrDefaultSatate();
        }
        public void HdrDefaultSatate()
        {
            foreach (Control control in gbHdr.Controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = false;
                }
                if (control is Button)
                {
                    if (control.Name == "btnHdrSave")
                    {
                        control.Enabled = false;
                    }
                    else if (control.Name == "btnCancel")
                    {
                        control.SendToBack();
                    }

                }
            }
        }
        public void DisplayHeader()
        {
            try
            {
                lblHeader1.Text = Globals.Header1;
            }
            catch(Exception ex)
            { 
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_objConSett.updateCommValue(cmbPorts.SelectedItem.ToString(), int.Parse(CmbBaudRate.SelectedItem.ToString())) > 0)
                {
                    MessageBox.Show("Restart required to apply changes");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Failed try again");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globals.Iscomtrue = true;  
            this.Close();
           
        }
       
        private void btnHdrSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (_objConSett.updateHeaderVal(txth1.Text, txth2.Text) > 0)
                {
                    MessageBox.Show("updated Successfully");
                    Globals.InitiateApplication();
                   // _updateHeaderUI();
                    lblHeader1.Text = Globals.Header1;
                    
                    
                   // lblHeader2.Text = Globals.Header2;
                    HdrDefaultSatate();
                    AvailInfo();
                }
                else
                {
                    MessageBox.Show("Failed try again");
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control control in gbHdr.Controls)
            {
                if (control is TextBox)
                {
                    //control.Text = "";
                    control.Enabled = true;
                }
                if (control is Button)
                {
                    if (control.Name == "btnHdrSave")
                    {
                        control.Enabled = true;
                    }
                    else if (control.Name == "btnEdit")
                    {
                        control.SendToBack();
                    }

                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                string dpath = AppDomain.CurrentDomain.BaseDirectory + @"\logoimage\leftlogo\";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG;)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";
                openFileDialog1.Title = "Select File for Image";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string CopyTO = openFileDialog1.FileName;
                    string PasteTO = AppDomain.CurrentDomain.BaseDirectory + @"\logoimage\leftlogo\" + Path.GetFileName(openFileDialog1.FileName);
                    if (File.Exists(PasteTO))
                    {
                        string message = "file already exist Are sure to replace?";
                        string caption = "Replace";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            File.Delete(dpath + System.IO.Path.GetFileName(openFileDialog1.FileName));
                            File.Copy(CopyTO, PasteTO, true);
                            txth2.Text = PasteTO;
                            //pblogo.Image = new Bitmap(openFileDialog1.FileName);                           
                           //var image = Image.FromFile(openFileDialog1.FileName);//System.IO.Path.GetFileName(openFileDialog1.FileName);
                           //lblLogo.Image = image;
                        }
                    }
                    else
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        File.Copy(CopyTO, PasteTO);
                        //lblLogo.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
                        txth2.Text = PasteTO;
                        //pblogo.Image = new Bitmap(openFileDialog1.FileName);
                        //var image = Image.FromFile(openFileDialog1.FileName);//System.IO.Path.GetFileName(openFileDialog1.FileName);
                        //lblLogo.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(ex.Message.ToString(), this.GetType().Name, "browseImage");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                HdrDefaultSatate();
                AvailInfo();
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(this.GetType().Name, Logger.GetMethodName(), ex.Message.ToString());
            }
        }
    }
}
