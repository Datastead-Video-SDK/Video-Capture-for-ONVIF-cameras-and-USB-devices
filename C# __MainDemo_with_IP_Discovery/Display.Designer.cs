using System.Windows.Forms;

namespace MainDemo
{
    partial class Display : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkAdjustPixelAspectRatio = new System.Windows.Forms.CheckBox();
            this.chkVideoVisibleWhenStopped = new System.Windows.Forms.CheckBox();
            this.rdgVideoRenderer = new System.Windows.Forms.GroupBox();
            this.rdgVideoRendererMadVR = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererEVR = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererNone = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererOverlay = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererStandard = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererAutoSelect = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererVMR7 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererVMR9 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererRecPriority = new System.Windows.Forms.RadioButton();
            this.chkTransparency = new System.Windows.Forms.CheckBox();
            this.grbMainVideoWindow = new System.Windows.Forms.GroupBox();
            this.chkTransparentColor = new System.Windows.Forms.CheckBox();
            this.txtTransparentColor = new System.Windows.Forms.TextBox();
            this.chkAlphablend = new System.Windows.Forms.CheckBox();
            this.tbrAlphablend = new System.Windows.Forms.TrackBar();
            this.lblMonitorNumber = new System.Windows.Forms.Label();
            this.txtDisplayMonitor = new System.Windows.Forms.TextBox();
            this.btnTestPanScan = new System.Windows.Forms.Button();
            this.btnTestPanScanHelp = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkFullScreen = new System.Windows.Forms.CheckBox();
            this.chkUseVideoPort = new System.Windows.Forms.CheckBox();
            this.tbrPanScan = new System.Windows.Forms.TrackBar();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.rdgAspectRatio = new System.Windows.Forms.GroupBox();
            this.rdgDisplayAspectRatioPanScan = new System.Windows.Forms.RadioButton();
            this.rdgDisplayAspectRatioStretch = new System.Windows.Forms.RadioButton();
            this.rdgDisplayAspectRatioPan = new System.Windows.Forms.RadioButton();
            this.rdgDisplayAspectRatioBox = new System.Windows.Forms.RadioButton();
            this.chkEmbedded = new System.Windows.Forms.CheckBox();
            this.chkMouseMovesWindow = new System.Windows.Forms.CheckBox();
            this.chkStayOnTop = new System.Windows.Forms.CheckBox();
            this.chkAutoSize = new System.Windows.Forms.CheckBox();
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.btnNewLocation2 = new System.Windows.Forms.Button();
            this.chkSetLogo = new System.Windows.Forms.CheckBox();
            this.chkBorder = new System.Windows.Forms.CheckBox();
            this.chkChangeCursor = new System.Windows.Forms.CheckBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.chkBlackMagicOutput = new System.Windows.Forms.CheckBox();
            this.chkDisplayActive = new System.Windows.Forms.CheckBox();
            this.rdgDisplaySelected = new System.Windows.Forms.GroupBox();
            this.rdgSelectDisplay9 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay8 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay7 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay6 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay5 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay4 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay3 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay2 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay1 = new System.Windows.Forms.RadioButton();
            this.rdgSelectDisplay0 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRenderer.SuspendLayout();
            this.grbMainVideoWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAlphablend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPanScan)).BeginInit();
            this.rdgAspectRatio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.rdgDisplaySelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAdjustPixelAspectRatio
            // 
            this.chkAdjustPixelAspectRatio.BackColor = System.Drawing.SystemColors.Control;
            this.chkAdjustPixelAspectRatio.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAdjustPixelAspectRatio.Font = new System.Drawing.Font("Arial", 8F);
            this.chkAdjustPixelAspectRatio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAdjustPixelAspectRatio.Location = new System.Drawing.Point(213, 41);
            this.chkAdjustPixelAspectRatio.Name = "chkAdjustPixelAspectRatio";
            this.chkAdjustPixelAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAdjustPixelAspectRatio.Size = new System.Drawing.Size(181, 20);
            this.chkAdjustPixelAspectRatio.TabIndex = 53;
            this.chkAdjustPixelAspectRatio.Text = "adjust pixel aspect ratio";
            this.chkAdjustPixelAspectRatio.UseVisualStyleBackColor = false;
            this.chkAdjustPixelAspectRatio.CheckedChanged += new System.EventHandler(this.chkAdjustPixelAspectRatio_CheckedChanged);
            // 
            // chkVideoVisibleWhenStopped
            // 
            this.chkVideoVisibleWhenStopped.AutoSize = true;
            this.chkVideoVisibleWhenStopped.Location = new System.Drawing.Point(213, 23);
            this.chkVideoVisibleWhenStopped.Name = "chkVideoVisibleWhenStopped";
            this.chkVideoVisibleWhenStopped.Size = new System.Drawing.Size(199, 21);
            this.chkVideoVisibleWhenStopped.TabIndex = 52;
            this.chkVideoVisibleWhenStopped.Text = "video visible when stopped";
            this.chkVideoVisibleWhenStopped.CheckedChanged += new System.EventHandler(this.chkVideoVisibleWhenStopped_CheckedChanged);
            // 
            // rdgVideoRenderer
            // 
            this.rdgVideoRenderer.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererMadVR);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererEVR);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererNone);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererOverlay);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererStandard);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererAutoSelect);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererVMR7);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererVMR9);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererRecPriority);
            this.rdgVideoRenderer.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRenderer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRenderer.Location = new System.Drawing.Point(5, 0);
            this.rdgVideoRenderer.Name = "rdgVideoRenderer";
            this.rdgVideoRenderer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRenderer.Size = new System.Drawing.Size(202, 207);
            this.rdgVideoRenderer.TabIndex = 51;
            this.rdgVideoRenderer.TabStop = false;
            this.rdgVideoRenderer.Text = "video renderer";
            // 
            // rdgVideoRendererMadVR
            // 
            this.rdgVideoRendererMadVR.AutoSize = true;
            this.rdgVideoRendererMadVR.Location = new System.Drawing.Point(109, 55);
            this.rdgVideoRendererMadVR.Name = "rdgVideoRendererMadVR";
            this.rdgVideoRendererMadVR.Size = new System.Drawing.Size(75, 20);
            this.rdgVideoRendererMadVR.TabIndex = 46;
            this.rdgVideoRendererMadVR.TabStop = true;
            this.rdgVideoRendererMadVR.Text = "madVR";
            this.rdgVideoRendererMadVR.UseVisualStyleBackColor = true;
            this.rdgVideoRendererMadVR.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererEVR
            // 
            this.rdgVideoRendererEVR.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererEVR.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererEVR.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRendererEVR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererEVR.Location = new System.Drawing.Point(7, 54);
            this.rdgVideoRendererEVR.Name = "rdgVideoRendererEVR";
            this.rdgVideoRendererEVR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererEVR.Size = new System.Drawing.Size(78, 19);
            this.rdgVideoRendererEVR.TabIndex = 45;
            this.rdgVideoRendererEVR.TabStop = true;
            this.rdgVideoRendererEVR.Tag = "1";
            this.rdgVideoRendererEVR.Text = "EVR";
            this.rdgVideoRendererEVR.UseVisualStyleBackColor = false;
            this.rdgVideoRendererEVR.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererNone
            // 
            this.rdgVideoRendererNone.Location = new System.Drawing.Point(109, 32);
            this.rdgVideoRendererNone.Name = "rdgVideoRendererNone";
            this.rdgVideoRendererNone.Size = new System.Drawing.Size(75, 18);
            this.rdgVideoRendererNone.TabIndex = 43;
            this.rdgVideoRendererNone.Tag = "7";
            this.rdgVideoRendererNone.Text = "none";
            this.rdgVideoRendererNone.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererOverlay
            // 
            this.rdgVideoRendererOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererOverlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererOverlay.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRendererOverlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererOverlay.Location = new System.Drawing.Point(6, 150);
            this.rdgVideoRendererOverlay.Name = "rdgVideoRendererOverlay";
            this.rdgVideoRendererOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererOverlay.Size = new System.Drawing.Size(76, 19);
            this.rdgVideoRendererOverlay.TabIndex = 42;
            this.rdgVideoRendererOverlay.TabStop = true;
            this.rdgVideoRendererOverlay.Tag = "5";
            this.rdgVideoRendererOverlay.Text = "overlay";
            this.rdgVideoRendererOverlay.UseVisualStyleBackColor = false;
            this.rdgVideoRendererOverlay.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererStandard
            // 
            this.rdgVideoRendererStandard.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererStandard.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererStandard.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRendererStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererStandard.Location = new System.Drawing.Point(7, 125);
            this.rdgVideoRendererStandard.Name = "rdgVideoRendererStandard";
            this.rdgVideoRendererStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererStandard.Size = new System.Drawing.Size(87, 19);
            this.rdgVideoRendererStandard.TabIndex = 41;
            this.rdgVideoRendererStandard.TabStop = true;
            this.rdgVideoRendererStandard.Tag = "4";
            this.rdgVideoRendererStandard.Text = "standard";
            this.rdgVideoRendererStandard.UseVisualStyleBackColor = false;
            this.rdgVideoRendererStandard.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererAutoSelect
            // 
            this.rdgVideoRendererAutoSelect.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererAutoSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererAutoSelect.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRendererAutoSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererAutoSelect.Location = new System.Drawing.Point(7, 30);
            this.rdgVideoRendererAutoSelect.Name = "rdgVideoRendererAutoSelect";
            this.rdgVideoRendererAutoSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererAutoSelect.Size = new System.Drawing.Size(96, 20);
            this.rdgVideoRendererAutoSelect.TabIndex = 40;
            this.rdgVideoRendererAutoSelect.TabStop = true;
            this.rdgVideoRendererAutoSelect.Tag = "0";
            this.rdgVideoRendererAutoSelect.Text = "auto";
            this.rdgVideoRendererAutoSelect.UseVisualStyleBackColor = false;
            this.rdgVideoRendererAutoSelect.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererVMR7
            // 
            this.rdgVideoRendererVMR7.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererVMR7.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererVMR7.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRendererVMR7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererVMR7.Location = new System.Drawing.Point(7, 100);
            this.rdgVideoRendererVMR7.Name = "rdgVideoRendererVMR7";
            this.rdgVideoRendererVMR7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererVMR7.Size = new System.Drawing.Size(78, 19);
            this.rdgVideoRendererVMR7.TabIndex = 39;
            this.rdgVideoRendererVMR7.TabStop = true;
            this.rdgVideoRendererVMR7.Tag = "3";
            this.rdgVideoRendererVMR7.Text = "VMR7";
            this.rdgVideoRendererVMR7.UseVisualStyleBackColor = false;
            this.rdgVideoRendererVMR7.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererVMR9
            // 
            this.rdgVideoRendererVMR9.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererVMR9.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererVMR9.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgVideoRendererVMR9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererVMR9.Location = new System.Drawing.Point(7, 77);
            this.rdgVideoRendererVMR9.Name = "rdgVideoRendererVMR9";
            this.rdgVideoRendererVMR9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererVMR9.Size = new System.Drawing.Size(78, 19);
            this.rdgVideoRendererVMR9.TabIndex = 38;
            this.rdgVideoRendererVMR9.TabStop = true;
            this.rdgVideoRendererVMR9.Tag = "2";
            this.rdgVideoRendererVMR9.Text = "VMR9";
            this.rdgVideoRendererVMR9.UseVisualStyleBackColor = false;
            this.rdgVideoRendererVMR9.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererRecPriority
            // 
            this.rdgVideoRendererRecPriority.Location = new System.Drawing.Point(6, 173);
            this.rdgVideoRendererRecPriority.Name = "rdgVideoRendererRecPriority";
            this.rdgVideoRendererRecPriority.Size = new System.Drawing.Size(164, 20);
            this.rdgVideoRendererRecPriority.TabIndex = 44;
            this.rdgVideoRendererRecPriority.Tag = "6";
            this.rdgVideoRendererRecPriority.Text = "recording priority";
            this.rdgVideoRendererRecPriority.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // chkTransparency
            // 
            this.chkTransparency.Location = new System.Drawing.Point(213, 96);
            this.chkTransparency.Name = "chkTransparency";
            this.chkTransparency.Size = new System.Drawing.Size(115, 20);
            this.chkTransparency.TabIndex = 50;
            this.chkTransparency.Text = "transparency";
            this.chkTransparency.CheckedChanged += new System.EventHandler(this.chkTransparency_CheckedChanged);
            // 
            // grbMainVideoWindow
            // 
            this.grbMainVideoWindow.BackColor = System.Drawing.SystemColors.Control;
            this.grbMainVideoWindow.Controls.Add(this.chkTransparentColor);
            this.grbMainVideoWindow.Controls.Add(this.txtTransparentColor);
            this.grbMainVideoWindow.Controls.Add(this.chkAlphablend);
            this.grbMainVideoWindow.Controls.Add(this.tbrAlphablend);
            this.grbMainVideoWindow.Controls.Add(this.lblMonitorNumber);
            this.grbMainVideoWindow.Controls.Add(this.txtDisplayMonitor);
            this.grbMainVideoWindow.Controls.Add(this.btnTestPanScan);
            this.grbMainVideoWindow.Controls.Add(this.btnTestPanScanHelp);
            this.grbMainVideoWindow.Controls.Add(this.Label1);
            this.grbMainVideoWindow.Controls.Add(this.chkFullScreen);
            this.grbMainVideoWindow.Controls.Add(this.chkUseVideoPort);
            this.grbMainVideoWindow.Controls.Add(this.tbrPanScan);
            this.grbMainVideoWindow.Controls.Add(this.chkVisible);
            this.grbMainVideoWindow.Controls.Add(this.rdgAspectRatio);
            this.grbMainVideoWindow.Controls.Add(this.chkEmbedded);
            this.grbMainVideoWindow.Controls.Add(this.chkMouseMovesWindow);
            this.grbMainVideoWindow.Controls.Add(this.chkStayOnTop);
            this.grbMainVideoWindow.Controls.Add(this.chkAutoSize);
            this.grbMainVideoWindow.Controls.Add(this.btnNewLocation);
            this.grbMainVideoWindow.Controls.Add(this.btnNewLocation2);
            this.grbMainVideoWindow.Font = new System.Drawing.Font("Arial", 8F);
            this.grbMainVideoWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbMainVideoWindow.Location = new System.Drawing.Point(532, 42);
            this.grbMainVideoWindow.Name = "grbMainVideoWindow";
            this.grbMainVideoWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbMainVideoWindow.Size = new System.Drawing.Size(586, 182);
            this.grbMainVideoWindow.TabIndex = 46;
            this.grbMainVideoWindow.TabStop = false;
            this.grbMainVideoWindow.Text = "display settings:";
            // 
            // chkTransparentColor
            // 
            this.chkTransparentColor.AutoSize = true;
            this.chkTransparentColor.Location = new System.Drawing.Point(329, 78);
            this.chkTransparentColor.Name = "chkTransparentColor";
            this.chkTransparentColor.Size = new System.Drawing.Size(176, 20);
            this.chkTransparentColor.TabIndex = 34;
            this.chkTransparentColor.Text = "transparent RGB color:";
            this.chkTransparentColor.UseVisualStyleBackColor = true;
            this.chkTransparentColor.CheckedChanged += new System.EventHandler(this.chkTransparentColor_CheckedChanged);
            // 
            // txtTransparentColor
            // 
            this.txtTransparentColor.Location = new System.Drawing.Point(504, 77);
            this.txtTransparentColor.Name = "txtTransparentColor";
            this.txtTransparentColor.Size = new System.Drawing.Size(74, 23);
            this.txtTransparentColor.TabIndex = 33;
            this.txtTransparentColor.TextChanged += new System.EventHandler(this.txtTransparentColor_TextChanged);
            // 
            // chkAlphablend
            // 
            this.chkAlphablend.AutoSize = true;
            this.chkAlphablend.Location = new System.Drawing.Point(138, 65);
            this.chkAlphablend.Name = "chkAlphablend";
            this.chkAlphablend.Size = new System.Drawing.Size(177, 20);
            this.chkAlphablend.TabIndex = 32;
            this.chkAlphablend.Text = "alphablending: (0..255)";
            this.chkAlphablend.UseVisualStyleBackColor = true;
            this.chkAlphablend.CheckedChanged += new System.EventHandler(this.chkAlphablend_CheckedChanged);
            // 
            // tbrAlphablend
            // 
            this.tbrAlphablend.AutoSize = false;
            this.tbrAlphablend.Location = new System.Drawing.Point(132, 85);
            this.tbrAlphablend.Maximum = 255;
            this.tbrAlphablend.Name = "tbrAlphablend";
            this.tbrAlphablend.Size = new System.Drawing.Size(170, 23);
            this.tbrAlphablend.TabIndex = 31;
            this.tbrAlphablend.TickFrequency = 10;
            this.tbrAlphablend.Value = 180;
            this.tbrAlphablend.Scroll += new System.EventHandler(this.tbrAlphablend_Scroll);
            // 
            // lblMonitorNumber
            // 
            this.lblMonitorNumber.AutoSize = true;
            this.lblMonitorNumber.Location = new System.Drawing.Point(371, 51);
            this.lblMonitorNumber.Name = "lblMonitorNumber";
            this.lblMonitorNumber.Size = new System.Drawing.Size(172, 16);
            this.lblMonitorNumber.TabIndex = 30;
            this.lblMonitorNumber.Text = "assign to monitor number:";
            // 
            // txtDisplayMonitor
            // 
            this.txtDisplayMonitor.Location = new System.Drawing.Point(535, 47);
            this.txtDisplayMonitor.Name = "txtDisplayMonitor";
            this.txtDisplayMonitor.Size = new System.Drawing.Size(45, 23);
            this.txtDisplayMonitor.TabIndex = 29;
            this.txtDisplayMonitor.TextChanged += new System.EventHandler(this.txtDisplayMonitor_TextChanged);
            // 
            // btnTestPanScan
            // 
            this.btnTestPanScan.Location = new System.Drawing.Point(310, 106);
            this.btnTestPanScan.Name = "btnTestPanScan";
            this.btnTestPanScan.Size = new System.Drawing.Size(98, 24);
            this.btnTestPanScan.TabIndex = 27;
            this.btnTestPanScan.Text = "test pan-scan";
            this.btnTestPanScan.Click += new System.EventHandler(this.btnTestPanScan_Click);
            // 
            // btnTestPanScanHelp
            // 
            this.btnTestPanScanHelp.Location = new System.Drawing.Point(307, 133);
            this.btnTestPanScanHelp.Name = "btnTestPanScanHelp";
            this.btnTestPanScanHelp.Size = new System.Drawing.Size(22, 24);
            this.btnTestPanScanHelp.TabIndex = 28;
            this.btnTestPanScanHelp.Text = "?";
            this.btnTestPanScanHelp.Click += new System.EventHandler(this.btnTestPanScanHelp_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(134, 114);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 16);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "pan-scan (0..100)";
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.BackColor = System.Drawing.SystemColors.Control;
            this.chkFullScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFullScreen.Font = new System.Drawing.Font("Arial", 8F);
            this.chkFullScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFullScreen.Location = new System.Drawing.Point(198, 35);
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFullScreen.Size = new System.Drawing.Size(96, 19);
            this.chkFullScreen.TabIndex = 19;
            this.chkFullScreen.Text = "full screen";
            this.chkFullScreen.UseVisualStyleBackColor = false;
            this.chkFullScreen.CheckedChanged += new System.EventHandler(this.chkFullScreen_CheckedChanged);
            // 
            // chkUseVideoPort
            // 
            this.chkUseVideoPort.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseVideoPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseVideoPort.Font = new System.Drawing.Font("Arial", 8F);
            this.chkUseVideoPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseVideoPort.Location = new System.Drawing.Point(466, 16);
            this.chkUseVideoPort.Name = "chkUseVideoPort";
            this.chkUseVideoPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseVideoPort.Size = new System.Drawing.Size(114, 20);
            this.chkUseVideoPort.TabIndex = 21;
            this.chkUseVideoPort.Text = "use video port";
            this.chkUseVideoPort.UseVisualStyleBackColor = false;
            this.chkUseVideoPort.CheckedChanged += new System.EventHandler(this.chkUseVideoPort_CheckedChanged);
            // 
            // tbrPanScan
            // 
            this.tbrPanScan.AutoSize = false;
            this.tbrPanScan.Location = new System.Drawing.Point(132, 129);
            this.tbrPanScan.Maximum = 100;
            this.tbrPanScan.Name = "tbrPanScan";
            this.tbrPanScan.Size = new System.Drawing.Size(170, 23);
            this.tbrPanScan.TabIndex = 26;
            this.tbrPanScan.TickFrequency = 10;
            this.tbrPanScan.Value = 50;
            this.tbrPanScan.Scroll += new System.EventHandler(this.tbrPanScan_Scroll);
            // 
            // chkVisible
            // 
            this.chkVisible.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkVisible.Location = new System.Drawing.Point(10, 16);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(84, 20);
            this.chkVisible.TabIndex = 24;
            this.chkVisible.Text = "visible";
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // rdgAspectRatio
            // 
            this.rdgAspectRatio.Controls.Add(this.rdgDisplayAspectRatioPanScan);
            this.rdgAspectRatio.Controls.Add(this.rdgDisplayAspectRatioStretch);
            this.rdgAspectRatio.Controls.Add(this.rdgDisplayAspectRatioPan);
            this.rdgAspectRatio.Controls.Add(this.rdgDisplayAspectRatioBox);
            this.rdgAspectRatio.Location = new System.Drawing.Point(10, 62);
            this.rdgAspectRatio.Name = "rdgAspectRatio";
            this.rdgAspectRatio.Size = new System.Drawing.Size(111, 96);
            this.rdgAspectRatio.TabIndex = 23;
            this.rdgAspectRatio.TabStop = false;
            this.rdgAspectRatio.Text = "aspect ratio";
            // 
            // rdgDisplayAspectRatioPanScan
            // 
            this.rdgDisplayAspectRatioPanScan.AutoSize = true;
            this.rdgDisplayAspectRatioPanScan.Location = new System.Drawing.Point(10, 72);
            this.rdgDisplayAspectRatioPanScan.Name = "rdgDisplayAspectRatioPanScan";
            this.rdgDisplayAspectRatioPanScan.Size = new System.Drawing.Size(88, 20);
            this.rdgDisplayAspectRatioPanScan.TabIndex = 3;
            this.rdgDisplayAspectRatioPanScan.Tag = "3";
            this.rdgDisplayAspectRatioPanScan.Text = "pan-scan";
            this.rdgDisplayAspectRatioPanScan.CheckedChanged += new System.EventHandler(this.rdgDisplayAspectRatio_CheckedChanged);
            // 
            // rdgDisplayAspectRatioStretch
            // 
            this.rdgDisplayAspectRatioStretch.AutoSize = true;
            this.rdgDisplayAspectRatioStretch.Location = new System.Drawing.Point(10, 53);
            this.rdgDisplayAspectRatioStretch.Name = "rdgDisplayAspectRatioStretch";
            this.rdgDisplayAspectRatioStretch.Size = new System.Drawing.Size(72, 20);
            this.rdgDisplayAspectRatioStretch.TabIndex = 2;
            this.rdgDisplayAspectRatioStretch.Tag = "2";
            this.rdgDisplayAspectRatioStretch.Text = "stretch";
            this.rdgDisplayAspectRatioStretch.CheckedChanged += new System.EventHandler(this.rdgDisplayAspectRatio_CheckedChanged);
            // 
            // rdgDisplayAspectRatioPan
            // 
            this.rdgDisplayAspectRatioPan.AutoSize = true;
            this.rdgDisplayAspectRatioPan.Location = new System.Drawing.Point(10, 35);
            this.rdgDisplayAspectRatioPan.Name = "rdgDisplayAspectRatioPan";
            this.rdgDisplayAspectRatioPan.Size = new System.Drawing.Size(86, 20);
            this.rdgDisplayAspectRatioPan.TabIndex = 1;
            this.rdgDisplayAspectRatioPan.Tag = "1";
            this.rdgDisplayAspectRatioPan.Text = "no resize";
            this.rdgDisplayAspectRatioPan.CheckedChanged += new System.EventHandler(this.rdgDisplayAspectRatio_CheckedChanged);
            // 
            // rdgDisplayAspectRatioBox
            // 
            this.rdgDisplayAspectRatioBox.Location = new System.Drawing.Point(10, 16);
            this.rdgDisplayAspectRatioBox.Name = "rdgDisplayAspectRatioBox";
            this.rdgDisplayAspectRatioBox.Size = new System.Drawing.Size(51, 19);
            this.rdgDisplayAspectRatioBox.TabIndex = 0;
            this.rdgDisplayAspectRatioBox.Tag = "0";
            this.rdgDisplayAspectRatioBox.Text = "box";
            this.rdgDisplayAspectRatioBox.CheckedChanged += new System.EventHandler(this.rdgDisplayAspectRatio_CheckedChanged);
            // 
            // chkEmbedded
            // 
            this.chkEmbedded.BackColor = System.Drawing.SystemColors.Control;
            this.chkEmbedded.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkEmbedded.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkEmbedded.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEmbedded.Location = new System.Drawing.Point(10, 35);
            this.chkEmbedded.Name = "chkEmbedded";
            this.chkEmbedded.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEmbedded.Size = new System.Drawing.Size(127, 23);
            this.chkEmbedded.TabIndex = 22;
            this.chkEmbedded.Text = "embedded";
            this.chkEmbedded.UseVisualStyleBackColor = false;
            this.chkEmbedded.CheckedChanged += new System.EventHandler(this.chkEmbedded_CheckedChanged);
            // 
            // chkMouseMovesWindow
            // 
            this.chkMouseMovesWindow.BackColor = System.Drawing.SystemColors.Control;
            this.chkMouseMovesWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMouseMovesWindow.Font = new System.Drawing.Font("Arial", 8F);
            this.chkMouseMovesWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMouseMovesWindow.Location = new System.Drawing.Point(198, 16);
            this.chkMouseMovesWindow.Name = "chkMouseMovesWindow";
            this.chkMouseMovesWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMouseMovesWindow.Size = new System.Drawing.Size(163, 20);
            this.chkMouseMovesWindow.TabIndex = 18;
            this.chkMouseMovesWindow.Text = "mouse moves window";
            this.chkMouseMovesWindow.UseVisualStyleBackColor = false;
            this.chkMouseMovesWindow.CheckedChanged += new System.EventHandler(this.chkMouseMovesWindow_CheckedChanged);
            // 
            // chkStayOnTop
            // 
            this.chkStayOnTop.BackColor = System.Drawing.SystemColors.Control;
            this.chkStayOnTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkStayOnTop.Font = new System.Drawing.Font("Arial", 8F);
            this.chkStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkStayOnTop.Location = new System.Drawing.Point(368, 16);
            this.chkStayOnTop.Name = "chkStayOnTop";
            this.chkStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkStayOnTop.Size = new System.Drawing.Size(106, 20);
            this.chkStayOnTop.TabIndex = 17;
            this.chkStayOnTop.Text = "stay on top";
            this.chkStayOnTop.UseVisualStyleBackColor = false;
            this.chkStayOnTop.CheckedChanged += new System.EventHandler(this.chkStayOnTop_CheckedChanged);
            // 
            // chkAutoSize
            // 
            this.chkAutoSize.BackColor = System.Drawing.SystemColors.Control;
            this.chkAutoSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAutoSize.Font = new System.Drawing.Font("Arial", 8F);
            this.chkAutoSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAutoSize.Location = new System.Drawing.Point(95, 16);
            this.chkAutoSize.Name = "chkAutoSize";
            this.chkAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoSize.Size = new System.Drawing.Size(96, 20);
            this.chkAutoSize.TabIndex = 16;
            this.chkAutoSize.Text = "autosize";
            this.chkAutoSize.UseVisualStyleBackColor = false;
            this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNewLocation.Font = new System.Drawing.Font("Arial", 8F);
            this.btnNewLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewLocation.Location = new System.Drawing.Point(419, 133);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewLocation.Size = new System.Drawing.Size(168, 24);
            this.btnNewLocation.TabIndex = 12;
            this.btnNewLocation.Text = "location 10,10 (autosize)";
            this.btnNewLocation.UseVisualStyleBackColor = false;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNewLocation_Click);
            // 
            // btnNewLocation2
            // 
            this.btnNewLocation2.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewLocation2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNewLocation2.Font = new System.Drawing.Font("Arial", 8F);
            this.btnNewLocation2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewLocation2.Location = new System.Drawing.Point(419, 106);
            this.btnNewLocation2.Name = "btnNewLocation2";
            this.btnNewLocation2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewLocation2.Size = new System.Drawing.Size(168, 24);
            this.btnNewLocation2.TabIndex = 11;
            this.btnNewLocation2.Text = "location 20,20 (480,200)";
            this.btnNewLocation2.UseVisualStyleBackColor = false;
            this.btnNewLocation2.Click += new System.EventHandler(this.btnNewLocation2_Click);
            // 
            // chkSetLogo
            // 
            this.chkSetLogo.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSetLogo.Font = new System.Drawing.Font("Arial", 8F);
            this.chkSetLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSetLogo.Location = new System.Drawing.Point(213, 122);
            this.chkSetLogo.Name = "chkSetLogo";
            this.chkSetLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSetLogo.Size = new System.Drawing.Size(162, 19);
            this.chkSetLogo.TabIndex = 44;
            this.chkSetLogo.Text = "show logo, e.g.:";
            this.chkSetLogo.UseVisualStyleBackColor = false;
            this.chkSetLogo.CheckedChanged += new System.EventHandler(this.chkSetLogo_CheckedChanged);
            // 
            // chkBorder
            // 
            this.chkBorder.BackColor = System.Drawing.SystemColors.Control;
            this.chkBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkBorder.Font = new System.Drawing.Font("Arial", 8F);
            this.chkBorder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBorder.Location = new System.Drawing.Point(213, 78);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBorder.Size = new System.Drawing.Size(115, 20);
            this.chkBorder.TabIndex = 43;
            this.chkBorder.Text = "border";
            this.chkBorder.UseVisualStyleBackColor = false;
            this.chkBorder.CheckedChanged += new System.EventHandler(this.chkBorder_CheckedChanged);
            // 
            // chkChangeCursor
            // 
            this.chkChangeCursor.BackColor = System.Drawing.SystemColors.Control;
            this.chkChangeCursor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkChangeCursor.Font = new System.Drawing.Font("Arial", 8F);
            this.chkChangeCursor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkChangeCursor.Location = new System.Drawing.Point(213, 59);
            this.chkChangeCursor.Name = "chkChangeCursor";
            this.chkChangeCursor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkChangeCursor.Size = new System.Drawing.Size(192, 20);
            this.chkChangeCursor.TabIndex = 42;
            this.chkChangeCursor.Text = "change cursor (e.g.: cross)";
            this.chkChangeCursor.UseVisualStyleBackColor = false;
            this.chkChangeCursor.CheckedChanged += new System.EventHandler(this.chkChangeCursor_CheckedChanged);
            // 
            // imgLogo
            // 
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(213, 141);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(91, 62);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 49;
            this.imgLogo.TabStop = false;
            // 
            // chkBlackMagicOutput
            // 
            this.chkBlackMagicOutput.AutoSize = true;
            this.chkBlackMagicOutput.Location = new System.Drawing.Point(213, 4);
            this.chkBlackMagicOutput.Name = "chkBlackMagicOutput";
            this.chkBlackMagicOutput.Size = new System.Drawing.Size(202, 21);
            this.chkBlackMagicOutput.TabIndex = 54;
            this.chkBlackMagicOutput.Text = "BlackMagic Decklink output";
            this.chkBlackMagicOutput.CheckedChanged += new System.EventHandler(this.chkBlackMagicOutput_CheckedChanged);
            // 
            // chkDisplayActive
            // 
            this.chkDisplayActive.AutoSize = true;
            this.chkDisplayActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkDisplayActive.Location = new System.Drawing.Point(353, 91);
            this.chkDisplayActive.Name = "chkDisplayActive";
            this.chkDisplayActive.Size = new System.Drawing.Size(173, 21);
            this.chkDisplayActive.TabIndex = 55;
            this.chkDisplayActive.Text = "DISPLAY ACTIVE ->";
            this.chkDisplayActive.UseVisualStyleBackColor = true;
            this.chkDisplayActive.CheckedChanged += new System.EventHandler(this.chkDisplayActive_CheckedChanged);
            // 
            // rdgDisplaySelected
            // 
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay9);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay8);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay7);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay6);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay5);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay4);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay3);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay2);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay1);
            this.rdgDisplaySelected.Controls.Add(this.rdgSelectDisplay0);
            this.rdgDisplaySelected.Location = new System.Drawing.Point(488, 0);
            this.rdgDisplaySelected.Name = "rdgDisplaySelected";
            this.rdgDisplaySelected.Size = new System.Drawing.Size(631, 44);
            this.rdgDisplaySelected.TabIndex = 56;
            this.rdgDisplaySelected.TabStop = false;
            this.rdgDisplaySelected.Text = "display # selected:";
            // 
            // rdgSelectDisplay9
            // 
            this.rdgSelectDisplay9.AutoSize = true;
            this.rdgSelectDisplay9.Location = new System.Drawing.Point(576, 18);
            this.rdgSelectDisplay9.Name = "rdgSelectDisplay9";
            this.rdgSelectDisplay9.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay9.TabIndex = 9;
            this.rdgSelectDisplay9.Tag = "9";
            this.rdgSelectDisplay9.Text = "9";
            this.rdgSelectDisplay9.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay9.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay8
            // 
            this.rdgSelectDisplay8.AutoSize = true;
            this.rdgSelectDisplay8.Location = new System.Drawing.Point(516, 18);
            this.rdgSelectDisplay8.Name = "rdgSelectDisplay8";
            this.rdgSelectDisplay8.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay8.TabIndex = 8;
            this.rdgSelectDisplay8.Tag = "8";
            this.rdgSelectDisplay8.Text = "8";
            this.rdgSelectDisplay8.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay8.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay7
            // 
            this.rdgSelectDisplay7.AutoSize = true;
            this.rdgSelectDisplay7.Location = new System.Drawing.Point(456, 18);
            this.rdgSelectDisplay7.Name = "rdgSelectDisplay7";
            this.rdgSelectDisplay7.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay7.TabIndex = 7;
            this.rdgSelectDisplay7.Tag = "7";
            this.rdgSelectDisplay7.Text = "7";
            this.rdgSelectDisplay7.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay7.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay6
            // 
            this.rdgSelectDisplay6.AutoSize = true;
            this.rdgSelectDisplay6.Location = new System.Drawing.Point(396, 18);
            this.rdgSelectDisplay6.Name = "rdgSelectDisplay6";
            this.rdgSelectDisplay6.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay6.TabIndex = 6;
            this.rdgSelectDisplay6.Tag = "6";
            this.rdgSelectDisplay6.Text = "6";
            this.rdgSelectDisplay6.UseVisualStyleBackColor = true;
            // 
            // rdgSelectDisplay5
            // 
            this.rdgSelectDisplay5.AutoSize = true;
            this.rdgSelectDisplay5.Location = new System.Drawing.Point(336, 18);
            this.rdgSelectDisplay5.Name = "rdgSelectDisplay5";
            this.rdgSelectDisplay5.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay5.TabIndex = 5;
            this.rdgSelectDisplay5.Tag = "5";
            this.rdgSelectDisplay5.Text = "5";
            this.rdgSelectDisplay5.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay5.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay4
            // 
            this.rdgSelectDisplay4.AutoSize = true;
            this.rdgSelectDisplay4.Location = new System.Drawing.Point(276, 18);
            this.rdgSelectDisplay4.Name = "rdgSelectDisplay4";
            this.rdgSelectDisplay4.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay4.TabIndex = 4;
            this.rdgSelectDisplay4.Tag = "4";
            this.rdgSelectDisplay4.Text = "4";
            this.rdgSelectDisplay4.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay4.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay3
            // 
            this.rdgSelectDisplay3.AutoSize = true;
            this.rdgSelectDisplay3.Location = new System.Drawing.Point(216, 18);
            this.rdgSelectDisplay3.Name = "rdgSelectDisplay3";
            this.rdgSelectDisplay3.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay3.TabIndex = 3;
            this.rdgSelectDisplay3.Tag = "3";
            this.rdgSelectDisplay3.Text = "3";
            this.rdgSelectDisplay3.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay3.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay2
            // 
            this.rdgSelectDisplay2.AutoSize = true;
            this.rdgSelectDisplay2.Location = new System.Drawing.Point(156, 18);
            this.rdgSelectDisplay2.Name = "rdgSelectDisplay2";
            this.rdgSelectDisplay2.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay2.TabIndex = 2;
            this.rdgSelectDisplay2.Tag = "2";
            this.rdgSelectDisplay2.Text = "2";
            this.rdgSelectDisplay2.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay2.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay1
            // 
            this.rdgSelectDisplay1.AutoSize = true;
            this.rdgSelectDisplay1.Location = new System.Drawing.Point(96, 18);
            this.rdgSelectDisplay1.Name = "rdgSelectDisplay1";
            this.rdgSelectDisplay1.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay1.TabIndex = 1;
            this.rdgSelectDisplay1.Tag = "1";
            this.rdgSelectDisplay1.Text = "1";
            this.rdgSelectDisplay1.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay1.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // rdgSelectDisplay0
            // 
            this.rdgSelectDisplay0.AutoSize = true;
            this.rdgSelectDisplay0.Checked = true;
            this.rdgSelectDisplay0.Location = new System.Drawing.Point(32, 18);
            this.rdgSelectDisplay0.Name = "rdgSelectDisplay0";
            this.rdgSelectDisplay0.Size = new System.Drawing.Size(37, 21);
            this.rdgSelectDisplay0.TabIndex = 0;
            this.rdgSelectDisplay0.TabStop = true;
            this.rdgSelectDisplay0.Tag = "0";
            this.rdgSelectDisplay0.Text = "0";
            this.rdgSelectDisplay0.UseVisualStyleBackColor = true;
            this.rdgSelectDisplay0.CheckedChanged += new System.EventHandler(this.rdgSelectDisplay_CheckedChanged);
            // 
            // Display
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1349, 279);
            this.ControlBox = false;
            this.Controls.Add(this.rdgDisplaySelected);
            this.Controls.Add(this.chkDisplayActive);
            this.Controls.Add(this.chkBlackMagicOutput);
            this.Controls.Add(this.chkAdjustPixelAspectRatio);
            this.Controls.Add(this.chkVideoVisibleWhenStopped);
            this.Controls.Add(this.rdgVideoRenderer);
            this.Controls.Add(this.chkTransparency);
            this.Controls.Add(this.grbMainVideoWindow);
            this.Controls.Add(this.chkSetLogo);
            this.Controls.Add(this.chkBorder);
            this.Controls.Add(this.chkChangeCursor);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Display_Load);
            this.VisibleChanged += new System.EventHandler(this.Display_VisibleChanged);
            this.rdgVideoRenderer.ResumeLayout(false);
            this.rdgVideoRenderer.PerformLayout();
            this.grbMainVideoWindow.ResumeLayout(false);
            this.grbMainVideoWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAlphablend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPanScan)).EndInit();
            this.rdgAspectRatio.ResumeLayout(false);
            this.rdgAspectRatio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.rdgDisplaySelected.ResumeLayout(false);
            this.rdgDisplaySelected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip1;
		private CheckBox chkAdjustPixelAspectRatio;
        private CheckBox chkVideoVisibleWhenStopped;
        private GroupBox rdgVideoRenderer;
        private RadioButton rdgVideoRendererNone;
        private RadioButton rdgVideoRendererOverlay;
        private RadioButton rdgVideoRendererStandard;
        private RadioButton rdgVideoRendererAutoSelect;
        private RadioButton rdgVideoRendererVMR7;
        private RadioButton rdgVideoRendererVMR9;
        private RadioButton rdgVideoRendererRecPriority;
        private CheckBox chkTransparency;
        private GroupBox grbMainVideoWindow;
        private Button btnTestPanScanHelp;
        private Label Label1;
        private CheckBox chkFullScreen;
        private CheckBox chkUseVideoPort;
        private Button btnTestPanScan;
        private TrackBar tbrPanScan;
        private CheckBox chkVisible;
        private GroupBox rdgAspectRatio;
        private RadioButton rdgDisplayAspectRatioPanScan;
        private RadioButton rdgDisplayAspectRatioStretch;
        private RadioButton rdgDisplayAspectRatioPan;
        private RadioButton rdgDisplayAspectRatioBox;
        private CheckBox chkEmbedded;
        private CheckBox chkMouseMovesWindow;
        private CheckBox chkStayOnTop;
        private CheckBox chkAutoSize;
        private Button btnNewLocation;
        private Button btnNewLocation2;
        private CheckBox chkSetLogo;
        private CheckBox chkBorder;
        private CheckBox chkChangeCursor;
        private PictureBox imgLogo;
        private TransparentWindow frmTransparentWindow;
        private bool boolPanScan;
        private int PanScanVGWidth;
        private RadioButton rdgVideoRendererEVR;
        private CheckBox chkBlackMagicOutput;
        private CheckBox chkDisplayActive;
        private GroupBox rdgDisplaySelected;
        private RadioButton rdgSelectDisplay0;
        private RadioButton rdgSelectDisplay9;
        private RadioButton rdgSelectDisplay8;
        private RadioButton rdgSelectDisplay7;
        private RadioButton rdgSelectDisplay6;
        private RadioButton rdgSelectDisplay5;
        private RadioButton rdgSelectDisplay4;
        private RadioButton rdgSelectDisplay3;
        private RadioButton rdgSelectDisplay2;
        private RadioButton rdgSelectDisplay1;
        private TextBox txtDisplayMonitor;
        private Label lblMonitorNumber;
        private CheckBox chkAlphablend;
        private TrackBar tbrAlphablend;
        private CheckBox chkTransparentColor;
        private TextBox txtTransparentColor;
        private RadioButton rdgVideoRendererMadVR;
        private int PanScanVGHeight;
              
    }
}

