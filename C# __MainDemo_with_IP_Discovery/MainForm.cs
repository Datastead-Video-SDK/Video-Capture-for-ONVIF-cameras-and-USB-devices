using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using VidGrab;

namespace MainDemo
{
    public partial class MainForm : Form
    {
    
        /// Required designer variable.
        /// 


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
        public Color frmOverlays_btnDrawGridColor;
        public Color frmOverlays_btnFreeHandColor;

        public bool VideoProcessing_DetectNoVideoSignal;
        public bool VideoProcessing_DetectConnexantBlueScreen;

        public bool OldVideoSignalState;

        public VideoFromImagesFileList VideoFromImages;
        public bool VideoFromImagesUsePictureBox;

        public FreeHandDrawing cFreeHandDrawing;
        public PickupColor cPickupColor;

        private double LastKBWrittenReportTime;

        public System.Windows.Forms.Form frmInsetForm;

        private int StartupWidth;
        private int StartupHeight;

        public int StartupVGWidth;
        public int StartupVGHeight;


        private Audio frmAudio;
        private VideoSource frmVideoSource;
        private IPCamera frmIPCamera;
        private MultipurposeEncoder frmMultipurposeEncoder;
        private Display frmDisplay;
        private FrameGrabber frmFrameGrabber;
        private MotionDetection frmMotionDetection;
        private NetworkStreaming frmNetworkStreaming;
        private Overlays frmOverlays;
        private Player frmPlayer;
        public Recording frmRecording;
        private Reencoding frmReencoding;
        private SnapForm frmSnapForm;
        private VideoProcessing frmVideoProcessing;

        public Brush brushMotionRatio;
        public bool boolMotionRatio;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        
        public static MainForm cMainForm;

    
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            cMainForm = this;

            VideoFromImages = new VideoFromImagesFileList();
            VideoFromImagesUsePictureBox = false;

            VideoGrabber1.StoragePath = System.IO.Directory.GetCurrentDirectory();
            VideoGrabber1.Display_AspectRatio = TAspectRatio.ar_Box; // preserves the display aspect ratio
            VideoGrabber1.AutoRefreshPreview = true; // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

            StartupWidth = Width;
            StartupHeight = Height;

            IsVideoGrabberMouseDown = false;
            frmOverlays_edtDrawGrid = 0;
			frmOverlays_drawTarget = false;
            frmOverlays_btnDrawGridColor = Color.Blue;
            frmOverlays_btnFreeHandColor = Color.Red;

            StartupVGWidth = VideoGrabber1.Width;
            StartupVGHeight = VideoGrabber1.Height;

            edtStoragePath.Text = VideoGrabber1.StoragePath;

            cFreeHandDrawing = new FreeHandDrawing();
            cPickupColor = new PickupColor();

            LastKBWrittenReportTime = 0;

            frmAudio = new Audio();
            frmVideoSource = new VideoSource();
            frmIPCamera = new IPCamera();
            frmMultipurposeEncoder = new MultipurposeEncoder();
            frmDisplay = new Display();
            frmFrameGrabber = new FrameGrabber();
            frmMotionDetection = new MotionDetection();
            frmNetworkStreaming = new NetworkStreaming();
            frmOverlays = new Overlays();
            frmPlayer = new Player();
            frmRecording = new Recording();
            frmReencoding = new Reencoding();
            frmSnapForm = new SnapForm();
            frmVideoProcessing = new VideoProcessing();

            frmAudio.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmVideoSource.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmIPCamera.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmMultipurposeEncoder.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmDisplay.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmFrameGrabber.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmMotionDetection.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmNetworkStreaming.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmOverlays.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmPlayer.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmRecording.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmReencoding.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);
            frmVideoProcessing.Closing += new System.ComponentModel.CancelEventHandler(Helpers.SubForm_Closing);

            tbcTabs.SelectedTab = tbpVideoSource;
            SelectInsetForm(tbcTabs);

