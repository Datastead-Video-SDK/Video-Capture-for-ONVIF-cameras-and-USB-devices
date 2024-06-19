using System.Windows.Forms;

namespace MainDemo
{
    partial class MultipurposeEncoder : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipurposeEncoder));
            this.tbcMPE = new System.Windows.Forms.TabControl();
            this.tbpDatasteadEncoder = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxExtraParameters = new System.Windows.Forms.TextBox();
            this.grbMPEAudio = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edtDatasteadEncoder_Audio_BitRate_kb = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_Audio_SamplesPerSecond = new System.Windows.Forms.TextBox();
            this.grbMPEVideo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rgbMPERateControl = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtDatasteadEncoder_Video_rc_BufferSize_kb = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_Video_rc_MinBitRate_kb = new System.Windows.Forms.TextBox();
            this.cmbGPUEncoder = new System.Windows.Forms.ComboBox();
            this.edtDatasteadEncoder_Video_ThreadCount = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_Video_MaxBframes = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_Video_IDRInterval = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_Video_Bitrate_kb = new System.Windows.Forms.TextBox();
            this.edtDatasteadEncoder_CodecName = new System.Windows.Forms.TextBox();
            this.tbxDatasteadEncoderInfo = new System.Windows.Forms.TextBox();
            this.tbpMPECommandLine = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStopMPEReencoding = new System.Windows.Forms.Button();
            this.btnStartMPEReencoding = new System.Windows.Forms.Button();
            this.edtMPEReencoding = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edtMPEStreaming = new System.Windows.Forms.TextBox();
            this.chkMPEStreaming = new System.Windows.Forms.CheckBox();
            this.grbMPERecord = new System.Windows.Forms.GroupBox();
            this.edtMPERecording = new System.Windows.Forms.TextBox();
            this.chkMPERecording = new System.Windows.Forms.CheckBox();
            this.tbcMPE.SuspendLayout();
            this.tbpDatasteadEncoder.SuspendLayout();
            this.grbMPEAudio.SuspendLayout();
            this.grbMPEVideo.SuspendLayout();
            this.rgbMPERateControl.SuspendLayout();
            this.tbpMPECommandLine.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbMPERecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMPE
            // 
            this.tbcMPE.Controls.Add(this.tbpDatasteadEncoder);
            this.tbcMPE.Controls.Add(this.tbpMPECommandLine);
            this.tbcMPE.Location = new System.Drawing.Point(4, 3);
            this.tbcMPE.Name = "tbcMPE";
            this.tbcMPE.SelectedIndex = 0;
            this.tbcMPE.Size = new System.Drawing.Size(1402, 240);
            this.tbcMPE.TabIndex = 0;
            // 
            // tbpDatasteadEncoder
            // 
            this.tbpDatasteadEncoder.Controls.Add(this.label10);
            this.tbpDatasteadEncoder.Controls.Add(this.tbxExtraParameters);
            this.tbpDatasteadEncoder.Controls.Add(this.grbMPEAudio);
            this.tbpDatasteadEncoder.Controls.Add(this.grbMPEVideo);
            this.tbpDatasteadEncoder.Controls.Add(this.tbxDatasteadEncoderInfo);
            this.tbpDatasteadEncoder.Location = new System.Drawing.Point(4, 25);
            this.tbpDatasteadEncoder.Name = "tbpDatasteadEncoder";
            this.tbpDatasteadEncoder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatasteadEncoder.Size = new System.Drawing.Size(1394, 211);
            this.tbpDatasteadEncoder.TabIndex = 0;
            this.tbpDatasteadEncoder.Text = "Datastead Encoder";
            this.tbpDatasteadEncoder.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(931, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Extra parameters:";
            // 
            // tbxExtraParameters
            // 
            this.tbxExtraParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExtraParameters.Location = new System.Drawing.Point(931, 119);
            this.tbxExtraParameters.Multiline = true;
            this.tbxExtraParameters.Name = "tbxExtraParameters";
            this.tbxExtraParameters.Size = new System.Drawing.Size(294, 73);
            this.tbxExtraParameters.TabIndex = 4;
            this.tbxExtraParameters.TextChanged += new System.EventHandler(this.mmoExtraParameters_TextChanged);
            // 
            // grbMPEAudio
            // 
            this.grbMPEAudio.Controls.Add(this.label12);
            this.grbMPEAudio.Controls.Add(this.label11);
            this.grbMPEAudio.Controls.Add(this.edtDatasteadEncoder_Audio_BitRate_kb);
            this.grbMPEAudio.Controls.Add(this.edtDatasteadEncoder_Audio_SamplesPerSecond);
            this.grbMPEAudio.Location = new System.Drawing.Point(931, 0);
            this.grbMPEAudio.Name = "grbMPEAudio";
            this.grbMPEAudio.Size = new System.Drawing.Size(294, 96);
            this.grbMPEAudio.TabIndex = 3;
            this.grbMPEAudio.TabStop = false;
            this.grbMPEAudio.Text = "Audio: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Bit rate (kbps) e.g. 64, 128";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "samples per sec (44100, 22050...)";
            // 
            // edtDatasteadEncoder_Audio_BitRate_kb
            // 
            this.edtDatasteadEncoder_Audio_BitRate_kb.Location = new System.Drawing.Point(6, 49);
            this.edtDatasteadEncoder_Audio_BitRate_kb.Name = "edtDatasteadEncoder_Audio_BitRate_kb";
            this.edtDatasteadEncoder_Audio_BitRate_kb.Size = new System.Drawing.Size(57, 22);
            this.edtDatasteadEncoder_Audio_BitRate_kb.TabIndex = 3;
            this.edtDatasteadEncoder_Audio_BitRate_kb.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Audio_BitRate_kb_TextChanged);
            // 
            // edtDatasteadEncoder_Audio_SamplesPerSecond
            // 
            this.edtDatasteadEncoder_Audio_SamplesPerSecond.Location = new System.Drawing.Point(6, 21);
            this.edtDatasteadEncoder_Audio_SamplesPerSecond.Name = "edtDatasteadEncoder_Audio_SamplesPerSecond";
            this.edtDatasteadEncoder_Audio_SamplesPerSecond.Size = new System.Drawing.Size(57, 22);
            this.edtDatasteadEncoder_Audio_SamplesPerSecond.TabIndex = 2;
            this.edtDatasteadEncoder_Audio_SamplesPerSecond.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Audio_SamplesPerSecond_TextChanged);
            // 
            // grbMPEVideo
            // 
            this.grbMPEVideo.Controls.Add(this.label9);
            this.grbMPEVideo.Controls.Add(this.label8);
            this.grbMPEVideo.Controls.Add(this.label7);
            this.grbMPEVideo.Controls.Add(this.label6);
            this.grbMPEVideo.Controls.Add(this.label5);
            this.grbMPEVideo.Controls.Add(this.label4);
            this.grbMPEVideo.Controls.Add(this.rgbMPERateControl);
            this.grbMPEVideo.Controls.Add(this.cmbGPUEncoder);
            this.grbMPEVideo.Controls.Add(this.edtDatasteadEncoder_Video_ThreadCount);
            this.grbMPEVideo.Controls.Add(this.edtDatasteadEncoder_Video_MaxBframes);
            this.grbMPEVideo.Controls.Add(this.edtDatasteadEncoder_Video_IDRInterval);
            this.grbMPEVideo.Controls.Add(this.edtDatasteadEncoder_Video_Bitrate_kb);
            this.grbMPEVideo.Controls.Add(this.edtDatasteadEncoder_CodecName);
            this.grbMPEVideo.Location = new System.Drawing.Point(246, 0);
            this.grbMPEVideo.Name = "grbMPEVideo";
            this.grbMPEVideo.Size = new System.Drawing.Size(679, 200);
            this.grbMPEVideo.TabIndex = 1;
            this.grbMPEVideo.TabStop = false;
            this.grbMPEVideo.Text = "Video: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Codec name, e.g. \"h264\", \"hevc\", \"mpeg4\" or empty for default";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bit rate (kbps)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thread count, 1 by default (4 by default for h264)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max B-frames, 0 by default";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "IDR Interval (GOP), e.g. 30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bit rate (kbps)";
            // 
            // rgbMPERateControl
            // 
            this.rgbMPERateControl.Controls.Add(this.label3);
            this.rgbMPERateControl.Controls.Add(this.label2);
            this.rgbMPERateControl.Controls.Add(this.label1);
            this.rgbMPERateControl.Controls.Add(this.edtDatasteadEncoder_Video_rc_BufferSize_kb);
            this.rgbMPERateControl.Controls.Add(this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb);
            this.rgbMPERateControl.Controls.Add(this.edtDatasteadEncoder_Video_rc_MinBitRate_kb);
            this.rgbMPERateControl.Location = new System.Drawing.Point(488, 77);
            this.rgbMPERateControl.Name = "rgbMPERateControl";
            this.rgbMPERateControl.Size = new System.Drawing.Size(191, 112);
            this.rgbMPERateControl.TabIndex = 6;
            this.rgbMPERateControl.TabStop = false;
            this.rgbMPERateControl.Text = "rate control: (kbps)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "buffer size*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "max bit rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "min bit rate";
            // 
            // edtDatasteadEncoder_Video_rc_BufferSize_kb
            // 
            this.edtDatasteadEncoder_Video_rc_BufferSize_kb.Location = new System.Drawing.Point(6, 76);
            this.edtDatasteadEncoder_Video_rc_BufferSize_kb.Name = "edtDatasteadEncoder_Video_rc_BufferSize_kb";
            this.edtDatasteadEncoder_Video_rc_BufferSize_kb.Size = new System.Drawing.Size(67, 22);
            this.edtDatasteadEncoder_Video_rc_BufferSize_kb.TabIndex = 5;
            this.edtDatasteadEncoder_Video_rc_BufferSize_kb.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_rc_BufferSize_kb_TextChanged);
            // 
            // edtDatasteadEncoder_Video_rc_MaxBitRate_kb
            // 
            this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Location = new System.Drawing.Point(6, 48);
            this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Name = "edtDatasteadEncoder_Video_rc_MaxBitRate_kb";
            this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Size = new System.Drawing.Size(67, 22);
            this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.TabIndex = 4;
            this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_rc_MaxBitRate_kb_TextChanged);
            // 
            // edtDatasteadEncoder_Video_rc_MinBitRate_kb
            // 
            this.edtDatasteadEncoder_Video_rc_MinBitRate_kb.Location = new System.Drawing.Point(6, 20);
            this.edtDatasteadEncoder_Video_rc_MinBitRate_kb.Name = "edtDatasteadEncoder_Video_rc_MinBitRate_kb";
            this.edtDatasteadEncoder_Video_rc_MinBitRate_kb.Size = new System.Drawing.Size(67, 22);
            this.edtDatasteadEncoder_Video_rc_MinBitRate_kb.TabIndex = 3;
            this.edtDatasteadEncoder_Video_rc_MinBitRate_kb.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_rc_MinBitRate_kb_TextChanged);
            // 
            // cmbGPUEncoder
            // 
            this.cmbGPUEncoder.FormattingEnabled = true;
            this.cmbGPUEncoder.Items.AddRange(new object[] {
            "None",
            "Auto",
            "Intel_QSV",
            "NVidia_NVENC",
            "AMD_AMF"});
            this.cmbGPUEncoder.Location = new System.Drawing.Point(59, 158);
            this.cmbGPUEncoder.Name = "cmbGPUEncoder";
            this.cmbGPUEncoder.Size = new System.Drawing.Size(103, 24);
            this.cmbGPUEncoder.TabIndex = 5;
            this.cmbGPUEncoder.SelectedIndexChanged += new System.EventHandler(this.cmbGPUEncoder_SelectedIndexChanged);
            // 
            // edtDatasteadEncoder_Video_ThreadCount
            // 
            this.edtDatasteadEncoder_Video_ThreadCount.Location = new System.Drawing.Point(59, 130);
            this.edtDatasteadEncoder_Video_ThreadCount.Name = "edtDatasteadEncoder_Video_ThreadCount";
            this.edtDatasteadEncoder_Video_ThreadCount.Size = new System.Drawing.Size(103, 22);
            this.edtDatasteadEncoder_Video_ThreadCount.TabIndex = 4;
            this.edtDatasteadEncoder_Video_ThreadCount.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_ThreadCount_TextChanged);
            // 
            // edtDatasteadEncoder_Video_MaxBframes
            // 
            this.edtDatasteadEncoder_Video_MaxBframes.Location = new System.Drawing.Point(59, 102);
            this.edtDatasteadEncoder_Video_MaxBframes.Name = "edtDatasteadEncoder_Video_MaxBframes";
            this.edtDatasteadEncoder_Video_MaxBframes.Size = new System.Drawing.Size(103, 22);
            this.edtDatasteadEncoder_Video_MaxBframes.TabIndex = 3;
            this.edtDatasteadEncoder_Video_MaxBframes.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_MaxBframes_TextChanged);
            // 
            // edtDatasteadEncoder_Video_IDRInterval
            // 
            this.edtDatasteadEncoder_Video_IDRInterval.Location = new System.Drawing.Point(59, 74);
            this.edtDatasteadEncoder_Video_IDRInterval.Name = "edtDatasteadEncoder_Video_IDRInterval";
            this.edtDatasteadEncoder_Video_IDRInterval.Size = new System.Drawing.Size(103, 22);
            this.edtDatasteadEncoder_Video_IDRInterval.TabIndex = 2;
            this.edtDatasteadEncoder_Video_IDRInterval.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_IDRInterval_TextChanged);
            // 
            // edtDatasteadEncoder_Video_Bitrate_kb
            // 
            this.edtDatasteadEncoder_Video_Bitrate_kb.Location = new System.Drawing.Point(59, 46);
            this.edtDatasteadEncoder_Video_Bitrate_kb.Name = "edtDatasteadEncoder_Video_Bitrate_kb";
            this.edtDatasteadEncoder_Video_Bitrate_kb.Size = new System.Drawing.Size(103, 22);
            this.edtDatasteadEncoder_Video_Bitrate_kb.TabIndex = 1;
            this.edtDatasteadEncoder_Video_Bitrate_kb.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_Video_Bitrate_kb_TextChanged);
            // 
            // edtDatasteadEncoder_CodecName
            // 
            this.edtDatasteadEncoder_CodecName.Location = new System.Drawing.Point(59, 18);
            this.edtDatasteadEncoder_CodecName.Name = "edtDatasteadEncoder_CodecName";
            this.edtDatasteadEncoder_CodecName.Size = new System.Drawing.Size(103, 22);
            this.edtDatasteadEncoder_CodecName.TabIndex = 0;
            this.edtDatasteadEncoder_CodecName.TextChanged += new System.EventHandler(this.edtDatasteadEncoder_CodecName_TextChanged);
            // 
            // tbxDatasteadEncoderInfo
            // 
            this.tbxDatasteadEncoderInfo.Location = new System.Drawing.Point(5, 0);
            this.tbxDatasteadEncoderInfo.Multiline = true;
            this.tbxDatasteadEncoderInfo.Name = "tbxDatasteadEncoderInfo";
            this.tbxDatasteadEncoderInfo.Size = new System.Drawing.Size(235, 200);
            this.tbxDatasteadEncoderInfo.TabIndex = 0;
            // 
            // tbpMPECommandLine
            // 
            this.tbpMPECommandLine.Controls.Add(this.groupBox2);
            this.tbpMPECommandLine.Controls.Add(this.groupBox1);
            this.tbpMPECommandLine.Controls.Add(this.grbMPERecord);
            this.tbpMPECommandLine.Location = new System.Drawing.Point(4, 25);
            this.tbpMPECommandLine.Name = "tbpMPECommandLine";
            this.tbpMPECommandLine.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMPECommandLine.Size = new System.Drawing.Size(1394, 211);
            this.tbpMPECommandLine.TabIndex = 1;
            this.tbpMPECommandLine.Text = "Command line encoder";
            this.tbpMPECommandLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStopMPEReencoding);
            this.groupBox2.Controls.Add(this.btnStartMPEReencoding);
            this.groupBox2.Controls.Add(this.edtMPEReencoding);
            this.groupBox2.Location = new System.Drawing.Point(6, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1225, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direct transcoding: replace these sample file names by the real files to process," +
    " specify more FFmpeg settings if needed, then click \"Start MPE reencoding\"";
            // 
            // btnStopMPEReencoding
            // 
            this.btnStopMPEReencoding.Location = new System.Drawing.Point(1168, 20);
            this.btnStopMPEReencoding.Name = "btnStopMPEReencoding";
            this.btnStopMPEReencoding.Size = new System.Drawing.Size(50, 27);
            this.btnStopMPEReencoding.TabIndex = 3;
            this.btnStopMPEReencoding.Text = "Stop";
            this.btnStopMPEReencoding.UseVisualStyleBackColor = true;
            this.btnStopMPEReencoding.Click += new System.EventHandler(this.btnStopMPEReencoding_Click);
            // 
            // btnStartMPEReencoding
            // 
            this.btnStartMPEReencoding.Location = new System.Drawing.Point(1012, 20);
            this.btnStartMPEReencoding.Name = "btnStartMPEReencoding";
            this.btnStartMPEReencoding.Size = new System.Drawing.Size(151, 27);
            this.btnStartMPEReencoding.TabIndex = 2;
            this.btnStartMPEReencoding.Text = "Start MPE reencoding";
            this.btnStartMPEReencoding.UseVisualStyleBackColor = true;
            this.btnStartMPEReencoding.Click += new System.EventHandler(this.btnStartMPEReencoding_Click);
            // 
            // edtMPEReencoding
            // 
            this.edtMPEReencoding.Location = new System.Drawing.Point(7, 22);
            this.edtMPEReencoding.Name = "edtMPEReencoding";
            this.edtMPEReencoding.Size = new System.Drawing.Size(997, 22);
            this.edtMPEReencoding.TabIndex = 1;
            this.edtMPEReencoding.Text = "ffmpegLGPL.exe -i \"c:\\folder\\ClipToReencode.avi\" -f mp4 \"c:\\folder\\ClipReencodedT" +
    "oMP4.mp4\"";
            this.edtMPEReencoding.TextChanged += new System.EventHandler(this.edtMPEReencoding_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtMPEStreaming);
            this.groupBox1.Controls.Add(this.chkMPEStreaming);
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1225, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STREAMING: enable it then start the preview in the \"video source\" tab or recordin" +
    "g in the \"Recording\" tab        (note: it supersedes ALL the streaming settings " +
    "of the \"WM Streaming\" tab)";
            // 
            // edtMPEStreaming
            // 
            this.edtMPEStreaming.Location = new System.Drawing.Point(84, 23);
            this.edtMPEStreaming.Name = "edtMPEStreaming";
            this.edtMPEStreaming.Size = new System.Drawing.Size(1134, 22);
            this.edtMPEStreaming.TabIndex = 1;
            this.edtMPEStreaming.Text = resources.GetString("edtMPEStreaming.Text");
            this.edtMPEStreaming.TextChanged += new System.EventHandler(this.edtMPEStreaming_TextChanged);
            // 
            // chkMPEStreaming
            // 
            this.chkMPEStreaming.AutoSize = true;
            this.chkMPEStreaming.Location = new System.Drawing.Point(14, 23);
            this.chkMPEStreaming.Name = "chkMPEStreaming";
            this.chkMPEStreaming.Size = new System.Drawing.Size(73, 21);
            this.chkMPEStreaming.TabIndex = 0;
            this.chkMPEStreaming.Text = "enable";
            this.chkMPEStreaming.UseVisualStyleBackColor = true;
            this.chkMPEStreaming.CheckedChanged += new System.EventHandler(this.chkMPEStreaming_CheckedChanged);
            // 
            // grbMPERecord
            // 
            this.grbMPERecord.Controls.Add(this.edtMPERecording);
            this.grbMPERecord.Controls.Add(this.chkMPERecording);
            this.grbMPERecord.Location = new System.Drawing.Point(6, 6);
            this.grbMPERecord.Name = "grbMPERecord";
            this.grbMPERecord.Size = new System.Drawing.Size(1225, 55);
            this.grbMPERecord.TabIndex = 3;
            this.grbMPERecord.TabStop = false;
            this.grbMPERecord.Text = "RECORDING: enable it then start the recording in the \"Recording\" tab         (not" +
    "e: it supersedes ALL the compression and codec settings of the \"Recording\" tab)";
            // 
            // edtMPERecording
            // 
            this.edtMPERecording.Location = new System.Drawing.Point(84, 23);
            this.edtMPERecording.Name = "edtMPERecording";
            this.edtMPERecording.Size = new System.Drawing.Size(1134, 22);
            this.edtMPERecording.TabIndex = 1;
            this.edtMPERecording.Text = "ffmpegLGPL.exe -re -i %PIPE% -c:v h264 -threads 8 -profile:v baseline -loopfilter" +
    " 0 -b:v 10M -an -f mp4 %FILENAME%";
            this.edtMPERecording.TextChanged += new System.EventHandler(this.edtMPERecording_TextChanged);
            // 
            // chkMPERecording
            // 
            this.chkMPERecording.AutoSize = true;
            this.chkMPERecording.Location = new System.Drawing.Point(14, 23);
            this.chkMPERecording.Name = "chkMPERecording";
            this.chkMPERecording.Size = new System.Drawing.Size(73, 21);
            this.chkMPERecording.TabIndex = 0;
            this.chkMPERecording.Text = "enable";
            this.chkMPERecording.UseVisualStyleBackColor = true;
            this.chkMPERecording.CheckedChanged += new System.EventHandler(this.chkMPERecording_CheckedChanged);
            // 
            // MultipurposeEncoder
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1648, 337);
            this.ControlBox = false;
            this.Controls.Add(this.tbcMPE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultipurposeEncoder";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.MultipurposeEncoder_VisibleChanged);
            this.tbcMPE.ResumeLayout(false);
            this.tbpDatasteadEncoder.ResumeLayout(false);
            this.tbpDatasteadEncoder.PerformLayout();
            this.grbMPEAudio.ResumeLayout(false);
            this.grbMPEAudio.PerformLayout();
            this.grbMPEVideo.ResumeLayout(false);
            this.grbMPEVideo.PerformLayout();
            this.rgbMPERateControl.ResumeLayout(false);
            this.rgbMPERateControl.PerformLayout();
            this.tbpMPECommandLine.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbMPERecord.ResumeLayout(false);
            this.grbMPERecord.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TabControl tbcMPE;
        private TabPage tbpDatasteadEncoder;
        private TabPage tbpMPECommandLine;
        private GroupBox groupBox2;
        private Button btnStopMPEReencoding;
        private Button btnStartMPEReencoding;
        private TextBox edtMPEReencoding;
        private GroupBox groupBox1;
        private TextBox edtMPEStreaming;
        private CheckBox chkMPEStreaming;
        private GroupBox grbMPERecord;
        private TextBox edtMPERecording;
        private CheckBox chkMPERecording;
        private TextBox tbxDatasteadEncoderInfo;
        private GroupBox grbMPEAudio;
        private GroupBox grbMPEVideo;
        private TextBox edtDatasteadEncoder_Video_Bitrate_kb;
        private TextBox edtDatasteadEncoder_CodecName;
        private ComboBox cmbGPUEncoder;
        private TextBox edtDatasteadEncoder_Video_ThreadCount;
        private TextBox edtDatasteadEncoder_Video_MaxBframes;
        private TextBox edtDatasteadEncoder_Video_IDRInterval;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox rgbMPERateControl;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox edtDatasteadEncoder_Video_rc_BufferSize_kb;
        private TextBox edtDatasteadEncoder_Video_rc_MaxBitRate_kb;
        private TextBox edtDatasteadEncoder_Video_rc_MinBitRate_kb;
        private Label label10;
        private TextBox tbxExtraParameters;
        private Label label12;
        private Label label11;
        private TextBox edtDatasteadEncoder_Audio_BitRate_kb;
        private TextBox edtDatasteadEncoder_Audio_SamplesPerSecond;
    }
}

