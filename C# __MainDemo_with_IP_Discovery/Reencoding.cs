using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class Reencoding : Form
    {
        

		public Reencoding()
		{
			InitializeComponent();
		}

		public void RefreshDisplayOptions()
		{
			Helpers.SetRadioButtonInGroupUsingTag((rdgReencodingMethod), (short) MainForm.cMainForm.VideoGrabber1.Reencoding_Method);
			chkWMVOutput.Checked = MainForm.cMainForm.VideoGrabber1.Reencoding_WMVOutput;
			chkIncludeVideoStream.Checked = MainForm.cMainForm.VideoGrabber1.Reencoding_IncludeVideoStream;
			chkIncludeAudioStream.Checked = MainForm.cMainForm.VideoGrabber1.Reencoding_IncludeAudioStream;
			chkUseFrameGrabber.Checked = MainForm.cMainForm.VideoGrabber1.Reencoding_UseFrameGrabber;
			chkUseCurrentVideoCompressor.Checked = MainForm.cMainForm.VideoGrabber1.Reencoding_UseVideoCompressor;
			chkUseCurrentAudioCompressor.Checked = MainForm.cMainForm.VideoGrabber1.Reencoding_UseAudioCompressor;
			edtStartTime.Text = MainForm.cMainForm.VideoGrabber1.Reencoding_StartTime.ToString();
			edtStopTime.Text = MainForm.cMainForm.VideoGrabber1.Reencoding_StopTime.ToString();
		}

		private void btnDuration_Click(object sender, System.EventArgs e)
		{
			Int64 AVIDuration;
			Int64 AVIFrameCount;

			if (MainForm.cMainForm.VideoGrabber1.AVIDuration(edtSourceVideoClip.Text,out AVIDuration,out AVIFrameCount)) 
			{
				edtDuration.Text = AVIDuration.ToString();
				edtFrameCount.Text = AVIFrameCount.ToString();
			}
		}

		private void btnSourceVideoClip_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();

			edtSourceVideoClip.Text = "";
			fd.Filter = Helpers.OPEN_MEDIA_FILES;
			if (fd.ShowDialog() == DialogResult.OK) 
			{
				edtSourceVideoClip.Text = fd.FileName;
			}
		}

		private void btnStartReencoding_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Reencoding_SourceVideoClip = edtSourceVideoClip.Text;
			MainForm.cMainForm.VideoGrabber1.Reencoding_NewVideoClip = edtDestinationVideoClip.Text;

			MainForm.cMainForm.VideoGrabber1.Reencoding_WMVOutput = chkWMVOutput.Checked;
			MainForm.cMainForm.VideoGrabber1.Reencoding_IncludeVideoStream = chkIncludeVideoStream.Checked;
			MainForm.cMainForm.VideoGrabber1.Reencoding_IncludeAudioStream = chkIncludeAudioStream.Checked;
			MainForm.cMainForm.VideoGrabber1.Reencoding_UseFrameGrabber = chkUseFrameGrabber.Checked;
			MainForm.cMainForm.VideoGrabber1.Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor.Checked;
			MainForm.cMainForm.VideoGrabber1.Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor.Checked;

			if (rdgReencodingMethod1.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_AVI;
			}

			if (rdgReencodingMethod2.Checked) 
			{
				;
				MainForm.cMainForm.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
			};

			if (Helpers.IsNumeric(edtStartTime.Text)) 
			{
				;
				MainForm.cMainForm.VideoGrabber1.Reencoding_StartTime = Convert.ToInt64 (edtStartTime.Text);
			};

			if (Helpers.IsNumeric(edtStopTime.Text)) 
			{
				;
				MainForm.cMainForm.VideoGrabber1.Reencoding_StopTime = Convert.ToInt64 (edtStopTime.Text);
			};

			if (Helpers.IsNumeric(edtStartFrame.Text)) 
			{
				;
				MainForm.cMainForm.VideoGrabber1.Reencoding_StartFrame = Convert.ToInt64 (edtStartFrame.Text);
			};

			if (Helpers.IsNumeric(edtStopFrame.Text)) 
			{
				;
				MainForm.cMainForm.VideoGrabber1.Reencoding_StopFrame = Convert.ToInt64 (edtStopFrame.Text);
			};

			MainForm.cMainForm.VideoGrabber1.StartReencoding();
		}

		private void btnStopReencoding_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Stop();
		}

		private void Reencoding_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}
	}
}
