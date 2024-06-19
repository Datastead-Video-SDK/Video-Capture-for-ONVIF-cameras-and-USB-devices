using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using VidGrabWPF;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public Player(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        public void RefreshDisplayOptions()
        {
            updPlayerSpeedRatio.Value = (double) VideoGrabber.PlayerSpeedRatio * 10.0;
            updPlayerSpeedRatioText.Text = VideoGrabber.PlayerSpeedRatio.ToString("0.0");
            updPlayerFastSeekSpeed.Value = VideoGrabber.PlayerFastSeekSpeedRatio;
            btnAutoPlay.IsChecked = VideoGrabber.AutoStartPlayer;
            chkPlayerAudioRendering.IsChecked = VideoGrabber.PlayerAudioRendering;
            chkUseClock.IsChecked = VideoGrabber.UseClock;
            chkRefreshPausedDisplay.IsChecked = VideoGrabber.PlayerRefreshPausedDisplay;
        }

        private void btnAutoPlay_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AutoStartPlayer = btnAutoPlay.IsChecked == true;
        }

        private void btnChooseClip_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();

            dlgOpen.Filter = Helpers.OPEN_MEDIA_FILES;
            if (dlgOpen.ShowDialog() == true)
            {
                edtPlayerFileName.Text = dlgOpen.FileName;
            }
        }

        private void btnClipDuration_Click(object sender, RoutedEventArgs e)
        {
            Int64 AVIDuration;
            Int64 AVIFrameCount;

            if (VideoGrabber.AVIDuration(edtPlayerFileName.Text, out AVIDuration, out AVIFrameCount))
            {
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Duration: " + AVIDuration.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Frame count: " + AVIFrameCount.ToString());
            }
            else
            {
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "failed to get AVIDuration information");
            }
        }

        private void rdgHwAccel_none_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_none.IsChecked == true)
            {
                VideoGrabber.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            }
        }

        private void rdgHwAccel_CUDA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_CUDA.IsChecked == true)
            {
                VideoGrabber.PlayerHwAccel = VidGrab.THwAccel.hw_Cuda;
            }
        }

        private void rdgHwAccel_QuickSync_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_QuickSync.IsChecked == true)
            {
                VideoGrabber.PlayerHwAccel = VidGrab.THwAccel.hw_QuickSync;
            }
        }

        private void rdgHwAccel_DXVA2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_DXVA2.IsChecked == true)
            {
                VideoGrabber.PlayerHwAccel = VidGrab.THwAccel.hw_Dxva2;
            }
        }

        private void rdgHwAccel_d3d11_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgHwAccel_d3d11.IsChecked == true)
            {
                VideoGrabber.PlayerHwAccel = VidGrab.THwAccel.hw_d3d11;
            }
        }

        private void btnClipGeneralInfo_Click(object sender, RoutedEventArgs e)
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

            if (VideoGrabber.AVIInfo(edtPlayerFileName.Text, out AVIDuration, out AVIFrameCount, out VideoWidth, out VideoHeight, out VideoFrameRateFps, out AvgBitRate, out AudioChannels, out AudioSamplesPerSec, out AudioBitsPerSample, out VideoCodec, out AudioCodec))
            {
                double AvgBitRateDiv1024 = AvgBitRate / 1024;

                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, edtPlayerFileName.Text + ":");
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "duration (in sec): " + AVIDuration.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "frame count: " + AVIFrameCount.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "video width: " + VideoWidth.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "video height: " + VideoHeight.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "video frame rate (fps): " + VideoFrameRateFps.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "average bit rate (kb/s): " + AvgBitRateDiv1024.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "audio channels: " + AudioChannels.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "audio samples/sec: " + AudioSamplesPerSec.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "audio bits per sample: " + AudioBitsPerSample.ToString());
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "video codec: " + VideoCodec);
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "audio codec: " + AudioCodec);
            }
            else
            {
                Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "clip ! found.");
            }
        }

        private void btnOpenLastClipPlayed_Click(object sender, RoutedEventArgs e)
        {
            if (VideoGrabber.Last_Clip_Played != "")
            {
                edtPlayerFileName.Text = VideoGrabber.Last_Clip_Played;
                VideoGrabber.PlayerFileName = edtPlayerFileName.Text;
                VideoGrabber.OpenPlayer();
            }
        }

        private void btnOpenLastClipRecorded_Click(object sender, RoutedEventArgs e)
        {
            if (VideoGrabber.Last_Recording_FileName != "")
            {
                edtPlayerFileName.Text = VideoGrabber.Last_Recording_FileName;
                VideoGrabber.PlayerFileName = edtPlayerFileName.Text;
                VideoGrabber.OpenPlayer();
            }
        }

        private void btnPlayerCloseFile_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ClosePlayer();
        }

        private void btnPlayerOpenFile_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.PlayerFileName = edtPlayerFileName.Text;
            VideoGrabber.OpenPlayer();
        }

        private void btnPlayerOpenStreamingURL_Click(object sender, RoutedEventArgs e)
        {
            edtPlayerFileName.Text = "mms://www.datastead.com/demo/demo.wmv";
            VideoGrabber.PlayerFileName = edtPlayerFileName.Text;
            VideoGrabber.OpenPlayer();
        }

        private void chkPlayerAudioRendering_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.PlayerAudioRendering = chkPlayerAudioRendering.IsChecked == true;
        }

        private void chkRefreshPausedDisplay_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.PlayerRefreshPausedDisplay = chkRefreshPausedDisplay.IsChecked == true;
        }

        private void btnHeaderInfo_Click(object sender, RoutedEventArgs e)
        {
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "");
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, edtPlayerFileName.Text + " headers:");
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Title: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Title));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Description: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Description));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Author: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Author));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Copyright: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Copyright));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Album Artist: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumArtist));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Album Title: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumTitle));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Composer: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Composer));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Content Distributor: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ContentDistributor));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Director: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Director));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Encoding Time: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_EncodingTime));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Genre: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Genre));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Language: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Language));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Parental Rating: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ParentalRating));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Producer: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Producer));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Provider: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Provider));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "ToolName: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolName));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Tool Version: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolVersion));
            Helpers.AddLog(MainDemoWPF.MainForm.MainFormInstance.mmoLog, "Writer: " + VideoGrabber.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Writer));

        }

        private void chkUseClock_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.UseClock = chkUseClock.IsChecked == true;
        }

        private void chkLoop_CheckedChanged(object sender, RoutedEventArgs e)
        {
            // the code is in the VideoGrabber1_OnPlayerEndOfStream event of MainForm
        }

        private void btnPlaylistAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            int i;

            fd.Filter = Helpers.OPEN_MEDIA_FILES_EXTENDED;
            fd.Multiselect = true;
            if (fd.ShowDialog() == true)
            {
                for (i = 0; i < fd.FileNames.Length; i++)
                {
                    VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Add, fd.FileNames.GetValue(i).ToString());
                    lstPlaylist.Items.Add(fd.FileNames.GetValue(i));
                }
            }
        }

        private void btnPlaylistPlay_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Play, "");
        }

        private void btnPlaylistNext_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Next, "");
        }

        private void btnPlaylistPrevious_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Previous, "");
        }

        private void btnPlaylistStopAfterCurrent_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Stop, "");
        }

        private void btnPlaylistClose_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ClosePlayer();
        }

        private void chkPlaylistLoop_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkPlaylistLoop.IsChecked == true)
            {
                VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Loop, "");
            }
            else
            {
                VideoGrabber.Playlist(VidGrab.TPlaylist.pl_NoLoop, "");
            }
        }

        private void chkPlaylistRandom_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkPlaylistRandom.IsChecked == true)
            {
                VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Random, "");
            }
            else
            {
                VideoGrabber.Playlist(VidGrab.TPlaylist.pl_Sequential, "");
            }
        }

        private void btnOpenAtFrames_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.PlayerFileName = edtPlayerFileName.Text;
            if (Helpers.IsNumeric(txtStartFrame.Text) && Helpers.IsNumeric(txtStopFrame.Text))
            {
                VideoGrabber.OpenPlayerAtFramePositions(Convert.ToInt64(txtStartFrame.Text), Convert.ToInt64(txtStopFrame.Text), chkKeepBounds.IsChecked == true, chkReopen.IsChecked == true);
            }
        }

        private void btnOpenAtTimes_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.PlayerFileName = edtPlayerFileName.Text;
            if (Helpers.IsNumeric(txtStartTime.Text) && Helpers.IsNumeric(txtStopTime.Text))
            {
                VideoGrabber.OpenPlayerAtTimePositions(Convert.ToInt64(txtStartTime.Text), Convert.ToInt64(txtStopTime.Text), chkKeepBounds.IsChecked == true, chkReopen.IsChecked == true);
            }
        }

        private void Player_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

       private void updPlayerSpeedRatio_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.PlayerSpeedRatio = ((double)updPlayerSpeedRatio.Value) / 10;
            if (updPlayerSpeedRatioText != null) updPlayerSpeedRatioText.Text = VideoGrabber.PlayerSpeedRatio.ToString("0.0");
        }

        private void updPlayerSpeedRatioText_TextChanged(object sender, TextChangedEventArgs e)
        {
            VideoGrabber.PlayerSpeedRatio = Convert.ToDouble (updPlayerSpeedRatioText.Text);
        }

        private void updPlayerFastSeekSpeedText_TextChanged(object sender, TextChangedEventArgs e)
        {
            VideoGrabber.PlayerFastSeekSpeedRatio = Convert.ToInt32 (updPlayerFastSeekSpeedText.Text);
        }

    }
}
