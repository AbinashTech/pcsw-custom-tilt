namespace Tilt_Switch_System.Views
{
    partial class LowRangeCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowRangeCalibration));
            this.btnCalCapacityYWrite = new System.Windows.Forms.Button();
            this.btnCalCapacityEditY = new System.Windows.Forms.Button();
            this.btnCalCapacityY = new System.Windows.Forms.Button();
            this.txtCalCapacityY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalSpanYWrite = new System.Windows.Forms.Button();
            this.btnCalZeroYWrite = new System.Windows.Forms.Button();
            this.btnLowRangeTareWrite = new System.Windows.Forms.Button();
            this.btnCalSpanEditY = new System.Windows.Forms.Button();
            this.btnCalZeroEditY = new System.Windows.Forms.Button();
            this.btnCalSpanY = new System.Windows.Forms.Button();
            this.btnCalZeroY = new System.Windows.Forms.Button();
            this.txtCalSpanY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalZeroY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalCapacityWrite = new System.Windows.Forms.Button();
            this.btnCalSpanWrite = new System.Windows.Forms.Button();
            this.btnCalZeroWrite = new System.Windows.Forms.Button();
            this.btnCalCapacityEdit = new System.Windows.Forms.Button();
            this.btnCalSpanEdit = new System.Windows.Forms.Button();
            this.btnCalZeroEdit = new System.Windows.Forms.Button();
            this.btnCalCapacityRead = new System.Windows.Forms.Button();
            this.btnCalSpanRead = new System.Windows.Forms.Button();
            this.btnCalZeroRead = new System.Windows.Forms.Button();
            this.txtCalcapacity = new System.Windows.Forms.TextBox();
            this.lblRefLoad = new System.Windows.Forms.Label();
            this.txtCalSpan = new System.Windows.Forms.TextBox();
            this.lblCalSpan = new System.Windows.Forms.Label();
            this.txtCalZero = new System.Windows.Forms.TextBox();
            this.lblCalZero = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ComCalib = new System.IO.Ports.SerialPort(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.TmrCommunication = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.btnTareY = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.CmbCalibSelect = new System.Windows.Forms.ComboBox();
            this.lblXRawadc = new System.Windows.Forms.Label();
            this.tmrContinousSendData = new System.Windows.Forms.Timer(this.components);
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblHeader1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalCapacityYWrite
            // 
            this.btnCalCapacityYWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalCapacityYWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityYWrite.BackgroundImage")));
            this.btnCalCapacityYWrite.Enabled = false;
            this.btnCalCapacityYWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalCapacityYWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalCapacityYWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityYWrite.Image")));
            this.btnCalCapacityYWrite.Location = new System.Drawing.Point(690, 506);
            this.btnCalCapacityYWrite.Name = "btnCalCapacityYWrite";
            this.btnCalCapacityYWrite.Size = new System.Drawing.Size(135, 43);
            this.btnCalCapacityYWrite.TabIndex = 607;
            this.btnCalCapacityYWrite.UseVisualStyleBackColor = false;
            this.btnCalCapacityYWrite.Click += new System.EventHandler(this.btnCalCapacityYWrite_Click);
            // 
            // btnCalCapacityEditY
            // 
            this.btnCalCapacityEditY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalCapacityEditY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalCapacityEditY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalCapacityEditY.Image = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityEditY.Image")));
            this.btnCalCapacityEditY.Location = new System.Drawing.Point(555, 509);
            this.btnCalCapacityEditY.Name = "btnCalCapacityEditY";
            this.btnCalCapacityEditY.Size = new System.Drawing.Size(113, 42);
            this.btnCalCapacityEditY.TabIndex = 605;
            this.btnCalCapacityEditY.UseVisualStyleBackColor = false;
            this.btnCalCapacityEditY.Click += new System.EventHandler(this.btnCalCapacityEditY_Click);
            // 
            // btnCalCapacityY
            // 
            this.btnCalCapacityY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalCapacityY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalCapacityY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalCapacityY.Image = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityY.Image")));
            this.btnCalCapacityY.Location = new System.Drawing.Point(425, 509);
            this.btnCalCapacityY.Name = "btnCalCapacityY";
            this.btnCalCapacityY.Size = new System.Drawing.Size(113, 42);
            this.btnCalCapacityY.TabIndex = 603;
            this.btnCalCapacityY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalCapacityY.UseVisualStyleBackColor = false;
            this.btnCalCapacityY.Click += new System.EventHandler(this.btnCalCapacityY_Click);
            // 
            // txtCalCapacityY
            // 
            this.txtCalCapacityY.Enabled = false;
            this.txtCalCapacityY.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalCapacityY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalCapacityY.HideSelection = false;
            this.txtCalCapacityY.Location = new System.Drawing.Point(233, 512);
            this.txtCalCapacityY.MaxLength = 4;
            this.txtCalCapacityY.Name = "txtCalCapacityY";
            this.txtCalCapacityY.Size = new System.Drawing.Size(176, 40);
            this.txtCalCapacityY.TabIndex = 601;
            this.txtCalCapacityY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalCapacityY_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(28, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 33);
            this.label6.TabIndex = 610;
            this.label6.Text = "CAL CAPACITY-Y :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalSpanYWrite
            // 
            this.btnCalSpanYWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalSpanYWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalSpanYWrite.BackgroundImage")));
            this.btnCalSpanYWrite.Enabled = false;
            this.btnCalSpanYWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalSpanYWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalSpanYWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnCalSpanYWrite.Image")));
            this.btnCalSpanYWrite.Location = new System.Drawing.Point(690, 460);
            this.btnCalSpanYWrite.Name = "btnCalSpanYWrite";
            this.btnCalSpanYWrite.Size = new System.Drawing.Size(135, 43);
            this.btnCalSpanYWrite.TabIndex = 597;
            this.btnCalSpanYWrite.UseVisualStyleBackColor = false;
            this.btnCalSpanYWrite.Click += new System.EventHandler(this.btnCalSpanYWrite_Click);
            // 
            // btnCalZeroYWrite
            // 
            this.btnCalZeroYWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalZeroYWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalZeroYWrite.BackgroundImage")));
            this.btnCalZeroYWrite.Enabled = false;
            this.btnCalZeroYWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalZeroYWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalZeroYWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnCalZeroYWrite.Image")));
            this.btnCalZeroYWrite.Location = new System.Drawing.Point(690, 406);
            this.btnCalZeroYWrite.Name = "btnCalZeroYWrite";
            this.btnCalZeroYWrite.Size = new System.Drawing.Size(135, 43);
            this.btnCalZeroYWrite.TabIndex = 596;
            this.btnCalZeroYWrite.UseVisualStyleBackColor = false;
            this.btnCalZeroYWrite.Click += new System.EventHandler(this.btnCalZeroYWrite_Click);
            // 
            // btnLowRangeTareWrite
            // 
            this.btnLowRangeTareWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLowRangeTareWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnLowRangeTareWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLowRangeTareWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnLowRangeTareWrite.Image")));
            this.btnLowRangeTareWrite.Location = new System.Drawing.Point(263, 350);
            this.btnLowRangeTareWrite.Name = "btnLowRangeTareWrite";
            this.btnLowRangeTareWrite.Size = new System.Drawing.Size(135, 43);
            this.btnLowRangeTareWrite.TabIndex = 595;
            this.btnLowRangeTareWrite.UseVisualStyleBackColor = false;
            this.btnLowRangeTareWrite.Click += new System.EventHandler(this.btnLowRangeTareWrite_Click);
            // 
            // btnCalSpanEditY
            // 
            this.btnCalSpanEditY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalSpanEditY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalSpanEditY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalSpanEditY.Image = ((System.Drawing.Image)(resources.GetObject("btnCalSpanEditY.Image")));
            this.btnCalSpanEditY.Location = new System.Drawing.Point(555, 461);
            this.btnCalSpanEditY.Name = "btnCalSpanEditY";
            this.btnCalSpanEditY.Size = new System.Drawing.Size(113, 42);
            this.btnCalSpanEditY.TabIndex = 594;
            this.btnCalSpanEditY.UseVisualStyleBackColor = false;
            this.btnCalSpanEditY.Click += new System.EventHandler(this.btnCalSpanEditY_Click);
            // 
            // btnCalZeroEditY
            // 
            this.btnCalZeroEditY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalZeroEditY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalZeroEditY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalZeroEditY.Image = ((System.Drawing.Image)(resources.GetObject("btnCalZeroEditY.Image")));
            this.btnCalZeroEditY.Location = new System.Drawing.Point(555, 410);
            this.btnCalZeroEditY.Name = "btnCalZeroEditY";
            this.btnCalZeroEditY.Size = new System.Drawing.Size(113, 42);
            this.btnCalZeroEditY.TabIndex = 593;
            this.btnCalZeroEditY.UseVisualStyleBackColor = false;
            this.btnCalZeroEditY.Click += new System.EventHandler(this.btnCalZeroEditY_Click);
            // 
            // btnCalSpanY
            // 
            this.btnCalSpanY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalSpanY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalSpanY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalSpanY.Image = ((System.Drawing.Image)(resources.GetObject("btnCalSpanY.Image")));
            this.btnCalSpanY.Location = new System.Drawing.Point(425, 461);
            this.btnCalSpanY.Name = "btnCalSpanY";
            this.btnCalSpanY.Size = new System.Drawing.Size(113, 42);
            this.btnCalSpanY.TabIndex = 591;
            this.btnCalSpanY.UseVisualStyleBackColor = false;
            this.btnCalSpanY.Click += new System.EventHandler(this.btnCalSpanY_Click);
            // 
            // btnCalZeroY
            // 
            this.btnCalZeroY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalZeroY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalZeroY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalZeroY.Image = ((System.Drawing.Image)(resources.GetObject("btnCalZeroY.Image")));
            this.btnCalZeroY.Location = new System.Drawing.Point(425, 410);
            this.btnCalZeroY.Name = "btnCalZeroY";
            this.btnCalZeroY.Size = new System.Drawing.Size(113, 42);
            this.btnCalZeroY.TabIndex = 590;
            this.btnCalZeroY.UseVisualStyleBackColor = false;
            this.btnCalZeroY.Click += new System.EventHandler(this.btnCalZeroY_Click);
            // 
            // txtCalSpanY
            // 
            this.txtCalSpanY.Enabled = false;
            this.txtCalSpanY.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalSpanY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalSpanY.HideSelection = false;
            this.txtCalSpanY.Location = new System.Drawing.Point(233, 463);
            this.txtCalSpanY.MaxLength = 4;
            this.txtCalSpanY.Name = "txtCalSpanY";
            this.txtCalSpanY.Size = new System.Drawing.Size(176, 40);
            this.txtCalSpanY.TabIndex = 588;
            this.txtCalSpanY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalSpanY_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(28, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 598;
            this.label1.Text = "CAL SPAN-Y :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCalZeroY
            // 
            this.txtCalZeroY.Enabled = false;
            this.txtCalZeroY.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalZeroY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalZeroY.HideSelection = false;
            this.txtCalZeroY.Location = new System.Drawing.Point(233, 409);
            this.txtCalZeroY.MaxLength = 4;
            this.txtCalZeroY.Name = "txtCalZeroY";
            this.txtCalZeroY.Size = new System.Drawing.Size(176, 40);
            this.txtCalZeroY.TabIndex = 587;
            this.txtCalZeroY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalZeroY_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(28, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 33);
            this.label2.TabIndex = 599;
            this.label2.Text = "CAL ZERO-Y :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalCapacityWrite
            // 
            this.btnCalCapacityWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalCapacityWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityWrite.BackgroundImage")));
            this.btnCalCapacityWrite.Enabled = false;
            this.btnCalCapacityWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalCapacityWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalCapacityWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityWrite.Image")));
            this.btnCalCapacityWrite.Location = new System.Drawing.Point(690, 298);
            this.btnCalCapacityWrite.Name = "btnCalCapacityWrite";
            this.btnCalCapacityWrite.Size = new System.Drawing.Size(135, 43);
            this.btnCalCapacityWrite.TabIndex = 582;
            this.btnCalCapacityWrite.UseVisualStyleBackColor = false;
            this.btnCalCapacityWrite.Click += new System.EventHandler(this.btnCalCapacityWrite_Click);
            // 
            // btnCalSpanWrite
            // 
            this.btnCalSpanWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalSpanWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalSpanWrite.BackgroundImage")));
            this.btnCalSpanWrite.Enabled = false;
            this.btnCalSpanWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalSpanWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalSpanWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnCalSpanWrite.Image")));
            this.btnCalSpanWrite.Location = new System.Drawing.Point(690, 244);
            this.btnCalSpanWrite.Name = "btnCalSpanWrite";
            this.btnCalSpanWrite.Size = new System.Drawing.Size(135, 43);
            this.btnCalSpanWrite.TabIndex = 581;
            this.btnCalSpanWrite.UseVisualStyleBackColor = false;
            this.btnCalSpanWrite.Click += new System.EventHandler(this.btnCalSpanWrite_Click);
            // 
            // btnCalZeroWrite
            // 
            this.btnCalZeroWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalZeroWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalZeroWrite.BackgroundImage")));
            this.btnCalZeroWrite.Enabled = false;
            this.btnCalZeroWrite.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalZeroWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalZeroWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnCalZeroWrite.Image")));
            this.btnCalZeroWrite.Location = new System.Drawing.Point(690, 189);
            this.btnCalZeroWrite.Name = "btnCalZeroWrite";
            this.btnCalZeroWrite.Size = new System.Drawing.Size(135, 43);
            this.btnCalZeroWrite.TabIndex = 580;
            this.btnCalZeroWrite.UseVisualStyleBackColor = false;
            this.btnCalZeroWrite.Click += new System.EventHandler(this.btnCalZeroWrite_Click);
            // 
            // btnCalCapacityEdit
            // 
            this.btnCalCapacityEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalCapacityEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalCapacityEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalCapacityEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityEdit.Image")));
            this.btnCalCapacityEdit.Location = new System.Drawing.Point(555, 299);
            this.btnCalCapacityEdit.Name = "btnCalCapacityEdit";
            this.btnCalCapacityEdit.Size = new System.Drawing.Size(113, 42);
            this.btnCalCapacityEdit.TabIndex = 579;
            this.btnCalCapacityEdit.UseVisualStyleBackColor = false;
            this.btnCalCapacityEdit.Click += new System.EventHandler(this.btnCalCapacityEdit_Click);
            // 
            // btnCalSpanEdit
            // 
            this.btnCalSpanEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalSpanEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalSpanEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalSpanEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCalSpanEdit.Image")));
            this.btnCalSpanEdit.Location = new System.Drawing.Point(555, 248);
            this.btnCalSpanEdit.Name = "btnCalSpanEdit";
            this.btnCalSpanEdit.Size = new System.Drawing.Size(113, 42);
            this.btnCalSpanEdit.TabIndex = 578;
            this.btnCalSpanEdit.UseVisualStyleBackColor = false;
            this.btnCalSpanEdit.Click += new System.EventHandler(this.btnCalSpanEdit_Click);
            // 
            // btnCalZeroEdit
            // 
            this.btnCalZeroEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalZeroEdit.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalZeroEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalZeroEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCalZeroEdit.Image")));
            this.btnCalZeroEdit.Location = new System.Drawing.Point(555, 192);
            this.btnCalZeroEdit.Name = "btnCalZeroEdit";
            this.btnCalZeroEdit.Size = new System.Drawing.Size(113, 42);
            this.btnCalZeroEdit.TabIndex = 577;
            this.btnCalZeroEdit.UseVisualStyleBackColor = false;
            this.btnCalZeroEdit.Click += new System.EventHandler(this.btnCalZeroEdit_Click);
            // 
            // btnCalCapacityRead
            // 
            this.btnCalCapacityRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalCapacityRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalCapacityRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalCapacityRead.Image = ((System.Drawing.Image)(resources.GetObject("btnCalCapacityRead.Image")));
            this.btnCalCapacityRead.Location = new System.Drawing.Point(425, 299);
            this.btnCalCapacityRead.Name = "btnCalCapacityRead";
            this.btnCalCapacityRead.Size = new System.Drawing.Size(113, 42);
            this.btnCalCapacityRead.TabIndex = 576;
            this.btnCalCapacityRead.UseVisualStyleBackColor = false;
            this.btnCalCapacityRead.Click += new System.EventHandler(this.btnCalCapacityRead_Click);
            // 
            // btnCalSpanRead
            // 
            this.btnCalSpanRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalSpanRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalSpanRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalSpanRead.Image = ((System.Drawing.Image)(resources.GetObject("btnCalSpanRead.Image")));
            this.btnCalSpanRead.Location = new System.Drawing.Point(425, 248);
            this.btnCalSpanRead.Name = "btnCalSpanRead";
            this.btnCalSpanRead.Size = new System.Drawing.Size(113, 42);
            this.btnCalSpanRead.TabIndex = 575;
            this.btnCalSpanRead.UseVisualStyleBackColor = false;
            this.btnCalSpanRead.Click += new System.EventHandler(this.btnCalSpanRead_Click);
            // 
            // btnCalZeroRead
            // 
            this.btnCalZeroRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalZeroRead.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCalZeroRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalZeroRead.Image = ((System.Drawing.Image)(resources.GetObject("btnCalZeroRead.Image")));
            this.btnCalZeroRead.Location = new System.Drawing.Point(425, 192);
            this.btnCalZeroRead.Name = "btnCalZeroRead";
            this.btnCalZeroRead.Size = new System.Drawing.Size(113, 42);
            this.btnCalZeroRead.TabIndex = 574;
            this.btnCalZeroRead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalZeroRead.UseVisualStyleBackColor = false;
            this.btnCalZeroRead.Click += new System.EventHandler(this.btnCalZeroRead_Click);
            // 
            // txtCalcapacity
            // 
            this.txtCalcapacity.Enabled = false;
            this.txtCalcapacity.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalcapacity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalcapacity.HideSelection = false;
            this.txtCalcapacity.Location = new System.Drawing.Point(233, 301);
            this.txtCalcapacity.MaxLength = 2;
            this.txtCalcapacity.Name = "txtCalcapacity";
            this.txtCalcapacity.Size = new System.Drawing.Size(176, 40);
            this.txtCalcapacity.TabIndex = 573;
            this.txtCalcapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalcapacity_KeyPress);
            // 
            // lblRefLoad
            // 
            this.lblRefLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblRefLoad.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblRefLoad.ForeColor = System.Drawing.Color.Maroon;
            this.lblRefLoad.Location = new System.Drawing.Point(28, 304);
            this.lblRefLoad.Name = "lblRefLoad";
            this.lblRefLoad.Size = new System.Drawing.Size(200, 33);
            this.lblRefLoad.TabIndex = 583;
            this.lblRefLoad.Text = "CAL CAPACITY-X :";
            this.lblRefLoad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCalSpan
            // 
            this.txtCalSpan.Enabled = false;
            this.txtCalSpan.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalSpan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalSpan.HideSelection = false;
            this.txtCalSpan.Location = new System.Drawing.Point(233, 247);
            this.txtCalSpan.MaxLength = 4;
            this.txtCalSpan.Name = "txtCalSpan";
            this.txtCalSpan.Size = new System.Drawing.Size(176, 40);
            this.txtCalSpan.TabIndex = 572;
            this.txtCalSpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalSpan_KeyPress);
            // 
            // lblCalSpan
            // 
            this.lblCalSpan.BackColor = System.Drawing.Color.Transparent;
            this.lblCalSpan.Font = new System.Drawing.Font("Arial", 16F);
            this.lblCalSpan.ForeColor = System.Drawing.Color.Maroon;
            this.lblCalSpan.Location = new System.Drawing.Point(28, 255);
            this.lblCalSpan.Name = "lblCalSpan";
            this.lblCalSpan.Size = new System.Drawing.Size(200, 33);
            this.lblCalSpan.TabIndex = 584;
            this.lblCalSpan.Text = "CAL SPAN-X :";
            this.lblCalSpan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCalZero
            // 
            this.txtCalZero.Enabled = false;
            this.txtCalZero.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalZero.HideSelection = false;
            this.txtCalZero.Location = new System.Drawing.Point(233, 195);
            this.txtCalZero.MaxLength = 4;
            this.txtCalZero.Name = "txtCalZero";
            this.txtCalZero.Size = new System.Drawing.Size(176, 40);
            this.txtCalZero.TabIndex = 571;
            this.txtCalZero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalZero_KeyPress);
            // 
            // lblCalZero
            // 
            this.lblCalZero.BackColor = System.Drawing.Color.Transparent;
            this.lblCalZero.Font = new System.Drawing.Font("Arial", 16F);
            this.lblCalZero.ForeColor = System.Drawing.Color.Maroon;
            this.lblCalZero.Location = new System.Drawing.Point(28, 201);
            this.lblCalZero.Name = "lblCalZero";
            this.lblCalZero.Size = new System.Drawing.Size(200, 33);
            this.lblCalZero.TabIndex = 585;
            this.lblCalZero.Text = "CAL ZERO-X :";
            this.lblCalZero.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(480, 596);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 51);
            this.btnUpdate.TabIndex = 569;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ComCalib
            // 
            this.ComCalib.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ComCalib_DataReceived);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Green;
            this.lblMsg.Location = new System.Drawing.Point(19, 609);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(431, 38);
            this.lblMsg.TabIndex = 612;
            this.lblMsg.Text = "Downloaded Successfully..!!!!";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TmrCommunication
            // 
            this.TmrCommunication.Interval = 1;
            this.TmrCommunication.Tick += new System.EventHandler(this.TmrCommunication_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(659, 596);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 51);
            this.btnClose.TabIndex = 613;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(471, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 32);
            this.label3.TabIndex = 615;
            this.label3.Text = "Low Range Y Axis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(257, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 32);
            this.label4.TabIndex = 616;
            this.label4.Text = "Low Range X Axis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(629, 21);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(219, 38);
            this.lblDateTime.TabIndex = 617;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // btnTareY
            // 
            this.btnTareY.BackColor = System.Drawing.Color.Transparent;
            this.btnTareY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTareY.BackgroundImage")));
            this.btnTareY.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnTareY.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTareY.Image = ((System.Drawing.Image)(resources.GetObject("btnTareY.Image")));
            this.btnTareY.Location = new System.Drawing.Point(275, 558);
            this.btnTareY.Name = "btnTareY";
            this.btnTareY.Size = new System.Drawing.Size(135, 43);
            this.btnTareY.TabIndex = 618;
            this.btnTareY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTareY.UseVisualStyleBackColor = false;
            this.btnTareY.Click += new System.EventHandler(this.btnTareY_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.Location = new System.Drawing.Point(12, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 71);
            this.lblStatus.TabIndex = 619;
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
            this.btnStart.Location = new System.Drawing.Point(519, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 34);
            this.btnStart.TabIndex = 631;
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
            this.btnstop.Location = new System.Drawing.Point(641, 135);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(99, 34);
            this.btnstop.TabIndex = 630;
            this.btnstop.Text = "Stop";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // CmbCalibSelect
            // 
            this.CmbCalibSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCalibSelect.FormattingEnabled = true;
            this.CmbCalibSelect.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.CmbCalibSelect.Location = new System.Drawing.Point(284, 130);
            this.CmbCalibSelect.Name = "CmbCalibSelect";
            this.CmbCalibSelect.Size = new System.Drawing.Size(53, 39);
            this.CmbCalibSelect.TabIndex = 629;
            this.CmbCalibSelect.SelectedIndexChanged += new System.EventHandler(this.CmbCalibSelect_SelectedIndexChanged);
            // 
            // lblXRawadc
            // 
            this.lblXRawadc.BackColor = System.Drawing.Color.Black;
            this.lblXRawadc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXRawadc.ForeColor = System.Drawing.Color.Lime;
            this.lblXRawadc.Location = new System.Drawing.Point(358, 126);
            this.lblXRawadc.Name = "lblXRawadc";
            this.lblXRawadc.Size = new System.Drawing.Size(144, 47);
            this.lblXRawadc.TabIndex = 628;
            this.lblXRawadc.Text = "0000";
            this.lblXRawadc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrContinousSendData
            // 
            this.tmrContinousSendData.Interval = 250;
            this.tmrContinousSendData.Tick += new System.EventHandler(this.tmrContinousSendData_Tick);
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.Location = new System.Drawing.Point(7, 7);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(173, 65);
            this.pblogo.TabIndex = 632;
            this.pblogo.TabStop = false;
            // 
            // lblHeader1
            // 
            this.lblHeader1.BackColor = System.Drawing.Color.SlateBlue;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader1.Location = new System.Drawing.Point(195, 23);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(561, 39);
            this.lblHeader1.TabIndex = 633;
            this.lblHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowRangeCalibration
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
            this.Controls.Add(this.btnTareY);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCalCapacityYWrite);
            this.Controls.Add(this.btnCalCapacityEditY);
            this.Controls.Add(this.btnCalCapacityY);
            this.Controls.Add(this.txtCalCapacityY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalSpanYWrite);
            this.Controls.Add(this.btnCalZeroYWrite);
            this.Controls.Add(this.btnLowRangeTareWrite);
            this.Controls.Add(this.btnCalSpanEditY);
            this.Controls.Add(this.btnCalZeroEditY);
            this.Controls.Add(this.btnCalSpanY);
            this.Controls.Add(this.btnCalZeroY);
            this.Controls.Add(this.txtCalSpanY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalZeroY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalCapacityWrite);
            this.Controls.Add(this.btnCalSpanWrite);
            this.Controls.Add(this.btnCalZeroWrite);
            this.Controls.Add(this.btnCalCapacityEdit);
            this.Controls.Add(this.btnCalSpanEdit);
            this.Controls.Add(this.btnCalZeroEdit);
            this.Controls.Add(this.btnCalCapacityRead);
            this.Controls.Add(this.btnCalSpanRead);
            this.Controls.Add(this.btnCalZeroRead);
            this.Controls.Add(this.txtCalcapacity);
            this.Controls.Add(this.lblRefLoad);
            this.Controls.Add(this.txtCalSpan);
            this.Controls.Add(this.lblCalSpan);
            this.Controls.Add(this.txtCalZero);
            this.Controls.Add(this.lblCalZero);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LowRangeCalibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LowRangeCalib";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LowRangeCalibration_FormClosing);
            this.Load += new System.EventHandler(this.LowRangeCalibration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalCapacityYWrite;
        private System.Windows.Forms.Button btnCalCapacityEditY;
        private System.Windows.Forms.Button btnCalCapacityY;
        private System.Windows.Forms.TextBox txtCalCapacityY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalSpanYWrite;
        private System.Windows.Forms.Button btnCalZeroYWrite;
        private System.Windows.Forms.Button btnLowRangeTareWrite;
        private System.Windows.Forms.Button btnCalSpanEditY;
        private System.Windows.Forms.Button btnCalZeroEditY;
        private System.Windows.Forms.Button btnCalSpanY;
        private System.Windows.Forms.Button btnCalZeroY;
        private System.Windows.Forms.TextBox txtCalSpanY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalZeroY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalCapacityWrite;
        private System.Windows.Forms.Button btnCalSpanWrite;
        private System.Windows.Forms.Button btnCalZeroWrite;
        private System.Windows.Forms.Button btnCalCapacityEdit;
        private System.Windows.Forms.Button btnCalSpanEdit;
        private System.Windows.Forms.Button btnCalZeroEdit;
        private System.Windows.Forms.Button btnCalCapacityRead;
        private System.Windows.Forms.Button btnCalSpanRead;
        private System.Windows.Forms.Button btnCalZeroRead;
        private System.Windows.Forms.TextBox txtCalcapacity;
        private System.Windows.Forms.Label lblRefLoad;
        private System.Windows.Forms.TextBox txtCalSpan;
        private System.Windows.Forms.Label lblCalSpan;
        private System.Windows.Forms.TextBox txtCalZero;
        private System.Windows.Forms.Label lblCalZero;
        private System.Windows.Forms.Button btnUpdate;
        private System.IO.Ports.SerialPort ComCalib;
        internal System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer TmrCommunication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Button btnTareY;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.ComboBox CmbCalibSelect;
        private System.Windows.Forms.Label lblXRawadc;
        private System.Windows.Forms.Timer tmrContinousSendData;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblHeader1;
    }
}