using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using VidGrab;

namespace MainDemo
{
	public partial class VideoSource : Form
    {

		public VideoSource()
		{
			InitializeComponent();
		}

		public miscCameraControl frmMiscCameraControl;
		public miscVideoQuality frmMiscVideoQuality;
		
		public void RefreshDisplayOptions()
		{
			Helpers.AssignListToComboBox (cboVideoSource, MainForm.cMainForm.VideoGrabber1.VideoSources, (int) MainForm.cMainForm.VideoGrabber1.VideoSource);
			Helpers.AssignListToComboBox (cboVideoDevices, MainForm.cMainForm.VideoGrabber1.VideoDevices, MainForm.cMainForm.VideoGrabber1.VideoDevice);

            if (MainForm.cMainForm.VideoGrabber1.VideoDevice >= 0) // if a video capture device has been selected 
            {
                Helpers.AssignListToComboBox(cboAnalogVideoStandard, MainForm.cMainForm.VideoGrabber1.AnalogVideoStandards, MainForm.cMainForm.VideoGrabber1.AnalogVideoStandard);
                Helpers.AssignListToComboBox(cboVideoSizes, MainForm.cMainForm.VideoGrabber1.VideoSizes, MainForm.cMainForm.VideoGrabber1.VideoSize);
                Helpers.AssignListToComboBox(cboVideoSubtypes, MainForm.cMainForm.VideoGrabber1.VideoSubtypes, MainForm.cMainForm.VideoGrabber1.VideoSubtype);
                Helpers.AssignListToComboBox(cboVideoFormats, MainForm.cMainForm.VideoGrabber1.VideoFormats, MainForm.cMainForm.VideoGrabber1.VideoFormat);
                Helpers.AssignListToComboBox(cboVideoInputs, MainForm.cMainForm.VideoGrabber1.VideoInputs, MainForm.cMainForm.VideoGrabber1.VideoInput);

                cboAnalogVideoStandard.Enabled = MainForm.cMainForm.VideoGrabber1.IsAnalogVideoDecoderAvailable;
                cboVideoInputs.Enabled = MainForm.cMainForm.VideoGrabber1.IsVideoCrossbarAvailable;

            }

            btnAutoRefreshPreview.Enabled = MainForm.cMainForm.VideoGrabber1.AutoRefreshPreview;
			btnAutoRefreshPreview.Checked = MainForm.cMainForm.VideoGrabber1.AutoRefreshPreview;

			cboVideoSource.SelectedIndex = (int) MainForm.cMainForm.VideoGrabber1.VideoSource;

			chkScreenRecordingWithCursor.Checked = MainForm.cMainForm.VideoGrabber1.ScreenRecordingWithCursor;
			edtMonitorNumber.Text = MainForm.cMainForm.VideoGrabber1.ScreenRecordingMonitor.ToString();

			btnCameraControlDialog.Enabled = MainForm.cMainForm.VideoGrabber1.IsCameraControlAvailable;
			btnVideoQualityDialog.Enabled = MainForm.cMainForm.VideoGrabber1.IsVideoQualityAvailable;

			edtFrameRate.Text = MainForm.cMainForm.VideoGrabber1.FrameRate.ToString ("0.00");

			if (frmMiscCameraControl != null) frmMiscCameraControl.RefreshDisplayOptions();
			if (frmMiscVideoQuality != null) frmMiscVideoQuality.RefreshDisplayOptions();
		}

		private void btnAutoRefreshPreview_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AutoRefreshPreview = btnAutoRefreshPreview.Checked;
		}

