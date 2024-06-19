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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Runtime.InteropServices;

using Microsoft.Win32;
using VidGrabNoForm;

namespace WPF_Quick_Start_Demo
{
    public partial class MainWindow : Window
    {
        VideoGrabberWPF Vg;

        public MainWindow()
        {
            Vg = new VideoGrabberWPF();
            Vg.OnFirstFrameReceived += Vg_OnFirstFrameReceived;
            Vg.OnFrameSourceAvailable += Vg_OnFrameSourceAvailable;
            Vg.OnLog += Vg_OnLog;

            InitializeComponent();

            image1.Stretch = Stretch.Uniform;
            image2.Stretch = Stretch.Uniform;

        }

        private void Vg_OnLog(object sender, TOnLogEventArgs e)
        {
            if (e.logType == TLogType.i_leaving_full_screen_mode)
            {
                Vg.Display_Visible = false;
            }
            Logbox.Text += e.infoMsg + Environment.NewLine;
            Logbox.CaretIndex = Logbox.Text.Length;
            Logbox.ScrollToEnd();
        }

        void Vg_OnFrameSourceAvailable(object sender, EventArgs e)
        {
            image1.Dispatcher.Invoke((Action)(() => image1.Source = Vg.FrameSource));
        }

        void Vg_OnFirstFrameReceived(object sender, EventArgs e)
        {
            double AspectRatio = Vg.VideoWidth / Vg.VideoHeight;
            image1.Height = image1.Width * AspectRatio;
        }

        private void OneShot_Click(object sender, RoutedEventArgs e)
        {
            image2.Source = Vg.GetLastFrameAsBitmapSource(true);
        }

        private void DeactivateWPFRendering_Click(object sender, RoutedEventArgs e)
        {
            // stops the TVideoGrabber WPF rendering, this does not stop the TVideoGrabber component that goes on previewing or playing in the background
            Vg.WPFStopBitmapSource();
        }

        private void ReactivateWPFRendering_Click(object sender, RoutedEventArgs e)
        {
            Vg.WPFStartBitmapSource();
        }


        private void VideoOnFrameBitmap(object sender, TOnFrameBitmapEventArgs args)
        {
            VideoGrabberWPF VideoGrabberSender = (VideoGrabberWPF)sender;
            TFrameInfo FrameInfo = (TFrameInfo)Marshal.PtrToStructure((IntPtr)args.frameInfo, typeof(TFrameInfo));
            TFrameBitmapInfo FrameBitmapInfo = (TFrameBitmapInfo)Marshal.PtrToStructure((IntPtr)args.bitmapInfo, typeof(TFrameBitmapInfo));

            Graphics MyGraphics = Graphics.FromHdcInternal(FrameBitmapInfo.bitmapDC);

            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Red, 4);

            const int BorderSize = 90;
            const int BoderSizeX2 = BorderSize * 2;
            MyGraphics.DrawRectangle(p, BorderSize, BorderSize, VideoGrabberSender.VideoWidth - BoderSizeX2, VideoGrabberSender.VideoHeight - BoderSizeX2);

            MyGraphics.DrawLine(p, new PointF(0, 0), new PointF(800, 800));

            p.Dispose();
            MyGraphics.Dispose();
        }

        private void StartPreview_Screen_Click(object sender, RoutedEventArgs e)
        {
            Vg.StopPreview();
            Vg.VideoSource = TVideoSource.vs_ScreenRecording;
            Vg.StartPreview();
        }

        private void StartPreview_Webcam_Click(object sender, RoutedEventArgs e)
        {
            Vg.StopPreview();
            Vg.VideoSource = TVideoSource.vs_VideoCaptureDevice;
            Vg.VideoDevice = 0;
            Vg.AudioDevice = 0;
            Vg.AudioDeviceRendering = true;
            Vg.StartPreview();
        }

        private string GenerateFileName()
        {
            return "IPCam_" + DateTime.Now.ToString("yyMMdd_HH_mm_ss_fff") + ".mp4";

        }

        private void OpenURL_Click(object sender, RoutedEventArgs e)
        {
            Vg.Stop(); // stops recording as well as preview
            Vg.VideoSource = TVideoSource.vs_IPCamera;
            Vg.IPCameraURL = RtspURL.Text;
            Vg.AudioDeviceRendering = true;
            if (RecordIPCameraToMP4.IsChecked == true)
            {
                Vg.RecordingInNativeFormat = true;
                Vg.AudioRecording = true;
                Vg.RecordingMethod = TRecordingMethod.rm_MP4;
                Vg.RecordingFileName = GenerateFileName();
                Vg.StartRecording();
                NewFileWhileRecording.IsEnabled = true;
                PauseRecording.IsEnabled = true;
                ResumeRecording.IsEnabled = true;
                StopRecording.IsEnabled = true;
            }
            else
            {
                Vg.StartPreview();
            }
        }

        private void NewFileWhileRecording_Click(object sender, RoutedEventArgs e)
        {
            string NewFileName = GenerateFileName();
            Vg.RecordToNewFileNow(NewFileName, true);
        }

        private void StopPreview_Click(object sender, RoutedEventArgs e)
        {
            Vg.StopPreview();
        }

        public const string AUDIO_CLIPS = "*.mp3;*.wav;*.wma;*.mid";
        public const string VIDEO_CLIPS = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.webm;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*";
        public const string IMAGE_FILES = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png";
        public const string OPEN_MEDIA_FILES = "All media files|" + VIDEO_CLIPS + AUDIO_CLIPS + IMAGE_FILES
                        + "|Video clips|" + VIDEO_CLIPS
                        + "|Audio clips|" + AUDIO_CLIPS;
        public const string OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                        + "|Image files|" + IMAGE_FILES;
        public const string OPEN_PICTURE_FILES = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg";

