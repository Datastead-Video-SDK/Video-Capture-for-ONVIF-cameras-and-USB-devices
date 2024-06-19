unit MainForm;

interface

uses
   Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
   ExtCtrls, ComCtrls, StdCtrls, Buttons, Menus, VidGrab, Jpeg, ShellAPI,
   Mask;

const
   FreeHandMouseCoordinatesMax = 5000;

type
   TfrmMainForm = class(TForm)
      btnPlayerBackwards: TSpeedButton;
      btnPlayerFastForward: TSpeedButton;
      btnPlayerPause: TSpeedButton;
      btnPlayerRewind: TSpeedButton;
      btnPlayerStartPlaying: TSpeedButton;
      btnPlayerStop: TSpeedButton;
      edtFrameCount: TEdit;
      edtStoragePath: TEdit;
      grbPlayerControl: TGroupBox;
      Label52: TLabel;
      Label9: TLabel;
      mmoLog: TMemo;
      tbrPlayerProgress: TTrackBar;
      VideoGrabber: TVideoGrabber;
      pctMain: TPageControl;
      tbsVideoDevice: TTabSheet;
      grbVideoDeviceDialogs: TGroupBox;
      tbsAudio: TTabSheet;
      tbsRecording: TTabSheet;
      tbsPlayer: TTabSheet;
      btnOpenLastClipRecorded: TSpeedButton;
      btnPlayerOpenFile: TSpeedButton;
      Label23: TLabel;
      Label8: TLabel;
      Label40: TLabel;
      Label41: TLabel;
      btnPlayerOpenStreamingURL: TSpeedButton;
      edtPlayerFastSeekSpeed: TEdit;
      edtPlayerSpeedRatio: TEdit;
      updPlayerFastSeekSpeed: TUpDown;
      btnAutoPlay: TCheckBox;
      edtPlayerClip: TEdit;
      tbsFrameGrabber: TTabSheet;
      Label42: TLabel;
      Label43: TLabel;
      rgdFrameGrabberFormat: TRadioGroup;
      rgdFrameGrabber: TRadioGroup;
      tbsClipReencoding: TTabSheet;
      TabSheet1: TTabSheet;
      mmoSensitivityGrid: TMemo;
      mmoMotionGrid: TMemo;
      tbsFrameOverlay: TTabSheet;
      grbFreeHand: TGroupBox;
      chkFreeHandEnabled: TCheckBox;
      btnFreeHandErase: TButton;
      tbsVideoProcessing: TTabSheet;
      tbsDisplay: TTabSheet;
      grbMainVideoWindow: TGroupBox;
      chkEmbedded: TCheckBox;
      chkFullScreen: TCheckBox;
      chkStayOnTop: TCheckBox;
      chkUseVideoPort: TCheckBox;
      chkMouseMovesWindow: TCheckBox;
      chkAutoSize: TCheckBox;
      btnNewLocation2: TButton;
      chkPlayerAudioRendering: TCheckBox;
      grbOneShot: TGroupBox;
      edtUseThisFileName: TEdit;
      btnOneShotTBitmap: TButton;
      btnOneShotBMPFile: TButton;
      btnOneShotJPEGFile: TButton;
      chkUseThisFileName: TCheckBox;
      grbBurstMode: TGroupBox;
      Label14: TLabel;
      Label15: TLabel;
      btnBurstModeBMPFile: TButton;
      btnBurstModeJPEGFile: TButton;
      edtBurstCount: TEdit;
      edtBurstInterval: TEdit;
      btnBurstModeStop: TButton;
      btnBurstModeTBitmap: TButton;
      grbZoomSize: TGroupBox;
      Label12: TLabel;
      tbrCaptureZoomSize: TTrackBar;
      edtCaptureZoomSize: TEdit;
      btnResetCaptureZoomSize: TButton;
      mmoFrameCaptureLog: TMemo;
      chkRefreshPausedDisplay: TCheckBox;
      grbReencodingSettings: TGroupBox;
      chkIncludeVideoStream: TCheckBox;
      chkIncludeAudioStream: TCheckBox;
      chkUseCurrentVideoCompressor: TCheckBox;
      chkUseCurrentAudioCompressor: TCheckBox;
      chkUseFrameGrabber: TCheckBox;
      chkWMVOutput: TCheckBox;
      btnSourceVideoClip: TSpeedButton;
      edtSourceVideoClip: TEdit;
      edtDestinationVideoClip: TEdit;
      Label75: TLabel;
      Label45: TLabel;
      grbStartStopTime: TGroupBox;
      Label78: TLabel;
      Label79: TLabel;
      edtReencStartTime: TEdit;
      edtReencDuration: TEdit;
      edtReencStopTime: TEdit;
      btnDuration: TButton;
      btnStartReencoding: TButton;
      btnStopReencoding: TButton;
      rdgReencodingMethod: TRadioGroup;
      btnOpenLastClipPlayed: TSpeedButton;
      grbVsVideoCaptureDevice: TGroupBox;
      Label2: TLabel;
      Label19: TLabel;
      cboVideoInputs: TComboBox;
      cboAnalogVideoStandard: TComboBox;
      cboVideoDevices: TComboBox;
      btnAutoRefreshPreview: TCheckBox;
      grbVsFileOrUrl: TGroupBox;
      edtVideoSourceFileOrUrl: TEdit;
      grbCropping: TGroupBox;
      Label85: TLabel;
      Label86: TLabel;
      Label87: TLabel;
      Label84: TLabel;
      Label88: TLabel;
      chkCroppingEnabled: TCheckBox;
      trkCroppingX: TTrackBar;
      trkCroppingY: TTrackBar;
      edtCroppingWidth: TEdit;
      edtCroppingHeight: TEdit;
      trkCroppingZoom: TTrackBar;
      chkCroppingOutbounds: TCheckBox;
      btnCroppingZoomReset: TButton;
      grbVMR9Adjust: TGroupBox;
      Label7: TLabel;
      tbrVMR9Brightness: TTrackBar;
      tbrVMR9Contrast: TTrackBar;
      tbrVMR9Saturation: TTrackBar;
      tbrVMR9Hue: TTrackBar;
      vmr9FixRange: TCheckBox;
      Label21: TLabel;
      btnSelectFileOrUrl: TSpeedButton;
      grbVideoSource: TGroupBox;
      cboVideoSource: TComboBox;
      grbPreview: TGroupBox;
      btnStartPreview: TBitBtn;
      btnStopPreview: TButton;
      grbFrameRate: TGroupBox;
      edtFrameRate: TEdit;
      btnFrameRate: TButton;
      Label53: TLabel;
      lblMotionDetectorRequiresFrameGrabber: TLabel;
      chkMotionDetectionEnabled: TCheckBox;
      chkReduceVideoNoise: TCheckBox;
      btnShowGridDialog: TButton;
      Label54: TLabel;
      chkCompareRed: TCheckBox;
      chkCompareGreen: TCheckBox;
      chkCompareBlue: TCheckBox;
      chk_GreyScale: TCheckBox;
      imgMotionDetected: TImage;
      grbMotionRatio: TGroupBox;
      shpMotionDetected: TShape;
      edtMotionRatio: TEdit;
      grbXYMaxMotion: TGroupBox;
      edtMaxMotionXY: TEdit;
      edtMaxMotionCoord: TEdit;
      grbCellsSensitivity: TGroupBox;
      Label57: TLabel;
      Label58: TLabel;
      Label59: TLabel;
      edtXCell: TEdit;
      updXCell: TUpDown;
      edtYCell: TEdit;
      updYCell: TUpDown;
      edtCellSensitivity: TEdit;
      updCellSensitivity: TUpDown;
      btnSetCellsSensitivity: TButton;
      grbGridSize: TGroupBox;
      Label55: TLabel;
      Label56: TLabel;
      edtGridColCount: TEdit;
      updGridColCount: TUpDown;
      edtGridRowCount: TEdit;
      updGridRowCount: TUpDown;
      btnApplyGridSize: TButton;
      grbGridString: TGroupBox;
      Label51: TLabel;
      lblGridValid: TLabel;
      shpGridValid: TShape;
      edtGrid: TEdit;
      updGlobalGridSensitivity: TUpDown;
      Label28: TLabel;
      grbSoftwareVideoProcessing: TGroupBox;
      rdgVideoRotation: TRadioGroup;
      rdgDeinterlacing: TRadioGroup;
      chkFlipVertical: TCheckBox;
      chkFlipHorizontal: TCheckBox;
      chkGreyScale: TCheckBox;
      chkInvertColors: TCheckBox;
      btnResetAll: TButton;
      tbrBrightness: TTrackBar;
      tbrConstrast: TTrackBar;
      tbrSaturation: TTrackBar;
      tbrHue: TTrackBar;
      Label31: TLabel;
      chkTriggered: TCheckBox;
      btnTriggerNow: TButton;
      btnOpenClip: TButton;
      btnPlayerCloseClip: TButton;
      btnGetClipDuration: TButton;
      btnGeneralInfo: TButton;
      btnHeaderInfo: TButton;
      grbAudioRendering: TGroupBox;
      Label1: TLabel;
      Label17: TLabel;
      tbrAudioVolume: TTrackBar;
      tbrAudioBalance: TTrackBar;
      chkMuteAudioRendering: TCheckBox;
      btnRenewRecordingFile: TButton;
      btnStopRecording: TButton;
      btnStartRecordingControlled: TBitBtn;
      btnStartRecordingImmediately: TBitBtn;
      chkAudioRecording: TCheckBox;
      chkPreserveNativeFormat: TCheckBox;
      chkAVISaveToThisFile: TCheckBox;
      edtRecordingFileName: TEdit;
      btnAboutFrameRate: TButton;
      rdgVUMeters: TRadioGroup;
      pnLeftVUMeter: TPanel;
      pnRightVUMeter: TPanel;
      GroupBox2: TGroupBox;
      btnStartAudioRendering: TButton;
      btnStartWAVRecording: TButton;
      btnStartMP3Recording: TButton;
      btnStopAudio: TButton;
      btnStartASFRecording: TButton;
      chkUseClock: TCheckBox;
      chkEnableSnapshotButton: TCheckBox;
      rdgVideoRenderer: TRadioGroup;
      chkVideoVisibleWhenStopped: TCheckBox;
      chkChangeCursor: TCheckBox;
      chkBorder: TCheckBox;
      chkTransparency: TCheckBox;
      chkSetLogo: TCheckBox;
      imgLogo: TImage;
      grbPlaylist: TGroupBox;
      btnAddToPlaylist: TSpeedButton;
      chkPlaylistLoop: TCheckBox;
      btnPlaylistPlay: TButton;
      btnPlaylistNext: TButton;
      btnPlaylistPrevious: TButton;
      chkPlaylistRandom: TCheckBox;
      btnPlaylistStop: TButton;
      lstPlaylist: TListBox;
      btnClosePlaylist: TButton;
      rdgAspectRatio: TRadioGroup;
      btnOneShotClipboard: TButton;
      btnBurstModeClipboard: TButton;
      cboAudioRenderers: TComboBox;
      Label50: TLabel;
      edtPixellization: TEdit;
      updPixellization: TUpDown;
      chkVisible: TCheckBox;
      rdgDetectVideoSignal: TRadioGroup;
      Label60: TLabel;
      edtCustomRotationAngle: TEdit;
      Label61: TLabel;
      Label62: TLabel;
      edtReencFrameCount: TEdit;
      edtReencStartFrame: TEdit;
      edtReencStopFrame: TEdit;
      Label63: TLabel;
      Label64: TLabel;
      rdgRecordingMethod: TRadioGroup;
      Label72: TLabel;
      Label73: TLabel;
      edtFrameCaptureWidth: TEdit;
      edtFrameCaptureHeight: TEdit;
      tbrPanScan: TTrackBar;
      Label74: TLabel;
      btnTestPanScan: TButton;
      btnOpenAtFrames: TButton;
      btnOpenAtTimes: TButton;
      Label77: TLabel;
      Label80: TLabel;
      edtartFrame: TEdit;
      edtopFrame: TEdit;
      edtartTime: TEdit;
      edtopTime: TEdit;
      chkKeepBounds: TCheckBox;
      chkReopen: TCheckBox;
      Label89: TLabel;
      MainMenu1: TMainMenu;
      mnuFile: TMenuItem;
      mnuExit: TMenuItem;
      mnuAbout: TMenuItem;
      tbsIPCameras: TTabSheet;
      lblChooseIPCamera: TLabel;
      edtIPCameraURL: TEdit;
      btnIPCamStartPreview: TButton;
      edtIPCamConnectionTimeout: TEdit;
      Label91: TLabel;
      Label92: TLabel;
      VideoSourceFileOrUrl_UserName: TEdit;
      VideoSourceFileOrUrl_Password: TEdit;
      Label100: TLabel;
      Label101: TLabel;
      chkRenderAudioDevice: TCheckBox;
      chkAdjustPixelAspectRatio: TCheckBox;
      chkPlayerLoop: TCheckBox;
      GroupBox5: TGroupBox;
      grbRecordingTimer: TRadioGroup;
      Label29: TLabel;
      edtRecordingTimerInterval: TEdit;
      cboVideoFormats: TComboBox;
      Label81: TLabel;
      cboVideoSubtypes: TComboBox;
      Label104: TLabel;
      cboVideoSizes: TComboBox;
      Label4: TLabel;
      chkPlayerTrackbarSynchrone: TCheckBox;
      tbrZoomY: TTrackBar;
      tbrZoomX: TTrackBar;
      tbrZoom: TTrackBar;
      Label18: TLabel;
      Label105: TLabel;
      Label107: TLabel;
      btnPausePreview: TButton;
      btnResumePreview: TButton;
      chkAlphablend: TCheckBox;
      chkTranspColor: TCheckBox;
      tbrAlphablend: TTrackBar;
      edttranspColor: TEdit;
      chkChangePixels: TCheckBox;
      chkDrawGridOverFrames: TCheckBox;
      chkDrawTarget: TCheckBox;
      Label27: TLabel;
      btnPlayerFrameStep: TSpeedButton;
      Options1: TMenuItem;
      Resetvideocapturedevicesettings1: TMenuItem;
      lblFrameOverlayRequiresFrameGrabber: TLabel;
      chkBlackMagicDecklink: TCheckBox;
      grbVsScreenRecording: TGroupBox;
      Label35: TLabel;
      Label90: TLabel;
      edtScreenRecordingWindow: TEdit;
      btnScreenRecordingWindow: TButton;
      edtMonitorNumber: TEdit;
      btnMonitorNumberInfo: TButton;
      chkScreenRecordingWithCursor: TCheckBox;
      chkRecordingCanPause: TCheckBox;
      chkRecordingPauseCreatesNewFile: TCheckBox;
      chkRecordingOnMotion: TCheckBox;
      btnPauseRecording: TButton;
      btnResumeRecording: TButton;
      Label6: TLabel;
      Label16: TLabel;
      cboVideoCompressors: TComboBox;
      btnVideoCompressorSettings: TButton;
      cboAudioCompressors: TComboBox;
      btnAudioCompressorSettings: TButton;
      rdgCompressMode: TRadioGroup;
      chkOpenURLAsync: TCheckBox;
      rdgDisplaySelected: TRadioGroup;
      chkDisplayActive: TCheckBox;
      edtAssignToMonitorLabel: TLabel;
      edtAssignToMonitorNumber: TEdit;
      tbsMPE: TTabSheet;
      grbTextOverlay: TGroupBox;
      Label13: TLabel;
      Label20: TLabel;
      Label22: TLabel;
      Label33: TLabel;
      Label37: TLabel;
      Label3: TLabel;
      rdgTextOverlayAlign: TRadioGroup;
      chkTextOverlayEnabled: TCheckBox;
      chkTextOverlayTransparent: TCheckBox;
      mmoTextOverlayString: TMemo;
      edtTextOverlayTop: TEdit;
      edtTextOverlayLeft: TEdit;
      edtTextOverlayRight: TEdit;
      chkTextOverlayShadow: TCheckBox;
      updTextOverlaySize: TUpDown;
      rdgTextOverlaySelector: TRadioGroup;
      btnTextOverlayColor: TButton;
      btnBkgndColor: TButton;
      chkTextOverlayHighResFont: TCheckBox;
      edtTextOverlayTargetDisplay: TEdit;
      btnTargetDisplayInfo: TButton;
      chkTextOverlayScrolling: TCheckBox;
      edtTextOverlayScrollingSpeed: TEdit;
      chkAdjustOverlayAspectRatio: TCheckBox;
      btnPIPFromAnotherTVideoGrabber: TSpeedButton;
      grbBitmapOverlay: TGroupBox;
      Label48: TLabel;
      btnLoadImageOverlayFromFile: TSpeedButton;
      Label25: TLabel;
      Label82: TLabel;
      Label96: TLabel;
      Label47: TLabel;
      Label102: TLabel;
      Label103: TLabel;
      Label97: TLabel;
      edtImageOverlayTransparentColorValue: TEdit;
      rdgImageOverlaySelector: TRadioGroup;
      edtChromaKeyLeewayPercent: TTrackBar;
      chkImageOverlayEnabled: TCheckBox;
      edtImageOverlayLeft: TEdit;
      edtImageOverlayTop: TEdit;
      chkImageOverlayTransparent: TCheckBox;
      chkImageOverlayUseTransparentColor: TCheckBox;
      btnImageOverlayPickupColor: TButton;
      btnImageOverlayPickupHelp: TButton;
      edtImageOverlayWidth: TEdit;
      edtImageOverlayHeight: TEdit;
      chkImageOverlayAlphaBlend: TCheckBox;
      chkImageOverlayAlphablendCoeff: TTrackBar;
      chkImageOverlayChromaKey: TCheckBox;
      edtChromaKeyColorValue: TEdit;
      edtImageOverlayTargetDisplay: TEdit;
      btnImageOverlayInfo: TButton;
      chkModulo: TCheckBox;
      chkOverlayOrientation: TRadioGroup;
      chkZeroLatency: TCheckBox;
      Label76: TLabel;
      btnBargraphOverlay: TButton;
      chkTextOverlayAlphablend: TCheckBox;
      Label106: TLabel;
      tbrTextOverlayAlphablendValue: TTrackBar;
      btnIPCameraStop: TButton;
      btnIPCameraStarttMP4Recording: TButton;
      Label98: TLabel;
      RichEdit1: TRichEdit;
      btnPIPStop: TButton;
      edtBacktimedRecordingSeconds: TEdit;
      chkBacktimedRecordingSeconds: TCheckBox;
      Label94: TLabel;
      edtIPCamUserName: TEdit;
      Label95: TLabel;
      edtIPCamPassword: TEdit;
      chkUseExternalAudioforRTSP: TCheckBox;
      rgdHwAccel: TRadioGroup;
      rdgIRCutFilter: TRadioGroup;
      btnOneShotPngFile: TButton;
      BtnOneShotTiffFile: TButton;
      btnBurstModePNGFile: TButton;
      btnBurstModeTIFFFile: TButton;
      grbAudioCaptureDevice: TGroupBox;
      Label26: TLabel;
      Label49: TLabel;
      Label36: TLabel;
      cboAudioDevices: TComboBox;
      cboAudioInputs: TComboBox;
      tbrAudioInputLevel: TTrackBar;
      tbrAudioInputBalance: TTrackBar;
      TabSheet5: TTabSheet;
      chkStreamingVideoEnabled: TCheckBox;
      chkStreamingAudioEnabled: TCheckBox;
      Label120: TLabel;
      rdgPreferredVideoSize: TRadioGroup;
      chkretchPreferredVideoSize: TCheckBox;
      chk360VideoDecoding: TCheckBox;
      PageControl2: TPageControl;
      tbsDatasteadEncoder: TTabSheet;
      TabSheet7: TTabSheet;
      pgcMPE: TPageControl;
      tshMPESettings: TTabSheet;
      GroupBox1: TGroupBox;
      chkMPEStreaming: TCheckBox;
      edtMPEStreaming: TEdit;
      grbMPErecord: TGroupBox;
      chkMPERecording: TCheckBox;
      edtMPERecording: TEdit;
      GroupBox6: TGroupBox;
      edtMPEReencoding: TEdit;
      btnStartMPEReencoding: TButton;
      btnStopMPEReencoding: TButton;
      tbsMPERecordingLog: TTabSheet;
      lblMPERecordingProgressInfo: TLabel;
      mmoMPERecordingLog: TMemo;
      tbsMPEStreamingLog: TTabSheet;
      lblMPEStreamingProgressInfo: TLabel;
      mmoMPEStreamingLog: TMemo;
      tbsMPEReencodingLog: TTabSheet;
      lblMPEReencodingProgressInfo: TLabel;
      mmoMPEReencodingLog: TMemo;
      video: TGroupBox;
      edtDatasteadEncoder_VideoCodecName: TEdit;
      Label128: TLabel;
      Label129: TLabel;
      edtDatasteadEncoder_Video_Bitrate_kb: TEdit;
      Label130: TLabel;
      GroupBox10: TGroupBox;
      edtDatasteadEncoder_Video_rc_MinBitRate_kb: TEdit;
      edtDatasteadEncoder_Video_rc_MaxBitRate_kb: TEdit;
      edtDatasteadEncoder_Video_rc_BufferSize_kb: TEdit;
      edtDatasteadEncoder_Video_IDRInterval: TEdit;
      edtDatasteadEncoder_Video_MaxBframes: TEdit;
      edtDatasteadEncoder_Video_ThreadCount: TEdit;
      Label131: TLabel;
      Label132: TLabel;
      Label133: TLabel;
      Label134: TLabel;
      Label135: TLabel;
      Label137: TLabel;
      GroupBox12: TGroupBox;
      edtDatasteadEncoder_Audio_SamplesPerSecond: TEdit;
      edtDatasteadEncoder_Audio_BitRate_kb: TEdit;
      Label138: TLabel;
      Label139: TLabel;
      Label140: TLabel;
      BtnCodecExamples: TButton;
      Memo2: TMemo;
      mmoExtraParameters: TMemo;
      Label11: TLabel;
      Label38: TLabel;
      cmbGPUEncoder: TComboBox;
      Label136: TLabel;
      GroupBox3: TGroupBox;
      btnMultipurposeUDPStreaming: TButton;
      btnPauseStreaming: TButton;
      btnResumeStreaming: TButton;
      Label10: TLabel;
      edtNewFileDuringRecording: TEdit;
      Label24: TLabel;
      btnDeviceDialog: TButton;
      btnCameraControlDialog: TButton;
      btnVideoQualityDialog: TButton;
      GroupBox9: TGroupBox;
      Label114: TLabel;
      PageControl1: TPageControl;
      TabSheet2: TTabSheet;
      Label108: TLabel;
      Label109: TLabel;
      Label99: TLabel;
      Label110: TLabel;
      btnPTZTiltUp: TButton;
      btnPTZPanLeft: TButton;
      btnPTZPanRight: TButton;
      btnPTZTiltDown: TButton;
      btnPTZZoomOut: TButton;
      btnPTZZoomIn: TButton;
      edtPTZDurationMs: TEdit;
      btnPTZHelpDuration: TButton;
      chkPTZMouseUpStop: TCheckBox;
      TabSheet3: TTabSheet;
      Label111: TLabel;
      Label112: TLabel;
      Label113: TLabel;
      btnPTZSetTrackbarLimits: TButton;
      tbrPTZPan: TTrackBar;
      tbrPTZZoom: TTrackBar;
      tbrPTZTilt: TTrackBar;
      TabSheet4: TTabSheet;
      Label115: TLabel;
      Label117: TLabel;
      Label118: TLabel;
      edtPTZRelativeMove: TEdit;
      btnRelativePanLeft: TButton;
      btnRelativeTiltUp: TButton;
      btnRelativePanRight: TButton;
      btnRelativeTiltDown: TButton;
      btnRelativeZoomOut: TButton;
      btnRelativeZoomIn: TButton;
      PTZStop: TButton;
      tbrPTZSpeedRatio: TTrackBar;
      btnHelpPTZSpeedRatio: TButton;
      Label5: TLabel;
      edtDatasteadEncoder_AudioCodecName: TEdit;
      Label32: TLabel;
      GroupBox7: TGroupBox;
      Label34: TLabel;
      Label39: TLabel;
      btnNDIStreamingClientView: TButton;
      edtNDIRemoteHostAndSession: TEdit;
      GroupBox11: TGroupBox;
      Label125: TLabel;
      Label127: TLabel;
      edtNDISessionName: TEdit;
      btnNDIStreamingOK: TButton;
      btnNDISessions: TButton;
      edtNDIReceiveTimeout: TEdit;
      Label44: TLabel;
      btnONVIFReplayRecordingsList: TButton;
      edtIPCameraNTPTime: TEdit;
      Label65: TLabel;
      Label66: TLabel;
      cboAutoFileName: TComboBox;
      Label46: TLabel;
      edtAVIAutoFilePrefix: TEdit;
      btnIPCamStartPTZ: TButton;
      Label67: TLabel;
	 btnDiscoverONVIFFromMulticast: TButton;
    edtOnvifDiscoveryIPRange_FirstIP: TEdit;
    edtOnvifDiscoveryIPRange_LastIP: TEdit;
      Label68: TLabel;
      Label69: TLabel;
		lsbOnvifURLsDiscovered: TListBox;
    btnDiscoverONVIFFromIPRange: TButton;
    Label70: TLabel;
    edtDiscoveryTimeoutSeconds: TEdit;
    btnCancelDiscovery: TButton;
      procedure btnAudioCompressorSettingsClick(Sender: TObject);
      procedure btnAutoPlayClick(Sender: TObject);
      procedure btnAutoRefreshPreviewClick(Sender: TObject);
      procedure btnBurstModeBMPFileClick(Sender: TObject);
      procedure btnBurstModeJPEGFileClick(Sender: TObject);
		procedure btnBurstModeStopClick(Sender: TObject);
      procedure btnBurstModeTBitmapClick(Sender: TObject);
      procedure btnCameraControlDialogClick(Sender: TObject);
      procedure btnDeviceDialogClick(Sender: TObject);
      procedure btnNewLocation2Click(Sender: TObject);
      procedure btnFrameRateClick(Sender: TObject);
      procedure btnFreeHandEraseClick(Sender: TObject);
      procedure btnOneShotBMPFileClick(Sender: TObject);
      procedure btnOneShotJPEGFileClick(Sender: TObject);
      procedure btnOneShotTBitmapClick(Sender: TObject);
      procedure btnPauseRecordingClick(Sender: TObject);
      procedure btnPlayerBackwardsClick(Sender: TObject);
      procedure btnPlayerCloseClipClick(Sender: TObject);
      procedure btnPlayerFastForwardClick(Sender: TObject);
      procedure btnOpenLastClipRecordedClick(Sender: TObject);
      procedure btnPlayerOpenFileClick(Sender: TObject);
      procedure btnPlayerPauseClick(Sender: TObject);
      procedure btnPlayerRewindClick(Sender: TObject);
      procedure btnPlayerStartPlayingClick(Sender: TObject);
      procedure btnPlayerStopClick(Sender: TObject);
      procedure btnResetAllClick(Sender: TObject);
      procedure btnResetCaptureZoomSizeClick(Sender: TObject);
      procedure btnResumeRecordingClick(Sender: TObject);
      procedure btnStartRecordingImmediatelyClick(Sender: TObject);
      procedure btnStartPreviewClick(Sender: TObject);
      procedure btnStopRecordingClick(Sender: TObject);
      procedure btnStopPreviewClick(Sender: TObject);
      procedure btnVideoCompressorSettingsClick(Sender: TObject);
      procedure btnVideoQualityDialogClick(Sender: TObject);
      procedure cboAnalogVideoStandardChange(Sender: TObject);
      procedure cboAudioCompressorsChange(Sender: TObject);
      procedure cboAudioDevicesChange(Sender: TObject);
      procedure cboAudioInputsChange(Sender: TObject);
      procedure cboVideoCompressorsChange(Sender: TObject);
      procedure cboVideoDevicesChange(Sender: TObject);
      procedure cboVideoInputsChange(Sender: TObject);
      procedure cboVideoSizesChange(Sender: TObject);
      procedure cboVideoSubtypesChange(Sender: TObject);
      procedure chkAutoSizeClick(Sender: TObject);
      procedure chkEmbeddedClick(Sender: TObject);
      procedure chkFullScreenClick(Sender: TObject);
      procedure chkMouseMovesWindowClick(Sender: TObject);
      procedure chkStayOnTopClick(Sender: TObject);
      procedure chkUseVideoPortClick(Sender: TObject);
      procedure chkDisplayActiveClick(Sender: TObject);
      procedure chkRecordingCanPauseClick(Sender: TObject);
      procedure chkBorderClick(Sender: TObject);
      procedure chkFlipHorizontalClick(Sender: TObject);
      procedure chkFlipVerticalClick(Sender: TObject);
      procedure chkGreyScaleClick(Sender: TObject);
      procedure chkInvertColorsClick(Sender: TObject);
      procedure chkPlayerAudioRenderingClick(Sender: TObject);
      procedure chkRenderAudioDeviceClick(Sender: TObject);
      procedure chkTextOverlayEnabledClick(Sender: TObject);
      procedure chkTextOverlayTransparentClick(Sender: TObject);
      procedure chkTransparencyClick(Sender: TObject);
      procedure chkUseThisFileNameClick(Sender: TObject);
      procedure edtAVIAutoFilePrefixChange(Sender: TObject);
      procedure edtBurstCountChange(Sender: TObject);
      procedure edtBurstIntervalChange(Sender: TObject);
      procedure edtStoragePathChange(Sender: TObject);
      procedure edtTextOverlayLeftChange(Sender: TObject);
      procedure edtTextOverlayTopChange(Sender: TObject);
      procedure edtTextOverlayRightChange(Sender: TObject);
      procedure FormCreate(Sender: TObject);
      procedure mmoTextOverlayStringChange(Sender: TObject);
      procedure mnuAboutClick(Sender: TObject);
      procedure mnuExitClick(Sender: TObject);
      procedure rdgCompressModeClick(Sender: TObject);
      procedure rdgTextOverlayAlignClick(Sender: TObject);
      procedure rdgVideoRendererClick(Sender: TObject);
      procedure rgdFrameGrabberClick(Sender: TObject);
      procedure rgdFrameGrabberFormatClick(Sender: TObject);
		procedure tbrAudioBalanceChange(Sender: TObject);
      procedure tbrBrightnessChange(Sender: TObject);
		procedure tbrCaptureZoomSizeChange(Sender: TObject);
      procedure tbrConstrastChange(Sender: TObject);
      procedure tbrHueChange(Sender: TObject);
      procedure tbrSaturationChange(Sender: TObject);
      procedure updPlayerFastSeekSpeedClick(Sender: TObject;
        Button: TUDBtnType);
      procedure VideoGrabberDeviceArrivalOrRemoval(Sender: TObject;
        IsDeviceArrival, IsVideoDevice: Boolean; DeviceName: String;
        DeviceIndex: Integer);
      procedure VideoGrabberDeviceLost(Sender: TObject);
      procedure VideoGrabberDiskFull(Sender: TObject);
      procedure VideoGrabberMouseDown(Sender: TObject; VideoWindow: Integer;
        Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
      procedure VideoGrabberMouseMove(Sender: TObject; VideoWindow: Integer;
        Shift: TShiftState; X, Y: Integer);
      procedure VideoGrabberMouseUp(Sender: TObject; VideoWindow: Integer;
        Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
      procedure VideoGrabberPlayerEndOfStream(Sender: TObject);
      procedure VideoGrabberPreviewStarted(Sender: TObject);
      procedure VideoGrabberResize(Sender: TObject);
      procedure VideoGrabberResizeVideo(Sender: TObject;
        SourceWidth, SourceHeight: Integer);
      procedure tbrAudioInputLevelChange(Sender: TObject);
      procedure VideoGrabberDVCommandCompleted(Sender: TObject;
        NewStateValue: Integer; NewStateLabel: String);
      procedure rdgVideoRotationClick(Sender: TObject);
      procedure rdgDeinterlacingClick(Sender: TObject);
      procedure rdgRecordingMethodClick(Sender: TObject);
      procedure chkCompareRedClick(Sender: TObject);
      procedure chkCompareGreenClick(Sender: TObject);
      procedure chkCompareBlueClick(Sender: TObject);
      procedure chk_GreyScaleClick(Sender: TObject);
      procedure chkReduceVideoNoiseClick(Sender: TObject);
      procedure edtGridChange(Sender: TObject);
      procedure updGlobalGridSensitivityClick(Sender: TObject;
        Button: TUDBtnType);
      procedure btnApplyGridSizeClick(Sender: TObject);
      procedure btnSetCellsSensitivityClick(Sender: TObject);
      procedure btnShowGridDialogClick(Sender: TObject);
      procedure chkMotionDetectionEnabledClick(Sender: TObject);
      procedure VideoGrabberPlayerBufferingData(Sender: TObject;
        StartingToBuffer: Boolean);
      procedure VideoGrabberAudioDeviceSelected(Sender: TObject);
      procedure VideoGrabberLog(Sender: TObject; LogType: TLogType;
        Severity, InfoMsg: String);
      procedure VideoGrabberVideoDeviceSelected(Sender: TObject);
      procedure tbrAudioInputBalanceChange(Sender: TObject);
      procedure VideoGrabberReinitializing(Sender: TObject);
      procedure VideoGrabberRecordingCompleted(Sender: TObject;
        FileName: String; Success: Boolean);
      procedure VideoGrabberRecordingStarted(Sender: TObject; FileName: String);
      procedure VideoGrabberReencodingStarted(Sender: TObject;
        SourceFile, DestFile: String);
      procedure VideoGrabberReencodingCompleted(Sender: TObject;
        SourceFile, DestFile: String; Success: Boolean);
      procedure btnViewDirectNetworkStreamingClick(Sender: TObject);
      procedure VideoGrabberInactive(Sender: TObject);
      procedure btnSourceVideoClipClick(Sender: TObject);
      procedure btnStartReencodingClick(Sender: TObject);
      procedure btnStopReencodingClick(Sender: TObject);
      procedure btnDurationClick(Sender: TObject);
      procedure VideoGrabberRecordingReadyToStart(Sender: TObject);
      procedure btnStartRecordingControlledClick(Sender: TObject);
      procedure chkRefreshPausedDisplayClick(Sender: TObject);
      procedure VideoGrabberPlayerOpened(Sender: TObject);
      procedure chkPreserveNativeFormatClick(Sender: TObject);
      procedure chkSetLogoClick(Sender: TObject);
      procedure btnOpenLastClipPlayedClick(Sender: TObject);
      procedure cboVideoSourceChange(Sender: TObject);
      procedure chkScreenRecordingWithCursorClick(Sender: TObject);
      procedure chkCroppingEnabledClick(Sender: TObject);
      procedure chkCroppingOutboundsClick(Sender: TObject);
      procedure edtCroppingWidthChange(Sender: TObject);
      procedure edtCroppingHeightChange(Sender: TObject);
      procedure trkCroppingZoomChange(Sender: TObject);
      procedure btnCroppingZoomResetClick(Sender: TObject);
      procedure trkCroppingYChange(Sender: TObject);
      procedure trkCroppingXChange(Sender: TObject);
      procedure tbrVMR9BrightnessChange(Sender: TObject);
      procedure tbrVMR9ContrastChange(Sender: TObject);
      procedure tbrVMR9SaturationChange(Sender: TObject);
      procedure tbrVMR9HueChange(Sender: TObject);
      procedure VideoGrabberGraphBuilt(Sender: TObject);
      procedure vmr9FixRangeClick(Sender: TObject);
      procedure chkChangeCursorClick(Sender: TObject);
      procedure btnSelectFileOrUrlClick(Sender: TObject);
      procedure edtVideoSourceFileOrUrlChange(Sender: TObject);
      procedure FormDestroy(Sender: TObject);
      procedure chkAudioRecordingClick(Sender: TObject);
      procedure tbrAudioVolumeChange(Sender: TObject);
      procedure chkMuteAudioRenderingClick(Sender: TObject);
      procedure btnRenewRecordingFileClick(Sender: TObject);
      procedure btnLoadImageOverlayFromFileClick(Sender: TObject);
      procedure btnOpenClipClick(Sender: TObject);
      procedure btnGetClipDurationClick(Sender: TObject);
      procedure chkTriggeredClick(Sender: TObject);
      procedure btnTriggerNowClick(Sender: TObject);
      procedure chkRecordingPauseCreatesNewFileClick(Sender: TObject);
      procedure btnGeneralInfoClick(Sender: TObject);
      procedure btnHeaderInfoClick(Sender: TObject);
      procedure rdgVUMetersClick(Sender: TObject);
      procedure chkTextOverlayShadowClick(Sender: TObject);
      procedure updTextOverlaySizeClick(Sender: TObject; Button: TUDBtnType);
      procedure btnAboutFrameRateClick(Sender: TObject);
      procedure btnStartAudioRenderingClick(Sender: TObject);
      procedure btnStartMP3RecordingClick(Sender: TObject);
      procedure btnStartWAVRecordingClick(Sender: TObject);
      procedure btnStopAudioClick(Sender: TObject);
      procedure btnStartASFRecordingClick(Sender: TObject);
      procedure chkRecordingOnMotionClick(Sender: TObject);
      procedure chkUseClockClick(Sender: TObject);
      procedure btnScreenRecordingWindowClick(Sender: TObject);
      procedure chkVideoVisibleWhenStoppedClick(Sender: TObject);
      procedure btnAddToPlaylistClick(Sender: TObject);
      procedure btnPlaylistPlayClick(Sender: TObject);
      procedure btnPlaylistNextClick(Sender: TObject);
      procedure btnPlaylistPreviousClick(Sender: TObject);
      procedure btnPlaylistStopClick(Sender: TObject);
      procedure chkPlaylistLoopClick(Sender: TObject);
      procedure chkPlaylistRandomClick(Sender: TObject);
      procedure VideoGrabberPlayerEndOfPlaylist(Sender: TObject);
      procedure lstPlaylistClick(Sender: TObject);
      procedure btnClosePlaylistClick(Sender: TObject);
      procedure VideoGrabberDVDiscontinuity(Sender: TObject;
        var DeliverNewFrame: Boolean);
      procedure rdgAspectRatioClick(Sender: TObject);
      procedure btnOneShotClipboardClick(Sender: TObject);
      procedure btnBurstModeClipboardClick(Sender: TObject);
      procedure cboAudioRenderersChange(Sender: TObject);
      procedure VideoGrabberClientConnection(Sender: TObject;
        Connected: Boolean; ClientInfo: String);
      procedure updPixellizationClick(Sender: TObject; Button: TUDBtnType);
      procedure rdgTextOverlaySelectorClick(Sender: TObject);
      procedure btnTextOverlayColorClick(Sender: TObject);
      procedure btnBkgndColorClick(Sender: TObject);
      procedure chkVisibleClick(Sender: TObject);
      procedure edtCustomRotationAngleChange(Sender: TObject);
      procedure edtFrameCaptureWidthChange(Sender: TObject);
      procedure edtFrameCaptureHeightChange(Sender: TObject);
      procedure tbrPanScanChange(Sender: TObject);
      procedure btnTestPanScanClick(Sender: TObject);
      procedure btnOpenAtFramesClick(Sender: TObject);
      procedure btnOpenAtTimesClick(Sender: TObject);
      procedure edtMonitorNumberChange(Sender: TObject);
      procedure btnMonitorNumberInfoClick(Sender: TObject);
      procedure tbsIPCamerasShow(Sender: TObject);
      procedure btnIPCamStartPreviewClick(Sender: TObject);
      procedure edtIPCamConnectionTimeoutChange(Sender: TObject);
      procedure btnCurrentIPCameraURLClick(Sender: TObject);
      procedure btnUrlConfClick(Sender: TObject);
      procedure chkImageOverlayEnabledClick(Sender: TObject);
      procedure rdgImageOverlaySelectorClick(Sender: TObject);
      procedure chkImageOverlayTransparentClick(Sender: TObject);
      procedure chkImageOverlayUseTransparentColorClick(Sender: TObject);
      procedure chkImageOverlayAlphaBlendClick(Sender: TObject);
      procedure updImageAlphaBendClick(Sender: TObject; Button: TUDBtnType);
      procedure edtImageOverlayTransparentColorValueChange(Sender: TObject);
      procedure edtImageOverlayLeftChange(Sender: TObject);
      procedure edtImageOverlayTopChange(Sender: TObject);
      procedure edtImageOverlayWidthChange(Sender: TObject);
      procedure edtImageOverlayHeightChange(Sender: TObject);
      procedure btnImageOverlayPickupColorClick(Sender: TObject);
      procedure btnImageOverlayPickupHelpClick(Sender: TObject);
      procedure VideoSourceFileOrUrl_UserNameChange(Sender: TObject);
      procedure VideoSourceFileOrUrl_PasswordChange(Sender: TObject);
      procedure edtIPCamUserNameChange(Sender: TObject);
      procedure edtIPCamPasswordChange(Sender: TObject);
      procedure chkAdjustPixelAspectRatioClick(Sender: TObject);
      procedure edtChromaKeyColorValueChange(Sender: TObject);
      procedure edtChromaKeyLeewayPercentChange(Sender: TObject);
      procedure chkImageOverlayChromaKeyClick(Sender: TObject);
      procedure chkImageOverlayAlphablendCoeffChange(Sender: TObject);
      procedure chkPlayerLoopClick(Sender: TObject);
      procedure chkFreeHandEnabledClick(Sender: TObject);
      procedure chkDrawGridOverFramesClick(Sender: TObject);
      procedure VideoGrabberVideoFromBitmapsNextFrameNeeded(Sender: TObject;
        FirstSample: Boolean);
      procedure chkAVISaveToThisFileClick(Sender: TObject);
      procedure edtRecordingFileNameChange(Sender: TObject);
      procedure edtRecordingTimerIntervalChange(Sender: TObject);
      procedure grbRecordingTimerClick(Sender: TObject);
      procedure cboVideoFormatsChange(Sender: TObject);
      procedure mmoLogKeyUp(Sender: TObject; var Key: Word; Shift: TShiftState);
      procedure edtTextOverlayScrollingSpeedChange(Sender: TObject);
      procedure chkChangePixelsClick(Sender: TObject);
      procedure chkPlayerTrackbarSynchroneClick(Sender: TObject);
      procedure tbrPlayerProgressChange(Sender: TObject);
      procedure tbrZoomChange(Sender: TObject);
      procedure tbrZoomYChange(Sender: TObject);
      procedure tbrZoomXChange(Sender: TObject);
      procedure VideoGrabberFrameProgress2(Sender: TObject;
        FrameInfo: pFrameInfo);
      procedure VideoGrabberFrameBitmap(Sender: TObject; FrameInfo: pFrameInfo;
        BitmapInfo: pFrameBitmapInfo);
      procedure btnPausePreviewClick(Sender: TObject);
      procedure btnResumePreviewClick(Sender: TObject);
      procedure chkAlphablendClick(Sender: TObject);
      procedure chkTranspColorClick(Sender: TObject);
      procedure edttranspColorChange(Sender: TObject);
      procedure tbrAlphablendChange(Sender: TObject);
      procedure btnPlayerFrameStepClick(Sender: TObject);
      procedure btnPIPFromAnotherTVideoGrabberClick(Sender: TObject);
      procedure VideoGrabberRecordingPaused(Sender: TObject);
      procedure Resetvideocapturedevicesettings1Click(Sender: TObject);
      procedure edtPlayerSpeedRatioChange(Sender: TObject);
      procedure chkAdjustOverlayAspectRatioClick(Sender: TObject);
      procedure chkTextOverlayScrollingClick(Sender: TObject);
      procedure chkBlackMagicDecklinkClick(Sender: TObject);
      procedure chkEnableSnapshotButtonClick(Sender: TObject);
      procedure chkTextOverlayHighResFontClick(Sender: TObject);
      procedure edtTextOverlayTargetDisplayChange(Sender: TObject);
      procedure btnTargetDisplayInfoClick(Sender: TObject);
      procedure edtImageOverlayTargetDisplayChange(Sender: TObject);
      procedure chkOpenURLAsyncClick(Sender: TObject);
      procedure rdgDisplaySelectedClick(Sender: TObject);
      procedure edtAssignToMonitorNumberChange(Sender: TObject);
      procedure edtMPERecordingChange(Sender: TObject);
      procedure chkMPERecordingClick(Sender: TObject);
      procedure chkMPEStreamingClick(Sender: TObject);
      procedure edtMPEStreamingChange(Sender: TObject);
      procedure VideoGrabberMultipurposeEncoderProgress(Sender: TObject;
        MultipurposeEncoderInstance: TMultipurposeEncoderInstance);
      procedure edtMPEReencodingChange(Sender: TObject);
      procedure btnStartMPEReencodingClick(Sender: TObject);
      procedure btnStopMPEReencodingClick(Sender: TObject);
      procedure chkModuloClick(Sender: TObject);
      procedure chkOverlayOrientationClick(Sender: TObject);
      procedure chkZeroLatencyClick(Sender: TObject);
      procedure btnBargraphOverlayClick(Sender: TObject);
      procedure chkTextOverlayAlphablendClick(Sender: TObject);
      procedure tbrTextOverlayAlphablendValueChange(Sender: TObject);
      procedure btnIPCameraStarttMP4RecordingClick(Sender: TObject);
      procedure btnIPCameraStopClick(Sender: TObject);
      procedure edtIPCameraURLChange(Sender: TObject);
      procedure btnPIPStopClick(Sender: TObject);
      procedure tbrPTZSpeedRatioChange(Sender: TObject);
      procedure btnPTZHelpDurationClick(Sender: TObject);
      procedure btnHelpPTZSpeedRatioClick(Sender: TObject);
      procedure PTZStopClick(Sender: TObject);
      procedure PTZButtonsMouseUp(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Integer);
      procedure edtPTZDurationMsChange(Sender: TObject);
      procedure btnPTZTiltUpMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Integer);
      procedure btnPTZPanLeftMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Integer);
      procedure btnPTZPanRightMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Integer);
      procedure btnPTZTiltDownMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Integer);
      procedure btnPTZZoomOutMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Integer);
      procedure btnPTZZoomInClick(Sender: TObject);
      procedure tbrPTZPanChange(Sender: TObject);
      procedure tbrPTZZoomChange(Sender: TObject);
      procedure tbrPTZTiltChange(Sender: TObject);
      procedure btnPTZSetTrackbarLimitsClick(Sender: TObject);
      procedure edtPTZRelativeMoveChange(Sender: TObject);
      procedure btnRelativeTiltUpClick(Sender: TObject);
      procedure btnRelativePanLeftClick(Sender: TObject);
      procedure btnRelativePanRightClick(Sender: TObject);
      procedure btnRelativeTiltDownClick(Sender: TObject);
      procedure btnRelativeZoomOutClick(Sender: TObject);
      procedure btnRelativeZoomInClick(Sender: TObject);
      procedure rgdHwAccelClick(Sender: TObject);
      procedure rdgIRCutFilterClick(Sender: TObject);
      procedure btnOneShotPngFileClick(Sender: TObject);
      procedure BtnOneShotTiffFileClick(Sender: TObject);
      procedure btnBurstModePNGFileClick(Sender: TObject);
      procedure btnBurstModeTIFFFileClick(Sender: TObject);
      procedure btnNDIStreamingOKClick(Sender: TObject);
      procedure btnViewNDIStreamingHelpClick(Sender: TObject);
      procedure btnNDIStreamingClientViewClick(Sender: TObject);
      procedure btnNDIClientHelpClick(Sender: TObject);
      procedure rdgPreferredVideoSizeClick(Sender: TObject);
      procedure chkretchPreferredVideoSizeClick(Sender: TObject);
      procedure chk360VideoDecodingClick(Sender: TObject);
      procedure edtDatasteadEncoder_Video_Bitrate_kbChange(Sender: TObject);
      procedure edtDatasteadEncoder_Video_rc_MinBitRate_kbChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Video_rc_MaxBitRate_kbChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Video_rc_BufferSize_kbChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Video_IDRIntervalChange(Sender: TObject);
      procedure edtDatasteadEncoder_Video_MaxBframesChange(Sender: TObject);
      procedure edtDatasteadEncoder_Video_ThreadCountChange(Sender: TObject);
      procedure edtDatasteadEncoder_Audio_SamplesPerSecondChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Audio_BitRate_kbChange(Sender: TObject);
      procedure BtnCodecExamplesClick(Sender: TObject);
      procedure mmoExtraParametersChange(Sender: TObject);
      procedure cmbGPUEncoderChange(Sender: TObject);
      procedure btnMultipurposeUDPStreamingClick(Sender: TObject);
      procedure btnResumeStreamingClick(Sender: TObject);
      procedure btnPauseStreamingClick(Sender: TObject);
      procedure edtDatasteadEncoder_VideoCodecNameChange(Sender: TObject);
      procedure edtDatasteadEncoder_AudioCodecNameChange(Sender: TObject);
      procedure btnNDISessionsClick(Sender: TObject);
      procedure edtNDIReceiveTimeoutChange(Sender: TObject);
      procedure btnONVIFReplayRecordingsListClick(Sender: TObject);
      procedure cboAutoFileNameChange(Sender: TObject);
      procedure btnIPCamStartPTZClick(Sender: TObject);
      procedure VideoGrabberFrameCaptureCompleted(Sender: TObject;
        FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: LongInt;
        FrameNumber: LongWord; FrameTime: LargeInteger;
        DestType: TFrameCaptureDest; FileName: string; Success: Boolean;
        FrameId: LongInt);
      procedure VideoGrabberReencodingProgress(Sender: TObject;
        Percent: LongInt; Position, Duration: LargeInteger);
      procedure VideoGrabberMotionDetected(Sender: TObject;
        GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: LongInt;
        FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
        FrameId: LongInt; var CaptureFrame: Boolean);
      procedure VideoGrabberMotionNotDetected(Sender: TObject;
        FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
        FrameId: LongInt; var CaptureFrame: Boolean);
	 procedure lsbOnvifURLsDiscoveredClick(Sender: TObject);
    procedure btnDiscoverONVIFFromMulticastClick(Sender: TObject);
    procedure btnDiscoverONVIFFromIPRangeClick(Sender: TObject);
    procedure btnCancelDiscoveryClick(Sender: TObject);
    procedure VideoGrabberONVIFDiscoveryCompleted(Sender: TObject;
      DiscoveryCallbackStatus: TDiscoveryCallbackStatus; CameraCount: LongInt);
    procedure chkUseExternalAudioforRTSPClick(Sender: TObject);

   private
      FStartupWidth: Integer;
      FStartupHeight: Integer;

      FTransparentForm: TForm;
      FTransparentPanel: TPanel;
      FSnapForm: TForm;
      FSnapImage: TImage;

      FImageOverlayIndex: LongInt;
      FTextOverlayIndex: LongInt;

      FDisplaySelected: LongInt;

      FKBWritten_LastReportTime: int64;

      FFreeHandMouseDrawing: array [0 .. FreeHandMouseCoordinatesMax +
        1] of TRect;
      FFreeHandMouseDrawingEnabled: Boolean;
      FiFreeHandMouseDrawing: LongInt;

      FSearchBmpFiles: TSearchRec;
      FSearchBmpFilesOpened: Boolean;
      FSearchBmpPath: String;

      FOldVideoSignalState: Boolean;

      FPTZSpeedRatio: Double;
      FPTZRelativeMove: Double;
      FUpdatingPTZTrackbars: Boolean;
      FPTZMoveDurationMs: LongInt;

      FMultipurposeUDPStreamingID: LongInt;

      procedure ShowFormAboveVideo(Form: TForm);
      procedure RefreshDeviceControls;
      procedure RefreshDisplayOptions;

      procedure TransparentFormButtonClick(Sender: TObject);
      procedure PTZStopContinuousMove();
      procedure DoPTZAbsolute();

      procedure ChangeVideoSource (VideoSource: TVideoSource);
   end;