		private void btnDeviceDialog_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_VideoDevice);
			MainForm.cMainForm.RefreshDisplayOptions();
		}

		private void btnFrameRate_Click(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtFrameRate.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.FrameRate = Convert.ToDouble (edtFrameRate.Text);
				if (MainForm.cMainForm.VideoGrabber1.CurrentState == VidGrab.TCurrentState.cs_Preview) 
				{
					Helpers.AddLog((MainForm.cMainForm.mmoLog), "current frame rate: " + MainForm.cMainForm.VideoGrabber1.CurrentFrameRate.ToString ("0.00") + " fps.");
				}
			}
		}

        private void btnFrameRateHelp_Click(object sender, EventArgs e)
        
        {
            MessageBox.Show("'0' means that the default frame rate of the device will be used.\n\nAfter the OnPreviewStarted or OnRecordingStarted event occurs,\nits value is available in the CurrentFrameRate property.",
                    "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
        }
        
        
        private void btnSelectFileOrUrl_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();

			edtVideoSourceFileOrUrl.Text = "";
			fd.Filter = Helpers.OPEN_MEDIA_FILES;
			if (fd.ShowDialog() == DialogResult.OK) 
				edtVideoSourceFileOrUrl.Text = fd.FileName;
		}


        private void btnStartPreview_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.StartPreview();
		}

		private void btnStopPreview_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Stop();
		}

		private void cboVideoSource_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            MainForm.cMainForm.ChangeVideoSource((TVideoSource)cboVideoSource.SelectedIndex);
        }

        private void cboAnalogVideoStandard_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AnalogVideoStandard = cboAnalogVideoStandard.SelectedIndex;
		}

		private void cboVideoDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            MainForm.cMainForm.ChangeVideoSource(TVideoSource.vs_VideoCaptureDevice);
            MainForm.cMainForm.VideoGrabber1.VideoDevice = cboVideoDevices.SelectedIndex;
			// when selecting another video device, the OnVideoDeviceSelected event occurs.
			// From this event we invoke RefreshDisplayOptions to to refresh all the device-dependent controls.
		}

		private void cboVideoInputs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoInput = cboVideoInputs.SelectedIndex;
		}

		private void cboVideoSizes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoSize = cboVideoSizes.SelectedIndex;
		}

		private void cboVideoSubtypes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoSubtype = cboVideoSubtypes.SelectedIndex;
		}

        private void cboVideoFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.VideoFormat = cboVideoFormats.SelectedIndex;
        }

        private void btnScreenRecordingWindow_Click(object sender, System.EventArgs e)
		{
            
            MainForm.cMainForm.VideoGrabber1.SetWindowRecordingByName(edtScreenRecordingWindow.Text, chkScreenRecordingWindow.Checked);  // set to "true" for an exact and case-sensitive match
            //
            // recording window may be designated by name, class or handle by calling EnumerateWindows, which
            //  causes visible window info to be returned in the OnEnumerateWindows event
            // recording window may then be set by handle rather than name with SetWindowRecordingByHandle
            //
            MainForm.cMainForm.SetEnumerateWindows(edtScreenRecordingWindow.Text, (chkScreenRecordingWindow.Checked));
            if (MainForm.cMainForm.strScreenRecordingWindow != "")
            {
                MainForm.cMainForm.VideoGrabber1.EnumerateWindows();
            }
            
		}

		private void chkScreenRecordingWithCursor_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.ScreenRecordingWithCursor = chkScreenRecordingWithCursor.Checked;
		}

		private void edtMonitorNumber_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtMonitorNumber.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.ScreenRecordingMonitor = Convert.ToInt32 (edtMonitorNumber.Text);
			}
		}

		private void btnMonitorNumberInfo_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show ("  -1 = whole desktop (across monitors)     0 = 1st monitor (default)    1 = 2nd monitor    etc...",
                "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
		}

		private void edtVideoSourceFileOrUrl_TextChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoSource_FileOrURL = edtVideoSourceFileOrUrl.Text;
		}

        private void edtSourceFileOrUrlUserName_TextChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetAuthentication (VidGrab.TAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text);
        } 

        private void edtSourceFileOrUrlPassword_TextChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetAuthentication (VidGrab.TAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text);
        }

        private void rdgPreferredVideoSize_CheckedChanged(object sender, System.EventArgs e)
		{
			int w, h;
			if ((sender as RadioButton).Checked) 
			{
				w = 0;
				h = 0;
				switch (Convert.ToInt32 ((sender as Control).Tag))
				{
					case   0: w =    0; h =    0; break;
					case   1: w =  640; h =  360; break;
					case   2: w = 1280; h =  720; break;
					case   3: w = 1920; h = 1080; break;
					default : w =   0; h =   0; break;
				}
				MainForm.cMainForm.VideoGrabber1.UseNearestVideoSize(w, h, chkStretchPreferredVideoSize.Checked); // disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
				cboVideoSizes.Enabled = true;
			}
		}

		private void btnVideoQualityDialog_Click(object sender, System.EventArgs e)
		{

            while (Application.OpenForms.OfType<miscVideoQuality>().Count() > 0)
            {
                Application.OpenForms.OfType<miscVideoQuality>().First().Close();
            }
            frmMiscVideoQuality = new miscVideoQuality();
            frmMiscVideoQuality.Show();
		}

		private void btnCameraControlDialog_Click(object sender, System.EventArgs e)
		{
            while (Application.OpenForms.OfType<miscCameraControl>().Count() > 0)
            {
                Application.OpenForms.OfType<miscCameraControl>().First().Close();
            }
            frmMiscCameraControl = new miscCameraControl();
            frmMiscCameraControl.Show();
        }

		private void VideoSource_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

        private void chkStretchPreferredVideoSize_CheckedChanged(object sender, EventArgs e)
        {
            rdgPreferredVideoSize_CheckedChanged(grbPreferredVideoSizes.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked), null);
        }

        private void chk4InputsLayout_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMultiplexedInputEmulation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grbVsVideoCaptureDevice_Enter(object sender, EventArgs e)
        {

        }

    }
}