        private void OpenClip_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = OPEN_MEDIA_FILES_EXTENDED;
            if (fd.ShowDialog() == true)
            {
                Vg.PlayerFileName = fd.FileName;
                Vg.OpenPlayer();
            }
        }

        private void CloseClip_Click(object sender, RoutedEventArgs e)
        {
            Vg.ClosePlayer();
        }

        private void OpenURLInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Viewing or recording RTSP RTMP or HTTP URLs require to install the optional Datastead RTSP/RTMP/HTTP DirectShow source filter that can be downloaded at http://www.datastead.com/products/rtsprtmpsrc");
        }

        private void TextOverlays_Checked(object sender, RoutedEventArgs e)
        {
            Font OverlayFont1 = new Font("Courier New", 16, System.Drawing.FontStyle.Bold);
            Font OverlayFont2 = new Font("Arial", 16, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold);

            Vg.SetTextOverlay_String(0, "1st overlay (aqua, Courier New, index 0)");
            Vg.SetTextOverlay_Top(0, 10);
            Vg.SetTextOverlay_Left(0, 20);
            Vg.SetTextOverlay_Font(0, OverlayFont1.ToHfont());
            Vg.SetTextOverlay_FontColor(0, System.Drawing.ColorTranslator.ToWin32(System.Drawing.Color.Aqua));
            Vg.SetTextOverlay_Enabled(0, true);

            Vg.SetTextOverlay_String(1, "2nd overlay (yellow, Arial, index 1)\nthis demo draws a rectangle over the video frame");
            Vg.SetTextOverlay_Top(1, 30);
            Vg.SetTextOverlay_Left(1, 20);
            Vg.SetTextOverlay_Font(1, OverlayFont2.ToHfont());
            Vg.SetTextOverlay_FontColor(1, System.Drawing.ColorTranslator.ToWin32(System.Drawing.Color.Yellow));
            Vg.SetTextOverlay_Enabled(1, true);
        }

        private void LineOverlay_Checked(object sender, RoutedEventArgs e)
        {
            Vg.OnFrameBitmap += new OnFrameBitmapEventHandler(VideoGrabber1_OnFrameBitmap);
        }

        private void LineOverlay_Unchecked(object sender, RoutedEventArgs e)
        {
            Vg.OnFrameBitmap -= new OnFrameBitmapEventHandler(VideoGrabber1_OnFrameBitmap);
        }

        private void VideoGrabber1_OnFrameBitmap(object sender, VidGrabNoForm.TOnFrameBitmapEventArgs e)
        {
            VideoGrabberWPF VideoGrabberSender = (VideoGrabberWPF)sender;
            TFrameInfo FrameInfo = (TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(TFrameInfo));
            TFrameBitmapInfo FrameBitmapInfo = (TFrameBitmapInfo)Marshal.PtrToStructure((IntPtr)e.bitmapInfo, typeof(TFrameBitmapInfo));

            // FrameBitmapInfo.bitmapDataPtr gives a direct access to the bitmap bits
            // FrameBitmapInfo.bitmapSize returns the size of the bitmap bits

            Graphics MyGraphics = Graphics.FromHdcInternal(FrameBitmapInfo.bitmapDC);

            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Red, 4);

            const int BorderSize = 90;
            const int BoderSizeX2 = BorderSize * 2;
            MyGraphics.DrawRectangle(p, BorderSize, BorderSize, VideoGrabberSender.VideoWidth - BoderSizeX2, VideoGrabberSender.VideoHeight - BoderSizeX2);

            MyGraphics.DrawLine(p, new PointF(0, 0), new PointF(800, 800));

            p.Dispose();
            MyGraphics.Dispose();
        }

        private void PauseRecording_Click(object sender, RoutedEventArgs e)
        {
            Vg.PauseRecording();
        }

        private void ResumeRecording_Click(object sender, RoutedEventArgs e)
        {
            Vg.ResumeRecording();
        }

        private void StopRecording_Click(object sender, RoutedEventArgs e)
        {
            Vg.StopRecording();
        }

        private void rdgExtRenderDisabled_Checked(object sender, RoutedEventArgs e)
        {
            Vg.Display_Embedded = true; // disables the external rendering support
            //Vg.Display_Visible = false; // to prevent the external video window to appear
        }

        private void rdgExtRenderEnabledWpf_Checked(object sender, RoutedEventArgs e)
        {
            Vg.Display_Visible = false; // to prevent the external video window to appear
            Vg.Display_Embedded = false; // enables the exernal rendering support (additionally to the WPF control)
        }

        private void rdgExtRenderEnabledNoWPF_Checked(object sender, RoutedEventArgs e)
        {
        }
        private void chkFullScreen_Checked(object sender, RoutedEventArgs e)
        {
            Vg.Display_FullScreen = true;
            Vg.Display_Visible = true;
        }
        private void chkFullScreen_Unchecked(object sender, RoutedEventArgs e)
        {
            Vg.Display_Visible = false;
            Vg.Display_FullScreen = false;
        }

        private void chkExternalWindow_Checked(object sender, RoutedEventArgs e)
        {
            Vg.Display_Visible = true;
            Vg.Display_SetLocation(10, 10, 400, 320);
        }

        private void chkExternalWindow_Unchecked(object sender, RoutedEventArgs e)
        {
            Vg.Display_Visible = false;
        }

        private void chkWithAudio_Checked(object sender, RoutedEventArgs e)
        {
            Vg.AudioDeviceRendering = true;
        }

    }
}
