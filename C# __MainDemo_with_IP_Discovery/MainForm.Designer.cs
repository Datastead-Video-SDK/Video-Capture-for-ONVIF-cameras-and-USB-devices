using System.Windows.Forms;

namespace MainDemo
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VideoGrabber1 = new VidGrab.VideoGrabber();
            this.mmoLog = new System.Windows.Forms.TextBox();
            this.edtAdditionalInfo = new System.Windows.Forms.TextBox();
            this.edtFrameCount = new System.Windows.Forms.TextBox();
            this.edtStoragePath = new System.Windows.Forms.TextBox();
            this.gbPlayerControl = new System.Windows.Forms.GroupBox();
            this.btnFrameStep = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFastFwd = new System.Windows.Forms.Button();
            this.btnFastRew = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlayBackwards = new System.Windows.Forms.Button();
            this.tbrPlayer = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkPlayerTrackBarSynchrone = new System.Windows.Forms.CheckBox();
            this.tbrZoom = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrZoomX = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpReencoding = new System.Windows.Forms.TabPage();
            this.tbpDisplay = new System.Windows.Forms.TabPage();
            this.tbpVideoProcessing = new System.Windows.Forms.TabPage();
            this.tbpOverlays = new System.Windows.Forms.TabPage();
            this.tbpMotionDetection = new System.Windows.Forms.TabPage();
            this.tbpFrameGrabber = new System.Windows.Forms.TabPage();
            this.tbpPlayer = new System.Windows.Forms.TabPage();
            this.tbpNetworkStreaming = new System.Windows.Forms.TabPage();
            this.tbpMultipurposeEncoder = new System.Windows.Forms.TabPage();
            this.tbpRecording = new System.Windows.Forms.TabPage();
            this.tbpAudio = new System.Windows.Forms.TabPage();
            this.tbpIPCameras = new System.Windows.Forms.TabPage();
            this.tbpVideoSource = new System.Windows.Forms.TabPage();
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tbrZoomY = new System.Windows.Forms.TrackBar();
            this.gbPlayerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).BeginInit();
            this.tbcTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomY)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoGrabber1
            // 
            this.VideoGrabber1.AdjustOverlayAspectRatio = true;
            this.VideoGrabber1.AdjustPixelAspectRatio = true;
            this.VideoGrabber1.Aero = VidGrab.TAero.ae_Default;
            this.VideoGrabber1.AnalogVideoStandard = -1;
            this.VideoGrabber1.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.VideoGrabber1.ASFAudioBitRate = -1;
            this.VideoGrabber1.ASFAudioChannels = -1;
            this.VideoGrabber1.ASFBufferWindow = -1;
            this.VideoGrabber1.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.VideoGrabber1.ASFDirectStreamingKeepClientsConnected = false;
            this.VideoGrabber1.ASFFixedFrameRate = true;
            this.VideoGrabber1.ASFMediaServerPublishingPoint = "";
            this.VideoGrabber1.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.VideoGrabber1.ASFMediaServerTemplatePublishingPoint = "";
            this.VideoGrabber1.ASFNetworkMaxUsers = 5;
            this.VideoGrabber1.ASFNetworkPort = 0;
            this.VideoGrabber1.ASFProfile = -1;
            this.VideoGrabber1.ASFProfileFromCustomFile = "";
            this.VideoGrabber1.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.VideoGrabber1.ASFVideoBitRate = -1;
            this.VideoGrabber1.ASFVideoFrameRate = 0D;
            this.VideoGrabber1.ASFVideoHeight = -1;
            this.VideoGrabber1.ASFVideoMaxKeyFrameSpacing = -1;
            this.VideoGrabber1.ASFVideoQuality = -1;
            this.VideoGrabber1.ASFVideoWidth = -1;
            this.VideoGrabber1.AspectRatioToUse = -1D;
            this.VideoGrabber1.AssociateAudioAndVideoDevices = false;
            this.VideoGrabber1.AudioBalance = 0;
            this.VideoGrabber1.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru;
            this.VideoGrabber1.AudioCompressor = 0;
            this.VideoGrabber1.AudioDevice = -1;
            this.VideoGrabber1.AudioDeviceRendering = false;
            this.VideoGrabber1.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.VideoGrabber1.AudioInput = -1;
            this.VideoGrabber1.AudioInputBalance = 0;
            this.VideoGrabber1.AudioInputLevel = 65535;
            this.VideoGrabber1.AudioInputMono = false;
            this.VideoGrabber1.AudioPeakEvent = true;
            this.VideoGrabber1.AudioRecording = false;
            this.VideoGrabber1.AudioRenderer = -1;
            this.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default;
            this.VideoGrabber1.AudioStreamNumber = -1;
            this.VideoGrabber1.AudioSyncAdjustment = 0;
            this.VideoGrabber1.AudioSyncAdjustmentEnabled = false;
            this.VideoGrabber1.AudioVolume = 32767;
            this.VideoGrabber1.AudioVolumeEnabled = true;
            this.VideoGrabber1.AutoConnectRelatedPins = true;
            this.VideoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.VideoGrabber1.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.VideoGrabber1.AutoFileNameMinDigits = 6;
            this.VideoGrabber1.AutoFilePrefix = "vg";
            this.VideoGrabber1.AutoFileSuffix = "";
            this.VideoGrabber1.AutoRefreshPreview = false;
            this.VideoGrabber1.AutoStartPlayer = true;
            this.VideoGrabber1.AVIDurationUpdated = true;
            this.VideoGrabber1.AVIFormatOpenDML = true;
            this.VideoGrabber1.AVIFormatOpenDMLCompatibilityIndex = true;
            this.VideoGrabber1.BackColor = System.Drawing.Color.DarkGray;
            this.VideoGrabber1.BackgroundColor = 0;
            this.VideoGrabber1.BufferCount = -1;
            this.VideoGrabber1.BurstCount = 3;
            this.VideoGrabber1.BurstInterval = 0;
            this.VideoGrabber1.BurstMode = false;
            this.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.VideoGrabber1.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.VideoGrabber1.CameraControlSettings = true;
            this.VideoGrabber1.CaptureFileExt = "";
            this.VideoGrabber1.ColorKey = 1048592;
            this.VideoGrabber1.ColorKeyEnabled = false;
            this.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
            this.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.VideoGrabber1.Cropping_Enabled = false;
            this.VideoGrabber1.Cropping_Height = 120;
            this.VideoGrabber1.Cropping_Outbounds = true;
            this.VideoGrabber1.Cropping_Width = 160;
            this.VideoGrabber1.Cropping_X = 0;
            this.VideoGrabber1.Cropping_Y = 0;
            this.VideoGrabber1.Cropping_Zoom = 1D;
            this.VideoGrabber1.Display_Active = true;
            this.VideoGrabber1.Display_AlphaBlendEnabled = false;
            this.VideoGrabber1.Display_AlphaBlendValue = 180;
            this.VideoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.VideoGrabber1.Display_AutoSize = false;
            this.VideoGrabber1.Display_Embedded = true;
            this.VideoGrabber1.Display_Embedded_FitParent = false;
            this.VideoGrabber1.Display_FullScreen = false;
            this.VideoGrabber1.Display_Height = 720;
            this.VideoGrabber1.Display_Left = 10;
            this.VideoGrabber1.Display_Monitor = 0;
            this.VideoGrabber1.Display_MouseMovesWindow = true;
            this.VideoGrabber1.Display_PanScanRatio = 50;
            this.VideoGrabber1.Display_StayOnTop = false;
            this.VideoGrabber1.Display_Top = 10;
            this.VideoGrabber1.Display_TransparentColorEnabled = false;
            this.VideoGrabber1.Display_TransparentColorValue = 255;
            this.VideoGrabber1.Display_VideoPortEnabled = true;
            this.VideoGrabber1.Display_Visible = true;
            this.VideoGrabber1.Display_Width = 1280;
            this.VideoGrabber1.DoubleBuffered = false;
            this.VideoGrabber1.DroppedFramesPollingInterval = -1;
            this.VideoGrabber1.DualDisplay_Active = false;
            this.VideoGrabber1.DualDisplay_AlphaBlendEnabled = false;
            this.VideoGrabber1.DualDisplay_AlphaBlendValue = 180;
            this.VideoGrabber1.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.VideoGrabber1.DualDisplay_AutoSize = false;
            this.VideoGrabber1.DualDisplay_Embedded = false;
            this.VideoGrabber1.DualDisplay_Embedded_FitParent = false;
            this.VideoGrabber1.DualDisplay_FullScreen = false;
            this.VideoGrabber1.DualDisplay_Height = 720;
            this.VideoGrabber1.DualDisplay_Left = 20;
            this.VideoGrabber1.DualDisplay_Monitor = 0;
            this.VideoGrabber1.DualDisplay_MouseMovesWindow = true;
            this.VideoGrabber1.DualDisplay_PanScanRatio = 50;
            this.VideoGrabber1.DualDisplay_StayOnTop = false;
            this.VideoGrabber1.DualDisplay_Top = 400;
            this.VideoGrabber1.DualDisplay_TransparentColorEnabled = false;
            this.VideoGrabber1.DualDisplay_TransparentColorValue = 255;
            this.VideoGrabber1.DualDisplay_VideoPortEnabled = false;
            this.VideoGrabber1.DualDisplay_Visible = true;
            this.VideoGrabber1.DualDisplay_Width = 1280;
            this.VideoGrabber1.DVDateTimeEnabled = true;
            this.VideoGrabber1.DVDiscontinuityMinimumInterval = 3;
            this.VideoGrabber1.DVDTitle = 0;
            this.VideoGrabber1.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.VideoGrabber1.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.VideoGrabber1.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.VideoGrabber1.DVRecordingInNativeFormatSeparatesStreams = false;
            this.VideoGrabber1.DVReduceFrameRate = false;
            this.VideoGrabber1.DVRgb219 = false;
            this.VideoGrabber1.DVTimeCodeEnabled = false;
            this.VideoGrabber1.EventNotificationSynchrone = true;
            this.VideoGrabber1.ExtraDLLPath = "";
            this.VideoGrabber1.FixFlickerOrBlackCapture = false;
            this.VideoGrabber1.FrameCaptureHeight = -1;
            this.VideoGrabber1.FrameCaptureWidth = -1;
            this.VideoGrabber1.FrameCaptureWithoutOverlay = false;
            this.VideoGrabber1.FrameCaptureZoomSize = 100;
            this.VideoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.VideoGrabber1.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.VideoGrabber1.FrameNumberStartsFromZero = false;
            this.VideoGrabber1.FrameRate = 0D;
            this.VideoGrabber1.FrameRateDivider = 0;
            this.VideoGrabber1.GetLastFrameWaitTimeoutMs = 0;
            this.VideoGrabber1.HoldRecording = false;
            this.VideoGrabber1.ImageOverlay_AlphaBlend = false;
            this.VideoGrabber1.ImageOverlay_AlphaBlendValue = 180;
            this.VideoGrabber1.ImageOverlay_ChromaKey = false;
            this.VideoGrabber1.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.VideoGrabber1.ImageOverlay_ChromaKeyRGBColor = 0;
            this.VideoGrabber1.ImageOverlay_Height = -1;
            this.VideoGrabber1.ImageOverlay_LeftLocation = 10;
            this.VideoGrabber1.ImageOverlay_RotationAngle = 0D;
            this.VideoGrabber1.ImageOverlay_StretchToVideoSize = false;
            this.VideoGrabber1.ImageOverlay_TargetDisplay = -1;
            this.VideoGrabber1.ImageOverlay_TopLocation = 10;
            this.VideoGrabber1.ImageOverlay_Transparent = false;
            this.VideoGrabber1.ImageOverlay_TransparentColorValue = 0;
            this.VideoGrabber1.ImageOverlay_UseTransparentColor = false;
            this.VideoGrabber1.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.VideoGrabber1.ImageOverlay_Width = -1;
            this.VideoGrabber1.ImageOverlayEnabled = false;
            this.VideoGrabber1.ImageOverlaySelector = 0;
            this.VideoGrabber1.IPCameraURL = "";
            this.VideoGrabber1.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.VideoGrabber1.JPEGProgressiveDisplay = false;
            this.VideoGrabber1.JPEGQuality = 100;
            this.VideoGrabber1.LicenseString = "N/A";
            this.VideoGrabber1.Location = new System.Drawing.Point(400, 542);
            this.VideoGrabber1.LogoDisplayed = false;
            this.VideoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.VideoGrabber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoGrabber1.MixAudioSamples_CurrentSourceLevel = 100;
            this.VideoGrabber1.MixAudioSamples_ExternalSourceLevel = 100;
            this.VideoGrabber1.Mixer_MosaicColumns = 1;
            this.VideoGrabber1.Mixer_MosaicLines = 1;
            this.VideoGrabber1.MotionDetector_CompareBlue = true;
            this.VideoGrabber1.MotionDetector_CompareGreen = true;
            this.VideoGrabber1.MotionDetector_CompareRed = true;
            this.VideoGrabber1.MotionDetector_Enabled = false;
            this.VideoGrabber1.MotionDetector_GreyScale = false;
            this.VideoGrabber1.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
    "555555 5555555555 5555555555";
            this.VideoGrabber1.MotionDetector_MaxDetectionsPerSecond = 0D;
            this.VideoGrabber1.MotionDetector_MotionResetMs = 0;
            this.VideoGrabber1.MotionDetector_ReduceCPULoad = 1;
            this.VideoGrabber1.MotionDetector_ReduceVideoNoise = false;
            this.VideoGrabber1.MotionDetector_Triggered = false;
            this.VideoGrabber1.MouseWheelControlsZoomAtCursor = false;
            this.VideoGrabber1.MouseWheelEventEnabled = true;
            this.VideoGrabber1.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default;
            this.VideoGrabber1.MultiplexedInputEmulation = true;
            this.VideoGrabber1.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.VideoGrabber1.MultiplexedStabilizationDelay = 100;
            this.VideoGrabber1.MultiplexedSwitchDelay = 0;
            this.VideoGrabber1.Multiplexer = -1;
            this.VideoGrabber1.MuteAudioRendering = false;
            this.VideoGrabber1.Name = "VideoGrabber1";
            this.VideoGrabber1.NDIBandwidthType = VidGrab.TNDIBandwidthType.nbt_HighestBandwidth;
            this.VideoGrabber1.NDIGroups = "";
            this.VideoGrabber1.NDIName = "DATASTEAD_UNNAMED_SOURCE";
            this.VideoGrabber1.NDIReceiveTimeoutMs = 5000;
            this.VideoGrabber1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.VideoGrabber1.NormalCursor = VidGrab.TCursors.cr_Default;
            this.VideoGrabber1.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.VideoGrabber1.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.VideoGrabber1.NotificationSleepTime = -1;
            this.VideoGrabber1.OnFrameBitmapEventSynchrone = false;
            this.VideoGrabber1.OpenURLAsync = true;
            this.VideoGrabber1.OverlayAfterTransform = false;
            this.VideoGrabber1.OwnerObject = null;
            this.VideoGrabber1.PlayerAudioRendering = true;
            this.VideoGrabber1.PlayerDuration = ((long)(1));
            this.VideoGrabber1.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.VideoGrabber1.PlayerFastSeekSpeedRatio = 4;
            this.VideoGrabber1.PlayerFileName = "";
            this.VideoGrabber1.PlayerForcedCodec = "";
            this.VideoGrabber1.PlayerFramePosition = ((long)(1));
            this.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            this.VideoGrabber1.PlayerRefreshPausedDisplay = false;
            this.VideoGrabber1.PlayerRefreshPausedDisplayFrameRate = 0D;
            this.VideoGrabber1.PlayerSpeedRatio = 1D;
            this.VideoGrabber1.PlayerSpeedRatioConstantAudioPitch = true;
            this.VideoGrabber1.PlayerTimePosition = ((long)(0));
            this.VideoGrabber1.PlayerTrackBarSynchrone = false;
            this.VideoGrabber1.PlaylistIndex = 0;
            this.VideoGrabber1.PreallocCapFileCopiedAfterRecording = true;
            this.VideoGrabber1.PreallocCapFileEnabled = false;
            this.VideoGrabber1.PreallocCapFileName = "";
            this.VideoGrabber1.PreallocCapFileSizeInMB = 100;
            this.VideoGrabber1.PreviewZoomSize = 100;
            this.VideoGrabber1.QuickDeviceInitialization = false;
            this.VideoGrabber1.RawAudioSampleCapture = false;
            this.VideoGrabber1.RawCaptureAsyncEvent = true;
            this.VideoGrabber1.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.VideoGrabber1.RawVideoSampleCapture = false;
            this.VideoGrabber1.RecordingAudioBitRate = -1;
            this.VideoGrabber1.RecordingBacktimedFramesCount = 0;
            this.VideoGrabber1.RecordingCanPause = false;
            this.VideoGrabber1.RecordingFileName = "";
            this.VideoGrabber1.RecordingFileSizeMaxInMB = 0;
            this.VideoGrabber1.RecordingInNativeFormat = true;
            this.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
            this.VideoGrabber1.RecordingOnMotion_Enabled = false;
            this.VideoGrabber1.RecordingOnMotion_MotionThreshold = 0D;
            this.VideoGrabber1.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.VideoGrabber1.RecordingPauseCreatesNewFile = false;
            this.VideoGrabber1.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.VideoGrabber1.RecordingTimerInterval = 60;
            this.VideoGrabber1.RecordingVideoBitRate = -1;
            this.VideoGrabber1.Reencoding_IncludeAudioStream = true;
            this.VideoGrabber1.Reencoding_IncludeVideoStream = true;
            this.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.VideoGrabber1.Reencoding_NewVideoClip = "";
            this.VideoGrabber1.Reencoding_SourceVideoClip = "";
            this.VideoGrabber1.Reencoding_StartFrame = ((long)(-1));
            this.VideoGrabber1.Reencoding_StartTime = ((long)(-1));
            this.VideoGrabber1.Reencoding_StopFrame = ((long)(-1));
            this.VideoGrabber1.Reencoding_StopTime = ((long)(-1));
            this.VideoGrabber1.Reencoding_UseAudioCompressor = false;
            this.VideoGrabber1.Reencoding_UseFrameGrabber = true;
            this.VideoGrabber1.Reencoding_UseVideoCompressor = false;
            this.VideoGrabber1.Reencoding_WMVOutput = false;
            this.VideoGrabber1.ScreenRecordingLayeredWindows = false;
            this.VideoGrabber1.ScreenRecordingMonitor = 0;
            this.VideoGrabber1.ScreenRecordingNonVisibleWindows = false;
            this.VideoGrabber1.ScreenRecordingSizePercent = 100;
            this.VideoGrabber1.ScreenRecordingThroughClipboard = false;
            this.VideoGrabber1.ScreenRecordingWithCursor = true;
            this.VideoGrabber1.SendToDV_DeviceIndex = -1;
            this.VideoGrabber1.Size = new System.Drawing.Size(808, 404);
            this.VideoGrabber1.SpeakerBalance = 32762;
            this.VideoGrabber1.SpeakerControl = false;
            this.VideoGrabber1.SpeakerVolume = 65535;
            this.VideoGrabber1.StoragePath = "C:\\Users\\Michel_2\\AppData\\Local\\Temp\\";
            this.VideoGrabber1.StoragePathMode = VidGrab.TStoragePathMode.spm_AutoFileNameOnly;
            this.VideoGrabber1.StoreDeviceSettingsInRegistry = true;
            this.VideoGrabber1.StreamInterface_Format = "mpegts";
            this.VideoGrabber1.StreamInterface_FrameRate = 0D;
            this.VideoGrabber1.StreamInterface_IsRealTime = true;
            this.VideoGrabber1.SyncCommands = true;
            this.VideoGrabber1.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.VideoGrabber1.Synchronized = false;
            this.VideoGrabber1.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.VideoGrabber1.TabIndex = 0;
            this.VideoGrabber1.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.VideoGrabber1.TextOverlay_AlphaBlend = false;
            this.VideoGrabber1.TextOverlay_AlphaBlendValue = 180;
            this.VideoGrabber1.TextOverlay_BkColor = 16777215;
            this.VideoGrabber1.TextOverlay_Enabled = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.VideoGrabber1.TextOverlay_FontColor = 16776960;
            this.VideoGrabber1.TextOverlay_FontSize = 12;
            this.VideoGrabber1.TextOverlay_GradientColor = 8388608;
            this.VideoGrabber1.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.VideoGrabber1.TextOverlay_HighResFont = true;
            this.VideoGrabber1.TextOverlay_Left = 0;
            this.VideoGrabber1.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.VideoGrabber1.TextOverlay_Right = -1;
            this.VideoGrabber1.TextOverlay_Scrolling = false;
            this.VideoGrabber1.TextOverlay_ScrollingSpeed = 1;
            this.VideoGrabber1.TextOverlay_Selector = 0;
            this.VideoGrabber1.TextOverlay_Shadow = true;
            this.VideoGrabber1.TextOverlay_ShadowColor = 0;
            this.VideoGrabber1.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.VideoGrabber1.TextOverlay_String = resources.GetString("VideoGrabber1.TextOverlay_String");
            this.VideoGrabber1.TextOverlay_TargetDisplay = -1;
            this.VideoGrabber1.TextOverlay_Top = 0;
            this.VideoGrabber1.TextOverlay_Transparent = true;
            this.VideoGrabber1.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.VideoGrabber1.ThirdPartyDeinterlacer = "";
            this.VideoGrabber1.TranslateMouseCoordinates = true;
            this.VideoGrabber1.TunerFrequency = -1;
            this.VideoGrabber1.TunerMode = VidGrab.TTunerMode.tm_TVTuner;
            this.VideoGrabber1.TVChannel = 0;
            this.VideoGrabber1.TVCountryCode = 0;
            this.VideoGrabber1.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable;
            this.VideoGrabber1.TVUseFrequencyOverrides = false;
            this.VideoGrabber1.UseClock = true;
            this.VideoGrabber1.v360_AspectRatio = 0D;
            this.VideoGrabber1.v360_Enabled = false;
            this.VideoGrabber1.v360_MasterAngle = VidGrab.Tv360_Angle.v360_fov_Horizontal;
            this.VideoGrabber1.v360_MouseAction = VidGrab.TV360_MouseAction.ma_MouseMove;
            this.VideoGrabber1.v360_MouseActionPercent = 10;
            this.VideoGrabber1.VCRHorizontalLocking = false;
            this.VideoGrabber1.Version = "v15.4.1.0 (build 5047.240513) - Copyright (c)2024 Datastead";
            this.VideoGrabber1.VideoCompression_DataRate = -1;
            this.VideoGrabber1.VideoCompression_KeyFrameRate = 15;
            this.VideoGrabber1.VideoCompression_PFramesPerKeyFrame = 0;
            this.VideoGrabber1.VideoCompression_Quality = 1D;
            this.VideoGrabber1.VideoCompression_WindowSize = -1;
            this.VideoGrabber1.VideoCompressor = 0;
            this.VideoGrabber1.VideoControlSettings = true;
            this.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default;
            this.VideoGrabber1.VideoDelay = ((long)(0));
            this.VideoGrabber1.VideoDevice = -1;
            this.VideoGrabber1.VideoFormat = -1;
            this.VideoGrabber1.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.VideoGrabber1.VideoFromImages_RepeatIndefinitely = false;
            this.VideoGrabber1.VideoFromImages_SourceDirectory = "C:\\Users\\Michel_2\\AppData\\Local\\Temp\\";
            this.VideoGrabber1.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.VideoGrabber1.VideoInput = -1;
            this.VideoGrabber1.VideoProcessing_Brightness = 0;
            this.VideoGrabber1.VideoProcessing_Contrast = 0;
            this.VideoGrabber1.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.VideoGrabber1.VideoProcessing_FlipHorizontal = false;
            this.VideoGrabber1.VideoProcessing_FlipVertical = false;
            this.VideoGrabber1.VideoProcessing_GrayScale = false;
            this.VideoGrabber1.VideoProcessing_Hue = 0;
            this.VideoGrabber1.VideoProcessing_InvertColors = false;
            this.VideoGrabber1.VideoProcessing_Pixellization = 1;
            this.VideoGrabber1.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.VideoGrabber1.VideoProcessing_RotationCustomAngle = 45.5D;
            this.VideoGrabber1.VideoProcessing_Saturation = 0;
            this.VideoGrabber1.VideoQualitySettings = true;
            this.VideoGrabber1.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.VideoGrabber1.VideoRendererExternalIndex = -1;
            this.VideoGrabber1.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.VideoGrabber1.VideoSize = -1;
            this.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.VideoGrabber1.VideoSource_FileOrURL = "";
            this.VideoGrabber1.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.VideoGrabber1.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.VideoGrabber1.VideoStreamNumber = -1;
            this.VideoGrabber1.VideoSubtype = -1;
            this.VideoGrabber1.VideoVisibleWhenStopped = false;
            this.VideoGrabber1.VirtualAudioStreamControl = -1;
            this.VideoGrabber1.VirtualVideoStreamControl = -1;
            this.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.VideoGrabber1.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.VideoGrabber1.ZoomCoeff = 1000;
            this.VideoGrabber1.ZoomXCenter = 0;
            this.VideoGrabber1.ZoomYCenter = 0;
            this.VideoGrabber1.OnAudioDeviceSelected += new System.EventHandler(this.VideoGrabber1_OnAudioDeviceSelected);
            this.VideoGrabber1.OnClientConnection += new VidGrab.OnClientConnectionEventHandler(this.VideoGrabber1_OnClientConnection);
            this.VideoGrabber1.OnCopyPreallocDataCompleted += new VidGrab.OnCopyPreallocDataCompletedEventHandler(this.VideoGrabber1_OnCopyPreallocDataCompleted);
            this.VideoGrabber1.OnCopyPreallocDataProgress += new VidGrab.OnCopyPreallocDataProgressEventHandler(this.VideoGrabber1_OnCopyPreallocDataProgress);
            this.VideoGrabber1.OnCopyPreallocDataStarted += new VidGrab.OnCopyPreallocDataStartedEventHandler(this.VideoGrabber1_OnCopyPreallocDataStarted);
            this.VideoGrabber1.OnCreatePreallocFileCompleted += new VidGrab.OnCreatePreallocFileCompletedEventHandler(this.VideoGrabber1_OnCreatePreallocFileCompleted);
            this.VideoGrabber1.OnCreatePreallocFileProgress += new VidGrab.OnCreatePreallocFileProgressEventHandler(this.VideoGrabber1_OnCreatePreallocFileProgress);
            this.VideoGrabber1.OnCreatePreallocFileStarted += new VidGrab.OnCreatePreallocFileStartedEventHandler(this.VideoGrabber1_OnCreatePreallocFileStarted);
            this.VideoGrabber1.OnDeviceArrivalOrRemoval += new VidGrab.OnDeviceArrivalOrRemovalEventHandler(this.VideoGrabber1_OnDeviceArrivalOrRemoval);
            this.VideoGrabber1.OnDeviceLost += new System.EventHandler(this.VideoGrabber1_OnDeviceLost);
            this.VideoGrabber1.OnDirectNetworkStreamingHostUrl += new VidGrab.OnDirectNetworkStreamingHostUrlEventHandler(this.VideoGrabber1_OnDirectNetworkStreamingHostUrl);
            this.VideoGrabber1.OnDiskFull += new System.EventHandler(this.VideoGrabber1_OnDiskFull);
            this.VideoGrabber1.OnDVCommandCompleted += new VidGrab.OnDVCommandCompletedEventHandler(this.VideoGrabber1_OnDVCommandCompleted);
            this.VideoGrabber1.OnDVDiscontinuity += new VidGrab.OnDVDiscontinuityEventHandler(this.VideoGrabber1_OnDVDiscontinuity);
            this.VideoGrabber1.OnEnumerateWindows += new VidGrab.OnEnumerateWindowsEventHandler(this.VideoGrabber1_OnEnumerateWindows);
            this.VideoGrabber1.OnFrameBitmap += new VidGrab.OnFrameBitmapEventHandler(this.VideoGrabber1_OnFrameBitmap);
            this.VideoGrabber1.OnFrameCaptureCompleted += new VidGrab.OnFrameCaptureCompletedEventHandler(this.VideoGrabber1_OnFrameCaptureCompleted);
            this.VideoGrabber1.OnFrameProgress2 += new VidGrab.OnFrameProgress2EventHandler(this.VideoGrabber1_OnFrameProgress2);
            this.VideoGrabber1.OnGraphBuilt += new System.EventHandler(this.VideoGrabber1_OnGraphBuilt);
            this.VideoGrabber1.OnInactive += new System.EventHandler(this.VideoGrabber1_OnInactive);
            this.VideoGrabber1.OnLog += new VidGrab.OnLogEventHandler(this.VideoGrabber1_OnLog);
            this.VideoGrabber1.OnMotionDetected += new VidGrab.OnMotionDetectedEventHandler(this.VideoGrabber1_OnMotionDetected);
            this.VideoGrabber1.OnMotionNotDetected += new VidGrab.OnMotionNotDetectedEventHandler(this.VideoGrabber1_OnMotionNotDetected);
            this.VideoGrabber1.OnMouseDown += new VidGrab.OnMouseDownEventHandler(this.VideoGrabber1_OnMouseDown);
            this.VideoGrabber1.OnMouseMove += new VidGrab.OnMouseMoveEventHandler(this.VideoGrabber1_OnMouseMove);
            this.VideoGrabber1.OnMouseUp += new VidGrab.OnMouseUpEventHandler(this.VideoGrabber1_OnMouseUp);
            this.VideoGrabber1.OnONVIFDiscoveryCompleted += new VidGrab.OnONVIFDiscoveryCompletedEventHandler(this.VideoGrabber1_OnONVIFDiscoveryCompleted);
            this.VideoGrabber1.OnPlayerEndOfStream += new System.EventHandler(this.VideoGrabber1_OnPlayerEndOfStream);
            this.VideoGrabber1.OnPlayerOpened += new System.EventHandler(this.VideoGrabber1_OnPlayerOpened);
            this.VideoGrabber1.OnPlayerUpdateTrackbarPosition += new VidGrab.OnPlayerUpdateTrackbarPositionEventHandler(this.VideoGrabber1_OnPlayerUpdateTrackbarPosition);
            this.VideoGrabber1.OnPreviewStarted += new System.EventHandler(this.VideoGrabber1_OnPreviewStarted);
            this.VideoGrabber1.OnRecordingCompleted += new VidGrab.OnRecordingCompletedEventHandler(this.VideoGrabber1_OnRecordingCompleted);
            this.VideoGrabber1.OnRecordingPaused += new System.EventHandler(this.VideoGrabber1_OnRecordingPaused);
            this.VideoGrabber1.OnRecordingReadyToStart += new System.EventHandler(this.VideoGrabber1_OnRecordingReadyToStart);
            this.VideoGrabber1.OnRecordingStarted += new VidGrab.OnRecordingStartedEventHandler(this.VideoGrabber1_OnRecordingStarted);
            this.VideoGrabber1.OnReencodingCompleted += new VidGrab.OnReencodingCompletedEventHandler(this.VideoGrabber1_OnReencodingCompleted);
            this.VideoGrabber1.OnReencodingProgress += new VidGrab.OnReencodingProgressEventHandler(this.VideoGrabber1_OnReencodingProgress);
            this.VideoGrabber1.OnReencodingStarted += new VidGrab.OnReencodingStartedEventHandler(this.VideoGrabber1_OnReencodingStarted);
            this.VideoGrabber1.OnReinitializing += new System.EventHandler(this.VideoGrabber1_OnReinitializing);
            this.VideoGrabber1.OnResizeVideo += new VidGrab.OnResizeVideoEventHandler(this.VideoGrabber1_OnResizeVideo);
            this.VideoGrabber1.OnVideoDeviceSelected += new System.EventHandler(this.VideoGrabber1_OnVideoDeviceSelected);
            this.VideoGrabber1.OnVideoFromBitmapsNextFrameNeeded += new VidGrab.OnVideoFromBitmapsNextFrameNeededEventHandler(this.VideoGrabber1_OnVideoFromBitmapsNextFrameNeeded);
            this.VideoGrabber1.SizeChanged += new System.EventHandler(this.VideoGrabber1_SizeChanged);
            // 
            // mmoLog
            // 
            this.mmoLog.AcceptsReturn = true;
            this.mmoLog.BackColor = System.Drawing.SystemColors.Window;
            this.mmoLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoLog.Font = new System.Drawing.Font("Arial", 8F);
            this.mmoLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoLog.Location = new System.Drawing.Point(9, 578);
            this.mmoLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmoLog.MaxLength = 0;
            this.mmoLog.Multiline = true;
            this.mmoLog.Name = "mmoLog";
            this.mmoLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoLog.Size = new System.Drawing.Size(328, 502);
            this.mmoLog.TabIndex = 50;
            // 
            // edtAdditionalInfo
            // 
            this.edtAdditionalInfo.AcceptsReturn = true;
            this.edtAdditionalInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtAdditionalInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAdditionalInfo.Font = new System.Drawing.Font("Arial", 8F);
            this.edtAdditionalInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtAdditionalInfo.Location = new System.Drawing.Point(9, 540);
            this.edtAdditionalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtAdditionalInfo.MaxLength = 0;
            this.edtAdditionalInfo.Name = "edtAdditionalInfo";
            this.edtAdditionalInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtAdditionalInfo.Size = new System.Drawing.Size(328, 26);
            this.edtAdditionalInfo.TabIndex = 49;
            // 
            // edtFrameCount
            // 
            this.edtFrameCount.AcceptsReturn = true;
            this.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameCount.Font = new System.Drawing.Font("Arial", 8F);
            this.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameCount.Location = new System.Drawing.Point(9, 502);
            this.edtFrameCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtFrameCount.MaxLength = 0;
            this.edtFrameCount.Name = "edtFrameCount";
            this.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameCount.Size = new System.Drawing.Size(328, 26);
            this.edtFrameCount.TabIndex = 48;
            // 
            // edtStoragePath
            // 
            this.edtStoragePath.AcceptsReturn = true;
            this.edtStoragePath.BackColor = System.Drawing.SystemColors.Window;
            this.edtStoragePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStoragePath.Font = new System.Drawing.Font("Arial", 8F);
            this.edtStoragePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStoragePath.Location = new System.Drawing.Point(9, 468);
            this.edtStoragePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtStoragePath.MaxLength = 0;
            this.edtStoragePath.Name = "edtStoragePath";
            this.edtStoragePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStoragePath.Size = new System.Drawing.Size(328, 26);
            this.edtStoragePath.TabIndex = 46;
            this.edtStoragePath.TextChanged += new System.EventHandler(this.edtStoragePath_TextChanged);
            // 
            // gbPlayerControl
            // 
            this.gbPlayerControl.Controls.Add(this.btnFrameStep);
            this.gbPlayerControl.Controls.Add(this.btnFastFwd);
            this.gbPlayerControl.Controls.Add(this.btnFastRew);
            this.gbPlayerControl.Controls.Add(this.btnPlay);
            this.gbPlayerControl.Controls.Add(this.btnPause);
            this.gbPlayerControl.Controls.Add(this.btnPlayBackwards);
            this.gbPlayerControl.Controls.Add(this.tbrPlayer);
            this.gbPlayerControl.Controls.Add(this.btnStop);
            this.gbPlayerControl.Location = new System.Drawing.Point(9, 371);
            this.gbPlayerControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlayerControl.Name = "gbPlayerControl";
            this.gbPlayerControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlayerControl.Size = new System.Drawing.Size(1462, 68);
            this.gbPlayerControl.TabIndex = 60;
            this.gbPlayerControl.TabStop = false;
            this.gbPlayerControl.Text = "player control";
            // 
            // btnFrameStep
            // 
            this.btnFrameStep.BackColor = System.Drawing.SystemColors.Control;
            this.btnFrameStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFrameStep.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFrameStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFrameStep.ImageIndex = 6;
            this.btnFrameStep.ImageList = this.ImageList1;
            this.btnFrameStep.Location = new System.Drawing.Point(245, 24);
            this.btnFrameStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFrameStep.Name = "btnFrameStep";
            this.btnFrameStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFrameStep.Size = new System.Drawing.Size(52, 35);
            this.btnFrameStep.TabIndex = 33;
            this.btnFrameStep.UseVisualStyleBackColor = false;
            this.btnFrameStep.Click += new System.EventHandler(this.btnFrameStep_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            this.ImageList1.Images.SetKeyName(6, "");
            // 
            // btnFastFwd
            // 
            this.btnFastFwd.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastFwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFastFwd.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFastFwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastFwd.ImageIndex = 0;
            this.btnFastFwd.ImageList = this.ImageList1;
            this.btnFastFwd.Location = new System.Drawing.Point(364, 22);
            this.btnFastFwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFastFwd.Name = "btnFastFwd";
            this.btnFastFwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastFwd.Size = new System.Drawing.Size(52, 34);
            this.btnFastFwd.TabIndex = 32;
            this.btnFastFwd.UseVisualStyleBackColor = false;
            this.btnFastFwd.Click += new System.EventHandler(this.btnFastFwd_Click);
            // 
            // btnFastRew
            // 
            this.btnFastRew.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastRew.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFastRew.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFastRew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastRew.ImageIndex = 1;
            this.btnFastRew.ImageList = this.ImageList1;
            this.btnFastRew.Location = new System.Drawing.Point(306, 24);
            this.btnFastRew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFastRew.Name = "btnFastRew";
            this.btnFastRew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastRew.Size = new System.Drawing.Size(50, 35);
            this.btnFastRew.TabIndex = 31;
            this.btnFastRew.UseVisualStyleBackColor = false;
            this.btnFastRew.Click += new System.EventHandler(this.btnFastRew_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.ImageIndex = 2;
            this.btnPlay.ImageList = this.ImageList1;
            this.btnPlay.Location = new System.Drawing.Point(187, 24);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlay.Size = new System.Drawing.Size(50, 35);
            this.btnPlay.TabIndex = 30;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPause.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.ImageIndex = 4;
            this.btnPause.ImageList = this.ImageList1;
            this.btnPause.Location = new System.Drawing.Point(126, 24);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPause.Size = new System.Drawing.Size(50, 35);
            this.btnPause.TabIndex = 28;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlayBackwards
            // 
            this.btnPlayBackwards.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayBackwards.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayBackwards.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPlayBackwards.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayBackwards.ImageIndex = 5;
            this.btnPlayBackwards.ImageList = this.ImageList1;
            this.btnPlayBackwards.Location = new System.Drawing.Point(9, 24);
            this.btnPlayBackwards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayBackwards.Name = "btnPlayBackwards";
            this.btnPlayBackwards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayBackwards.Size = new System.Drawing.Size(52, 35);
            this.btnPlayBackwards.TabIndex = 27;
            this.btnPlayBackwards.UseVisualStyleBackColor = false;
            this.btnPlayBackwards.Click += new System.EventHandler(this.btnPlayBackwards_Click);
            // 
            // tbrPlayer
            // 
            this.tbrPlayer.AutoSize = false;
            this.tbrPlayer.Location = new System.Drawing.Point(425, 22);
            this.tbrPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbrPlayer.Name = "tbrPlayer";
            this.tbrPlayer.Size = new System.Drawing.Size(1025, 34);
            this.tbrPlayer.TabIndex = 20;
            this.tbrPlayer.Scroll += new System.EventHandler(this.tbrPlayer_Scroll);
            this.tbrPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyDown);
            this.tbrPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyUp);
            this.tbrPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseDown);
            this.tbrPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.ImageIndex = 3;
            this.btnStop.ImageList = this.ImageList1;
            this.btnStop.Location = new System.Drawing.Point(69, 24);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(50, 35);
            this.btnStop.TabIndex = 29;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(9, 441);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(99, 18);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "storage path:";
            // 
            // chkPlayerTrackBarSynchrone
            // 
            this.chkPlayerTrackBarSynchrone.Location = new System.Drawing.Point(1254, 456);
            this.chkPlayerTrackBarSynchrone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPlayerTrackBarSynchrone.Name = "chkPlayerTrackBarSynchrone";
            this.chkPlayerTrackBarSynchrone.Size = new System.Drawing.Size(268, 28);
            this.chkPlayerTrackBarSynchrone.TabIndex = 62;
            this.chkPlayerTrackBarSynchrone.Text = "player trackbar synchrone";
            this.chkPlayerTrackBarSynchrone.CheckedChanged += new System.EventHandler(this.chkPlayerTrackBarSynchrone_CheckedChanged);
            // 
            // tbrZoom
            // 
            this.tbrZoom.AutoSize = false;
            this.tbrZoom.Location = new System.Drawing.Point(400, 441);
            this.tbrZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbrZoom.Maximum = 20000;
            this.tbrZoom.Minimum = 1000;
            this.tbrZoom.Name = "tbrZoom";
            this.tbrZoom.Size = new System.Drawing.Size(845, 32);
            this.tbrZoom.TabIndex = 63;
            this.tbrZoom.Value = 1000;
            this.tbrZoom.Scroll += new System.EventHandler(this.tbrZoom_Scroll);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(346, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 42);
            this.label2.TabIndex = 64;
            this.label2.Text = "ZOOM:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbrZoomX
            // 
            this.tbrZoomX.AutoSize = false;
            this.tbrZoomX.Location = new System.Drawing.Point(495, 488);
            this.tbrZoomX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbrZoomX.Maximum = 20000;
            this.tbrZoomX.Minimum = 1000;
            this.tbrZoomX.Name = "tbrZoomX";
            this.tbrZoomX.Size = new System.Drawing.Size(760, 31);
            this.tbrZoomX.TabIndex = 65;
            this.tbrZoomX.Value = 1000;
            this.tbrZoomX.Scroll += new System.EventHandler(this.tbrZoomX_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(349, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 42);
            this.label3.TabIndex = 66;
            this.label3.Text = "zoom center X:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Y:";
            // 
            // tbpReencoding
            // 
            this.tbpReencoding.Location = new System.Drawing.Point(4, 28);
            this.tbpReencoding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpReencoding.Name = "tbpReencoding";
            this.tbpReencoding.Size = new System.Drawing.Size(1792, 330);
            this.tbpReencoding.TabIndex = 11;
            this.tbpReencoding.Text = "reencoding";
            // 
            // tbpDisplay
            // 
            this.tbpDisplay.Location = new System.Drawing.Point(4, 28);
            this.tbpDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDisplay.Name = "tbpDisplay";
            this.tbpDisplay.Size = new System.Drawing.Size(1792, 330);
            this.tbpDisplay.TabIndex = 10;
            this.tbpDisplay.Text = "display";
            // 
            // tbpVideoProcessing
            // 
            this.tbpVideoProcessing.Location = new System.Drawing.Point(4, 28);
            this.tbpVideoProcessing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpVideoProcessing.Name = "tbpVideoProcessing";
            this.tbpVideoProcessing.Size = new System.Drawing.Size(1792, 330);
            this.tbpVideoProcessing.TabIndex = 9;
            this.tbpVideoProcessing.Text = "video processing";
            // 
            // tbpOverlays
            // 
            this.tbpOverlays.Location = new System.Drawing.Point(4, 28);
            this.tbpOverlays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpOverlays.Name = "tbpOverlays";
            this.tbpOverlays.Size = new System.Drawing.Size(1792, 330);
            this.tbpOverlays.TabIndex = 8;
            this.tbpOverlays.Text = "overlays";
            // 
            // tbpMotionDetection
            // 
            this.tbpMotionDetection.Location = new System.Drawing.Point(4, 28);
            this.tbpMotionDetection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpMotionDetection.Name = "tbpMotionDetection";
            this.tbpMotionDetection.Size = new System.Drawing.Size(1792, 330);
            this.tbpMotionDetection.TabIndex = 7;
            this.tbpMotionDetection.Text = "motion detection";
            // 
            // tbpFrameGrabber
            // 
            this.tbpFrameGrabber.Location = new System.Drawing.Point(4, 28);
            this.tbpFrameGrabber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpFrameGrabber.Name = "tbpFrameGrabber";
            this.tbpFrameGrabber.Size = new System.Drawing.Size(1792, 330);
            this.tbpFrameGrabber.TabIndex = 6;
            this.tbpFrameGrabber.Text = "frame grabber";
            // 
            // tbpPlayer
            // 
            this.tbpPlayer.Location = new System.Drawing.Point(4, 28);
            this.tbpPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpPlayer.Name = "tbpPlayer";
            this.tbpPlayer.Size = new System.Drawing.Size(1792, 330);
            this.tbpPlayer.TabIndex = 5;
            this.tbpPlayer.Text = "player";
            // 
            // tbpNetworkStreaming
            // 
            this.tbpNetworkStreaming.Location = new System.Drawing.Point(4, 28);
            this.tbpNetworkStreaming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpNetworkStreaming.Name = "tbpNetworkStreaming";
            this.tbpNetworkStreaming.Size = new System.Drawing.Size(1792, 330);
            this.tbpNetworkStreaming.TabIndex = 4;
            this.tbpNetworkStreaming.Text = "streaming";
            // 
            // tbpMultipurposeEncoder
            // 
            this.tbpMultipurposeEncoder.Location = new System.Drawing.Point(4, 28);
            this.tbpMultipurposeEncoder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpMultipurposeEncoder.Name = "tbpMultipurposeEncoder";
            this.tbpMultipurposeEncoder.Size = new System.Drawing.Size(1792, 330);
            this.tbpMultipurposeEncoder.TabIndex = 13;
            this.tbpMultipurposeEncoder.Text = "Multipurpose Encoder";
            // 
            // tbpRecording
            // 
            this.tbpRecording.Location = new System.Drawing.Point(4, 28);
            this.tbpRecording.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpRecording.Name = "tbpRecording";
            this.tbpRecording.Size = new System.Drawing.Size(1792, 330);
            this.tbpRecording.TabIndex = 3;
            this.tbpRecording.Text = "recording";
            // 
            // tbpAudio
            // 
            this.tbpAudio.Location = new System.Drawing.Point(4, 28);
            this.tbpAudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpAudio.Name = "tbpAudio";
            this.tbpAudio.Size = new System.Drawing.Size(1792, 330);
            this.tbpAudio.TabIndex = 2;
            this.tbpAudio.Text = "audio";
            // 
            // tbpIPCameras
            // 
            this.tbpIPCameras.Location = new System.Drawing.Point(4, 28);
            this.tbpIPCameras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpIPCameras.Name = "tbpIPCameras";
            this.tbpIPCameras.Size = new System.Drawing.Size(1792, 330);
            this.tbpIPCameras.TabIndex = 1;
            this.tbpIPCameras.Text = "IP cameras";
            // 
            // tbpVideoSource
            // 
            this.tbpVideoSource.Location = new System.Drawing.Point(4, 28);
            this.tbpVideoSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpVideoSource.Name = "tbpVideoSource";
            this.tbpVideoSource.Size = new System.Drawing.Size(1792, 330);
            this.tbpVideoSource.TabIndex = 0;
            this.tbpVideoSource.Text = "video source";
            // 
            // tbcTabs
            // 
            this.tbcTabs.Controls.Add(this.tbpVideoSource);
            this.tbcTabs.Controls.Add(this.tbpIPCameras);
            this.tbcTabs.Controls.Add(this.tbpAudio);
            this.tbcTabs.Controls.Add(this.tbpRecording);
            this.tbcTabs.Controls.Add(this.tbpMultipurposeEncoder);
            this.tbcTabs.Controls.Add(this.tbpNetworkStreaming);
            this.tbcTabs.Controls.Add(this.tbpPlayer);
            this.tbcTabs.Controls.Add(this.tbpFrameGrabber);
            this.tbcTabs.Controls.Add(this.tbpMotionDetection);
            this.tbcTabs.Controls.Add(this.tbpOverlays);
            this.tbcTabs.Controls.Add(this.tbpVideoProcessing);
            this.tbcTabs.Controls.Add(this.tbpDisplay);
            this.tbcTabs.Controls.Add(this.tbpReencoding);
            this.tbcTabs.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tbcTabs.Location = new System.Drawing.Point(9, 0);
            this.tbcTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.Padding = new System.Drawing.Point(5, 3);
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(1800, 362);
            this.tbcTabs.TabIndex = 59;
            this.tbcTabs.SelectedIndexChanged += new System.EventHandler(this.tbcTabs_SelectedIndexChanged);
            // 
            // tbrZoomY
            // 
            this.tbrZoomY.AutoSize = false;
            this.tbrZoomY.Location = new System.Drawing.Point(348, 538);
            this.tbrZoomY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbrZoomY.Maximum = 20000;
            this.tbrZoomY.Minimum = 1000;
            this.tbrZoomY.Name = "tbrZoomY";
            this.tbrZoomY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrZoomY.Size = new System.Drawing.Size(29, 542);
            this.tbrZoomY.TabIndex = 68;
            this.tbrZoomY.Value = 1000;
            this.tbrZoomY.Scroll += new System.EventHandler(this.tbrZoomY_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 971);
            this.Controls.Add(this.VideoGrabber1);
            this.Controls.Add(this.tbrZoomY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrZoomX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbrZoom);
            this.Controls.Add(this.chkPlayerTrackBarSynchrone);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.gbPlayerControl);
            this.Controls.Add(this.tbcTabs);
            this.Controls.Add(this.mmoLog);
            this.Controls.Add(this.edtAdditionalInfo);
            this.Controls.Add(this.edtFrameCount);
            this.Controls.Add(this.edtStoragePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datastead Software - TVideoGrabber demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbPlayerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).EndInit();
            this.tbcTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public VidGrab.VideoGrabber VideoGrabber1;
        public System.Windows.Forms.TextBox mmoLog;
        public System.Windows.Forms.TextBox edtAdditionalInfo;
        public System.Windows.Forms.TextBox edtFrameCount;
        public System.Windows.Forms.TextBox edtStoragePath;
        internal System.Windows.Forms.GroupBox gbPlayerControl;
        public System.Windows.Forms.Button btnFrameStep;
        internal System.Windows.Forms.ImageList ImageList1;
        public System.Windows.Forms.Button btnFastFwd;
        public System.Windows.Forms.Button btnFastRew;
        public System.Windows.Forms.Button btnPlay;
        public System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Button btnPlayBackwards;
        internal System.Windows.Forms.TrackBar tbrPlayer;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkPlayerTrackBarSynchrone;
        internal System.Windows.Forms.TrackBar tbrZoom;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TrackBar tbrZoomX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TabPage tbpReencoding;
        internal System.Windows.Forms.TabPage tbpDisplay;
        internal System.Windows.Forms.TabPage tbpVideoProcessing;
        internal System.Windows.Forms.TabPage tbpOverlays;
        internal System.Windows.Forms.TabPage tbpMotionDetection;
        internal System.Windows.Forms.TabPage tbpFrameGrabber;
        internal System.Windows.Forms.TabPage tbpPlayer;
        internal System.Windows.Forms.TabPage tbpNetworkStreaming;
        internal System.Windows.Forms.TabPage tbpMultipurposeEncoder;
        internal System.Windows.Forms.TabPage tbpRecording;
        internal System.Windows.Forms.TabPage tbpAudio;
        internal System.Windows.Forms.TabPage tbpIPCameras;
        internal System.Windows.Forms.TabPage tbpVideoSource;
        public System.Windows.Forms.TabControl tbcTabs;
        internal System.Windows.Forms.TrackBar tbrZoomY;
    }
}