var
   frmMainForm: TfrmMainForm;
   mpeRecordingExamplesForm: TForm = nil;
   mpeStreamingExamplesForm: TForm = nil;

implementation

uses
   typinfo,
   miscVideoQuality,
   miscCameraControl;

const
   AUDIO_CLIPS = '*.mp3;*.wav;*.wma;*.mid';
   VIDEO_CLIPS =
     '*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.wemb;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*';
   IMAGE_FILES = '*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png';
   OPEN_MEDIA_FILES = 'All media files|' + VIDEO_CLIPS + ';' + AUDIO_CLIPS + ';'
     + IMAGE_FILES + '|Video clips|' + VIDEO_CLIPS + '|Audio clips|' +
     AUDIO_CLIPS;
   OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES + '|Image files|' + IMAGE_FILES;
   OPEN_IMAGE_FILES =
     'Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg';
{$R *.DFM}
{$IFNDEF VER160}

function StrToFloatDef(const S: string; const Default: Extended): Extended;
begin
   if not TextToFloat(PChar(S), Result, fvExtended) then
      Result := Default;
end;
{$ENDIF VER160}

procedure AssignListToComboBox(ComboBox: TComboBox; List: String;
  Index: Integer);
begin
   ComboBox.Items.Text := List;
   if (ComboBox.Items.Count > 0) and (Index >= 0) then
   begin
      ComboBox.ItemIndex := Index;
   end;
