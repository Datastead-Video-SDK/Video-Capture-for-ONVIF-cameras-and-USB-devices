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
    /// Interaction logic for VideoSource.xaml
    /// </summary>
    public partial class VideoSource : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public VideoSource(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        private miscCameraControl frmMiscCameraControl = null;
        private miscVideoQuality frmMiscVideoQuality = null;
        private bool m_RefreshingDisplayOptions = false;


        public void RefreshDisplayOptions()
        {
            if (!m_RefreshingDisplayOptions) 
            {
                m_RefreshingDisplayOptions = true;
                Helpers.AssignListToComboBox(cboVideoSource, VideoGrabber.VideoSources, (int)VideoGrabber.VideoSource);
                Helpers.AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices, VideoGrabber.VideoDevice);

                if (VideoGrabber.VideoDevice >= 0) // if a video capture device has been selected 
                {
                    Helpers.AssignListToComboBox(cboAnalogVideoStandards, VideoGrabber.AnalogVideoStandards, VideoGrabber.AnalogVideoStandard);
                    Helpers.AssignListToComboBox(cboVideoSizes, VideoGrabber.VideoSizes, VideoGrabber.VideoSize);
                    Helpers.AssignListToComboBox(cboVideoSubtypes, VideoGrabber.VideoSubtypes, VideoGrabber.VideoSubtype);
                    Helpers.AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats, VideoGrabber.VideoFormat);
                    Helpers.AssignListToComboBox(cboVideoInputs, VideoGrabber.VideoInputs, VideoGrabber.VideoInput);

                    cboAnalogVideoStandards.IsEnabled = VideoGrabber.IsAnalogVideoDecoderAvailable;
                    cboVideoInputs.IsEnabled = VideoGrabber.IsVideoCrossbarAvailable;

                }

                btnAutoRefreshPreview.IsEnabled = VideoGrabber.AutoRefreshPreview;
                btnAutoRefreshPreview.IsChecked = VideoGrabber.AutoRefreshPreview;

                cboVideoSource.SelectedIndex = (int)VideoGrabber.VideoSource;

                chkScreenRecordingWithCursor.IsChecked = VideoGrabber.ScreenRecordingWithCursor;
                edtMonitorNumber.Text = VideoGrabber.ScreenRecordingMonitor.ToString();

                btnCameraControlDialog.IsEnabled = VideoGrabber.IsCameraControlAvailable;
                btnVideoQualityDialog.IsEnabled = VideoGrabber.IsVideoQualityAvailable;

                edtFrameRate.Text = VideoGrabber.FrameRate.ToString("0.00");

                if (frmMiscCameraControl != null) frmMiscCameraControl.RefreshDisplayOptions();
                if (frmMiscVideoQuality != null) frmMiscVideoQuality.RefreshDisplayOptions();
                m_RefreshingDisplayOptions = false;
            }
        }

        private void btnAutoRefreshPreview_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AutoRefreshPreview = btnAutoRefreshPreview.IsChecked == true;
        }

        private void btnDeviceDialog_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ShowDialog(VidGrab.TDialog.dlg_VideoDevice);
            MainDemoWPF.MainForm.MainFormInstance.RefreshDisplayOptions();
        }

        private void btnFrameRate_Click(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtFrameRate.Text))
            {
                VideoGrabber.FrameRate = Convert.ToDouble(edtFrameRate.Text);
                if (VideoGrabber.CurrentState == VidGrab.TCurrentState.cs_Preview)
                {
                    Helpers.AddLog((MainDemoWPF.MainForm.MainFormInstance.mmoLog), "current frame rate: " + VideoGrabber.CurrentFrameRate.ToString("0.00") + " fps.");
                }
            }
        }

        private void btnFrameRateHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'0' means that the default frame rate of the device will be used.\n\nAfter the OnPreviewStarted or OnRecordingStarted event occurs,\nits value is available in the CurrentFrameRate property.",
                    "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
        }


        private void btnSelectFileOrUrl_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            edtVideoSourceFileOrUrl.Text = "";
            fd.Filter = Helpers.OPEN_MEDIA_FILES;
            if (fd.ShowDialog() == true)
                edtVideoSourceFileOrUrl.Text = fd.FileName;
        }

        private void btnDemoUrl_Click(object sender, EventArgs e)
        {
            edtVideoSourceFileOrUrl.Text = "mms://www.datastead.com/demo/demo.wmv";
        }

        private void btnStartPreview_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.StartPreview();
        }

        private void btnStopPreview_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Stop();
        }

        private void cboVideoSource_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboVideoSource.SelectedIndex < 6)
            {
                VideoGrabber.VideoSource = (VidGrab.TVideoSource)cboVideoSource.SelectedIndex;
            }
            else
            {
                Helpers.AddLog((MainDemoWPF.MainForm.MainFormInstance.mmoLog), "this option is not demonstrated in this demo");
            }
        }

        private void cboAnalogVideoStandard_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AnalogVideoStandard = cboAnalogVideoStandards.SelectedIndex;
        }

        private void cboVideoDevices_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoDevice = cboVideoDevices.SelectedIndex;
            // when selecting another video device, the OnVideoDeviceSelected event occurs.
            // From this event we invoke RefreshDisplayOptions to to refresh all the device-dependent controls.
        }

        private void cboVideoInputs_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoInput = cboVideoInputs.SelectedIndex;
        }

        private void cboVideoSizes_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoSize = cboVideoSizes.SelectedIndex;
        }

        private void cboVideoSubtypes_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoSubtype = cboVideoSubtypes.SelectedIndex;
        }

        private void btnScreenRecordingWindow_Click(object sender, RoutedEventArgs e)
        {

            VideoGrabber.SetWindowRecordingByName(edtScreenRecordingWindow.Text, chkScreenRecordingWindow.IsChecked == true);  // set to "true" for an exact and case-sensitive match
            //
            // recording window may be designated by name, class or handle by calling EnumerateWindows, which
            //  causes visible window info to be returned in the OnEnumerateWindows event
            // recording window may then be set by handle rather than name with SetWindowRecordingByHandle
            //
            MainDemoWPF.MainForm.MainFormInstance.SetEnumerateWindows(edtScreenRecordingWindow.Text, (chkScreenRecordingWindow.IsChecked == true));
            if (MainDemoWPF.MainForm.MainFormInstance.strScreenRecordingWindow != "")
            {
                VideoGrabber.EnumerateWindows();
            }

        }

        private void chkScreenRecordingWithCursor_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ScreenRecordingWithCursor = chkScreenRecordingWithCursor.IsChecked == true;
        }

        private void edtMonitorNumber_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtMonitorNumber.Text))
            {
                VideoGrabber.ScreenRecordingMonitor = Convert.ToInt32(edtMonitorNumber.Text);
            }
        }

        private void btnMonitorNumberInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("  -1 = whole desktop (across monitors)     0 = 1st monitor (default)    1 = 2nd monitor    etc...",
                "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
        }

        private void edtVideoSourceFileOrUrl_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoSource_FileOrURL = edtVideoSourceFileOrUrl.Text;
        }

        private void edtSourceFileOrUrlUserName_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetAuthentication(VidGrab.TAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text);
        }

        private void edtSourceFileOrUrlPassword_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetAuthentication(VidGrab.TAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text);
        }

        private void rdgPreferredVideoSize_CheckedChanged(object sender, RoutedEventArgs e)
        {
            int w, h;

            if ((sender as RadioButton).IsChecked == true)
            {
                w = 0;
                h = 0;
                switch (Convert.ToInt32((sender as Control).TabIndex))
                {
                    case 0: w = 0; h = 0; break;
                    case 1: w = 640; h = 360; break;
                    case 2: w = 1280; h = 720; break;
                    case 3: w = 1920; h = 1080; break;
                    default: w = 0; h = 0; break;
                }
                VideoGrabber.UseNearestVideoSize(w, h, chkStretchPreferredVideoSize.IsChecked == true); // disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
                cboVideoSizes.IsEnabled = true;
            }
        }


        private void btnVideoQualityDialog_Click(object sender, RoutedEventArgs e)
        {
            if (frmMiscVideoQuality == null)
            {
                frmMiscVideoQuality = new miscVideoQuality(VideoGrabber);
            }
            frmMiscVideoQuality.Show();
        }

        private void btnCameraControlDialog_Click(object sender, RoutedEventArgs e)
        {
            if (frmMiscCameraControl == null)
            {
                frmMiscCameraControl = new miscCameraControl(VideoGrabber);
            }
            frmMiscCameraControl.Show();
        }

        private void VideoSource_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void cboVideoSizes_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.VideoSize = cboVideoSizes.SelectedIndex;
        }

        private void cboVideoSubtypes_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
                VideoGrabber.VideoSubtype = cboVideoSubtypes.SelectedIndex;
        }

        private void cboVideoFormats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.VideoFormat = cboVideoFormats.SelectedIndex;
        }

        private void cboVideoDevices_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.VideoDevice = cboVideoDevices.SelectedIndex;
        }

        private void cboVideoInputs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.VideoInput = cboVideoInputs.SelectedIndex;
        }

    }
}
