object Form1: TForm1
  Left = 339
  Top = 209
  Caption = 'Video from BMP or JPEG files'
  ClientHeight = 449
  ClientWidth = 731
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Position = poScreenCenter
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 8
    Width = 361
    Height = 13
    Caption = 
      'first of all, enter the folder in which where the BMP or JPEG fi' +
      'les are located: '
  end
  object Label2: TLabel
    Left = 228
    Top = 38
    Width = 149
    Height = 13
    Caption = 'frame rate during recording(fps:)'
  end
  object Label3: TLabel
    Left = 236
    Top = 62
    Width = 142
    Height = 13
    Caption = 'real frame rate of the clip (fps:)'
  end
  object Label4: TLabel
    Left = 216
    Top = 80
    Width = 279
    Height = 13
    Caption = '(it is possible to record faster than the normal playback rate)'
  end
  object VideoGrabber: TVideoGrabber
    Left = 264
    Top = 104
    Width = 433
    Height = 329
    Color = clBlack
    ASFMediaServerPublishingPoint = 'http://YourWindowsMediaServer/YourPublishingPoint'
    ASFVideoWidth = 320
    AspectRatioToUse = -1.000000000000000000
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    DroppedFramesPollingInterval = 10
    DualDisplay_Left = 400
    DualDisplay_Top = 10
    DVEncoder_VideoStandard = dvs_PAL
    Cropping_Zoom = 1.000000000000000000
    FrameGrabber = fg_PreviewStream
    ImageOverlayEnabled = False
    ImageOverlay_AlphaBlend = False
    ImageOverlay_AlphaBlendValue = 180
    ImageOverlay_ChromaKey = False
    ImageOverlay_ChromaKeyLeewayPercent = 25
    ImageOverlay_ChromaKeyRGBColor = 0
    ImageOverlay_Height = -1
    ImageOverlay_LeftLocation = 10
    ImageOverlay_VideoAlignment = oa_LeftTop
    ImageOverlay_StretchToVideoSize = False
    ImageOverlay_TopLocation = 10
    ImageOverlay_Transparent = False
    ImageOverlay_TransparentColorValue = 0
    ImageOverlay_UseTransparentColor = False
    ImageOverlay_Width = -1
    ImageOverlay_TargetDisplay = -1
    LicenseString = 'N/A'
    MotionDetector_Grid = 
      '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
      '5 5555555555 5555555555 5555555555 5555555555 '
    MultiplexedStabilizationDelay = 30
    NDIName = 'DATASTEAD_UNNAMED_SOURCE'
    PlayerSpeedRatio = 1.000000000000000000
    RecordingOnMotion_MotionThreshold = 0.001000000000000000
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -11
    TextOverlay_Font.Name = 'MS Sans Serif'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 7
    TextOverlay_HighResFont = True
    TextOverlay_Left = 0
    TextOverlay_Top = 0
    TextOverlay_Right = -1
    TextOverlay_Orientation = to_Horizontal
    TextOverlay_Scrolling = False
    TextOverlay_ScrollingSpeed = 1
    TextOverlay_Shadow = True
    TextOverlay_ShadowColor = clBlack
    TextOverlay_ShadowDirection = cd_SouthEast
    TextOverlay_BkColor = clWhite
    TextOverlay_Align = tf_Left
    TextOverlay_AlphaBlend = False
    TextOverlay_AlphaBlendValue = 180
    TextOverlay_GradientMode = gm_Disabled
    TextOverlay_GradientColor = clNavy
    TextOverlay_VideoAlignment = oa_LeftTop
    TextOverlay_String = 
      'Note: the date/time formats '#13#10'can be easily modified.'#13#10#13#10'system ' +
      'date/time: %sys_time[dd/mm/yy hh:nn:ss]%'#13#10'DV time code: %time_co' +
      'de%'#13#10'DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%'#13#10'frame count: %f' +
      'rame_count%'#13#10'time (full): %time_full%'#13#10'time (sec): %time_sec%'#13#10't' +
      'ime (ns): %time_100ns%'
    TextOverlay_TargetDisplay = -1
    TextOverlay_Transparent = True
    TVUseFrequencyOverrides = True
    VideoCompression_Quality = 1.000000000000000000
    VideoCompressor = 0
    VideoDelay = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.500000000000000000
    VideoSource_FileOrURL = 'http://www.datastead.com/demo/demo.wmv'
    StreamInterface_IsRealTime = True
    OnAVIDurationUpdated = VideoGrabberAVIDurationUpdated
    OnFrameProgress = VideoGrabberFrameProgress
    OnInactive = VideoGrabberInactive
    OnLog = VideoGrabberLog
    OnPlayerOpened = VideoGrabberPlayerOpened
    OnPreviewStarted = VideoGrabberPreviewStarted
    OnRecordingCompleted = VideoGrabberRecordingCompleted
    OnRecordingStarted = VideoGrabberRecordingStarted
    OnVideoFromBitmapsNextFrameNeeded = VideoGrabberVideoFromBitmapsNextFrameNeeded
  end
  object btnStartPreview: TButton
    Left = 448
    Top = 34
    Width = 80
    Height = 21
    Caption = 'start preview'
    TabOrder = 1
    OnClick = btnStartPreviewClick
  end
  object edtFilesLocation: TEdit
    Left = 448
    Top = 4
    Width = 257
    Height = 21
    TabOrder = 2
    Text = 'c:\MyBitmapsSourceDirectory'
  end
  object btnStartRecording: TButton
    Left = 536
    Top = 34
    Width = 80
    Height = 21
    Caption = 'start recording'
    TabOrder = 3
    OnClick = btnStartRecordingClick
  end
  object btnStop: TButton
    Left = 624
    Top = 34
    Width = 80
    Height = 21
    Caption = 'stop'
    TabOrder = 4
    OnClick = btnStopClick
  end
  object mmoLog: TMemo
    Left = 16
    Top = 112
    Width = 185
    Height = 329
    Color = clSilver
    TabOrder = 5
  end
  object btnPlay: TButton
    Left = 624
    Top = 58
    Width = 80
    Height = 21
    Caption = 'play'
    TabOrder = 6
    OnClick = btnPlayClick
  end
  object edtFrameProgress: TEdit
    Left = 16
    Top = 88
    Width = 185
    Height = 21
    Color = clSilver
    TabOrder = 7
  end
  object rdgSearchForBMPorJPEG: TRadioGroup
    Left = 16
    Top = 40
    Width = 185
    Height = 41
    Caption = 'search for:'
    Columns = 2
    ItemIndex = 0
    Items.Strings = (
      'BMP files'
      'JPEG files')
    TabOrder = 8
  end
  object edtRecordingFrameRate: TEdit
    Left = 384
    Top = 34
    Width = 33
    Height = 21
    TabOrder = 9
    Text = '50'
  end
  object edtFinalFrameRate: TEdit
    Left = 384
    Top = 58
    Width = 33
    Height = 21
    TabOrder = 10
    Text = '10'
  end
end
