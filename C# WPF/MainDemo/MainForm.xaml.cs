using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Automation;
using System.Windows.Controls.Primitives;
using System.Windows.Ink;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using VidGrab;
using VidGrabWPF;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public static MainForm MainFormInstance;

        public VideoFromImagesFileList VideoFromImages;


        public struct WINDOW_ENUM
        {
            public IntPtr WindowHandle;
            public string WindowName;
            public string WindowClass;
        }
        public bool IsVideoGrabberMouseDown;
        public int lngScreenRecordingWindow;
        public string strScreenRecordingWindow;
        public bool boolScreenRecordingWindow;
        public WINDOW_ENUM[] wenScreenRecordingWindow;

        public int frmOverlays_edtDrawGrid;
        public bool frmOverlays_drawTarget;
        private System.Drawing.Point frmOverlays_drawTarget_Location;
        public System.Windows.Media.Brush frmOverlays_btnDrawGridColor;
        public System.Windows.Media.Brush frmOverlays_btnFreeHandColor;

        public bool VideoProcessing_DetectNoVideoSignal;
        public bool VideoProcessing_DetectConnexantBlueScreen;

        public bool OldVideoSignalState;


        public bool VideoFromImagesUsePictureBox;

        public FreeHandDrawing cFreeHandDrawing;
        public PickupColor cPickupColor;

        private double LastKBWrittenReportTime;


        private double StartupWidth;
        private double StartupHeight;


        public double StartupVGWidth;
        public double StartupVGHeight;

        public System.Drawing.Brush brushMotionRatio;
        public bool boolMotionRatio;

        public Audio tabitem_Audio = null;
        public Display tabitem_Display = null;
        public FrameGrabber tabitem_FrameGrabber = null;
        public IPCamera tabitem_IPCamera = null;
        public MotionDetection tabitem_MotionDetection = null;
        public MultipurposeEncoder tabitem_MultipurposeEncoder = null;
        public NetworkStreaming tabitem_NetworkStreaming = null;
        public Overlays tabitem_Overlays = null;
        public Player tabitem_Player = null;
        public Recording tabitem_Recording = null;
        public Reencoding tabitem_Reencoding = null;
        public VideoProcessing tabitem_VideoProcessing = null;
        public VideoSource tabitem_VideoSource = null;

        public MainForm()
        {
            InitializeComponent();

            MainFormInstance = this;

            tabitem_Audio = new Audio(VideoGrabber1);
            tabitem_Display = new Display(VideoGrabber1);
            tabitem_FrameGrabber = new FrameGrabber(VideoGrabber1);
            tabitem_IPCamera = new IPCamera(VideoGrabber1);
            tabitem_MotionDetection = new MotionDetection(VideoGrabber1);
            tabitem_MultipurposeEncoder = new MultipurposeEncoder(VideoGrabber1);
            tabitem_NetworkStreaming = new NetworkStreaming(VideoGrabber1);
            tabitem_Overlays = new Overlays(VideoGrabber1);
            tabitem_Player = new Player(VideoGrabber1);
            tabitem_Recording = new Recording(VideoGrabber1);
            tabitem_Reencoding = new Reencoding(VideoGrabber1);
            tabitem_VideoProcessing = new VideoProcessing(VideoGrabber1);
            tabitem_VideoSource = new VideoSource(VideoGrabber1);

            tbpAudio.Content = tabitem_Audio;
            tbpDisplay.Content = tabitem_Display;
            tbpFrameGrabber.Content = tabitem_FrameGrabber;
            tbpIPCameras.Content = tabitem_IPCamera;
            tbpMotionDetection.Content = tabitem_MotionDetection;
            tbpMultipurposeEncoder.Content = tabitem_MultipurposeEncoder;
            tbpNetworkStreaming.Content = tabitem_NetworkStreaming;
            tbpOverlays.Content = tabitem_Overlays;
            tbpPlayer.Content = tabitem_Player;
            tbpRecording.Content = tabitem_Recording;
            tbpReencoding.Content = tabitem_Reencoding;
            tbpVideoProcessing.Content = tabitem_VideoProcessing;
            tbpVideoSource.Content = tabitem_VideoSource;

            VideoFromImages = new VideoFromImagesFileList();
            VideoFromImagesUsePictureBox = false;

            VideoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box; // preserves the display aspect ratio
            VideoGrabber1.AutoRefreshPreview = true; // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

            StartupWidth = Width;
            StartupHeight = Height;


            IsVideoGrabberMouseDown = false;
            frmOverlays_edtDrawGrid = 0;
            frmOverlays_drawTarget = false;
            frmOverlays_btnDrawGridColor = System.Windows.Media.Brushes.Blue;
            frmOverlays_btnFreeHandColor = System.Windows.Media.Brushes.Red;

            StartupVGWidth = VideoGrabber1.Width;
            StartupVGHeight = VideoGrabber1.Height;

            edtStoragePath.Text = VideoGrabber1.StoragePath;

            cFreeHandDrawing = new FreeHandDrawing();
            cPickupColor = new PickupColor();

            LastKBWrittenReportTime = 0;

            RefreshDisplayOptions();

            tbcTabs.SelectedItem = tbpVideoSource;
        }

        private bool m_RefreshingOptions = false;

        public void RefreshDisplayOptions()
        {
            if (!m_RefreshingOptions)
            {
                m_RefreshingOptions = true;
                tabitem_Audio.RefreshDisplayOptions();
                tabitem_Display.RefreshDisplayOptions();
                tabitem_FrameGrabber.RefreshDisplayOptions();
                tabitem_IPCamera.RefreshDisplayOptions();
                tabitem_MotionDetection.RefreshDisplayOptions();
                tabitem_MultipurposeEncoder.RefreshDisplayOptions();
                tabitem_NetworkStreaming.RefreshDisplayOptions();
                tabitem_Overlays.RefreshDisplayOptions();
                tabitem_Player.RefreshDisplayOptions();
                tabitem_Recording.RefreshDisplayOptions();
                tabitem_Reencoding.RefreshDisplayOptions();
                tabitem_VideoProcessing.RefreshDisplayOptions();
                tabitem_VideoSource.RefreshDisplayOptions();
                m_RefreshingOptions = false;
            }
        }

        public void SetEnumerateWindows(string WindowName, bool ExactMatch)
        {
            wenScreenRecordingWindow = new WINDOW_ENUM[1];
            lngScreenRecordingWindow = 0;
            strScreenRecordingWindow = WindowName;
            boolScreenRecordingWindow = ExactMatch;
            tabitem_VideoSource.lblEnumerateWindows.Content = ((strScreenRecordingWindow == "") ? "" : System.Convert.ToString(lngScreenRecordingWindow));
        }

        private void VideoGrabber1_OnEnumerateWindows(object sender, VidGrab.TOnEnumerateWindowsEventArgs e)
        {
            // EnumerateWindows begins gathering of visible windows
            // Demo proc SetEnumerateWindows initializes array wenScreenRecordingWindow(),
            //  called in OnRecordingReadyToStart event, which is instigated by
            //  enabling HoldRecording before calling StartRecording
            //  (see btnStartRecordingControlled in Recording form)

            bool b = false;

            if (strScreenRecordingWindow.ToLower() == e.windowName.ToLower())
            {
                b = true;
            }
            else if ((!boolScreenRecordingWindow) & (e.windowName.ToLower().IndexOf(strScreenRecordingWindow.ToLower(), 0) + 1) > 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            if (b)
            {
#if (!VS2003)
                Array.Resize(ref wenScreenRecordingWindow, lngScreenRecordingWindow + 1);
#endif
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowHandle = e.windowHandle;
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowClass = e.windowClass;
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowName = e.windowName;
                lngScreenRecordingWindow = lngScreenRecordingWindow + 1;

                tabitem_VideoSource.lblEnumerateWindows.Content = Convert.ToString(lngScreenRecordingWindow);
            }
        }


        private void VideoGrabber1_OnVideoDeviceSelected(object sender, EventArgs e)
        {
            RefreshDisplayOptions(); // updates all the ComboBox lists and controls, especially those that depend of the video capture device (like VideoInputs, VideoSubtypes, etc...)
        }

        private void VideoGrabber1_OnAudioDeviceSelected(object sender, EventArgs e)
        {
            RefreshDisplayOptions(); // updates all the ComboBox lists and controls, especially those that depend of the audio capture device (like AudioInputs, etc...)
        }

        private void VideoGrabber1_OnFrameProgress2(object sender, VidGrab.TOnFrameProgress2EventArgs e)
        {
            VidGrab.TFrameInfo FrameInfo = (VidGrab.TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(VidGrab.TFrameInfo));

            if (FrameInfo.currentState == VidGrab.TCurrentState.cs_Playback) // we don't include the dropped frames during playback
            {
                edtFrameCount.Text = String.Format("frame: {0} time:{1:00}:{2:00}:{3:00}:{4:00}", FrameInfo.frameNumber, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs);
            }
            else
            {
                edtFrameCount.Text = String.Format("frame: {0} dropped:{1} time:{2:00}:{3:00}:{4:00}:{5:00}", FrameInfo.frameNumber, FrameInfo.droppedFrameCount, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs);
            }

            if (FrameInfo.NTPFrameTime > 0)
            {
                edtAdditionalInfo.Text = String.Format("ntp (100ns): {0}", FrameInfo.NTPFrameTime);
            }

            if (VideoGrabber1.CurrentState == VidGrab.TCurrentState.cs_Recording)
            {
                if ((FrameInfo.frameTime - LastKBWrittenReportTime) > 50000000)
                {  // every 5 seconds
                    LastKBWrittenReportTime = FrameInfo.frameTime;
                    Helpers.AddLog(mmoLog, String.Format("written to disk: {0} KB", VideoGrabber1.RecordingKBytesWrittenToDisk()));
                }
            }
        }

        private void VideoGrabber1_OnFrameBitmap(object sender, VidGrab.TOnFrameBitmapEventArgs e)
        {
            // this event is called directly from a thread. Read the (*) comment at the bottom of this page

            // GRID DRAWING
            // ============
            {
                VidGrab.TFrameInfo FrameInfo = (VidGrab.TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(VidGrab.TFrameInfo));
                VidGrab.TFrameBitmapInfo FrameBitmapInfo = (VidGrab.TFrameBitmapInfo)Marshal.PtrToStructure((IntPtr)e.bitmapInfo, typeof(VidGrab.TFrameBitmapInfo));

                if (frmOverlays_drawTarget)
                {
                    Graphics MyGraphics = Graphics.FromHdcInternal(FrameBitmapInfo.bitmapDC);

                    System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Blue);
                    SolidBrush b = new SolidBrush(System.Drawing.Color.Blue);

                    int TargetRadius = 50;
                    int TargetRadiusX2 = TargetRadius * 2;

                    MyGraphics.DrawEllipse(p, frmOverlays_drawTarget_Location.X - TargetRadius, frmOverlays_drawTarget_Location.Y - TargetRadius, TargetRadiusX2, TargetRadiusX2);

                    MyGraphics.FillRectangle(b, frmOverlays_drawTarget_Location.X - TargetRadius, frmOverlays_drawTarget_Location.Y, TargetRadiusX2, 1);
                    MyGraphics.FillRectangle(b, frmOverlays_drawTarget_Location.X, frmOverlays_drawTarget_Location.Y - TargetRadius, 1, TargetRadiusX2);

                    MyGraphics.Dispose();
                }

                if (frmOverlays_edtDrawGrid > 1)
                {

                    Graphics MyGraphics = Graphics.FromHdcInternal(FrameBitmapInfo.bitmapDC);
                    SolidBrush b = new SolidBrush(System.Drawing.Color.Aqua);

                    int xStep = FrameBitmapInfo.bitmapWidth / frmOverlays_edtDrawGrid;
                    int yStep = xStep;

                    int xLocation = xStep;
                    int yLocation = yStep;

                    while (xLocation < FrameBitmapInfo.bitmapWidth)
                    {
                        MyGraphics.FillRectangle(b, xLocation, 0, 1, FrameBitmapInfo.bitmapHeight);
                        xLocation += xStep;
                    }

                    while (yLocation < FrameBitmapInfo.bitmapHeight)
                    {
                        MyGraphics.FillRectangle(b, 0, yLocation, FrameBitmapInfo.bitmapWidth, 1);
                        yLocation += yStep;
                    }

                    MyGraphics.Dispose();
                }

                // FREE HAND DRAWING
                // ============

                if (cFreeHandDrawing.iArrayCoordinates > 0)
                { // see the VideoGrabberMouse... events;

                    Graphics MyGraphics = Graphics.FromHdcInternal(FrameBitmapInfo.bitmapDC);
                    System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Brushes.Red);
                    SolidBrush b = new SolidBrush(System.Drawing.Color.Red);

                    int LastX = 0;
                    int LastY = 0;

                    int i;

                    for (i = 0; i < cFreeHandDrawing.iArrayCoordinates; i++)
                    {
                        if (cFreeHandDrawing.ArrayCoordinates[i].Width == 0)
                        { //// Width is used as boolean to know if (it is a MoveTo or a LineTo;
                            LastX = cFreeHandDrawing.ArrayCoordinates[i].X;
                            LastY = cFreeHandDrawing.ArrayCoordinates[i].Y;
                            MyGraphics.FillRectangle(b, LastX, LastY, 1, 1);
                        }
                        else
                        {
                            MyGraphics.DrawLine(p, LastX, LastY, cFreeHandDrawing.ArrayCoordinates[i].X, cFreeHandDrawing.ArrayCoordinates[i].Y);
                            LastX = cFreeHandDrawing.ArrayCoordinates[i].X;
                            LastY = cFreeHandDrawing.ArrayCoordinates[i].Y;
                        }
                    }

                    MyGraphics.Dispose();
                }

                // VIDEO SIGNAL DETECTION
                // ============

                bool NewVideoSignalState = false;

                NewVideoSignalState = OldVideoSignalState;

                if (VideoProcessing_DetectNoVideoSignal)
                {
                    NewVideoSignalState = VideoGrabber1.IsVideoSignalDetected(false, true, 30, 30, 30, true);
                }
                else if (VideoProcessing_DetectConnexantBlueScreen)
                {
                    NewVideoSignalState = VideoGrabber1.IsVideoSignalDetected(true, false, 0, 0, 0, false);
                }

                if (NewVideoSignalState != OldVideoSignalState)
                {
                    OldVideoSignalState = NewVideoSignalState;
                    if (NewVideoSignalState)
                    {
                        Helpers.AddLog(mmoLog, "Video signal is back");
                    }
                    else
                    {
                        Helpers.AddLog(mmoLog, "VIDEO SIGNAL LOST");
                    }
                }

                // used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
                if (cPickupColor.MustGetRGBPixel)
                {
                    cPickupColor.MustGetRGBPixel = false;
                    cPickupColor.LastRGBPixelValueAtMousePosition = VideoGrabber1.GetRGBPixelAt(cPickupColor.MouseXVideoPosition, cPickupColor.MouseYVideoPosition);
                }
            }
        }

        private void VideoGrabber1_OnFrameCaptureCompleted(object sender, VidGrab.TOnFrameCaptureCompletedEventArgs e)
        {
            if (e.success)
            {
                Helpers.AddLog((tabitem_FrameGrabber.mmoFrameCaptureLog), "frame #" + e.frameNumber.ToString() + " captured");
            }

            if ((e.destType == VidGrab.TFrameCaptureDest.fc_JpegFile) || (e.destType == VidGrab.TFrameCaptureDest.fc_BmpFile))
            {
                if (e.success)
                {
                    Helpers.AddLog((tabitem_FrameGrabber.mmoFrameCaptureLog), e.fileName);
                }
                else
                {
                    Helpers.AddLog((tabitem_FrameGrabber.mmoFrameCaptureLog), "error: failed to create " + e.fileName);
                }
            }
            if (e.destType == VidGrab.TFrameCaptureDest.fc_TBitmap)
            {
                 SnapForm frm_SnapForm = new SnapForm();
                frm_SnapForm.Owner = this;
                frm_SnapForm.SnapImage.Source = Imaging.CreateBitmapSourceFromHBitmap(e.frameBitmapHandle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
                frm_SnapForm.Show();
            }
        }

        private void VideoGrabber1_OnCopyPreallocDataCompleted(object sender, VidGrab.TOnSourceFileToDestFileCompletedEventArgs e)
        {
            if (e.success)
            {
                Helpers.AddLog(mmoLog, " successfully copied to " + e.destFile + ".");
            }
            else
            {
                Helpers.AddLog(mmoLog, "ERROR: Failed to copy " + e.sourceFile + " to " + e.destFile + "!");
            }
        }

        private void VideoGrabber1_OnCopyPreallocDataProgress(object sender, VidGrab.TOnProgressEventArgs e)
        {
            Helpers.AddLog(mmoLog, "copying data: " + e.percent.ToString() + "% completed.");
        }

        private void VideoGrabber1_OnCopyPreallocDataStarted(object sender, VidGrab.TOnSourceFileToDestFileStartedEventArgs e)
        {
            Helpers.AddLog(mmoLog, "copying data from " + e.sourceFile + " to " + e.destFile + "...");
        }

        private void VideoGrabber1_OnCreatePreallocFileCompleted(object sender, VidGrab.TOnCreatePreallocatedFileCompletedEventArgs e)
        {
            if (e.success)
            {
                Helpers.AddLog(mmoLog, "preallocated file " + e.fileName + " successfully created.");
            }
            else
            {
                Helpers.AddLog(mmoLog, "ERROR: Failed to preallocate " + e.fileName);
            }
        }

        private void VideoGrabber1_OnCreatePreallocFileProgress(object sender, VidGrab.TOnProgressEventArgs e)
        {
            Helpers.AddLog(mmoLog, e.percent.ToString() + "% of preallocated file completed");
        }

        private void VideoGrabber1_OnCreatePreallocFileStarted(object sender, VidGrab.TOnFileNotificationEventArgs e)
        {
            Helpers.AddLog(mmoLog, "preallocating file " + e.fileName + "...");
        }

        private void VideoGrabber1_OnDeviceArrivalOrRemoval(object sender, VidGrab.TOnDeviceArrivalOrRemovalEventArgs e)
        {
            string AudioOrVideoDevice;

            if (e.isVideoDevice)
            {
                AudioOrVideoDevice = "video device ";
            }
            else
            {
                AudioOrVideoDevice = "audio device ";
            }
            if (e.isDeviceArrival)
            {
                Helpers.AddLog(mmoLog, AudioOrVideoDevice + " arrival:");
            }
            else
            {
                Helpers.AddLog(mmoLog, AudioOrVideoDevice + " removal:");
            }
            Helpers.AddLog(mmoLog, e.deviceName);
            if (e.isVideoDevice)
            {
                Helpers.AssignListToComboBox(tabitem_VideoSource.cboVideoDevices, VideoGrabber1.VideoDevices, VideoGrabber1.VideoDevice);
            }
            else
            {
                Helpers.AssignListToComboBox(tabitem_Audio.cboAudioDevices, VideoGrabber1.AudioDevices, VideoGrabber1.AudioDevice);
            }
        }

        private void VideoGrabber1_OnDeviceLost(object sender, EventArgs e)
        {
            Helpers.AddLog(mmoLog, "DEVICE LOST!");
            Helpers.AssignListToComboBox(tabitem_VideoSource.cboVideoDevices, VideoGrabber1.VideoDevices, VideoGrabber1.VideoDevice);
            Helpers.AssignListToComboBox(tabitem_Audio.cboAudioDevices, VideoGrabber1.AudioDevices, VideoGrabber1.AudioDevice);
        }

        private void VideoGrabber1_OnDirectNetworkStreamingHostUrl(object sender, VidGrab.TOnDirectNetworkStreamingHostUrlEventArgs e)
        {
            Helpers.AddLog(mmoLog, "streaming URL: " + e.hostUrl);
            Helpers.AddLog(mmoLog, "streaming host: " + e.hostName);
            Helpers.AddLog(mmoLog, "streaming port: " + e.hostPort.ToString());
        }

        private void VideoGrabber1_OnDiskFull(object sender, EventArgs e)
        {
            Helpers.AddLog(mmoLog, "DISK FULL!");
        }

        private void VideoGrabber1_OnDVCommandCompleted(object sender, VidGrab.TOnDVCommandCompletedEventArgs e)
        {
            Helpers.AddLog(mmoLog, "camcorder state: " + e.newStateLabel);
        }

        private void VideoGrabber1_OnDVDiscontinuity(object sender, VidGrab.TOnDVDiscontinuityEventArgs e)
        {
            // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below);
            // e.deliverNewFrame = false;
            // VideoGrabber1.RecordToNewFileNow();

            // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below);
            // e.deliverNewFrame = false;
            // VideoGrabber1.Stop();

            // read the (*) comment at the bottom of this unit;
        }

        private void VideoGrabber1_OnLog(object sender, VidGrab.TOnLogEventArgs e)
        {
            Helpers.AddLog(mmoLog, "[" + e.severity + "] " + e.infoMsg);
        }

        private void VideoGrabber1_OnMotionDetected(object sender, VidGrab.TOnMotionDetectedEventArgs e)
        {

            int MaxMotionXLocation = 0;
            int MaxMotionYLocation = 0;
             
            tabitem_MotionDetection.edtMotionRatio.Text = VideoGrabber1.MotionDetector_GlobalMotionRatio.ToString("0.000");

            tabitem_MotionDetection.MotionDetected = true;

            tabitem_MotionDetection.edtMaxMotionXY.Text = "x:" + e.maxMotionCellX.ToString() + " y:" + e.maxMotionCellY.ToString();

            if (VideoGrabber1.MotionDetector_GetCellLocation(e.maxMotionCellX, e.maxMotionCellY, ref MaxMotionXLocation, ref MaxMotionYLocation))
            {
                tabitem_MotionDetection.edtMaxMotionCoord.Text = "x: " + MaxMotionXLocation.ToString() + "  y: " + MaxMotionYLocation.ToString();
            }

            tabitem_MotionDetection.mmoMotionGrid.Text = VideoGrabber1.MotionDetector_Get2DTextMotion();

            System.IntPtr FrameBitmap = (System.IntPtr)VideoGrabber1.GetLastFrameAsHBITMAP(0, false, 0, 0, 0, 0, (int) tabitem_MotionDetection.imgMotionDetected.Width, (int) tabitem_MotionDetection.imgMotionDetected.Height, 32);
            if (!FrameBitmap.Equals(System.IntPtr.Zero))
            {
                tabitem_MotionDetection.imgMotionDetected.Source = Imaging.CreateBitmapSourceFromHBitmap(FrameBitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
                Helpers.DeleteObject(FrameBitmap);
            }
        }

        private void VideoGrabber1_OnMotionNotDetected(object sender, VidGrab.TOnMotionNotDetectedEventArgs e)
        {
            tabitem_MotionDetection.edtMotionRatio.Text = "";

            tabitem_MotionDetection.MotionDetected = false;

            tabitem_MotionDetection.mmoMotionGrid.Text = VideoGrabber1.MotionDetector_Get2DTextMotion();
        }

        private void VideoGrabber1_OnMouseDown(object sender, VidGrab.TOnVideoMouseUpDownEventArgs e)
        {
            if (e.videoWindow != -1)  // if (the video is displayed;
            {
                if (tabitem_Overlays.chkTargetAtMouseLocation.IsChecked == true)
                {
                    frmOverlays_drawTarget_Location.X = e.x;
                    frmOverlays_drawTarget_Location.Y = e.y;
                    frmOverlays_drawTarget = true;
                }

                if (tabitem_Overlays.chkFreeHandEnabled.IsChecked == true)
                {
                    if (cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY)
                    {
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].X = e.x;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Y = e.y;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Width = 0; // Width is used as boolean to know if [it is a MoveTo or a LineTo
                        cFreeHandDrawing.iArrayCoordinates++;
                        cFreeHandDrawing.DrawingEnabled = true;
                        VideoGrabber1.RefreshPlayerOverlays();
                    }
                }
                IsVideoGrabberMouseDown = true;
            }
        }

        private void VideoGrabber1_OnMouseMove(object sender, VidGrab.TOnVideoMouseMoveEventArgs e)
        {
            if (e.videoWindow != -1)  // if (the video is displayed;
            {

                if (frmOverlays_drawTarget)
                {
                    if (IsVideoGrabberMouseDown)
                    {
                        frmOverlays_drawTarget_Location.X = e.x;
                        frmOverlays_drawTarget_Location.Y = e.y;
                    }
                }

                if (cFreeHandDrawing.DrawingEnabled)
                {
                    if (cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY)
                    {
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].X = e.x;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Y = e.y;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Width = 1; // Width is used as boolean to know if [it is a MoveTo or a LineTo;
                        cFreeHandDrawing.iArrayCoordinates++;
                        VideoGrabber1.RefreshPlayerOverlays();
                    }
                }
            }
        }

        private void VideoGrabber1_OnMouseUp(object sender, VidGrab.TOnVideoMouseUpDownEventArgs e)
        {
            IsVideoGrabberMouseDown = false;
            cFreeHandDrawing.DrawingEnabled = false;

            // used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
            cPickupColor.LastRGBPixelValueAtMousePosition = 0;
            cPickupColor.MouseXVideoPosition = e.x;
            cPickupColor.MouseYVideoPosition = e.y;
            cPickupColor.MustGetRGBPixel = true;
            VideoGrabber1.RefreshPlayerOverlays();
        }

        private void VideoGrabber1_OnPlayerOpened(object sender, EventArgs e)
        {
            sldPlayer.Minimum = 1;
            sldPlayer.TickFrequency = 1;
            sldPlayer.Maximum = (int)VideoGrabber1.PlayerFrameCount;

            Helpers.AddLog(mmoLog, "");
            Helpers.AddLog(mmoLog, "playing " + VideoGrabber1.PlayerFileName);

            if (VideoGrabber1.IsPlayerVideoStreamAvailable == VidGrab.TTriState.ts_True)
            {
                Helpers.AddLog(mmoLog, "this clip has a video stream");
            }
            else if (VideoGrabber1.IsPlayerVideoStreamAvailable == VidGrab.TTriState.ts_False)
            {
                Helpers.AddLog(mmoLog, "this clip does not have video");
            }
            if (VideoGrabber1.IsPlayerAudioStreamAvailable == VidGrab.TTriState.ts_True)
            {
                Helpers.AddLog(mmoLog, "this clip has a Audio stream");
            }
            else if (VideoGrabber1.IsPlayerAudioStreamAvailable == VidGrab.TTriState.ts_False)
            {
                Helpers.AddLog(mmoLog, "this clip does not have Audio");

            }

            Helpers.AddLog(mmoLog, "");
            Helpers.AddLog(mmoLog, "video codec: " + VideoGrabber1.PlayerVideoCodec);
            Helpers.AddLog(mmoLog, "audio codec: " + VideoGrabber1.PlayerAudioCodec);
            Helpers.AddLog(mmoLog, "");
            double PlayerDuration = VideoGrabber1.PlayerDuration / 10000000;
            Helpers.AddLog(mmoLog, "Duration: " + PlayerDuration.ToString("0.00"));
            Helpers.AddLog(mmoLog, "Frame count: " + VideoGrabber1.PlayerFrameCount.ToString());
            Helpers.AddLog(mmoLog, "Frame rate: " + VideoGrabber1.PlayerFrameRate.ToString("0.00"));
            Helpers.AddLog(mmoLog, "size:" + VideoGrabber1.VideoWidth.ToString() + "x" + VideoGrabber1.VideoHeight.ToString());

            if (VideoGrabber1.IsPlaylistActive())
            {
                tabitem_Player.lstPlaylist.SelectedIndex = VideoGrabber1.PlaylistIndex;
            }
        }

        private void VideoGrabber1_OnPlayerEndOfStream(object sender, EventArgs e)
        {
            Helpers.AddLog(mmoLog, "end of stream.");

            if (tabitem_Player.chkLoop.IsChecked == true)
            {
                VideoGrabber1.RunPlayer();
            }
        }

        private void chkPlayerTrackBarSynchrone_CheckedChanged(object sender, RoutedEventArgs e)
        {  
            VideoGrabber1.PlayerTrackBarSynchrone = chkPlayerTrackBarSynchrone.IsChecked == true;
        }

        private void btnPlayBackwards_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.RunPlayerBackwards();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.RunPlayer();
        }

        private void btnFrameStep_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.PlayerFrameStep(1);
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.PausePlayer();
        }

        private void btnFastFwd_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.FastForwardPlayer();
        }

        private void btnFastRew_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.RewindPlayer();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.StopPlayer();
        }

        private void VideoGrabber1_OnPlayerUpdateTrackbarPosition(object sender, VidGrab.TOnFrameProgressEventArgs e)
        {
            sldPlayer.Value = (int)e.frameNumber;
        }

        private void sldPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_MouseDown);
        }

        private void sldPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_MouseUp);
        }

        private void sldPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_KeyDown);
        }

        private void sldPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_KeyUp);
        }

        private void VideoGrabber1_OnPreviewStarted(object sender, EventArgs e)
        {
            Helpers.AddLog(mmoLog, "");
            Helpers.AddLog(mmoLog, "video size: " + VideoGrabber1.VideoWidth.ToString() + " x" + VideoGrabber1.VideoHeight.ToString());
            Helpers.AddLog(mmoLog, "display size: " + VideoGrabber1.Display_VideoWidth.ToString() + " x" + VideoGrabber1.Display_VideoHeight.ToString());
            Helpers.AddLog(mmoLog, "current frame rate: " + VideoGrabber1.CurrentFrameRate.ToString("0.00") + " fps.");
            Helpers.AddLog(mmoLog, "");
        }

        private void VideoGrabber1_OnRecordingPaused(object sender, EventArgs e)
        {
            Helpers.AddLog(mmoLog, "recording paused...");
        }

        private void VideoGrabber1_OnRecordingCompleted(object sender, VidGrab.TOnRecordingCompletedEventArgs e)
        {
            if (e.success)
            {
                Helpers.AddLog(mmoLog, " successfully created.");
                Helpers.AddLog(mmoLog, " size: " + VideoGrabber1.RecordingKBytesWrittenToDisk().ToString() + " KB");
            }
            else
            {
                Helpers.AddLog(mmoLog, "recording failed.");
            }
        }

        private void VideoGrabber1_OnRecordingReadyToStart(object sender, EventArgs e)
        {

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired
            MessageBoxResult result;
            result = MessageBox.Show("\"StartRecording\" was initiated with \"HoldRecording\" enabled,\nfiring the \"OnRecordingReadyToStart\" event.\n\nReady to start recording!", "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                VideoGrabber1.ResumeRecording();
            }
            else
            {
                VideoGrabber1.Stop();
            }

        }

        private void VideoGrabber1_OnRecordingStarted(object sender, VidGrab.TOnFileNotificationEventArgs e)
        {
            Helpers.AddLog(mmoLog, "recording to " + e.fileName + ":");
            Helpers.AddLog(mmoLog, VideoGrabber1.RecordingWidth.ToString() + " x" + VideoGrabber1.RecordingHeight.ToString());
            Helpers.AddLog(mmoLog, "current frame rate: " + VideoGrabber1.CurrentFrameRate.ToString("0.0") + " fps.");
            LastKBWrittenReportTime = 0;
        }

        private void VideoGrabber1_OnReencodingCompleted(object sender, VidGrab.TOnSourceFileToDestFileCompletedEventArgs e)
        {
            if (e.success)
            {
                Helpers.AddLog(mmoLog, " successfully reencoded to " + e.destFile);
            }
            else
            {
                Helpers.AddLog(mmoLog, "Failed to reencode " + e.sourceFile + " to " + e.destFile);
            }
        }

        private void VideoGrabber1_OnReencodingProgress(object sender, VidGrab.TOnProgressEventArgs e)
        {
            Helpers.AddLog(mmoLog, e.percent.ToString() + "% completed...");
        }

        private void VideoGrabber1_OnReencodingStarted(object sender, VidGrab.TOnSourceFileToDestFileStartedEventArgs e)
        {
            Helpers.AddLog(mmoLog, "reencoding " + e.sourceFile + " to " + e.destFile + "...");
        }

        private void VideoGrabber1_OnReinitializing(object sender, EventArgs e)
        {
            mmoLog.Text = "";
        }

        private void VideoGrabber1_SizeChanged(object sender, EventArgs e)
        {
            /* TODO
int NewWidth;
int NewHeight;


NewWidth = VideoGrabber1.Left + VideoGrabber1.VideoWidth + 30;
NewHeight = VideoGrabber1.Top + VideoGrabber1.VideoHeight + 60;
if ((NewWidth >= Width) | (NewHeight >= Height))
{
Width = ((NewWidth < StartupWidth) ? StartupWidth : NewWidth);
Height = ((NewHeight < StartupHeight) ? StartupHeight : NewHeight);
}
else
{
if (NewWidth < StartupWidth)
{
Width = StartupWidth;
}
if (NewHeight < StartupHeight)
{
Height = StartupHeight;
}
}
*/
        }

        private void VideoGrabber1_OnResizeVideo(object sender, VidGrab.TOnResizeVideoEventArgs e)
        {
if (tabitem_VideoProcessing != null) // tabitem_VideoProcessing may ! have been yet created 
{
tabitem_VideoProcessing.trkCroppingX.Maximum = VideoGrabber1.Cropping_XMax;
tabitem_VideoProcessing.trkCroppingX.TickFrequency = (tabitem_VideoProcessing.trkCroppingX.Maximum / 10);
tabitem_VideoProcessing.trkCroppingY.Maximum = VideoGrabber1.Cropping_YMax;
tabitem_VideoProcessing.trkCroppingY.TickFrequency = (tabitem_VideoProcessing.trkCroppingY.Maximum / 10);
}
        }

        private void VideoGrabber1_OnVideoFromBitmapsNextFrameNeeded(object sender, VidGrab.TOnVideoFromBitmapsNextFrameNeededEventArgs e)
        {
            // you can pass to this event:;
            // - either the path to a BMP file or a JPEG file (this is the case in this example);
            // - either a the HBITMAP handle of a bitmap;

            bool EndOfData = false;

            string ImageFile = "";

            if (e.firstSample)
            {
                ImageFile = VideoFromImages.FirstImageFile(); // the initialization is done in VideoFromJPEGsOrBitmaps
                if (ImageFile == "")  // no image file found
                {
                    EndOfData = true;
                }
            }
            else
            {
                ImageFile = VideoFromImages.NextImageFile(); // the initialization is done in VideoFromJPEGsOrBitmaps
                if (ImageFile == "")  // it was the last image
                {
                    EndOfData = true;
                }
            }
            VideoGrabber1.SendImageToVideoFromBitmaps(ImageFile, IntPtr.Zero, false, EndOfData);

        }

        private void VideoGrabber1_OnClientConnection(object sender, VidGrab.TOnClientConnectionEventArgs e)
        {
            if (e.connected)
            {
                Helpers.AddLog(mmoLog, "client connected: " + e.clientInfo);
            }
            else
            {
                Helpers.AddLog(mmoLog, "client disconnected: " + e.clientInfo);
            }
        }

        private void edtStoragePath_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.StoragePath = edtStoragePath.Text;
        }

        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.About();
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void VideoGrabber1_OnGraphBuilt(object sender, EventArgs e)
        {
            tbrZoomX.Minimum = -(VideoGrabber1.VideoWidth / 2);
            tbrZoomX.Maximum = VideoGrabber1.VideoWidth / 2;
            tbrZoomX.Value = 0;
            tbrZoomY.Minimum = -(VideoGrabber1.VideoHeight / 2);
            tbrZoomY.Maximum = VideoGrabber1.VideoHeight / 2;
            tbrZoomY.Value = 0;
        }

        private void VideoGrabber1_OnInactive(object sender, EventArgs e)
        {
            Helpers.AddLog(mmoLog, "(done.)");
        }

        private void mnuResetVideoDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber1.ResetVideoDeviceSettings();
        }

        public class FreeHandDrawing
        {
            public int MAXCOORDINATESARRAY = 5000;
            public bool DrawingEnabled = false;
            public int iArrayCoordinates = 0;
            public System.Drawing.Rectangle[] ArrayCoordinates;

            public FreeHandDrawing()
            {
                ArrayCoordinates = new System.Drawing.Rectangle[MAXCOORDINATESARRAY + 1];
            }
        }

        public class PickupColor
        {
            public bool MustGetRGBPixel = false;
            public int LastRGBPixelValueAtMousePosition = -1;
            public int MouseXVideoPosition = 0;
            public int MouseYVideoPosition = 0;
        }

        private void sldPlayer_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber1.PlayerFramePosition = Convert.ToInt64 (sldPlayer.Value);
        }

        private void tbrZoom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber1.ZoomCoeff = Convert.ToInt32(tbrZoom.Value);
            Helpers.AddLog(mmoLog, VideoGrabber1.ZoomCoeff.ToString());
        }

        private void tbrZoomX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber1.ZoomXCenter = Convert.ToInt32(tbrZoomX.Value);
        }
        private void tbrZoomY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber1.ZoomYCenter = Convert.ToInt32(tbrZoomY.Value);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            VideoGrabber1.PreloadFilters("rtsp");
        }
    }
}




