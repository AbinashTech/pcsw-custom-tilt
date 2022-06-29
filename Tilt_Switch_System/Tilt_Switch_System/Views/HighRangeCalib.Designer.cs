namespace Tilt_Switch_System.Views
{
    partial class HighRangeCalib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighRangeCalib));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTareBoth = new System.Windows.Forms.Button();
            this.btnTareYWrite = new System.Windows.Forms.Button();
            this.btnTareXWrite = new System.Windows.Forms.Button();
            this.btnZMaxWrite = new System.Windows.Forms.Button();
            this.btnZMinWrite = new System.Windows.Forms.Button();
            this.btnYMaxWrite = new System.Windows.Forms.Button();
            this.btnZMaxEdit = new System.Windows.Forms.Button();
            this.btnZMinEdit = new System.Windows.Forms.Button();
            this.btnYMaxEdit = new System.Windows.Forms.Button();
            this.btnZMaxRead = new System.Windows.Forms.Button();
            this.btnZMinRead = new System.Windows.Forms.Button();
            this.btnYMaxRead = new System.Windows.Forms.Button();
            this.txtZMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYMinWrite = new System.Windows.Forms.Button();
            this.btnXMaxWrite = new System.Windows.Forms.Button();
            this.btnXMinWrite = new System.Windows.Forms.Button();
            this.btnYMinEdit = new System.Windows.Forms.Button();
            this.btnXMaxEdit = new System.Windows.Forms.Button();
            this.btnXMinEdit = new System.Windows.Forms.Button();
            this.btnYMinRead = new System.Windows.Forms.Button();
            this.btnXMaxRead = new System.Windows.Forms.Button();
            this.btnXMinRead = new System.Windows.Forms.Button();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.lblRefLoad = new System.Windows.Forms.Label();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.lblCalSpan = new System.Windows.Forms.Label();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.lblCalZero = new System.Windows.Forms.Label();
            this.ComHighCalib = new System.IO.Ports.SerialPort(this.components);
            this.TmrCommunication = new System.Windows.Forms.Timer(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblXRawadc = new System.Windows.Forms.Label();
            this.tmrContinousSendData = new System.Windows.Forms.Timer(this.components);
            this.CmbCalibSelect = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblHeader1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(636, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 44);
            this.btnClose.TabIndex = 573;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(336, 608);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 44);
            this.btnUpdate.TabIndex = 572;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTareBoth
            // 
            this.btnTareBoth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTareBoth.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnTareBoth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTareBoth.Image = ((System.Drawing.Image)(resources.GetObject("btnTareBoth.Image")));
            this.btnTareBoth.Location = new System.Drawing.Point(79, 608);
            this.btnTareBoth.Name = "btnTareBoth";
            this.btnTareBoth.Size = new System.Drawing.Size(132, 44);
            this.btnTareBoth.TabIndex = 571;
            this.btnTareBoth.UseVisualStyleBackColor = false;
            this.btnTareBoth.Click += new System.EventHandler(this.btnTareBoth_Click);
            // 
            // btnTareYWrite
            // 
            this.btnTareYWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTareYWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnTareYWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTareYWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnTareYWrite.Image")));
            this.btnTareYWrite.Location = new System.Drawing.Point(451, 523);
            this.btnTareYWrite.Name = "btnTareYWrite";
            this.btnTareYWrite.Size = new System.Drawing.Size(135, 43);
            this.btnTareYWrite.TabIndex = 568;
            this.btnTareYWrite.UseVisualStyleBackColor = false;
            this.btnTareYWrite.Click += new System.EventHandler(this.btnTareYWrite_Click);
            // 
            // btnTareXWrite
            // 
            this.btnTareXWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTareXWrite.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnTareXWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnTareXWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTareXWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnTareXWrite.Image")));
            this.btnTareXWrite.Location = new System.Drawing.Point(289, 523);
            this.btnTareXWrite.Name = "btnTareXWrite";
            this.btnTareXWrite.Size = new System.Drawing.Size(135, 43);
            this.btnTareXWrite.TabIndex = 567;
            this.btnTareXWrite.UseVisualStyleBackColor = false;
            this.btnTareXWrite.Click += new System.EventHandler(this.btnTareXWrite_Click);
            // 
            // btnZMaxWrite
            // 
            this.btnZMaxWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZMaxWrite.Enabled = false;
            this.btnZMaxWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnZMaxWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZMaxWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnZMaxWrite.Image")));
            this.btnZMaxWrite.Location = new System.Drawing.Point(639, 471);
            this.btnZMaxWrite.Name = "btnZMaxWrite";
            this.btnZMaxWrite.Size = new System.Drawing.Size(135, 43);
            this.btnZMaxWrite.TabIndex = 557;
            this.btnZMaxWrite.UseVisualStyleBackColor = false;
            this.btnZMaxWrite.Click += new System.EventHandler(this.btnZMaxWrite_Click);
            // 
            // btnZMinWrite
            // 
            this.btnZMinWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZMinWrite.Enabled = false;
            this.btnZMinWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnZMinWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZMinWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnZMinWrite.Image")));
            this.btnZMinWrite.Location = new System.Drawing.Point(639, 420);
            this.btnZMinWrite.Name = "btnZMinWrite";
            this.btnZMinWrite.Size = new System.Drawing.Size(135, 43);
            this.btnZMinWrite.TabIndex = 556;
            this.btnZMinWrite.UseVisualStyleBackColor = false;
            this.btnZMinWrite.Click += new System.EventHandler(this.btnZMinWrite_Click);
            // 
            // btnYMaxWrite
            // 
            this.btnYMaxWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYMaxWrite.Enabled = false;
            this.btnYMaxWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnYMaxWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYMaxWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnYMaxWrite.Image")));
            this.btnYMaxWrite.Location = new System.Drawing.Point(639, 358);
            this.btnYMaxWrite.Name = "btnYMaxWrite";
            this.btnYMaxWrite.Size = new System.Drawing.Size(135, 43);
            this.btnYMaxWrite.TabIndex = 555;
            this.btnYMaxWrite.UseVisualStyleBackColor = false;
            this.btnYMaxWrite.Click += new System.EventHandler(this.btnYMaxWrite_Click);
            // 
            // btnZMaxEdit
            // 
            this.btnZMaxEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZMaxEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnZMaxEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZMaxEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnZMaxEdit.Image")));
            this.btnZMaxEdit.Location = new System.Drawing.Point(504, 472);
            this.btnZMaxEdit.Name = "btnZMaxEdit";
            this.btnZMaxEdit.Size = new System.Drawing.Size(113, 42);
            this.btnZMaxEdit.TabIndex = 554;
            this.btnZMaxEdit.UseVisualStyleBackColor = false;
            this.btnZMaxEdit.Click += new System.EventHandler(this.btnZMaxEdit_Click);
            // 
            // btnZMinEdit
            // 
            this.btnZMinEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZMinEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnZMinEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZMinEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnZMinEdit.Image")));
            this.btnZMinEdit.Location = new System.Drawing.Point(504, 424);
            this.btnZMinEdit.Name = "btnZMinEdit";
            this.btnZMinEdit.Size = new System.Drawing.Size(113, 42);
            this.btnZMinEdit.TabIndex = 553;
            this.btnZMinEdit.UseVisualStyleBackColor = false;
            this.btnZMinEdit.Click += new System.EventHandler(this.btnZMinEdit_Click);
            // 
            // btnYMaxEdit
            // 
            this.btnYMaxEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYMaxEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnYMaxEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYMaxEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnYMaxEdit.Image")));
            this.btnYMaxEdit.Location = new System.Drawing.Point(504, 361);
            this.btnYMaxEdit.Name = "btnYMaxEdit";
            this.btnYMaxEdit.Size = new System.Drawing.Size(113, 42);
            this.btnYMaxEdit.TabIndex = 552;
            this.btnYMaxEdit.UseVisualStyleBackColor = false;
            this.btnYMaxEdit.Click += new System.EventHandler(this.btnYMaxEdit_Click);
            // 
            // btnZMaxRead
            // 
            this.btnZMaxRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZMaxRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnZMaxRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZMaxRead.Image = ((System.Drawing.Image)(resources.GetObject("btnZMaxRead.Image")));
            this.btnZMaxRead.Location = new System.Drawing.Point(374, 472);
            this.btnZMaxRead.Name = "btnZMaxRead";
            this.btnZMaxRead.Size = new System.Drawing.Size(113, 42);
            this.btnZMaxRead.TabIndex = 551;
            this.btnZMaxRead.UseVisualStyleBackColor = false;
            this.btnZMaxRead.Click += new System.EventHandler(this.btnZMaxRead_Click);
            // 
            // btnZMinRead
            // 
            this.btnZMinRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZMinRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnZMinRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZMinRead.Image = ((System.Drawing.Image)(resources.GetObject("btnZMinRead.Image")));
            this.btnZMinRead.Location = new System.Drawing.Point(374, 424);
            this.btnZMinRead.Name = "btnZMinRead";
            this.btnZMinRead.Size = new System.Drawing.Size(113, 42);
            this.btnZMinRead.TabIndex = 550;
            this.btnZMinRead.UseVisualStyleBackColor = false;
            this.btnZMinRead.Click += new System.EventHandler(this.btnZMinRead_Click);
            // 
            // btnYMaxRead
            // 
            this.btnYMaxRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYMaxRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnYMaxRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYMaxRead.Image = ((System.Drawing.Image)(resources.GetObject("btnYMaxRead.Image")));
            this.btnYMaxRead.Location = new System.Drawing.Point(374, 361);
            this.btnYMaxRead.Name = "btnYMaxRead";
            this.btnYMaxRead.Size = new System.Drawing.Size(113, 42);
            this.btnYMaxRead.TabIndex = 549;
            this.btnYMaxRead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYMaxRead.UseVisualStyleBackColor = false;
            this.btnYMaxRead.Click += new System.EventHandler(this.btnYMaxRead_Click);
            // 
            // txtZMax
            // 
            this.txtZMax.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtZMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtZMax.HideSelection = false;
            this.txtZMax.Location = new System.Drawing.Point(182, 474);
            this.txtZMax.MaxLength = 4;
            this.txtZMax.Name = "txtZMax";
            this.txtZMax.Size = new System.Drawing.Size(176, 40);
            this.txtZMax.TabIndex = 548;
            this.txtZMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZMax_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(29, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 558;
            this.label1.Text = "Z Max :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtZMin
            // 
            this.txtZMin.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtZMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtZMin.HideSelection = false;
            this.txtZMin.Location = new System.Drawing.Point(182, 423);
            this.txtZMin.MaxLength = 4;
            this.txtZMin.Name = "txtZMin";
            this.txtZMin.Size = new System.Drawing.Size(176, 40);
            this.txtZMin.TabIndex = 547;
            this.txtZMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZMin_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(35, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 559;
            this.label2.Text = "Z Min :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtYMax
            // 
            this.txtYMax.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtYMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYMax.HideSelection = false;
            this.txtYMax.Location = new System.Drawing.Point(182, 364);
            this.txtYMax.MaxLength = 4;
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(176, 40);
            this.txtYMax.TabIndex = 546;
            this.txtYMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYMax_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(35, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 560;
            this.label3.Text = "Y Max :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnYMinWrite
            // 
            this.btnYMinWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYMinWrite.Enabled = false;
            this.btnYMinWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnYMinWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYMinWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnYMinWrite.Image")));
            this.btnYMinWrite.Location = new System.Drawing.Point(639, 305);
            this.btnYMinWrite.Name = "btnYMinWrite";
            this.btnYMinWrite.Size = new System.Drawing.Size(135, 43);
            this.btnYMinWrite.TabIndex = 542;
            this.btnYMinWrite.UseVisualStyleBackColor = false;
            this.btnYMinWrite.Click += new System.EventHandler(this.btnYMinWrite_Click);
            // 
            // btnXMaxWrite
            // 
            this.btnXMaxWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXMaxWrite.Enabled = false;
            this.btnXMaxWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnXMaxWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXMaxWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnXMaxWrite.Image")));
            this.btnXMaxWrite.Location = new System.Drawing.Point(639, 251);
            this.btnXMaxWrite.Name = "btnXMaxWrite";
            this.btnXMaxWrite.Size = new System.Drawing.Size(135, 43);
            this.btnXMaxWrite.TabIndex = 541;
            this.btnXMaxWrite.UseVisualStyleBackColor = false;
            this.btnXMaxWrite.Click += new System.EventHandler(this.btnXMaxWrite_Click);
            // 
            // btnXMinWrite
            // 
            this.btnXMinWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXMinWrite.Enabled = false;
            this.btnXMinWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnXMinWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXMinWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnXMinWrite.Image")));
            this.btnXMinWrite.Location = new System.Drawing.Point(639, 193);
            this.btnXMinWrite.Name = "btnXMinWrite";
            this.btnXMinWrite.Size = new System.Drawing.Size(135, 43);
            this.btnXMinWrite.TabIndex = 540;
            this.btnXMinWrite.UseVisualStyleBackColor = false;
            this.btnXMinWrite.Click += new System.EventHandler(this.btnXMinWrite_Click);
            // 
            // btnYMinEdit
            // 
            this.btnYMinEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYMinEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnYMinEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYMinEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnYMinEdit.Image")));
            this.btnYMinEdit.Location = new System.Drawing.Point(504, 306);
            this.btnYMinEdit.Name = "btnYMinEdit";
            this.btnYMinEdit.Size = new System.Drawing.Size(113, 42);
            this.btnYMinEdit.TabIndex = 539;
            this.btnYMinEdit.UseVisualStyleBackColor = false;
            this.btnYMinEdit.Click += new System.EventHandler(this.btnYMinEdit_Click);
            // 
            // btnXMaxEdit
            // 
            this.btnXMaxEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXMaxEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnXMaxEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXMaxEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnXMaxEdit.Image")));
            this.btnXMaxEdit.Location = new System.Drawing.Point(504, 255);
            this.btnXMaxEdit.Name = "btnXMaxEdit";
            this.btnXMaxEdit.Size = new System.Drawing.Size(113, 42);
            this.btnXMaxEdit.TabIndex = 538;
            this.btnXMaxEdit.UseVisualStyleBackColor = false;
            this.btnXMaxEdit.Click += new System.EventHandler(this.btnXMaxEdit_Click);
            // 
            // btnXMinEdit
            // 
            this.btnXMinEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXMinEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnXMinEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXMinEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnXMinEdit.Image")));
            this.btnXMinEdit.Location = new System.Drawing.Point(504, 196);
            this.btnXMinEdit.Name = "btnXMinEdit";
            this.btnXMinEdit.Size = new System.Drawing.Size(113, 42);
            this.btnXMinEdit.TabIndex = 537;
            this.btnXMinEdit.UseVisualStyleBackColor = false;
            this.btnXMinEdit.Click += new System.EventHandler(this.btnXMinEdit_Click);
            // 
            // btnYMinRead
            // 
            this.btnYMinRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYMinRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnYMinRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYMinRead.Image = ((System.Drawing.Image)(resources.GetObject("btnYMinRead.Image")));
            this.btnYMinRead.Location = new System.Drawing.Point(374, 306);
            this.btnYMinRead.Name = "btnYMinRead";
            this.btnYMinRead.Size = new System.Drawing.Size(113, 42);
            this.btnYMinRead.TabIndex = 536;
            this.btnYMinRead.UseVisualStyleBackColor = false;
            this.btnYMinRead.Click += new System.EventHandler(this.btnYMinRead_Click);
            // 
            // btnXMaxRead
            // 
            this.btnXMaxRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXMaxRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnXMaxRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXMaxRead.Image = ((System.Drawing.Image)(resources.GetObject("btnXMaxRead.Image")));
            this.btnXMaxRead.Location = new System.Drawing.Point(374, 255);
            this.btnXMaxRead.Name = "btnXMaxRead";
            this.btnXMaxRead.Size = new System.Drawing.Size(113, 42);
            this.btnXMaxRead.TabIndex = 535;
            this.btnXMaxRead.UseVisualStyleBackColor = false;
            this.btnXMaxRead.Click += new System.EventHandler(this.btnXMaxRead_Click);
            // 
            // btnXMinRead
            // 
            this.btnXMinRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXMinRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnXMinRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXMinRead.Image = ((System.Drawing.Image)(resources.GetObject("btnXMinRead.Image")));
            this.btnXMinRead.Location = new System.Drawing.Point(374, 196);
            this.btnXMinRead.Name = "btnXMinRead";
            this.btnXMinRead.Size = new System.Drawing.Size(113, 42);
            this.btnXMinRead.TabIndex = 534;
            this.btnXMinRead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXMinRead.UseVisualStyleBackColor = false;
            this.btnXMinRead.Click += new System.EventHandler(this.btnXMinRead_Click);
            // 
            // txtYMin
            // 
            this.txtYMin.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtYMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYMin.HideSelection = false;
            this.txtYMin.Location = new System.Drawing.Point(182, 308);
            this.txtYMin.MaxLength = 4;
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(176, 40);
            this.txtYMin.TabIndex = 533;
            this.txtYMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYMin_KeyPress);
            // 
            // lblRefLoad
            // 
            this.lblRefLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblRefLoad.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblRefLoad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRefLoad.Location = new System.Drawing.Point(29, 311);
            this.lblRefLoad.Name = "lblRefLoad";
            this.lblRefLoad.Size = new System.Drawing.Size(141, 37);
            this.lblRefLoad.TabIndex = 543;
            this.lblRefLoad.Text = "Y Min :";
            this.lblRefLoad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtXMax
            // 
            this.txtXMax.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtXMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtXMax.HideSelection = false;
            this.txtXMax.Location = new System.Drawing.Point(182, 254);
            this.txtXMax.MaxLength = 4;
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(176, 40);
            this.txtXMax.TabIndex = 532;
            this.txtXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXMax_KeyPress);
            // 
            // lblCalSpan
            // 
            this.lblCalSpan.BackColor = System.Drawing.Color.Transparent;
            this.lblCalSpan.Font = new System.Drawing.Font("Arial", 16F);
            this.lblCalSpan.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCalSpan.Location = new System.Drawing.Point(35, 262);
            this.lblCalSpan.Name = "lblCalSpan";
            this.lblCalSpan.Size = new System.Drawing.Size(135, 30);
            this.lblCalSpan.TabIndex = 544;
            this.lblCalSpan.Text = "X Max :";
            this.lblCalSpan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtXMin
            // 
            this.txtXMin.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtXMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtXMin.HideSelection = false;
            this.txtXMin.Location = new System.Drawing.Point(182, 199);
            this.txtXMin.MaxLength = 4;
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(176, 40);
            this.txtXMin.TabIndex = 531;
            this.txtXMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXMin_KeyPress);
            // 
            // lblCalZero
            // 
            this.lblCalZero.BackColor = System.Drawing.Color.Transparent;
            this.lblCalZero.Font = new System.Drawing.Font("Arial", 16F);
            this.lblCalZero.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCalZero.Location = new System.Drawing.Point(35, 205);
            this.lblCalZero.Name = "lblCalZero";
            this.lblCalZero.Size = new System.Drawing.Size(135, 31);
            this.lblCalZero.TabIndex = 545;
            this.lblCalZero.Text = "X Min :";
            this.lblCalZero.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComHighCalib
            // 
            this.ComHighCalib.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ComCalib_DataReceived);
            // 
            // TmrCommunication
            // 
            this.TmrCommunication.Interval = 1;
            this.TmrCommunication.Tick += new System.EventHandler(this.TmrCommunication_Tick);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Green;
            this.lblMsg.Location = new System.Drawing.Point(226, 569);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(431, 38);
            this.lblMsg.TabIndex = 613;
            this.lblMsg.Text = "Downloaded Successfully..!!!!";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(227, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 32);
            this.label4.TabIndex = 616;
            this.label4.Text = "High Range Calibration";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.Location = new System.Drawing.Point(10, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 78);
            this.lblStatus.TabIndex = 620;
            // 
            // lblXRawadc
            // 
            this.lblXRawadc.BackColor = System.Drawing.Color.Black;
            this.lblXRawadc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXRawadc.ForeColor = System.Drawing.Color.Lime;
            this.lblXRawadc.Location = new System.Drawing.Point(343, 125);
            this.lblXRawadc.Name = "lblXRawadc";
            this.lblXRawadc.Size = new System.Drawing.Size(144, 47);
            this.lblXRawadc.TabIndex = 623;
            this.lblXRawadc.Text = "0000";
            this.lblXRawadc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblXRawadc.Click += new System.EventHandler(this.lblXRawadc_Click);
            // 
            // tmrContinousSendData
            // 
            this.tmrContinousSendData.Interval = 50;
            this.tmrContinousSendData.Tick += new System.EventHandler(this.tmrContinousSendData_Tick);
            // 
            // CmbCalibSelect
            // 
            this.CmbCalibSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCalibSelect.FormattingEnabled = true;
            this.CmbCalibSelect.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.CmbCalibSelect.Location = new System.Drawing.Point(269, 129);
            this.CmbCalibSelect.Name = "CmbCalibSelect";
            this.CmbCalibSelect.Size = new System.Drawing.Size(53, 39);
            this.CmbCalibSelect.TabIndex = 624;
            this.CmbCalibSelect.SelectedIndexChanged += new System.EventHandler(this.CmbCalibSelect_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.AutoEllipsis = true;
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStart.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnStart.Location = new System.Drawing.Point(504, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 34);
            this.btnStart.TabIndex = 627;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnstop
            // 
            this.btnstop.AutoEllipsis = true;
            this.btnstop.BackColor = System.Drawing.Color.Black;
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnstop.FlatAppearance.BorderSize = 2;
            this.btnstop.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnstop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnstop.Location = new System.Drawing.Point(626, 134);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(99, 34);
            this.btnstop.TabIndex = 626;
            this.btnstop.Text = "Stop";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.Location = new System.Drawing.Point(7, 7);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(173, 65);
            this.pblogo.TabIndex = 628;
            this.pblogo.TabStop = false;
            // 
            // lblHeader1
            // 
            this.lblHeader1.BackColor = System.Drawing.Color.SlateBlue;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader1.Location = new System.Drawing.Point(186, 23);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(561, 39);
            this.lblHeader1.TabIndex = 629;
            this.lblHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighRangeCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 660);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.CmbCalibSelect);
            this.Controls.Add(this.lblXRawadc);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTareBoth);
            this.Controls.Add(this.btnTareYWrite);
            this.Controls.Add(this.btnTareXWrite);
            this.Controls.Add(this.btnZMaxWrite);
            this.Controls.Add(this.btnZMinWrite);
            this.Controls.Add(this.btnYMaxWrite);
            this.Controls.Add(this.btnZMaxEdit);
            this.Controls.Add(this.btnZMinEdit);
            this.Controls.Add(this.btnYMaxEdit);
            this.Controls.Add(this.btnZMaxRead);
            this.Controls.Add(this.btnZMinRead);
            this.Controls.Add(this.btnYMaxRead);
            this.Controls.Add(this.txtZMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYMinWrite);
            this.Controls.Add(this.btnXMaxWrite);
            this.Controls.Add(this.btnXMinWrite);
            this.Controls.Add(this.btnYMinEdit);
            this.Controls.Add(this.btnXMaxEdit);
            this.Controls.Add(this.btnXMinEdit);
            this.Controls.Add(this.btnYMinRead);
            this.Controls.Add(this.btnXMaxRead);
            this.Controls.Add(this.btnXMinRead);
            this.Controls.Add(this.txtYMin);
            this.Controls.Add(this.lblRefLoad);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.lblCalSpan);
            this.Controls.Add(this.txtXMin);
            this.Controls.Add(this.lblCalZero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HighRangeCalib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighRangeCalib";
            this.Load += new System.EventHandler(this.HighRangeCalib_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTareBoth;
        private System.Windows.Forms.Button btnTareYWrite;
        private System.Windows.Forms.Button btnTareXWrite;
        private System.Windows.Forms.Button btnZMaxWrite;
        private System.Windows.Forms.Button btnZMinWrite;
        private System.Windows.Forms.Button btnYMaxWrite;
        private System.Windows.Forms.Button btnZMaxEdit;
        private System.Windows.Forms.Button btnZMinEdit;
        private System.Windows.Forms.Button btnYMaxEdit;
        private System.Windows.Forms.Button btnZMaxRead;
        private System.Windows.Forms.Button btnZMinRead;
        private System.Windows.Forms.Button btnYMaxRead;
        private System.Windows.Forms.TextBox txtZMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYMinWrite;
        private System.Windows.Forms.Button btnXMaxWrite;
        private System.Windows.Forms.Button btnXMinWrite;
        private System.Windows.Forms.Button btnYMinEdit;
        private System.Windows.Forms.Button btnXMaxEdit;
        private System.Windows.Forms.Button btnXMinEdit;
        private System.Windows.Forms.Button btnYMinRead;
        private System.Windows.Forms.Button btnXMaxRead;
        private System.Windows.Forms.Button btnXMinRead;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.Label lblRefLoad;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.Label lblCalSpan;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label lblCalZero;
        private System.IO.Ports.SerialPort ComHighCalib;
        private System.Windows.Forms.Timer TmrCommunication;
        internal System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblXRawadc;
        private System.Windows.Forms.Timer tmrContinousSendData;
        private System.Windows.Forms.ComboBox CmbCalibSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblHeader1;
    }
}