using System.Windows.Forms;

namespace MainDemo
{
    partial class Player : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.btnChooseClip = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOpenAtFrames = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.chkPlaylistRandom = new System.Windows.Forms.CheckBox();
            this.chkPlaylistLoop = new System.Windows.Forms.CheckBox();
            this.btnPlaylistClose = new System.Windows.Forms.Button();
            this.btnPlaylistStopAfterCurrent = new System.Windows.Forms.Button();
            this.btnPlaylistPrevious = new System.Windows.Forms.Button();
            this.btnPlaylistNext = new System.Windows.Forms.Button();
            this.btnPlaylistPlay = new System.Windows.Forms.Button();
            this.btnPlaylistAdd = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.chkReopen = new System.Windows.Forms.CheckBox();
            this.chkKeepBounds = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenAtTimes = new System.Windows.Forms.Button();
            this.txtStopTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtStopFrame = new System.Windows.Forms.TextBox();
            this.txtStartFrame = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.chkUseClock = new System.Windows.Forms.CheckBox();
            this.btnHeaderInfo = new System.Windows.Forms.Button();
            this.btnClipGeneralInfo = new System.Windows.Forms.Button();
            this.updPlayerFastSeekSpeed = new System.Windows.Forms.NumericUpDown();
            this.updPlayerSpeedRatio = new System.Windows.Forms.NumericUpDown();
            this.edtPlayerFileName = new System.Windows.Forms.TextBox();
            this.btnClipDuration = new System.Windows.Forms.Button();
            this.btnPlayerOpenFile = new System.Windows.Forms.Button();
            this.btnOpenLastClipRecorded = new System.Windows.Forms.Button();
            this.btnOpenLastClipPlayed = new System.Windows.Forms.Button();
            this.btnPlayerCloseFile = new System.Windows.Forms.Button();
            this.btnPlayerOpenStreamingURL = new System.Windows.Forms.Button();
            this.btnAutoPlay = new System.Windows.Forms.CheckBox();
            this.chkPlayerAudioRendering = new System.Windows.Forms.CheckBox();
            this.chkRefreshPausedDisplay = new System.Windows.Forms.CheckBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updSpeedRadioValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdgHwAccel_d3d11 = new System.Windows.Forms.RadioButton();
            this.rdgHwAccel_DXVA2 = new System.Windows.Forms.RadioButton();
            this.rdgHwAccel_QuickSync = new System.Windows.Forms.RadioButton();
            this.rdgHwAccel_CUDA = new System.Windows.Forms.RadioButton();
            this.rdgHwAccel_none = new System.Windows.Forms.RadioButton();
            this.chk360VideoDecoding = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPlayerFastSeekSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPlayerSpeedRatio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseClip
            // 
            this.btnChooseClip.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseClip.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChooseClip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseClip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChooseClip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseClip.ImageIndex = 0;
            this.btnChooseClip.ImageList = this.ImageList1;
            this.btnChooseClip.Location = new System.Drawing.Point(16, 24);
            this.btnChooseClip.Name = "btnChooseClip";
            this.btnChooseClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChooseClip.Size = new System.Drawing.Size(151, 35);
            this.btnChooseClip.TabIndex = 109;
            this.btnChooseClip.Text = "open a clip...";
            this.btnChooseClip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseClip.UseVisualStyleBackColor = false;
            this.btnChooseClip.Click += new System.EventHandler(this.btnChooseClip_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.ImageList1.Images.SetKeyName(0, "");
            // 
            // btnOpenAtFrames
            // 
            this.btnOpenAtFrames.Location = new System.Drawing.Point(240, 160);
            this.btnOpenAtFrames.Name = "btnOpenAtFrames";
            this.btnOpenAtFrames.Size = new System.Drawing.Size(143, 31);
            this.btnOpenAtFrames.TabIndex = 123;
            this.btnOpenAtFrames.Text = "open at frames ->";
            this.btnOpenAtFrames.Click += new System.EventHandler(this.btnOpenAtFrames_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lstPlaylist);
            this.GroupBox1.Controls.Add(this.chkPlaylistRandom);
            this.GroupBox1.Controls.Add(this.chkPlaylistLoop);
            this.GroupBox1.Controls.Add(this.btnPlaylistClose);
            this.GroupBox1.Controls.Add(this.btnPlaylistStopAfterCurrent);
            this.GroupBox1.Controls.Add(this.btnPlaylistPrevious);
            this.GroupBox1.Controls.Add(this.btnPlaylistNext);
            this.GroupBox1.Controls.Add(this.btnPlaylistPlay);
            this.GroupBox1.Controls.Add(this.btnPlaylistAdd);
            this.GroupBox1.Location = new System.Drawing.Point(756, 24);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(517, 188);
            this.GroupBox1.TabIndex = 116;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Playlist";
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.ItemHeight = 20;
            this.lstPlaylist.Location = new System.Drawing.Point(105, 71);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(401, 104);
            this.lstPlaylist.TabIndex = 8;
            // 
            // chkPlaylistRandom
            // 
            this.chkPlaylistRandom.Location = new System.Drawing.Point(12, 108);
            this.chkPlaylistRandom.Name = "chkPlaylistRandom";
            this.chkPlaylistRandom.Size = new System.Drawing.Size(100, 24);
            this.chkPlaylistRandom.TabIndex = 7;
            this.chkPlaylistRandom.Text = "Random";
            this.chkPlaylistRandom.CheckedChanged += new System.EventHandler(this.chkPlaylistRandom_CheckedChanged);
            // 
            // chkPlaylistLoop
            // 
            this.chkPlaylistLoop.Location = new System.Drawing.Point(12, 71);
            this.chkPlaylistLoop.Name = "chkPlaylistLoop";
            this.chkPlaylistLoop.Size = new System.Drawing.Size(78, 25);
            this.chkPlaylistLoop.TabIndex = 6;
            this.chkPlaylistLoop.Text = "Loop";
            this.chkPlaylistLoop.CheckedChanged += new System.EventHandler(this.chkPlaylistLoop_CheckedChanged);
            // 
            // btnPlaylistClose
            // 
            this.btnPlaylistClose.Location = new System.Drawing.Point(447, 23);
            this.btnPlaylistClose.Name = "btnPlaylistClose";
            this.btnPlaylistClose.Size = new System.Drawing.Size(59, 36);
            this.btnPlaylistClose.TabIndex = 5;
            this.btnPlaylistClose.Text = "Close";
            this.btnPlaylistClose.Click += new System.EventHandler(this.btnPlaylistClose_Click);
            // 
            // btnPlaylistStopAfterCurrent
            // 
            this.btnPlaylistStopAfterCurrent.Location = new System.Drawing.Point(299, 23);
            this.btnPlaylistStopAfterCurrent.Name = "btnPlaylistStopAfterCurrent";
            this.btnPlaylistStopAfterCurrent.Size = new System.Drawing.Size(142, 37);
            this.btnPlaylistStopAfterCurrent.TabIndex = 4;
            this.btnPlaylistStopAfterCurrent.Text = "Stop after current";
            this.btnPlaylistStopAfterCurrent.Click += new System.EventHandler(this.btnPlaylistStopAfterCurrent_Click);
            // 
            // btnPlaylistPrevious
            // 
            this.btnPlaylistPrevious.Location = new System.Drawing.Point(208, 23);
            this.btnPlaylistPrevious.Name = "btnPlaylistPrevious";
            this.btnPlaylistPrevious.Size = new System.Drawing.Size(85, 37);
            this.btnPlaylistPrevious.TabIndex = 3;
            this.btnPlaylistPrevious.Text = "Previous";
            this.btnPlaylistPrevious.Click += new System.EventHandler(this.btnPlaylistPrevious_Click);
            // 
            // btnPlaylistNext
            // 
            this.btnPlaylistNext.Location = new System.Drawing.Point(146, 23);
            this.btnPlaylistNext.Name = "btnPlaylistNext";
            this.btnPlaylistNext.Size = new System.Drawing.Size(56, 37);
            this.btnPlaylistNext.TabIndex = 2;
            this.btnPlaylistNext.Text = "Next";
            this.btnPlaylistNext.Click += new System.EventHandler(this.btnPlaylistNext_Click);
            // 
            // btnPlaylistPlay
            // 
            this.btnPlaylistPlay.Location = new System.Drawing.Point(84, 23);
            this.btnPlaylistPlay.Name = "btnPlaylistPlay";
            this.btnPlaylistPlay.Size = new System.Drawing.Size(56, 37);
            this.btnPlaylistPlay.TabIndex = 1;
            this.btnPlaylistPlay.Text = "Play";
            this.btnPlaylistPlay.Click += new System.EventHandler(this.btnPlaylistPlay_Click);
            // 
            // btnPlaylistAdd
            // 
            this.btnPlaylistAdd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlaylistAdd.Location = new System.Drawing.Point(12, 24);
            this.btnPlaylistAdd.Name = "btnPlaylistAdd";
            this.btnPlaylistAdd.Size = new System.Drawing.Size(66, 36);
            this.btnPlaylistAdd.TabIndex = 0;
            this.btnPlaylistAdd.Text = "Add...";
            this.btnPlaylistAdd.Click += new System.EventHandler(this.btnPlaylistAdd_Click);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(183, 1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(1076, 19);
            this.Label6.TabIndex = 131;
            this.Label6.Text = "to use only the player, disable the live video and audio capture devices by setii" +
    "ng VideoDevice = -1 and AudioDevice = -1 (\"video source\" and \"audio\")";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 16);
            this.Label5.TabIndex = 130;
            this.Label5.Text = "Player functions";
            // 
            // chkLoop
            // 
            this.chkLoop.Location = new System.Drawing.Point(6, 129);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(202, 24);
            this.chkLoop.TabIndex = 129;
            this.chkLoop.Text = "loop (repeat indefinitely)";
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // chkReopen
            // 
            this.chkReopen.Location = new System.Drawing.Point(596, 201);
            this.chkReopen.Name = "chkReopen";
            this.chkReopen.Size = new System.Drawing.Size(162, 28);
            this.chkReopen.TabIndex = 126;
            this.chkReopen.Text = "reopen if opened";
            // 
            // chkKeepBounds
            // 
            this.chkKeepBounds.Checked = true;
            this.chkKeepBounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepBounds.Location = new System.Drawing.Point(596, 164);
            this.chkKeepBounds.Name = "chkKeepBounds";
            this.chkKeepBounds.Size = new System.Drawing.Size(146, 28);
            this.chkKeepBounds.TabIndex = 125;
            this.chkKeepBounds.Text = "keep bounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(237, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "(times are expressed in 100ns units e.g. 3 seconds - 30000000)";
            // 
            // btnOpenAtTimes
            // 
            this.btnOpenAtTimes.Location = new System.Drawing.Point(240, 197);
            this.btnOpenAtTimes.Name = "btnOpenAtTimes";
            this.btnOpenAtTimes.Size = new System.Drawing.Size(143, 31);
            this.btnOpenAtTimes.TabIndex = 122;
            this.btnOpenAtTimes.Text = "open at times ->";
            this.btnOpenAtTimes.Click += new System.EventHandler(this.btnOpenAtTimes_Click);
            // 
            // txtStopTime
            // 
            this.txtStopTime.Location = new System.Drawing.Point(491, 197);
            this.txtStopTime.Name = "txtStopTime";
            this.txtStopTime.Size = new System.Drawing.Size(99, 27);
            this.txtStopTime.TabIndex = 121;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(386, 197);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(99, 27);
            this.txtStartTime.TabIndex = 120;
            // 
            // txtStopFrame
            // 
            this.txtStopFrame.Location = new System.Drawing.Point(491, 160);
            this.txtStopFrame.Name = "txtStopFrame";
            this.txtStopFrame.Size = new System.Drawing.Size(99, 27);
            this.txtStopFrame.TabIndex = 119;
            // 
            // txtStartFrame
            // 
            this.txtStartFrame.Location = new System.Drawing.Point(386, 160);
            this.txtStartFrame.Name = "txtStartFrame";
            this.txtStartFrame.Size = new System.Drawing.Size(99, 27);
            this.txtStartFrame.TabIndex = 118;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.BackColor = System.Drawing.SystemColors.Control;
            this.Label30.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label30.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label30.Location = new System.Drawing.Point(64, 172);
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label30.Size = new System.Drawing.Size(155, 16);
            this.Label30.TabIndex = 117;
            this.Label30.Text = "normal play speed ratio";
            // 
            // chkUseClock
            // 
            this.chkUseClock.Location = new System.Drawing.Point(240, 129);
            this.chkUseClock.Name = "chkUseClock";
            this.chkUseClock.Size = new System.Drawing.Size(102, 24);
            this.chkUseClock.TabIndex = 114;
            this.chkUseClock.Text = "use clock";
            this.chkUseClock.CheckedChanged += new System.EventHandler(this.chkUseClock_CheckedChanged);
            // 
            // btnHeaderInfo
            // 
            this.btnHeaderInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnHeaderInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHeaderInfo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHeaderInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHeaderInfo.Location = new System.Drawing.Point(540, 64);
            this.btnHeaderInfo.Name = "btnHeaderInfo";
            this.btnHeaderInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHeaderInfo.Size = new System.Drawing.Size(110, 33);
            this.btnHeaderInfo.TabIndex = 113;
            this.btnHeaderInfo.Text = "header info?";
            this.btnHeaderInfo.UseVisualStyleBackColor = false;
            this.btnHeaderInfo.Click += new System.EventHandler(this.btnHeaderInfo_Click);
            // 
            // btnClipGeneralInfo
            // 
            this.btnClipGeneralInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnClipGeneralInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClipGeneralInfo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClipGeneralInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClipGeneralInfo.Location = new System.Drawing.Point(420, 64);
            this.btnClipGeneralInfo.Name = "btnClipGeneralInfo";
            this.btnClipGeneralInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClipGeneralInfo.Size = new System.Drawing.Size(112, 33);
            this.btnClipGeneralInfo.TabIndex = 112;
            this.btnClipGeneralInfo.Text = "general info?";
            this.btnClipGeneralInfo.UseVisualStyleBackColor = false;
            this.btnClipGeneralInfo.Click += new System.EventHandler(this.btnClipGeneralInfo_Click);
            // 
            // updPlayerFastSeekSpeed
            // 
            this.updPlayerFastSeekSpeed.BackColor = System.Drawing.Color.Silver;
            this.updPlayerFastSeekSpeed.Location = new System.Drawing.Point(6, 209);
            this.updPlayerFastSeekSpeed.Name = "updPlayerFastSeekSpeed";
            this.updPlayerFastSeekSpeed.Size = new System.Drawing.Size(58, 27);
            this.updPlayerFastSeekSpeed.TabIndex = 111;
            this.updPlayerFastSeekSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updPlayerFastSeekSpeed.ValueChanged += new System.EventHandler(this.updPlayerFastSeekSpeed_ValueChanged);
            // 
            // updPlayerSpeedRatio
            // 
            this.updPlayerSpeedRatio.BackColor = System.Drawing.Color.Silver;
            this.updPlayerSpeedRatio.Location = new System.Drawing.Point(40, 169);
            this.updPlayerSpeedRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updPlayerSpeedRatio.Name = "updPlayerSpeedRatio";
            this.updPlayerSpeedRatio.Size = new System.Drawing.Size(24, 27);
            this.updPlayerSpeedRatio.TabIndex = 110;
            this.updPlayerSpeedRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updPlayerSpeedRatio.ValueChanged += new System.EventHandler(this.updPlayerSpeedRatio_ValueChanged);
            // 
            // edtPlayerFileName
            // 
            this.edtPlayerFileName.AcceptsReturn = true;
            this.edtPlayerFileName.BackColor = System.Drawing.SystemColors.Window;
            this.edtPlayerFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPlayerFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtPlayerFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPlayerFileName.Location = new System.Drawing.Point(175, 24);
            this.edtPlayerFileName.MaxLength = 0;
            this.edtPlayerFileName.Name = "edtPlayerFileName";
            this.edtPlayerFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPlayerFileName.Size = new System.Drawing.Size(393, 23);
            this.edtPlayerFileName.TabIndex = 108;
            this.edtPlayerFileName.Text = "Choose a video or audio clip...";
            // 
            // btnClipDuration
            // 
            this.btnClipDuration.BackColor = System.Drawing.SystemColors.Control;
            this.btnClipDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClipDuration.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClipDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClipDuration.Location = new System.Drawing.Point(658, 64);
            this.btnClipDuration.Name = "btnClipDuration";
            this.btnClipDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClipDuration.Size = new System.Drawing.Size(89, 33);
            this.btnClipDuration.TabIndex = 107;
            this.btnClipDuration.Text = "duration?";
            this.btnClipDuration.UseVisualStyleBackColor = false;
            this.btnClipDuration.Click += new System.EventHandler(this.btnClipDuration_Click);
            // 
            // btnPlayerOpenFile
            // 
            this.btnPlayerOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayerOpenFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayerOpenFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayerOpenFile.Location = new System.Drawing.Point(576, 24);
            this.btnPlayerOpenFile.Name = "btnPlayerOpenFile";
            this.btnPlayerOpenFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayerOpenFile.Size = new System.Drawing.Size(81, 35);
            this.btnPlayerOpenFile.TabIndex = 105;
            this.btnPlayerOpenFile.Text = "Open";
            this.btnPlayerOpenFile.UseVisualStyleBackColor = false;
            this.btnPlayerOpenFile.Click += new System.EventHandler(this.btnPlayerOpenFile_Click);
            // 
            // btnOpenLastClipRecorded
            // 
            this.btnOpenLastClipRecorded.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenLastClipRecorded.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenLastClipRecorded.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLastClipRecorded.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenLastClipRecorded.Location = new System.Drawing.Point(265, 64);
            this.btnOpenLastClipRecorded.Name = "btnOpenLastClipRecorded";
            this.btnOpenLastClipRecorded.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenLastClipRecorded.Size = new System.Drawing.Size(147, 33);
            this.btnOpenLastClipRecorded.TabIndex = 104;
            this.btnOpenLastClipRecorded.Text = "Last clip recorded";
            this.btnOpenLastClipRecorded.UseVisualStyleBackColor = false;
            this.btnOpenLastClipRecorded.Click += new System.EventHandler(this.btnOpenLastClipRecorded_Click);
            // 
            // btnOpenLastClipPlayed
            // 
            this.btnOpenLastClipPlayed.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenLastClipPlayed.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenLastClipPlayed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLastClipPlayed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenLastClipPlayed.Location = new System.Drawing.Point(127, 64);
            this.btnOpenLastClipPlayed.Name = "btnOpenLastClipPlayed";
            this.btnOpenLastClipPlayed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenLastClipPlayed.Size = new System.Drawing.Size(131, 33);
            this.btnOpenLastClipPlayed.TabIndex = 103;
            this.btnOpenLastClipPlayed.Text = "Last clip played";
            this.btnOpenLastClipPlayed.UseVisualStyleBackColor = false;
            this.btnOpenLastClipPlayed.Click += new System.EventHandler(this.btnOpenLastClipPlayed_Click);
            // 
            // btnPlayerCloseFile
            // 
            this.btnPlayerCloseFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayerCloseFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayerCloseFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerCloseFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayerCloseFile.Location = new System.Drawing.Point(666, 24);
            this.btnPlayerCloseFile.Name = "btnPlayerCloseFile";
            this.btnPlayerCloseFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayerCloseFile.Size = new System.Drawing.Size(81, 35);
            this.btnPlayerCloseFile.TabIndex = 102;
            this.btnPlayerCloseFile.Text = "Close";
            this.btnPlayerCloseFile.UseVisualStyleBackColor = false;
            this.btnPlayerCloseFile.Click += new System.EventHandler(this.btnPlayerCloseFile_Click);
            // 
            // btnPlayerOpenStreamingURL
            // 
            this.btnPlayerOpenStreamingURL.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayerOpenStreamingURL.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayerOpenStreamingURL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOpenStreamingURL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayerOpenStreamingURL.Location = new System.Drawing.Point(16, 64);
            this.btnPlayerOpenStreamingURL.Name = "btnPlayerOpenStreamingURL";
            this.btnPlayerOpenStreamingURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayerOpenStreamingURL.Size = new System.Drawing.Size(103, 33);
            this.btnPlayerOpenStreamingURL.TabIndex = 101;
            this.btnPlayerOpenStreamingURL.Text = "demo URL?";
            this.btnPlayerOpenStreamingURL.UseVisualStyleBackColor = false;
            this.btnPlayerOpenStreamingURL.Click += new System.EventHandler(this.btnPlayerOpenStreamingURL_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoPlay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutoPlay.Location = new System.Drawing.Point(240, 103);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAutoPlay.Size = new System.Drawing.Size(158, 26);
            this.btnAutoPlay.TabIndex = 100;
            this.btnAutoPlay.Text = "auto start playing";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.CheckedChanged += new System.EventHandler(this.btnAutoPlay_CheckedChanged);
            // 
            // chkPlayerAudioRendering
            // 
            this.chkPlayerAudioRendering.BackColor = System.Drawing.SystemColors.Control;
            this.chkPlayerAudioRendering.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPlayerAudioRendering.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPlayerAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPlayerAudioRendering.Location = new System.Drawing.Point(6, 103);
            this.chkPlayerAudioRendering.Name = "chkPlayerAudioRendering";
            this.chkPlayerAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPlayerAudioRendering.Size = new System.Drawing.Size(189, 26);
            this.chkPlayerAudioRendering.TabIndex = 99;
            this.chkPlayerAudioRendering.Text = "render player audio";
            this.chkPlayerAudioRendering.UseVisualStyleBackColor = false;
            this.chkPlayerAudioRendering.CheckedChanged += new System.EventHandler(this.chkPlayerAudioRendering_CheckedChanged);
            // 
            // chkRefreshPausedDisplay
            // 
            this.chkRefreshPausedDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.chkRefreshPausedDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRefreshPausedDisplay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRefreshPausedDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRefreshPausedDisplay.Location = new System.Drawing.Point(6, 251);
            this.chkRefreshPausedDisplay.Name = "chkRefreshPausedDisplay";
            this.chkRefreshPausedDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRefreshPausedDisplay.Size = new System.Drawing.Size(731, 26);
            this.chkRefreshPausedDisplay.TabIndex = 98;
            this.chkRefreshPausedDisplay.Text = "refresh periodically paused display when the frame grabber is enabled (e.g. to ap" +
    "ply graphic overlays)";
            this.chkRefreshPausedDisplay.UseVisualStyleBackColor = false;
            this.chkRefreshPausedDisplay.CheckedChanged += new System.EventHandler(this.chkRefreshPausedDisplay_CheckedChanged);
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.BackColor = System.Drawing.SystemColors.Control;
            this.Label31.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label31.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label31.Location = new System.Drawing.Point(64, 212);
            this.Label31.Name = "Label31";
            this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label31.Size = new System.Drawing.Size(143, 16);
            this.Label31.TabIndex = 106;
            this.Label31.Text = "ff / rewind speed ratio";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(491, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 128;
            this.label2.Text = "stop (*)     (*) default -1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(386, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 127;
            this.label1.Text = "start (*)";
            // 
            // updSpeedRadioValue
            // 
            this.updSpeedRadioValue.BackColor = System.Drawing.Color.Silver;
            this.updSpeedRadioValue.Location = new System.Drawing.Point(5, 171);
            this.updSpeedRadioValue.Name = "updSpeedRadioValue";
            this.updSpeedRadioValue.Size = new System.Drawing.Size(35, 27);
            this.updSpeedRadioValue.TabIndex = 134;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdgHwAccel_d3d11);
            this.groupBox2.Controls.Add(this.rdgHwAccel_DXVA2);
            this.groupBox2.Controls.Add(this.rdgHwAccel_QuickSync);
            this.groupBox2.Controls.Add(this.rdgHwAccel_CUDA);
            this.groupBox2.Controls.Add(this.rdgHwAccel_none);
            this.groupBox2.Location = new System.Drawing.Point(756, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 81);
            this.groupBox2.TabIndex = 135;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware acceleration of video decoding";
            // 
            // rdgHwAccel_d3d11
            // 
            this.rdgHwAccel_d3d11.AutoSize = true;
            this.rdgHwAccel_d3d11.Location = new System.Drawing.Point(422, 39);
            this.rdgHwAccel_d3d11.Name = "rdgHwAccel_d3d11";
            this.rdgHwAccel_d3d11.Size = new System.Drawing.Size(72, 24);
            this.rdgHwAccel_d3d11.TabIndex = 4;
            this.rdgHwAccel_d3d11.Text = "d3d11";
            this.rdgHwAccel_d3d11.UseVisualStyleBackColor = true;
            this.rdgHwAccel_d3d11.CheckedChanged += new System.EventHandler(this.rdgHwAccel_d3d11_CheckedChanged);
            // 
            // rdgHwAccel_DXVA2
            // 
            this.rdgHwAccel_DXVA2.AutoSize = true;
            this.rdgHwAccel_DXVA2.Location = new System.Drawing.Point(312, 37);
            this.rdgHwAccel_DXVA2.Name = "rdgHwAccel_DXVA2";
            this.rdgHwAccel_DXVA2.Size = new System.Drawing.Size(77, 24);
            this.rdgHwAccel_DXVA2.TabIndex = 3;
            this.rdgHwAccel_DXVA2.Text = "DXVA2";
            this.rdgHwAccel_DXVA2.UseVisualStyleBackColor = true;
            this.rdgHwAccel_DXVA2.CheckedChanged += new System.EventHandler(this.rdgHwAccel_DXVA2_CheckedChanged);
            // 
            // rdgHwAccel_QuickSync
            // 
            this.rdgHwAccel_QuickSync.AutoSize = true;
            this.rdgHwAccel_QuickSync.Location = new System.Drawing.Point(181, 37);
            this.rdgHwAccel_QuickSync.Name = "rdgHwAccel_QuickSync";
            this.rdgHwAccel_QuickSync.Size = new System.Drawing.Size(97, 24);
            this.rdgHwAccel_QuickSync.TabIndex = 2;
            this.rdgHwAccel_QuickSync.Text = "QuickSync";
            this.rdgHwAccel_QuickSync.UseVisualStyleBackColor = true;
            this.rdgHwAccel_QuickSync.CheckedChanged += new System.EventHandler(this.rdgHwAccel_QuickSync_CheckedChanged);
            // 
            // rdgHwAccel_CUDA
            // 
            this.rdgHwAccel_CUDA.AutoSize = true;
            this.rdgHwAccel_CUDA.Location = new System.Drawing.Point(85, 39);
            this.rdgHwAccel_CUDA.Name = "rdgHwAccel_CUDA";
            this.rdgHwAccel_CUDA.Size = new System.Drawing.Size(70, 24);
            this.rdgHwAccel_CUDA.TabIndex = 1;
            this.rdgHwAccel_CUDA.Text = "CUDA";
            this.rdgHwAccel_CUDA.UseVisualStyleBackColor = true;
            this.rdgHwAccel_CUDA.CheckedChanged += new System.EventHandler(this.rdgHwAccel_CUDA_CheckedChanged);
            // 
            // rdgHwAccel_none
            // 
            this.rdgHwAccel_none.AutoSize = true;
            this.rdgHwAccel_none.Checked = true;
            this.rdgHwAccel_none.Location = new System.Drawing.Point(7, 39);
            this.rdgHwAccel_none.Name = "rdgHwAccel_none";
            this.rdgHwAccel_none.Size = new System.Drawing.Size(63, 24);
            this.rdgHwAccel_none.TabIndex = 0;
            this.rdgHwAccel_none.TabStop = true;
            this.rdgHwAccel_none.Text = "none";
            this.rdgHwAccel_none.UseVisualStyleBackColor = true;
            this.rdgHwAccel_none.CheckedChanged += new System.EventHandler(this.rdgHwAccel_none_CheckedChanged);
            // 
            // chk360VideoDecoding
            // 
            this.chk360VideoDecoding.AutoSize = true;
            this.chk360VideoDecoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk360VideoDecoding.Location = new System.Drawing.Point(418, 103);
            this.chk360VideoDecoding.Name = "chk360VideoDecoding";
            this.chk360VideoDecoding.Size = new System.Drawing.Size(231, 20);
            this.chk360VideoDecoding.TabIndex = 136;
            this.chk360VideoDecoding.Text = "360° video decoding enabled";
            this.chk360VideoDecoding.UseVisualStyleBackColor = true;
            this.chk360VideoDecoding.CheckedChanged += new System.EventHandler(this.chk360VideoDecoding_CheckedChanged);
            // 
            // Player
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1297, 306);
            this.ControlBox = false;
            this.Controls.Add(this.chk360VideoDecoding);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.updSpeedRadioValue);
            this.Controls.Add(this.btnChooseClip);
            this.Controls.Add(this.btnOpenAtFrames);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.chkLoop);
            this.Controls.Add(this.chkReopen);
            this.Controls.Add(this.chkKeepBounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOpenAtTimes);
            this.Controls.Add(this.txtStopTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtStopFrame);
            this.Controls.Add(this.txtStartFrame);
            this.Controls.Add(this.Label30);
            this.Controls.Add(this.chkUseClock);
            this.Controls.Add(this.btnHeaderInfo);
            this.Controls.Add(this.btnClipGeneralInfo);
            this.Controls.Add(this.updPlayerFastSeekSpeed);
            this.Controls.Add(this.updPlayerSpeedRatio);
            this.Controls.Add(this.edtPlayerFileName);
            this.Controls.Add(this.btnClipDuration);
            this.Controls.Add(this.btnPlayerOpenFile);
            this.Controls.Add(this.btnOpenLastClipRecorded);
            this.Controls.Add(this.btnOpenLastClipPlayed);
            this.Controls.Add(this.btnPlayerCloseFile);
            this.Controls.Add(this.btnPlayerOpenStreamingURL);
            this.Controls.Add(this.btnAutoPlay);
            this.Controls.Add(this.chkPlayerAudioRendering);
            this.Controls.Add(this.chkRefreshPausedDisplay);
            this.Controls.Add(this.Label31);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Player_Load);
            this.VisibleChanged += new System.EventHandler(this.Player_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updPlayerFastSeekSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPlayerSpeedRatio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button btnChooseClip;
        private  Button btnOpenAtFrames;
        private  GroupBox GroupBox1;
        internal  ListBox lstPlaylist;
        private  CheckBox chkPlaylistRandom;
        private  CheckBox chkPlaylistLoop;
        private  Button btnPlaylistClose;
        private  Button btnPlaylistStopAfterCurrent;
        private  Button btnPlaylistPrevious;
        private  Button btnPlaylistNext;
        private  Button btnPlaylistPlay;
        private  Button btnPlaylistAdd;
        private  Label Label6;
        private  Label Label5;
        internal  CheckBox chkLoop;
        private  CheckBox chkReopen;
        private  CheckBox chkKeepBounds;
        private  Label label3;
        private  Button btnOpenAtTimes;
        private  TextBox txtStopTime;
        private  TextBox txtStartTime;
        private  TextBox txtStopFrame;
        private  TextBox txtStartFrame;
        private Label Label30;
        private  CheckBox chkUseClock;
        private Button btnHeaderInfo;
        private Button btnClipGeneralInfo;
        private  NumericUpDown updPlayerFastSeekSpeed;
        private  NumericUpDown updPlayerSpeedRatio;
        private TextBox edtPlayerFileName;
        private Button btnClipDuration;
        private Button btnPlayerOpenFile;
        private Button btnOpenLastClipRecorded;
        private Button btnOpenLastClipPlayed;
        private Button btnPlayerCloseFile;
        private Button btnPlayerOpenStreamingURL;
        private CheckBox btnAutoPlay;
        private CheckBox chkPlayerAudioRendering;
        private CheckBox chkRefreshPausedDisplay;
        private Label Label31;
        private  Label label2;
        private  Label label1;
        private  ImageList ImageList1;
        private TextBox updSpeedRadioValue;
        private GroupBox groupBox2;
        private RadioButton rdgHwAccel_d3d11;
        private RadioButton rdgHwAccel_DXVA2;
        private RadioButton rdgHwAccel_QuickSync;
        private RadioButton rdgHwAccel_CUDA;
        private RadioButton rdgHwAccel_none;
        private CheckBox chk360VideoDecoding;

    }
}

