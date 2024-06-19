using System.Windows.Forms;

namespace MainDemo
{
    partial class Recording : Form
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
            this.edtRecordingFileName = new System.Windows.Forms.TextBox();
            this.btnStartRecordingImmediately = new System.Windows.Forms.Button();
            this.btnStartRecordingControlled = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnRenewRecordingFile = new System.Windows.Forms.Button();
            this.rdgRecordingMethod = new System.Windows.Forms.GroupBox();
            this.rdgRecordingMethod_MPG = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethod_WebM = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodMP4 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodFLV = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodMKV = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodSendToDV = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodAVI = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodWMV = new System.Windows.Forms.RadioButton();
            this.chkAudioRecording = new System.Windows.Forms.CheckBox();
            this.chkPreserveNativeFormat = new System.Windows.Forms.CheckBox();
            this.chkAVISaveToThisFile = new System.Windows.Forms.CheckBox();
            this.rdgRecordingTimer = new System.Windows.Forms.GroupBox();
            this.rdgRecordingTimer4 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingTimer3 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingTimer2 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingTimer1 = new System.Windows.Forms.RadioButton();
            this.chkScreenRecordWindow = new System.Windows.Forms.CheckBox();
            this.lblStartRecordingControlled = new System.Windows.Forms.Label();
            this.edtRecordingTimer = new System.Windows.Forms.TextBox();
            this.btnResumeRecording = new System.Windows.Forms.Button();
            this.btnPauseRecording = new System.Windows.Forms.Button();
            this.chkRecordingOnMotion = new System.Windows.Forms.CheckBox();
            this.chkPauseCreatesNewFile = new System.Windows.Forms.CheckBox();
            this.chkRecordingCanPause = new System.Windows.Forms.CheckBox();
            this.rdgCompressMode = new System.Windows.Forms.GroupBox();
            this.rdgCompressModeNo = new System.Windows.Forms.RadioButton();
            this.rdgCompressModeAfterCapture = new System.Windows.Forms.RadioButton();
            this.rdgCompressModeOnTheFly = new System.Windows.Forms.RadioButton();
            this.rdgCompressType = new System.Windows.Forms.GroupBox();
            this.rdgCompressTypeAudio = new System.Windows.Forms.RadioButton();
            this.rdgCompressTypeAudioVideo = new System.Windows.Forms.RadioButton();
            this.rdgCompressTypeVideo = new System.Windows.Forms.RadioButton();
            this.cboVideoCompressors = new System.Windows.Forms.ComboBox();
            this.btnVideoCompressorSettings = new System.Windows.Forms.Button();
            this.cboAudioCompressors = new System.Windows.Forms.ComboBox();
            this.btnAudioCompressorSettings = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnCodecExamples = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edtNewFileDuringRecording = new System.Windows.Forms.TextBox();
            this.rdgRecordingMethod.SuspendLayout();
            this.rdgRecordingTimer.SuspendLayout();
            this.rdgCompressMode.SuspendLayout();
            this.rdgCompressType.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtRecordingFileName
            // 
            this.edtRecordingFileName.AcceptsReturn = true;
            this.edtRecordingFileName.BackColor = System.Drawing.SystemColors.Window;
            this.edtRecordingFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtRecordingFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtRecordingFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtRecordingFileName.Location = new System.Drawing.Point(410, 164);
            this.edtRecordingFileName.MaxLength = 0;
            this.edtRecordingFileName.Name = "edtRecordingFileName";
            this.edtRecordingFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtRecordingFileName.Size = new System.Drawing.Size(143, 23);
            this.edtRecordingFileName.TabIndex = 47;
            this.edtRecordingFileName.Text = "VideoClip.avi";
            // 
            // btnStartRecordingImmediately
            // 
            this.btnStartRecordingImmediately.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartRecordingImmediately.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartRecordingImmediately.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartRecordingImmediately.ForeColor = System.Drawing.Color.Red;
            this.btnStartRecordingImmediately.Location = new System.Drawing.Point(1, 7);
            this.btnStartRecordingImmediately.Name = "btnStartRecordingImmediately";
            this.btnStartRecordingImmediately.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartRecordingImmediately.Size = new System.Drawing.Size(175, 36);
            this.btnStartRecordingImmediately.TabIndex = 58;
            this.btnStartRecordingImmediately.Text = "start (immediately)";
            this.btnStartRecordingImmediately.UseVisualStyleBackColor = false;
            this.btnStartRecordingImmediately.Click += new System.EventHandler(this.btnStartRecordingImmediately_Click);
            // 
            // btnStartRecordingControlled
            // 
            this.btnStartRecordingControlled.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartRecordingControlled.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartRecordingControlled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartRecordingControlled.ForeColor = System.Drawing.Color.Red;
            this.btnStartRecordingControlled.Location = new System.Drawing.Point(183, 7);
            this.btnStartRecordingControlled.Name = "btnStartRecordingControlled";
            this.btnStartRecordingControlled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartRecordingControlled.Size = new System.Drawing.Size(175, 36);
            this.btnStartRecordingControlled.TabIndex = 57;
            this.btnStartRecordingControlled.Text = "start (controlled)";
            this.btnStartRecordingControlled.UseVisualStyleBackColor = false;
            this.btnStartRecordingControlled.Click += new System.EventHandler(this.btnStartRecordingControlled_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStopRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopRecording.Location = new System.Drawing.Point(365, 7);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopRecording.Size = new System.Drawing.Size(149, 36);
            this.btnStopRecording.TabIndex = 56;
            this.btnStopRecording.Text = "stop";
            this.btnStopRecording.UseVisualStyleBackColor = false;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnRenewRecordingFile
            // 
            this.btnRenewRecordingFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnRenewRecordingFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRenewRecordingFile.Enabled = false;
            this.btnRenewRecordingFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRenewRecordingFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRenewRecordingFile.Location = new System.Drawing.Point(1, 212);
            this.btnRenewRecordingFile.Name = "btnRenewRecordingFile";
            this.btnRenewRecordingFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRenewRecordingFile.Size = new System.Drawing.Size(196, 36);
            this.btnRenewRecordingFile.TabIndex = 55;
            this.btnRenewRecordingFile.Text = "new file while recording:";
            this.btnRenewRecordingFile.UseVisualStyleBackColor = false;
            this.btnRenewRecordingFile.Click += new System.EventHandler(this.btnRenewRecordingFile_Click);
            // 
            // rdgRecordingMethod
            // 
            this.rdgRecordingMethod.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethod_MPG);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethod_WebM);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodMP4);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodFLV);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodMKV);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodSendToDV);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodAVI);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodWMV);
            this.rdgRecordingMethod.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgRecordingMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethod.Location = new System.Drawing.Point(562, 0);
            this.rdgRecordingMethod.Name = "rdgRecordingMethod";
            this.rdgRecordingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethod.Size = new System.Drawing.Size(166, 277);
            this.rdgRecordingMethod.TabIndex = 52;
            this.rdgRecordingMethod.TabStop = false;
            this.rdgRecordingMethod.Text = "recording method";
            // 
            // rdgRecordingMethod_MPG
            // 
            this.rdgRecordingMethod_MPG.AutoSize = true;
            this.rdgRecordingMethod_MPG.Location = new System.Drawing.Point(12, 219);
            this.rdgRecordingMethod_MPG.Name = "rdgRecordingMethod_MPG";
            this.rdgRecordingMethod_MPG.Size = new System.Drawing.Size(59, 20);
            this.rdgRecordingMethod_MPG.TabIndex = 46;
            this.rdgRecordingMethod_MPG.TabStop = true;
            this.rdgRecordingMethod_MPG.Tag = "7";
            this.rdgRecordingMethod_MPG.Text = "MPG";
            this.rdgRecordingMethod_MPG.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethod_WebM
            // 
            this.rdgRecordingMethod_WebM.AutoSize = true;
            this.rdgRecordingMethod_WebM.Location = new System.Drawing.Point(12, 191);
            this.rdgRecordingMethod_WebM.Name = "rdgRecordingMethod_WebM";
            this.rdgRecordingMethod_WebM.Size = new System.Drawing.Size(108, 20);
            this.rdgRecordingMethod_WebM.TabIndex = 45;
            this.rdgRecordingMethod_WebM.TabStop = true;
            this.rdgRecordingMethod_WebM.Tag = "6";
            this.rdgRecordingMethod_WebM.Text = "WebM (VP8)";
            this.rdgRecordingMethod_WebM.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodMP4
            // 
            this.rdgRecordingMethodMP4.AutoSize = true;
            this.rdgRecordingMethodMP4.Location = new System.Drawing.Point(12, 163);
            this.rdgRecordingMethodMP4.Name = "rdgRecordingMethodMP4";
            this.rdgRecordingMethodMP4.Size = new System.Drawing.Size(56, 20);
            this.rdgRecordingMethodMP4.TabIndex = 44;
            this.rdgRecordingMethodMP4.TabStop = true;
            this.rdgRecordingMethodMP4.Tag = "5";
            this.rdgRecordingMethodMP4.Text = "MP4";
            this.rdgRecordingMethodMP4.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodFLV
            // 
            this.rdgRecordingMethodFLV.AutoSize = true;
            this.rdgRecordingMethodFLV.Location = new System.Drawing.Point(12, 136);
            this.rdgRecordingMethodFLV.Name = "rdgRecordingMethodFLV";
            this.rdgRecordingMethodFLV.Size = new System.Drawing.Size(53, 20);
            this.rdgRecordingMethodFLV.TabIndex = 43;
            this.rdgRecordingMethodFLV.TabStop = true;
            this.rdgRecordingMethodFLV.Tag = "4";
            this.rdgRecordingMethodFLV.Text = "FLV";
            this.rdgRecordingMethodFLV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodMKV
            // 
            this.rdgRecordingMethodMKV.AutoSize = true;
            this.rdgRecordingMethodMKV.Location = new System.Drawing.Point(12, 108);
            this.rdgRecordingMethodMKV.Name = "rdgRecordingMethodMKV";
            this.rdgRecordingMethodMKV.Size = new System.Drawing.Size(57, 20);
            this.rdgRecordingMethodMKV.TabIndex = 42;
            this.rdgRecordingMethodMKV.TabStop = true;
            this.rdgRecordingMethodMKV.Tag = "3";
            this.rdgRecordingMethodMKV.Text = "MKV";
            this.rdgRecordingMethodMKV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodSendToDV
            // 
            this.rdgRecordingMethodSendToDV.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethodSendToDV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgRecordingMethodSendToDV.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgRecordingMethodSendToDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethodSendToDV.Location = new System.Drawing.Point(12, 81);
            this.rdgRecordingMethodSendToDV.Name = "rdgRecordingMethodSendToDV";
            this.rdgRecordingMethodSendToDV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethodSendToDV.Size = new System.Drawing.Size(134, 27);
            this.rdgRecordingMethodSendToDV.TabIndex = 39;
            this.rdgRecordingMethodSendToDV.TabStop = true;
            this.rdgRecordingMethodSendToDV.Tag = "2";
            this.rdgRecordingMethodSendToDV.Text = "Send to DV";
            this.rdgRecordingMethodSendToDV.UseVisualStyleBackColor = false;
            this.rdgRecordingMethodSendToDV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodAVI
            // 
            this.rdgRecordingMethodAVI.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethodAVI.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgRecordingMethodAVI.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgRecordingMethodAVI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethodAVI.Location = new System.Drawing.Point(12, 29);
            this.rdgRecordingMethodAVI.Name = "rdgRecordingMethodAVI";
            this.rdgRecordingMethodAVI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethodAVI.Size = new System.Drawing.Size(123, 27);
            this.rdgRecordingMethodAVI.TabIndex = 11;
            this.rdgRecordingMethodAVI.TabStop = true;
            this.rdgRecordingMethodAVI.Tag = "0";
            this.rdgRecordingMethodAVI.Text = "AVI";
            this.rdgRecordingMethodAVI.UseVisualStyleBackColor = false;
            this.rdgRecordingMethodAVI.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodWMV
            // 
            this.rdgRecordingMethodWMV.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethodWMV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgRecordingMethodWMV.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgRecordingMethodWMV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethodWMV.Location = new System.Drawing.Point(12, 56);
            this.rdgRecordingMethodWMV.Name = "rdgRecordingMethodWMV";
            this.rdgRecordingMethodWMV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethodWMV.Size = new System.Drawing.Size(123, 25);
            this.rdgRecordingMethodWMV.TabIndex = 10;
            this.rdgRecordingMethodWMV.TabStop = true;
            this.rdgRecordingMethodWMV.Tag = "1";
            this.rdgRecordingMethodWMV.Text = "ASF (WMV)";
            this.rdgRecordingMethodWMV.UseVisualStyleBackColor = false;
            this.rdgRecordingMethodWMV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // chkAudioRecording
            // 
            this.chkAudioRecording.BackColor = System.Drawing.SystemColors.Control;
            this.chkAudioRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAudioRecording.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkAudioRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAudioRecording.Location = new System.Drawing.Point(1, 77);
            this.chkAudioRecording.Name = "chkAudioRecording";
            this.chkAudioRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAudioRecording.Size = new System.Drawing.Size(215, 26);
            this.chkAudioRecording.TabIndex = 51;
            this.chkAudioRecording.Text = "enable audio recording";
            this.chkAudioRecording.UseVisualStyleBackColor = false;
            this.chkAudioRecording.CheckedChanged += new System.EventHandler(this.chkAudioRecording_CheckedChanged);
            // 
            // chkPreserveNativeFormat
            // 
            this.chkPreserveNativeFormat.AutoSize = true;
            this.chkPreserveNativeFormat.BackColor = System.Drawing.SystemColors.Control;
            this.chkPreserveNativeFormat.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPreserveNativeFormat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPreserveNativeFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPreserveNativeFormat.Location = new System.Drawing.Point(1, 49);
            this.chkPreserveNativeFormat.Name = "chkPreserveNativeFormat";
            this.chkPreserveNativeFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPreserveNativeFormat.Size = new System.Drawing.Size(222, 20);
            this.chkPreserveNativeFormat.TabIndex = 49;
            this.chkPreserveNativeFormat.Text = "RECORD IN NATIVE FORMAT";
            this.chkPreserveNativeFormat.UseVisualStyleBackColor = false;
            this.chkPreserveNativeFormat.CheckedChanged += new System.EventHandler(this.chkPreserveNativeFormat_CheckedChanged);
            // 
            // chkAVISaveToThisFile
            // 
            this.chkAVISaveToThisFile.BackColor = System.Drawing.SystemColors.Control;
            this.chkAVISaveToThisFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAVISaveToThisFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAVISaveToThisFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAVISaveToThisFile.Location = new System.Drawing.Point(1, 164);
            this.chkAVISaveToThisFile.Name = "chkAVISaveToThisFile";
            this.chkAVISaveToThisFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAVISaveToThisFile.Size = new System.Drawing.Size(401, 27);
            this.chkAVISaveToThisFile.TabIndex = 48;
            this.chkAVISaveToThisFile.Text = "don\'t generate file names automatically, save to:";
            this.chkAVISaveToThisFile.UseVisualStyleBackColor = false;
            // 
            // rdgRecordingTimer
            // 
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer4);
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer3);
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer2);
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer1);
            this.rdgRecordingTimer.Controls.Add(this.chkScreenRecordWindow);
            this.rdgRecordingTimer.Controls.Add(this.lblStartRecordingControlled);
            this.rdgRecordingTimer.Controls.Add(this.edtRecordingTimer);
            this.rdgRecordingTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingTimer.Location = new System.Drawing.Point(267, 44);
            this.rdgRecordingTimer.Name = "rdgRecordingTimer";
            this.rdgRecordingTimer.Size = new System.Drawing.Size(287, 116);
            this.rdgRecordingTimer.TabIndex = 64;
            this.rdgRecordingTimer.TabStop = false;
            this.rdgRecordingTimer.Text = "recording timer";
            // 
            // rdgRecordingTimer4
            // 
            this.rdgRecordingTimer4.Location = new System.Drawing.Point(162, 43);
            this.rdgRecordingTimer4.Name = "rdgRecordingTimer4";
            this.rdgRecordingTimer4.Size = new System.Drawing.Size(118, 26);
            this.rdgRecordingTimer4.TabIndex = 52;
            this.rdgRecordingTimer4.TabStop = true;
            this.rdgRecordingTimer4.Tag = "3";
            this.rdgRecordingTimer4.Text = "start after...";
            this.rdgRecordingTimer4.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer4_CheckedChanged);
            // 
            // rdgRecordingTimer3
            // 
            this.rdgRecordingTimer3.Location = new System.Drawing.Point(162, 20);
            this.rdgRecordingTimer3.Name = "rdgRecordingTimer3";
            this.rdgRecordingTimer3.Size = new System.Drawing.Size(118, 27);
            this.rdgRecordingTimer3.TabIndex = 51;
            this.rdgRecordingTimer3.TabStop = true;
            this.rdgRecordingTimer3.Tag = "2";
            this.rdgRecordingTimer3.Text = "stop after...";
            this.rdgRecordingTimer3.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer3_CheckedChanged);
            // 
            // rdgRecordingTimer2
            // 
            this.rdgRecordingTimer2.Location = new System.Drawing.Point(13, 43);
            this.rdgRecordingTimer2.Name = "rdgRecordingTimer2";
            this.rdgRecordingTimer2.Size = new System.Drawing.Size(148, 28);
            this.rdgRecordingTimer2.TabIndex = 50;
            this.rdgRecordingTimer2.TabStop = true;
            this.rdgRecordingTimer2.Tag = "1";
            this.rdgRecordingTimer2.Text = "new file every...";
            this.rdgRecordingTimer2.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer2_CheckedChanged);
            // 
            // rdgRecordingTimer1
            // 
            this.rdgRecordingTimer1.Location = new System.Drawing.Point(13, 20);
            this.rdgRecordingTimer1.Name = "rdgRecordingTimer1";
            this.rdgRecordingTimer1.Size = new System.Drawing.Size(135, 27);
            this.rdgRecordingTimer1.TabIndex = 49;
            this.rdgRecordingTimer1.TabStop = true;
            this.rdgRecordingTimer1.Tag = "0";
            this.rdgRecordingTimer1.Text = "disabled";
            this.rdgRecordingTimer1.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer1_CheckedChanged);
            // 
            // chkScreenRecordWindow
            // 
            this.chkScreenRecordWindow.Checked = true;
            this.chkScreenRecordWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScreenRecordWindow.Enabled = false;
            this.chkScreenRecordWindow.Location = new System.Drawing.Point(131, 63);
            this.chkScreenRecordWindow.Name = "chkScreenRecordWindow";
            this.chkScreenRecordWindow.Size = new System.Drawing.Size(147, 49);
            this.chkScreenRecordWindow.TabIndex = 48;
            this.chkScreenRecordWindow.Text = "e.g. source = screen window";
            this.chkScreenRecordWindow.CheckedChanged += new System.EventHandler(this.chkScreenRecordWindow_CheckedChanged);
            // 
            // lblStartRecordingControlled
            // 
            this.lblStartRecordingControlled.AutoSize = true;
            this.lblStartRecordingControlled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartRecordingControlled.Location = new System.Drawing.Point(54, 77);
            this.lblStartRecordingControlled.Name = "lblStartRecordingControlled";
            this.lblStartRecordingControlled.Size = new System.Drawing.Size(62, 20);
            this.lblStartRecordingControlled.TabIndex = 46;
            this.lblStartRecordingControlled.Text = "seconds";
            // 
            // edtRecordingTimer
            // 
            this.edtRecordingTimer.Location = new System.Drawing.Point(12, 73);
            this.edtRecordingTimer.Name = "edtRecordingTimer";
            this.edtRecordingTimer.Size = new System.Drawing.Size(38, 27);
            this.edtRecordingTimer.TabIndex = 45;
            this.edtRecordingTimer.Text = "0";
            this.edtRecordingTimer.TextChanged += new System.EventHandler(this.edtRecordingTimer_TextChanged);
            // 
            // btnResumeRecording
            // 
            this.btnResumeRecording.BackColor = System.Drawing.SystemColors.Control;
            this.btnResumeRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResumeRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResumeRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResumeRecording.Location = new System.Drawing.Point(821, 97);
            this.btnResumeRecording.Name = "btnResumeRecording";
            this.btnResumeRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResumeRecording.Size = new System.Drawing.Size(82, 31);
            this.btnResumeRecording.TabIndex = 65;
            this.btnResumeRecording.Text = "resume";
            this.btnResumeRecording.UseVisualStyleBackColor = false;
            this.btnResumeRecording.Click += new System.EventHandler(this.btnResumeRecording_Click);
            // 
            // btnPauseRecording
            // 
            this.btnPauseRecording.BackColor = System.Drawing.SystemColors.Control;
            this.btnPauseRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPauseRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPauseRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPauseRecording.Location = new System.Drawing.Point(733, 97);
            this.btnPauseRecording.Name = "btnPauseRecording";
            this.btnPauseRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPauseRecording.Size = new System.Drawing.Size(80, 31);
            this.btnPauseRecording.TabIndex = 66;
            this.btnPauseRecording.Text = "pause";
            this.btnPauseRecording.UseVisualStyleBackColor = false;
            this.btnPauseRecording.Click += new System.EventHandler(this.btnPauseRecording_Click);
            // 
            // chkRecordingOnMotion
            // 
            this.chkRecordingOnMotion.Location = new System.Drawing.Point(733, 60);
            this.chkRecordingOnMotion.Name = "chkRecordingOnMotion";
            this.chkRecordingOnMotion.Size = new System.Drawing.Size(206, 31);
            this.chkRecordingOnMotion.TabIndex = 69;
            this.chkRecordingOnMotion.Text = "pause/resume on motion";
            this.chkRecordingOnMotion.Click += new System.EventHandler(this.chkRecordingOnMotion_CheckedChanged);
            // 
            // chkPauseCreatesNewFile
            // 
            this.chkPauseCreatesNewFile.Location = new System.Drawing.Point(733, 31);
            this.chkPauseCreatesNewFile.Name = "chkPauseCreatesNewFile";
            this.chkPauseCreatesNewFile.Size = new System.Drawing.Size(212, 30);
            this.chkPauseCreatesNewFile.TabIndex = 68;
            this.chkPauseCreatesNewFile.Text = "pause creates new file";
            this.chkPauseCreatesNewFile.Click += new System.EventHandler(this.chkPauseCreatesNewFile_CheckedChanged);
            // 
            // chkRecordingCanPause
            // 
            this.chkRecordingCanPause.BackColor = System.Drawing.SystemColors.Control;
            this.chkRecordingCanPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRecordingCanPause.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkRecordingCanPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRecordingCanPause.Location = new System.Drawing.Point(733, 4);
            this.chkRecordingCanPause.Name = "chkRecordingCanPause";
            this.chkRecordingCanPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRecordingCanPause.Size = new System.Drawing.Size(212, 32);
            this.chkRecordingCanPause.TabIndex = 67;
            this.chkRecordingCanPause.Text = "recording can pause";
            this.chkRecordingCanPause.UseVisualStyleBackColor = false;
            this.chkRecordingCanPause.Click += new System.EventHandler(this.chkRecordingCanPause_CheckedChanged);
            // 
            // rdgCompressMode
            // 
            this.rdgCompressMode.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressMode.Controls.Add(this.rdgCompressModeNo);
            this.rdgCompressMode.Controls.Add(this.rdgCompressModeAfterCapture);
            this.rdgCompressMode.Controls.Add(this.rdgCompressModeOnTheFly);
            this.rdgCompressMode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressMode.Location = new System.Drawing.Point(930, 0);
            this.rdgCompressMode.Name = "rdgCompressMode";
            this.rdgCompressMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressMode.Size = new System.Drawing.Size(142, 108);
            this.rdgCompressMode.TabIndex = 71;
            this.rdgCompressMode.TabStop = false;
            this.rdgCompressMode.Text = "compress. mode";
            // 
            // rdgCompressModeNo
            // 
            this.rdgCompressModeNo.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressModeNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressModeNo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressModeNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressModeNo.Location = new System.Drawing.Point(12, 24);
            this.rdgCompressModeNo.Name = "rdgCompressModeNo";
            this.rdgCompressModeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressModeNo.Size = new System.Drawing.Size(79, 27);
            this.rdgCompressModeNo.TabIndex = 24;
            this.rdgCompressModeNo.TabStop = true;
            this.rdgCompressModeNo.Tag = "0";
            this.rdgCompressModeNo.Text = "no";
            this.rdgCompressModeNo.UseVisualStyleBackColor = false;
            this.rdgCompressModeNo.CheckedChanged += new System.EventHandler(this.rdgCompressMode_CheckedChanged);
            // 
            // rdgCompressModeAfterCapture
            // 
            this.rdgCompressModeAfterCapture.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressModeAfterCapture.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressModeAfterCapture.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressModeAfterCapture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressModeAfterCapture.Location = new System.Drawing.Point(12, 73);
            this.rdgCompressModeAfterCapture.Name = "rdgCompressModeAfterCapture";
            this.rdgCompressModeAfterCapture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressModeAfterCapture.Size = new System.Drawing.Size(122, 27);
            this.rdgCompressModeAfterCapture.TabIndex = 23;
            this.rdgCompressModeAfterCapture.TabStop = true;
            this.rdgCompressModeAfterCapture.Tag = "2";
            this.rdgCompressModeAfterCapture.Text = "after capture";
            this.rdgCompressModeAfterCapture.UseVisualStyleBackColor = false;
            this.rdgCompressModeAfterCapture.CheckedChanged += new System.EventHandler(this.rdgCompressMode_CheckedChanged);
            // 
            // rdgCompressModeOnTheFly
            // 
            this.rdgCompressModeOnTheFly.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressModeOnTheFly.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressModeOnTheFly.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressModeOnTheFly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressModeOnTheFly.Location = new System.Drawing.Point(12, 49);
            this.rdgCompressModeOnTheFly.Name = "rdgCompressModeOnTheFly";
            this.rdgCompressModeOnTheFly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressModeOnTheFly.Size = new System.Drawing.Size(113, 27);
            this.rdgCompressModeOnTheFly.TabIndex = 22;
            this.rdgCompressModeOnTheFly.TabStop = true;
            this.rdgCompressModeOnTheFly.Tag = "1";
            this.rdgCompressModeOnTheFly.Text = "on the fly";
            this.rdgCompressModeOnTheFly.UseVisualStyleBackColor = false;
            this.rdgCompressModeOnTheFly.CheckedChanged += new System.EventHandler(this.rdgCompressMode_CheckedChanged);
            // 
            // rdgCompressType
            // 
            this.rdgCompressType.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressType.Controls.Add(this.rdgCompressTypeAudio);
            this.rdgCompressType.Controls.Add(this.rdgCompressTypeAudioVideo);
            this.rdgCompressType.Controls.Add(this.rdgCompressTypeVideo);
            this.rdgCompressType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressType.Location = new System.Drawing.Point(930, 109);
            this.rdgCompressType.Name = "rdgCompressType";
            this.rdgCompressType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressType.Size = new System.Drawing.Size(142, 108);
            this.rdgCompressType.TabIndex = 70;
            this.rdgCompressType.TabStop = false;
            this.rdgCompressType.Text = "compress. type";
            // 
            // rdgCompressTypeAudio
            // 
            this.rdgCompressTypeAudio.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressTypeAudio.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressTypeAudio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressTypeAudio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressTypeAudio.Location = new System.Drawing.Point(12, 49);
            this.rdgCompressTypeAudio.Name = "rdgCompressTypeAudio";
            this.rdgCompressTypeAudio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressTypeAudio.Size = new System.Drawing.Size(113, 27);
            this.rdgCompressTypeAudio.TabIndex = 20;
            this.rdgCompressTypeAudio.TabStop = true;
            this.rdgCompressTypeAudio.Tag = "1";
            this.rdgCompressTypeAudio.Text = "audio";
            this.rdgCompressTypeAudio.UseVisualStyleBackColor = false;
            this.rdgCompressTypeAudio.CheckedChanged += new System.EventHandler(this.rdgCompressType_CheckedChanged);
            // 
            // rdgCompressTypeAudioVideo
            // 
            this.rdgCompressTypeAudioVideo.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressTypeAudioVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressTypeAudioVideo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressTypeAudioVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressTypeAudioVideo.Location = new System.Drawing.Point(12, 73);
            this.rdgCompressTypeAudioVideo.Name = "rdgCompressTypeAudioVideo";
            this.rdgCompressTypeAudioVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressTypeAudioVideo.Size = new System.Drawing.Size(123, 27);
            this.rdgCompressTypeAudioVideo.TabIndex = 19;
            this.rdgCompressTypeAudioVideo.TabStop = true;
            this.rdgCompressTypeAudioVideo.Tag = "2";
            this.rdgCompressTypeAudioVideo.Text = "audio + video";
            this.rdgCompressTypeAudioVideo.UseVisualStyleBackColor = false;
            this.rdgCompressTypeAudioVideo.CheckedChanged += new System.EventHandler(this.rdgCompressType_CheckedChanged);
            // 
            // rdgCompressTypeVideo
            // 
            this.rdgCompressTypeVideo.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressTypeVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressTypeVideo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgCompressTypeVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressTypeVideo.Location = new System.Drawing.Point(12, 24);
            this.rdgCompressTypeVideo.Name = "rdgCompressTypeVideo";
            this.rdgCompressTypeVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressTypeVideo.Size = new System.Drawing.Size(79, 27);
            this.rdgCompressTypeVideo.TabIndex = 18;
            this.rdgCompressTypeVideo.TabStop = true;
            this.rdgCompressTypeVideo.Tag = "0";
            this.rdgCompressTypeVideo.Text = "video";
            this.rdgCompressTypeVideo.UseVisualStyleBackColor = false;
            this.rdgCompressTypeVideo.CheckedChanged += new System.EventHandler(this.rdgCompressType_CheckedChanged);
            // 
            // cboVideoCompressors
            // 
            this.cboVideoCompressors.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoCompressors.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoCompressors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoCompressors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoCompressors.Location = new System.Drawing.Point(1080, 21);
            this.cboVideoCompressors.Name = "cboVideoCompressors";
            this.cboVideoCompressors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoCompressors.Size = new System.Drawing.Size(234, 24);
            this.cboVideoCompressors.TabIndex = 75;
            this.cboVideoCompressors.SelectedIndexChanged += new System.EventHandler(this.cboVideoCompressors_SelectedIndexChanged);
            // 
            // btnVideoCompressorSettings
            // 
            this.btnVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVideoCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVideoCompressorSettings.Location = new System.Drawing.Point(1080, 56);
            this.btnVideoCompressorSettings.Name = "btnVideoCompressorSettings";
            this.btnVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVideoCompressorSettings.Size = new System.Drawing.Size(87, 35);
            this.btnVideoCompressorSettings.TabIndex = 74;
            this.btnVideoCompressorSettings.Text = "settings";
            this.btnVideoCompressorSettings.UseVisualStyleBackColor = false;
            this.btnVideoCompressorSettings.Click += new System.EventHandler(this.btnVideoCompressorSettings_Click);
            // 
            // cboAudioCompressors
            // 
            this.cboAudioCompressors.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioCompressors.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioCompressors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAudioCompressors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioCompressors.Location = new System.Drawing.Point(1079, 139);
            this.cboAudioCompressors.Name = "cboAudioCompressors";
            this.cboAudioCompressors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioCompressors.Size = new System.Drawing.Size(233, 24);
            this.cboAudioCompressors.TabIndex = 73;
            this.cboAudioCompressors.SelectedIndexChanged += new System.EventHandler(this.cboAudioCompressors_SelectedIndexChanged);
            // 
            // btnAudioCompressorSettings
            // 
            this.btnAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAudioCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAudioCompressorSettings.Location = new System.Drawing.Point(1079, 173);
            this.btnAudioCompressorSettings.Name = "btnAudioCompressorSettings";
            this.btnAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAudioCompressorSettings.Size = new System.Drawing.Size(87, 36);
            this.btnAudioCompressorSettings.TabIndex = 72;
            this.btnAudioCompressorSettings.Text = "settings";
            this.btnAudioCompressorSettings.UseVisualStyleBackColor = false;
            this.btnAudioCompressorSettings.Click += new System.EventHandler(this.btnAudioCompressorSettings_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(1080, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(159, 27);
            this.Label1.TabIndex = 77;
            this.Label1.Text = "video compressor";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(1079, 117);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(159, 27);
            this.Label2.TabIndex = 76;
            this.Label2.Text = "audio compressor";
            // 
            // btnCodecExamples
            // 
            this.btnCodecExamples.Location = new System.Drawing.Point(838, 247);
            this.btnCodecExamples.Name = "btnCodecExamples";
            this.btnCodecExamples.Size = new System.Drawing.Size(476, 30);
            this.btnCodecExamples.TabIndex = 84;
            this.btnCodecExamples.Text = "Help about the Datastead Encoder settings";
            this.btnCodecExamples.Click += new System.EventHandler(this.btnCodecExamples_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "(auto file name if empty)";
            // 
            // edtNewFileDuringRecording
            // 
            this.edtNewFileDuringRecording.AcceptsReturn = true;
            this.edtNewFileDuringRecording.BackColor = System.Drawing.SystemColors.Window;
            this.edtNewFileDuringRecording.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtNewFileDuringRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtNewFileDuringRecording.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtNewFileDuringRecording.Location = new System.Drawing.Point(204, 215);
            this.edtNewFileDuringRecording.MaxLength = 0;
            this.edtNewFileDuringRecording.Name = "edtNewFileDuringRecording";
            this.edtNewFileDuringRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtNewFileDuringRecording.Size = new System.Drawing.Size(158, 23);
            this.edtNewFileDuringRecording.TabIndex = 87;
            // 
            // Recording
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1354, 297);
            this.ControlBox = false;
            this.Controls.Add(this.edtNewFileDuringRecording);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCodecExamples);
            this.Controls.Add(this.cboVideoCompressors);
            this.Controls.Add(this.btnVideoCompressorSettings);
            this.Controls.Add(this.cboAudioCompressors);
            this.Controls.Add(this.btnAudioCompressorSettings);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.rdgCompressMode);
            this.Controls.Add(this.rdgCompressType);
            this.Controls.Add(this.btnResumeRecording);
            this.Controls.Add(this.btnPauseRecording);
            this.Controls.Add(this.rdgRecordingTimer);
            this.Controls.Add(this.edtRecordingFileName);
            this.Controls.Add(this.btnStartRecordingImmediately);
            this.Controls.Add(this.btnStartRecordingControlled);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnRenewRecordingFile);
            this.Controls.Add(this.rdgRecordingMethod);
            this.Controls.Add(this.chkAudioRecording);
            this.Controls.Add(this.chkPreserveNativeFormat);
            this.Controls.Add(this.chkAVISaveToThisFile);
            this.Controls.Add(this.chkPauseCreatesNewFile);
            this.Controls.Add(this.chkRecordingOnMotion);
            this.Controls.Add(this.chkRecordingCanPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recording";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.Recording_VisibleChanged);
            this.rdgRecordingMethod.ResumeLayout(false);
            this.rdgRecordingMethod.PerformLayout();
            this.rdgRecordingTimer.ResumeLayout(false);
            this.rdgRecordingTimer.PerformLayout();
            this.rdgCompressMode.ResumeLayout(false);
            this.rdgCompressType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.ToolTip ToolTip1;
        private TextBox edtRecordingFileName;
        private Button btnStartRecordingImmediately;
        private Button btnStartRecordingControlled;
        private Button btnStopRecording;
        internal Button btnRenewRecordingFile;
        private GroupBox rdgRecordingMethod;
        private RadioButton rdgRecordingMethodSendToDV;
        private RadioButton rdgRecordingMethodAVI;
        private RadioButton rdgRecordingMethodWMV;
        private CheckBox chkAudioRecording;
        private CheckBox chkPreserveNativeFormat;
        private CheckBox chkAVISaveToThisFile;
        private  GroupBox rdgRecordingTimer;
        private  RadioButton rdgRecordingTimer4;
        private  RadioButton rdgRecordingTimer3;
        private  RadioButton rdgRecordingTimer2;
        private  RadioButton rdgRecordingTimer1;
        internal  CheckBox chkScreenRecordWindow;
        private  Label lblStartRecordingControlled;
        private  TextBox edtRecordingTimer;
        private RadioButton rdgRecordingMethodMKV;
        internal RadioButton rdgRecordingMethodMP4;
        private RadioButton rdgRecordingMethodFLV;
        private RadioButton rdgRecordingMethod_WebM;
        private RadioButton rdgRecordingMethod_MPG;
        private Button btnResumeRecording;
        private Button btnPauseRecording;
        private  CheckBox chkRecordingOnMotion;
        private  CheckBox chkPauseCreatesNewFile;
        private CheckBox chkRecordingCanPause;
        private GroupBox rdgCompressMode;
        private RadioButton rdgCompressModeNo;
        private RadioButton rdgCompressModeAfterCapture;
        private RadioButton rdgCompressModeOnTheFly;
        private GroupBox rdgCompressType;
        private RadioButton rdgCompressTypeAudio;
        private RadioButton rdgCompressTypeAudioVideo;
        private RadioButton rdgCompressTypeVideo;
        private ComboBox cboVideoCompressors;
        private Button btnVideoCompressorSettings;
        private ComboBox cboAudioCompressors;
        private Button btnAudioCompressorSettings;
        private Label Label1;
        private Label Label2;
        private  Button btnCodecExamples;
        private Label label3;
        private TextBox edtNewFileDuringRecording;

    }
}

