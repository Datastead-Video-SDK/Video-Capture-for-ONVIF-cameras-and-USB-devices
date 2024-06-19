using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for VideoFromJPEGsorBitmaps.
	/// </summary>
	public class VideoFromJPEGsOrBitmaps : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal GroupBox grbVideoFromJPEGsorBitmaps;
        internal Button btnStopPreview;
        internal Button btnStartPreview;
        internal CheckBox chkLoopIndefinitely;
        internal Button btnBrowseFolders;
        internal TextBox edtSourceFolder;
        internal Label Label1;
        internal PictureBox PictureBox4;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox1;
        internal RadioButton rbFromBMPorJPEGfiles;
        internal RadioButton rbFromPictureBox;
        internal Label lblFirstSelectJPEGsOrBitmaps;
        internal Label Label2;
        internal TextBox edtVideoFromJPEGsorBitmaps;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private VidGrab.VideoGrabber  VideoGrabber = MainForm.cMainForm.VideoGrabber1;

		public VideoFromJPEGsOrBitmaps()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoFromJPEGsOrBitmaps));
            this.grbVideoFromJPEGsorBitmaps = new System.Windows.Forms.GroupBox();
            this.btnStopPreview = new System.Windows.Forms.Button();
            this.btnStartPreview = new System.Windows.Forms.Button();
            this.chkLoopIndefinitely = new System.Windows.Forms.CheckBox();
            this.btnBrowseFolders = new System.Windows.Forms.Button();
            this.edtSourceFolder = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbFromBMPorJPEGfiles = new System.Windows.Forms.RadioButton();
            this.rbFromPictureBox = new System.Windows.Forms.RadioButton();
            this.lblFirstSelectJPEGsOrBitmaps = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.edtVideoFromJPEGsorBitmaps = new System.Windows.Forms.TextBox();
            this.grbVideoFromJPEGsorBitmaps.SuspendLayout();
#if (!VS2003) 
			((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
#endif
			this.SuspendLayout();
            // 
            // grbVideoFromJPEGsorBitmaps
            // 
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.btnStopPreview);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.btnStartPreview);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.chkLoopIndefinitely);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.btnBrowseFolders);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.edtSourceFolder);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.Label1);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.PictureBox4);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.PictureBox3);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.PictureBox2);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.PictureBox1);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.rbFromBMPorJPEGfiles);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.rbFromPictureBox);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.lblFirstSelectJPEGsOrBitmaps);
            this.grbVideoFromJPEGsorBitmaps.Controls.Add(this.Label2);
            this.grbVideoFromJPEGsorBitmaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVideoFromJPEGsorBitmaps.Location = new System.Drawing.Point(4, 0);
            this.grbVideoFromJPEGsorBitmaps.Name = "grbVideoFromJPEGsorBitmaps";
            this.grbVideoFromJPEGsorBitmaps.Size = new System.Drawing.Size(585, 176);
            this.grbVideoFromJPEGsorBitmaps.TabIndex = 64;
            this.grbVideoFromJPEGsorBitmaps.TabStop = false;
            this.grbVideoFromJPEGsorBitmaps.Text = "Video from JPEGs or Bitmaps";
            // 
            // btnStopPreview
            // 
            this.btnStopPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopPreview.Location = new System.Drawing.Point(456, 69);
            this.btnStopPreview.Name = "btnStopPreview";
            this.btnStopPreview.Size = new System.Drawing.Size(88, 24);
            this.btnStopPreview.TabIndex = 59;
            this.btnStopPreview.Text = "Stop preview";
            this.btnStopPreview.Click += new System.EventHandler(this.btnStopPreview_Click);
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPreview.Location = new System.Drawing.Point(362, 69);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.Size = new System.Drawing.Size(88, 24);
            this.btnStartPreview.TabIndex = 37;
            this.btnStartPreview.Text = "Start preview";
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // chkLoopIndefinitely
            // 
#if (!VS2003) 
			this.chkLoopIndefinitely.AutoSize = true;
