using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class Audio : Form
    {
		private const int VU_LEFT = 0;
		private const int VU_RIGHT = 1;

		public Audio()
		{
            //
            // Required for Windows Form Designer support
            //

            InitializeComponent();

		}
        public void RefreshDisplayOptions()
        {
            Helpers.AssignListToComboBox(cboAudioDevices, MainForm.cMainForm.VideoGrabber1.AudioDevices, MainForm.cMainForm.VideoGrabber1.AudioDevice);

            if (MainForm.cMainForm.VideoGrabber1.AudioDevice >= 0) { // if an audio capture device has been selected
                Helpers.AssignListToComboBox(cboAudioInputs, MainForm.cMainForm.VideoGrabber1.AudioInputs, MainForm.cMainForm.VideoGrabber1.AudioInput);
            }

            tbrAudioInputLevel.Value = MainForm.cMainForm.VideoGrabber1.AudioInputLevel;
            tbrAudioInputBalance.Value = MainForm.cMainForm.VideoGrabber1.AudioInputBalance;
            
			Helpers.AssignListToComboBox(cboAudioRenderers, MainForm.cMainForm.VideoGrabber1.AudioRenderers, MainForm.cMainForm.VideoGrabber1.AudioRenderer);

			chkRenderAudioDevice.Checked = MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering;
			chkMuteAudioRendering.Checked = MainForm.cMainForm.VideoGrabber1.MuteAudioRendering;

			if (MainForm.cMainForm.VideoGrabber1.AudioDevice == -1)
			{
				cboAudioDevices.Text = "SELECT AND AUDIO CAPTURE DEVICE IN THIS LIST";
			}
			if (MainForm.cMainForm.VideoGrabber1.AudioRenderer == -1) {
				cboAudioRenderers.Text = "default (AudioRenderer = -1)";
			}
		}

		private void cboAudioDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioDevice = cboAudioDevices.SelectedIndex;
		}

		private void cboAudioInputs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioInput = cboAudioInputs.SelectedIndex;
		}

		private void chkRenderAudioDevice_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering = chkRenderAudioDevice.Checked;
		}

		private void chkMuteAudioRendering_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MuteAudioRendering = chkMuteAudioRendering.Checked;
		}

		private void cboAudioRenderers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioRenderer = cboAudioRenderers.SelectedIndex;
		}

		private void tbrAudioVolume_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioVolume = tbrAudioVolume.Value;
		}

		private void tbrAudioInputLevel_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioInputLevel = tbrAudioInputLevel.Value;
		}

		private void tbrAudioInputBalance_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioInputBalance = tbrAudioInputBalance.Value;
		}

		private void tbrAudioBalance_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioBalance = tbrAudioBalance.Value;
		}

		private void rdgVUMeter_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				switch (Convert.ToInt32((sender as RadioButton).Tag))
				{
					case 0:
						MainForm.cMainForm.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled;
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, (IntPtr) 0); // VU_LEFT = 0, VU_RIGHT = 1;
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, (IntPtr) 0);
					break;
					case 1:
						MainForm.cMainForm.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Analog;
			
						pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 4) / 3;
						pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 4) / 3;
			
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr) 0); // VU_LEFT = 0, VU_RIGHT = 1
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr) 0);
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterLeft.Handle); // VU_LEFT = 0, VU_RIGHT = 1
                        MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterRight.Handle);
						break;
					case 2:
						MainForm.cMainForm.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Bargraph;
			
						pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 2) / 10;
						pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 2) / 10;
			
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr) 0x404040); // VU_LEFT = 0, VU_RIGHT = 1
						MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr) 0x404040);
                        MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterLeft.Handle); // VU_LEFT = 0, VU_RIGHT = 1
                        MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterRight.Handle);
						break;
				}
			}
		}

        private void btnBargraphOverlay_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(2, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr) 10);
            MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(3, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr) 140);
            for (uint i = 2; i <= 3; i++)
            {
                MainForm.cMainForm.VideoGrabber1.SetVuMeter_Enabled(Convert.ToInt32(i), VidGrab.TVuMeter.vu_BargraphOverlay);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_Transparent, (IntPtr) 1);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayTop, (IntPtr) 10);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayWidth, (IntPtr) 100);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayHeight, (IntPtr) 60);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr) 0x800000);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_NormalColor, (IntPtr) 0x000080);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningColor, (IntPtr) 0x00A5FF);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakColor, (IntPtr) 0x00FFFF);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningPercent, (IntPtr) 20);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakPercent, (IntPtr) 40);
            }
        }

		private void btnStartAudioRendering_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.StartAudioRendering();
			if (! MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering) {
				if (btnStartAudioRendering.Tag == null) 
				{
					btnStartAudioRendering.Tag = 1; //' to show the popup only one time
					MessageBox.Show ("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers",
                                "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
				}
            }
		}

		private void btnStartWavRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
			MainForm.cMainForm.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
			MainForm.cMainForm.VideoGrabber1.StartAudioRecording();
		}

		private void btnSartMP3Recording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
			MainForm.cMainForm.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Audio;
			MainForm.cMainForm.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
			
			MainForm.cMainForm.VideoGrabber1.AudioCompressor = MainForm.cMainForm.VideoGrabber1.FindIndexInListByName (MainForm.cMainForm.VideoGrabber1.AudioCompressors, "LAME Audio Encoder", false, true);
			if (MainForm.cMainForm.VideoGrabber1.AudioCompressor == -1) 
			{
				MessageBox.Show ("The LAME 3.99.5 DirectShow Filter is required, download it from https://www.rarewares.org/mp3-lame-dshow-acm.php and register lame.ax with regsvr32.exe",
                            "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
			}
			else {
				MainForm.cMainForm.VideoGrabber1.StartAudioRecording();
			}
		}

		private void btnStartWMVRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
			MainForm.cMainForm.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_ASF;
			MainForm.cMainForm.VideoGrabber1.StartAudioRecording();
		}

		private void btnStopAudio_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Stop();
		}

		private void chkUseAudioOfVideoCaptureDevice_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkUseAudioOfVideoCaptureDevice.Checked)
			{
				MainForm.cMainForm.VideoGrabber1.VideoDevice = 0; // in this demo, by default we choose the 1st
			}
			else {
				MainForm.cMainForm.VideoGrabber1.VideoDevice = -1; // this deactivates the video capture device
			}
		}

		private void Audio_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

        private void btnAudioDeviceDialog_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_AudioDevice);
        }

        private void rdgAudioSourceDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceDefault.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default;
            }
        }

        private void rdgAudioSourceExternal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceExternal.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_UseExternalAudio;
            }
        }

        private void rdgAudioSourceSpeakerOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceSpeakerOutput.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_SpeakerOutput;
            }
        }

        private void rdgAudioSourceDefaultSpeakerRecording_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceDefaultSpeakerRecording.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_DefaultWithSpeakerRecording;
            }
        }

	}
}
