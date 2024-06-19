using System.Windows.Forms;

namespace MainDemo
{
    partial class Reencoding : Form
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
            this.Label7 = new System.Windows.Forms.Label();
            this.btnStopReencoding = new System.Windows.Forms.Button();
            this.btnStartReencoding = new System.Windows.Forms.Button();
            this.rdgReencodingMethod = new System.Windows.Forms.GroupBox();
            this.rdgReencodingMethod2 = new System.Windows.Forms.RadioButton();
            this.rdgReencodingMethod1 = new System.Windows.Forms.RadioButton();
            this.grbReencodingSettings = new System.Windows.Forms.GroupBox();
            this.chkWMVOutput = new System.Windows.Forms.CheckBox();
            this.chkUseFrameGrabber = new System.Windows.Forms.CheckBox();
            this.chkIncludeAudioStream = new System.Windows.Forms.CheckBox();
            this.chkUseCurrentVideoCompressor = new System.Windows.Forms.CheckBox();
            this.chkIncludeVideoStream = new System.Windows.Forms.CheckBox();
            this.chkUseCurrentAudioCompressor = new System.Windows.Forms.CheckBox();
            this.grbStartStopTime = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.edtStartFrame = new System.Windows.Forms.TextBox();
            this.edtStopFrame = new System.Windows.Forms.TextBox();
            this.edtFrameCount = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.edtDuration = new System.Windows.Forms.TextBox();
            this.edtStartTime = new System.Windows.Forms.TextBox();
            this.edtStopTime = new System.Windows.Forms.TextBox();
            this.btnDuration = new System.Windows.Forms.Button();
            this.edtDestinationVideoClip = new System.Windows.Forms.TextBox();
            this.edtSourceVideoClip = new System.Windows.Forms.TextBox();
            this.btnSourceVideoClip = new System.Windows.Forms.Button();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.rdgReencodingMethod.SuspendLayout();
            this.grbReencodingSettings.SuspendLayout();
            this.grbStartStopTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(92, 16);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "Reencoding";
            // 
            // btnStopReencoding
            // 
            this.btnStopReencoding.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopReencoding.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopReencoding.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopReencoding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopReencoding.Location = new System.Drawing.Point(1127, 223);
            this.btnStopReencoding.Name = "btnStopReencoding";
            this.btnStopReencoding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopReencoding.Size = new System.Drawing.Size(113, 38);
            this.btnStopReencoding.TabIndex = 34;
            this.btnStopReencoding.Text = "Stop";
            this.btnStopReencoding.UseVisualStyleBackColor = false;
            this.btnStopReencoding.Click += new System.EventHandler(this.btnStopReencoding_Click);
            // 
            // btnStartReencoding
            // 
            this.btnStartReencoding.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartReencoding.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartReencoding.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartReencoding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartReencoding.Location = new System.Drawing.Point(1006, 223);
            this.btnStartReencoding.Name = "btnStartReencoding";
            this.btnStartReencoding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartReencoding.Size = new System.Drawing.Size(113, 38);
            this.btnStartReencoding.TabIndex = 33;
            this.btnStartReencoding.Text = "Start";
            this.btnStartReencoding.UseVisualStyleBackColor = false;
            this.btnStartReencoding.Click += new System.EventHandler(this.btnStartReencoding_Click);
            // 
            // rdgReencodingMethod
            // 
            this.rdgReencodingMethod.BackColor = System.Drawing.SystemColors.Control;
            this.rdgReencodingMethod.Controls.Add(this.rdgReencodingMethod2);
            this.rdgReencodingMethod.Controls.Add(this.rdgReencodingMethod1);
            this.rdgReencodingMethod.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgReencodingMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgReencodingMethod.Location = new System.Drawing.Point(712, 208);
            this.rdgReencodingMethod.Name = "rdgReencodingMethod";
            this.rdgReencodingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgReencodingMethod.Size = new System.Drawing.Size(259, 65);
            this.rdgReencodingMethod.TabIndex = 32;
            this.rdgReencodingMethod.TabStop = false;
            this.rdgReencodingMethod.Text = "reencoding method";
            // 
            // rdgReencodingMethod2
            // 
            this.rdgReencodingMethod2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgReencodingMethod2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgReencodingMethod2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgReencodingMethod2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgReencodingMethod2.Location = new System.Drawing.Point(127, 21);
            this.rdgReencodingMethod2.Name = "rdgReencodingMethod2";
            this.rdgReencodingMethod2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgReencodingMethod2.Size = new System.Drawing.Size(124, 39);
            this.rdgReencodingMethod2.TabIndex = 20;
            this.rdgReencodingMethod2.TabStop = true;
            this.rdgReencodingMethod2.Tag = "1";
            this.rdgReencodingMethod2.Text = "ASF (WMV)";
            this.rdgReencodingMethod2.UseVisualStyleBackColor = false;
            // 
            // rdgReencodingMethod1
            // 
            this.rdgReencodingMethod1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgReencodingMethod1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgReencodingMethod1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgReencodingMethod1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgReencodingMethod1.Location = new System.Drawing.Point(12, 24);
            this.rdgReencodingMethod1.Name = "rdgReencodingMethod1";
            this.rdgReencodingMethod1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgReencodingMethod1.Size = new System.Drawing.Size(135, 27);
            this.rdgReencodingMethod1.TabIndex = 21;
            this.rdgReencodingMethod1.TabStop = true;
            this.rdgReencodingMethod1.Tag = "0";
            this.rdgReencodingMethod1.Text = "AVI / MPEG";
            this.rdgReencodingMethod1.UseVisualStyleBackColor = false;
            // 
            // grbReencodingSettings
            // 
            this.grbReencodingSettings.BackColor = System.Drawing.SystemColors.Control;
            this.grbReencodingSettings.Controls.Add(this.chkWMVOutput);
            this.grbReencodingSettings.Controls.Add(this.chkUseFrameGrabber);
            this.grbReencodingSettings.Controls.Add(this.chkIncludeAudioStream);
            this.grbReencodingSettings.Controls.Add(this.chkUseCurrentVideoCompressor);
            this.grbReencodingSettings.Controls.Add(this.chkIncludeVideoStream);
            this.grbReencodingSettings.Controls.Add(this.chkUseCurrentAudioCompressor);
            this.grbReencodingSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbReencodingSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbReencodingSettings.Location = new System.Drawing.Point(709, 0);
            this.grbReencodingSettings.Name = "grbReencodingSettings";
            this.grbReencodingSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbReencodingSettings.Size = new System.Drawing.Size(563, 203);
            this.grbReencodingSettings.TabIndex = 31;
            this.grbReencodingSettings.TabStop = false;
            this.grbReencodingSettings.Text = "reencoding settings";
            // 
            // chkWMVOutput
            // 
            this.chkWMVOutput.BackColor = System.Drawing.SystemColors.Control;
            this.chkWMVOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkWMVOutput.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkWMVOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkWMVOutput.Location = new System.Drawing.Point(15, 29);
            this.chkWMVOutput.Name = "chkWMVOutput";
            this.chkWMVOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkWMVOutput.Size = new System.Drawing.Size(503, 27);
            this.chkWMVOutput.TabIndex = 18;
            this.chkWMVOutput.Text = "WMV output  (Windows Media Video)";
            this.chkWMVOutput.UseVisualStyleBackColor = false;
            // 
            // chkUseFrameGrabber
            // 
            this.chkUseFrameGrabber.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseFrameGrabber.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseFrameGrabber.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUseFrameGrabber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseFrameGrabber.Location = new System.Drawing.Point(15, 159);
            this.chkUseFrameGrabber.Name = "chkUseFrameGrabber";
            this.chkUseFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseFrameGrabber.Size = new System.Drawing.Size(540, 25);
            this.chkUseFrameGrabber.TabIndex = 17;
            this.chkUseFrameGrabber.Text = "use the frame grabber (allows text/graphics overlays, video processing...)";
            this.chkUseFrameGrabber.UseVisualStyleBackColor = false;
            // 
            // chkIncludeAudioStream
            // 
            this.chkIncludeAudioStream.BackColor = System.Drawing.SystemColors.Control;
            this.chkIncludeAudioStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIncludeAudioStream.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIncludeAudioStream.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIncludeAudioStream.Location = new System.Drawing.Point(268, 61);
            this.chkIncludeAudioStream.Name = "chkIncludeAudioStream";
            this.chkIncludeAudioStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIncludeAudioStream.Size = new System.Drawing.Size(224, 27);
            this.chkIncludeAudioStream.TabIndex = 16;
            this.chkIncludeAudioStream.Text = "includes the audio stream";
            this.chkIncludeAudioStream.UseVisualStyleBackColor = false;
            // 
            // chkUseCurrentVideoCompressor
            // 
            this.chkUseCurrentVideoCompressor.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseCurrentVideoCompressor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseCurrentVideoCompressor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUseCurrentVideoCompressor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseCurrentVideoCompressor.Location = new System.Drawing.Point(15, 93);
            this.chkUseCurrentVideoCompressor.Name = "chkUseCurrentVideoCompressor";
            this.chkUseCurrentVideoCompressor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseCurrentVideoCompressor.Size = new System.Drawing.Size(483, 27);
            this.chkUseCurrentVideoCompressor.TabIndex = 15;
            this.chkUseCurrentVideoCompressor.Text = "use the current video compressor (selected in the \"recording\" tab)";
            this.chkUseCurrentVideoCompressor.UseVisualStyleBackColor = false;
            // 
            // chkIncludeVideoStream
            // 
            this.chkIncludeVideoStream.BackColor = System.Drawing.SystemColors.Control;
            this.chkIncludeVideoStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIncludeVideoStream.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIncludeVideoStream.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIncludeVideoStream.Location = new System.Drawing.Point(15, 61);
            this.chkIncludeVideoStream.Name = "chkIncludeVideoStream";
            this.chkIncludeVideoStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIncludeVideoStream.Size = new System.Drawing.Size(214, 27);
            this.chkIncludeVideoStream.TabIndex = 14;
            this.chkIncludeVideoStream.Text = "includes the video stream";
            this.chkIncludeVideoStream.UseVisualStyleBackColor = false;
            // 
            // chkUseCurrentAudioCompressor
            // 
            this.chkUseCurrentAudioCompressor.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseCurrentAudioCompressor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseCurrentAudioCompressor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUseCurrentAudioCompressor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseCurrentAudioCompressor.Location = new System.Drawing.Point(15, 127);
            this.chkUseCurrentAudioCompressor.Name = "chkUseCurrentAudioCompressor";
            this.chkUseCurrentAudioCompressor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseCurrentAudioCompressor.Size = new System.Drawing.Size(483, 25);
            this.chkUseCurrentAudioCompressor.TabIndex = 13;
            this.chkUseCurrentAudioCompressor.Text = "use the current audio compressor (selected in the \"recording\" tab)";
            this.chkUseCurrentAudioCompressor.UseVisualStyleBackColor = false;
            // 
            // grbStartStopTime
            // 
            this.grbStartStopTime.BackColor = System.Drawing.SystemColors.Control;
            this.grbStartStopTime.Controls.Add(this.Label8);
            this.grbStartStopTime.Controls.Add(this.Label6);
            this.grbStartStopTime.Controls.Add(this.Label5);
            this.grbStartStopTime.Controls.Add(this.edtStartFrame);
            this.grbStartStopTime.Controls.Add(this.edtStopFrame);
            this.grbStartStopTime.Controls.Add(this.edtFrameCount);
            this.grbStartStopTime.Controls.Add(this.Label4);
            this.grbStartStopTime.Controls.Add(this.Label3);
            this.grbStartStopTime.Controls.Add(this.Label2);
            this.grbStartStopTime.Controls.Add(this.Label1);
            this.grbStartStopTime.Controls.Add(this.edtDuration);
            this.grbStartStopTime.Controls.Add(this.edtStartTime);
            this.grbStartStopTime.Controls.Add(this.edtStopTime);
            this.grbStartStopTime.Controls.Add(this.btnDuration);
            this.grbStartStopTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbStartStopTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbStartStopTime.Location = new System.Drawing.Point(6, 93);
            this.grbStartStopTime.Name = "grbStartStopTime";
            this.grbStartStopTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbStartStopTime.Size = new System.Drawing.Size(695, 180);
            this.grbStartStopTime.TabIndex = 30;
            this.grbStartStopTime.TabStop = false;
            this.grbStartStopTime.Text = "START / STOP   (optional)";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.Navy;
            this.Label8.Location = new System.Drawing.Point(224, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(411, 16);
            this.Label8.TabIndex = 34;
            this.Label8.Text = "Times are expressed in 100ns units, e.g. 3 seconds = 30000000";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(93, 139);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(210, 16);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "STOP position (-1 = end of clip):";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(44, 97);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(255, 16);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "START position (-1 = beginning of clip):";
            // 
            // edtStartFrame
            // 
            this.edtStartFrame.AcceptsReturn = true;
            this.edtStartFrame.BackColor = System.Drawing.SystemColors.Window;
            this.edtStartFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStartFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtStartFrame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStartFrame.Location = new System.Drawing.Point(516, 93);
            this.edtStartFrame.MaxLength = 0;
            this.edtStartFrame.Name = "edtStartFrame";
            this.edtStartFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStartFrame.Size = new System.Drawing.Size(148, 23);
            this.edtStartFrame.TabIndex = 31;
            this.edtStartFrame.Text = "-1";
            // 
            // edtStopFrame
            // 
            this.edtStopFrame.AcceptsReturn = true;
            this.edtStopFrame.BackColor = System.Drawing.SystemColors.Window;
            this.edtStopFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStopFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtStopFrame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStopFrame.Location = new System.Drawing.Point(516, 136);
            this.edtStopFrame.MaxLength = 0;
            this.edtStopFrame.Name = "edtStopFrame";
            this.edtStopFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStopFrame.Size = new System.Drawing.Size(148, 23);
            this.edtStopFrame.TabIndex = 30;
            this.edtStopFrame.Text = "-1";
            // 
            // edtFrameCount
            // 
            this.edtFrameCount.AcceptsReturn = true;
            this.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameCount.Location = new System.Drawing.Point(516, 52);
            this.edtFrameCount.MaxLength = 0;
            this.edtFrameCount.Name = "edtFrameCount";
            this.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameCount.Size = new System.Drawing.Size(148, 23);
            this.edtFrameCount.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(511, 27);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(140, 16);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "the FRAME NUMBER";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(478, 27);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(28, 16);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "OR";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(303, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(165, 16);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "the TIME (in 100ns units)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(237, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 16);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "SPECIFY";
            // 
            // edtDuration
            // 
            this.edtDuration.AcceptsReturn = true;
            this.edtDuration.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDuration.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtDuration.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDuration.Location = new System.Drawing.Point(327, 52);
            this.edtDuration.MaxLength = 0;
            this.edtDuration.Name = "edtDuration";
            this.edtDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDuration.Size = new System.Drawing.Size(148, 23);
            this.edtDuration.TabIndex = 24;
            // 
            // edtStartTime
            // 
            this.edtStartTime.AcceptsReturn = true;
            this.edtStartTime.BackColor = System.Drawing.SystemColors.Window;
            this.edtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStartTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtStartTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStartTime.Location = new System.Drawing.Point(327, 93);
            this.edtStartTime.MaxLength = 0;
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStartTime.Size = new System.Drawing.Size(148, 23);
            this.edtStartTime.TabIndex = 8;
            this.edtStartTime.Text = "-1";
            // 
            // edtStopTime
            // 
            this.edtStopTime.AcceptsReturn = true;
            this.edtStopTime.BackColor = System.Drawing.SystemColors.Window;
            this.edtStopTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStopTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtStopTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStopTime.Location = new System.Drawing.Point(327, 136);
            this.edtStopTime.MaxLength = 0;
            this.edtStopTime.Name = "edtStopTime";
            this.edtStopTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStopTime.Size = new System.Drawing.Size(148, 23);
            this.edtStopTime.TabIndex = 7;
            this.edtStopTime.Text = "-1";
            // 
            // btnDuration
            // 
            this.btnDuration.BackColor = System.Drawing.SystemColors.Control;
            this.btnDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDuration.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDuration.Location = new System.Drawing.Point(28, 52);
            this.btnDuration.Name = "btnDuration";
            this.btnDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDuration.Size = new System.Drawing.Size(289, 31);
            this.btnDuration.TabIndex = 6;
            this.btnDuration.Text = "source duration and/or frame count?";
            this.btnDuration.UseVisualStyleBackColor = false;
            this.btnDuration.Click += new System.EventHandler(this.btnDuration_Click);
            // 
            // edtDestinationVideoClip
            // 
            this.edtDestinationVideoClip.AcceptsReturn = true;
            this.edtDestinationVideoClip.BackColor = System.Drawing.SystemColors.Window;
            this.edtDestinationVideoClip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDestinationVideoClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtDestinationVideoClip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDestinationVideoClip.Location = new System.Drawing.Point(364, 47);
            this.edtDestinationVideoClip.MaxLength = 0;
            this.edtDestinationVideoClip.Name = "edtDestinationVideoClip";
            this.edtDestinationVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDestinationVideoClip.Size = new System.Drawing.Size(337, 23);
            this.edtDestinationVideoClip.TabIndex = 27;
            // 
            // edtSourceVideoClip
            // 
            this.edtSourceVideoClip.AcceptsReturn = true;
            this.edtSourceVideoClip.BackColor = System.Drawing.SystemColors.Window;
            this.edtSourceVideoClip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtSourceVideoClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtSourceVideoClip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtSourceVideoClip.Location = new System.Drawing.Point(364, 3);
            this.edtSourceVideoClip.MaxLength = 0;
            this.edtSourceVideoClip.Name = "edtSourceVideoClip";
            this.edtSourceVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtSourceVideoClip.Size = new System.Drawing.Size(337, 23);
            this.edtSourceVideoClip.TabIndex = 26;
            // 
            // btnSourceVideoClip
            // 
            this.btnSourceVideoClip.BackColor = System.Drawing.SystemColors.Control;
            this.btnSourceVideoClip.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSourceVideoClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSourceVideoClip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSourceVideoClip.ImageIndex = 0;
            this.btnSourceVideoClip.Location = new System.Drawing.Point(152, 0);
            this.btnSourceVideoClip.Name = "btnSourceVideoClip";
            this.btnSourceVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSourceVideoClip.Size = new System.Drawing.Size(203, 33);
            this.btnSourceVideoClip.TabIndex = 25;
            this.btnSourceVideoClip.Text = " source video clip...";
            this.btnSourceVideoClip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSourceVideoClip.UseVisualStyleBackColor = false;
            this.btnSourceVideoClip.Click += new System.EventHandler(this.btnSourceVideoClip_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.SystemColors.Control;
            this.Label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label33.Location = new System.Drawing.Point(141, 41);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(205, 16);
            this.Label33.TabIndex = 29;
            this.Label33.Text = "file name for the new video clip:";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.SystemColors.Control;
            this.Label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label32.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label32.Location = new System.Drawing.Point(20, 67);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(311, 16);
            this.Label32.TabIndex = 28;
            this.Label32.Text = "(extension will be \".wmv\" if WMV output enabled)";
            // 
            // Reencoding
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1310, 280);
            this.ControlBox = false;
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnStopReencoding);
            this.Controls.Add(this.btnStartReencoding);
            this.Controls.Add(this.rdgReencodingMethod);
            this.Controls.Add(this.grbReencodingSettings);
            this.Controls.Add(this.grbStartStopTime);
            this.Controls.Add(this.edtDestinationVideoClip);
            this.Controls.Add(this.edtSourceVideoClip);
            this.Controls.Add(this.btnSourceVideoClip);
            this.Controls.Add(this.Label33);
            this.Controls.Add(this.Label32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reencoding";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.Reencoding_VisibleChanged);
            this.rdgReencodingMethod.ResumeLayout(false);
            this.grbReencodingSettings.ResumeLayout(false);
            this.grbStartStopTime.ResumeLayout(false);
            this.grbStartStopTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.ToolTip ToolTip1;
        private  Label Label7;
        private Button btnStopReencoding;
        private Button btnStartReencoding;
        private GroupBox rdgReencodingMethod;
        private RadioButton rdgReencodingMethod2;
        private RadioButton rdgReencodingMethod1;
        private GroupBox grbReencodingSettings;
        private CheckBox chkWMVOutput;
        private CheckBox chkUseFrameGrabber;
        private CheckBox chkIncludeAudioStream;
        private CheckBox chkUseCurrentVideoCompressor;
        private CheckBox chkIncludeVideoStream;
        private CheckBox chkUseCurrentAudioCompressor;
        private GroupBox grbStartStopTime;
        private  Label Label8;
        private  Label Label6;
        private  Label Label5;
        private TextBox edtStartFrame;
        private TextBox edtStopFrame;
        private TextBox edtFrameCount;
        private  Label Label4;
        private  Label Label3;
        private  Label Label2;
        private  Label Label1;
        private TextBox edtDuration;
        private TextBox edtStartTime;
        private TextBox edtStopTime;
        private Button btnDuration;
        private TextBox edtDestinationVideoClip;
        private TextBox edtSourceVideoClip;
        private Button btnSourceVideoClip;
        private Label Label33;
        private Label Label32;
    }
}

