#define VS2003
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class FrameGrabber : Form
    {
		public FrameGrabber()
		{
			InitializeComponent();

		}

		public void RefreshDisplayOptions()
		{
			Helpers.SetRadioButtonInGroupUsingTag(rgdFrameGrabber, (short) MainForm.cMainForm.VideoGrabber1.FrameGrabber);
			Helpers.SetRadioButtonInGroupUsingTag(rgdFrameGrabberFormat, (short) MainForm.cMainForm.VideoGrabber1.FrameGrabberRGBFormat);
			Helpers.SetRadioButtonInGroupUsingTag(rdgAutoFileName, (short) MainForm.cMainForm.VideoGrabber1.AutoFileName);

			edtAVIAutoFilePrefix.Text = MainForm.cMainForm.VideoGrabber1.AutoFilePrefix;

			edtBurstCount.Text = MainForm.cMainForm.VideoGrabber1.BurstCount.ToString();
			edtBurstInterval.Text = MainForm.cMainForm.VideoGrabber1.BurstInterval.ToString();
			tbrCaptureZoomSize.Value = MainForm.cMainForm.VideoGrabber1.FrameCaptureZoomSize;
			edtFrameCaptureWidth.Text = MainForm.cMainForm.VideoGrabber1.FrameCaptureWidth.ToString();
			edtFrameCaptureHeight.Text = MainForm.cMainForm.VideoGrabber1.FrameCaptureHeight.ToString();
		}

		private void btnBurstModeBMPFile_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_BmpFile;
			MainForm.cMainForm.VideoGrabber1.BurstMode = true;
			// The frame capture starts when BurstMode is set to true.;
			// if (BurstCount = 0 the frame capture won"t stop.;
			// BMP file names will be generated automatically according to AutoFileName;
			// and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.;
		}

		private void btnBurstModeJPEGFile_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_JpegFile;
			MainForm.cMainForm.VideoGrabber1.BurstMode = true;
			// The frame capture starts when BurstMode is set to true.;
			// if (BurstCount = 0 the frame capture won"t stop.;
			// JPEG file names will be generated automatically according to AutoFileName;
			// and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.;
		}

		private void btnBurstModeClipboard_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_Clipboard;
			MainForm.cMainForm.VideoGrabber1.BurstMode = true;
			// The frame capture starts when BurstMode is set to true.;
			// if (BurstCount = 0 the frame capture won"t stop.;
			// Captured frames will be returned by the OnFrameCaptureCompleted event.;
		}

		private void btnBurstModeStop_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.BurstMode = false;
		}

		private void btnBurstModeTBitmap_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
			MainForm.cMainForm.VideoGrabber1.BurstMode = true;
			// The frame capture starts when BurstMode is set to true.;
			// if (BurstCount = 0 the frame capture won"t stop.;
			// Captured frames will be returned by the OnFrameCaptureCompleted event.;
		}

		private void btnOneShotJPEGFile_Click(object sender, System.EventArgs e)
		{
			if (chkUseThisFileName.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, edtUseThisFileName.Text);
			}
			else {
				MainForm.cMainForm.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, "");
			}
			// note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory;
			// note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success;
		}

		private void btnOneShotBMPFile_Click(object sender, System.EventArgs e)
		{
			if (chkUseThisFileName.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_BmpFile, edtUseThisFileName.Text);
			}
			else 
			{
				MainForm.cMainForm.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_BmpFile, "");
			}
			// note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory;
			// note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success;
		}

		private void btnOneShotClipboard_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_Clipboard, "");
		}

		private void btnOneShotTBitmap_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_TBitmap, "");
		}

		private void chkUseThisFileName_CheckedChanged(object sender, System.EventArgs e)
		{
			edtUseThisFileName.Enabled = chkUseThisFileName.Checked;
		}

		private void edtAVIAutoFilePrefix_TextChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AutoFilePrefix = edtAVIAutoFilePrefix.Text;
		}

		private void edtBurstCount_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtBurstCount.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.BurstCount = Convert.ToInt32 (edtBurstCount.Text);
			};
		}

		private void edtBurstInterval_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtBurstInterval.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.BurstInterval = Convert.ToInt32 (edtBurstInterval.Text);
			};
		}

		private void rdgAutoFileName1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (rdgAutoFileName1.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
			};
		}

		private void rdgAutoFileName2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (rdgAutoFileName2.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_DateTime;
			};
		}

		private void btnResetCaptureZoomSize_Click(object sender, System.EventArgs e)
		{
			tbrCaptureZoomSize.Value = 100;
            MainForm.cMainForm.VideoGrabber1.FrameCaptureZoomSize = tbrCaptureZoomSize.Value;
            edtCaptureZoomSize.Text = tbrCaptureZoomSize.Value.ToString() + "%";
            tbrCaptureZoomSize.Refresh();
		}

		private void tbrCaptureZoomSize_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.FrameCaptureZoomSize = tbrCaptureZoomSize.Value;
			edtCaptureZoomSize.Text = tbrCaptureZoomSize.Value.ToString () + "%";
		}

		private void edtFrameCaptureWidth_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtFrameCaptureWidth.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.FrameCaptureWidth = Convert.ToInt32 (edtFrameCaptureWidth.Text);
			}
		}

		private void edtFrameCaptureHeight_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtFrameCaptureHeight.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.FrameCaptureHeight = Convert.ToInt32 (edtFrameCaptureHeight.Text);
			}
		}

		private void rgdFrameGrabber_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.FrameGrabber = (VidGrab.TFrameGrabber) Convert.ToInt32 ((sender as Control).Tag);
				RefreshDisplayOptions();
			}
		
		}

		private void rgdFrameGrabberFormat_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.FrameGrabberRGBFormat = (VidGrab.TFrameGrabberRGBFormat) Convert.ToInt32 ((sender as Control).Tag);
			}
		
		}

		private void FrameGrabber_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

        private void rdgAutoFileName3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAutoFileName3.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Counter;
            };

        }

	}
}
