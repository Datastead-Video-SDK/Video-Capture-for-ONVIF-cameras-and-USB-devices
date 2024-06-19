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

using VidGrabWPF;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for FrameGrabber.xaml
    /// </summary>
    public partial class FrameGrabber : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public FrameGrabber(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        public void RefreshDisplayOptions()
        {
            Helpers.SetRadioButtonInGroupUsingTag(rgdFrameGrabber, (short)VideoGrabber.FrameGrabber);
            Helpers.SetRadioButtonInGroupUsingTag(rgdFrameGrabberFormat, (short)VideoGrabber.FrameGrabberRGBFormat);
            Helpers.SetRadioButtonInGroupUsingTag(rdgAutoFileName, (short)VideoGrabber.AutoFileName);

            edtAVIAutoFilePrefix.Text = VideoGrabber.AutoFilePrefix;

            edtBurstCount.Text = VideoGrabber.BurstCount.ToString();
            edtBurstInterval.Text = VideoGrabber.BurstInterval.ToString();
            tbrCaptureZoomSize.Value = VideoGrabber.FrameCaptureZoomSize;
            edtFrameCaptureWidth.Text = VideoGrabber.FrameCaptureWidth.ToString();
            edtFrameCaptureHeight.Text = VideoGrabber.FrameCaptureHeight.ToString();
        }

        private void btnBurstModeBMPFile_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.BurstType = VidGrab.TFrameCaptureDest.fc_BmpFile;
            VideoGrabber.BurstMode = true;
            // The frame capture starts when BurstMode is set to true.;
            // if (BurstCount = 0 the frame capture won"t stop.;
            // BMP file names will be generated automatically according to AutoFileName;
            // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.;
        }

        private void btnBurstModeJPEGFile_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.BurstType = VidGrab.TFrameCaptureDest.fc_JpegFile;
            VideoGrabber.BurstMode = true;
            // The frame capture starts when BurstMode is set to true.;
            // if (BurstCount = 0 the frame capture won"t stop.;
            // JPEG file names will be generated automatically according to AutoFileName;
            // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.;
        }

        private void btnBurstModeClipboard_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.BurstType = VidGrab.TFrameCaptureDest.fc_Clipboard;
            VideoGrabber.BurstMode = true;
            // The frame capture starts when BurstMode is set to true.;
            // if (BurstCount = 0 the frame capture won"t stop.;
            // Captured frames will be returned by the OnFrameCaptureCompleted event.;
        }

        private void btnBurstModeStop_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.BurstMode = false;
        }

        private void btnBurstModeTBitmap_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            VideoGrabber.BurstMode = true;
            // The frame capture starts when BurstMode is set to true.;
            // if (BurstCount = 0 the frame capture won"t stop.;
            // Captured frames will be returned by the OnFrameCaptureCompleted event.;
        }

        private void btnOneShotJPEGFile_Click(object sender, RoutedEventArgs e)
        {
            if (chkUseThisFileName.IsChecked == true)
            {
                VideoGrabber.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, edtUseThisFileName.Text);
            }
            else
            {
                VideoGrabber.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, "");
            }
            // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory;
            // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success;
        }

        private void btnOneShotBMPFile_Click(object sender, RoutedEventArgs e)
        {
            if (chkUseThisFileName.IsChecked == true)
            {
                VideoGrabber.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_BmpFile, edtUseThisFileName.Text);
            }
            else
            {
                VideoGrabber.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_BmpFile, "");
            }
            // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory;
            // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success;
        }

        private void btnOneShotClipboard_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_Clipboard, "");
        }

        private void btnOneShotTBitmap_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_TBitmap, "");
        }

        private void chkUseThisFileName_CheckedChanged(object sender, RoutedEventArgs e)
        {
            edtUseThisFileName.IsEnabled = chkUseThisFileName.IsChecked == true;
        }

        private void edtAVIAutoFilePrefix_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AutoFilePrefix = edtAVIAutoFilePrefix.Text;
        }

        private void edtBurstCount_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtBurstCount.Text))
            {
                VideoGrabber.BurstCount = Convert.ToInt32(edtBurstCount.Text);
            };
        }

        private void edtBurstInterval_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtBurstInterval.Text))
            {
                VideoGrabber.BurstInterval = Convert.ToInt32(edtBurstInterval.Text);
            };
        }

        private void rdgAutoFileName1_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (rdgAutoFileName1.IsChecked == true)
            {
                VideoGrabber.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            };
        }

        private void rdgAutoFileName2_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (rdgAutoFileName2.IsChecked == true)
            {
                VideoGrabber.AutoFileName = VidGrab.TAutoFileName.fn_DateTime;
            };
        }

        private void btnResetCaptureZoomSize_Click(object sender, RoutedEventArgs e)
        {
            tbrCaptureZoomSize.Value = 100;
            VideoGrabber.FrameCaptureZoomSize = (int) tbrCaptureZoomSize.Value;
            edtCaptureZoomSize.Text = tbrCaptureZoomSize.Value.ToString() + "%";
            tbrCaptureZoomSize.UpdateLayout();
        }

        private void edtFrameCaptureWidth_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtFrameCaptureWidth.Text))
            {
                VideoGrabber.FrameCaptureWidth = Convert.ToInt32(edtFrameCaptureWidth.Text);
            }
        }

        private void edtFrameCaptureHeight_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtFrameCaptureHeight.Text))
            {
                VideoGrabber.FrameCaptureHeight = Convert.ToInt32(edtFrameCaptureHeight.Text);
            }
        }

        private void rgdFrameGrabber_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.FrameGrabber = (VidGrab.TFrameGrabber)Convert.ToInt32((sender as Control).TabIndex);
                RefreshDisplayOptions();
            }

        }

        private void rgdFrameGrabberFormat_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.FrameGrabberRGBFormat = (VidGrab.TFrameGrabberRGBFormat)Convert.ToInt32((sender as Control).TabIndex);
            }

        }

        private void FrameGrabber_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void rdgAutoFileName3_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (rdgAutoFileName3.IsChecked == true)
            {
                VideoGrabber.AutoFileName = VidGrab.TAutoFileName.fn_Counter;
            };

        }

        private void tbrCaptureZoomSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.FrameCaptureZoomSize = (int)tbrCaptureZoomSize.Value;
            edtCaptureZoomSize.Text = tbrCaptureZoomSize.Value.ToString() + "%";
        }

    }
}
