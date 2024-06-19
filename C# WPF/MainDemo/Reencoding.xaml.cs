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
    /// Interaction logic for Reencoding.xaml
    /// </summary>
    public partial class Reencoding : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public Reencoding(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        public void RefreshDisplayOptions()
        {
            Helpers.SetRadioButtonInGroupUsingTag((rdgReencodingMethod), (short)VideoGrabber.Reencoding_Method);
            chkWMVOutput.IsChecked = VideoGrabber.Reencoding_WMVOutput;
            chkIncludeVideoStream.IsChecked = VideoGrabber.Reencoding_IncludeVideoStream;
            chkIncludeAudioStream.IsChecked = VideoGrabber.Reencoding_IncludeAudioStream;
            chkUseFrameGrabber.IsChecked = VideoGrabber.Reencoding_UseFrameGrabber;
            chkUseCurrentVideoCompressor.IsChecked = VideoGrabber.Reencoding_UseVideoCompressor;
            chkUseCurrentAudioCompressor.IsChecked = VideoGrabber.Reencoding_UseAudioCompressor;
            edtStartTime.Text = VideoGrabber.Reencoding_StartTime.ToString();
            edtStopTime.Text = VideoGrabber.Reencoding_StopTime.ToString();
        }

        private void btnDuration_Click(object sender, RoutedEventArgs e)
        {
            Int64 AVIDuration;
            Int64 AVIFrameCount;

            if (VideoGrabber.AVIDuration(edtSourceVideoClip.Text, out AVIDuration, out AVIFrameCount))
            {
                edtDuration.Text = AVIDuration.ToString();
                edtFrameCount.Text = AVIFrameCount.ToString();
            }
        }

        private void btnSourceVideoClip_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            edtSourceVideoClip.Text = "";
            fd.Filter = Helpers.OPEN_MEDIA_FILES;
            if (fd.ShowDialog() == true)
            {
                edtSourceVideoClip.Text = fd.FileName;
            }
        }

        private void btnStartReencoding_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Reencoding_SourceVideoClip = edtSourceVideoClip.Text;
            VideoGrabber.Reencoding_NewVideoClip = edtDestinationVideoClip.Text;

            VideoGrabber.Reencoding_WMVOutput = chkWMVOutput.IsChecked == true;
            VideoGrabber.Reencoding_IncludeVideoStream = chkIncludeVideoStream.IsChecked == true;
            VideoGrabber.Reencoding_IncludeAudioStream = chkIncludeAudioStream.IsChecked == true;
            VideoGrabber.Reencoding_UseFrameGrabber = chkUseFrameGrabber.IsChecked == true;
            VideoGrabber.Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor.IsChecked == true;
            VideoGrabber.Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor.IsChecked == true;

            if (rdgReencodingMethod1.IsChecked == true)
            {
                VideoGrabber.Reencoding_Method = VidGrab.TRecordingMethod.rm_AVI;
            }

            if (rdgReencodingMethod2.IsChecked == true)
            {
                ;
                VideoGrabber.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            };

            if (Helpers.IsNumeric(edtStartTime.Text))
            {
                ;
                VideoGrabber.Reencoding_StartTime = Convert.ToInt64(edtStartTime.Text);
            };

            if (Helpers.IsNumeric(edtStopTime.Text))
            {
                ;
                VideoGrabber.Reencoding_StopTime = Convert.ToInt64(edtStopTime.Text);
            };

            if (Helpers.IsNumeric(edtStartFrame.Text))
            {
                ;
                VideoGrabber.Reencoding_StartFrame = Convert.ToInt64(edtStartFrame.Text);
            };

            if (Helpers.IsNumeric(edtStopFrame.Text))
            {
                ;
                VideoGrabber.Reencoding_StopFrame = Convert.ToInt64(edtStopFrame.Text);
            };

            VideoGrabber.StartReencoding();
        }

        private void btnStopReencoding_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Stop();
        }

        private void Reencoding_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

    }
}
