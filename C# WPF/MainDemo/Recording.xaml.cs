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
    /// Interaction logic for Recording.xaml
    /// </summary>
    public partial class Recording : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public Recording(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }
        public void RefreshDisplayOptions()
        {
            Helpers.SetRadioButtonInGroupUsingTag((rdgRecordingMethod), (short)VideoGrabber.RecordingMethod);
            Helpers.SetRadioButtonInGroupUsingTag((rdgCompressMode), (short)VideoGrabber.CompressionMode);
            Helpers.SetRadioButtonInGroupUsingTag((rdgCompressType), (short)VideoGrabber.CompressionType);
            Helpers.SetRadioButtonInGroupUsingTag((rdgRecordingTimer), (short)VideoGrabber.RecordingTimer);

            chkRecordingCanPause.IsChecked = VideoGrabber.RecordingCanPause;
            chkPauseCreatesNewFile.IsChecked = VideoGrabber.RecordingPauseCreatesNewFile;
            chkRecordingOnMotion.IsChecked = VideoGrabber.RecordingOnMotion_Enabled;

            chkPreserveNativeFormat.IsChecked = VideoGrabber.RecordingInNativeFormat;

            chkAudioRecording.IsChecked = VideoGrabber.AudioRecording;

            Helpers.AssignListToComboBox((cboVideoCompressors), VideoGrabber.VideoCompressors, VideoGrabber.VideoCompressor);
            Helpers.AssignListToComboBox((cboAudioCompressors), VideoGrabber.AudioCompressors, VideoGrabber.AudioCompressor);

            btnPauseRecording.IsEnabled = VideoGrabber.RecordingCanPause;
            btnResumeRecording.IsEnabled = VideoGrabber.RecordingCanPause;

            rdgCompressMode.IsEnabled = true;
            rdgCompressType.IsEnabled = true;

            chkScreenRecordWindow.IsEnabled = ((VideoGrabber.VideoSource == VidGrab.TVideoSource.vs_ScreenRecording) ? true : false);

            if (!VideoGrabber.AudioRecording)
            {
                rdgCompressType.IsEnabled = false;
            }
        }

        private void btnVideoCompressorSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ShowDialog(VidGrab.TDialog.dlg_VideoCompressor);
        }

        private void btnAudioCompressorSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ShowDialog(VidGrab.TDialog.dlg_AudioCompressor);
        }

        private void btnMultiplexerSettings_Click(object sender, EventArgs e)
        {
            VideoGrabber.ShowDialog(VidGrab.TDialog.dlg_Multiplexer);
        }

        private void btnCodecExamples_Click(object sender, EventArgs e)
        {
            Helpers.ShellExecute((System.IntPtr)0, "open", "http://www.datastead.com/tvideograbber-recording-codecs-examples.html?demo=csharp", "", "", Helpers.ShowCommands.SW_SHOWNORMAL);
        }

        private void btnSaveVideoCompressorSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            SaveDlg.FileName = VideoGrabber.VideoCompressorName + " (" + VideoGrabber.RecordingMethod.ToString() + ").txt";
            if (SaveDlg.ShowDialog() == true)
            {
                // be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

                VideoGrabber.SaveCompressorSettingsToTextFile(true, VideoGrabber.VideoCompressor, SaveDlg.FileName);

                // remark: you can use instead SaveCompressorSettingsToDataString (TRUE, VideoGrabber.VideoCompressor, YourDataString)
            }
        }

        private void btnSaveAudioCompressorSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            SaveDlg.FileName = VideoGrabber.AudioCompressorName + " (" + VideoGrabber.RecordingMethod.ToString() + ").txt";
            if (SaveDlg.ShowDialog() == true)
            {
                // be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

                VideoGrabber.SaveCompressorSettingsToTextFile(false, VideoGrabber.AudioCompressor, SaveDlg.FileName);

                // remark: you can use instead SaveCompressorSettingsToDataString (FALSE, VideoGrabber.AudioCompressor, YourDataString)
            }
        }

        private void btnReloadVideoCompressorSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            OpenDlg.Filter = Helpers.OPEN_COMPRESSOR_SETTINGS;
            if (OpenDlg.ShowDialog() == true)
            {
                VideoGrabber.LoadCompressorSettingsFromTextFile(true, VideoGrabber.VideoCompressor, OpenDlg.FileName);

                // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (TRUE, VideoGrabber.VideoCompressor)
            }
        }

        private void btnReloadAudioCompressorSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            OpenDlg.Filter = Helpers.OPEN_COMPRESSOR_SETTINGS;
            if (OpenDlg.ShowDialog() == true)
            {
                VideoGrabber.LoadCompressorSettingsFromTextFile(false, VideoGrabber.AudioCompressor, OpenDlg.FileName);

                // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (FALSE, VideoGrabber.AudioCompressor)
            }
        }

        private void btnCreatePreallocFileNow_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.CreatePreallocCapFile();
        }

        private void btnMoreInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Means that the recording stream will ! be uncompressed.\n\r\n\rMUST BE ENABLED: \n\r\n\r- to record hardware-encoded MPEG \n\r\n\r- to record or DV devices in native DV format \n\r\n\r- to record the DV date/time into the video clip and retrieve it during playback \n\r\n\r\n\r\n\rMUST BE DISABLED: \n\r\n\r- to record the text and graphics overlays into the video clip, and retrieve them during playback",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
        }

        private void btnPauseRecording_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.PauseRecording();
        }

        private void btnRenewRecordingFile_Click(object sender, RoutedEventArgs e)
        {
            if (chkAVISaveToThisFile.IsChecked == true)
            {
                VideoGrabber.RecordingFileName = edtRecordingFileName.Text;
            }
            else
            {
                VideoGrabber.RecordingFileName = "";
            }
            VideoGrabber.RecordToNewFileNow("", true);
        }

        private void btnResumeRecording_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ResumeRecording();
        }

        private void btnStartRecordingControlled_Click(object sender, RoutedEventArgs e)
        {
            if (chkAVISaveToThisFile.IsChecked == true)
            {
                VideoGrabber.RecordingFileName = edtRecordingFileName.Text;
            }
            else
            {
                VideoGrabber.RecordingFileName = "";
            }

            VideoGrabber.HoldRecording = true;
            VideoGrabber.StartRecording();

        }

        private void rdgRecordingTimer1_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
        }

        private void rdgRecordingTimer2_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.RecordingTimer = VidGrab.TRecordingTimer.rt_RecordToNewFile;
        }

        private void rdgRecordingTimer3_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.RecordingTimer = VidGrab.TRecordingTimer.rt_StopRecording;
        }

        private void rdgRecordingTimer4_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.RecordingTimer = VidGrab.TRecordingTimer.rt_StartRecording;
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

        private void btnStartRecordingImmediately_Click(object sender, RoutedEventArgs e)
        {
            if (chkAVISaveToThisFile.IsChecked == true)
            {
                VideoGrabber.RecordingFileName = edtRecordingFileName.Text;
            }
            else
            {
                VideoGrabber.RecordingFileName = "";
            }
            VideoGrabber.HoldRecording = false; // let's start recording as soon as the graph is built.

            VideoGrabber.StartRecording();
        }

        private void btnStopRecording_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Stop();
        }

        private void cboAudioCompressors_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioCompressor = cboAudioCompressors.SelectedIndex;
        }

        private void cboVideoCompressors_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoCompressor = cboVideoCompressors.SelectedIndex;
        }

        private void chkAudioRecording_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioRecording = chkAudioRecording.IsChecked == true;
            RefreshDisplayOptions();
        }

        private void chkPreserveNativeFormat_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.RecordingInNativeFormat = chkPreserveNativeFormat.IsChecked == true;
        }

        private void chkRecordingCanPause_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.RecordingCanPause = chkRecordingCanPause.IsChecked == true;
            RefreshDisplayOptions();
        }

        private void chkPauseCreatesNewFile_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.RecordingPauseCreatesNewFile = chkPauseCreatesNewFile.IsChecked == true;
        }

        private void chkRecordingOnMotion_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.RecordingOnMotion_Enabled = chkRecordingOnMotion.IsChecked == true;
            chkRecordingCanPause.IsChecked = chkRecordingOnMotion.IsChecked == true;
        }

        private void rdgCompressMode_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.CompressionMode = (VidGrab.TCompressionMode)Convert.ToInt32((sender as Control).TabIndex);
            }
        }

        private void rdgCompressType_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.CompressionType = (VidGrab.TCompressionType)Convert.ToInt32((sender as Control).TabIndex);
            }
        }

        private void rdgRecordingMethod_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.RecordingMethod = (VidGrab.TRecordingMethod)Convert.ToInt32((sender as RadioButton).TabIndex);
                RefreshDisplayOptions();
            }
        }

        private void btnASFinfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("the ASF settings are located on the 'network streaming// tab",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
        }

        private void btnSendToDVinfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("the recording is sent to the DV camcorder (this feature is called also 'print to DV')",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
        }

        private void Recording_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void edtRecordingTimerInterval_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToInt32(edtRecordingTimerInterval.Text) > 0)
            {
                VideoGrabber.RecordingTimerInterval = Convert.ToInt32(edtRecordingTimerInterval.Text);
            }
            else
            {
                VideoGrabber.RecordingTimerInterval = 0;
            }
        }

        private void cboVideoCompressors_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.VideoCompressor = cboVideoCompressors.SelectedIndex;
        }

        private void cboAudioCompressors_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.AudioCompressor = cboAudioCompressors.SelectedIndex;
        }

    }
}
