using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class Recording : Form
    {
		public Recording()
		{
			InitializeComponent();
		}

		public void RefreshDisplayOptions()
		{
			Helpers.SetRadioButtonInGroupUsingTag((rdgRecordingMethod), (short) MainForm.cMainForm.VideoGrabber1.RecordingMethod);
			Helpers.SetRadioButtonInGroupUsingTag((rdgCompressMode), (short) MainForm.cMainForm.VideoGrabber1.CompressionMode);
			Helpers.SetRadioButtonInGroupUsingTag((rdgCompressType), (short) MainForm.cMainForm.VideoGrabber1.CompressionType);
            Helpers.SetRadioButtonInGroupUsingTag((rdgRecordingTimer), (short)MainForm.cMainForm.VideoGrabber1.RecordingTimer);

			chkRecordingCanPause.Checked = MainForm.cMainForm.VideoGrabber1.RecordingCanPause;
			chkPauseCreatesNewFile.Checked = MainForm.cMainForm.VideoGrabber1.RecordingPauseCreatesNewFile;
			chkRecordingOnMotion.Checked = MainForm.cMainForm.VideoGrabber1.RecordingOnMotion_Enabled;

			chkPreserveNativeFormat.Checked = MainForm.cMainForm.VideoGrabber1.RecordingInNativeFormat;

			chkAudioRecording.Checked = MainForm.cMainForm.VideoGrabber1.AudioRecording;

			Helpers.AssignListToComboBox((cboVideoCompressors), MainForm.cMainForm.VideoGrabber1.VideoCompressors, MainForm.cMainForm.VideoGrabber1.VideoCompressor);
			Helpers.AssignListToComboBox((cboAudioCompressors), MainForm.cMainForm.VideoGrabber1.AudioCompressors, MainForm.cMainForm.VideoGrabber1.AudioCompressor);

            btnPauseRecording.Enabled = MainForm.cMainForm.VideoGrabber1.RecordingCanPause;
			btnResumeRecording.Enabled = MainForm.cMainForm.VideoGrabber1.RecordingCanPause;

			rdgCompressMode.Enabled = true;
			rdgCompressType.Enabled = true;

            chkScreenRecordWindow.Enabled = ((MainForm.cMainForm.VideoGrabber1.VideoSource == VidGrab.TVideoSource.vs_ScreenRecording) ? true : false);

			if (! MainForm.cMainForm.VideoGrabber1.AudioRecording) 
			{
				rdgCompressType.Enabled = false;
			}
			
        }

        private void btnVideoCompressorSettings_Click(object sender, System.EventArgs e)
        {
            if (MainForm.cMainForm.VideoGrabber1.VideoCompressor == 0)  // index 0 is  the Datastead Multipurpose Encoder, the settings can be set with Encoder_SetInt and Encoder_SetStr
            {
                MainForm.cMainForm.tbcTabs.SelectedTab = MainForm.cMainForm.tbpMultipurposeEncoder;
                MainForm.cMainForm.SelectInsetForm(MainForm.cMainForm.tbcTabs);
            }
            else
            {
                MainForm.cMainForm.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_VideoCompressor);
            }
        }

        private void btnAudioCompressorSettings_Click(object sender, System.EventArgs e)
        {
            if (MainForm.cMainForm.VideoGrabber1.AudioCompressor == 0)  // index 0 is  the Datastead Multipurpose Encoder, the settings can be set with Encoder_SetInt and Encoder_SetStr
            {
                MainForm.cMainForm.tbcTabs.SelectedTab = MainForm.cMainForm.tbpMultipurposeEncoder;
                MainForm.cMainForm.SelectInsetForm(MainForm.cMainForm.tbcTabs);
            }
            else
            {
                MainForm.cMainForm.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_AudioCompressor);
            }
        }

        private void btnCodecExamples_Click(object sender, EventArgs e)
        {
            Helpers.ShellExecute((System.IntPtr)0, "open", "https://www.datastead.com/faq/how-can-the-tvideograbber-sdk-record-in-mp4-through-the-multipurpose-encoder/", "", "", Helpers.ShowCommands.SW_SHOWNORMAL);
        }

		private void btnPauseRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PauseRecording();
		}

		private void btnRenewRecordingFile_Click(object sender, System.EventArgs e)
		{
			if (chkAVISaveToThisFile.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingFileName = edtRecordingFileName.Text;
			}
			else 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingFileName = "";
			}
			MainForm.cMainForm.VideoGrabber1.RecordToNewFileNow("", true);
		}

		private void btnResumeRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.ResumeRecording();
		}

		private void btnStartRecordingControlled_Click(object sender, System.EventArgs e)
		{
			if (chkAVISaveToThisFile.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingFileName = edtRecordingFileName.Text;
			} 
			else 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingFileName = "";
			}

			MainForm.cMainForm.VideoGrabber1.HoldRecording = true;
			MainForm.cMainForm.VideoGrabber1.StartRecording();

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired

            if ((MainForm.cMainForm.VideoGrabber1.RecordingTimer == VidGrab.TRecordingTimer.rt_StartRecording) & (MainForm.cMainForm.VideoGrabber1.VideoSource == VidGrab.TVideoSource.vs_ScreenRecording) & (chkScreenRecordWindow.Checked == true) & (MainForm.cMainForm.lngScreenRecordingWindow > 0))
            {
                // for screen recording of a window, this code will make it the top window before recording start;
                //  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                // (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                Helpers.MakeTopWindow (MainForm.cMainForm.wenScreenRecordingWindow[MainForm.cMainForm.lngScreenRecordingWindow - 1].WindowHandle);
            }
        }

        private void rdgRecordingTimer1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
        }

        private void rdgRecordingTimer2_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_RecordToNewFile;
        }

        private void rdgRecordingTimer3_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_StopRecording;
        }

        private void rdgRecordingTimer4_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_StartRecording;
        }

        private void edtRecordingTimer_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(edtRecordingTimer.Text) > 0)
            {
                MainForm.cMainForm.VideoGrabber1.RecordingTimerInterval = Convert.ToInt32(edtRecordingTimer.Text);
            }
            else
            {
                MainForm.cMainForm.VideoGrabber1.RecordingTimerInterval = 0;
            }
        }

        private void chkScreenRecordWindow_CheckedChanged(object sender, EventArgs e)
        {
            // for source = screen demonstration purposes, if:
            // - VideoSource = vs_ScreenRecording
            // - source window handle is identified with VideoSource form btnScreenRecordingWindow
            //   via EnumerateWindows and OnEnumerateWindows event (SetEnumerateWindows demo procedure)
            // - chkScreenRecordWindow is enabled
            // source window will be made top window at recording start (using API SetWindowPos),
            //  see Recording form btnStartRecordingImmediately and btnStartRecordingControlled,
            //  and events OnEnumerateWindows, OnRecordingReadyToStart
        }
        
        private void btnStartRecordingImmediately_Click(object sender, System.EventArgs e)
		{
			if (chkAVISaveToThisFile.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingFileName = edtRecordingFileName.Text;
			} 
			else 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingFileName = "";
			}
			MainForm.cMainForm.VideoGrabber1.HoldRecording = false; // let's start recording as soon as the graph is built.

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired

            if ((MainForm.cMainForm.VideoGrabber1.RecordingTimer == VidGrab.TRecordingTimer.rt_StartRecording) & (MainForm.cMainForm.VideoGrabber1.VideoSource == VidGrab.TVideoSource.vs_ScreenRecording) & (chkScreenRecordWindow.Checked == true) & (MainForm.cMainForm.lngScreenRecordingWindow > 0))
            {
                // for screen recording of a window, this code will make it the top window before recording start;
                //  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                // (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                Helpers.MakeTopWindow(MainForm.cMainForm.wenScreenRecordingWindow[MainForm.cMainForm.lngScreenRecordingWindow - 1].WindowHandle);
            }
            MainForm.cMainForm.VideoGrabber1.StartRecording();
		}

		private void btnStopRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Stop();
		}

		private void cboAudioCompressors_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioCompressor = cboAudioCompressors.SelectedIndex;
		}

		private void cboVideoCompressors_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoCompressor = cboVideoCompressors.SelectedIndex;
		}

		private void chkAudioRecording_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioRecording = chkAudioRecording.Checked;
			RefreshDisplayOptions();
		}

		private void chkPreserveNativeFormat_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.RecordingInNativeFormat = chkPreserveNativeFormat.Checked;
		}

		private void chkRecordingCanPause_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.RecordingCanPause = chkRecordingCanPause.Checked;
			RefreshDisplayOptions();
		}

		private void chkPauseCreatesNewFile_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.RecordingPauseCreatesNewFile = chkPauseCreatesNewFile.Checked;
		}

		private void chkRecordingOnMotion_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.RecordingOnMotion_Enabled = chkRecordingOnMotion.Checked;
			chkRecordingCanPause.Checked = chkRecordingOnMotion.Checked;
		}

		private void rdgCompressMode_CheckedChanged (object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.CompressionMode = (VidGrab.TCompressionMode) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void rdgCompressType_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.CompressionType = (VidGrab.TCompressionType) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void rdgRecordingMethod_CheckedChanged(object sender, System.EventArgs e)
		{
		if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.RecordingMethod = (VidGrab.TRecordingMethod) Convert.ToInt32 ((sender as Control).Tag);
                RefreshDisplayOptions();
			}
		}

		private void Recording_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

    }
}
