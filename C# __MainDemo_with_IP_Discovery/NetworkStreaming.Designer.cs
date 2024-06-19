using System.Windows.Forms;

namespace MainDemo
{
    partial class NetworkStreaming : Form
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
            this.chkVideoStreamingEnabled = new System.Windows.Forms.CheckBox();
            this.chkAudioStreamingEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResumeStreaming = new System.Windows.Forms.Button();
            this.btnPauseStreaming = new System.Windows.Forms.Button();
            this.btnMultipurposeUDPStreaming = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNDIStreamingOK = new System.Windows.Forms.Button();
            this.edtNDISessionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNDIStreamingClientView = new System.Windows.Forms.Button();
            this.btnNDIClientHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkVideoStreamingEnabled
            // 
            this.chkVideoStreamingEnabled.AutoSize = true;
            this.chkVideoStreamingEnabled.Checked = true;
            this.chkVideoStreamingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVideoStreamingEnabled.Location = new System.Drawing.Point(12, 12);
            this.chkVideoStreamingEnabled.Name = "chkVideoStreamingEnabled";
            this.chkVideoStreamingEnabled.Size = new System.Drawing.Size(119, 21);
            this.chkVideoStreamingEnabled.TabIndex = 1;
            this.chkVideoStreamingEnabled.Text = "video enabled";
            this.chkVideoStreamingEnabled.UseVisualStyleBackColor = true;
            // 
            // chkAudioStreamingEnabled
            // 
            this.chkAudioStreamingEnabled.AutoSize = true;
            this.chkAudioStreamingEnabled.Location = new System.Drawing.Point(11, 45);
            this.chkAudioStreamingEnabled.Name = "chkAudioStreamingEnabled";
            this.chkAudioStreamingEnabled.Size = new System.Drawing.Size(120, 21);
            this.chkAudioStreamingEnabled.TabIndex = 2;
            this.chkAudioStreamingEnabled.Text = "audio enabled";
            this.chkAudioStreamingEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResumeStreaming);
            this.groupBox1.Controls.Add(this.btnPauseStreaming);
            this.groupBox1.Controls.Add(this.btnMultipurposeUDPStreaming);
            this.groupBox1.Location = new System.Drawing.Point(188, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examples";
            // 
            // btnResumeStreaming
            // 
            this.btnResumeStreaming.Location = new System.Drawing.Point(223, 52);
            this.btnResumeStreaming.Name = "btnResumeStreaming";
            this.btnResumeStreaming.Size = new System.Drawing.Size(150, 29);
            this.btnResumeStreaming.TabIndex = 2;
            this.btnResumeStreaming.Text = "resume streaming";
            this.btnResumeStreaming.UseVisualStyleBackColor = true;
            this.btnResumeStreaming.Click += new System.EventHandler(this.btnResumeStreaming_Click);
            // 
            // btnPauseStreaming
            // 
            this.btnPauseStreaming.Location = new System.Drawing.Point(56, 52);
            this.btnPauseStreaming.Name = "btnPauseStreaming";
            this.btnPauseStreaming.Size = new System.Drawing.Size(145, 29);
            this.btnPauseStreaming.TabIndex = 1;
            this.btnPauseStreaming.Text = "pause streaming";
            this.btnPauseStreaming.UseVisualStyleBackColor = true;
            this.btnPauseStreaming.Click += new System.EventHandler(this.btnPauseStreaming_Click);
            // 
            // btnMultipurposeUDPStreaming
            // 
            this.btnMultipurposeUDPStreaming.Location = new System.Drawing.Point(6, 20);
            this.btnMultipurposeUDPStreaming.Name = "btnMultipurposeUDPStreaming";
            this.btnMultipurposeUDPStreaming.Size = new System.Drawing.Size(440, 23);
            this.btnMultipurposeUDPStreaming.TabIndex = 0;
            this.btnMultipurposeUDPStreaming.Text = "UDP streaming 2Mb/s, destination : udp://@239.255.0.1:10124";
            this.btnMultipurposeUDPStreaming.UseVisualStyleBackColor = true;
            this.btnMultipurposeUDPStreaming.Click += new System.EventHandler(this.btnMultipurposeUDPStreaming_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(191, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encoder (requires the Datastead Multipurpose Encoder)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(643, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "NDI (requires the Datastead NDI filters)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNDIStreamingOK);
            this.groupBox2.Controls.Add(this.edtNDISessionName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(646, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "server side: ";
            // 
            // btnNDIStreamingOK
            // 
            this.btnNDIStreamingOK.Location = new System.Drawing.Point(17, 39);
            this.btnNDIStreamingOK.Name = "btnNDIStreamingOK";
            this.btnNDIStreamingOK.Size = new System.Drawing.Size(48, 34);
            this.btnNDIStreamingOK.TabIndex = 3;
            this.btnNDIStreamingOK.Text = "OK";
            this.btnNDIStreamingOK.UseVisualStyleBackColor = true;
            this.btnNDIStreamingOK.Click += new System.EventHandler(this.btnNDIStreamingOK_Click);
            // 
            // edtNDISessionName
            // 
            this.edtNDISessionName.Location = new System.Drawing.Point(132, 18);
            this.edtNDISessionName.Name = "edtNDISessionName";
            this.edtNDISessionName.Size = new System.Drawing.Size(140, 22);
            this.edtNDISessionName.TabIndex = 2;
            this.edtNDISessionName.Text = "MYSTREAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "(then, start e.g. the preview or playback)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "session name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNDIStreamingClientView);
            this.groupBox3.Controls.Add(this.btnNDIClientHelp);
            this.groupBox3.Location = new System.Drawing.Point(646, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 60);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "client side: (from a 2nd MainDemo.exe)";
            // 
            // btnNDIStreamingClientView
            // 
            this.btnNDIStreamingClientView.Location = new System.Drawing.Point(5, 21);
            this.btnNDIStreamingClientView.Name = "btnNDIStreamingClientView";
            this.btnNDIStreamingClientView.Size = new System.Drawing.Size(60, 26);
            this.btnNDIStreamingClientView.TabIndex = 1;
            this.btnNDIStreamingClientView.Text = "View";
            this.btnNDIStreamingClientView.UseVisualStyleBackColor = true;
            this.btnNDIStreamingClientView.Click += new System.EventHandler(this.btnNDIStreamingClientView_Click);
            // 
            // btnNDIClientHelp
            // 
            this.btnNDIClientHelp.Location = new System.Drawing.Point(78, 21);
            this.btnNDIClientHelp.Name = "btnNDIClientHelp";
            this.btnNDIClientHelp.Size = new System.Drawing.Size(38, 26);
            this.btnNDIClientHelp.TabIndex = 0;
            this.btnNDIClientHelp.Text = "?";
            this.btnNDIClientHelp.UseVisualStyleBackColor = true;
            this.btnNDIClientHelp.Click += new System.EventHandler(this.btnNDIClientHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "FOR MORE EXAMPLES PLEASE CONTACT US at support@datastead.com";
            // 
            // NetworkStreaming
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1259, 287);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAudioStreamingEnabled);
            this.Controls.Add(this.chkVideoStreamingEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkStreaming";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.NetworkStreaming_Load);
            this.VisibleChanged += new System.EventHandler(this.NetworkStreaming_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private CheckBox chkVideoStreamingEnabled;
        private CheckBox chkAudioStreamingEnabled;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnResumeStreaming;
        private Button btnPauseStreaming;
        private Button btnMultipurposeUDPStreaming;
        private Button btnNDIStreamingOK;
        private TextBox edtNDISessionName;
        private Label label5;
        private Label label4;
        private Button btnNDIStreamingClientView;
        private Button btnNDIClientHelp;
        private Label label1;
        private int m_MultipurposeUDPStreamingID = -1;
    }
}

