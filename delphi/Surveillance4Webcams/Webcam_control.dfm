object FrmWebcam: TFrmWebcam
  Left = 214
  Top = 205
  BorderStyle = bsSingle
  BorderWidth = 1
  Caption = 'FrmWebcam'
  ClientHeight = 303
  ClientWidth = 416
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Visible = True
  OnShow = FormShow
  TextHeight = 13
  object Label2: TLabel
    Left = 262
    Top = 224
    Width = 79
    Height = 13
    Caption = 'motion sensitivity'
  end
  object Label1: TLabel
    Left = 262
    Top = 244
    Width = 89
    Height = 13
    Caption = 'detections/second'
  end
  object Label3: TLabel
    Left = 262
    Top = 258
    Width = 88
    Height = 13
    Caption = '0=video frame rate'
  end
  object shpMotionDetected: TShape
    Left = 347
    Top = 104
    Width = 15
    Height = 15
    Brush.Color = clScrollBar
    Shape = stCircle
  end
  object Label4: TLabel
    Left = 8
    Top = 22
    Width = 103
    Height = 13
    Caption = 'video capture device:'
  end
  object Label5: TLabel
    Left = 280
    Top = 20
    Width = 47
    Height = 13
    Caption = 'video size'
  end
  object Label6: TLabel
    Left = 168
    Top = 60
    Width = 52
    Height = 13
    Caption = 'video input'
  end
  object Label7: TLabel
    Left = 280
    Top = 60
    Width = 105
    Height = 13
    Caption = 'analog video standard'
  end
  object edtGlobalSensitivity: TEdit
    Left = 216
    Top = 224
    Width = 30
    Height = 21
    TabOrder = 4
    Text = '5'
  end
  object updGlobalSensitivity: TUpDown
    Left = 246
    Top = 224
    Width = 15
    Height = 21
    Associate = edtGlobalSensitivity
    Max = 9
    Position = 5
    TabOrder = 6
    OnClick = updGlobalSensitivityClick
  end
  object edtMaxDetectionsPerSecond: TEdit
    Left = 216
    Top = 248
    Width = 30
    Height = 21
    TabOrder = 8
    Text = '5'
  end
  object updMaxDetectionsPerSecond: TUpDown
    Left = 246
    Top = 248
    Width = 15
    Height = 21
    Associate = edtMaxDetectionsPerSecond
    Max = 30
    Position = 5
    TabOrder = 0
    OnClick = updMaxDetectionsPerSecondClick
  end
  object mmoMotionGrid: TMemo
    Left = 216
    Top = 104
    Width = 121
    Height = 115
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -9
    Font.Name = 'Courier New'
    Font.Style = []
    Lines.Strings = (
      'motion detection')
    ParentFont = False
    TabOrder = 1
    WordWrap = False
  end
  object cboVideoDevices: TComboBox
    Left = 8
    Top = 36
    Width = 265
    Height = 21
    TabOrder = 2
    Text = 'cboVideoDevices'
    OnChange = cboVideoDevicesChange
  end
  object cboVideoSize: TComboBox
    Left = 280
    Top = 34
    Width = 129
    Height = 21
    TabOrder = 3
    Text = 'cboVideoSize'
    OnChange = cboVideoSizeChange
  end
  object cboVideoInput: TComboBox
    Left = 168
    Top = 74
    Width = 105
    Height = 21
    TabOrder = 5
    Text = 'cboVideoInput'
    OnChange = cboVideoInputChange
  end
  object cboAnalogVideoStandard: TComboBox
    Left = 280
    Top = 74
    Width = 129
    Height = 21
    TabOrder = 7
    Text = 'cboAnalogVideoStandard'
    OnChange = cboAnalogVideoStandardChange
  end
  object VideoGrabber: TVideoGrabber
    Left = 8
    Top = 104
    Width = 201
    Height = 161
    Color = clBlack
    ASFMediaServerPublishingPoint = 'http://YourWindowsMediaServer/YourPublishingPoint'
    ASFVideoWidth = 320
    AspectRatioToUse = -1.000000000000000000
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    DroppedFramesPollingInterval = 1
    DualDisplay_Left = 400
    DualDisplay_Top = 10
    DVEncoder_VideoStandard = dvs_PAL
    Cropping_Zoom = 1.000000000000000000
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
    VideoCompression_Quality = 1.000000000000000000
    VideoCompressor = 0
    VideoDelay = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.500000000000000000
    VideoSource_FileOrURL = 'http://www.datastead.com/demo/demo.wmv'
    StreamInterface_IsRealTime = True
    OnLog = VideoGrabberLog
    OnMotionDetected = VideoGrabberMotionDetected
    OnMotionNotDetected = VideoGrabberMotionNotDetected
    OnVideoDeviceSelected = VideoGrabberVideoDeviceSelected
  end
  object StartPreview1: TButton
    Left = 12
    Top = 2
    Width = 53
    Height = 17
    Caption = 'preview'
    TabOrder = 10
    OnClick = StartPreview1Click
  end
  object StopPreview1: TButton
    Left = 66
    Top = 2
    Width = 45
    Height = 17
    Caption = '(stop)'
    TabOrder = 11
    OnClick = StopPreview1Click
  end
  object StartRecording1: TButton
    Left = 124
    Top = 2
    Width = 53
    Height = 17
    Caption = 'recording'
    TabOrder = 12
    OnClick = StartRecording1Click
  end
  object StopRecording1: TButton
    Left = 178
    Top = 2
    Width = 45
    Height = 17
    Caption = '(stop)'
    TabOrder = 13
    OnClick = StopRecording1Click
  end
  object StartPlayback1: TButton
    Left = 236
    Top = 2
    Width = 53
    Height = 17
    Caption = 'playback'
    TabOrder = 14
    OnClick = StartPlayback1Click
  end
  object StopPlayback2: TButton
    Left = 290
    Top = 2
    Width = 45
    Height = 17
    Caption = '(stop)'
    TabOrder = 15
    OnClick = StopPlayback2Click
  end
  object chkCaptureFrame: TCheckBox
    Left = 16
    Top = 76
    Width = 137
    Height = 17
    Caption = 'Capture frame on motion'
    TabOrder = 16
  end
end