end;

procedure TfrmMainForm.FormCreate(Sender: TObject);
begin
	VideoGrabber.SetDisplayAspectRatio(0, ar_Box);
   // preserves the aspect ratio in the display window, whatever the size of the control
   VideoGrabber.AutoRefreshPreview := true;
   // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

   FImageOverlayIndex := 0;
   FTextOverlayIndex := 0;

   FMultipurposeUDPStreamingID := -1;

   FFreeHandMouseDrawingEnabled := False; // used for free-hand mouse drawing
   FiFreeHandMouseDrawing := 0; // used for free-hand mouse drawing
   FSearchBmpFilesOpened := False;
   // used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

   FKBWritten_LastReportTime := 0;
   // used to store the last time, to report periodically the KB written from the OnFrameProgress event (in this demo every 5 seconds)

   FStartupWidth := Width;
   FStartupHeight := Height;

   FOldVideoSignalState := False;
   FDisplaySelected := 0;

   // pctMain.ActivePage := tbsVideoDevice;


   // - controls using global TVideoGrabber properties, e.g. like the VideoDevices list, are updated from the FormCreate event
   // - controls that depend of the current video device are set in the VideoDeviceSelected event
   // - controls that depend of the current audio device are set in the AudioDeviceSelected event

   /// ////////////////////// Controls on main form
   edtStoragePath.Text := VideoGrabber.StoragePath;

   /// ////////////////////// Video source tab
   AssignListToComboBox(cboVideoSource, VideoGrabber.VideoSources,
     Integer(VideoGrabber.VideoSource));
   AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices,
     VideoGrabber.VideoDevice);
   btnAutoRefreshPreview.Checked := VideoGrabber.AutoRefreshPreview;
   cboVideoSource.ItemIndex := Integer(VideoGrabber.VideoSource);
   chkScreenRecordingWithCursor.Checked :=
     VideoGrabber.ScreenRecordingWithCursor;
   edtMonitorNumber.Text := IntToStr(VideoGrabber.ScreenRecordingMonitor);
   VideoGrabber.VideoSource_FileOrUrl := edtVideoSourceFileOrUrl.Text;

   /// ////////////////////// Audio tab
   AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices,
     VideoGrabber.AudioDevice);
   AssignListToComboBox(cboAudioRenderers, VideoGrabber.AudioRenderers,
     VideoGrabber.AudioRenderer);
   chkRenderAudioDevice.Checked := VideoGrabber.AudioDeviceRendering;
   chkMuteAudioRendering.Checked := VideoGrabber.MuteAudioRendering;
   rdgVUMeters.ItemIndex := Integer(VideoGrabber.VUMeter);

   /// ////////////////////// RECORDING tab
   rdgRecordingMethod.ItemIndex := Integer(VideoGrabber.RecordingMethod);
   grbRecordingTimer.ItemIndex := Integer(VideoGrabber.RecordingTimer);
   if VideoGrabber.RecordingFileName <> '' then
   begin
      edtRecordingFileName.Text := VideoGrabber.RecordingFileName;
      chkAVISaveToThisFile.Checked := true;
   end;
   chkRecordingCanPause.Checked := VideoGrabber.RecordingCanPause;
   chkRecordingPauseCreatesNewFile.Checked :=
     VideoGrabber.RecordingPauseCreatesNewFile;
   chkPreserveNativeFormat.Checked := VideoGrabber.RecordingInNativeFormat;

   rdgCompressMode.ItemIndex := Integer(VideoGrabber.CompressionMode);
   chkAudioRecording.Checked := VideoGrabber.AudioRecording;
   AssignListToComboBox(cboVideoCompressors, VideoGrabber.VideoCompressors,
     VideoGrabber.VideoCompressor);
   AssignListToComboBox(cboAudioCompressors, VideoGrabber.AudioCompressors,
     VideoGrabber.AudioCompressor);

   /// ////////////////////// IP Camera tab
   chkOpenURLAsync.Checked := VideoGrabber.OpenURLAsync;
   tbrPTZSpeedRatio.Position := 100;
   // speed ratio in the 0..1 range and trackbar in the 0..100 range, so value = trackbar position / 100
   FPTZMoveDurationMs := 300; // 300 ms
   FPTZRelativeMove := 0.01;
   FPTZSpeedRatio := 0.5; //
   FUpdatingPTZTrackbars := False;

   /// ////////////////////// Player tab
   edtPlayerSpeedRatio.Text := FormatFloat('0.0',
     VideoGrabber.PlayerSpeedRatio);

   updPlayerFastSeekSpeed.Position := VideoGrabber.PlayerFastSeekSpeedRatio;
   edtPlayerFastSeekSpeed.Text :=
     IntToStr(VideoGrabber.PlayerFastSeekSpeedRatio);

   btnAutoPlay.Checked := VideoGrabber.AutoStartPlayer;
   chkPlayerAudioRendering.Checked := VideoGrabber.PlayerAudioRendering;
   chkUseClock.Checked := VideoGrabber.UseClock;
   chkRefreshPausedDisplay.Checked := VideoGrabber.PlayerRefreshPausedDisplay;

   rgdHwAccel.ItemIndex := Integer(VideoGrabber.PlayerHWAccel);

   /// ////////////////////// Frame grabber tab
   edtAVIAutoFilePrefix.Text := VideoGrabber.AutoFilePrefix;
   rgdFrameGrabberFormat.ItemIndex :=
     Integer(VideoGrabber.FrameGrabberRGBFormat);
   rgdFrameGrabber.ItemIndex := Integer(VideoGrabber.FrameGrabber);
   cboAutoFileName.ItemIndex := Integer(VideoGrabber.AutoFileName);
   edtFrameCaptureWidth.Text := IntToStr(VideoGrabber.FrameCaptureWidth);
   edtFrameCaptureHeight.Text := IntToStr(VideoGrabber.FrameCaptureHeight);

   /// ////////////////////// Frame capture tab
   edtBurstCount.Text := IntToStr(VideoGrabber.BurstCount);
   edtBurstInterval.Text := IntToStr(VideoGrabber.BurstInterval);
   tbrCaptureZoomSize.Position := VideoGrabber.FrameCaptureZoomSize;

   /// ////////////////////// Motion detection tab

   chkMotionDetectionEnabled.Checked := VideoGrabber.MotionDetector_Enabled;
   chkCompareRed.Checked := VideoGrabber.MotionDetector_CompareRed;
   chkCompareGreen.Checked := VideoGrabber.MotionDetector_CompareGreen;
   chkCompareBlue.Checked := VideoGrabber.MotionDetector_CompareBlue;
   chk_GreyScale.Checked := VideoGrabber.MotionDetector_GreyScale;
   chkReduceVideoNoise.Checked := VideoGrabber.MotionDetector_ReduceVideoNoise;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
   edtGridColCount.Text := IntToStr(VideoGrabber.MotionDetector_GridXCount);
   edtGridRowCount.Text := IntToStr(VideoGrabber.MotionDetector_GridYCount);
   chkTriggered.Checked := VideoGrabber.MotionDetector_Triggered;

   /// ////////////////////// Overlay tab
   rdgImageOverlaySelector.ItemIndex := 0;
   rdgImageOverlaySelectorClick(Self);
   // reloads the image overlay settings for the index 0
   chkAdjustOverlayAspectRatio.Checked := VideoGrabber.AdjustOverlayAspectRatio;

   rdgTextOverlaySelector.ItemIndex := 0;
   rdgTextOverlaySelectorClick(Self);
   // reloads the text overlay settings for the index 0

   /// ////////////////////// Video processing tab
   rdgVideoRotation.ItemIndex := Integer(VideoGrabber.VideoProcessing_Rotation);
   tbrBrightness.Position := -VideoGrabber.VideoProcessing_Brightness;
   tbrConstrast.Position := -VideoGrabber.VideoProcessing_Contrast;
   tbrSaturation.Position := -VideoGrabber.VideoProcessing_Saturation;
   tbrHue.Position := VideoGrabber.VideoProcessing_Hue;
   edtCustomRotationAngle.Text := FormatFloat('0.00',
     VideoGrabber.VideoProcessing_RotationCustomAngle);

   rdgDeinterlacing.ItemIndex :=
     Integer(VideoGrabber.VideoProcessing_Deinterlacing);
   chkGreyScale.Checked := VideoGrabber.VideoProcessing_GrayScale;
   chkInvertColors.Checked := VideoGrabber.VideoProcessing_InvertColors;
   chkFlipVertical.Checked := VideoGrabber.VideoProcessing_FlipVertical;
   chkFlipHorizontal.Checked := VideoGrabber.VideoProcessing_FlipHorizontal;

   chkCroppingEnabled.Checked := VideoGrabber.Cropping_Enabled;
   chkCroppingOutbounds.Checked := VideoGrabber.Cropping_Outbounds;
   edtCroppingWidth.Text := IntToStr(VideoGrabber.Cropping_Width);
   edtCroppingHeight.Text := IntToStr(VideoGrabber.Cropping_Height);
   trkCroppingZoom.Position := Round(VideoGrabber.Cropping_Zoom * 100);

   // trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
   trkCroppingY.Position := VideoGrabber.Cropping_Y;
   trkCroppingX.Position := VideoGrabber.Cropping_X;

   /// ////////////////////// Display tab
   VideoGrabber.SetDisplayTransparentColorValue(0, $0000FF);
   VideoGrabber.SetDisplayTransparentColorValue(1, $FF0000);

   chkZeroLatency.Checked := (VideoGrabber.SyncPreview = sp_Disabled);
   chkVideoVisibleWhenStopped.Checked := VideoGrabber.VideoVisibleWhenStopped;
   chkAdjustPixelAspectRatio.Checked := VideoGrabber.AdjustPixelAspectRatio;
   chkBorder.Checked := VideoGrabber.BorderStyle = bsSingle;
   chkTransparency.Checked := VideoGrabber.ColorKeyEnabled;
   rdgVideoRenderer.ItemIndex := Integer(VideoGrabber.VideoRenderer);
   RefreshDisplayOptions;

   /// ////////////////////// reencoding tab
   chkWMVOutput.Checked := VideoGrabber.Reencoding_WMVOutput;
   chkIncludeVideoStream.Checked := VideoGrabber.Reencoding_IncludeVideoStream;
   chkIncludeAudioStream.Checked := VideoGrabber.Reencoding_IncludeAudioStream;
   chkUseFrameGrabber.Checked := VideoGrabber.Reencoding_UseFrameGrabber;
   chkUseCurrentVideoCompressor.Checked :=
     VideoGrabber.Reencoding_UseVideoCompressor;
   chkUseCurrentAudioCompressor.Checked :=
     VideoGrabber.Reencoding_UseAudioCompressor;
   edtReencStartTime.Text := IntToStr(VideoGrabber.Reencoding_StartTime);
   edtReencStopTime.Text := IntToStr(VideoGrabber.Reencoding_StopTime);
   edtReencStartFrame.Text := IntToStr(VideoGrabber.Reencoding_StartFrame);
   edtReencStopFrame.Text := IntToStr(VideoGrabber.Reencoding_StopFrame);
   rdgReencodingMethod.ItemIndex := Integer(VideoGrabber.Reencoding_Method);

end;

/// /////////////////////////////////////////////////////////////////////////////
// VIDEO DEVICE TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.VideoGrabberVideoDeviceSelected(Sender: TObject);
begin
   cboVideoDevices.ItemIndex := VideoGrabber.VideoDevice;
   // be sure the listbox index matches the current index value

   // from this event update the properties that depend of the current video capture device.
   // This event occurs when a new value is assigned to the VideoDevice property.
   RefreshDeviceControls;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.ChangeVideoSource (VideoSource: TVideoSource);
var
   VideoSourceName: string;
begin
   if VideoGrabber.VideoSource <> VideoSource then begin
      VideoGrabber.VideoSource := VideoSource;
      case VideoSource of
         vs_VideoCaptureDevice: begin
            cboVideoSource.ItemIndex := 0;
            VideoSourceName := 'vs_VideoCaptureDevice';
         end;
         vs_ScreenRecording: begin
            cboVideoSource.ItemIndex := 1;
            VideoSourceName := 'vs_ScreenRecording';
         end;
         vs_VideoFileOrURL: begin
            cboVideoSource.ItemIndex := 2;
            VideoSourceName := 'vs_VideoFileOrURL';
         end;
         vs_JPEGsOrBitmaps: begin
            cboVideoSource.ItemIndex := 3;
            VideoSourceName := 'vs_JPEGsOrBitmaps';
         end;
         vs_IPCamera: begin
            cboVideoSource.ItemIndex := 4;
            VideoSourceName := 'vs_IPCamera';
         end;
         vs_Mixer: begin
            cboVideoSource.ItemIndex := 5;
            VideoSourceName := 'vs_Mixer';
         end;
      else
         VideoSourceName := '';
         mmoLog.Lines.Add('this "VideoSource" option is not used in this demo');
      end;
      if VideoSourceName <> '' then begin
         mmoLog.Lines.Add('changing VideoSource to: ' + VideoSourceName);
      end;
   end;
end;

procedure TfrmMainForm.cboVideoSourceChange(Sender: TObject);
begin
   ChangeVideoSource (TVideoSource (cboVideoSource.ItemIndex));
end;

procedure TfrmMainForm.cboVideoDevicesChange(Sender: TObject);
begin
   if cboVideoDevices.ItemIndex >= 0 then begin
      ChangeVideoSource (vs_VideoCaptureDevice);
   end;
   VideoGrabber.VideoDevice := cboVideoDevices.ItemIndex;
   // when selecting another video capture device, the OnVideoDeviceSelected event occurs.
   // be sure to refresh all your device-dependent controls from the OnVideoDeviceSelected event.
end;

procedure TfrmMainForm.btnStartPreviewClick(Sender: TObject);
begin
   VideoGrabber.StartPreview;
end;

procedure TfrmMainForm.btnPausePreviewClick(Sender: TObject);
begin
   VideoGrabber.PausePreview;
end;

procedure TfrmMainForm.btnResumePreviewClick(Sender: TObject);
begin
   VideoGrabber.ResumePreview;
end;

procedure TfrmMainForm.btnStopPreviewClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.btnAutoRefreshPreviewClick(Sender: TObject);
begin
   VideoGrabber.AutoRefreshPreview := btnAutoRefreshPreview.Checked;
end;

procedure TfrmMainForm.chkEnableSnapshotButtonClick(Sender: TObject);
begin
   if chkEnableSnapshotButton.Enabled then
   begin
      VideoGrabber.WebcamStillCaptureButton := wb_Enabled;
   end
   else
   begin
      VideoGrabber.WebcamStillCaptureButton := wb_Disabled;
   end;
end;

procedure TfrmMainForm.cboVideoInputsChange(Sender: TObject);
begin
   VideoGrabber.VideoInput := cboVideoInputs.ItemIndex;
end;

procedure TfrmMainForm.cboVideoFormatsChange(Sender: TObject);
begin
   VideoGrabber.VideoFormat := cboVideoFormats.ItemIndex;
   AssignListToComboBox(cboVideoSizes, VideoGrabber.VideoSizes,
     VideoGrabber.VideoSize); // updates VideoSizes accordingly
   AssignListToComboBox(cboVideoSubtypes, VideoGrabber.VideoSubtypes,
     VideoGrabber.VideoSubtype); // updates VideoSubtypes accordingly
end;

procedure TfrmMainForm.cboVideoSizesChange(Sender: TObject);
begin
   VideoGrabber.VideoSize := cboVideoSizes.ItemIndex;
   AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats,
     VideoGrabber.VideoFormat); // updates VideoFormats accordingly
end;

procedure TfrmMainForm.cboVideoSubtypesChange(Sender: TObject);
begin
   VideoGrabber.VideoSubtype := cboVideoSubtypes.ItemIndex;
   AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats,
     VideoGrabber.VideoFormat); // updates VideoFormats accordingly
end;

procedure TfrmMainForm.cboAnalogVideoStandardChange(Sender: TObject);
begin
   VideoGrabber.AnalogVideoStandard := cboAnalogVideoStandard.ItemIndex;
end;

procedure TfrmMainForm.chkSetLogoClick(Sender: TObject);
begin
   if chkSetLogo.Checked then
   begin
      VideoGrabber.SetLogoFromTImage(imgLogo);
      VideoGrabber.LogoLayout := lg_Stretched;
      VideoGrabber.LogoDisplayed := true;
   end
   else
   begin
      VideoGrabber.LogoDisplayed := False;
   end;
end;

procedure TfrmMainForm.btnDeviceDialogClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_VideoDevice);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.btnCameraControlDialogClick(Sender: TObject);
begin
   ShowFormAboveVideo(frmCameraControl);
end;

procedure TfrmMainForm.btnCancelDiscoveryClick(Sender: TObject);
begin
	VideoGrabber.ONVIFCancelDiscovery();
end;

procedure TfrmMainForm.btnVideoQualityDialogClick(Sender: TObject);
begin
   ShowFormAboveVideo(frmVideoQuality);
end;

procedure TfrmMainForm.btnFrameRateClick(Sender: TObject);
var
   Value: Double;
begin
   Value := StrToFloatDef(edtFrameRate.Text, -1);
   VideoGrabber.FrameRate := Value;

   if VideoGrabber.CurrentState = cs_Preview then
   begin
      mmoLog.Lines.Add('current frame rate: ' + FormatFloat('0.00',
        VideoGrabber.CurrentFrameRate) + ' fps.');
   end;
end;

procedure TfrmMainForm.btnAboutFrameRateClick(Sender: TObject);
begin
   ShowMessage('0 means that the default frame rate of the device will be used.'
     + #13#10 + 'After the OnPreviewStarted or OnRecordingStarted event occurs,'
     + #13#10 + 'its value is available in the CurrentFrameRate property.');
end;

procedure TfrmMainForm.btnSelectFileOrUrlClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then
   begin
      edtVideoSourceFileOrUrl.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.edtVideoSourceFileOrUrlChange(Sender: TObject);
begin
   VideoGrabber.VideoSource_FileOrUrl := edtVideoSourceFileOrUrl.Text;
end;

procedure TfrmMainForm.VideoSourceFileOrUrl_UserNameChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication(at_StreamingUrl,
     VideoSourceFileOrUrl_UserName.Text, VideoSourceFileOrUrl_Password.Text);
end;

procedure TfrmMainForm.VideoSourceFileOrUrl_PasswordChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication(at_StreamingUrl,
     VideoSourceFileOrUrl_UserName.Text, VideoSourceFileOrUrl_Password.Text);
end;

procedure TfrmMainForm.btnUrlConfClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_NetShowConfig);
end;

