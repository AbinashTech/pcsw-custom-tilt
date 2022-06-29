namespace Tilt_Switch_System
{
    partial class ViewMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMain));
            this.btnYAngleTare = new System.Windows.Forms.Button();
            this.btnXAngleTare = new System.Windows.Forms.Button();
            this.lblYAngle = new System.Windows.Forms.Label();
            this.lblXAngle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetLimit = new System.Windows.Forms.Button();
            this.btnLowRangeCalibration = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.Controller = new System.IO.Ports.SerialPort(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnHighRangeCalib = new System.Windows.Forms.Button();
            this.tmrCheckCommunication = new System.Windows.Forms.Timer(this.components);
            this.btnCalibration = new System.Windows.Forms.Button();
            this.pnlCalibScreen = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.tmrContinousSendData = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmrTestSelection = new System.Windows.Forms.Timer(this.components);
            this.lblTareMsg = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.RbHighRange = new System.Windows.Forms.RadioButton();
            this.RbLowRange = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnYAngleHRTare = new System.Windows.Forms.Button();
            this.btnXAngleHRTare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.pnlCalibScreen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYAngleTare
            // 
            this.btnYAngleTare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYAngleTare.BackgroundImage")));
            this.btnYAngleTare.Image = ((System.Drawing.Image)(resources.GetObject("btnYAngleTare.Image")));
            this.btnYAngleTare.Location = new System.Drawing.Point(573, 401);
            this.btnYAngleTare.Name = "btnYAngleTare";
            this.btnYAngleTare.Size = new System.Drawing.Size(133, 44);
            this.btnYAngleTare.TabIndex = 21;
            this.btnYAngleTare.UseVisualStyleBackColor = true;
            this.btnYAngleTare.Visible = false;
            this.btnYAngleTare.Click += new System.EventHandler(this.btnYAngleTare_Click);
            // 
            // btnXAngleTare
            // 
            this.btnXAngleTare.Image = ((System.Drawing.Image)(resources.GetObject("btnXAngleTare.Image")));
            this.btnXAngleTare.Location = new System.Drawing.Point(573, 335);
            this.btnXAngleTare.Name = "btnXAngleTare";
            this.btnXAngleTare.Size = new System.Drawing.Size(133, 44);
            this.btnXAngleTare.TabIndex = 20;
            this.btnXAngleTare.UseVisualStyleBackColor = true;
            this.btnXAngleTare.Visible = false;
            this.btnXAngleTare.Click += new System.EventHandler(this.btnXAngleTare_Click);
            // 
            // lblYAngle
            // 
            this.lblYAngle.BackColor = System.Drawing.Color.Black;
            this.lblYAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYAngle.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblYAngle.Location = new System.Drawing.Point(366, 390);
            this.lblYAngle.Name = "lblYAngle";
            this.lblYAngle.Size = new System.Drawing.Size(192, 56);
            this.lblYAngle.TabIndex = 19;
            this.lblYAngle.Text = "000000";
            this.lblYAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXAngle
            // 
            this.lblXAngle.BackColor = System.Drawing.Color.Black;
            this.lblXAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXAngle.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblXAngle.Location = new System.Drawing.Point(366, 318);
            this.lblXAngle.Name = "lblXAngle";
            this.lblXAngle.Size = new System.Drawing.Size(192, 62);
            this.lblXAngle.TabIndex = 17;
            this.lblXAngle.Text = "000000";
            this.lblXAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(716, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 48);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetLimit
            // 
            this.btnSetLimit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetLimit.BackgroundImage")));
            this.btnSetLimit.Location = new System.Drawing.Point(508, 600);
            this.btnSetLimit.Name = "btnSetLimit";
            this.btnSetLimit.Size = new System.Drawing.Size(132, 48);
            this.btnSetLimit.TabIndex = 14;
            this.btnSetLimit.UseVisualStyleBackColor = true;
            this.btnSetLimit.Click += new System.EventHandler(this.btnSetLimit_Click);
            // 
            // btnLowRangeCalibration
            // 
            this.btnLowRangeCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLowRangeCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowRangeCalibration.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLowRangeCalibration.Image = ((System.Drawing.Image)(resources.GetObject("btnLowRangeCalibration.Image")));
            this.btnLowRangeCalibration.Location = new System.Drawing.Point(303, 172);
            this.btnLowRangeCalibration.Name = "btnLowRangeCalibration";
            this.btnLowRangeCalibration.Size = new System.Drawing.Size(170, 62);
            this.btnLowRangeCalibration.TabIndex = 13;
            this.btnLowRangeCalibration.UseVisualStyleBackColor = false;
            this.btnLowRangeCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.Location = new System.Drawing.Point(26, 600);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(132, 48);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Controller
            // 
            this.Controller.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Controller_DataReceived);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.Location = new System.Drawing.Point(716, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 67);
            this.lblStatus.TabIndex = 151;
            // 
            // btnHighRangeCalib
            // 
            this.btnHighRangeCalib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHighRangeCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighRangeCalib.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnHighRangeCalib.Image = ((System.Drawing.Image)(resources.GetObject("btnHighRangeCalib.Image")));
            this.btnHighRangeCalib.Location = new System.Drawing.Point(81, 172);
            this.btnHighRangeCalib.Name = "btnHighRangeCalib";
            this.btnHighRangeCalib.Size = new System.Drawing.Size(170, 62);
            this.btnHighRangeCalib.TabIndex = 152;
            this.btnHighRangeCalib.UseVisualStyleBackColor = false;
            this.btnHighRangeCalib.Click += new System.EventHandler(this.btnHighRangeCalib_Click);
            // 
            // tmrCheckCommunication
            // 
            this.tmrCheckCommunication.Tick += new System.EventHandler(this.tmrCheckCommunication_Tick);
            // 
            // btnCalibration
            // 
            this.btnCalibration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalibration.BackgroundImage")));
            this.btnCalibration.Location = new System.Drawing.Point(254, 600);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(147, 48);
            this.btnCalibration.TabIndex = 153;
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click_1);
            // 
            // pnlCalibScreen
            // 
            this.pnlCalibScreen.Controls.Add(this.panel2);
            this.pnlCalibScreen.Controls.Add(this.label5);
            this.pnlCalibScreen.Controls.Add(this.btnExit);
            this.pnlCalibScreen.Controls.Add(this.panel4);
            this.pnlCalibScreen.Controls.Add(this.panel5);
            this.pnlCalibScreen.Controls.Add(this.panel3);
            this.pnlCalibScreen.Controls.Add(this.btnHighRangeCalib);
            this.pnlCalibScreen.Controls.Add(this.btnLowRangeCalibration);
            this.pnlCalibScreen.Controls.Add(this.label2);
            this.pnlCalibScreen.Location = new System.Drawing.Point(50, 28400);
            this.pnlCalibScreen.Name = "pnlCalibScreen";
            this.pnlCalibScreen.Size = new System.Drawing.Size(776, 311);
            this.pnlCalibScreen.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LawnGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 55);
            this.panel2.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calibration Screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(56, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(680, 39);
            this.label5.TabIndex = 162;
            this.label5.Text = " Note: Based on selection calibration screen will show.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(531, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 62);
            this.btnExit.TabIndex = 161;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LawnGreen;
            this.panel4.Location = new System.Drawing.Point(757, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 287);
            this.panel4.TabIndex = 159;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LawnGreen;
            this.panel5.Location = new System.Drawing.Point(0, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 263);
            this.panel5.TabIndex = 156;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LawnGreen;
            this.panel3.Location = new System.Drawing.Point(-1, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 13);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 96);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do You Want to Calibrate High Range Or Low Range Please Select.....!!!!!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(629, 28);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(219, 38);
            this.lblDateTime.TabIndex = 155;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(247, 487);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(539, 52);
            this.lblMsg.TabIndex = 614;
            this.lblMsg.Text = "CheckCommunication...!!!";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMsg.Visible = false;
            // 
            // tmrContinousSendData
            // 
            this.tmrContinousSendData.Enabled = true;
            this.tmrContinousSendData.Interval = 50;
            this.tmrContinousSendData.Tick += new System.EventHandler(this.tmrContinousSendData_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tmrTestSelection
            // 
            this.tmrTestSelection.Tick += new System.EventHandler(this.tmrTestSelection_Tick);
            // 
            // lblTareMsg
            // 
            this.lblTareMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTareMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblTareMsg.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTareMsg.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTareMsg.Location = new System.Drawing.Point(334, 487);
            this.lblTareMsg.Name = "lblTareMsg";
            this.lblTareMsg.Size = new System.Drawing.Size(224, 68);
            this.lblTareMsg.TabIndex = 619;
            this.lblTareMsg.Text = "Tare...!!!!";
            this.lblTareMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTareMsg.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.lblDisplay);
            this.tabPage1.Controls.Add(this.RbHighRange);
            this.tabPage1.Controls.Add(this.RbLowRange);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RS232";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(6, 94);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(313, 40);
            this.lblDisplay.TabIndex = 620;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RbHighRange
            // 
            this.RbHighRange.AutoSize = true;
            this.RbHighRange.BackColor = System.Drawing.Color.Transparent;
            this.RbHighRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbHighRange.ForeColor = System.Drawing.Color.Black;
            this.RbHighRange.Location = new System.Drawing.Point(71, 58);
            this.RbHighRange.Name = "RbHighRange";
            this.RbHighRange.Size = new System.Drawing.Size(124, 28);
            this.RbHighRange.TabIndex = 619;
            this.RbHighRange.Text = "HighRange";
            this.RbHighRange.UseVisualStyleBackColor = false;
            this.RbHighRange.CheckedChanged += new System.EventHandler(this.RbHighRange_CheckedChanged);
            // 
            // RbLowRange
            // 
            this.RbLowRange.AutoSize = true;
            this.RbLowRange.BackColor = System.Drawing.Color.Transparent;
            this.RbLowRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbLowRange.ForeColor = System.Drawing.Color.Black;
            this.RbLowRange.Location = new System.Drawing.Point(71, 14);
            this.RbLowRange.Name = "RbLowRange";
            this.RbLowRange.Size = new System.Drawing.Size(119, 28);
            this.RbLowRange.TabIndex = 618;
            this.RbLowRange.Text = "LowRange";
            this.RbLowRange.UseVisualStyleBackColor = false;
            this.RbLowRange.CheckedChanged += new System.EventHandler(this.RbLowRange_CheckedChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 182);
            this.tabControl1.TabIndex = 618;
            // 
            // btnYAngleHRTare
            // 
            this.btnYAngleHRTare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYAngleHRTare.BackgroundImage")));
            this.btnYAngleHRTare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYAngleHRTare.Image = ((System.Drawing.Image)(resources.GetObject("btnYAngleHRTare.Image")));
            this.btnYAngleHRTare.Location = new System.Drawing.Point(573, 402);
            this.btnYAngleHRTare.Name = "btnYAngleHRTare";
            this.btnYAngleHRTare.Size = new System.Drawing.Size(133, 44);
            this.btnYAngleHRTare.TabIndex = 621;
            this.btnYAngleHRTare.UseVisualStyleBackColor = true;
            this.btnYAngleHRTare.Visible = false;
            this.btnYAngleHRTare.Click += new System.EventHandler(this.btnYAngleHRTare_Click);
            // 
            // btnXAngleHRTare
            // 
            this.btnXAngleHRTare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAngleHRTare.Image = ((System.Drawing.Image)(resources.GetObject("btnXAngleHRTare.Image")));
            this.btnXAngleHRTare.Location = new System.Drawing.Point(573, 336);
            this.btnXAngleHRTare.Name = "btnXAngleHRTare";
            this.btnXAngleHRTare.Size = new System.Drawing.Size(133, 44);
            this.btnXAngleHRTare.TabIndex = 620;
            this.btnXAngleHRTare.UseVisualStyleBackColor = true;
            this.btnXAngleHRTare.Visible = false;
            this.btnXAngleHRTare.Click += new System.EventHandler(this.btnXAngleHRTare_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(720, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 622;
            this.label3.Text = "Version  1.0";
            // 
            // lblHeader2
            // 
            this.lblHeader2.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader2.Location = new System.Drawing.Point(285, 39);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(385, 31);
            this.lblHeader2.TabIndex = 624;
            this.lblHeader2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader2.Visible = false;
            // 
            // lblHeader1
            // 
            this.lblHeader1.BackColor = System.Drawing.Color.SlateBlue;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader1.Location = new System.Drawing.Point(207, 25);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(421, 40);
            this.lblHeader1.TabIndex = 623;
            this.lblHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
            this.pblogo.Location = new System.Drawing.Point(7, 7);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(173, 65);
            this.pblogo.TabIndex = 625;
            this.pblogo.TabStop = false;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 660);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pnlCalibScreen);
            this.Controls.Add(this.btnCalibration);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnYAngleTare);
            this.Controls.Add(this.btnXAngleTare);
            this.Controls.Add(this.lblYAngle);
            this.Controls.Add(this.lblXAngle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSetLimit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnYAngleHRTare);
            this.Controls.Add(this.btnXAngleHRTare);
            this.Controls.Add(this.lblTareMsg);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.pnlCalibScreen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYAngleTare;
        private System.Windows.Forms.Button btnXAngleTare;
        private System.Windows.Forms.Label lblYAngle;
        private System.Windows.Forms.Label lblXAngle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSetLimit;
        private System.Windows.Forms.Button btnLowRangeCalibration;
        private System.Windows.Forms.Button btnSettings;
        private System.IO.Ports.SerialPort Controller;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHighRangeCalib;
        private System.Windows.Forms.Timer tmrCheckCommunication;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Panel pnlCalibScreen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tmrDateTime;
        internal System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer tmrContinousSendData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer tmrTestSelection;
        internal System.Windows.Forms.Label lblTareMsg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.RadioButton RbHighRange;
        private System.Windows.Forms.RadioButton RbLowRange;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnYAngleHRTare;
        private System.Windows.Forms.Button btnXAngleHRTare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.PictureBox pblogo;
    }
}

