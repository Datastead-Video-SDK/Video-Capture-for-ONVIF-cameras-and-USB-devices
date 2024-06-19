using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MainDemo
{
	public partial class Player : Form
    {

		public Player()
		{
			InitializeComponent();
		}


		private void Player_Load(object sender, System.EventArgs e)
		{
		
		}

		public void RefreshDisplayOptions()
		{
			updPlayerSpeedRatio.Value = (decimal) MainForm.cMainForm.VideoGrabber1.PlayerSpeedRatio * 10;
			updPlayerFastSeekSpeed.Value = MainForm.cMainForm.VideoGrabber1.PlayerFastSeekSpeedRatio;
			btnAutoPlay.Checked = MainForm.cMainForm.VideoGrabber1.AutoStartPlayer;
			chkPlayerAudioRendering.Checked = MainForm.cMainForm.VideoGrabber1.PlayerAudioRendering;
			chkUseClock.Checked = MainForm.cMainForm.VideoGrabber1.UseClock;
			chkRefreshPausedDisplay.Checked = MainForm.cMainForm.VideoGrabber1.PlayerRefreshPausedDisplay;
		}

		private void btnAutoPlay_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AutoStartPlayer = btnAutoPlay.Checked;
		}

        private void chk360VideoDecoding_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.v360_Enabled = chk360VideoDecoding.Checked;
        }

		private void btnChooseClip_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlgOpen = new OpenFileDialog();

			dlgOpen.Filter = Helpers.OPEN_MEDIA_FILES;
			if (dlgOpen.ShowDialog() == DialogResult.OK) 
			{
				edtPlayerFileName.Text = dlgOpen.FileName;
			}
		}

		private void btnClipDuration_Click(object sender, System.EventArgs e)
		{
			Int64 AVIDuration;
			Int64 AVIFrameCount;

			if (MainForm.cMainForm.VideoGrabber1.AVIDuration(edtPlayerFileName.Text,out AVIDuration,out AVIFrameCount)) 
			{
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "Duration: " + AVIDuration.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "Frame count: " + AVIFrameCount.ToString());
			}
			else 
			{
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "failed to get AVIDuration information");
			}
		}

        private void rdgHwAccel_none_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_none.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            }
        }

        private void rdgHwAccel_CUDA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_CUDA.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_Cuda;
            }
        }

        private void rdgHwAccel_QuickSync_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_QuickSync.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_QuickSync;
            }
        }

        private void rdgHwAccel_DXVA2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_DXVA2.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_Dxva2;
            }
        }

        private void rdgHwAccel_d3d11_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_d3d11.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_d3d11;
            }
        }

		private void btnClipGeneralInfo_Click(object sender, System.EventArgs e)
		{
			Int64 AVIDuration;
			Int64 AVIFrameCount;
			int VideoWidth;
			int VideoHeight;
			string VideoCodec;
			string AudioCodec;
			double VideoFrameRateFps;
			int AvgBitRate;
			int AudioChannels;
			int AudioSamplesPerSec;
			int AudioBitsPerSample;

			if (MainForm.cMainForm.VideoGrabber1.AVIInfo(edtPlayerFileName.Text, out AVIDuration, out AVIFrameCount, out VideoWidth, out VideoHeight, out VideoFrameRateFps, out AvgBitRate, out AudioChannels, out AudioSamplesPerSec, out AudioBitsPerSample, out VideoCodec, out AudioCodec))
			{
				double AvgBitRateDiv1024 = AvgBitRate / 1024;
			
				Helpers.AddLog(MainForm.cMainForm.mmoLog, edtPlayerFileName.Text + ":");
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "duration (in sec): " + AVIDuration.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "frame count: " + AVIFrameCount.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "video width: " + VideoWidth.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "video height: " + VideoHeight.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "video frame rate (fps): " + VideoFrameRateFps.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "average bit rate (kb/s): " + AvgBitRateDiv1024.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "audio channels: " + AudioChannels.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "audio samples/sec: " + AudioSamplesPerSec.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "audio bits per sample: " + AudioBitsPerSample.ToString());
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "video codec: " + VideoCodec);
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "audio codec: " + AudioCodec);
			}
			else
			{
				Helpers.AddLog(MainForm.cMainForm.mmoLog, "clip ! found.");
			}
		}

		private void btnOpenLastClipPlayed_Click(object sender, System.EventArgs e)
		{
			if (MainForm.cMainForm.VideoGrabber1.Last_Clip_Played != "") 
			{
				edtPlayerFileName.Text = MainForm.cMainForm.VideoGrabber1.Last_Clip_Played;
				MainForm.cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
				MainForm.cMainForm.VideoGrabber1.OpenPlayer();
			}
		}

		private void btnOpenLastClipRecorded_Click(object sender, System.EventArgs e)
		{
			if (MainForm.cMainForm.VideoGrabber1.Last_Recording_FileName != "") {
				edtPlayerFileName.Text = MainForm.cMainForm.VideoGrabber1.Last_Recording_FileName;
				MainForm.cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
				MainForm.cMainForm.VideoGrabber1.OpenPlayer();
			}
		}

		private void btnPlayerCloseFile_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.ClosePlayer();
		}

		private void btnPlayerOpenFile_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			MainForm.cMainForm.VideoGrabber1.OpenPlayer();
		}

		private void btnPlayerOpenStreamingURL_Click(object sender, System.EventArgs e)
		{
			edtPlayerFileName.Text = "mms://www.datastead.com/demo/demo.wmv";
			MainForm.cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			MainForm.cMainForm.VideoGrabber1.OpenPlayer();
		}

		private void chkPlayerAudioRendering_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerAudioRendering = chkPlayerAudioRendering.Checked;
		}

		private void chkRefreshPausedDisplay_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerRefreshPausedDisplay = chkRefreshPausedDisplay.Checked;
		}

		private void updPlayerSpeedRatio_ValueChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerSpeedRatio = ((double) updPlayerSpeedRatio.Value) / 10;
            updSpeedRadioValue.Text = MainForm.cMainForm.VideoGrabber1.PlayerSpeedRatio.ToString("0.0");
		}

		private void updPlayerFastSeekSpeed_ValueChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerFastSeekSpeedRatio = (int) updPlayerFastSeekSpeed.Value;
		}

		private void btnHeaderInfo_Click(object sender, System.EventArgs e)
		{
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "");
			Helpers.AddLog(MainForm.cMainForm.mmoLog, edtPlayerFileName.Text + " headers:");
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Title: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Title));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Description: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Description));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Author: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Author));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Copyright: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Copyright));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Album Artist: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumArtist));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Album Title: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumTitle));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Composer: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Composer));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Content Distributor: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ContentDistributor));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Director: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Director));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Encoding Time: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_EncodingTime));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Genre: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Genre));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Language: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Language));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Parental Rating: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ParentalRating));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Producer: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Producer));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Provider: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Provider));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "ToolName: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolName));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Tool Version: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolVersion));
			Helpers.AddLog(MainForm.cMainForm.mmoLog, "Writer: " + MainForm.cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Writer));

		}

		private void chkUseClock_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.UseClock = chkUseClock.Checked;
		}

        private void chkLoop_CheckedChanged(object sender, System.EventArgs e)
        {
            // the code is in the VideoGrabber1_OnPlayerEndOfStream event of MainForm
        }

		private void btnPlaylistAdd_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			int i;

			fd.Filter = Helpers.OPEN_MEDIA_FILES_EXTENDED;
			fd.Multiselect = true;
			if (fd.ShowDialog() == DialogResult.OK) 
			{
				for (i = 0; i < fd.FileNames.Length; i ++) 
				{
					MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Add, fd.FileNames.GetValue(i).ToString());
					lstPlaylist.Items.Add(fd.FileNames.GetValue(i));
				}
			}
		}

		private void btnPlaylistPlay_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Play, "");
		}

		private void btnPlaylistNext_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Next, "");
		}

		private void btnPlaylistPrevious_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Previous, "");
		}

		private void btnPlaylistStopAfterCurrent_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Stop, "");
		}

		private void btnPlaylistClose_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.ClosePlayer();
		}

		private void chkPlaylistLoop_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkPlaylistLoop.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Loop, "");
			}
			else 
			{
				MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_NoLoop, "");
			}
		}

		private void chkPlaylistRandom_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkPlaylistRandom.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Random, "");
			}
			else 
			{
				MainForm.cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Sequential, "");
			}
		}

		private void btnOpenAtFrames_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			if (Helpers.IsNumeric(txtStartFrame.Text) && Helpers.IsNumeric(txtStopFrame.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.OpenPlayerAtFramePositions (Convert.ToInt64 (txtStartFrame.Text), Convert.ToInt64 (txtStopFrame.Text), chkKeepBounds.Checked, chkReopen.Checked);
			}
		}

		private void btnOpenAtTimes_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			if (Helpers.IsNumeric(txtStartTime.Text) && Helpers.IsNumeric(txtStopTime.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.OpenPlayerAtTimePositions (Convert.ToInt64 (txtStartTime.Text), Convert.ToInt64 (txtStopTime.Text), chkKeepBounds.Checked, chkReopen.Checked);
			}
		}

		private void Player_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}



	}
}