procedure TfrmMainForm.btnScreenRecordingWindowClick(Sender: TObject);
begin
   VideoGrabber.SetWindowRecordingByName(edtScreenRecordingWindow.Text, False);
   // set to "true" for an exact and case-sensitive match
end;

procedure TfrmMainForm.chkScreenRecordingWithCursorClick(Sender: TObject);
begin
   VideoGrabber.ScreenRecordingWithCursor :=
     chkScreenRecordingWithCursor.Checked;
end;

procedure TfrmMainForm.edtMonitorNumberChange(Sender: TObject);
begin
   VideoGrabber.ScreenRecordingMonitor := StrToIntDef(edtMonitorNumber.Text, 0);
end;

procedure TfrmMainForm.btnMonitorNumberInfoClick(Sender: TObject);
begin
   ShowMessage('-1 = full desktop, 0 = 1st monitor, 1 = 2nd monitor, etc...');
end;

procedure TfrmMainForm.btnMultipurposeUDPStreamingClick(Sender: TObject);
begin
   if FMultipurposeUDPStreamingID = -1 then
   begin
      FMultipurposeUDPStreamingID :=
        VideoGrabber.Encoders_CreateInstanceForStreaming
        ('udp://239.255.0.1:10124');
   end;
   if FMultipurposeUDPStreamingID > -1 then
   begin
      /// uncomment one of the lines below to use a specific codec, e.g.:
      // VideoGrabber.Encoder_SetStr (FMultipurposeUDPStreamingID, Enc_Video_Codec, 'hevc');
      // VideoGrabber.Encoder_SetStr (FMultipurposeUDPStreamingID, Enc_Video_Codec, 'h264');

      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_Enabled_bool, 1);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Audio_Enabled_bool, 1);
      if not chkStreamingVideoEnabled.Checked then
      begin
         VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
           Enc_Video_Enabled_bool, 0);
      end;
      if not chkStreamingAudioEnabled.Checked then
      begin
         VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
           Enc_Audio_Enabled_bool, 0);
      end;
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_BitRate_kb, 2000);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_rc_MinBitRate_kb, 1800);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_rc_MaxBitRate_kb, 2200);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_IDR_Interval, 30);
      /// uncomment to enable the GPU encoder, if available for h264 or hevc
      // VideoGrabber.Encoder_SetInt (FStreamingEncoderId, Enc_Video_GPU_Encoder, LongInt (Enc_GPU_Auto));  // or specify directly Enc_GPU_Intel_QSV, Enc_GPU_NVidia_NVENC or Enc_GPU_AMD_AMF
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_IsActive_bool, 1);
   end;
end;

procedure TfrmMainForm.btnPauseStreamingClick(Sender: TObject);
begin
   VideoGrabber.Encoder_Pause(FMultipurposeUDPStreamingID);
end;

procedure TfrmMainForm.btnResumeStreamingClick(Sender: TObject);
begin
   VideoGrabber.Encoder_Resume(FMultipurposeUDPStreamingID);
end;

procedure TfrmMainForm.VideoGrabberPreviewStarted(Sender: TObject);
begin
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('video source size: ' + IntToStr(VideoGrabber.VideoWidth) +
     'x' + IntToStr(VideoGrabber.VideoHeight));
   mmoLog.Lines.Add('display aspect ratio: ' +
     IntToStr(VideoGrabber.VideoWidth_PreferredAspectRatio) + 'x' +
     IntToStr(VideoGrabber.VideoHeight_PreferredAspectRatio));
   mmoLog.Lines.Add('current frame rate: ' + FormatFloat('0.00',
     VideoGrabber.CurrentFrameRate) + ' fps.');
   mmoLog.Lines.Add('');
end;

/// /////////////////////////////////////////////////////////////////////////////
// AUDIO TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.VideoGrabberAudioDeviceSelected(Sender: TObject);
begin
   // from this event set the parameters that change when the current audio capture device change
   cboAudioDevices.ItemIndex := VideoGrabber.AudioDevice;
   // be sure the listbox index matches the current index value

   AssignListToComboBox(cboAudioInputs, VideoGrabber.AudioInputs,
     Integer(VideoGrabber.AudioInput));
   tbrAudioInputLevel.Position := VideoGrabber.AudioInputLevel;
   tbrAudioInputBalance.Position := VideoGrabber.AudioInputBalance;
end;

procedure TfrmMainForm.btnStartAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.StartAudioRendering;
   if not VideoGrabber.AudioDeviceRendering then
   begin
      if btnStartAudioRendering.Tag = 0 then
      begin
         btnStartAudioRendering.Tag := 1; // to show the popup only one time
         ShowMessage
           ('StartAudioRendering acts as "preview", e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers');
      end;
   end;
end;

procedure TfrmMainForm.btnStartWAVRecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_NoCompression;
   VideoGrabber.RecordingMethod := rm_AVI;
   VideoGrabber.StartAudioRecording;
end;

procedure TfrmMainForm.btnStartMP3RecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_CompressOnTheFly;
   VideoGrabber.CompressionType := ct_Audio;
   VideoGrabber.RecordingMethod := rm_AVI;
   VideoGrabber.AudioCompressor := VideoGrabber.FindIndexInListByName
     (VideoGrabber.AudioCompressors, 'LAME Audio Encoder', False, true);
   if VideoGrabber.AudioCompressor = -1 then
   begin
      ShowMessage
        ('The LAME 3.99.5 DirectShow Filter is required, download it from https://www.rarewares.org/mp3-lame-dshow-acm.php and register lame.ax with regsvr32.exe');
   end
   else
   begin
      VideoGrabber.StartAudioRecording;
   end;
end;

procedure TfrmMainForm.btnStartASFRecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_NoCompression;
   VideoGrabber.RecordingMethod := rm_ASF;
   VideoGrabber.StartAudioRecording;
end;

procedure TfrmMainForm.btnStopAudioClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.chkRenderAudioDeviceClick(Sender: TObject);
begin
   VideoGrabber.AudioDeviceRendering := chkRenderAudioDevice.Checked;
end;

procedure TfrmMainForm.cboAudioDevicesChange(Sender: TObject);
begin
   VideoGrabber.AudioDevice := cboAudioDevices.ItemIndex;
end;

procedure TfrmMainForm.cboAudioInputsChange(Sender: TObject);
begin
   VideoGrabber.AudioInput := cboAudioInputs.ItemIndex;
end;

procedure TfrmMainForm.tbrAudioInputLevelChange(Sender: TObject);
begin
   VideoGrabber.AudioInputLevel := tbrAudioInputLevel.Position;
end;

procedure TfrmMainForm.tbrAudioInputBalanceChange(Sender: TObject);
begin
   VideoGrabber.AudioInputBalance := tbrAudioInputBalance.Position;
end;

procedure TfrmMainForm.cboAudioRenderersChange(Sender: TObject);
begin
   VideoGrabber.AudioRenderer := cboAudioRenderers.ItemIndex;
end;

procedure TfrmMainForm.cboAutoFileNameChange(Sender: TObject);
begin
   VideoGrabber.AutoFileName := TAutoFileName(cboAutoFileName.ItemIndex);
end;

procedure TfrmMainForm.tbrAudioVolumeChange(Sender: TObject);
begin
   VideoGrabber.AudioVolume := tbrAudioVolume.Position;
end;

procedure TfrmMainForm.tbrAudioBalanceChange(Sender: TObject);
begin
   VideoGrabber.AudioBalance := tbrAudioBalance.Position;
end;

procedure TfrmMainForm.chkMuteAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.MuteAudioRendering := chkMuteAudioRendering.Checked;
end;

procedure TfrmMainForm.rdgVUMetersClick(Sender: TObject);
const
   VU_LEFT = 0;
   VU_RIGHT = 1;
begin
   case rdgVUMeters.ItemIndex of
      0:
         begin
            VideoGrabber.VUMeter := vu_Disabled;
         end;
      1:
         begin
            VideoGrabber.VUMeter := vu_Analog;

            pnLeftVUMeter.Width := (pnLeftVUMeter.Height * 4) div 3;
            pnRightVUMeter.Width := (pnRightVUMeter.Height * 4) div 3;

            VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_bkGndColor, clBlack);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_bkGndColor, clBlack);
         end;
      2:
         begin
            VideoGrabber.VUMeter := vu_Bargraph;

            pnLeftVUMeter.Width := (pnLeftVUMeter.Height * 2) div 10;
            pnRightVUMeter.Width := (pnRightVUMeter.Height * 2) div 10;

            VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_bkGndColor,
              TColor($404040));
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_bkGndColor,
              TColor($404040));

         end;
   end;
   if VideoGrabber.VUMeter <> vu_Disabled then
   begin
      VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_Handle, pnLeftVUMeter.Handle);
      // we use a TPanel to display the VU meters,
      VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_Handle,
        pnRightVUMeter.Handle);
      // this is activated by assigning the TPanel's handle...
   end
   else
   begin
      VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_Handle, 0);
      // ...and the TPanel is freed by passing 0 as handle
      VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_Handle, 0);
   end;
end;

procedure TfrmMainForm.btnBargraphOverlayClick(Sender: TObject);
var
   i: LongInt;
begin
   VideoGrabber.SetVUMeterSetting(2, vu_OverlayLeft, 10);
   VideoGrabber.SetVUMeterSetting(3, vu_OverlayLeft, 140);
   for i := 2 to 3 do
   begin
      VideoGrabber.SetVUMeter_Enabled(i, vu_BargraphOverlay);
      VideoGrabber.SetVUMeterSetting(i, vu_Transparent, 1);
      VideoGrabber.SetVUMeterSetting(i, vu_OverlayTop, 10);
      VideoGrabber.SetVUMeterSetting(i, vu_OverlayWidth, 100);
      VideoGrabber.SetVUMeterSetting(i, vu_OverlayHeight, 60);
      VideoGrabber.SetVUMeterSetting(i, vu_bkGndColor, $800000);
      VideoGrabber.SetVUMeterSetting(i, vu_NormalColor, $000080);
      VideoGrabber.SetVUMeterSetting(i, vu_WarningColor, $00A5FF);
      VideoGrabber.SetVUMeterSetting(i, vu_PeakColor, $00FFFF);
      VideoGrabber.SetVUMeterSetting(i, vu_WarningPercent, 20);
      VideoGrabber.SetVUMeterSetting(i, vu_PeakPercent, 40);
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// RECORDING TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnStartRecordingImmediatelyClick(Sender: TObject);
begin
   VideoGrabber.HoldRecording := False;
   // let's start recording as soon as the graph is built.
   VideoGrabber.StartRecording;
end;

procedure TfrmMainForm.btnStartRecordingControlledClick(Sender: TObject);
begin
   VideoGrabber.HoldRecording := true;
   VideoGrabber.StartRecording;

   // Enabling HoldRecording prevents the recording to start when the recording graph is built.
   // after the OnRecordingReadyToStart event occurs, you can accurately start the
   // recording by invoking ResumeRecording.
end;

procedure TfrmMainForm.btnStopRecordingClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.btnRenewRecordingFileClick(Sender: TObject);
begin
   VideoGrabber.RecordToNewFileNow(edtNewFileDuringRecording.Text, true);
end;

procedure TfrmMainForm.rdgRecordingMethodClick(Sender: TObject);
begin
   VideoGrabber.RecordingMethod :=
     TRecordingMethod(rdgRecordingMethod.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.chkRecordingCanPauseClick(Sender: TObject);
begin
   VideoGrabber.RecordingCanPause := chkRecordingCanPause.Checked;
   RefreshDeviceControls;
end;

procedure TfrmMainForm.chkRecordingPauseCreatesNewFileClick(Sender: TObject);
begin
   VideoGrabber.RecordingPauseCreatesNewFile :=
     chkRecordingPauseCreatesNewFile.Checked;
end;

procedure TfrmMainForm.chkRecordingOnMotionClick(Sender: TObject);
begin
   VideoGrabber.RecordingOnMotion_Enabled := chkRecordingOnMotion.Checked;
   chkRecordingCanPause.Checked := chkRecordingOnMotion.Checked;
end;

procedure TfrmMainForm.btnPauseRecordingClick(Sender: TObject);
begin
   VideoGrabber.PauseRecording;
end;

procedure TfrmMainForm.btnResumeRecordingClick(Sender: TObject);
begin
   VideoGrabber.ResumeRecording;
end;

procedure TfrmMainForm.chkAVISaveToThisFileClick(Sender: TObject);
begin
   if chkAVISaveToThisFile.Checked then
   begin
      VideoGrabber.RecordingFileName := edtRecordingFileName.Text;
   end
   else
   begin
      VideoGrabber.RecordingFileName := '';
   end;
end;

procedure TfrmMainForm.edtRecordingFileNameChange(Sender: TObject);
begin
   if chkAVISaveToThisFile.Checked then
   begin
      VideoGrabber.RecordingFileName := edtRecordingFileName.Text;
   end;
end;

procedure TfrmMainForm.chkAudioRecordingClick(Sender: TObject);
begin
   VideoGrabber.AudioRecording := chkAudioRecording.Checked;
   RefreshDeviceControls;
end;

procedure TfrmMainForm.grbRecordingTimerClick(Sender: TObject);
begin
   VideoGrabber.RecordingTimer := TRecordingTimer(grbRecordingTimer.ItemIndex);
   VideoGrabber.RecordingTimerInterval :=
     StrToIntDef(edtRecordingTimerInterval.Text, 0);
end;

procedure TfrmMainForm.edtRecordingTimerIntervalChange(Sender: TObject);
begin
   VideoGrabber.RecordingTimerInterval :=
     StrToIntDef(edtRecordingTimerInterval.Text, 0);
end;

procedure TfrmMainForm.chkPreserveNativeFormatClick(Sender: TObject);
begin
   VideoGrabber.RecordingInNativeFormat := chkPreserveNativeFormat.Checked;
end;

procedure TfrmMainForm.cboVideoCompressorsChange(Sender: TObject);
begin
   VideoGrabber.VideoCompressor := cboVideoCompressors.ItemIndex;
end;

procedure TfrmMainForm.cboAudioCompressorsChange(Sender: TObject);
begin
   VideoGrabber.AudioCompressor := cboAudioCompressors.ItemIndex;
end;

function GetRecordingMethodName(Value: TRecordingMethod): string;
begin
   case Value of
      rm_ASF:
         Result := 'rm_ASF';
      rm_SendToDV:
         Result := 'rm_sDV';
      rm_MKV:
         Result := 'rm_MKV';
      rm_FLV:
         Result := 'rm_FLV';
      rm_MP4:
         Result := 'rm_MP4';
      rm_MPG:
         Result := 'rm_MPG';
      rm_Multiplexer:
         Result := 'rm_Mux';
   else
      Result := 'rm_AVI';
   end;
end;

procedure TfrmMainForm.btnVideoCompressorSettingsClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_VideoCompressor);
end;

procedure TfrmMainForm.btnAudioCompressorSettingsClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_AudioCompressor);
end;

