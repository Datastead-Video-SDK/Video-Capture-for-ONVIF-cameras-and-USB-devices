using System.Windows.Forms;

namespace MainDemo
{
    partial class FrameGrabber : Form
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.edtFrameCaptureHeight = new System.Windows.Forms.TextBox();
            this.edtFrameCaptureWidth = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Frame11 = new System.Windows.Forms.GroupBox();
            this.tbrCaptureZoomSize = new System.Windows.Forms.TrackBar();
            this.btnResetCaptureZoomSize = new System.Windows.Forms.Button();
            this.edtCaptureZoomSize = new System.Windows.Forms.TextBox();
            this.mmoFrameCaptureLog = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.rdgAutoFileName = new System.Windows.Forms.GroupBox();
            this.rdgAutoFileName3 = new System.Windows.Forms.RadioButton();
            this.edtAVIAutoFilePrefix = new System.Windows.Forms.TextBox();
            this.rdgAutoFileName1 = new System.Windows.Forms.RadioButton();
            this.rdgAutoFileName2 = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.grbBurstMode = new System.Windows.Forms.GroupBox();
            this.btnBurstModeClipboard = new System.Windows.Forms.Button();
            this.btnBurstModeStop = new System.Windows.Forms.Button();
            this.btnBurstModeJPEGFile = new System.Windows.Forms.Button();
            this.btnBurstModeBMPFile = new System.Windows.Forms.Button();
            this.btnBurstModeTBitmap = new System.Windows.Forms.Button();
            this.edtBurstCount = new System.Windows.Forms.TextBox();
            this.edtBurstInterval = new System.Windows.Forms.TextBox();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.grbOneShot = new System.Windows.Forms.GroupBox();
            this.edtUseThisFileName = new System.Windows.Forms.TextBox();
            this.btnOneShotClipboard = new System.Windows.Forms.Button();
            this.chkUseThisFileName = new System.Windows.Forms.CheckBox();
            this.btnOneShotTBitmap = new System.Windows.Forms.Button();
            this.btnOneShotBMPFile = new System.Windows.Forms.Button();
            this.btnOneShotJPEGFile = new System.Windows.Forms.Button();
            this.rgdFrameGrabberFormat = new System.Windows.Forms.GroupBox();
            this.rgdFrameGrabberFormatRGB8 = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberFormatRGB555 = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberFormatDefault = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberFormatRGB32 = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberFormatRGB24 = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberFormat565 = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabber = new System.Windows.Forms.GroupBox();
            this.rgdFrameGrabberPreviewStream = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberCaptureStream = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberDisabled = new System.Windows.Forms.RadioButton();
            this.rgdFrameGrabberBothStreams = new System.Windows.Forms.RadioButton();
            this.Frame11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrCaptureZoomSize)).BeginInit();
            this.rdgAutoFileName.SuspendLayout();
            this.grbBurstMode.SuspendLayout();
            this.grbOneShot.SuspendLayout();
            this.rgdFrameGrabberFormat.SuspendLayout();
            this.rgdFrameGrabber.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtFrameCaptureHeight
            // 
            this.edtFrameCaptureHeight.Location = new System.Drawing.Point(888, 244);
            this.edtFrameCaptureHeight.Name = "edtFrameCaptureHeight";
            this.edtFrameCaptureHeight.Size = new System.Drawing.Size(112, 27);
            this.edtFrameCaptureHeight.TabIndex = 53;
            this.edtFrameCaptureHeight.TextChanged += new System.EventHandler(this.edtFrameCaptureHeight_TextChanged);
            // 
            // edtFrameCaptureWidth
            // 
            this.edtFrameCaptureWidth.Location = new System.Drawing.Point(888, 188);
            this.edtFrameCaptureWidth.Name = "edtFrameCaptureWidth";
            this.edtFrameCaptureWidth.Size = new System.Drawing.Size(112, 27);
            this.edtFrameCaptureWidth.TabIndex = 52;
            this.edtFrameCaptureWidth.TextChanged += new System.EventHandler(this.edtFrameCaptureWidth_TextChanged);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(888, 221);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 26);
            this.Label3.TabIndex = 51;
            this.Label3.Text = "capture height:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(888, 167);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 24);
            this.Label2.TabIndex = 50;
            this.Label2.Text = "capture width:";
            // 
            // Frame11
            // 
            this.Frame11.BackColor = System.Drawing.SystemColors.Control;
            this.Frame11.Controls.Add(this.tbrCaptureZoomSize);
            this.Frame11.Controls.Add(this.btnResetCaptureZoomSize);
            this.Frame11.Controls.Add(this.edtCaptureZoomSize);
            this.Frame11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Frame11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame11.Location = new System.Drawing.Point(888, 24);
            this.Frame11.Name = "Frame11";
            this.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame11.Size = new System.Drawing.Size(112, 137);
            this.Frame11.TabIndex = 48;
            this.Frame11.TabStop = false;
            this.Frame11.Text = "zoom size";
            // 
            // tbrCaptureZoomSize
            // 
            this.tbrCaptureZoomSize.AutoSize = false;
            this.tbrCaptureZoomSize.Location = new System.Drawing.Point(12, 24);
            this.tbrCaptureZoomSize.Maximum = 300;
            this.tbrCaptureZoomSize.Name = "tbrCaptureZoomSize";
            this.tbrCaptureZoomSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrCaptureZoomSize.Size = new System.Drawing.Size(22, 105);
            this.tbrCaptureZoomSize.TabIndex = 35;
            this.tbrCaptureZoomSize.TickFrequency = 30;
            this.tbrCaptureZoomSize.Scroll += new System.EventHandler(this.tbrCaptureZoomSize_Scroll);
            // 
            // btnResetCaptureZoomSize
            // 
            this.btnResetCaptureZoomSize.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetCaptureZoomSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResetCaptureZoomSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetCaptureZoomSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetCaptureZoomSize.Location = new System.Drawing.Point(44, 37);
            this.btnResetCaptureZoomSize.Name = "btnResetCaptureZoomSize";
            this.btnResetCaptureZoomSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetCaptureZoomSize.Size = new System.Drawing.Size(54, 34);
            this.btnResetCaptureZoomSize.TabIndex = 34;
            this.btnResetCaptureZoomSize.Text = "rst";
            this.btnResetCaptureZoomSize.UseVisualStyleBackColor = false;
            this.btnResetCaptureZoomSize.Click += new System.EventHandler(this.btnResetCaptureZoomSize_Click);
            // 
            // edtCaptureZoomSize
            // 
            this.edtCaptureZoomSize.AcceptsReturn = true;
            this.edtCaptureZoomSize.BackColor = System.Drawing.Color.Silver;
            this.edtCaptureZoomSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCaptureZoomSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtCaptureZoomSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCaptureZoomSize.Location = new System.Drawing.Point(44, 80);
            this.edtCaptureZoomSize.MaxLength = 0;
            this.edtCaptureZoomSize.Name = "edtCaptureZoomSize";
            this.edtCaptureZoomSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCaptureZoomSize.Size = new System.Drawing.Size(54, 23);
            this.edtCaptureZoomSize.TabIndex = 33;
            this.edtCaptureZoomSize.Text = "100%";
            // 
            // mmoFrameCaptureLog
            // 
            this.mmoFrameCaptureLog.AcceptsReturn = true;
            this.mmoFrameCaptureLog.BackColor = System.Drawing.Color.Silver;
            this.mmoFrameCaptureLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoFrameCaptureLog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mmoFrameCaptureLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoFrameCaptureLog.Location = new System.Drawing.Point(1008, 24);
            this.mmoFrameCaptureLog.MaxLength = 0;
            this.mmoFrameCaptureLog.Multiline = true;
            this.mmoFrameCaptureLog.Name = "mmoFrameCaptureLog";
            this.mmoFrameCaptureLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoFrameCaptureLog.Size = new System.Drawing.Size(268, 252);
            this.mmoFrameCaptureLog.TabIndex = 49;
            this.mmoFrameCaptureLog.Text = "  log:";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.SystemColors.Control;
            this.Label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label32.Location = new System.Drawing.Point(6, 0);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(111, 16);
            this.Label32.TabIndex = 43;
            this.Label32.Text = "Frame grabber";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.SystemColors.Control;
            this.Label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label33.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label33.Location = new System.Drawing.Point(162, 0);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(859, 16);
            this.Label33.TabIndex = 42;
            this.Label33.Text = "The frame grabber handles frame capture, frame overlay and video processing, so t" +
    "hese features are not available when it is disabled. ";
            // 
            // rdgAutoFileName
            // 
            this.rdgAutoFileName.BackColor = System.Drawing.SystemColors.Control;
            this.rdgAutoFileName.Controls.Add(this.rdgAutoFileName3);
            this.rdgAutoFileName.Controls.Add(this.edtAVIAutoFilePrefix);
            this.rdgAutoFileName.Controls.Add(this.rdgAutoFileName1);
            this.rdgAutoFileName.Controls.Add(this.rdgAutoFileName2);
            this.rdgAutoFileName.Controls.Add(this.Label1);
            this.rdgAutoFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgAutoFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgAutoFileName.Location = new System.Drawing.Point(6, 176);
            this.rdgAutoFileName.Name = "rdgAutoFileName";
            this.rdgAutoFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgAutoFileName.Size = new System.Drawing.Size(350, 127);
            this.rdgAutoFileName.TabIndex = 47;
            this.rdgAutoFileName.TabStop = false;
            this.rdgAutoFileName.Text = "file names are generated automatically on a...";
            // 
            // rdgAutoFileName3
            // 
            this.rdgAutoFileName3.Location = new System.Drawing.Point(22, 79);
            this.rdgAutoFileName3.Name = "rdgAutoFileName3";
            this.rdgAutoFileName3.Size = new System.Drawing.Size(181, 28);
            this.rdgAutoFileName3.TabIndex = 39;
            this.rdgAutoFileName3.TabStop = true;
            this.rdgAutoFileName3.Tag = "2";
            this.rdgAutoFileName3.Text = "counter (start from 0)";
            this.rdgAutoFileName3.CheckedChanged += new System.EventHandler(this.rdgAutoFileName3_CheckedChanged);
            // 
            // edtAVIAutoFilePrefix
            // 
            this.edtAVIAutoFilePrefix.AcceptsReturn = true;
            this.edtAVIAutoFilePrefix.BackColor = System.Drawing.SystemColors.Window;
            this.edtAVIAutoFilePrefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAVIAutoFilePrefix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtAVIAutoFilePrefix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtAVIAutoFilePrefix.Location = new System.Drawing.Point(182, 47);
            this.edtAVIAutoFilePrefix.MaxLength = 0;
            this.edtAVIAutoFilePrefix.Name = "edtAVIAutoFilePrefix";
            this.edtAVIAutoFilePrefix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtAVIAutoFilePrefix.Size = new System.Drawing.Size(111, 23);
            this.edtAVIAutoFilePrefix.TabIndex = 37;
            this.edtAVIAutoFilePrefix.TextChanged += new System.EventHandler(this.edtAVIAutoFilePrefix_TextChanged);
            // 
            // rdgAutoFileName1
            // 
            this.rdgAutoFileName1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgAutoFileName1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgAutoFileName1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgAutoFileName1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgAutoFileName1.Location = new System.Drawing.Point(22, 24);
            this.rdgAutoFileName1.Name = "rdgAutoFileName1";
            this.rdgAutoFileName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgAutoFileName1.Size = new System.Drawing.Size(147, 27);
            this.rdgAutoFileName1.TabIndex = 31;
            this.rdgAutoFileName1.TabStop = true;
            this.rdgAutoFileName1.Tag = "0";
            this.rdgAutoFileName1.Text = "sequential basis";
            this.rdgAutoFileName1.UseVisualStyleBackColor = false;
            this.rdgAutoFileName1.CheckedChanged += new System.EventHandler(this.rdgAutoFileName1_CheckedChanged);
            // 
            // rdgAutoFileName2
            // 
            this.rdgAutoFileName2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgAutoFileName2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgAutoFileName2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgAutoFileName2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgAutoFileName2.Location = new System.Drawing.Point(22, 52);
            this.rdgAutoFileName2.Name = "rdgAutoFileName2";
            this.rdgAutoFileName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgAutoFileName2.Size = new System.Drawing.Size(147, 27);
            this.rdgAutoFileName2.TabIndex = 30;
            this.rdgAutoFileName2.TabStop = true;
            this.rdgAutoFileName2.Tag = "1";
            this.rdgAutoFileName2.Text = "time basis";
            this.rdgAutoFileName2.UseVisualStyleBackColor = false;
            this.rdgAutoFileName2.CheckedChanged += new System.EventHandler(this.rdgAutoFileName2_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(177, 24);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(161, 28);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "prefix for file names:";
            // 
            // grbBurstMode
            // 
            this.grbBurstMode.BackColor = System.Drawing.SystemColors.Control;
            this.grbBurstMode.Controls.Add(this.btnBurstModeClipboard);
            this.grbBurstMode.Controls.Add(this.btnBurstModeStop);
            this.grbBurstMode.Controls.Add(this.btnBurstModeJPEGFile);
            this.grbBurstMode.Controls.Add(this.btnBurstModeBMPFile);
            this.grbBurstMode.Controls.Add(this.btnBurstModeTBitmap);
            this.grbBurstMode.Controls.Add(this.edtBurstCount);
            this.grbBurstMode.Controls.Add(this.edtBurstInterval);
            this.grbBurstMode.Controls.Add(this.Label34);
            this.grbBurstMode.Controls.Add(this.Label35);
            this.grbBurstMode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbBurstMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbBurstMode.Location = new System.Drawing.Point(364, 128);
            this.grbBurstMode.Name = "grbBurstMode";
            this.grbBurstMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbBurstMode.Size = new System.Drawing.Size(516, 148);
            this.grbBurstMode.TabIndex = 46;
            this.grbBurstMode.TabStop = false;
            this.grbBurstMode.Text = "burst-mode frame capture to... ";
            // 
            // btnBurstModeClipboard
            // 
            this.btnBurstModeClipboard.BackColor = System.Drawing.SystemColors.Control;
            this.btnBurstModeClipboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBurstModeClipboard.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBurstModeClipboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBurstModeClipboard.Location = new System.Drawing.Point(314, 24);
            this.btnBurstModeClipboard.Name = "btnBurstModeClipboard";
            this.btnBurstModeClipboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBurstModeClipboard.Size = new System.Drawing.Size(91, 35);
            this.btnBurstModeClipboard.TabIndex = 29;
            this.btnBurstModeClipboard.Text = "Clipboard";
            this.btnBurstModeClipboard.UseVisualStyleBackColor = false;
            this.btnBurstModeClipboard.Click += new System.EventHandler(this.btnBurstModeClipboard_Click);
            // 
            // btnBurstModeStop
            // 
            this.btnBurstModeStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnBurstModeStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBurstModeStop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBurstModeStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBurstModeStop.Location = new System.Drawing.Point(414, 24);
            this.btnBurstModeStop.Name = "btnBurstModeStop";
            this.btnBurstModeStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBurstModeStop.Size = new System.Drawing.Size(91, 35);
            this.btnBurstModeStop.TabIndex = 26;
            this.btnBurstModeStop.Text = "Stop";
            this.btnBurstModeStop.UseVisualStyleBackColor = false;
            this.btnBurstModeStop.Click += new System.EventHandler(this.btnBurstModeStop_Click);
            // 
            // btnBurstModeJPEGFile
            // 
            this.btnBurstModeJPEGFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnBurstModeJPEGFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBurstModeJPEGFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBurstModeJPEGFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBurstModeJPEGFile.Location = new System.Drawing.Point(212, 24);
            this.btnBurstModeJPEGFile.Name = "btnBurstModeJPEGFile";
            this.btnBurstModeJPEGFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBurstModeJPEGFile.Size = new System.Drawing.Size(91, 35);
            this.btnBurstModeJPEGFile.TabIndex = 25;
            this.btnBurstModeJPEGFile.Text = "JPEG file";
            this.btnBurstModeJPEGFile.UseVisualStyleBackColor = false;
            this.btnBurstModeJPEGFile.Click += new System.EventHandler(this.btnBurstModeJPEGFile_Click);
            // 
            // btnBurstModeBMPFile
            // 
            this.btnBurstModeBMPFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnBurstModeBMPFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBurstModeBMPFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBurstModeBMPFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBurstModeBMPFile.Location = new System.Drawing.Point(112, 24);
            this.btnBurstModeBMPFile.Name = "btnBurstModeBMPFile";
            this.btnBurstModeBMPFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBurstModeBMPFile.Size = new System.Drawing.Size(91, 35);
            this.btnBurstModeBMPFile.TabIndex = 24;
            this.btnBurstModeBMPFile.Text = "BMP file";
            this.btnBurstModeBMPFile.UseVisualStyleBackColor = false;
            this.btnBurstModeBMPFile.Click += new System.EventHandler(this.btnBurstModeBMPFile_Click);
            // 
            // btnBurstModeTBitmap
            // 
            this.btnBurstModeTBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.btnBurstModeTBitmap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBurstModeTBitmap.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBurstModeTBitmap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBurstModeTBitmap.Location = new System.Drawing.Point(12, 24);
            this.btnBurstModeTBitmap.Name = "btnBurstModeTBitmap";
            this.btnBurstModeTBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBurstModeTBitmap.Size = new System.Drawing.Size(91, 35);
            this.btnBurstModeTBitmap.TabIndex = 23;
            this.btnBurstModeTBitmap.Text = "TBitmap";
            this.btnBurstModeTBitmap.UseVisualStyleBackColor = false;
            this.btnBurstModeTBitmap.Click += new System.EventHandler(this.btnBurstModeTBitmap_Click);
            // 
            // edtBurstCount
            // 
            this.edtBurstCount.AcceptsReturn = true;
            this.edtBurstCount.BackColor = System.Drawing.SystemColors.Window;
            this.edtBurstCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtBurstCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtBurstCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtBurstCount.Location = new System.Drawing.Point(12, 61);
            this.edtBurstCount.MaxLength = 0;
            this.edtBurstCount.Name = "edtBurstCount";
            this.edtBurstCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtBurstCount.Size = new System.Drawing.Size(58, 23);
            this.edtBurstCount.TabIndex = 22;
            this.edtBurstCount.Text = "3";
            this.edtBurstCount.TextChanged += new System.EventHandler(this.edtBurstCount_TextChanged);
            // 
            // edtBurstInterval
            // 
            this.edtBurstInterval.AcceptsReturn = true;
            this.edtBurstInterval.BackColor = System.Drawing.SystemColors.Window;
            this.edtBurstInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtBurstInterval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtBurstInterval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtBurstInterval.Location = new System.Drawing.Point(12, 99);
            this.edtBurstInterval.MaxLength = 0;
            this.edtBurstInterval.Name = "edtBurstInterval";
            this.edtBurstInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtBurstInterval.Size = new System.Drawing.Size(58, 23);
            this.edtBurstInterval.TabIndex = 21;
            this.edtBurstInterval.Text = "0";
            this.edtBurstInterval.TextChanged += new System.EventHandler(this.edtBurstInterval_TextChanged);
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.BackColor = System.Drawing.SystemColors.Control;
            this.Label34.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label34.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label34.Location = new System.Drawing.Point(72, 64);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label34.Size = new System.Drawing.Size(394, 16);
            this.Label34.TabIndex = 28;
            this.Label34.Text = "number of frames to capture  (0 = capture frames indefinitely)";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.BackColor = System.Drawing.SystemColors.Control;
            this.Label35.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label35.Location = new System.Drawing.Point(72, 101);
            this.Label35.Name = "Label35";
            this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label35.Size = new System.Drawing.Size(319, 16);
            this.Label35.TabIndex = 27;
            this.Label35.Text = "number of frames to skip for each frame captured";
            // 
            // grbOneShot
            // 
            this.grbOneShot.BackColor = System.Drawing.SystemColors.Control;
            this.grbOneShot.Controls.Add(this.edtUseThisFileName);
            this.grbOneShot.Controls.Add(this.btnOneShotClipboard);
            this.grbOneShot.Controls.Add(this.chkUseThisFileName);
            this.grbOneShot.Controls.Add(this.btnOneShotTBitmap);
            this.grbOneShot.Controls.Add(this.btnOneShotBMPFile);
            this.grbOneShot.Controls.Add(this.btnOneShotJPEGFile);
            this.grbOneShot.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbOneShot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbOneShot.Location = new System.Drawing.Point(364, 24);
            this.grbOneShot.Name = "grbOneShot";
            this.grbOneShot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbOneShot.Size = new System.Drawing.Size(516, 104);
            this.grbOneShot.TabIndex = 45;
            this.grbOneShot.TabStop = false;
            this.grbOneShot.Text = "one-shot frame capture to...";
            // 
            // edtUseThisFileName
            // 
            this.edtUseThisFileName.AcceptsReturn = true;
            this.edtUseThisFileName.BackColor = System.Drawing.SystemColors.Window;
            this.edtUseThisFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtUseThisFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtUseThisFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtUseThisFileName.Location = new System.Drawing.Point(392, 61);
            this.edtUseThisFileName.MaxLength = 0;
            this.edtUseThisFileName.Name = "edtUseThisFileName";
            this.edtUseThisFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtUseThisFileName.Size = new System.Drawing.Size(113, 23);
            this.edtUseThisFileName.TabIndex = 18;
            this.edtUseThisFileName.Text = "CapFile01";
            // 
            // btnOneShotClipboard
            // 
            this.btnOneShotClipboard.BackColor = System.Drawing.SystemColors.Control;
            this.btnOneShotClipboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOneShotClipboard.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOneShotClipboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOneShotClipboard.Location = new System.Drawing.Point(314, 24);
            this.btnOneShotClipboard.Name = "btnOneShotClipboard";
            this.btnOneShotClipboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOneShotClipboard.Size = new System.Drawing.Size(91, 35);
            this.btnOneShotClipboard.TabIndex = 20;
            this.btnOneShotClipboard.Text = "Clipboard";
            this.btnOneShotClipboard.UseVisualStyleBackColor = false;
            this.btnOneShotClipboard.Click += new System.EventHandler(this.btnOneShotClipboard_Click);
            // 
            // chkUseThisFileName
            // 
            this.chkUseThisFileName.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseThisFileName.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseThisFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUseThisFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseThisFileName.Location = new System.Drawing.Point(12, 64);
            this.chkUseThisFileName.Name = "chkUseThisFileName";
            this.chkUseThisFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseThisFileName.Size = new System.Drawing.Size(392, 27);
            this.chkUseThisFileName.TabIndex = 19;
            this.chkUseThisFileName.Text = "don\'t generate file name automatically, use instead:";
            this.chkUseThisFileName.UseVisualStyleBackColor = false;
            this.chkUseThisFileName.CheckedChanged += new System.EventHandler(this.chkUseThisFileName_CheckedChanged);
            // 
            // btnOneShotTBitmap
            // 
            this.btnOneShotTBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.btnOneShotTBitmap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOneShotTBitmap.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOneShotTBitmap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOneShotTBitmap.Location = new System.Drawing.Point(12, 24);
            this.btnOneShotTBitmap.Name = "btnOneShotTBitmap";
            this.btnOneShotTBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOneShotTBitmap.Size = new System.Drawing.Size(91, 35);
            this.btnOneShotTBitmap.TabIndex = 17;
            this.btnOneShotTBitmap.Text = "TBitmap";
            this.btnOneShotTBitmap.UseVisualStyleBackColor = false;
            this.btnOneShotTBitmap.Click += new System.EventHandler(this.btnOneShotTBitmap_Click);
            // 
            // btnOneShotBMPFile
            // 
            this.btnOneShotBMPFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOneShotBMPFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOneShotBMPFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOneShotBMPFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOneShotBMPFile.Location = new System.Drawing.Point(112, 24);
            this.btnOneShotBMPFile.Name = "btnOneShotBMPFile";
            this.btnOneShotBMPFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOneShotBMPFile.Size = new System.Drawing.Size(91, 35);
            this.btnOneShotBMPFile.TabIndex = 16;
            this.btnOneShotBMPFile.Text = "BMP file";
            this.btnOneShotBMPFile.UseVisualStyleBackColor = false;
            this.btnOneShotBMPFile.Click += new System.EventHandler(this.btnOneShotBMPFile_Click);
            // 
            // btnOneShotJPEGFile
            // 
            this.btnOneShotJPEGFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOneShotJPEGFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOneShotJPEGFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOneShotJPEGFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOneShotJPEGFile.Location = new System.Drawing.Point(212, 24);
            this.btnOneShotJPEGFile.Name = "btnOneShotJPEGFile";
            this.btnOneShotJPEGFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOneShotJPEGFile.Size = new System.Drawing.Size(91, 35);
            this.btnOneShotJPEGFile.TabIndex = 15;
            this.btnOneShotJPEGFile.Text = "JPEG file";
            this.btnOneShotJPEGFile.UseVisualStyleBackColor = false;
            this.btnOneShotJPEGFile.Click += new System.EventHandler(this.btnOneShotJPEGFile_Click);
            // 
            // rgdFrameGrabberFormat
            // 
            this.rgdFrameGrabberFormat.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormat.Controls.Add(this.rgdFrameGrabberFormatRGB8);
            this.rgdFrameGrabberFormat.Controls.Add(this.rgdFrameGrabberFormatRGB555);
            this.rgdFrameGrabberFormat.Controls.Add(this.rgdFrameGrabberFormatDefault);
            this.rgdFrameGrabberFormat.Controls.Add(this.rgdFrameGrabberFormatRGB32);
            this.rgdFrameGrabberFormat.Controls.Add(this.rgdFrameGrabberFormatRGB24);
            this.rgdFrameGrabberFormat.Controls.Add(this.rgdFrameGrabberFormat565);
            this.rgdFrameGrabberFormat.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormat.Location = new System.Drawing.Point(156, 24);
            this.rgdFrameGrabberFormat.Name = "rgdFrameGrabberFormat";
            this.rgdFrameGrabberFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormat.Size = new System.Drawing.Size(200, 124);
            this.rgdFrameGrabberFormat.TabIndex = 44;
            this.rgdFrameGrabberFormat.TabStop = false;
            this.rgdFrameGrabberFormat.Text = "frame grabber format";
            // 
            // rgdFrameGrabberFormatRGB8
            // 
            this.rgdFrameGrabberFormatRGB8.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormatRGB8.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberFormatRGB8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormatRGB8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormatRGB8.Location = new System.Drawing.Point(97, 80);
            this.rgdFrameGrabberFormatRGB8.Name = "rgdFrameGrabberFormatRGB8";
            this.rgdFrameGrabberFormatRGB8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormatRGB8.Size = new System.Drawing.Size(91, 27);
            this.rgdFrameGrabberFormatRGB8.TabIndex = 8;
            this.rgdFrameGrabberFormatRGB8.TabStop = true;
            this.rgdFrameGrabberFormatRGB8.Tag = "5";
            this.rgdFrameGrabberFormatRGB8.Text = "RGB8";
            this.rgdFrameGrabberFormatRGB8.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberFormatRGB8.CheckedChanged += new System.EventHandler(this.rgdFrameGrabberFormat_CheckedChanged);
            // 
            // rgdFrameGrabberFormatRGB555
            // 
            this.rgdFrameGrabberFormatRGB555.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormatRGB555.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberFormatRGB555.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormatRGB555.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormatRGB555.Location = new System.Drawing.Point(97, 52);
            this.rgdFrameGrabberFormatRGB555.Name = "rgdFrameGrabberFormatRGB555";
            this.rgdFrameGrabberFormatRGB555.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormatRGB555.Size = new System.Drawing.Size(91, 27);
            this.rgdFrameGrabberFormatRGB555.TabIndex = 9;
            this.rgdFrameGrabberFormatRGB555.TabStop = true;
            this.rgdFrameGrabberFormatRGB555.Tag = "4";
            this.rgdFrameGrabberFormatRGB555.Text = "RGB555";
            this.rgdFrameGrabberFormatRGB555.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberFormatRGB555.CheckedChanged += new System.EventHandler(this.rgdFrameGrabberFormat_CheckedChanged);
            // 
            // rgdFrameGrabberFormatDefault
            // 
            this.rgdFrameGrabberFormatDefault.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormatDefault.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberFormatDefault.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormatDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormatDefault.Location = new System.Drawing.Point(12, 24);
            this.rgdFrameGrabberFormatDefault.Name = "rgdFrameGrabberFormatDefault";
            this.rgdFrameGrabberFormatDefault.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormatDefault.Size = new System.Drawing.Size(78, 27);
            this.rgdFrameGrabberFormatDefault.TabIndex = 13;
            this.rgdFrameGrabberFormatDefault.TabStop = true;
            this.rgdFrameGrabberFormatDefault.Tag = "0";
            this.rgdFrameGrabberFormatDefault.Text = "default";
            this.rgdFrameGrabberFormatDefault.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberFormatDefault.CheckedChanged += new System.EventHandler(this.rgdFrameGrabberFormat_CheckedChanged);
            // 
            // rgdFrameGrabberFormatRGB32
            // 
            this.rgdFrameGrabberFormatRGB32.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormatRGB32.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberFormatRGB32.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormatRGB32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormatRGB32.Location = new System.Drawing.Point(12, 52);
            this.rgdFrameGrabberFormatRGB32.Name = "rgdFrameGrabberFormatRGB32";
            this.rgdFrameGrabberFormatRGB32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormatRGB32.Size = new System.Drawing.Size(91, 27);
            this.rgdFrameGrabberFormatRGB32.TabIndex = 12;
            this.rgdFrameGrabberFormatRGB32.TabStop = true;
            this.rgdFrameGrabberFormatRGB32.Tag = "1";
            this.rgdFrameGrabberFormatRGB32.Text = "RGB32";
            this.rgdFrameGrabberFormatRGB32.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberFormatRGB32.CheckedChanged += new System.EventHandler(this.rgdFrameGrabberFormat_CheckedChanged);
            // 
            // rgdFrameGrabberFormatRGB24
            // 
            this.rgdFrameGrabberFormatRGB24.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormatRGB24.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberFormatRGB24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormatRGB24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormatRGB24.Location = new System.Drawing.Point(12, 80);
            this.rgdFrameGrabberFormatRGB24.Name = "rgdFrameGrabberFormatRGB24";
            this.rgdFrameGrabberFormatRGB24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormatRGB24.Size = new System.Drawing.Size(91, 27);
            this.rgdFrameGrabberFormatRGB24.TabIndex = 11;
            this.rgdFrameGrabberFormatRGB24.TabStop = true;
            this.rgdFrameGrabberFormatRGB24.Tag = "2";
            this.rgdFrameGrabberFormatRGB24.Text = "RGB24";
            this.rgdFrameGrabberFormatRGB24.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberFormatRGB24.CheckedChanged += new System.EventHandler(this.rgdFrameGrabberFormat_CheckedChanged);
            // 
            // rgdFrameGrabberFormat565
            // 
            this.rgdFrameGrabberFormat565.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberFormat565.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberFormat565.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberFormat565.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgdFrameGrabberFormat565.Location = new System.Drawing.Point(97, 24);
            this.rgdFrameGrabberFormat565.Name = "rgdFrameGrabberFormat565";
            this.rgdFrameGrabberFormat565.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberFormat565.Size = new System.Drawing.Size(91, 27);
            this.rgdFrameGrabberFormat565.TabIndex = 10;
            this.rgdFrameGrabberFormat565.TabStop = true;
            this.rgdFrameGrabberFormat565.Tag = "3";
            this.rgdFrameGrabberFormat565.Text = "RGB565";
            this.rgdFrameGrabberFormat565.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberFormat565.CheckedChanged += new System.EventHandler(this.rgdFrameGrabberFormat_CheckedChanged);
            // 
            // rgdFrameGrabber
            // 
            this.rgdFrameGrabber.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabber.Controls.Add(this.rgdFrameGrabberPreviewStream);
            this.rgdFrameGrabber.Controls.Add(this.rgdFrameGrabberCaptureStream);
            this.rgdFrameGrabber.Controls.Add(this.rgdFrameGrabberDisabled);
            this.rgdFrameGrabber.Controls.Add(this.rgdFrameGrabberBothStreams);
            this.rgdFrameGrabber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rgdFrameGrabber.Location = new System.Drawing.Point(6, 24);
            this.rgdFrameGrabber.Name = "rgdFrameGrabber";
            this.rgdFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabber.Size = new System.Drawing.Size(142, 149);
            this.rgdFrameGrabber.TabIndex = 41;
            this.rgdFrameGrabber.TabStop = false;
            this.rgdFrameGrabber.Text = "Frame grabber";
            // 
            // rgdFrameGrabberPreviewStream
            // 
            this.rgdFrameGrabberPreviewStream.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberPreviewStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberPreviewStream.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberPreviewStream.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rgdFrameGrabberPreviewStream.Location = new System.Drawing.Point(8, 53);
            this.rgdFrameGrabberPreviewStream.Name = "rgdFrameGrabberPreviewStream";
            this.rgdFrameGrabberPreviewStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberPreviewStream.Size = new System.Drawing.Size(113, 27);
            this.rgdFrameGrabberPreviewStream.TabIndex = 3;
            this.rgdFrameGrabberPreviewStream.TabStop = true;
            this.rgdFrameGrabberPreviewStream.Tag = "1";
            this.rgdFrameGrabberPreviewStream.Text = "preview";
            this.rgdFrameGrabberPreviewStream.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberPreviewStream.CheckedChanged += new System.EventHandler(this.rgdFrameGrabber_CheckedChanged);
            // 
            // rgdFrameGrabberCaptureStream
            // 
            this.rgdFrameGrabberCaptureStream.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberCaptureStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberCaptureStream.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberCaptureStream.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rgdFrameGrabberCaptureStream.Location = new System.Drawing.Point(8, 83);
            this.rgdFrameGrabberCaptureStream.Name = "rgdFrameGrabberCaptureStream";
            this.rgdFrameGrabberCaptureStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberCaptureStream.Size = new System.Drawing.Size(113, 26);
            this.rgdFrameGrabberCaptureStream.TabIndex = 2;
            this.rgdFrameGrabberCaptureStream.TabStop = true;
            this.rgdFrameGrabberCaptureStream.Tag = "2";
            this.rgdFrameGrabberCaptureStream.Text = "capture";
            this.rgdFrameGrabberCaptureStream.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberCaptureStream.CheckedChanged += new System.EventHandler(this.rgdFrameGrabber_CheckedChanged);
            // 
            // rgdFrameGrabberDisabled
            // 
            this.rgdFrameGrabberDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberDisabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberDisabled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberDisabled.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rgdFrameGrabberDisabled.Location = new System.Drawing.Point(8, 112);
            this.rgdFrameGrabberDisabled.Name = "rgdFrameGrabberDisabled";
            this.rgdFrameGrabberDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberDisabled.Size = new System.Drawing.Size(113, 27);
            this.rgdFrameGrabberDisabled.TabIndex = 1;
            this.rgdFrameGrabberDisabled.TabStop = true;
            this.rgdFrameGrabberDisabled.Tag = "3";
            this.rgdFrameGrabberDisabled.Text = "disabled";
            this.rgdFrameGrabberDisabled.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberDisabled.CheckedChanged += new System.EventHandler(this.rgdFrameGrabber_CheckedChanged);
            // 
            // rgdFrameGrabberBothStreams
            // 
            this.rgdFrameGrabberBothStreams.BackColor = System.Drawing.SystemColors.Control;
            this.rgdFrameGrabberBothStreams.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgdFrameGrabberBothStreams.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgdFrameGrabberBothStreams.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rgdFrameGrabberBothStreams.Location = new System.Drawing.Point(8, 24);
            this.rgdFrameGrabberBothStreams.Name = "rgdFrameGrabberBothStreams";
            this.rgdFrameGrabberBothStreams.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgdFrameGrabberBothStreams.Size = new System.Drawing.Size(125, 27);
            this.rgdFrameGrabberBothStreams.TabIndex = 4;
            this.rgdFrameGrabberBothStreams.TabStop = true;
            this.rgdFrameGrabberBothStreams.Tag = "0";
            this.rgdFrameGrabberBothStreams.Text = "both streams";
            this.rgdFrameGrabberBothStreams.UseVisualStyleBackColor = false;
            this.rgdFrameGrabberBothStreams.CheckedChanged += new System.EventHandler(this.rgdFrameGrabber_CheckedChanged);
            // 
            // FrameGrabber
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1299, 287);
            this.ControlBox = false;
            this.Controls.Add(this.edtFrameCaptureHeight);
            this.Controls.Add(this.edtFrameCaptureWidth);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Frame11);
            this.Controls.Add(this.mmoFrameCaptureLog);
            this.Controls.Add(this.Label32);
            this.Controls.Add(this.Label33);
            this.Controls.Add(this.rdgAutoFileName);
            this.Controls.Add(this.grbBurstMode);
            this.Controls.Add(this.grbOneShot);
            this.Controls.Add(this.rgdFrameGrabberFormat);
            this.Controls.Add(this.rgdFrameGrabber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrameGrabber";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.FrameGrabber_VisibleChanged);
            this.Frame11.ResumeLayout(false);
            this.Frame11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrCaptureZoomSize)).EndInit();
            this.rdgAutoFileName.ResumeLayout(false);
            this.rdgAutoFileName.PerformLayout();
            this.grbBurstMode.ResumeLayout(false);
            this.grbBurstMode.PerformLayout();
            this.grbOneShot.ResumeLayout(false);
            this.grbOneShot.PerformLayout();
            this.rgdFrameGrabberFormat.ResumeLayout(false);
            this.rgdFrameGrabber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip ToolTip1;
        private TextBox edtFrameCaptureHeight;
        private TextBox edtFrameCaptureWidth;
        private Label Label3;
        private Label Label2;
        private GroupBox Frame11;
        private TrackBar tbrCaptureZoomSize;
        private Button btnResetCaptureZoomSize;
        private TextBox edtCaptureZoomSize;
        internal TextBox mmoFrameCaptureLog;
        private Label Label32;
        private Label Label33;
        private GroupBox rdgAutoFileName;
        private TextBox edtAVIAutoFilePrefix;
        private RadioButton rdgAutoFileName1;
        private RadioButton rdgAutoFileName2;
        private Label Label1;
        private GroupBox grbBurstMode;
        private Button btnBurstModeClipboard;
        private Button btnBurstModeStop;
        private Button btnBurstModeJPEGFile;
        private Button btnBurstModeBMPFile;
        private Button btnBurstModeTBitmap;
        private TextBox edtBurstCount;
        private TextBox edtBurstInterval;
        private Label Label34;
        private Label Label35;
        private GroupBox grbOneShot;
        private TextBox edtUseThisFileName;
        private Button btnOneShotClipboard;
        private CheckBox chkUseThisFileName;
        private Button btnOneShotTBitmap;
        private Button btnOneShotBMPFile;
        private Button btnOneShotJPEGFile;
        private GroupBox rgdFrameGrabberFormat;
        private RadioButton rgdFrameGrabberFormatRGB8;
        private RadioButton rgdFrameGrabberFormatRGB555;
        private RadioButton rgdFrameGrabberFormatDefault;
        private RadioButton rgdFrameGrabberFormatRGB32;
        private RadioButton rgdFrameGrabberFormatRGB24;
        private RadioButton rgdFrameGrabberFormat565;
        private GroupBox rgdFrameGrabber;
        private RadioButton rgdFrameGrabberPreviewStream;
        private RadioButton rgdFrameGrabberCaptureStream;
        private RadioButton rgdFrameGrabberDisabled;
        private RadioButton rgdFrameGrabberBothStreams;
        private RadioButton rdgAutoFileName3;
    }
}