            RefreshDisplayOptions();

        }

        public void RefreshDisplayOptions()
        {
            frmVideoSource.RefreshDisplayOptions();
            frmIPCamera.RefreshDisplayOptions();
            frmMultipurposeEncoder.RefreshDisplayOptions();
            frmAudio.RefreshDisplayOptions();
            frmDisplay.RefreshDisplayOptions();
            frmFrameGrabber.RefreshDisplayOptions();
            frmMotionDetection.RefreshDisplayOptions();
            frmNetworkStreaming.RefreshDisplayOptions();
            frmOverlays.RefreshDisplayOptions();
            frmPlayer.RefreshDisplayOptions();
            frmRecording.RefreshDisplayOptions();
            frmReencoding.RefreshDisplayOptions();
            frmVideoProcessing.RefreshDisplayOptions();
        }

		private void tbcTabs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SelectInsetForm(tbcTabs);
		}

        public void SelectInsetForm(TabControl Tabs)
        {

            if (frmInsetForm != null)
            {
                frmInsetForm.Close();
            }

            switch (Tabs.SelectedTab.Name)
            {
                case "tbpVideoSource":
                    frmInsetForm = frmVideoSource;
                    break;
                case "tbpIPCameras":
                    frmInsetForm = frmIPCamera;
                    break;
                case "tbpAudio":
                    frmInsetForm = frmAudio;
                    break;
                case "tbpRecording":
                    frmInsetForm = frmRecording;
                    break;
                case "tbpMultipurposeEncoder":
                    frmInsetForm = frmMultipurposeEncoder;
                    break;
                case "tbpNetworkStreaming":
                    frmInsetForm = frmNetworkStreaming;
                    break;
                case "tbpPlayer":
                    frmInsetForm = frmPlayer;
                    break;
                case "tbpFrameGrabber":
                    frmInsetForm = frmFrameGrabber;
                    break;
                case "tbpMotionDetection":
                    frmInsetForm = frmMotionDetection;
                    break;
                case "tbpOverlays":
                    frmInsetForm = frmOverlays;
                    break;
                case "tbpVideoProcessing":
                    frmInsetForm = frmVideoProcessing;
                    break;
                case "tbpDisplay":
                    frmInsetForm = frmDisplay;
                    break;
                case "tbpReencoding":
                    frmInsetForm = frmReencoding;
                    break;
            }

            if (frmInsetForm != null)
            {
                Helpers.InsetForms (ref frmInsetForm, Tabs.SelectedTab.Handle);
                frmInsetForm.Show();
            }

        }

        public void SetEnumerateWindows(string WindowName, bool ExactMatch)
        {
            wenScreenRecordingWindow = new WINDOW_ENUM[1];
            lngScreenRecordingWindow = 0;
            strScreenRecordingWindow = WindowName;
            boolScreenRecordingWindow = ExactMatch;
            frmVideoSource.lblEnumerateWindows.Text = ((strScreenRecordingWindow == "") ? "" : System.Convert.ToString(lngScreenRecordingWindow));
        }

        private void VideoGrabber1_OnEnumerateWindows(object sender, TOnEnumerateWindowsEventArgs e)
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
				wenScreenRecordingWindow[lngScreenRecordingWindow].WindowHandle = (IntPtr) e.windowHandle;
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowClass = e.windowClass;
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowName = e.windowName;
                lngScreenRecordingWindow = lngScreenRecordingWindow + 1;

                frmVideoSource.lblEnumerateWindows.Text = Convert.ToString(lngScreenRecordingWindow);
            }
        }

        public void ChangeVideoSource(TVideoSource VideoSource)
        {
            if (VideoSource != MainForm.cMainForm.VideoGrabber1.VideoSource)
            {
                MainForm.cMainForm.VideoGrabber1.VideoSource = VideoSource;
                string VideoSourceName = TVideoSource.vs_VideoCaptureDevice.ToString();
                switch (VideoSource)
                {
                    case TVideoSource.vs_VideoCaptureDevice:
                        frmVideoSource.cboVideoSource.SelectedIndex = 0;
                        break;
                    case TVideoSource.vs_ScreenRecording:
                        frmVideoSource.cboVideoSource.SelectedIndex = 1;
                        break;
                    case TVideoSource.vs_VideoFileOrURL:
                        frmVideoSource.cboVideoSource.SelectedIndex = 2;
                        break;
                    case TVideoSource.vs_JPEGsOrBitmaps:
                        frmVideoSource.cboVideoSource.SelectedIndex = 3;
                        break;
                    case TVideoSource.vs_IPCamera:
                        frmVideoSource.cboVideoSource.SelectedIndex = 4;
                        break;
                    case TVideoSource.vs_Mixer:
                        frmVideoSource.cboVideoSource.SelectedIndex = 5;
                        break;
                    default:
                        VideoSourceName = "";
                        Helpers.AddLog((MainForm.cMainForm.mmoLog), "VideoSource = " + VideoSource.ToString() + " not used in this demo");
                        break;
                }
                if (VideoSourceName != "")
                {
                    Helpers.AddLog((MainForm.cMainForm.mmoLog), "changing VideoSource to: " + VideoSourceName);

                }
            }
        }


        private void VideoGrabber1_OnVideoDeviceSelected(object sender, System.EventArgs e)
        {
            RefreshDisplayOptions(); // updates all the ComboBox lists and controls, especially those that depend of the video capture device (like VideoInputs, VideoSubtypes, etc...)
        }

        private void VideoGrabber1_OnAudioDeviceSelected(object sender, System.EventArgs e)
        {
            RefreshDisplayOptions(); // updates all the ComboBox lists and controls, especially those that depend of the audio capture device (like AudioInputs, etc...)
        }

        private void VideoGrabber1_OnFrameProgress2(object sender, TOnFrameProgress2EventArgs e)
        {
            TFrameInfo FrameInfo = (TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(TFrameInfo)); 

            if (FrameInfo.currentState == TCurrentState.cs_Playback) // we don't include the dropped frames during playback
            {
                edtFrameCount.Text = String.Format("frame: {0} time:{1:00}:{2:00}:{3:00}:{4:00}", FrameInfo.frameNumber, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs);
            }
            else
            {
                edtFrameCount.Text = String.Format("frame: {0} dropped:{1} time:{2:00}:{3:00}:{4:00}:{5:00}", FrameInfo.frameNumber, FrameInfo.droppedFrameCount, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs);
            }

            if (FrameInfo.NTPFrameTime > 0) 
            {
                edtAdditionalInfo.Text = String.Format("ntp frame time (100ns): {0}", FrameInfo.NTPFrameTime);
            }

            if (VideoGrabber1.CurrentState == TCurrentState.cs_Recording)
            {
                if ((FrameInfo.frameTime - LastKBWrittenReportTime) > 50000000)
                {  // every 5 seconds
                    LastKBWrittenReportTime = FrameInfo.frameTime;
                    Helpers.AddLog(mmoLog, String.Format("written to disk: {0} KB", VideoGrabber1.RecordingKBytesWrittenToDisk()));
                }
            }
        }

        private void VideoGrabber1_OnFrameBitmap(object sender, TOnFrameBitmapEventArgs e)
        {
            // this event is called directly from a thread. Read the (*) comment at the bottom of this page

            // GRID DRAWING
            // ============
            {
                TFrameInfo FrameInfo = (TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(TFrameInfo));
                TFrameBitmapInfo FrameBitmapInfo = (TFrameBitmapInfo)Marshal.PtrToStructure((IntPtr)e.bitmapInfo, typeof(TFrameBitmapInfo));

                if (frmOverlays_drawTarget)
				{
				Graphics MyGraphics = Graphics.FromHdcInternal(FrameBitmapInfo.bitmapDC);

				Pen p = new Pen(Color.Blue);
				SolidBrush b = new SolidBrush(Color.Blue);

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
                    SolidBrush b = new SolidBrush(frmOverlays_btnDrawGridColor);

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
                    Pen p = new Pen(frmOverlays_btnFreeHandColor);
                    SolidBrush b = new SolidBrush(frmOverlays_btnFreeHandColor);

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

        private void VideoGrabber1_OnFrameCaptureCompleted(object sender, TOnFrameCaptureCompletedEventArgs e)
        {
            if (e.success)
            {
                Helpers.AddLog((frmFrameGrabber.mmoFrameCaptureLog), "frame #" + e.frameNumber.ToString() + " captured");
            }

            if ((e.destType == TFrameCaptureDest.fc_JpegFile) || (e.destType == TFrameCaptureDest.fc_BmpFile))
            {
                if (e.success)
                {
                    Helpers.AddLog((frmFrameGrabber.mmoFrameCaptureLog), e.fileName);
                }
                else
                {
                    Helpers.AddLog((frmFrameGrabber.mmoFrameCaptureLog), "error: failed to create " + e.fileName);
                }
            }
            if (e.destType == TFrameCaptureDest.fc_TBitmap)
            {
                if (frmSnapForm.IsDisposed)
                {
                    frmSnapForm = new SnapForm();
                }
                if (!frmSnapForm.Visible)
                {
                    frmSnapForm.Show();
                }
                if (frmSnapForm.SnapImage.Image != null)
                {
                    frmSnapForm.SnapImage.Image.Dispose();
                }
                frmSnapForm.SnapImage.Image = Image.FromHbitmap(e.frameBitmapHandle);
            }
        }

        private void VideoGrabber1_OnCopyPreallocDataCompleted(object sender, TOnSourceFileToDestFileCompletedEventArgs e)
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

        private void VideoGrabber1_OnCopyPreallocDataProgress(object sender, TOnProgressEventArgs e)
        {
            Helpers.AddLog(mmoLog, "copying data: " + e.percent.ToString() + "% completed.");
        }

        private void VideoGrabber1_OnCopyPreallocDataStarted(object sender, TOnSourceFileToDestFileStartedEventArgs e)
        {
            Helpers.AddLog(mmoLog, "copying data from " + e.sourceFile + " to " + e.destFile + "...");
        }

        private void VideoGrabber1_OnCreatePreallocFileCompleted(object sender, TOnCreatePreallocatedFileCompletedEventArgs e)
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

        private void VideoGrabber1_OnCreatePreallocFileProgress(object sender, TOnProgressEventArgs e)
        {
            Helpers.AddLog(mmoLog, e.percent.ToString() + "% of preallocated file completed");
        }

        private void VideoGrabber1_OnCreatePreallocFileStarted(object sender, TOnFileNotificationEventArgs e)
        {
            Helpers.AddLog(mmoLog, "preallocating file " + e.fileName + "...");
        }

        private void VideoGrabber1_OnDeviceArrivalOrRemoval(object sender, TOnDeviceArrivalOrRemovalEventArgs e)
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
                Helpers.AssignListToComboBox(frmVideoSource.cboVideoDevices, VideoGrabber1.VideoDevices, VideoGrabber1.VideoDevice);
            }
            else
            {
                Helpers.AssignListToComboBox(frmAudio.cboAudioDevices, VideoGrabber1.AudioDevices, VideoGrabber1.AudioDevice);
            }
        }

        private void VideoGrabber1_OnDeviceLost(object sender, System.EventArgs e)
        {
            Helpers.AddLog(mmoLog, "DEVICE LOST!");
            Helpers.AssignListToComboBox(frmVideoSource.cboVideoDevices, VideoGrabber1.VideoDevices, VideoGrabber1.VideoDevice);
            Helpers.AssignListToComboBox(frmAudio.cboAudioDevices, VideoGrabber1.AudioDevices, VideoGrabber1.AudioDevice);
        }

        private void VideoGrabber1_OnDirectNetworkStreamingHostUrl(object sender, TOnDirectNetworkStreamingHostUrlEventArgs e)
        {
            Helpers.AddLog(mmoLog, "streaming URL: " + e.hostUrl);
            Helpers.AddLog(mmoLog, "streaming host: " + e.hostName);
            Helpers.AddLog(mmoLog, "streaming port: " + e.hostPort.ToString());
        }

        private void VideoGrabber1_OnDiskFull(object sender, System.EventArgs e)
        {
            Helpers.AddLog(mmoLog, "DISK FULL!");
        }

        private void VideoGrabber1_OnDVCommandCompleted(object sender, TOnDVCommandCompletedEventArgs e)
        {
            Helpers.AddLog(mmoLog, "camcorder state: " + e.newStateLabel);
        }

        private void VideoGrabber1_OnDVDiscontinuity(object sender, TOnDVDiscontinuityEventArgs e)
        {
            // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below);
            // e.deliverNewFrame = false;
            // VideoGrabber1.RecordToNewFileNow();

            // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below);
            // e.deliverNewFrame = false;
            // VideoGrabber1.Stop();

            // read the (*) comment at the bottom of this unit;
        }

        private void VideoGrabber1_OnLog(object sender, TOnLogEventArgs e)
        {
            Helpers.AddLog(mmoLog, "[" + e.severity + "] " + e.infoMsg);
        }

        private void VideoGrabber1_OnMotionDetected(object sender, TOnMotionDetectedEventArgs e)
        {
            int MaxMotionXLocation = 0;
            int MaxMotionYLocation = 0;

            frmMotionDetection.edtMotionRatio.Text = VideoGrabber1.MotionDetector_GlobalMotionRatio.ToString("0.000");

            frmMotionDetection.MotionDetected = true;

            frmMotionDetection.edtMaxMotionXY.Text = "x:" + e.maxMotionCellX.ToString() + " y:" + e.maxMotionCellY.ToString();

            if (VideoGrabber1.MotionDetector_GetCellLocation(e.maxMotionCellX, e.maxMotionCellY, ref MaxMotionXLocation, ref MaxMotionYLocation))
            { 
                frmMotionDetection.edtMaxMotionCoord.Text = "x: " + MaxMotionXLocation.ToString() + "  y: " + MaxMotionYLocation.ToString();
            }

            frmMotionDetection.mmoMotionGrid.Text = VideoGrabber1.MotionDetector_Get2DTextMotion();

            System.IntPtr FrameBitmap = (System.IntPtr) VideoGrabber1.GetLastFrameAsHBITMAP(0, false, 0, 0, 0, 0, frmMotionDetection.imgMotionDetected.Width, frmMotionDetection.imgMotionDetected.Height, 32);
            if (! FrameBitmap.Equals (System.IntPtr.Zero)) {
                frmMotionDetection.imgMotionDetected.Image = Image.FromHbitmap(FrameBitmap);
                Helpers.DeleteObject(FrameBitmap);
            }
        }

        private void VideoGrabber1_OnMotionNotDetected(object sender, TOnMotionNotDetectedEventArgs e)
        {
            frmMotionDetection.edtMotionRatio.Text = "";

            frmMotionDetection.MotionDetected = false;

            frmMotionDetection.mmoMotionGrid.Text = VideoGrabber1.MotionDetector_Get2DTextMotion();
        }

        private void VideoGrabber1_OnMouseDown(object sender, TOnVideoMouseUpDownEventArgs e)
        {
            if (e.videoWindow != -1)  // if (the video is displayed;
            {
				if (frmOverlays.chkTargetAtMouseLocation.Checked) 
				{
					frmOverlays_drawTarget_Location.X = e.x;
					frmOverlays_drawTarget_Location.Y = e.y;
					frmOverlays_drawTarget = true;
				}

                if (frmOverlays.chkFreeHandEnabled.Checked)
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

        private void VideoGrabber1_OnMouseMove(object sender, TOnVideoMouseMoveEventArgs e)
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

        private void VideoGrabber1_OnMouseUp(object sender, TOnVideoMouseUpDownEventArgs e)
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

        private void VideoGrabber1_OnPlayerOpened(object sender, System.EventArgs e)
        {
            tbrPlayer.Minimum = 1;
            tbrPlayer.TickFrequency = 1;
            tbrPlayer.Maximum = (int)VideoGrabber1.PlayerFrameCount;

            Helpers.AddLog(mmoLog, "");
            Helpers.AddLog(mmoLog, "playing " + VideoGrabber1.PlayerFileName);

            if (VideoGrabber1.IsPlayerVideoStreamAvailable == TTriState.ts_True)
            {
                Helpers.AddLog(mmoLog, "this clip has a video stream");
            }
            else if (VideoGrabber1.IsPlayerVideoStreamAvailable == TTriState.ts_False)
            {
                Helpers.AddLog(mmoLog, "this clip does not have video");
            }
            if (VideoGrabber1.IsPlayerAudioStreamAvailable == TTriState.ts_True)
            {
                Helpers.AddLog(mmoLog, "this clip has a Audio stream");
            }
            else if (VideoGrabber1.IsPlayerAudioStreamAvailable == TTriState.ts_False)
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
                frmPlayer.lstPlaylist.SelectedIndex = VideoGrabber1.PlaylistIndex;
            }
        }

        private void VideoGrabber1_OnPlayerEndOfStream(object sender, System.EventArgs e)
        {
            Helpers.AddLog(mmoLog, "end of stream.");

            if (frmPlayer.chkLoop.Checked)
            {
                VideoGrabber1.RunPlayer();
            }
        }

        private void tbrPlayer_Scroll(object sender, System.EventArgs e)
        {
            VideoGrabber1.PlayerFramePosition = tbrPlayer.Value;
        }

        private void chkPlayerTrackBarSynchrone_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber1.PlayerTrackBarSynchrone = chkPlayerTrackBarSynchrone.Checked;
        }

        private void btnPlayBackwards_Click(object sender, EventArgs e)
        {
            VideoGrabber1.RunPlayerBackwards();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            VideoGrabber1.RunPlayer();
        }

        private void btnFrameStep_Click(object sender, EventArgs e)
        {
            VideoGrabber1.PlayerFrameStep(1);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            VideoGrabber1.PausePlayer();
        }

        private void btnFastFwd_Click(object sender, EventArgs e)
        {
            VideoGrabber1.FastForwardPlayer();
        }

        private void btnFastRew_Click(object sender, EventArgs e)
        {
            VideoGrabber1.RewindPlayer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            VideoGrabber1.StopPlayer();
        }

        private void VideoGrabber1_OnPlayerUpdateTrackbarPosition(object sender, TOnFrameProgressEventArgs e)
        {
            tbrPlayer.Value = (int)e.frameNumber;
        }

        private void tbrPlayer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(TTrackbarAction.tba_MouseDown);
        }

        private void tbrPlayer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(TTrackbarAction.tba_MouseUp);
        }

        private void tbrPlayer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(TTrackbarAction.tba_KeyDown);
        }

        private void tbrPlayer_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            VideoGrabber1.NotifyPlayerTrackbarAction(TTrackbarAction.tba_KeyUp);
        }

        private void VideoGrabber1_OnPreviewStarted(object sender, System.EventArgs e)
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

        private void VideoGrabber1_OnRecordingCompleted(object sender, TOnRecordingCompletedEventArgs e)
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

        private void VideoGrabber1_OnRecordingReadyToStart(object sender, System.EventArgs e)
        {

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired
            DialogResult result;
            result = MessageBox.Show("\"StartRecording\" was initiated with \"HoldRecording\" enabled,\nfiring the \"OnRecordingReadyToStart\" event.\n\nReady to start recording!", "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if ((VideoGrabber1.VideoSource == TVideoSource.vs_ScreenRecording) & (frmRecording.chkScreenRecordWindow.Checked == true) & (lngScreenRecordingWindow > 0))
                {
                    // for screen recording of a window, this code will make it the top window before recording start;
                    //  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                    // (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                    Helpers.MakeTopWindow(MainForm.cMainForm.wenScreenRecordingWindow[MainForm.cMainForm.lngScreenRecordingWindow - 1].WindowHandle);
                }
                VideoGrabber1.ResumeRecording();
            }
            else
            {
                VideoGrabber1.Stop();
            }

        }

        private void VideoGrabber1_OnRecordingStarted(object sender, TOnFileNotificationEventArgs e)
        {
            Helpers.AddLog(mmoLog, "recording to " + e.fileName + ":");
            Helpers.AddLog(mmoLog, VideoGrabber1.RecordingWidth.ToString() + " x" + VideoGrabber1.RecordingHeight.ToString());
            Helpers.AddLog(mmoLog, "current frame rate: " + VideoGrabber1.CurrentFrameRate.ToString("0.0") + " fps.");
            frmRecording.btnRenewRecordingFile.Enabled = true;
            LastKBWrittenReportTime = 0;
        }

        private void VideoGrabber1_OnReencodingCompleted(object sender, TOnSourceFileToDestFileCompletedEventArgs e)
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

        private void VideoGrabber1_OnReencodingProgress(object sender, TOnProgressEventArgs e)
        {
            Helpers.AddLog(mmoLog, e.percent.ToString() + "% completed...");
        }

        private void VideoGrabber1_OnReencodingStarted(object sender, TOnSourceFileToDestFileStartedEventArgs e)
        {
            Helpers.AddLog(mmoLog, "reencoding " + e.sourceFile + " to " + e.destFile + "...");
        }

        private void VideoGrabber1_OnReinitializing(object sender, System.EventArgs e)
        {
            mmoLog.Text = "";
        }

        private void VideoGrabber1_SizeChanged(object sender, System.EventArgs e)
        {
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
        }

        private void VideoGrabber1_OnResizeVideo(object sender, TOnResizeVideoEventArgs e)
        {
            if (frmVideoProcessing != null) // frmVideoProcessing may ! have been yet created 
            {
                frmVideoProcessing.trkCroppingX.Maximum = VideoGrabber1.Cropping_XMax;
                frmVideoProcessing.trkCroppingX.TickFrequency = (frmVideoProcessing.trkCroppingX.Maximum / 10);
                frmVideoProcessing.trkCroppingY.Maximum = VideoGrabber1.Cropping_YMax;
                frmVideoProcessing.trkCroppingY.TickFrequency = (frmVideoProcessing.trkCroppingY.Maximum / 10);
            }
        }

        private void VideoGrabber1_OnVideoFromBitmapsNextFrameNeeded(object sender, TOnVideoFromBitmapsNextFrameNeededEventArgs e)
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

        private void VideoGrabber1_OnClientConnection(object sender, TOnClientConnectionEventArgs e)
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

        private void edtStoragePath_TextChanged(object sender, System.EventArgs e)
        {
            VideoGrabber1.StoragePath = edtStoragePath.Text;
        }

        private void mnuAbout_Click(object sender, System.EventArgs e)
        {
            VideoGrabber1.About();
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void VideoGrabber1_OnGraphBuilt(object sender, System.EventArgs e)
        {
            tbrZoomX.Minimum = -(VideoGrabber1.VideoWidth / 2);
            tbrZoomX.Maximum = VideoGrabber1.VideoWidth / 2;
            tbrZoomX.Value = 0;
            tbrZoomY.Minimum = -(VideoGrabber1.VideoHeight / 2);
            tbrZoomY.Maximum = VideoGrabber1.VideoHeight / 2;
            tbrZoomY.Value = 0;
        }

        private void VideoGrabber1_OnInactive(object sender, System.EventArgs e)
        {
            Helpers.AddLog(mmoLog, "(done.)");
        }

        private void mnuResetVideoDeviceSettings_Click(object sender, EventArgs e)
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

        private void tbrZoom_Scroll(object sender, EventArgs e)
        {
            VideoGrabber1.ZoomCoeff = tbrZoom.Value;
        }

        private void tbrZoomX_Scroll(object sender, EventArgs e)
        {
            VideoGrabber1.ZoomXCenter = tbrZoomX.Value;

        }

        private void tbrZoomY_Scroll(object sender, EventArgs e)
        {
            VideoGrabber1.ZoomYCenter = tbrZoomY.Value;
        }

        private void VideoGrabber1_OnONVIFDiscoveryCompleted(object sender, TOnONVIFDiscoveryCompletedNotificationEventArgs e)
        {
            if ((e.discoveryCallbackStatus == TDiscoveryCallbackStatus.dcs_IPRangeCompleted) || (e.discoveryCallbackStatus == TDiscoveryCallbackStatus.dcs_MulticastCompleted)) {
                int iCamera = 0;
                IntPtr pCameraType;
                IntPtr pCameraServiceUrl;
                while (VideoGrabber1.ONVIFEnumCamerasDiscovered(iCamera, out pCameraType,  out pCameraServiceUrl))
                {
                    string CameraType = Marshal.PtrToStringAuto(pCameraType);
                    string CameraServiceUrl = Marshal.PtrToStringAuto(pCameraServiceUrl);
                    string CameraInfo = "[ " + CameraType + " ] " + CameraServiceUrl;
                    if (!frmIPCamera.lbxCamerasDiscovered.Items.Equals(CameraInfo))
                    {
                        frmIPCamera.lbxCamerasDiscovered.Items.Add(CameraInfo);
                    }
                    iCamera++;
                }
            }
        }
    }
}

//(*) From this event you should not perform any actions with the potential to block:
//    1. do not hold a critical section or wait on another thread,
//    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
//    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
//       of a ListBox component. If you need to read a such property, set an intermediary variable when
//       the property changes, and then read the intermediary variable from this event.