#endif
			this.chkLoopIndefinitely.Checked = true;
            this.chkLoopIndefinitely.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoopIndefinitely.Enabled = false;
            this.chkLoopIndefinitely.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoopIndefinitely.Location = new System.Drawing.Point(222, 121);
            this.chkLoopIndefinitely.Name = "chkLoopIndefinitely";
            this.chkLoopIndefinitely.Size = new System.Drawing.Size(98, 17);
            this.chkLoopIndefinitely.TabIndex = 72;
            this.chkLoopIndefinitely.Text = "loop indefinitely";
            // 
            // btnBrowseFolders
            // 
            this.btnBrowseFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFolders.Location = new System.Drawing.Point(545, 141);
            this.btnBrowseFolders.Name = "btnBrowseFolders";
            this.btnBrowseFolders.Size = new System.Drawing.Size(27, 22);
            this.btnBrowseFolders.TabIndex = 71;
            this.btnBrowseFolders.Text = "...";
            this.btnBrowseFolders.Click += new System.EventHandler(this.btnBrowseFolders_Click);
            // 
            // edtSourceFolder
            // 
            this.edtSourceFolder.Location = new System.Drawing.Point(222, 141);
            this.edtSourceFolder.Name = "edtSourceFolder";
            this.edtSourceFolder.Size = new System.Drawing.Size(327, 20);
            this.edtSourceFolder.TabIndex = 70;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(29, 141);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(190, 13);
            this.Label1.TabIndex = 69;
            this.Label1.Text = "source folder of the BMP or JPEG files:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(194, 59);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(50, 50);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox4.TabIndex = 68;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(138, 59);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(50, 50);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 67;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(82, 59);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(50, 50);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 66;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(26, 59);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 65;
            this.PictureBox1.TabStop = false;
            // 
            // rbFromBMPorJPEGfiles
            // 
            this.rbFromBMPorJPEGfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromBMPorJPEGfiles.Location = new System.Drawing.Point(15, 121);
            this.rbFromBMPorJPEGfiles.Name = "rbFromBMPorJPEGfiles";
            this.rbFromBMPorJPEGfiles.Size = new System.Drawing.Size(152, 21);
            this.rbFromBMPorJPEGfiles.TabIndex = 64;
            this.rbFromBMPorJPEGfiles.Text = "from BMP or JPEG files:";
            this.rbFromBMPorJPEGfiles.CheckedChanged += new System.EventHandler(this.rbFromBMPorJPEGfiles_CheckedChanged);
            // 
            // rbFromPictureBox
            // 
            this.rbFromPictureBox.Checked = true;
            this.rbFromPictureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromPictureBox.Location = new System.Drawing.Point(15, 35);
            this.rbFromPictureBox.Name = "rbFromPictureBox";
            this.rbFromPictureBox.Size = new System.Drawing.Size(192, 24);
            this.rbFromPictureBox.TabIndex = 63;
            this.rbFromPictureBox.TabStop = true;
            this.rbFromPictureBox.Text = "from PictureBox images, e.g.:";
            this.rbFromPictureBox.CheckedChanged += new System.EventHandler(this.rbFromPictureBox_CheckedChanged);
            // 
            // lblFirstSelectJPEGsOrBitmaps
            // 
            this.lblFirstSelectJPEGsOrBitmaps.AutoSize = true;
            this.lblFirstSelectJPEGsOrBitmaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstSelectJPEGsOrBitmaps.ForeColor = System.Drawing.Color.Red;
            this.lblFirstSelectJPEGsOrBitmaps.Location = new System.Drawing.Point(8, 17);
            this.lblFirstSelectJPEGsOrBitmaps.Name = "lblFirstSelectJPEGsOrBitmaps";
            this.lblFirstSelectJPEGsOrBitmaps.Size = new System.Drawing.Size(565, 13);
            this.lblFirstSelectJPEGsOrBitmaps.TabIndex = 62;
            this.lblFirstSelectJPEGsOrBitmaps.Text = "first select VideoSource = vs_JPEGsOrBitmaps in the Video Sources list of the  \"v" +
                "ideo source\" tab";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(359, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 73;
            this.Label2.Text = "Start / Stop Preview";
            // 
            // edtVideoFromJPEGsorBitmaps
            // 
            this.edtVideoFromJPEGsorBitmaps.BackColor = System.Drawing.Color.Silver;
            this.edtVideoFromJPEGsorBitmaps.Location = new System.Drawing.Point(595, 6);
            this.edtVideoFromJPEGsorBitmaps.Multiline = true;
            this.edtVideoFromJPEGsorBitmaps.Name = "edtVideoFromJPEGsorBitmaps";
            this.edtVideoFromJPEGsorBitmaps.ReadOnly = true;
            this.edtVideoFromJPEGsorBitmaps.Size = new System.Drawing.Size(315, 170);
            this.edtVideoFromJPEGsorBitmaps.TabIndex = 63;
            this.edtVideoFromJPEGsorBitmaps.Text = resources.GetString("edtVideoFromJPEGsorBitmaps.Text");
            // 
            // VideoFromJPEGsOrBitmaps
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1053, 290);
            this.ControlBox = false;
            this.Controls.Add(this.grbVideoFromJPEGsorBitmaps);
            this.Controls.Add(this.edtVideoFromJPEGsorBitmaps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoFromJPEGsOrBitmaps";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.VideoFromJPEGsOrBitmaps_VisibleChanged);
            this.grbVideoFromJPEGsorBitmaps.ResumeLayout(false);
            this.grbVideoFromJPEGsorBitmaps.PerformLayout();
#if (!VS2003) 
			((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
#endif
			this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

        public void RefreshDisplayOptions() 
        {
            lblFirstSelectJPEGsOrBitmaps.Visible = (cMainForm.VideoGrabber1.VideoSource != VidGrab.TVideoSource.vs_JPEGsOrBitmaps);
        }

        private void VideoFromJPEGsOrBitmaps_VisibleChanged(object sender, System.EventArgs e)
        {
            if (Visible) 
            {
                RefreshDisplayOptions();
            }
        }

        private void btnStartPreview_Click(object sender, System.EventArgs e)
        {
            bool ImageFileFound;

            if (cMainForm.VideoGrabber1.VideoSource != VidGrab.TVideoSource.vs_JPEGsOrBitmaps) 
            {
                cMainForm.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_JPEGsOrBitmaps;
                AddLog(cMainForm.mmoLog, "VideoSource set to 'vs_JPEGsOrBitmaps'");
            }

            cMainForm.VideoFromImagesUsePictureBox = rbFromPictureBox.Checked;

            if (cMainForm.VideoFromImagesUsePictureBox) 
            {
                cMainForm.VideoGrabber1.StartPreview();	
            }
            else 
            {
                ImageFileFound = cMainForm.VideoFromImages.ReinitFolder (edtSourceFolder.Text, "*.bmp", chkLoopIndefinitely.Checked);
                if (! ImageFileFound) 
                {
                    ImageFileFound = cMainForm.VideoFromImages.ReinitFolder (edtSourceFolder.Text, "*.jpg", chkLoopIndefinitely.Checked);
                }
                if (ImageFileFound) 
                {
                    cMainForm.VideoGrabber1.StartPreview();	
                }
                else 
                {
                    MessageBox.Show("no bitmap files found in the specified directory! Capture a set of frames to BMP or JPEG files first, e.g. by using the frame grabber in burst mode.",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnStopPreview_Click(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.Stop();	
        }

        private void btnBrowseFolders_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
        
            FolderBrowser.ShowDialog();
            edtSourceFolder.Text = FolderBrowser.SelectedPath;
        }

        private void rbFromPictureBox_CheckedChanged(object sender, EventArgs e)
        {
            chkLoopIndefinitely.Enabled = false;
        }

        private void rbFromBMPorJPEGfiles_CheckedChanged(object sender, EventArgs e)
        {
            chkLoopIndefinitely.Enabled = true;
        }

	}

}
