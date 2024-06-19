using System.Windows.Forms;

namespace MainDemo
{
    partial class VideoProcessing : Form
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
            this.grbDetectVideoSignal = new System.Windows.Forms.GroupBox();
            this.rdgConnexantbluescreen = new System.Windows.Forms.RadioButton();
            this.rdgNoVideoSignal = new System.Windows.Forms.RadioButton();
            this.rdgDetectVideoSignalDisabled = new System.Windows.Forms.RadioButton();
            this.grbSoftwareVideoProcessing = new System.Windows.Forms.GroupBox();
            this.lblSWVideoProcessingRequiresFrameGrabber = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.updVideoPixelization = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbrHue = new System.Windows.Forms.TrackBar();
            this.tbrSaturation = new System.Windows.Forms.TrackBar();
            this.tbrContrast = new System.Windows.Forms.TrackBar();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.rdgVideoRotation = new System.Windows.Forms.GroupBox();
            this.edtCustomRotationAngle = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.rdgVideoRotation9 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation7 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation6 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation5 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation4 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation0 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation2 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation1 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation3 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation8 = new System.Windows.Forms.RadioButton();
            this.rdgDeinterlacing = new System.Windows.Forms.GroupBox();
            this.rdgDeinterlacingFullSize = new System.Windows.Forms.RadioButton();
            this.rdgDeinterlacingHalfSize = new System.Windows.Forms.RadioButton();
            this.rdgDeinterlacingDisabled = new System.Windows.Forms.RadioButton();
            this.chkFlipVertical = new System.Windows.Forms.CheckBox();
            this.chkFlipHorizontal = new System.Windows.Forms.CheckBox();
            this.chkInvertColors = new System.Windows.Forms.CheckBox();
            this.chkGreyScale = new System.Windows.Forms.CheckBox();
            this.grbCropping = new System.Windows.Forms.GroupBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.trkCroppingZoom = new System.Windows.Forms.TrackBar();
            this.trkCroppingY = new System.Windows.Forms.TrackBar();
            this.trkCroppingX = new System.Windows.Forms.TrackBar();
            this.chkCroppingEnabled = new System.Windows.Forms.CheckBox();
            this.chkCroppingOutbounds = new System.Windows.Forms.CheckBox();
            this.edtCroppingWidth = new System.Windows.Forms.TextBox();
            this.edtCroppingHeight = new System.Windows.Forms.TextBox();
            this.btnCroppingZoomReset = new System.Windows.Forms.Button();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.grbVMR9Adjust = new System.Windows.Forms.GroupBox();
            this.lblVMR9Available = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbrVMR9Hue = new System.Windows.Forms.TrackBar();
            this.tbrVMR9Saturation = new System.Windows.Forms.TrackBar();
            this.tbrVMR9Contrast = new System.Windows.Forms.TrackBar();
            this.tbrVMR9Brightness = new System.Windows.Forms.TrackBar();
            this.vmr9FixRange = new System.Windows.Forms.CheckBox();
            this.grbDetectVideoSignal.SuspendLayout();
            this.grbSoftwareVideoProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updVideoPixelization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.rdgVideoRotation.SuspendLayout();
            this.rdgDeinterlacing.SuspendLayout();
            this.grbCropping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingX)).BeginInit();
            this.grbVMR9Adjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetectVideoSignal
            // 
            this.grbDetectVideoSignal.Controls.Add(this.rdgConnexantbluescreen);
            this.grbDetectVideoSignal.Controls.Add(this.rdgNoVideoSignal);
            this.grbDetectVideoSignal.Controls.Add(this.rdgDetectVideoSignalDisabled);
            this.grbDetectVideoSignal.Location = new System.Drawing.Point(678, 201);
            this.grbDetectVideoSignal.Name = "grbDetectVideoSignal";
            this.grbDetectVideoSignal.Size = new System.Drawing.Size(588, 71);
            this.grbDetectVideoSignal.TabIndex = 26;
            this.grbDetectVideoSignal.TabStop = false;
            this.grbDetectVideoSignal.Text = "Detect video signal (adjustable)";
            // 
            // rdgConnexantbluescreen
            // 
            this.rdgConnexantbluescreen.AutoSize = true;
            this.rdgConnexantbluescreen.Location = new System.Drawing.Point(391, 31);
            this.rdgConnexantbluescreen.Name = "rdgConnexantbluescreen";
            this.rdgConnexantbluescreen.Size = new System.Drawing.Size(171, 24);
            this.rdgConnexantbluescreen.TabIndex = 2;
            this.rdgConnexantbluescreen.Text = "Conexant blue screen";
            this.rdgConnexantbluescreen.CheckedChanged += new System.EventHandler(this.rdgConnexantbluescreen_CheckedChanged);
            // 
            // rdgNoVideoSignal
            // 
            this.rdgNoVideoSignal.AutoSize = true;
            this.rdgNoVideoSignal.Location = new System.Drawing.Point(161, 31);
            this.rdgNoVideoSignal.Name = "rdgNoVideoSignal";
            this.rdgNoVideoSignal.Size = new System.Drawing.Size(179, 24);
            this.rdgNoVideoSignal.TabIndex = 1;
            this.rdgNoVideoSignal.Text = "no signal (dark screen)";
            this.rdgNoVideoSignal.CheckedChanged += new System.EventHandler(this.rdgNoVideoSignal_CheckedChanged);
            // 
            // rdgDetectVideoSignalDisabled
            // 
            this.rdgDetectVideoSignalDisabled.AutoSize = true;
            this.rdgDetectVideoSignalDisabled.Checked = true;
            this.rdgDetectVideoSignalDisabled.Location = new System.Drawing.Point(35, 31);
            this.rdgDetectVideoSignalDisabled.Name = "rdgDetectVideoSignalDisabled";
            this.rdgDetectVideoSignalDisabled.Size = new System.Drawing.Size(87, 24);
            this.rdgDetectVideoSignalDisabled.TabIndex = 0;
            this.rdgDetectVideoSignalDisabled.TabStop = true;
            this.rdgDetectVideoSignalDisabled.Text = "disabled";
            this.rdgDetectVideoSignalDisabled.CheckedChanged += new System.EventHandler(this.rdgDetectVideoSignalDisabled_CheckedChanged);
            // 
            // grbSoftwareVideoProcessing
            // 
            this.grbSoftwareVideoProcessing.BackColor = System.Drawing.SystemColors.Control;
            this.grbSoftwareVideoProcessing.Controls.Add(this.lblSWVideoProcessingRequiresFrameGrabber);
            this.grbSoftwareVideoProcessing.Controls.Add(this.Label1);
            this.grbSoftwareVideoProcessing.Controls.Add(this.updVideoPixelization);
            this.grbSoftwareVideoProcessing.Controls.Add(this.Label3);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrHue);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrSaturation);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrContrast);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrBrightness);
            this.grbSoftwareVideoProcessing.Controls.Add(this.btnResetAll);
            this.grbSoftwareVideoProcessing.Controls.Add(this.rdgVideoRotation);
            this.grbSoftwareVideoProcessing.Controls.Add(this.rdgDeinterlacing);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkFlipVertical);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkFlipHorizontal);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkInvertColors);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkGreyScale);
            this.grbSoftwareVideoProcessing.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbSoftwareVideoProcessing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbSoftwareVideoProcessing.Location = new System.Drawing.Point(6, 0);
            this.grbSoftwareVideoProcessing.Name = "grbSoftwareVideoProcessing";
            this.grbSoftwareVideoProcessing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbSoftwareVideoProcessing.Size = new System.Drawing.Size(661, 272);
            this.grbSoftwareVideoProcessing.TabIndex = 25;
            this.grbSoftwareVideoProcessing.TabStop = false;
            this.grbSoftwareVideoProcessing.Text = "Software video processing";
            // 
            // lblSWVideoProcessingRequiresFrameGrabber
            // 
            this.lblSWVideoProcessingRequiresFrameGrabber.AutoSize = true;
            this.lblSWVideoProcessingRequiresFrameGrabber.ForeColor = System.Drawing.Color.Red;
            this.lblSWVideoProcessingRequiresFrameGrabber.Location = new System.Drawing.Point(240, 0);
            this.lblSWVideoProcessingRequiresFrameGrabber.Name = "lblSWVideoProcessingRequiresFrameGrabber";
            this.lblSWVideoProcessingRequiresFrameGrabber.Size = new System.Drawing.Size(230, 16);
            this.lblSWVideoProcessingRequiresFrameGrabber.TabIndex = 48;
            this.lblSWVideoProcessingRequiresFrameGrabber.Text = "the frame grabber must be enabled";
            this.lblSWVideoProcessingRequiresFrameGrabber.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(476, 228);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(157, 16);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "bright  contr. satur.  hue";
            // 
            // updVideoPixelization
            // 
            this.updVideoPixelization.Location = new System.Drawing.Point(412, 201);
            this.updVideoPixelization.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updVideoPixelization.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updVideoPixelization.Name = "updVideoPixelization";
            this.updVideoPixelization.Size = new System.Drawing.Size(56, 23);
            this.updVideoPixelization.TabIndex = 45;
            this.updVideoPixelization.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updVideoPixelization.ValueChanged += new System.EventHandler(this.updVideoPixelization_ValueChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(321, 204);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 16);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "pixellization:";
            // 
            // tbrHue
            // 
            this.tbrHue.AutoSize = false;
            this.tbrHue.Location = new System.Drawing.Point(622, 27);
            this.tbrHue.Maximum = 180;
            this.tbrHue.Minimum = -180;
            this.tbrHue.Name = "tbrHue";
            this.tbrHue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrHue.Size = new System.Drawing.Size(24, 205);
            this.tbrHue.TabIndex = 44;
            this.tbrHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrHue.Scroll += new System.EventHandler(this.tbrHue_Scroll);
            // 
            // tbrSaturation
            // 
            this.tbrSaturation.AutoSize = false;
            this.tbrSaturation.Location = new System.Drawing.Point(580, 28);
            this.tbrSaturation.Maximum = 64;
            this.tbrSaturation.Minimum = -64;
            this.tbrSaturation.Name = "tbrSaturation";
            this.tbrSaturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrSaturation.Size = new System.Drawing.Size(24, 204);
            this.tbrSaturation.TabIndex = 43;
            this.tbrSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrSaturation.Scroll += new System.EventHandler(this.tbrSaturation_Scroll);
            // 
            // tbrContrast
            // 
            this.tbrContrast.AutoSize = false;
            this.tbrContrast.Location = new System.Drawing.Point(538, 28);
            this.tbrContrast.Maximum = 128;
            this.tbrContrast.Minimum = -128;
            this.tbrContrast.Name = "tbrContrast";
            this.tbrContrast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrContrast.Size = new System.Drawing.Size(24, 204);
            this.tbrContrast.TabIndex = 42;
            this.tbrContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrContrast.Scroll += new System.EventHandler(this.tbrContrast_Scroll);
            // 
            // tbrBrightness
            // 
            this.tbrBrightness.AutoSize = false;
            this.tbrBrightness.Location = new System.Drawing.Point(496, 28);
            this.tbrBrightness.Maximum = 128;
            this.tbrBrightness.Minimum = -128;
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrBrightness.Size = new System.Drawing.Size(24, 204);
            this.tbrBrightness.TabIndex = 41;
            this.tbrBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrBrightness.Scroll += new System.EventHandler(this.tbrBrightness_Scroll);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResetAll.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetAll.Location = new System.Drawing.Point(23, 32);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetAll.Size = new System.Drawing.Size(154, 32);
            this.btnResetAll.TabIndex = 39;
            this.btnResetAll.Text = "reset all";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // rdgVideoRotation
            // 
            this.rdgVideoRotation.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation.Controls.Add(this.edtCustomRotationAngle);
            this.rdgVideoRotation.Controls.Add(this.Label4);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation9);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation7);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation6);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation5);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation4);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation0);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation2);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation1);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation3);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation8);
            this.rdgVideoRotation.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation.Location = new System.Drawing.Point(12, 73);
            this.rdgVideoRotation.Name = "rdgVideoRotation";
            this.rdgVideoRotation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation.Size = new System.Drawing.Size(301, 190);
            this.rdgVideoRotation.TabIndex = 30;
            this.rdgVideoRotation.TabStop = false;
            this.rdgVideoRotation.Text = "Video rotation (in degrees)";
            // 
            // edtCustomRotationAngle
            // 
            this.edtCustomRotationAngle.Location = new System.Drawing.Point(233, 148);
            this.edtCustomRotationAngle.Name = "edtCustomRotationAngle";
            this.edtCustomRotationAngle.Size = new System.Drawing.Size(56, 23);
            this.edtCustomRotationAngle.TabIndex = 50;
            this.edtCustomRotationAngle.TextChanged += new System.EventHandler(this.edtCustomRotationAngle_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 152);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(211, 16);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "custom rotation angle (<= 360°):";
            // 
            // rdgVideoRotation9
            // 
            this.rdgVideoRotation9.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation9.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation9.Location = new System.Drawing.Point(133, 117);
            this.rdgVideoRotation9.Name = "rdgVideoRotation9";
            this.rdgVideoRotation9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation9.Size = new System.Drawing.Size(146, 26);
            this.rdgVideoRotation9.TabIndex = 40;
            this.rdgVideoRotation9.TabStop = true;
            this.rdgVideoRotation9.Tag = "9";
            this.rdgVideoRotation9.Text = "custom ° mirror";
            this.rdgVideoRotation9.UseVisualStyleBackColor = false;
            this.rdgVideoRotation9.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation7
            // 
            this.rdgVideoRotation7.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation7.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation7.Location = new System.Drawing.Point(133, 92);
            this.rdgVideoRotation7.Name = "rdgVideoRotation7";
            this.rdgVideoRotation7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation7.Size = new System.Drawing.Size(113, 27);
            this.rdgVideoRotation7.TabIndex = 38;
            this.rdgVideoRotation7.TabStop = true;
            this.rdgVideoRotation7.Tag = "7";
            this.rdgVideoRotation7.Text = "270° mirror";
            this.rdgVideoRotation7.UseVisualStyleBackColor = false;
            this.rdgVideoRotation7.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation6
            // 
            this.rdgVideoRotation6.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation6.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation6.Location = new System.Drawing.Point(133, 68);
            this.rdgVideoRotation6.Name = "rdgVideoRotation6";
            this.rdgVideoRotation6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation6.Size = new System.Drawing.Size(113, 25);
            this.rdgVideoRotation6.TabIndex = 37;
            this.rdgVideoRotation6.TabStop = true;
            this.rdgVideoRotation6.Tag = "6";
            this.rdgVideoRotation6.Text = "180° mirror";
            this.rdgVideoRotation6.UseVisualStyleBackColor = false;
            this.rdgVideoRotation6.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation5
            // 
            this.rdgVideoRotation5.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation5.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation5.Location = new System.Drawing.Point(133, 43);
            this.rdgVideoRotation5.Name = "rdgVideoRotation5";
            this.rdgVideoRotation5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation5.Size = new System.Drawing.Size(112, 26);
            this.rdgVideoRotation5.TabIndex = 36;
            this.rdgVideoRotation5.TabStop = true;
            this.rdgVideoRotation5.Tag = "5";
            this.rdgVideoRotation5.Text = "90° mirror";
            this.rdgVideoRotation5.UseVisualStyleBackColor = false;
            this.rdgVideoRotation5.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation4
            // 
            this.rdgVideoRotation4.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation4.Location = new System.Drawing.Point(133, 19);
            this.rdgVideoRotation4.Name = "rdgVideoRotation4";
            this.rdgVideoRotation4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation4.Size = new System.Drawing.Size(146, 25);
            this.rdgVideoRotation4.TabIndex = 35;
            this.rdgVideoRotation4.TabStop = true;
            this.rdgVideoRotation4.Tag = "4";
            this.rdgVideoRotation4.Text = "0° mirror";
            this.rdgVideoRotation4.UseVisualStyleBackColor = false;
            this.rdgVideoRotation4.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation0
            // 
            this.rdgVideoRotation0.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation0.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation0.Location = new System.Drawing.Point(34, 19);
            this.rdgVideoRotation0.Name = "rdgVideoRotation0";
            this.rdgVideoRotation0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation0.Size = new System.Drawing.Size(57, 25);
            this.rdgVideoRotation0.TabIndex = 34;
            this.rdgVideoRotation0.TabStop = true;
            this.rdgVideoRotation0.Tag = "0";
            this.rdgVideoRotation0.Text = "0°";
            this.rdgVideoRotation0.UseVisualStyleBackColor = false;
            this.rdgVideoRotation0.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation2
            // 
            this.rdgVideoRotation2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation2.Location = new System.Drawing.Point(34, 68);
            this.rdgVideoRotation2.Name = "rdgVideoRotation2";
            this.rdgVideoRotation2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation2.Size = new System.Drawing.Size(66, 25);
            this.rdgVideoRotation2.TabIndex = 33;
            this.rdgVideoRotation2.TabStop = true;
            this.rdgVideoRotation2.Tag = "2";
            this.rdgVideoRotation2.Text = "180°";
            this.rdgVideoRotation2.UseVisualStyleBackColor = false;
            this.rdgVideoRotation2.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation1
            // 
            this.rdgVideoRotation1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation1.Location = new System.Drawing.Point(34, 43);
            this.rdgVideoRotation1.Name = "rdgVideoRotation1";
            this.rdgVideoRotation1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation1.Size = new System.Drawing.Size(57, 26);
            this.rdgVideoRotation1.TabIndex = 32;
            this.rdgVideoRotation1.TabStop = true;
            this.rdgVideoRotation1.Tag = "1";
            this.rdgVideoRotation1.Text = "90°";
            this.rdgVideoRotation1.UseVisualStyleBackColor = false;
            this.rdgVideoRotation1.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation3
            // 
            this.rdgVideoRotation3.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation3.Location = new System.Drawing.Point(34, 92);
            this.rdgVideoRotation3.Name = "rdgVideoRotation3";
            this.rdgVideoRotation3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation3.Size = new System.Drawing.Size(66, 27);
            this.rdgVideoRotation3.TabIndex = 31;
            this.rdgVideoRotation3.TabStop = true;
            this.rdgVideoRotation3.Tag = "3";
            this.rdgVideoRotation3.Text = "270°";
            this.rdgVideoRotation3.UseVisualStyleBackColor = false;
            this.rdgVideoRotation3.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation8
            // 
            this.rdgVideoRotation8.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation8.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgVideoRotation8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation8.Location = new System.Drawing.Point(34, 117);
            this.rdgVideoRotation8.Name = "rdgVideoRotation8";
            this.rdgVideoRotation8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation8.Size = new System.Drawing.Size(134, 26);
            this.rdgVideoRotation8.TabIndex = 39;
            this.rdgVideoRotation8.TabStop = true;
            this.rdgVideoRotation8.Tag = "8";
            this.rdgVideoRotation8.Text = "custom °";
            this.rdgVideoRotation8.UseVisualStyleBackColor = false;
            this.rdgVideoRotation8.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgDeinterlacing
            // 
            this.rdgDeinterlacing.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacing.Controls.Add(this.rdgDeinterlacingFullSize);
            this.rdgDeinterlacing.Controls.Add(this.rdgDeinterlacingHalfSize);
            this.rdgDeinterlacing.Controls.Add(this.rdgDeinterlacingDisabled);
            this.rdgDeinterlacing.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgDeinterlacing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacing.Location = new System.Drawing.Point(321, 73);
            this.rdgDeinterlacing.Name = "rdgDeinterlacing";
            this.rdgDeinterlacing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacing.Size = new System.Drawing.Size(147, 111);
            this.rdgDeinterlacing.TabIndex = 26;
            this.rdgDeinterlacing.TabStop = false;
            this.rdgDeinterlacing.Text = "deinterlacing";
            // 
            // rdgDeinterlacingFullSize
            // 
            this.rdgDeinterlacingFullSize.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacingFullSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgDeinterlacingFullSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgDeinterlacingFullSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacingFullSize.Location = new System.Drawing.Point(22, 73);
            this.rdgDeinterlacingFullSize.Name = "rdgDeinterlacingFullSize";
            this.rdgDeinterlacingFullSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacingFullSize.Size = new System.Drawing.Size(113, 28);
            this.rdgDeinterlacingFullSize.TabIndex = 29;
            this.rdgDeinterlacingFullSize.TabStop = true;
            this.rdgDeinterlacingFullSize.Tag = "2";
            this.rdgDeinterlacingFullSize.Text = "full size";
            this.rdgDeinterlacingFullSize.UseVisualStyleBackColor = false;
            this.rdgDeinterlacingFullSize.CheckedChanged += new System.EventHandler(this.rdgDeinterlacing_CheckedChanged);
            // 
            // rdgDeinterlacingHalfSize
            // 
            this.rdgDeinterlacingHalfSize.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacingHalfSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgDeinterlacingHalfSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgDeinterlacingHalfSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacingHalfSize.Location = new System.Drawing.Point(22, 49);
            this.rdgDeinterlacingHalfSize.Name = "rdgDeinterlacingHalfSize";
            this.rdgDeinterlacingHalfSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacingHalfSize.Size = new System.Drawing.Size(113, 28);
            this.rdgDeinterlacingHalfSize.TabIndex = 28;
            this.rdgDeinterlacingHalfSize.TabStop = true;
            this.rdgDeinterlacingHalfSize.Tag = "1";
            this.rdgDeinterlacingHalfSize.Text = "half-size";
            this.rdgDeinterlacingHalfSize.UseVisualStyleBackColor = false;
            this.rdgDeinterlacingHalfSize.CheckedChanged += new System.EventHandler(this.rdgDeinterlacing_CheckedChanged);
            // 
            // rdgDeinterlacingDisabled
            // 
            this.rdgDeinterlacingDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacingDisabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgDeinterlacingDisabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgDeinterlacingDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacingDisabled.Location = new System.Drawing.Point(22, 24);
            this.rdgDeinterlacingDisabled.Name = "rdgDeinterlacingDisabled";
            this.rdgDeinterlacingDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacingDisabled.Size = new System.Drawing.Size(113, 28);
            this.rdgDeinterlacingDisabled.TabIndex = 27;
            this.rdgDeinterlacingDisabled.TabStop = true;
            this.rdgDeinterlacingDisabled.Tag = "0";
            this.rdgDeinterlacingDisabled.Text = "disabled";
            this.rdgDeinterlacingDisabled.UseVisualStyleBackColor = false;
            this.rdgDeinterlacingDisabled.CheckedChanged += new System.EventHandler(this.rdgDeinterlacing_CheckedChanged);
            // 
            // chkFlipVertical
            // 
            this.chkFlipVertical.BackColor = System.Drawing.SystemColors.Control;
            this.chkFlipVertical.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFlipVertical.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFlipVertical.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFlipVertical.Location = new System.Drawing.Point(343, 24);
            this.chkFlipVertical.Name = "chkFlipVertical";
            this.chkFlipVertical.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFlipVertical.Size = new System.Drawing.Size(113, 27);
            this.chkFlipVertical.TabIndex = 25;
            this.chkFlipVertical.Text = "flip vertical";
            this.chkFlipVertical.UseVisualStyleBackColor = false;
            this.chkFlipVertical.CheckedChanged += new System.EventHandler(this.chkFlipVertical_CheckedChanged);
            // 
            // chkFlipHorizontal
            // 
            this.chkFlipHorizontal.BackColor = System.Drawing.SystemColors.Control;
            this.chkFlipHorizontal.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFlipHorizontal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFlipHorizontal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFlipHorizontal.Location = new System.Drawing.Point(343, 49);
            this.chkFlipHorizontal.Name = "chkFlipHorizontal";
            this.chkFlipHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFlipHorizontal.Size = new System.Drawing.Size(125, 27);
            this.chkFlipHorizontal.TabIndex = 24;
            this.chkFlipHorizontal.Text = "flip horizontal";
            this.chkFlipHorizontal.UseVisualStyleBackColor = false;
            this.chkFlipHorizontal.CheckedChanged += new System.EventHandler(this.chkFlipHorizontal_CheckedChanged);
            // 
            // chkInvertColors
            // 
            this.chkInvertColors.BackColor = System.Drawing.SystemColors.Control;
            this.chkInvertColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkInvertColors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkInvertColors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkInvertColors.Location = new System.Drawing.Point(212, 49);
            this.chkInvertColors.Name = "chkInvertColors";
            this.chkInvertColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInvertColors.Size = new System.Drawing.Size(137, 27);
            this.chkInvertColors.TabIndex = 22;
            this.chkInvertColors.Text = "inverted colors";
            this.chkInvertColors.UseVisualStyleBackColor = false;
            this.chkInvertColors.CheckedChanged += new System.EventHandler(this.chkInvertColors_CheckedChanged);
            // 
            // chkGreyScale
            // 
            this.chkGreyScale.BackColor = System.Drawing.SystemColors.Control;
            this.chkGreyScale.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkGreyScale.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkGreyScale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkGreyScale.Location = new System.Drawing.Point(212, 24);
            this.chkGreyScale.Name = "chkGreyScale";
            this.chkGreyScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkGreyScale.Size = new System.Drawing.Size(136, 27);
            this.chkGreyScale.TabIndex = 23;
            this.chkGreyScale.Text = "greyscale";
            this.chkGreyScale.UseVisualStyleBackColor = false;
            this.chkGreyScale.CheckedChanged += new System.EventHandler(this.chkGreyScale_CheckedChanged);
            // 
            // grbCropping
            // 
            this.grbCropping.BackColor = System.Drawing.SystemColors.Control;
            this.grbCropping.Controls.Add(this.Label32);
            this.grbCropping.Controls.Add(this.trkCroppingZoom);
            this.grbCropping.Controls.Add(this.trkCroppingY);
            this.grbCropping.Controls.Add(this.trkCroppingX);
            this.grbCropping.Controls.Add(this.chkCroppingEnabled);
            this.grbCropping.Controls.Add(this.chkCroppingOutbounds);
            this.grbCropping.Controls.Add(this.edtCroppingWidth);
            this.grbCropping.Controls.Add(this.edtCroppingHeight);
            this.grbCropping.Controls.Add(this.btnCroppingZoomReset);
            this.grbCropping.Controls.Add(this.Label33);
            this.grbCropping.Controls.Add(this.Label34);
            this.grbCropping.Controls.Add(this.Label35);
            this.grbCropping.Controls.Add(this.Label36);
            this.grbCropping.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbCropping.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbCropping.Location = new System.Drawing.Point(903, 1);
            this.grbCropping.Name = "grbCropping";
            this.grbCropping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbCropping.Size = new System.Drawing.Size(363, 199);
            this.grbCropping.TabIndex = 24;
            this.grbCropping.TabStop = false;
            this.grbCropping.Text = "Cropping";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.SystemColors.Control;
            this.Label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label32.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label32.Location = new System.Drawing.Point(120, 157);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(42, 16);
            this.Label32.TabIndex = 19;
            this.Label32.Text = "X pos";
            // 
            // trkCroppingZoom
            // 
            this.trkCroppingZoom.AutoSize = false;
            this.trkCroppingZoom.Location = new System.Drawing.Point(15, 112);
            this.trkCroppingZoom.Maximum = 1000;
            this.trkCroppingZoom.Name = "trkCroppingZoom";
            this.trkCroppingZoom.Size = new System.Drawing.Size(258, 31);
            this.trkCroppingZoom.TabIndex = 47;
            this.trkCroppingZoom.TickFrequency = 50;
            this.trkCroppingZoom.Value = 100;
            this.trkCroppingZoom.Scroll += new System.EventHandler(this.trkCroppingZoom_Scroll);
            // 
            // trkCroppingY
            // 
            this.trkCroppingY.AutoSize = false;
            this.trkCroppingY.Location = new System.Drawing.Point(321, 17);
            this.trkCroppingY.Maximum = 30000;
            this.trkCroppingY.Name = "trkCroppingY";
            this.trkCroppingY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkCroppingY.Size = new System.Drawing.Size(28, 172);
            this.trkCroppingY.TabIndex = 46;
            this.trkCroppingY.TickFrequency = 3000;
            this.trkCroppingY.Scroll += new System.EventHandler(this.trkCroppingY_Scroll);
            // 
            // trkCroppingX
            // 
            this.trkCroppingX.AutoSize = false;
            this.trkCroppingX.Location = new System.Drawing.Point(166, 152);
            this.trkCroppingX.Maximum = 30000;
            this.trkCroppingX.Name = "trkCroppingX";
            this.trkCroppingX.Size = new System.Drawing.Size(147, 31);
            this.trkCroppingX.TabIndex = 20;
            this.trkCroppingX.TickFrequency = 3000;
            this.trkCroppingX.Scroll += new System.EventHandler(this.trkCroppingX_Scroll);
            // 
            // chkCroppingEnabled
            // 
            this.chkCroppingEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkCroppingEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCroppingEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCroppingEnabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCroppingEnabled.Location = new System.Drawing.Point(15, 24);
            this.chkCroppingEnabled.Name = "chkCroppingEnabled";
            this.chkCroppingEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCroppingEnabled.Size = new System.Drawing.Size(91, 27);
            this.chkCroppingEnabled.TabIndex = 12;
            this.chkCroppingEnabled.Text = "enabled";
            this.chkCroppingEnabled.UseVisualStyleBackColor = false;
            this.chkCroppingEnabled.CheckedChanged += new System.EventHandler(this.chkCroppingEnabled_CheckedChanged);
            // 
            // chkCroppingOutbounds
            // 
            this.chkCroppingOutbounds.BackColor = System.Drawing.SystemColors.Control;
            this.chkCroppingOutbounds.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCroppingOutbounds.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCroppingOutbounds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCroppingOutbounds.Location = new System.Drawing.Point(15, 57);
            this.chkCroppingOutbounds.Name = "chkCroppingOutbounds";
            this.chkCroppingOutbounds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCroppingOutbounds.Size = new System.Drawing.Size(112, 26);
            this.chkCroppingOutbounds.TabIndex = 11;
            this.chkCroppingOutbounds.Text = "out bounds";
            this.chkCroppingOutbounds.UseVisualStyleBackColor = false;
            this.chkCroppingOutbounds.CheckedChanged += new System.EventHandler(this.chkCroppingOutbounds_CheckedChanged);
            // 
            // edtCroppingWidth
            // 
            this.edtCroppingWidth.AcceptsReturn = true;
            this.edtCroppingWidth.BackColor = System.Drawing.SystemColors.Window;
            this.edtCroppingWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCroppingWidth.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtCroppingWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCroppingWidth.Location = new System.Drawing.Point(223, 20);
            this.edtCroppingWidth.MaxLength = 0;
            this.edtCroppingWidth.Name = "edtCroppingWidth";
            this.edtCroppingWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCroppingWidth.Size = new System.Drawing.Size(69, 23);
            this.edtCroppingWidth.TabIndex = 10;
            this.edtCroppingWidth.TextChanged += new System.EventHandler(this.edtCroppingWidth_TextChanged);
            // 
            // edtCroppingHeight
            // 
            this.edtCroppingHeight.AcceptsReturn = true;
            this.edtCroppingHeight.BackColor = System.Drawing.SystemColors.Window;
            this.edtCroppingHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCroppingHeight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtCroppingHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCroppingHeight.Location = new System.Drawing.Point(223, 57);
            this.edtCroppingHeight.MaxLength = 0;
            this.edtCroppingHeight.Name = "edtCroppingHeight";
            this.edtCroppingHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCroppingHeight.Size = new System.Drawing.Size(69, 23);
            this.edtCroppingHeight.TabIndex = 9;
            this.edtCroppingHeight.TextChanged += new System.EventHandler(this.edtCroppingHeight_TextChanged);
            // 
            // btnCroppingZoomReset
            // 
            this.btnCroppingZoomReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnCroppingZoomReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCroppingZoomReset.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCroppingZoomReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCroppingZoomReset.Location = new System.Drawing.Point(15, 156);
            this.btnCroppingZoomReset.Name = "btnCroppingZoomReset";
            this.btnCroppingZoomReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCroppingZoomReset.Size = new System.Drawing.Size(91, 32);
            this.btnCroppingZoomReset.TabIndex = 7;
            this.btnCroppingZoomReset.Text = "reset";
            this.btnCroppingZoomReset.UseVisualStyleBackColor = false;
            this.btnCroppingZoomReset.Click += new System.EventHandler(this.btnCroppingZoomReset_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.SystemColors.Control;
            this.Label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label33.Location = new System.Drawing.Point(275, 96);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(43, 16);
            this.Label33.TabIndex = 18;
            this.Label33.Text = "Y pos";
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.SystemColors.Control;
            this.Label34.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label34.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label34.Location = new System.Drawing.Point(12, 91);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label34.Size = new System.Drawing.Size(112, 26);
            this.Label34.TabIndex = 17;
            this.Label34.Text = "cropping zoom";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.BackColor = System.Drawing.SystemColors.Control;
            this.Label35.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label35.Location = new System.Drawing.Point(135, 27);
            this.Label35.Name = "Label35";
            this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label35.Size = new System.Drawing.Size(72, 16);
            this.Label35.TabIndex = 16;
            this.Label35.Text = "area width";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.BackColor = System.Drawing.SystemColors.Control;
            this.Label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label36.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label36.Location = new System.Drawing.Point(135, 60);
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label36.Size = new System.Drawing.Size(79, 16);
            this.Label36.TabIndex = 15;
            this.Label36.Text = "area height";
            // 
            // grbVMR9Adjust
            // 
            this.grbVMR9Adjust.BackColor = System.Drawing.SystemColors.Control;
            this.grbVMR9Adjust.Controls.Add(this.lblVMR9Available);
            this.grbVMR9Adjust.Controls.Add(this.Label2);
            this.grbVMR9Adjust.Controls.Add(this.Label5);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Hue);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Saturation);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Contrast);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Brightness);
            this.grbVMR9Adjust.Controls.Add(this.vmr9FixRange);
            this.grbVMR9Adjust.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbVMR9Adjust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVMR9Adjust.Location = new System.Drawing.Point(678, 0);
            this.grbVMR9Adjust.Name = "grbVMR9Adjust";
            this.grbVMR9Adjust.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVMR9Adjust.Size = new System.Drawing.Size(213, 200);
            this.grbVMR9Adjust.TabIndex = 23;
            this.grbVMR9Adjust.TabStop = false;
            this.grbVMR9Adjust.Text = "VMR9 image adjustment";
            // 
            // lblVMR9Available
            // 
            this.lblVMR9Available.BackColor = System.Drawing.Color.Red;
            this.lblVMR9Available.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVMR9Available.Location = new System.Drawing.Point(23, 139);
            this.lblVMR9Available.Name = "lblVMR9Available";
            this.lblVMR9Available.Size = new System.Drawing.Size(14, 14);
            this.lblVMR9Available.TabIndex = 50;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(61, 167);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(137, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "bright cont. sat.  hue";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 32);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "fix\r\nrange";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbrVMR9Hue
            // 
            this.tbrVMR9Hue.AutoSize = false;
            this.tbrVMR9Hue.Location = new System.Drawing.Point(181, 20);
            this.tbrVMR9Hue.Maximum = 180;
            this.tbrVMR9Hue.Minimum = -180;
            this.tbrVMR9Hue.Name = "tbrVMR9Hue";
            this.tbrVMR9Hue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Hue.Size = new System.Drawing.Size(24, 156);
            this.tbrVMR9Hue.TabIndex = 48;
            this.tbrVMR9Hue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Hue.Scroll += new System.EventHandler(this.tbrVMR9Hue_Scroll);
            // 
            // tbrVMR9Saturation
            // 
            this.tbrVMR9Saturation.AutoSize = false;
            this.tbrVMR9Saturation.Location = new System.Drawing.Point(147, 20);
            this.tbrVMR9Saturation.Maximum = 64;
            this.tbrVMR9Saturation.Minimum = -64;
            this.tbrVMR9Saturation.Name = "tbrVMR9Saturation";
            this.tbrVMR9Saturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Saturation.Size = new System.Drawing.Size(26, 156);
            this.tbrVMR9Saturation.TabIndex = 47;
            this.tbrVMR9Saturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Saturation.Scroll += new System.EventHandler(this.tbrVMR9Saturation_Scroll);
            // 
            // tbrVMR9Contrast
            // 
            this.tbrVMR9Contrast.AutoSize = false;
            this.tbrVMR9Contrast.Location = new System.Drawing.Point(113, 20);
            this.tbrVMR9Contrast.Maximum = 128;
            this.tbrVMR9Contrast.Minimum = -128;
            this.tbrVMR9Contrast.Name = "tbrVMR9Contrast";
            this.tbrVMR9Contrast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Contrast.Size = new System.Drawing.Size(26, 156);
            this.tbrVMR9Contrast.TabIndex = 46;
            this.tbrVMR9Contrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Contrast.Scroll += new System.EventHandler(this.tbrVMR9Contrast_Scroll);
            // 
            // tbrVMR9Brightness
            // 
            this.tbrVMR9Brightness.AutoSize = false;
            this.tbrVMR9Brightness.Location = new System.Drawing.Point(79, 20);
            this.tbrVMR9Brightness.Maximum = 128;
            this.tbrVMR9Brightness.Minimum = -128;
            this.tbrVMR9Brightness.Name = "tbrVMR9Brightness";
            this.tbrVMR9Brightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Brightness.Size = new System.Drawing.Size(26, 156);
            this.tbrVMR9Brightness.TabIndex = 45;
            this.tbrVMR9Brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Brightness.Scroll += new System.EventHandler(this.tbrVMR9Brightness_Scroll);
            // 
            // vmr9FixRange
            // 
            this.vmr9FixRange.BackColor = System.Drawing.SystemColors.Control;
            this.vmr9FixRange.Checked = true;
            this.vmr9FixRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vmr9FixRange.Cursor = System.Windows.Forms.Cursors.Default;
            this.vmr9FixRange.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vmr9FixRange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vmr9FixRange.Location = new System.Drawing.Point(21, 32);
            this.vmr9FixRange.Name = "vmr9FixRange";
            this.vmr9FixRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vmr9FixRange.Size = new System.Drawing.Size(28, 32);
            this.vmr9FixRange.TabIndex = 1;
            this.vmr9FixRange.UseVisualStyleBackColor = false;
            this.vmr9FixRange.CheckedChanged += new System.EventHandler(this.vmr9FixRange_CheckedChanged);
            // 
            // VideoProcessing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1297, 294);
            this.ControlBox = false;
            this.Controls.Add(this.grbDetectVideoSignal);
            this.Controls.Add(this.grbSoftwareVideoProcessing);
            this.Controls.Add(this.grbCropping);
            this.Controls.Add(this.grbVMR9Adjust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoProcessing";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.VideoProcessing_VisibleChanged);
            this.grbDetectVideoSignal.ResumeLayout(false);
            this.grbDetectVideoSignal.PerformLayout();
            this.grbSoftwareVideoProcessing.ResumeLayout(false);
            this.grbSoftwareVideoProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updVideoPixelization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
            this.rdgVideoRotation.ResumeLayout(false);
            this.rdgVideoRotation.PerformLayout();
            this.rdgDeinterlacing.ResumeLayout(false);
            this.grbCropping.ResumeLayout(false);
            this.grbCropping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingX)).EndInit();
            this.grbVMR9Adjust.ResumeLayout(false);
            this.grbVMR9Adjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Brightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip1;
        private  GroupBox grbDetectVideoSignal;
        private  RadioButton rdgConnexantbluescreen;
        private  RadioButton rdgNoVideoSignal;
        private  RadioButton rdgDetectVideoSignalDisabled;
        private GroupBox grbSoftwareVideoProcessing;
        private Label Label1;
        private  NumericUpDown updVideoPixelization;
        private  Label Label3;
        private  TrackBar tbrHue;
        private  TrackBar tbrSaturation;
        private  TrackBar tbrContrast;
        private  TrackBar tbrBrightness;
        private Button btnResetAll;
        private GroupBox rdgVideoRotation;
        private  TextBox edtCustomRotationAngle;
        private  Label Label4;
        private RadioButton rdgVideoRotation9;
        private RadioButton rdgVideoRotation8;
        private RadioButton rdgVideoRotation7;
        private RadioButton rdgVideoRotation6;
        private RadioButton rdgVideoRotation5;
        private RadioButton rdgVideoRotation4;
        private RadioButton rdgVideoRotation0;
        private RadioButton rdgVideoRotation2;
        private RadioButton rdgVideoRotation1;
        private RadioButton rdgVideoRotation3;
        private GroupBox rdgDeinterlacing;
        private RadioButton rdgDeinterlacingFullSize;
        private RadioButton rdgDeinterlacingHalfSize;
        private RadioButton rdgDeinterlacingDisabled;
        private CheckBox chkFlipVertical;
        private CheckBox chkFlipHorizontal;
        private CheckBox chkInvertColors;
        private CheckBox chkGreyScale;
        private GroupBox grbCropping;
        private Label Label32;
        internal  TrackBar trkCroppingZoom;
        internal TrackBar trkCroppingY;
        internal TrackBar trkCroppingX;
        private CheckBox chkCroppingEnabled;
        private CheckBox chkCroppingOutbounds;
        private TextBox edtCroppingWidth;
        private TextBox edtCroppingHeight;
        private Button btnCroppingZoomReset;
        private Label Label33;
        private Label Label34;
        private Label Label35;
        private Label Label36;
        private GroupBox grbVMR9Adjust;
        private  Label lblVMR9Available;
        private Label Label2;
        private  Label Label5;
        private  TrackBar tbrVMR9Hue;
        private  TrackBar tbrVMR9Saturation;
        private  TrackBar tbrVMR9Contrast;
        private  TrackBar tbrVMR9Brightness;
        private CheckBox vmr9FixRange;
        private  Label lblSWVideoProcessingRequiresFrameGrabber;
    }
}