procedure TfrmMainForm.rdgCompressModeClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := TCompressionMode(rdgCompressMode.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.VideoGrabberRecordingReadyToStart(Sender: TObject);
begin
   if MessageDlg('Ready to start recording!', mtInformation, [MbOk, MbCancel],
     0) = MrOk then
   begin
      VideoGrabber.ResumeRecording;
   end
   else
   begin
      VideoGrabber.Stop;
   end;
end;

procedure TfrmMainForm.VideoGrabberRecordingStarted(Sender: TObject;
  FileName: String);
begin
   mmoLog.Lines.Add('recording to ' + FileName + ':');
   mmoLog.Lines.Add(IntToStr(VideoGrabber.RecordingWidth) + 'x' +
     IntToStr(VideoGrabber.RecordingHeight));
   mmoLog.Lines.Add('current frame rate: ' + FormatFloat('0.00',
     VideoGrabber.CurrentFrameRate) + ' fps.');
   FKBWritten_LastReportTime := 0;
end;

procedure TfrmMainForm.VideoGrabberReencodingProgress(Sender: TObject;
  Percent: LongInt; Position, Duration: LargeInteger);
begin
   mmoLog.Lines.Add(IntToStr(Percent) + '% completed...');
end;

procedure TfrmMainForm.VideoGrabberRecordingPaused(Sender: TObject);
begin
   mmoLog.Lines.Add('recording paused...');
end;

procedure TfrmMainForm.VideoGrabberRecordingCompleted(Sender: TObject;
  FileName: String; Success: Boolean);
begin
   if Success then
   begin
      mmoLog.Lines.Add(FileName + ' successfully created.');
      mmoLog.Lines.Add('size: ' +
        IntToStr(VideoGrabber.RecordingKBytesWrittenToDisk) + ' KB');
   end
   else
   begin
      mmoLog.Lines.Add('recording failed.');
   end;
end;

procedure TfrmMainForm.VideoGrabberReencodingStarted(Sender: TObject;
  SourceFile, DestFile: String);
begin
   mmoLog.Lines.Add('reencoding ' + SourceFile + ' to ' + DestFile + '...');
end;

procedure TfrmMainForm.VideoGrabberReencodingCompleted(Sender: TObject;
  SourceFile, DestFile: String; Success: Boolean);
begin
   if Success then
   begin
      mmoLog.Lines.Add(SourceFile + ' successfully reencoded to ' + DestFile);
   end
   else
   begin
      mmoLog.Lines.Add('Failed to reencode ' + SourceFile + ' to ' + DestFile);
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// FRAME GRABBER TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.rgdFrameGrabberClick(Sender: TObject);
begin
   VideoGrabber.FrameGrabber := TFrameGrabber(rgdFrameGrabber.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.rgdFrameGrabberFormatClick(Sender: TObject);
begin
   VideoGrabber.FrameGrabberRGBFormat :=
     TFrameGrabberRGBFormat(rgdFrameGrabberFormat.ItemIndex);
end;

procedure TfrmMainForm.edtAVIAutoFilePrefixChange(Sender: TObject);
begin
   VideoGrabber.AutoFilePrefix := edtAVIAutoFilePrefix.Text;
end;

procedure TfrmMainForm.btnOneShotTBitmapClick(Sender: TObject);
begin
   VideoGrabber.CaptureFrameTo(fc_TBitmap, '');
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotBMPFileClick(Sender: TObject);
begin
   if chkUseThisFileName.Checked then
   begin
      VideoGrabber.CaptureFrameTo(fc_BmpFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_BmpFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotJPEGFileClick(Sender: TObject);
begin
   if chkUseThisFileName.Checked then
   begin
      VideoGrabber.CaptureFrameTo(fc_JpegFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_JpegFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotPngFileClick(Sender: TObject);
begin
   if chkUseThisFileName.Checked then
   begin
      VideoGrabber.CaptureFrameTo(fc_PngFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_PngFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.BtnOneShotTiffFileClick(Sender: TObject);
begin
   if chkUseThisFileName.Checked then
   begin
      VideoGrabber.CaptureFrameTo(fc_TiffFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_TiffFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotClipboardClick(Sender: TObject);
begin
   VideoGrabber.CaptureFrameTo(fc_Clipboard, '');
end;

procedure TfrmMainForm.chkUseThisFileNameClick(Sender: TObject);
begin
   edtUseThisFileName.Enabled := chkUseThisFileName.Checked;
end;

procedure TfrmMainForm.btnBurstModeTBitmapClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_TBitmap;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeBMPFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_BmpFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // BMP file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeJPEGFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_JpegFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeClipboardClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_Clipboard;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
end;

procedure TfrmMainForm.btnBurstModePNGFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_PngFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeTIFFFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_TiffFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeStopClick(Sender: TObject);
begin
   VideoGrabber.BurstMode := False;
end;

procedure TfrmMainForm.edtBurstCountChange(Sender: TObject);
begin
   VideoGrabber.BurstCount := StrToIntDef(edtBurstCount.Text, 1);
end;

procedure TfrmMainForm.chkModuloClick(Sender: TObject);
begin
   if chkModulo.Checked then
   begin
      VideoGrabber.AutoFileName := fn_Modulo;
   end;
end;

procedure TfrmMainForm.edtBurstIntervalChange(Sender: TObject);
begin
   VideoGrabber.BurstInterval := StrToIntDef(edtBurstInterval.Text, 1);
end;

procedure TfrmMainForm.tbrCaptureZoomSizeChange(Sender: TObject);
begin
   VideoGrabber.FrameCaptureZoomSize := tbrCaptureZoomSize.Position;
   edtCaptureZoomSize.Text := IntToStr(tbrCaptureZoomSize.Position) + '%';
end;

procedure TfrmMainForm.btnResetCaptureZoomSizeClick(Sender: TObject);
begin
   tbrCaptureZoomSize.Position := 100;
end;

procedure TfrmMainForm.edtFrameCaptureWidthChange(Sender: TObject);
begin
   VideoGrabber.FrameCaptureWidth := StrToIntDef(edtFrameCaptureWidth.Text, -1);
end;

procedure TfrmMainForm.edtFrameCaptureHeightChange(Sender: TObject);
begin
   VideoGrabber.FrameCaptureHeight :=
     StrToIntDef(edtFrameCaptureHeight.Text, -1);
end;

procedure TfrmMainForm.VideoGrabberFrameProgress2(Sender: TObject;
  FrameInfo: pFrameInfo);
var
   KbWritten: DWORD;
begin
   with FrameInfo^ do
   begin
      if CurrentState = cs_Playback then
      begin // no dropped frames in playback mode
         edtFrameCount.Text := Format('frame: %d time:%.2d:%.2d:%.2d %.2d',
           [FrameNumber, FrameTime_Hour, FrameTime_Min, FrameTime_Sec,
           FrameTime_Hs]);
      end
      else
      begin
         edtFrameCount.Text :=
           Format('frame: %d dropped: %d time:%.2d:%.2d:%.2d %.2d',
           [FrameNumber, DroppedFrameCount, FrameTime_Hour, FrameTime_Min,
           FrameTime_Sec, FrameTime_Hs]);
      end;

      if VideoGrabber.CurrentState = cs_Recording then
      begin
         if (FrameTime - FKBWritten_LastReportTime) > 50000000 then
         begin // 5 seconds
            FKBWritten_LastReportTime := FrameTime;
            KbWritten := VideoGrabber.RecordingKBytesWrittenToDisk;
            if KbWritten > 0 then
            begin
               mmoLog.Lines.Add('written to disk: ' +
                 IntToStr(KbWritten) + ' KB');
            end;
         end;
      end;
      if FrameInfo^.NTPFrameTime > 0 then
      begin
         edtIPCameraNTPTime.Text := 'ntp: ' + IntToStr(FrameInfo^.NTPFrameTime);
      end;
   end;
end;

procedure CopyFrameToBitmapDemo(BitmapInfo: pFrameBitmapInfo);
var
   NewBitmap: TBitmap;
begin
   // this code shows how to make a copy of the current video frame to an Image, invoke it from the OnFrameBitmap event below

   NewBitmap := TBitmap.Create;
   NewBitmap.Canvas.Lock;
   NewBitmap.Width := BitmapInfo^.BitmapWidth;
   NewBitmap.Height := BitmapInfo^.BitmapHeight;
   case BitmapInfo^.BitmapBitsPerPixel of
      32:
         NewBitmap.PixelFormat := pf32Bit;
      24:
         NewBitmap.PixelFormat := pf24Bit;
      16:
         NewBitmap.PixelFormat := pf16Bit;
      15:
         NewBitmap.PixelFormat := pf15Bit;
      8:
         NewBitmap.PixelFormat := pf8Bit;
   else
      NewBitmap.PixelFormat := pf24Bit;
   end;
   BitBlt(NewBitmap.Canvas.Handle, 0, 0, BitmapInfo^.BitmapWidth,
     BitmapInfo^.BitmapHeight, BitmapInfo^.BitmapDC, 0, 0, SRCCOPY);
   NewBitmap.Canvas.Unlock;
   NewBitmap.SaveToFile('c:\myfolder\myframecapture.bmp');
   NewBitmap.Free;
end;

procedure DrawCircle(Canvas: TCanvas; xCenter, yCenter, Radius: LongInt);
var
   xCenterAndRadius: LongInt;
begin
   xCenterAndRadius := xCenter + Radius;
   Canvas.Arc(xCenter - Radius, yCenter - Radius, xCenterAndRadius,
     yCenter + Radius, xCenterAndRadius, xCenter, xCenterAndRadius, xCenter);
end;

procedure TfrmMainForm.VideoGrabberFrameBitmap(Sender: TObject;
  FrameInfo: pFrameInfo; BitmapInfo: pFrameBitmapInfo);
type
   pTRGB24Array = ^TRGB24Array;
   TRGB24Array = array [0 .. 65535] of TRGBTriple;

   pTRGB32Array = ^TRGB32Array;
   TRGB32Array = array [0 .. 65535] of TRGBQuad;
var
   i, iCol: Integer;
   Canvas: TCanvas;
   NewVideoSignalState: Boolean;
   xStep, yStep, xLocation, yLocation: LongInt;
   BitmapLinePtr: PBYTE;
   RGB32Line: pTRGB32Array;
   RGB24Line: pTRGB24Array;
   TargetRadius: LongInt;
begin
   // From this event you should not perform any actions with the potential to block:
   // 1. do not hold a critical section or wait on another thread,
   // 2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
   // 3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
   // of a ListBox component. If you need to read a such property, set an intermediary variable when
   // the property changes, and then read the intermediary variable from this event.

   // -----------------------------------------------------------
   // CopyFrameToBitmapDemo (BitmapInfo); // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
   // -----------------------------------------------------------

   with BitmapInfo^ do
   begin

      // DRAWS A TARGET AT THE MOUSE LOCATION
      // ====================================

      if chkDrawTarget.Checked then
      begin
         if LastMouseButtonClicked = mbLeft then
         begin
            Canvas := TCanvas.Create;
            Canvas.Handle := BitmapDC;
            Canvas.Pen.Color := clRed;
            TargetRadius := 50;
            DrawCircle(Canvas, LastXMouseDownLocation, LastYMouseDownLocation,
              TargetRadius);
            Canvas.MoveTo(LastXMouseDownLocation - TargetRadius,
              LastYMouseDownLocation);
            Canvas.LineTo(LastXMouseDownLocation + TargetRadius,
              LastYMouseDownLocation);
            Canvas.MoveTo(LastXMouseDownLocation, LastYMouseDownLocation -
              TargetRadius);
            Canvas.LineTo(LastXMouseDownLocation, LastYMouseDownLocation +
              TargetRadius);
            Canvas.Free;
         end;
      end;

      // DIRECT ACCESS TO THE RGB PIXELS
      // ===============================

      if chkChangePixels.Checked then
      begin
         BitmapLinePtr := BitmapDataPtr;

         if BitmapBitsPerPixel = 24 then
         begin // case where FrameGrabberRGBFormat is set to fgf_RGB24 (you can select it in the "frame grabber" tab)
            for i := 0 to BitmapHeight - 1 do
            begin
               RGB24Line := pTRGB24Array(BitmapLinePtr);
               for iCol := 0 to BitmapWidth - 1 do
               begin
                  RGB24Line[iCol].rgbtGreen := 0;
                  // e.g. we remove the green color -> purple image
               end;
               inc(BitmapLinePtr, BitmapLineSize);
            end;
         end
         else if BitmapBitsPerPixel = 32 then
         begin // case where FrameGrabberRGBFormat is set to fgf_RGB32 (default setting) (you can select it in the "frame grabber" tab)
            for i := 0 to BitmapHeight - 1 do
            begin
               RGB32Line := pTRGB32Array(BitmapLinePtr);
               for iCol := 0 to BitmapWidth - 1 do
               begin
                  RGB32Line[iCol].rgbBlue := 0;
                  // e.g. we remove the blue color -> yellow image
               end;
               inc(BitmapLinePtr, BitmapLineSize);
            end;
         end;
      end;

      // GRID DRAWING BY USING THE CANVAS DC AND FILLRECT
      // ================================================

      if chkDrawGridOverFrames.Checked then
      begin

         xStep := BitmapWidth div 10;
         yStep := BitmapHeight div 10;

         xLocation := xStep;
         yLocation := yStep;

         Canvas := TCanvas.Create;
         Canvas.Brush.Color := clBlue;
         Canvas.Brush.Style := bsSolid;
         Canvas.Handle := BitmapDC;

         while xLocation < BitmapWidth do
         begin
            Canvas.FillRect(Rect(xLocation, 0, xLocation + 1, BitmapHeight));
            inc(xLocation, xStep);
         end;

         while yLocation < BitmapHeight do
         begin
            Canvas.FillRect(Rect(0, yLocation, BitmapWidth, yLocation + 1));
            inc(yLocation, yStep);
         end;

         Canvas.Free;
      end;

      // FREE HAND DRANWING BY USING THE CANVAS DC AND LINETO / MOVETO
      // =============================================================

      if FiFreeHandMouseDrawing > 0 then
      begin // see VideoGrabberMouseMove event below
         Canvas := TCanvas.Create;
         Canvas.Handle := BitmapDC;
         Canvas.Pen.Color := clRed;
         for i := 0 to FiFreeHandMouseDrawing - 1 do
         begin
            if FFreeHandMouseDrawing[i].Right = 0 then
            begin // Right is used as boolean to know if it is a MoveTo or a LineTo
               Canvas.MoveTo(FFreeHandMouseDrawing[i].Left,
                 FFreeHandMouseDrawing[i].Top);
               Canvas.Pixels[FFreeHandMouseDrawing[i].Left,
                 FFreeHandMouseDrawing[i].Top] := clRed;
            end
            else
            begin
               Canvas.LineTo(FFreeHandMouseDrawing[i].Left,
                 FFreeHandMouseDrawing[i].Top);
            end;
         end;
         Canvas.Free;
      end;

      // VIDEO SIGNAL DETECTION
      // ======================

      if rdgDetectVideoSignal.ItemIndex > 0 then
      begin
         NewVideoSignalState := False;
         if rdgDetectVideoSignal.ItemIndex = 1 then
         begin // no video signal (dark screen)
            NewVideoSignalState := VideoGrabber.IsVideoSignalDetected(False,
              true, 30, 30, 30, true);
         end
         else if rdgDetectVideoSignal.ItemIndex = 2 then
         begin // Connexant blue screen (no signal)
            NewVideoSignalState := VideoGrabber.IsVideoSignalDetected(true,
              False, 0, 0, 0, False);
         end;
         if NewVideoSignalState <> FOldVideoSignalState then
         begin
            FOldVideoSignalState := NewVideoSignalState;
            // memorize the new state
            if NewVideoSignalState then
            begin
               mmoLog.Lines.Add('Video signal is back');
            end
            else
            begin
               mmoLog.Lines.Add('VIDEO SIGNAL LOST');
            end;
         end;
      end;
   end;
end;

procedure TfrmMainForm.VideoGrabberFrameCaptureCompleted(Sender: TObject;
  FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: LongInt;
  FrameNumber: LongWord; FrameTime: LargeInteger; DestType: TFrameCaptureDest;
  FileName: string; Success: Boolean; FrameId: LongInt);
var
   DestForm: TForm;
   DestImage: TImage;
begin
   if Success then
   begin
      mmoFrameCaptureLog.Lines.Add('frame #' + IntToStr(FrameNumber) +
        ' captured');
   end;
   Case DestType of
      fc_BmpFile, fc_JpegFile:
         begin
            if Success then
            begin
               mmoFrameCaptureLog.Lines.Add(FileName);
            end
            else
            begin
               mmoFrameCaptureLog.Lines.Add('error: failed to create ' +
                 FileName);
            end;
         end;

      fc_TBitmap:
         begin
            if VideoGrabber.CanProcessMessages then
            begin // to prevent crash in synchrone mode (mainly when Player is playing and UseClock is disabled)
               if (not VideoGrabber.BurstMode) or
                 (VideoGrabber.BurstMode and (VideoGrabber.BurstCount = 0)) then
               begin // reuse the same form
                  if not assigned(FSnapForm) then
                  begin
                     Application.CreateForm(TForm, FSnapForm);
                     FSnapForm.Position := poDefault;
                     FSnapForm.Formstyle := fsStayOnTop;
                  end;
                  if assigned(FSnapImage) then
                  begin
                     FSnapImage.Free;
                  end;
                  FSnapImage := TImage.Create(FSnapForm);
                  DestForm := FSnapForm;
                  DestImage := FSnapImage;
               end
               else
               begin
                  Application.CreateForm(TForm, DestForm);
                  DestForm.Position := poDefault;
                  DestForm.Formstyle := fsStayOnTop;
                  DestForm.DoubleBuffered := true;
                  DestImage := TImage.Create(DestForm);
                  DestImage.Parent := DestForm;
               end;

               DestForm.ClientWidth := BitmapWidth;
               DestForm.ClientHeight := BitmapHeight;
               DestImage.AutoSize := true;

               DestImage.Picture.Bitmap.Assign(FrameBitmap);

               DestImage.Parent := DestForm;

               if not DestForm.Visible then
               begin
                  DestForm.Show;
               end;
            end;
         end;
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// PLAYER TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnPlayerOpenFileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED;
   if OpenDlg.Execute then
   begin
      edtPlayerClip.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnOpenLastClipRecordedClick(Sender: TObject);
begin
   if VideoGrabber.Last_Recording_FileName <> '' then
   begin
      edtPlayerClip.Text := VideoGrabber.Last_Recording_FileName;
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayer;
   end;
end;

procedure TfrmMainForm.btnOpenLastClipPlayedClick(Sender: TObject);
begin
   if VideoGrabber.Last_Clip_Played <> '' then
   begin
      edtPlayerClip.Text := VideoGrabber.Last_Clip_Played;
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayer;
   end;
end;

procedure TfrmMainForm.btnGetClipDurationClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
begin
   if VideoGrabber.AVIDuration(edtPlayerClip.Text, Duration, FrameCount) then
   begin
      mmoLog.Lines.Add('Duration: ' + IntToStr(Duration));
      mmoLog.Lines.Add('Frame count: ' + IntToStr(FrameCount));
   end
   else
   begin
      mmoLog.Lines.Add('failed to get info for this clip');
   end;
end;

procedure TfrmMainForm.rgdHwAccelClick(Sender: TObject);
begin
   VideoGrabber.PlayerHWAccel := THWAccel(rgdHwAccel.ItemIndex);
end;

procedure TfrmMainForm.btnGeneralInfoClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
   VideoWidth: LongInt;
   VideoHeight: LongInt;
   VideoCodec: string;
   AudioCodec: string;
   VideoFrameRateFps: Double;
   AvgBitRate: LongInt;
   AudioChannels: LongInt;
   AudioSamplesPerSec: LongInt;
   AudioBitsPerSample: LongInt;
begin
   if VideoGrabber.AVIInfo(edtPlayerClip.Text, Duration, FrameCount, VideoWidth,
     VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels,
     AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec) then
   begin
      mmoLog.Lines.Add('');
      mmoLog.Lines.Add(edtPlayerClip.Text + ':');
      mmoLog.Lines.Add('duration (in sec): ' + FormatFloat('0.00',
        Duration / 10000000));
      mmoLog.Lines.Add('frame count: ' + IntToStr(FrameCount));
      mmoLog.Lines.Add('video source width: ' + IntToStr(VideoWidth));
      mmoLog.Lines.Add('video source height: ' + IntToStr(VideoHeight));
      mmoLog.Lines.Add('video frame rate (fps): ' + FormatFloat('0.00',
        VideoFrameRateFps));
      mmoLog.Lines.Add('average bit rate (kb/s): ' +
        IntToStr(AvgBitRate div 1024));
      mmoLog.Lines.Add('audio channels: ' + IntToStr(AudioChannels));
      mmoLog.Lines.Add('audio samples/sec: ' + IntToStr(AudioSamplesPerSec));
      mmoLog.Lines.Add('audio bits per sample: ' +
        IntToStr(AudioBitsPerSample));
      mmoLog.Lines.Add('video codec: ' + VideoCodec);
      mmoLog.Lines.Add('audio codec: ' + AudioCodec);
   end
   else
   begin
      mmoLog.Lines.Add(edtPlayerClip.Text + ' clip not found.');
   end;
end;

procedure TfrmMainForm.btnHeaderInfoClick(Sender: TObject);
begin
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add(edtPlayerClip.Text + ' headers:');
   mmoLog.Lines.Add('Title: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Title));
   mmoLog.Lines.Add('Description: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Description));
   mmoLog.Lines.Add('Author: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Author));
   mmoLog.Lines.Add('Copyright: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Copyright));
   mmoLog.Lines.Add('Album Artist: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_AlbumArtist));
   mmoLog.Lines.Add('Album Title: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_AlbumTitle));
   mmoLog.Lines.Add('Composer: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Composer));
   mmoLog.Lines.Add('Content Distributor: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ContentDistributor));
   mmoLog.Lines.Add('Director: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Director));
   mmoLog.Lines.Add('Encoding Time: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_EncodingTime));
   mmoLog.Lines.Add('Genre: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Genre));
   mmoLog.Lines.Add('Language: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Language));
   mmoLog.Lines.Add('Parental Rating: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ParentalRating));
   mmoLog.Lines.Add('Producer: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Producer));
   mmoLog.Lines.Add('Provider: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Provider));
   mmoLog.Lines.Add('ToolName: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ToolName));
   mmoLog.Lines.Add('Tool Version: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ToolVersion));
   mmoLog.Lines.Add('Writer: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Writer));
end;

procedure TfrmMainForm.btnOpenClipClick(Sender: TObject);
begin
   VideoGrabber.PlayerFileName := edtPlayerClip.Text;
   VideoGrabber.OpenPlayer;
end;

procedure TfrmMainForm.btnPlayerCloseClipClick(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TfrmMainForm.btnPlayerPauseClick(Sender: TObject);
begin
   VideoGrabber.PausePlayer;
end;

procedure TfrmMainForm.btnPlayerStopClick(Sender: TObject);
begin
   VideoGrabber.StopPlayer;
end;

procedure TfrmMainForm.btnPlayerStartPlayingClick(Sender: TObject);
begin
   VideoGrabber.RunPlayer;
end;

procedure TfrmMainForm.btnPlayerFrameStepClick(Sender: TObject);
begin
   VideoGrabber.PlayerFrameStep(1);
end;

procedure TfrmMainForm.btnPlayerBackwardsClick(Sender: TObject);
begin
   VideoGrabber.RunPlayerBackwards;
end;

procedure TfrmMainForm.btnPlayerRewindClick(Sender: TObject);
begin
   VideoGrabber.RewindPlayer;
end;

procedure TfrmMainForm.btnPlayerFastForwardClick(Sender: TObject);
begin
   VideoGrabber.FastForwardPlayer;
end;

procedure TfrmMainForm.btnAutoPlayClick(Sender: TObject);
begin
   VideoGrabber.AutoStartPlayer := btnAutoPlay.Checked;
end;

procedure TfrmMainForm.chk360VideoDecodingClick(Sender: TObject);
begin
   VideoGrabber.v360_Enabled := chk360VideoDecoding.Checked;
end;

procedure TfrmMainForm.tbrPlayerProgressChange(Sender: TObject);
begin
   // the tbrPlayer trackbar is assigned directly to the VideoGrabber.PlayerTrackBar property, that handle the position automatically
end;

procedure TfrmMainForm.chkPlayerTrackbarSynchroneClick(Sender: TObject);
begin
   VideoGrabber.PlayerTrackBarSynchrone := chkPlayerTrackbarSynchrone.Checked;
end;

procedure TfrmMainForm.chkPlayerAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.PlayerAudioRendering := chkPlayerAudioRendering.Checked;
end;

procedure TfrmMainForm.chkPlayerLoopClick(Sender: TObject);
begin
   // the code is in the PlayerEndOfStream event
end;

procedure TfrmMainForm.chkUseClockClick(Sender: TObject);
begin
   VideoGrabber.UseClock := chkUseClock.Checked;
end;

procedure TfrmMainForm.chkUseExternalAudioforRTSPClick(Sender: TObject);
begin
   if chkUseExternalAudioforRTSP.Checked then begin
      VideoGrabber.AudioSource := as_UseExternalAudio;
   end
   else begin
      VideoGrabber.AudioSource := as_Default;
   end;
end;

procedure TfrmMainForm.chkRefreshPausedDisplayClick(Sender: TObject);
begin
   VideoGrabber.PlayerRefreshPausedDisplay := chkRefreshPausedDisplay.Checked;
end;

procedure TfrmMainForm.edtPlayerSpeedRatioChange(Sender: TObject);
var
   OldSpeedRatio: Double;
begin
   OldSpeedRatio := VideoGrabber.PlayerSpeedRatio;
   VideoGrabber.PlayerSpeedRatio :=
     StrToFloatDef(edtPlayerSpeedRatio.Text, 1.0);
   if VideoGrabber.PlayerSpeedRatio <> OldSpeedRatio then
   begin
      mmoLog.Lines.Add('player speed ratio selected: ' + FormatFloat('0.0',
        VideoGrabber.PlayerSpeedRatio));
   end;
end;

procedure TfrmMainForm.updPlayerFastSeekSpeedClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.PlayerFastSeekSpeedRatio := updPlayerFastSeekSpeed.Position;
   edtPlayerFastSeekSpeed.Text :=
     IntToStr(VideoGrabber.PlayerFastSeekSpeedRatio);
end;

procedure TfrmMainForm.VideoGrabberPlayerOpened(Sender: TObject);
begin
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('playing ' + VideoGrabber.PlayerFileName);
   if VideoGrabber.IsPlayervideoStreamAvailable = ts_True then
   begin
      mmoLog.Lines.Add('this clip has a video stream');
   end
   else if VideoGrabber.IsPlayervideoStreamAvailable = ts_False then
   begin
      mmoLog.Lines.Add('this clip does not have video');
   end;
   if VideoGrabber.IsPlayerAudioStreamAvailable = ts_True then
   begin
      mmoLog.Lines.Add('this clip has an audio stream');
   end
   else if VideoGrabber.IsPlayerAudioStreamAvailable = ts_False then
   begin
      mmoLog.Lines.Add('this clip does not have audio');
   end;
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('video codec: ' + VideoGrabber.PlayerVideoCodec);
   mmoLog.Lines.Add('audio codec: ' + VideoGrabber.PlayerAudioCodec);
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('Duration: ' + FormatFloat('0.00',
     VideoGrabber.PlayerDuration / 10000000));
   mmoLog.Lines.Add('Frame count: ' + IntToStr(VideoGrabber.PlayerFrameCount));
   mmoLog.Lines.Add('Frame rate: ' + FormatFloat('0.00',
     VideoGrabber.PlayerFrameRate));
   mmoLog.Lines.Add('video source size: ' + IntToStr(VideoGrabber.VideoWidth) +
     'x' + IntToStr(VideoGrabber.VideoHeight));
   mmoLog.Lines.Add('display aspect ratio: ' +
     IntToStr(VideoGrabber.VideoWidth_PreferredAspectRatio) + 'x' +
     IntToStr(VideoGrabber.VideoHeight_PreferredAspectRatio));

   if VideoGrabber.IsPlaylistActive then
   begin
      lstPlaylist.ItemIndex := VideoGrabber.PlaylistIndex;
   end;
end;

procedure TfrmMainForm.VideoGrabberPlayerBufferingData(Sender: TObject;
  StartingToBuffer: Boolean);
begin
   if StartingToBuffer then
   begin
      mmoLog.Lines.Add('buffering data...');
   end
   else
   begin
      mmoLog.Lines.Add('buffering completed.');
   end;
end;

procedure TfrmMainForm.btnAddToPlaylistClick(Sender: TObject);
var
   i: LongInt;
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED;
   OpenDlg.Options := [ofAllowMultiSelect];
   if OpenDlg.Execute then
   begin
      for i := 0 to OpenDlg.Files.Count - 1 do
      begin
         VideoGrabber.Playlist(pl_Add, OpenDlg.Files[i]);
         lstPlaylist.Items.Add(OpenDlg.Files[i]);
      end;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnPlaylistPlayClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Play, '');
end;

procedure TfrmMainForm.btnPlaylistNextClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Next, '');
end;

procedure TfrmMainForm.btnPlaylistPreviousClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Previous, '');
end;

procedure TfrmMainForm.btnPlaylistStopClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Stop, '');
end;

procedure TfrmMainForm.btnClosePlaylistClick(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TfrmMainForm.chkPlaylistLoopClick(Sender: TObject);
begin
   if chkPlaylistLoop.Checked then
   begin
      VideoGrabber.Playlist(pl_Loop, '');
   end
   else
   begin
      VideoGrabber.Playlist(pl_NoLoop, '');
   end;
end;

procedure TfrmMainForm.chkPlaylistRandomClick(Sender: TObject);
begin
   if chkPlaylistRandom.Checked then
   begin
      VideoGrabber.Playlist(pl_Random, '');
   end
   else
   begin
      VideoGrabber.Playlist(pl_Sequential, '');
   end;
end;

// begin ONVIF discovery

procedure TfrmMainForm.btnDiscoverONVIFFromIPRangeClick(Sender: TObject);
begin
   if lsbOnvifURLsDiscovered.Items.Count > 0 then begin
      lsbOnvifURLsDiscovered.Items.Clear();
   end;
	if VideoGrabber.ONVIFDiscoverCameras_IPrange(edtOnvifDiscoveryIPRange_FirstIP.Text, edtOnvifDiscoveryIPRange_LastIP.Text, StrToIntDef (edtDiscoveryTimeoutSeconds.Text, 0)) then begin
		 mmoLog.Lines.Add ('ONVIF discovery from IP range in progress...');
	end
	else begin
		 mmoLog.Lines.Add ('failed to start ONVIF discovery from IP range');
	end;
end;

procedure TfrmMainForm.btnDiscoverONVIFFromMulticastClick(Sender: TObject);
begin
   if lsbOnvifURLsDiscovered.Items.Count > 0 then begin
      lsbOnvifURLsDiscovered.Items.Clear();
   end;
	if VideoGrabber.ONVIFDiscoverCameras_Multicast(StrToIntDef (edtDiscoveryTimeoutSeconds.Text, 0)) then begin
		 mmoLog.Lines.Add ('ONVIF discovery from multicast in progress...');
	end
	else begin
		 mmoLog.Lines.Add ('failed to start ONVIF discovery from multicast');
	end;
end;

procedure TfrmMainForm.lsbOnvifURLsDiscoveredClick(Sender: TObject);
var
	CameraInfo: string;
	ServiceURL: String;
	OnvifURL: string;
	pURL: LongInt;
begin
	CameraInfo := lsbOnvifURLsDiscovered.Items[lsbOnvifURLsDiscovered.ItemIndex];
	pURL := pos ('] ', CameraInfo);
	if pURL > 0 then begin
		ServiceURL := copy (CameraInfo, pURL + 2, MAXINT);
		if ServiceURL <> '' then begin
			OnvifURL := VideoGrabber.GetONVIFURLFromServiceURL (ServiceURL);
			if OnvifURL <> '' then begin
				edtIPCameraURL.Text := ONVIFUrl;
			end;
		end;
	end;
end;

// end ONVIF discovery

procedure TfrmMainForm.lstPlaylistClick(Sender: TObject);
begin
   VideoGrabber.PlaylistIndex := lstPlaylist.ItemIndex;
   VideoGrabber.Playlist(pl_Play, '');
end;

procedure TfrmMainForm.VideoGrabberPlayerEndOfStream(Sender: TObject);
begin
   mmoLog.Lines.Add('end of stream.');
   if chkPlayerLoop.Checked then
   begin
      VideoGrabber.RunPlayer;
   end;
end;

procedure TfrmMainForm.VideoGrabberPlayerEndOfPlaylist(Sender: TObject);
begin
   mmoLog.Lines.Add('END OF PLAYLIST.');
end;

procedure TfrmMainForm.btnViewDirectNetworkStreamingClick(Sender: TObject);
begin
   if VideoGrabber.StreamingURL <> '' then
   begin
      ShellExecute(0, 'open', PChar(VideoGrabber.StreamingURL), '', '',
        SW_SHOW);
   end;
end;

procedure TfrmMainForm.VideoGrabberClientConnection(Sender: TObject;
  Connected: Boolean; ClientInfo: String);
begin
end;

/// /////////////////////////////////////////////////////////////////////////////
// FRAME OVERLAY TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.chkTextOverlayEnabledClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Enabled(FTextOverlayIndex,
     chkTextOverlayEnabled.Checked);
   if chkTextOverlayEnabled.Checked then
   begin
      chkTextOverlayEnabled.Font.Color := clBlack;
   end
   else
   begin
      chkTextOverlayEnabled.Font.Color := clRed;
   end;
end;

procedure TfrmMainForm.chkTextOverlayHighResFontClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_HighResFont(FTextOverlayIndex,
     chkTextOverlayHighResFont.Checked);
end;

procedure TfrmMainForm.edtTextOverlayTargetDisplayChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_TargetDisplay(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayTargetDisplay.Text, 0));
end;

procedure TfrmMainForm.chkTextOverlayScrollingClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Scrolling(FTextOverlayIndex,
     chkTextOverlayScrolling.Checked);
end;

procedure TfrmMainForm.edtTextOverlayScrollingSpeedChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_ScrollingSpeed(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayScrollingSpeed.Text, 0));
end;

procedure TfrmMainForm.btnTextOverlayColorClick(Sender: TObject);
var
   dlgTextOverlayColor: TColorDialog;
begin
   dlgTextOverlayColor := TColorDialog.Create(nil);
   dlgTextOverlayColor.Color := VideoGrabber.GetTextOverlay_Font
     (FTextOverlayIndex).Color;
   if dlgTextOverlayColor.Execute then
   begin
      VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Color :=
        dlgTextOverlayColor.Color;
   end;
   dlgTextOverlayColor.Free;
end;

procedure TfrmMainForm.btnBkgndColorClick(Sender: TObject);
var
   dlgTextOverlayColor: TColorDialog;
begin
   dlgTextOverlayColor := TColorDialog.Create(nil);
   dlgTextOverlayColor.Color := VideoGrabber.GetTextOverlay_BkColor
     (FTextOverlayIndex);
   if dlgTextOverlayColor.Execute then
   begin
      VideoGrabber.SetTextOverlay_BkColor(FTextOverlayIndex,
        dlgTextOverlayColor.Color);
   end;
   dlgTextOverlayColor.Free;
end;

procedure TfrmMainForm.chkTextOverlayTransparentClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Transparent(FTextOverlayIndex,
     chkTextOverlayTransparent.Checked);
end;

procedure TfrmMainForm.updTextOverlaySizeClick(Sender: TObject;
  Button: TUDBtnType);
var
   OldSize: LongInt;
begin
   OldSize := VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Size;
   case Button of
      btPrev:
         VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Size :=
           OldSize - 1;
      btNext:
         VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Size :=
           OldSize + 1;
   end;
end;

procedure TfrmMainForm.chkTextOverlayShadowClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Shadow(FTextOverlayIndex,
     chkTextOverlayShadow.Checked);
end;

procedure TfrmMainForm.chkOverlayOrientationClick(Sender: TObject);
begin
   case chkOverlayOrientation.ItemIndex of
      0:
         VideoGrabber.SetTextOverlay_Orientation(FTextOverlayIndex,
           to_Horizontal);
      1:
         VideoGrabber.SetTextOverlay_Orientation(FTextOverlayIndex,
           to_Vertical);
      2:
         VideoGrabber.SetTextOverlay_Orientation(FTextOverlayIndex,
           to_VerticalInverted);
   end;
end;

procedure TfrmMainForm.chkAdjustOverlayAspectRatioClick(Sender: TObject);
begin
   VideoGrabber.AdjustOverlayAspectRatio := chkAdjustOverlayAspectRatio.Checked;
end;

procedure TfrmMainForm.rdgTextOverlayAlignClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Align(FTextOverlayIndex,
     TTextOverlayAlign(rdgTextOverlayAlign.ItemIndex));
end;

procedure TfrmMainForm.chkTextOverlayAlphablendClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_AlphaBlend(FTextOverlayIndex,
     chkTextOverlayAlphablend.Checked);
end;

procedure TfrmMainForm.tbrTextOverlayAlphablendValueChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_AlphaBlendValue(FTextOverlayIndex,
     tbrTextOverlayAlphablendValue.Position);
end;

procedure TfrmMainForm.mmoTextOverlayStringChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_String(FTextOverlayIndex,
     mmoTextOverlayString.Text);
end;

procedure TfrmMainForm.edtTextOverlayLeftChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Left(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayLeft.Text, 0));
end;

procedure TfrmMainForm.edtTextOverlayTopChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Top(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayTop.Text, 0));
end;

procedure TfrmMainForm.edtTextOverlayRightChange(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Right(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayRight.Text, 0));
end;

procedure TfrmMainForm.rdgTextOverlaySelectorClick(Sender: TObject);
begin
   FTextOverlayIndex := rdgTextOverlaySelector.ItemIndex;

   // as we have selected another set, let's reload the corresponding values
   chkTextOverlayEnabled.Checked := VideoGrabber.GetTextOverlay_Enabled
     (FTextOverlayIndex);
   chkTextOverlayHighResFont.Checked := VideoGrabber.GetTextOverlay_HighResFont
     (FTextOverlayIndex);
   edtTextOverlayTargetDisplay.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_TargetDisplay(FTextOverlayIndex));

   if not chkTextOverlayEnabled.Checked then
   begin
      chkTextOverlayEnabled.Font.Color := clRed;
   end
   else
   begin
      chkTextOverlayEnabled.Font.Color := clBlack;
   end;
   mmoTextOverlayString.Text := VideoGrabber.GetTextOverlay_String
     (FTextOverlayIndex);
   edtTextOverlayLeft.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_Left(FTextOverlayIndex));
   edtTextOverlayTop.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_Top(FTextOverlayIndex));
   edtTextOverlayRight.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_Right(FTextOverlayIndex));
   rdgTextOverlayAlign.ItemIndex :=
     Integer(VideoGrabber.GetTextOverlay_Align(FTextOverlayIndex));
   chkTextOverlayScrolling.Checked := VideoGrabber.GetTextOverlay_Scrolling
     (FTextOverlayIndex);
   edtTextOverlayScrollingSpeed.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_ScrollingSpeed(FTextOverlayIndex));
   chkTextOverlayTransparent.Checked := VideoGrabber.GetTextOverlay_Transparent
     (FTextOverlayIndex);
   chkTextOverlayShadow.Checked := VideoGrabber.GetTextOverlay_Shadow
     (FTextOverlayIndex);
end;

procedure TfrmMainForm.chkChangePixelsClick(Sender: TObject);
begin
   // chkChangePixels.Checked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
end;

procedure TfrmMainForm.chkDrawGridOverFramesClick(Sender: TObject);
begin
   // chkDrawTarget.Checked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
end;

procedure TfrmMainForm.chkFreeHandEnabledClick(Sender: TObject);
begin
   // chkFreeHandEnabled.Checked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
end;

procedure TfrmMainForm.btnFreeHandEraseClick(Sender: TObject);
begin
   FiFreeHandMouseDrawing := 0;
   VideoGrabber.RefreshPlayerOverlays;
end;

procedure TfrmMainForm.btnLoadImageOverlayFromFileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_IMAGE_FILES;
   if OpenDlg.Execute then
   begin
      VideoGrabber.SetImageOverlayFromImageFile2(FImageOverlayIndex,
        OpenDlg.FileName);
   end;
   OpenDlg.Free;
end;

var
   PIPVideoGrabber: TVideoGrabber = nil;
   PIPMixIndex: LongInt = -1;

procedure TfrmMainForm.btnPIPFromAnotherTVideoGrabberClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then
   begin
      if not assigned(PIPVideoGrabber) then
      begin
         PIPVideoGrabber := TVideoGrabber.Create(Self);
         PIPVideoGrabber.VideoRenderer := vr_None;
         PIPVideoGrabber.Visible := False;
         if PIPMixIndex > -1 then
         begin
            VideoGrabber.Mixer_RemoveFromMixer(PIPMixIndex);
         end;
         PIPMixIndex := VideoGrabber.Mixer_SetupPIPFromSource
           (PIPVideoGrabber.UniqueId, 0, 0, 0, 0, true, 10, 10, 200,
           150, False);
      end;
      PIPVideoGrabber.PlayerFileName := OpenDlg.FileName;
      PIPVideoGrabber.OpenPlayer();
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnPIPStopClick(Sender: TObject);
begin
   if PIPMixIndex > -1 then
   begin
      VideoGrabber.Mixer_RemoveFromMixer(PIPMixIndex);
      PIPMixIndex := -1;
   end;
end;

procedure TfrmMainForm.rdgImageOverlaySelectorClick(Sender: TObject);
begin
   FImageOverlayIndex := rdgImageOverlaySelector.ItemIndex;
   chkImageOverlayEnabled.Checked := VideoGrabber.GetImageOverlay_Enabled
     (FImageOverlayIndex);

   edtImageOverlayTargetDisplay.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_TargetDisplay(FImageOverlayIndex));

   edtImageOverlayLeft.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_LeftLocation(FImageOverlayIndex));
   edtImageOverlayTop.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_TopLocation(FImageOverlayIndex));
   edtImageOverlayWidth.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_Width(FImageOverlayIndex));
   edtImageOverlayHeight.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_Height(FImageOverlayIndex));

   chkImageOverlayTransparent.Checked :=
     VideoGrabber.GetImageOverlay_Transparent(FImageOverlayIndex);
   chkImageOverlayUseTransparentColor.Checked :=
     VideoGrabber.GetImageOverlay_UseTransparentColor(FImageOverlayIndex);
   edtImageOverlayTransparentColorValue.Text :=
     Format('%.6X', [VideoGrabber.GetImageOverlay_TransparentColorValue
     (FImageOverlayIndex)]);

   chkImageOverlayAlphaBlend.Checked := VideoGrabber.GetImageOverlay_AlphaBlend
     (FImageOverlayIndex);
   chkImageOverlayAlphablendCoeff.Position :=
     VideoGrabber.GetImageOverlay_AlphaBlendValue(FImageOverlayIndex);

   chkImageOverlayChromaKey.Checked := VideoGrabber.GetImageOverlay_ChromaKey
     (FImageOverlayIndex);
   edtChromaKeyColorValue.Text :=
     Format('%.6X', [VideoGrabber.GetImageOverlay_ChromaKeyRGBColor
     (FImageOverlayIndex)]);
   edtChromaKeyLeewayPercent.Position :=
     VideoGrabber.GetImageOverlay_ChromaKeyLeewayPercent(FImageOverlayIndex);

end;

procedure TfrmMainForm.chkImageOverlayEnabledClick(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_Enabled(FImageOverlayIndex,
     chkImageOverlayEnabled.Checked);
end;

procedure TfrmMainForm.edtImageOverlayLeftChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_LeftLocation(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayLeft.Text, 0));
end;

procedure TfrmMainForm.edtImageOverlayTopChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_TopLocation(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayTop.Text, 0));
end;

procedure TfrmMainForm.edtImageOverlayWidthChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_Width(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayWidth.Text, -1));
end;

procedure TfrmMainForm.edtImageOverlayHeightChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_Height(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayHeight.Text, -1));
end;

procedure TfrmMainForm.chkImageOverlayTransparentClick(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_Transparent(FImageOverlayIndex,
     chkImageOverlayTransparent.Checked);
end;

procedure TfrmMainForm.edtImageOverlayTargetDisplayChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_TargetDisplay(FTextOverlayIndex,
     StrToIntDef(edtImageOverlayTargetDisplay.Text, 0));
end;

procedure TfrmMainForm.btnImageOverlayPickupColorClick(Sender: TObject);
var
   LastClickRGBValue: DWORD;
begin
   LastClickRGBValue := VideoGrabber.GetRGBPixelAt(-1, -1);
   VideoGrabber.SetImageOverlay_TransparentColorValue(FImageOverlayIndex,
     LastClickRGBValue);
   edtImageOverlayTransparentColorValue.Text :=
     Format('%.6X', [LastClickRGBValue]);
end;

procedure TfrmMainForm.btnImageOverlayPickupHelpClick(Sender: TObject);
begin
   ShowMessage('while the preview is running:' + #13#10 +
     '- load the image overlay' + #13#10 +
     '- enable "transparent" and "use transp. color value"' + #13#10 +
     '- in the video window, click on the video frame on the color of the overlayed image you want to be transparent'
     + #13#10 +
     '- click on "pickup the transparent color" to select it as transparent color');
end;

procedure TfrmMainForm.chkImageOverlayUseTransparentColorClick(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_UseTransparentColor(FImageOverlayIndex,
     chkImageOverlayUseTransparentColor.Checked);
end;

procedure TfrmMainForm.edtImageOverlayTransparentColorValueChange
  (Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_TransparentColorValue(FImageOverlayIndex,
     StrToIntDef('$' + edtImageOverlayTransparentColorValue.Text, 0));
end;

procedure TfrmMainForm.chkImageOverlayAlphaBlendClick(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_AlphaBlend(FImageOverlayIndex,
     chkImageOverlayAlphaBlend.Checked);
end;

procedure TfrmMainForm.chkImageOverlayAlphablendCoeffChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_AlphaBlendValue(FImageOverlayIndex,
     chkImageOverlayAlphablendCoeff.Position);
end;

procedure TfrmMainForm.updImageAlphaBendClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.SetImageOverlay_AlphaBlendValue(FImageOverlayIndex,
     chkImageOverlayAlphablendCoeff.Position);
end;

procedure TfrmMainForm.chkImageOverlayChromaKeyClick(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_ChromaKey(FImageOverlayIndex,
     chkImageOverlayChromaKey.Checked);
end;

procedure TfrmMainForm.edtChromaKeyColorValueChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_ChromaKeyRGBColor(FImageOverlayIndex,
     StrToIntDef('$' + edtChromaKeyColorValue.Text, 0));
end;

procedure TfrmMainForm.edtChromaKeyLeewayPercentChange(Sender: TObject);
begin
   VideoGrabber.SetImageOverlay_ChromaKeyLeewayPercent(FImageOverlayIndex,
     edtChromaKeyLeewayPercent.Position);
end;

procedure TfrmMainForm.VideoGrabberMouseDown(Sender: TObject;
  VideoWindow: Integer; Button: TMouseButton; Shift: TShiftState;
  X, Y: Integer);
begin
   if VideoWindow <> -1 then
   begin // if the video is displayed
      if chkFreeHandEnabled.Checked then
      begin
         if FiFreeHandMouseDrawing < FreeHandMouseCoordinatesMax then
         begin
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left := X;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top := Y;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right := 0;
            // Right is used as boolean to know if it is a MoveTo or a LineTo
            inc(FiFreeHandMouseDrawing);
            FFreeHandMouseDrawingEnabled := true;
            VideoGrabber.RefreshPlayerOverlays;
         end;
      end;
   end;
end;

procedure TfrmMainForm.VideoGrabberMouseMove(Sender: TObject;
  VideoWindow: Integer; Shift: TShiftState; X, Y: Integer);
begin
   if VideoWindow <> -1 then
   begin // if the video is displayed
      if FFreeHandMouseDrawingEnabled then
      begin
         if FiFreeHandMouseDrawing < FreeHandMouseCoordinatesMax then
         begin
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left := X;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top := Y;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right := 1;
            // Right is used as boolean to know if it is a MoveTo or a LineTo
            inc(FiFreeHandMouseDrawing);
            VideoGrabber.RefreshPlayerOverlays;
         end;
      end;
   end;
end;

procedure TfrmMainForm.VideoGrabberMouseUp(Sender: TObject;
  VideoWindow: Integer; Button: TMouseButton; Shift: TShiftState;
  X, Y: Integer);
begin
   FFreeHandMouseDrawingEnabled := False;
   VideoGrabber.RefreshPlayerOverlays;
end;

procedure TfrmMainForm.VideoGrabberResizeVideo(Sender: TObject;
  SourceWidth, SourceHeight: Integer);
begin
   trkCroppingX.Min := -VideoGrabber.Cropping_Width;
   trkCroppingY.Min := -VideoGrabber.Cropping_Height;
   trkCroppingX.Max := VideoGrabber.Cropping_XMax;
   trkCroppingY.Max := VideoGrabber.Cropping_YMax;
end;

/// /////////////////////////////////////////////////////////////////////////////
// VIDEO PROCESSING TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.rdgVideoRotationClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Rotation :=
     TVideoRotation(rdgVideoRotation.ItemIndex);
end;

procedure TfrmMainForm.edtCustomRotationAngleChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_RotationCustomAngle :=
     StrToFloatDef(edtCustomRotationAngle.Text, 0);
end;

procedure TfrmMainForm.updPixellizationClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.VideoProcessing_Pixellization := updPixellization.Position;
end;

procedure TfrmMainForm.rdgDeinterlacingClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Deinterlacing :=
     TVideoDeinterlacing(rdgDeinterlacing.ItemIndex);
end;

procedure TfrmMainForm.tbrBrightnessChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Brightness := -tbrBrightness.Position;
end;

procedure TfrmMainForm.tbrConstrastChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Contrast := -tbrConstrast.Position;
end;

procedure TfrmMainForm.tbrSaturationChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Saturation := -tbrSaturation.Position;
end;

procedure TfrmMainForm.tbrHueChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Hue := tbrHue.Position;
end;

procedure TfrmMainForm.btnResetAllClick(Sender: TObject);
begin
   rdgVideoRotation.ItemIndex := 0;
   rdgDeinterlacing.ItemIndex := 0;
   rdgVideoRotation.ItemIndex := 0;
   tbrBrightness.Position := 0;
   tbrConstrast.Position := 0;
   tbrSaturation.Position := 0;
   tbrHue.Position := 0;
   chkGreyScale.Checked := False;
   chkInvertColors.Checked := False;
   chkFlipVertical.Checked := False;
   chkFlipHorizontal.Checked := False;
   updPixellization.Position := 1;
   VideoGrabber.VideoProcessing_Pixellization := 1;
end;

procedure TfrmMainForm.chkFlipVerticalClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_FlipVertical := chkFlipVertical.Checked;
end;

procedure TfrmMainForm.chkFlipHorizontalClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_FlipHorizontal := chkFlipHorizontal.Checked;
end;

procedure TfrmMainForm.chkGreyScaleClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_GrayScale := chkGreyScale.Checked;
end;

procedure TfrmMainForm.chkInvertColorsClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_InvertColors := chkInvertColors.Checked;
end;

procedure TfrmMainForm.VideoGrabberGraphBuilt(Sender: TObject);

   procedure InitVMR9Trackbar(VMR9ImageAdjustment: TVMR9ImageAdjustment;
     Trackbar: TTrackBar);
   var
      MinValue, MaxValue, StepSize, DefaultValue, CurrentValue: LongInt;
   begin
      Trackbar.Enabled := VideoGrabber.GetVMR9ImageAdjustmentBounds(true,
        VMR9ImageAdjustment, MinValue, MaxValue, StepSize, DefaultValue,
        CurrentValue);
      if Trackbar.Enabled then
      begin
         Trackbar.Min := MinValue;
         Trackbar.Max := MaxValue;
         Trackbar.Frequency := StepSize;
         Trackbar.Position := CurrentValue;
      end;
   end;

begin
   InitVMR9Trackbar(vmr9_Brightness, tbrVMR9Brightness);
   InitVMR9Trackbar(vmr9_Contrast, tbrVMR9Contrast);
   InitVMR9Trackbar(vmr9_Saturation, tbrVMR9Saturation);
   InitVMR9Trackbar(vmr9_Hue, tbrVMR9Hue);

   tbrAudioBalance.Position := VideoGrabber.AudioBalance;
   tbrAudioVolume.Position := VideoGrabber.AudioVolume;

   tbrZoomX.Min := -(VideoGrabber.VideoWidth div 2);
   tbrZoomX.Max := VideoGrabber.VideoWidth div 2;
   tbrZoomY.Min := -(VideoGrabber.VideoHeight div 2);
   tbrZoomY.Max := VideoGrabber.VideoHeight div 2;
end;

procedure TfrmMainForm.tbrZoomChange(Sender: TObject);
begin
   VideoGrabber.ZoomCoeff := tbrZoom.Position;
end;

procedure TfrmMainForm.tbrZoomXChange(Sender: TObject);
begin
   VideoGrabber.ZoomXCenter := tbrZoomX.Position;
end;

procedure TfrmMainForm.tbrZoomYChange(Sender: TObject);
begin
   VideoGrabber.ZoomYCenter := tbrZoomY.Position;
end;

procedure TfrmMainForm.tbrVMR9BrightnessChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Brightness,
     tbrVMR9Brightness.Position, False);
end;

procedure TfrmMainForm.tbrVMR9ContrastChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Contrast,
     tbrVMR9Contrast.Position, vmr9FixRange.Checked);
end;

procedure TfrmMainForm.tbrVMR9SaturationChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Saturation,
     tbrVMR9Saturation.Position, vmr9FixRange.Checked);
end;

procedure TfrmMainForm.tbrVMR9HueChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Hue,
     tbrVMR9Hue.Position, False);
end;

procedure TfrmMainForm.vmr9FixRangeClick(Sender: TObject);
begin
   // fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
end;

procedure TfrmMainForm.chkCroppingEnabledClick(Sender: TObject);
begin
   VideoGrabber.Cropping_Enabled := chkCroppingEnabled.Checked;
end;

procedure TfrmMainForm.chkCroppingOutboundsClick(Sender: TObject);
begin
   VideoGrabber.Cropping_Outbounds := chkCroppingOutbounds.Checked;
end;

procedure TfrmMainForm.edtCroppingWidthChange(Sender: TObject);
begin
   VideoGrabber.Cropping_Width := StrToIntDef(edtCroppingWidth.Text, 0);
end;

procedure TfrmMainForm.edtCroppingHeightChange(Sender: TObject);
begin
   VideoGrabber.Cropping_Height := StrToIntDef(edtCroppingHeight.Text, 0);
end;

procedure TfrmMainForm.trkCroppingZoomChange(Sender: TObject);
begin
   VideoGrabber.Cropping_Zoom := trkCroppingZoom.Position / 100;
end;

procedure TfrmMainForm.btnCroppingZoomResetClick(Sender: TObject);
begin
   trkCroppingZoom.Position := 100;
end;

procedure TfrmMainForm.trkCroppingYChange(Sender: TObject);
begin
   // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   VideoGrabber.Cropping_Y := trkCroppingY.Position;
end;

procedure TfrmMainForm.trkCroppingXChange(Sender: TObject);
begin
   // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   VideoGrabber.Cropping_X := trkCroppingX.Position;
end;

/// /////////////////////////////////////////////////////////////////////////////
// DISPLAY TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure EnableOrDisableGroupBoxControls(GroupBox: TGroupBox; Value: Boolean);
var
   i: Integer;
begin
   for i := 0 to GroupBox.ControlCount - 1 do
   begin
      GroupBox.Controls[i].Enabled := Value;
   end;
end;

procedure TfrmMainForm.RefreshDisplayOptions;
begin
   // this procedure is called each time a setting of this form is changed,
   // to show what features can be used, according to their respective states

   // NOTE: duplicating 2 times all the components of this form for the 2 windows
   // is not very efficient, this has been done only for a better readability.

   chkDisplayActive.Checked := VideoGrabber.GetDisplayActive(FDisplaySelected);
   chkVisible.Checked := VideoGrabber.GetDisplayVisible(FDisplaySelected);
   chkEmbedded.Checked := VideoGrabber.GetDisplayEmbedded(FDisplaySelected);
   chkFullScreen.Checked := VideoGrabber.GetDisplayFullScreen(FDisplaySelected);
   chkStayOnTop.Checked := VideoGrabber.GetDisplayStayOnTop(FDisplaySelected);
   chkUseVideoPort.Checked := VideoGrabber.GetDisplayVideoPortEnabled
     (FDisplaySelected);
   chkMouseMovesWindow.Checked := VideoGrabber.GetDisplayMouseMovesWindow
     (FDisplaySelected);
   chkAutoSize.Checked := VideoGrabber.GetDisplayAutoSize(FDisplaySelected);
   rdgAspectRatio.ItemIndex :=
     Integer(VideoGrabber.GetDisplayAspectRatio(FDisplaySelected));
   tbrPanScan.Position := VideoGrabber.GetDisplayPanScanRatio(FDisplaySelected);
   chkAlphablend.Checked := VideoGrabber.GetDisplayAlphaBlendEnabled
     (FDisplaySelected);
   tbrAlphablend.Position := VideoGrabber.GetDisplayAlphaBlendValue
     (FDisplaySelected);
   chkTranspColor.Checked := VideoGrabber.GetDisplayTransparentColorEnabled
     (FDisplaySelected);
   edttranspColor.Text := Format('%.6X',
     [VideoGrabber.GetDisplayTransparentColorValue(FDisplaySelected)]);
   edtAssignToMonitorNumber.Text :=
     IntToStr(VideoGrabber.GetDisplayMonitor(FDisplaySelected));

   EnableOrDisableGroupBoxControls(grbMainVideoWindow,
     VideoGrabber.GetDisplayActive(FDisplaySelected));

   if VideoGrabber.GetDisplayActive(FDisplaySelected) then
   begin
      chkStayOnTop.Enabled :=
        (not VideoGrabber.GetDisplayEmbedded(FDisplaySelected)) or
        VideoGrabber.GetDisplayFullScreen(FDisplaySelected);
      edtAssignToMonitorLabel.Enabled := VideoGrabber.MonitorsCount > 1;
      edtAssignToMonitorNumber.Enabled := VideoGrabber.MonitorsCount > 1;
      chkMouseMovesWindow.Enabled := not VideoGrabber.GetDisplayEmbedded
        (FDisplaySelected);
      btnNewLocation2.Enabled := not VideoGrabber.GetDisplayEmbedded
        (FDisplaySelected);
      chkUseVideoPort.Enabled := VideoGrabber.IsVideoPortAvailable;
      chkAlphablend.Enabled := not VideoGrabber.GetDisplayEmbedded
        (FDisplaySelected);
      chkTranspColor.Enabled := not VideoGrabber.GetDisplayEmbedded
        (FDisplaySelected);
   end;

end;

procedure TfrmMainForm.chkBlackMagicDecklinkClick(Sender: TObject);
begin
   if chkBlackMagicDecklink.Checked then
   begin
      VideoGrabber.VideoRendererExternal := vre_BlackMagic_Decklink;
   end
   else
   begin
      VideoGrabber.VideoRendererExternal := vre_None;
   end;
end;

procedure TfrmMainForm.chkVideoVisibleWhenStoppedClick(Sender: TObject);
begin
   VideoGrabber.VideoVisibleWhenStopped := chkVideoVisibleWhenStopped.Checked;
end;

procedure TfrmMainForm.chkAdjustPixelAspectRatioClick(Sender: TObject);
begin
   VideoGrabber.AdjustPixelAspectRatio := chkAdjustPixelAspectRatio.Checked;
end;

procedure TfrmMainForm.chkChangeCursorClick(Sender: TObject);
begin
   case chkChangeCursor.Checked of
      true:
         VideoGrabber.VideoCursor := crCross;
      False:
         VideoGrabber.VideoCursor := crDefault;
   end;
end;

procedure TfrmMainForm.chkBorderClick(Sender: TObject);
begin
   if chkBorder.Checked then
   begin
      VideoGrabber.BorderStyle := bsSingle;
   end
   else
   begin
      VideoGrabber.BorderStyle := bsNone;
   end;
end;

procedure TfrmMainForm.chkZeroLatencyClick(Sender: TObject);
begin
   if chkZeroLatency.Checked then
   begin
      VideoGrabber.SyncPreview := sp_Disabled;
   end
   else
   begin
      VideoGrabber.SyncPreview := sp_Auto;
   end;
end;

procedure TfrmMainForm.chkTransparencyClick(Sender: TObject);
var
   Button: TButton;
begin
   VideoGrabber.ColorKeyEnabled := chkTransparency.Checked;
   if VideoGrabber.ColorKeyEnabled then
   begin
      if not assigned(FTransparentForm) then
      begin
         Application.CreateForm(TForm, FTransparentForm);
         FTransparentForm.Width := 300;
         FTransparentForm.Height := 200;
         FTransparentForm.Position := poScreenCenter;
         FTransparentForm.Formstyle := fsStayOnTop;
         FTransparentPanel := TPanel.Create(FTransparentForm);
         FTransparentPanel.Parent := FTransparentForm;
         FTransparentPanel.BevelInner := bvNone;
         FTransparentPanel.BevelOuter := bvNone;
         // FTransparentPanel.Align := alClient;
         FTransparentPanel.Top := 0;
         FTransparentPanel.Caption := 'transparent window';
         FTransparentPanel.Font.Color := clRed;
         FTransparentPanel.Font.Size := 16;
         Button := TButton.Create(FTransparentForm);
         Button.Top := 100;
         Button.Width := 200;
         Button.Parent := FTransparentForm;
         Button.Caption := 'click to remove border';
         Button.OnClick := TransparentFormButtonClick;
      end;

      FTransparentForm.Color := VideoGrabber.ColorKey;
      FTransparentPanel.Color := VideoGrabber.ColorKey;
      VideoGrabber.SetWindowTransparency(FTransparentForm.Handle, true,
        False, 0);
      FTransparentForm.Show;
   end;
end;

procedure TfrmMainForm.TransparentFormButtonClick(Sender: TObject);
begin
   FTransparentForm.BorderStyle := bsNone;
   VideoGrabber.SetWindowTransparency(FTransparentForm.Handle, true, False, 0);
end;

procedure TfrmMainForm.rdgVideoRendererClick(Sender: TObject);
begin
   VideoGrabber.VideoRenderer := TVideoRenderer(rdgVideoRenderer.ItemIndex);
end;

procedure TfrmMainForm.chkDisplayActiveClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayActive(FDisplaySelected, chkDisplayActive.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkVisibleClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayVisible(FDisplaySelected, chkVisible.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkEmbeddedClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayEmbedded(FDisplaySelected, chkEmbedded.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkAutoSizeClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayAutoSize(FDisplaySelected, chkAutoSize.Checked);
   if not VideoGrabber.GetDisplayAutoSize(FDisplaySelected) then
   begin
      VideoGrabber.SetDisplayWidth(FDisplaySelected, 320);
      VideoGrabber.SetDisplayHeight(FDisplaySelected, 240);
   end;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkFullScreenClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayFullScreen(FDisplaySelected, chkFullScreen.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkStayOnTopClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayStayOnTop(FDisplaySelected, chkStayOnTop.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkUseVideoPortClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayVideoPortEnabled(FDisplaySelected,
     chkUseVideoPort.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.btnNewLocation2Click(Sender: TObject);
begin
   VideoGrabber.SetDisplayAutoSize(FDisplaySelected, False);
   // we will specify the size below
   VideoGrabber.SetDisplayEmbedded(FDisplaySelected, False);
   // detach from component
   VideoGrabber.SetDisplayLocation(FDisplaySelected, 20, 20, 640, 480);
   // DisplayAutoSize=false, we can specify a size
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chkMouseMovesWindowClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayMouseMovesWindow(FDisplaySelected,
     chkMouseMovesWindow.Checked);
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.rdgAspectRatioClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayAspectRatio(FDisplaySelected,
     TAspectRatio(rdgAspectRatio.ItemIndex));
end;

procedure TfrmMainForm.tbrPanScanChange(Sender: TObject);
begin
   VideoGrabber.SetDisplayPanScanRatio(FDisplaySelected, tbrPanScan.Position);
end;

procedure TfrmMainForm.btnTestPanScanClick(Sender: TObject);
begin
   rdgAspectRatio.ItemIndex := Integer(ar_PanScan);
   VideoGrabber.SetDisplayAspectRatio(FDisplaySelected, ar_PanScan);
   VideoGrabber.SetDisplayEmbedded(FDisplaySelected, true);
   VideoGrabber.SetDisplayAutoSize(FDisplaySelected, False);
   VideoGrabber.Width := 600;
   VideoGrabber.Height := VideoGrabber.Width * 9 div 16;
end;

procedure TfrmMainForm.chkAlphablendClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayAlphaBlendEnabled(FDisplaySelected,
     chkAlphablend.Checked);
end;

procedure TfrmMainForm.edtAssignToMonitorNumberChange(Sender: TObject);
begin
   VideoGrabber.SetDisplayMonitor(FDisplaySelected,
     StrToIntDef(edtAssignToMonitorNumber.Text, 0));
end;

procedure TfrmMainForm.tbrAlphablendChange(Sender: TObject);
begin
   VideoGrabber.SetDisplayAlphaBlendValue(FDisplaySelected,
     tbrAlphablend.Position);
end;

procedure TfrmMainForm.chkTranspColorClick(Sender: TObject);
begin
   VideoGrabber.SetDisplayTransparentColorEnabled(FDisplaySelected,
     chkTranspColor.Checked);
end;

procedure TfrmMainForm.edttranspColorChange(Sender: TObject);
begin
   VideoGrabber.SetDisplayTransparentColorValue(FDisplaySelected,
     StrToIntDef('$' + edttranspColor.Text, 0));
end;

/// /////////////////////////////////////////////////////////////////////////////
// MOTION DETECTOR TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.chkMotionDetectionEnabledClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_Enabled := chkMotionDetectionEnabled.Checked;
end;

procedure TfrmMainForm.chkCompareRedClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_CompareRed := chkCompareRed.Checked;
end;

procedure TfrmMainForm.chkCompareGreenClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_CompareGreen := chkCompareGreen.Checked;
end;

procedure TfrmMainForm.chkCompareBlueClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_CompareBlue := chkCompareBlue.Checked;
end;

procedure TfrmMainForm.chk_GreyScaleClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_GreyScale := chk_GreyScale.Checked;
end;

procedure TfrmMainForm.chkReduceVideoNoiseClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_ReduceVideoNoise := chkReduceVideoNoise.Checked;
end;

procedure TfrmMainForm.edtGridChange(Sender: TObject);
begin
   VideoGrabber.MotionDetector_Grid := edtGrid.Text;
   if VideoGrabber.MotionDetector_IsGridValid then
   begin
      shpGridValid.Brush.Color := clLime;
      lblGridValid.Caption := 'valid';
   end
   else
   begin
      shpGridValid.Brush.Color := clRed;
      lblGridValid.Caption := 'invalid';
   end;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.updGlobalGridSensitivityClick(Sender: TObject;
  Button: TUDBtnType);
begin
   if Button = btNext then
   begin
      VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(1);
   end
   else
   begin
      VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(-1);
   end;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
end;

procedure TfrmMainForm.btnApplyGridSizeClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_SetGridSize(StrToInt(edtGridColCount.Text),
     StrToInt(edtGridRowCount.Text));
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.btnSetCellsSensitivityClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_SetCellSensitivity(StrToInt(edtXCell.Text),
     StrToInt(edtYCell.Text), StrToInt(edtCellSensitivity.Text));
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.btnShowGridDialogClick(Sender: TObject);
begin
   if (VideoGrabber.CurrentState <> cs_Preview) and
     (VideoGrabber.CurrentState <> cs_Recording) then
   begin
      ShowMessage
        ('you should start preview or recording to see the video frame under the grid');
   end
   else if not VideoGrabber.MotionDetector_Enabled then
   begin
      ShowMessage
        ('you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid');
   end;
   VideoGrabber.MotionDetector_ShowGridDialog;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.chkTriggeredClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_Triggered := chkTriggered.Checked;
end;

procedure TfrmMainForm.btnTriggerNowClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_TriggerNow;
end;

procedure TfrmMainForm.VideoGrabberMotionDetected(Sender: TObject;
  GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: LongInt;
  FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
  FrameId: LongInt; var CaptureFrame: Boolean);
var
   MaxMotionXLocation, MaxMotionYLocation: LongInt;
   MotionBitmap: TBitmap;
begin
   shpMotionDetected.Brush.Color := clLime;
   edtMotionRatio.Text := FormatFloat('0.000',
     VideoGrabber.MotionDetector_GlobalMotionRatio);

   edtMaxMotionXY.Text := 'X:' + IntToStr(MaxMotionCellX) + ' ; Y:' +
     IntToStr(MaxMotionCellY);
   if VideoGrabber.MotionDetector_GetCellLocation(MaxMotionCellX,
     MaxMotionCellY, MaxMotionXLocation, MaxMotionYLocation) then
   begin
      edtMaxMotionCoord.Text := 'x: ' + IntToStr(MaxMotionXLocation) + ' ; y: '
        + IntToStr(MaxMotionYLocation);
   end;

   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;

   MotionBitmap := VideoGrabber.GetLastFrameAsTBitmap(0, False, 0, 0, 0, 0,
     imgMotionDetected.Width, imgMotionDetected.Height, 0);
   if assigned(MotionBitmap) then
   begin
      imgMotionDetected.Picture.Assign(MotionBitmap);
      MotionBitmap.Free;
   end;
end;

procedure TfrmMainForm.VideoGrabberMotionNotDetected(Sender: TObject;
  FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
  FrameId: LongInt; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Brush.Color := clGreen;
   edtMotionRatio.Text := '';
   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;
end;

/// /////////////////////////////////////////////////////////////////////////////
// "CLIP REENCODING" TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnSourceVideoClipClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   edtDestinationVideoClip.Text := '';
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then
   begin
      edtSourceVideoClip.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnDurationClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
begin
   if VideoGrabber.AVIDuration(edtSourceVideoClip.Text, Duration, FrameCount)
   then
   begin
      edtReencDuration.Text := IntToStr(Duration);
      edtReencFrameCount.Text := IntToStr(FrameCount);
   end;
end;

procedure TfrmMainForm.btnStartReencodingClick(Sender: TObject);
begin
   VideoGrabber.Reencoding_SourceVideoClip := edtSourceVideoClip.Text;
   VideoGrabber.Reencoding_NewVideoClip := edtDestinationVideoClip.Text;

   VideoGrabber.Reencoding_WMVOutput := chkWMVOutput.Checked;
   VideoGrabber.Reencoding_IncludeVideoStream := chkIncludeVideoStream.Checked;
   VideoGrabber.Reencoding_IncludeAudioStream := chkIncludeAudioStream.Checked;
   VideoGrabber.Reencoding_UseFrameGrabber := chkUseFrameGrabber.Checked;
   VideoGrabber.Reencoding_UseVideoCompressor :=
     chkUseCurrentVideoCompressor.Checked;
   VideoGrabber.Reencoding_UseAudioCompressor :=
     chkUseCurrentAudioCompressor.Checked;
   VideoGrabber.Reencoding_Method :=
     TRecordingMethod(rdgReencodingMethod.ItemIndex);

   // if a frame number is specified (<> -1), it is mandatory, so the time is ignored
   VideoGrabber.Reencoding_StartTime :=
     StrToInt64Def(edtReencStartTime.Text, -1);
   VideoGrabber.Reencoding_StartFrame :=
     StrToInt64Def(edtReencStartFrame.Text, -1);
   VideoGrabber.Reencoding_StopTime := StrToInt64Def(edtReencStopTime.Text, -1);
   VideoGrabber.Reencoding_StopFrame :=
     StrToInt64Def(edtReencStopFrame.Text, -1);

   VideoGrabber.StartReencoding;
end;

procedure TfrmMainForm.btnStopReencodingClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

/// /////////////////////////////////////////////////////////////////////////////
// MISC.
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.edtStoragePathChange(Sender: TObject);
begin
   VideoGrabber.StoragePath := edtStoragePath.Text;
end;

procedure TfrmMainForm.ShowFormAboveVideo(Form: TForm);
begin
   if not assigned(Form) then
      Exit;
   Form.Top := Top + VideoGrabber.Top - Form.Height;
   Form.Left := Left + VideoGrabber.Left - Form.Width;
   if Form.Top < 0 then
   begin
      Form.Top := 0;
   end;
   if Form.Left < 0 then
   begin
      Form.Left := 0;
   end;
   Form.Show;
end;

procedure TfrmMainForm.RefreshDeviceControls;
begin
   if csDestroying in ComponentState then
      Exit; // do nothing if the app terminates

   // let's refresh the controls according to the TVideoGrabber current video device selected

   AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats,
     VideoGrabber.VideoFormat);
   AssignListToComboBox(cboVideoSizes, VideoGrabber.VideoSizes,
     VideoGrabber.VideoSize);
   AssignListToComboBox(cboVideoSubtypes, VideoGrabber.VideoSubtypes,
     VideoGrabber.VideoSubtype);
   AssignListToComboBox(cboVideoInputs, VideoGrabber.VideoInputs,
     Integer(VideoGrabber.VideoInput));
   AssignListToComboBox(cboAnalogVideoStandard,
     VideoGrabber.AnalogVideoStandards,
     Integer(VideoGrabber.AnalogVideoStandard));

   btnPauseRecording.Enabled := VideoGrabber.RecordingCanPause;
   btnResumeRecording.Enabled := VideoGrabber.RecordingCanPause;

   btnCameraControlDialog.Enabled := VideoGrabber.IsCameraControlAvailable;
   btnVideoQualityDialog.Enabled := VideoGrabber.IsVideoQualityAvailable;

   cboAnalogVideoStandard.Enabled := VideoGrabber.IsAnalogVideoDecoderAvailable;
   cboVideoInputs.Enabled := VideoGrabber.IsVideoCrossbarAvailable;

   edtFrameRate.Text := FormatFloat('0.00', VideoGrabber.FrameRate);

   lblFrameOverlayRequiresFrameGrabber.Visible :=
     VideoGrabber.FrameGrabber = fg_Disabled;
   lblMotionDetectorRequiresFrameGrabber.Visible :=
     VideoGrabber.FrameGrabber = fg_Disabled;

end;

procedure TfrmMainForm.Resetvideocapturedevicesettings1Click(Sender: TObject);
begin
   VideoGrabber.ResetVideoDeviceSettings;
end;

procedure TfrmMainForm.VideoGrabberDVCommandCompleted(Sender: TObject;
  NewStateValue: Integer; NewStateLabel: String);
begin
   mmoLog.Lines.Add('camcorder state: ' + NewStateLabel);
end;

procedure TfrmMainForm.VideoGrabberDVDiscontinuity(Sender: TObject;
  var DeliverNewFrame: Boolean);
begin
   // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame := false;
   // VideoGrabber.RecordToNewFileNow;

   // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame := false;
   // VideoGrabber.Stop;

   // Important: from this event you should not perform any actions with the potential to block, such as holding
   // a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
end;

procedure TfrmMainForm.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add('[' + Severity + '] ' + InfoMsg);
end;

procedure TfrmMainForm.VideoGrabberInactive(Sender: TObject);
begin
   mmoLog.Lines.Add('(done.)');
end;

procedure TfrmMainForm.mnuAboutClick(Sender: TObject);
begin
   VideoGrabber.About;
end;

procedure TfrmMainForm.VideoGrabberResize(Sender: TObject);
var
   NewWidth: Integer;
   NewHeight: Integer;
begin
   NewWidth := VideoGrabber.Left + VideoGrabber.Width + 30;
   NewHeight := VideoGrabber.Top + VideoGrabber.Height + 60;
   if NewWidth < FStartupWidth then
   begin
      NewWidth := FStartupWidth;
   end;
   if NewHeight < FStartupHeight then
   begin
      NewHeight := FStartupHeight;
   end;
   if (NewWidth >= Width) and (NewHeight >= Height) then
   begin
      Width := NewWidth;
      Height := NewHeight;
   end;
end;

procedure TfrmMainForm.VideoGrabberDeviceLost(Sender: TObject);
begin
   mmoLog.Lines.Add('DEVICE LOST!');
   AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices,
     VideoGrabber.VideoDevice);
   AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices,
     VideoGrabber.AudioDevice);
end;

procedure TfrmMainForm.VideoGrabberDiskFull(Sender: TObject);
begin
   mmoLog.Lines.Add('DISK FULL!');
end;

procedure TfrmMainForm.VideoGrabberReinitializing(Sender: TObject);
begin
   FOldVideoSignalState := False;
end;

procedure TfrmMainForm.VideoGrabberDeviceArrivalOrRemoval(Sender: TObject;
  IsDeviceArrival, IsVideoDevice: Boolean; DeviceName: String;
  DeviceIndex: Integer);
var
   AudioOrVideoDevice: string;
begin
   if IsVideoDevice then
   begin
      AudioOrVideoDevice := 'video device ';
   end
   else
   begin
      AudioOrVideoDevice := 'audio device ';
   end;
   if IsDeviceArrival then
   begin
      mmoLog.Lines.Add(AudioOrVideoDevice + 'arrival:');
   end
   else
   begin
      mmoLog.Lines.Add(AudioOrVideoDevice + 'removal:');
   end;
   mmoLog.Lines.Add(DeviceName);
   if IsVideoDevice then
   begin
      AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices,
        VideoGrabber.VideoDevice);
   end
   else
   begin
      AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices,
        VideoGrabber.AudioDevice);
   end;
end;

procedure TfrmMainForm.VideoGrabberVideoFromBitmapsNextFrameNeeded
  (Sender: TObject; FirstSample: Boolean);
var
   FileAvailable: Boolean;
   EndOfData: Boolean;
   BMPorJPEGFilePath: string;
begin
   FileAvailable := False;
   EndOfData := False;

   if FirstSample or (not FSearchBmpFilesOpened) then
   begin // let's start from the first file

      if FSearchBmpFilesOpened then
      begin
         FindClose(FSearchBmpFiles);
         FSearchBmpFilesOpened := False;
      end;

      if Length(VideoGrabber.StoragePath) > 0 then
      begin // let's add a trailing slash if required
         if (VideoGrabber.StoragePath[Length(VideoGrabber.StoragePath)]) = '\'
         then
         begin
            FSearchBmpPath := VideoGrabber.StoragePath;
         end
         else
         begin
            FSearchBmpPath := VideoGrabber.StoragePath + '\';
         end;
      end
      else
      begin
         FSearchBmpPath := '.\';
      end;

      if FindFirst(FSearchBmpPath + '*.bmp', faAnyFile, FSearchBmpFiles) = 0
      then
      begin
         FileAvailable := true;
         FSearchBmpFilesOpened := true;
      end
      else if FindFirst(FSearchBmpPath + '*.jpg', faAnyFile, FSearchBmpFiles) = 0
      then
      begin
         FileAvailable := true;
         FSearchBmpFilesOpened := true;
      end
      else
      begin
         mmoLog.Lines.Add('');
         mmoLog.Lines.Add
           ('no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber.');
         EndOfData := true;
      end;
   end
   else
   begin
      if FindNext(FSearchBmpFiles) = 0 then
      begin
         FileAvailable := true;
      end
      else
      begin
         FindClose(FSearchBmpFiles);
         FSearchBmpFilesOpened := False;
         EndOfData := true;
      end;
   end;

   if FileAvailable then
   begin
      // we can pass a bitmap handle to "BitmapHandle" or a BMP or JPEG file to BMPorJPEGFile
      // in this case we pass a BMP or JPEG file, so we set BitmapHandle = 0
      BMPorJPEGFilePath := FSearchBmpPath + FSearchBmpFiles.Name;

      VideoGrabber.SendImageToVideoFromBitmaps(BMPorJPEGFilePath, 0, False,
        EndOfData);
   end
	else
   begin
		// to notify no more images available we pass an empty file name and set the EndOfData parameter to "true"
      VideoGrabber.SendImageToVideoFromBitmaps('', 0, False, true);
   end;
end;

procedure TfrmMainForm.btnONVIFReplayRecordingsListClick(Sender: TObject);
var
	XMLReplayRecordings: string;
begin
	XMLReplayRecordings := VideoGrabber.ONVIFDeviceInfo(onv_XMLReplay);
	if XMLReplayRecordings <> '' then
	begin
      mmoLog.Lines.Add(XMLReplayRecordings);
   end
   else
   begin
      mmoLog.Lines.Add('');
      mmoLog.Lines.Add
        ('Error! First start the onvif://... preview, or at least set the ONVIF URL and set VideoSource=vs_IPCamera, e.g.');
      mmoLog.Lines.Add('');
      mmoLog.Lines.Add('vg.VideoSource=vs_IPCamera');
      mmoLog.Lines.Add('vg.IPCameraURL="onvif://..."');
      mmoLog.Lines.Add('string XMLData=vg.ONVIFDeviceInfo(onv_XMLReplay)');
   end;
end;

procedure TfrmMainForm.btnOpenAtFramesClick(Sender: TObject);
begin
   // -2 is just used to check if the numeric value is valid
   if (StrToIntDef(edtartFrame.Text, -2) <> -2) and
     (StrToIntDef(edtopFrame.Text, -2) <> -2) then
   begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayerAtFramePositions(StrToInt(edtartFrame.Text),
        StrToInt(edtopFrame.Text), chkKeepBounds.Checked, chkReopen.Checked);
   end
   else
   begin
      ShowMessage('invalid start frame or stop frame');
   end;
end;

procedure TfrmMainForm.btnOpenAtTimesClick(Sender: TObject);
begin
   // -2 is just used to check if the numeric value is valid
   if (StrToIntDef(edtartTime.Text, -2) <> -2) and
     (StrToIntDef(edtopTime.Text, -2) <> -2) then
   begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayerAtTimePositions(StrToInt(edtartTime.Text),
        StrToInt(edtopTime.Text), chkKeepBounds.Checked, chkReopen.Checked);
   end
   else
   begin
      ShowMessage('invalid start Time or stop Time');
   end;
end;

// IP Cameras

procedure TfrmMainForm.tbsIPCamerasShow(Sender: TObject);
begin
   lblChooseIPCamera.Visible := VideoGrabber.VideoSource <> vs_IPCamera;
end;

procedure TfrmMainForm.btnCurrentIPCameraURLClick(Sender: TObject);
begin
   ShellExecute(0, 'open', PChar('http://www.datastead.com/demo/IPCam.htm'), '',
     '', SW_SHOW);
end;

procedure TfrmMainForm.chkOpenURLAsyncClick(Sender: TObject);
begin
   VideoGrabber.OpenURLAsync := chkOpenURLAsync.Checked;
end;

procedure TfrmMainForm.edtIPCamUserNameChange(Sender: TObject);
begin
	VideoGrabber.SetAuthentication(at_IPCamera, edtIPCamUserName.Text,
     edtIPCamPassword.Text);
end;

procedure TfrmMainForm.edtIPCamPasswordChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication(at_IPCamera, edtIPCamUserName.Text,
     edtIPCamPassword.Text);
end;

procedure TfrmMainForm.edtIPCamConnectionTimeoutChange(Sender: TObject);
begin
   VideoGrabber.SetIPCameraSetting(ips_ConnectionTimeout, StrToIntDef(edtIPCamConnectionTimeout.Text, 10000));
end;

procedure TfrmMainForm.edtIPCameraURLChange(Sender: TObject);
begin
	VideoGrabber.IPCameraURL := edtIPCameraURL.Text;
end;

procedure TfrmMainForm.btnIPCamStartPreviewClick(Sender: TObject);
begin
   ChangeVideoSource (vs_IPCamera);
   edtIPCameraURL.Text := VideoGrabber.IPCameraURL;
   // to reflect the current URL entered
   VideoGrabber.StartPreview;
end;

procedure TfrmMainForm.btnIPCamStartPTZClick(Sender: TObject);
begin
   VideoGrabber.StartPTZ();
end;

procedure TfrmMainForm.btnIPCameraStopClick(Sender: TObject);
begin
   VideoGrabber.Stop();
end;

procedure TfrmMainForm.btnIPCameraStarttMP4RecordingClick(Sender: TObject);
var
   BacktimedRecordingDurationInSeconds: LongInt;
begin
   ChangeVideoSource (TVideoSource (cboVideoSource.ItemIndex));
	rdgRecordingMethod.ItemIndex := Integer(rm_MP4);
	edtIPCameraURL.Text := VideoGrabber.IPCameraURL;
   // to reflect the current URL entered
   if (chkBacktimedRecordingSeconds.Checked) then
   begin
      BacktimedRecordingDurationInSeconds :=
        StrToIntDef(edtBacktimedRecordingSeconds.Text, 0);
      if BacktimedRecordingDurationInSeconds > 0 then
      begin
			// to activate a pre-roll of 5 seconds on the RTSP filter add ">backtimed=5" at the end of the RTSP URL
         VideoGrabber.IPCameraURL := edtIPCameraURL.Text + '>backtimed=' +
           IntToStr(BacktimedRecordingDurationInSeconds);
         VideoGrabber.HoldRecording := true;
         // to start the recording in "preview mode", ready to start the recording when VideoGrabber.ResumeRecording will be invoked
      end;
   end;
	VideoGrabber.StartRecording();
end;

procedure TfrmMainForm.FormDestroy(Sender: TObject);
begin
   if FSearchBmpFilesOpened then
   begin
      FindClose(FSearchBmpFiles);
      FSearchBmpFilesOpened := False;
   end;
end;

procedure TfrmMainForm.mmoLogKeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
   VideoGrabber.Version := mmoLog.Text;
end;

procedure ShowTargetDisplayInfo();
begin
   ShowMessage
     ('SetTextOverlay_TargetDisplay / SetImageOverlay_TargetDisplay determines how the overlay is be applied (*):'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = -1: OVERLAY APPLIED TO THE VIDEO FRAME' + #13#10 +
     'advantage: the overlay can applied on the recording if RecordingInNativeFormat is disabled'
     + #13#10 +
     'disadvantage: if the frame is stretched (e.g. full screen display) the overlay is stretched as well'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = -2: OVERLAY APPLIED TO ALL THE VIDEO WINDOWS but not to the video frames (recorded or captured)'
     + #13#10 +
     'advantage: when stretching the video windows (e.g. full screen display), the overlays are not stretched'
     + #13#10 +
     'disadvantage: it is applied the same way on all the renderers (e.g. if DualDisplay or more renderers are enabled)'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = -3: OVERLAY APPLIED TO THE VIDEO CONTROL WHEN IT IS INACTIVE'
     + #13#10 +
     'this allows to display e.g. a camera number or a logo while the TVideoGrabber control is not displaying the video.'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = n (in the 0..n-1 range): OVERLAY APPLIED TO THE SPECIFIED VIDEO WINDOW'
     + #13#10 +
     'advantage: when more than 1 renderer is used, it is possible to display this overlay only one the specified renderer'
     + #13#10 + 'Possible values:' + #13#10 + ' 0: Display... renderer' + #13#10
     + ' 1: DualDisplay... renderer' + #13#10 +
     ' 2 to 9: third to tenth video renderer' + #13#10 + '' + #13#10 +
     '(*) notes:' + #13#10 +
     '- TargetDisplay <> -1 REQUIRES VideoRenderer to be set to vr_Auto or vr_RecordingPriority'
     + #13#10 +
     '- to quick see what happens when changing TargetDisplay, go to theDisplay tab, activate e.g. 4 or 5 video windows and try -1, -2, 0, 1, 2, 3, 4, 5 as TargetDisplay value');
end;

procedure TfrmMainForm.btnTargetDisplayInfoClick(Sender: TObject);
begin
   ShowTargetDisplayInfo();
end;

procedure TfrmMainForm.rdgDisplaySelectedClick(Sender: TObject);
begin
   FDisplaySelected := rdgDisplaySelected.ItemIndex;
   RefreshDisplayOptions();
end;

procedure TfrmMainForm.VideoGrabberMultipurposeEncoderProgress(Sender: TObject;
  MultipurposeEncoderInstance: TMultipurposeEncoderInstance);
var
   InputsTotalDurationMs: Cardinal;
   FrameCount: Cardinal;
   fps: Double;
   quality: Double;
   SizeWrittenKb: Double;
   TimeMs: Cardinal;
   BitRate: Double;
	DuplicatedCount: Cardinal;
   DroppedCount: Cardinal;
   ExitCode: LongInt;
   ProgressInfo: string;
begin
   VideoGrabber.MultipurposeEncoder_GetCurrentInfo(MultipurposeEncoderInstance,
     InputsTotalDurationMs, FrameCount, fps, quality, SizeWrittenKb, TimeMs,
     BitRate, DuplicatedCount, DroppedCount, ExitCode);
   ProgressInfo :=
     Format('Frame count: %4d       Fps: %2.1f        Time(ms):%10d       Written(kb): %5.1f       Bitrate(kbps): %5.1f       Dropped:  %4d',
     [FrameCount, fps, TimeMs, SizeWrittenKb, BitRate, DroppedCount]);

   if MultipurposeEncoderInstance = mpe_Recording then
   begin
      lblMPERecordingProgressInfo.Caption := ProgressInfo;
      mmoMPERecordingLog.Lines.Add(VideoGrabber.MultipurposeEncoder_GetLastLog
        (mpe_Recording));
   end
   else if MultipurposeEncoderInstance = mpe_Streaming then
   begin
      lblMPEStreamingProgressInfo.Caption := ProgressInfo;
      mmoMPEStreamingLog.Lines.Add(VideoGrabber.MultipurposeEncoder_GetLastLog
        (mpe_Streaming));
   end
   else if MultipurposeEncoderInstance = mpe_Reencoding then
   begin
      lblMPEReencodingProgressInfo.Caption := ProgressInfo;
      mmoMPEReencodingLog.Lines.Add(VideoGrabber.MultipurposeEncoder_GetLastLog
        (mpe_Reencoding));
   end;
end;

procedure TfrmMainForm.VideoGrabberONVIFDiscoveryCompleted(Sender: TObject;
  DiscoveryCallbackStatus: TDiscoveryCallbackStatus; CameraCount: LongInt);
var
	iCamera: LongInt;
	CameraType, CameraONVIFServiceUrl: string;
	CameraInfo: string;
begin
	if DiscoveryCallbackStatus in [dcs_CameraFound]  then begin
		CameraType := '';
		CameraONVIFServiceUrl := '';
		if VideoGrabber.ONVIFEnumCamerasDiscovered (CameraCount - 1, CameraType, CameraONVIFServiceURL) then begin
         mmoLog.Lines.Add ('camera found: ' + CameraType);
      end;
   end
   else if DiscoveryCallbackStatus in [dcs_MulticastCompleted, dcs_IPRangeCompleted]  then begin
		iCamera := 0;
		CameraType := '';
		CameraONVIFServiceUrl := '';
		while VideoGrabber.ONVIFEnumCamerasDiscovered (iCamera, CameraType, CameraONVIFServiceURL) do begin
			CameraInfo := '[ ' + CameraType + ' ] ' +  CameraONVIFServiceURL;
			if lsbOnvifURLsDiscovered.Items.IndexOf (CameraInfo) = -1 then begin
				lsbOnvifURLsDiscovered.Items.Add (CameraInfo);
			end;
			inc (iCamera);
		end;
	end;
end;

procedure TfrmMainForm.chkMPERecordingClick(Sender: TObject);
begin
   VideoGrabber.EnableMultipurposeEncoder(mpe_Recording,
     chkMPERecording.Checked);
   edtMPERecordingChange(Self); // to apply the recording settings
end;

procedure TfrmMainForm.chkMPEStreamingClick(Sender: TObject);
begin
   VideoGrabber.EnableMultipurposeEncoder(mpe_Streaming,
     chkMPEStreaming.Checked);
   edtMPEStreamingChange(Self); // to apply the streaming settings
end;

procedure TfrmMainForm.edtMPERecordingChange(Sender: TObject);
begin
   VideoGrabber.SetMultipurposeEncoderSettings(mpe_Recording,
     edtMPERecording.Text);
end;

procedure TfrmMainForm.edtMPEReencodingChange(Sender: TObject);
begin
   VideoGrabber.SetMultipurposeEncoderSettings(mpe_Reencoding,
     edtMPEReencoding.Text);
end;

procedure TfrmMainForm.edtMPEStreamingChange(Sender: TObject);
begin
   VideoGrabber.SetMultipurposeEncoderSettings(mpe_Streaming,
     edtMPEStreaming.Text);
end;

procedure TfrmMainForm.edtNDIReceiveTimeoutChange(Sender: TObject);
begin
   VideoGrabber.NDIReceiveTimeoutMs :=
     StrToIntDef(edtNDIReceiveTimeout.Text, 0);
end;

procedure TfrmMainForm.btnStartMPEReencodingClick(Sender: TObject);
begin
   edtMPEReencodingChange(Self); // to apply the reencoding settings
   VideoGrabber.EnableMultipurposeEncoder(mpe_Reencoding, true);
   VideoGrabber.StartReencoding();
end;

procedure TfrmMainForm.btnStopMPEReencodingClick(Sender: TObject);
begin
   VideoGrabber.Stop();
end;

procedure TfrmMainForm.tbrPTZSpeedRatioChange(Sender: TObject);
begin
   FPTZSpeedRatio := tbrPTZSpeedRatio.Position / 100;
end;

procedure TfrmMainForm.btnPTZHelpDurationClick(Sender: TObject);
begin
   ShowMessage('Duration of the motion expressed in milliseconds.' + #13#10 +
     '0 = continuous move' + #13#10#13#10 +
     'Note: some cameras may not support a motion duration and move continuously even if a duration is specified.'
     + #13#10 +
     ' In this case invoke StartMove(), wait the desired duration with a timer then invoke ONVIFPTZStopMove()');
end;

procedure TfrmMainForm.btnHelpPTZSpeedRatioClick(Sender: TObject);
begin
   ShowMessage
     ('the "PTZ speed adjustment" and "absolute PTZ move" capabilities are not supported by all the brands/models of ONVIF cameras');
end;

procedure TfrmMainForm.PTZStopContinuousMove();
begin
   VideoGrabber.ONVIFPTZStopMove('Tilt');
   VideoGrabber.ONVIFPTZStopMove('Pan');
   VideoGrabber.ONVIFPTZStopMove('Zoom');
end;

procedure TfrmMainForm.PTZStopClick(Sender: TObject);
begin
   PTZStopContinuousMove();
end;

procedure TfrmMainForm.PTZButtonsMouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
   if chkPTZMouseUpStop.Checked then
   begin
      PTZStopContinuousMove();
   end;
end;

procedure TfrmMainForm.rdgIRCutFilterClick(Sender: TObject);
begin
   case rdgIRCutFilter.ItemIndex of
      0:
         VideoGrabber.ONVIF_SetStr('RTSP_Source_Axis_IrCutFilter_str', 'auto');
      1:
         VideoGrabber.ONVIF_SetStr('RTSP_Source_Axis_IrCutFilter_str',
           'enabled');
      2:
         VideoGrabber.ONVIF_SetStr('RTSP_Source_Axis_IrCutFilter_str',
           'disabled');
   end;
end;

procedure TfrmMainForm.edtPTZDurationMsChange(Sender: TObject);
begin
   FPTZMoveDurationMs := StrToIntDef(edtPTZDurationMs.Text, 300);
end;

procedure TfrmMainForm.btnPTZTiltUpMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
   VideoGrabber.ONVIFPTZStartMove('Tilt', False, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZTiltDownMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
   VideoGrabber.ONVIFPTZStartMove('Tilt', true, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZPanLeftMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
   VideoGrabber.ONVIFPTZStartMove('Pan', False, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZPanRightMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
   VideoGrabber.ONVIFPTZStartMove('Pan', true, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZZoomOutMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
   VideoGrabber.ONVIFPTZStartMove('Zoom', False, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZZoomInClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZStartMove('Zoom', true, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.DoPTZAbsolute();
var
   dPan, dTilt, dZoom: Double;
begin
   if not FUpdatingPTZTrackbars then
   begin
      if (GetKeyState(VK_LBUTTON) and $8000) = 0 then
      begin // to do something only when the mouse button is released on the trackbar
         dPan := tbrPTZPan.Position / 100;
         dTilt := tbrPTZTilt.Position / 100;
         dZoom := tbrPTZZoom.Position / 100;
         VideoGrabber.ONVIFPTZSetPosition(dPan, dTilt, dZoom,
           FPTZSpeedRatio, False);
      end;
   end;
end;

procedure TfrmMainForm.tbrPTZPanChange(Sender: TObject);
begin
   DoPTZAbsolute();
end;

procedure TfrmMainForm.tbrPTZZoomChange(Sender: TObject);
begin
   DoPTZAbsolute();
end;

procedure TfrmMainForm.tbrPTZTiltChange(Sender: TObject);
begin
   DoPTZAbsolute();
end;

procedure TfrmMainForm.btnPTZSetTrackbarLimitsClick(Sender: TObject);
var
   dPan_Min, dPan_Max, dTilt_Min, dTilt_Max, dZoom_Min, dZoom_Max: Double;
   dPan, dTilt, dZoom: Double;
   UTCTime: int64;
   IsMoving: LongInt;
begin
   if VideoGrabber.ONVIFPTZGetLimits(dPan_Min, dPan_Max, dTilt_Min, dTilt_Max,
     dZoom_Min, dZoom_Max) then
   begin
      FUpdatingPTZTrackbars := true;
      tbrPTZPan.Min := trunc(dPan_Min * 100.0);
      tbrPTZPan.Max := trunc(dPan_Max * 100.0);
      tbrPTZTilt.Min := trunc(dTilt_Min * 100.0);
      tbrPTZTilt.Max := trunc(dTilt_Max * 100.0);
      tbrPTZZoom.Min := trunc(dZoom_Min * 100.0);
      tbrPTZZoom.Max := trunc(dZoom_Max * 100.0);
      tbrPTZSpeedRatio.Min := 0;
      tbrPTZSpeedRatio.Max := 100;
      tbrPTZSpeedRatio.Position := trunc(FPTZSpeedRatio * 100.0);

      if VideoGrabber.ONVIFPTZGetPosition(dPan, dTilt, dZoom, UTCTime, IsMoving)
      then
      begin
         tbrPTZPan.Position := trunc(dPan * 100.0);
         tbrPTZTilt.Position := trunc(dTilt * 100.0);
         tbrPTZZoom.Position := trunc(dZoom * 100.0);
      end;
      FUpdatingPTZTrackbars := False;
   end;
end;

procedure TfrmMainForm.edtPTZRelativeMoveChange(Sender: TObject);
begin
   FPTZRelativeMove := StrToFloatDef(edtPTZRelativeMove.Text, 0.01);

end;

procedure TfrmMainForm.btnRelativeTiltUpClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, FPTZRelativeMove, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativeTiltDownClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, -FPTZRelativeMove, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativePanLeftClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(FPTZRelativeMove, 0, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativePanRightClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(-FPTZRelativeMove, 0, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativeZoomOutClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, 0, -FPTZRelativeMove,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativeZoomInClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, 0, FPTZRelativeMove,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.mnuExitClick(Sender: TObject);
begin
   Close;
end;

procedure TfrmMainForm.btnNDIStreamingOKClick(Sender: TObject);
begin
   if chkStreamingVideoEnabled.Checked and chkStreamingAudioEnabled.Checked then
   begin
      VideoGrabber.NetworkStreamingType := nst_AudioVideoStreaming;
   end
   else if chkStreamingVideoEnabled.Checked then
   begin
      VideoGrabber.NetworkStreamingType := nst_VideoStreaming;
   end
   else if chkStreamingAudioEnabled.Checked then
   begin
      VideoGrabber.NetworkStreamingType := nst_AudioStreaming;
   end;
   VideoGrabber.NDIName := edtNDISessionName.Text;
   VideoGrabber.NetworkStreaming := ns_NDI;
   mmoLog.Lines.Add('NDI streaming enabled');
end;

procedure TfrmMainForm.btnViewNDIStreamingHelpClick(Sender: TObject);
begin
   ShowMessage
     ('This option open the NDI stream through the Datastead NDI filters.' +
     #13#10#13#10 +
     'Alternatively, if there is only one NDI source, it is possible to use the "NewTek NDI Video" virtual capture device in the "video capture devices" list.');
end;

procedure TfrmMainForm.btnNDISessionsClick(Sender: TObject);
var
   SessionList: string;
begin
   SessionList := VideoGrabber.GetNDISessions(False, False);
   mmoLog.Lines.Add('ndi sessions available:');
   mmoLog.Lines.Add(SessionList);
end;

procedure TfrmMainForm.btnNDIStreamingClientViewClick(Sender: TObject);
begin
   ChangeVideoSource (vs_VideoFileOrURL);
   VideoGrabber.VideoSource_FileOrUrl := edtNDIRemoteHostAndSession.Text;
   VideoGrabber.StartPreview();
end;

procedure TfrmMainForm.btnNDIClientHelpClick(Sender: TObject);
begin
   ShowMessage
     ('select "NewTek NDI Video" in the "video devices" list and click "Start Preview"');
end;

procedure TfrmMainForm.rdgPreferredVideoSizeClick(Sender: TObject);
begin
   case rdgPreferredVideoSize.ItemIndex of
      0:
         VideoGrabber.UseNearestVideoSize(0, 0,
           chkretchPreferredVideoSize.Checked);
         // disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
      1:
         VideoGrabber.UseNearestVideoSize(640, 360,
           chkretchPreferredVideoSize.Checked);
      2:
         VideoGrabber.UseNearestVideoSize(1280, 720,
           chkretchPreferredVideoSize.Checked);
      3:
         VideoGrabber.UseNearestVideoSize(1920, 1080,
           chkretchPreferredVideoSize.Checked);
      // or any other custom value
   end;
end;

procedure TfrmMainForm.chkretchPreferredVideoSizeClick(Sender: TObject);
begin
   rdgPreferredVideoSizeClick(Self);
end;

procedure TfrmMainForm.edtDatasteadEncoder_VideoCodecNameChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, Enc_Video_Codec,
     edtDatasteadEncoder_VideoCodecName.Text);
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_Bitrate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_BitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Video_Bitrate_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_rc_MinBitRate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_rc_MinBitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Video_rc_MinBitRate_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_rc_MaxBitRate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_rc_MaxBitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_rc_BufferSize_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_rc_BufferSize_kb,
     StrToIntDef(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_IDRIntervalChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_IDR_Interval,
     StrToIntDef(edtDatasteadEncoder_Video_IDRInterval.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_MaxBframesChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_Max_BFrames,
     StrToIntDef(edtDatasteadEncoder_Video_MaxBframes.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_ThreadCountChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_Thread_Count,
     StrToIntDef(edtDatasteadEncoder_Video_ThreadCount.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Audio_SamplesPerSecondChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Audio_SamplesPerSec,
     StrToIntDef(edtDatasteadEncoder_Audio_SamplesPerSecond.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_AudioCodecNameChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, Enc_Audio_Codec,
     edtDatasteadEncoder_AudioCodecName.Text);
end;

procedure TfrmMainForm.edtDatasteadEncoder_Audio_BitRate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Audio_BitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Audio_BitRate_kb.Text, 0));
end;

procedure TfrmMainForm.BtnCodecExamplesClick(Sender: TObject);
begin
   ShellExecute(0, 'open',
     'https://www.datastead.com/faq/how-can-the-tvideograbber-sdk-record-in-mp4-through-the-multipurpose-encoder/',
     nil, nil, SW_SHOW);
end;

procedure TfrmMainForm.mmoExtraParametersChange(Sender: TObject);
begin
   VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, Enc_Extra_Parameters,
     mmoExtraParameters.Lines.Text);
end;

procedure TfrmMainForm.cmbGPUEncoderChange(Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_GPU_Encoder,
     cmbGPUEncoder.ItemIndex);
end;

end.
