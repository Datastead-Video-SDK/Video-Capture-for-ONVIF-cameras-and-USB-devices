object frmMainForm: TfrmMainForm
  Left = 1241
  Top = 359
  Caption = '/'
  ClientHeight = 887
  ClientWidth = 1333
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  Position = poScreenCenter
  ShowHint = True
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  DesignSize = (
    1333
    887)
  TextHeight = 13
  object Label9: TLabel
    Left = 7
    Top = 332
    Width = 59
    Height = 13
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Caption = 'storage path'
  end
  object Label52: TLabel
    Left = 90
    Top = 4
    Width = 3
    Height = 13
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
  end
  object Label18: TLabel
    Left = 270
    Top = 339
    Width = 35
    Height = 13
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Caption = 'ZOOM:'
  end
  object Label105: TLabel
    Left = 245
    Top = 359
    Width = 71
    Height = 13
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Caption = 'zoom center X:'
  end
  object Label107: TLabel
    Left = 217
    Top = 342
    Width = 10
    Height = 13
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Caption = 'Y:'
  end
  object mmoLog: TMemo
    Left = 4
    Top = 424
    Width = 202
    Height = 456
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Anchors = [akLeft, akTop, akBottom]
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -12
    Font.Name = 'Arial'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    OnKeyUp = mmoLogKeyUp
    ExplicitHeight = 448
  end
  object edtStoragePath: TEdit
    Left = 4
    Top = 349
    Width = 202
    Height = 21
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    TabOrder = 1
    OnChange = edtStoragePathChange
  end
  object edtFrameCount: TEdit
    Left = 4
    Top = 374
    Width = 202
    Height = 21
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Color = clSilver
    ReadOnly = True
    TabOrder = 2
  end
  object grbPlayerControl: TGroupBox
    Left = 8
    Top = 261
    Width = 1316
    Height = 70
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Anchors = [akLeft, akTop, akRight]
    Caption = 'player control'
    TabOrder = 3
    ExplicitWidth = 1314
    DesignSize = (
      1316
      70)
    object btnPlayerBackwards: TSpeedButton
      Left = 15
      Top = 20
      Width = 34
      Height = 21
      Hint = 'play backwards'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F33333FF3337F3E0F33333033370E337F3333FF73337F3E0F333300333
        70E337F333FF773337F3E0F33300033370E337F333F7773337F3E0F330000333
        70E337F33377773337F3E0F33300033370E337F33337773337F3E0F333300333
        70E337F33333773337F3E0F33333033370E337F33333373337F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerBackwardsClick
    end
    object btnPlayerPause: TSpeedButton
      Left = 54
      Top = 20
      Width = 35
      Height = 21
      Hint = 'pause'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F33333333337F3E0F33333333370E337F333FF3FF337F3E0F330030033
        70E337F3377F77F337F3E0F33003003370E337F3377F77F337F3E0F330030033
        70E337F3377F77F337F3E0F33003003370E337F3377F77F337F3E0F330030033
        70E337F33773773337F3E0F33333333370E337F33333333337F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerPauseClick
    end
    object btnPlayerStop: TSpeedButton
      Left = 92
      Top = 20
      Width = 35
      Height = 21
      Hint = 'stop'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F33333333337F3E0F33333333370E337F333FFFFF337F3E0F330000033
        70E337F3377777F337F3E0F33000003370E337F3377777F337F3E0F330000033
        70E337F3377777F337F3E0F33000003370E337F3377777F337F3E0F330000033
        70E337F33777773337F3E0F33333333370E337F33333333337F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerStopClick
    end
    object btnPlayerStartPlaying: TSpeedButton
      Left = 132
      Top = 20
      Width = 34
      Height = 21
      Hint = 'play'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F3333F333337F3E0F33303333370E337F3337FF33337F3E0F333003333
        70E337F33377FF3337F3E0F33300033370E337F333777FF337F3E0F333000033
        70E337F33377773337F3E0F33300033370E337F33377733337F3E0F333003333
        70E337F33377333337F3E0F33303333370E337F33373333337F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerStartPlayingClick
    end
    object btnPlayerRewind: TSpeedButton
      Left = 209
      Top = 20
      Width = 35
      Height = 21
      Hint = 'rewinds'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F33333333337F3E0F33333333370E337F3333F3FF337F3E0F333030033
        70E337F3337F77F337F3E0F33003003370E337F3377F77F337F3E0F300030033
        70E337F3777F77F337F3E0F33003003370E337F3377F77F337F3E0F333030033
        70E337F33373773337F3E0F33333333370E337F33333333337F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerRewindClick
    end
    object btnPlayerFastForward: TSpeedButton
      Left = 249
      Top = 20
      Width = 34
      Height = 21
      Hint = 'fast forwards'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F33333333337F3E0F33333333370E337F333FF3F3337F3E0F330030333
        70E337F3377F7FF337F3E0F33003003370E337F3377F77FF37F3E0F330030003
        70E337F3377F777337F3E0F33003003370E337F3377F773337F3E0F330030333
        70E337F33773733337F3E0F33333333370E337F33333333337F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerFastForwardClick
    end
    object btnPlayerFrameStep: TSpeedButton
      Left = 171
      Top = 20
      Width = 35
      Height = 21
      Hint = 'move to next frame step-by-step (when the clip is paused)'
      Glyph.Data = {
        76010000424D7601000000000000760000002800000020000000100000000100
        0400000000000001000000000000000000001000000010000000000000000000
        800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
        FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
        33333333333333333333EEEEEEEEEEEEEEE333FFFFFFFFFFFFF3E00000000000
        00E337777777777777F3E0F77777777770E337F33333333337F3E0F333333333
        70E337F33333333737F3E0F33333330370E337F33333333737F3E0F303333303
        70E337F33733333737F3E0F30333330370E337F33733333737F3E00000033303
        70E337F77777333737F3E0F30333030370E337F33733373737F3E0F303333003
        70E337F33733337737F3E0F33333330370E337F33333333737F3E0F333333333
        70E337F33333333337F3E0FFFFFFFFFFF0E337FFFFFFFFFFF7F3E00000000000
        00E33777777777777733EEEEEEEEEEEEEEE33333333333333333}
      NumGlyphs = 2
      OnClick = btnPlayerFrameStepClick
    end
    object tbrPlayerProgress: TTrackBar
      Left = 289
      Top = 22
      Width = 1024
      Height = 32
      Anchors = [akLeft, akTop, akRight]
      Max = 1
      Min = 1
      PageSize = 1
      Position = 1
      TabOrder = 0
      ThumbLength = 15
      OnChange = tbrPlayerProgressChange
      ExplicitWidth = 1022
    end
    object chkPlayerTrackbarSynchrone: TCheckBox
      Left = 945
      Top = 46
      Width = 179
      Height = 21
      Hint = 
        'if enabled, the clip is moved while the mouse is moving the trac' +
        'kbar, if disabled it is moved only when the mouse is released'
      Caption = 'player trackbar synchrone'
      TabOrder = 1
      OnClick = chkPlayerTrackbarSynchroneClick
    end
  end
  object VideoGrabber: TVideoGrabber
    Left = 234
    Top = 398
    Width = 781
    Height = 430
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Color = clBlack
    OnResize = VideoGrabberResize
    AspectRatioToUse = -1.000000000000000000
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
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
      '5 5555555555 5555555555 5555555555 5555555555'
    NDIName = 'DATASTEAD_UNNAMED_SOURCE'
    PlayerSpeedRatio = 1.000000000000000000
    PlayerTrackBar = tbrPlayerProgress
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -20
    TextOverlay_Font.Name = 'Arial'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 12
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
      'de%'#13#10'DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%'#13#10'frame number: %' +
      'frame_count%'#13#10'time (full): %time_full%'#13#10'time (sec): %time_sec%'#13#10 +
      'time (ns): %time_100ns%'
    TextOverlay_TargetDisplay = -1
    TextOverlay_Transparent = True
    v360_AspectRatio = -1.000000000000000000
    VideoCompression_Quality = 1.000000000000000000
    VideoCompressor = 0
    VideoDelay = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.500000000000000000
    StreamInterface_Format = 'mpegts'
    StreamInterface_IsRealTime = True
    OnAudioDeviceSelected = VideoGrabberAudioDeviceSelected
    OnClientConnection = VideoGrabberClientConnection
    OnDeviceArrivalOrRemoval = VideoGrabberDeviceArrivalOrRemoval
    OnDeviceLost = VideoGrabberDeviceLost
    OnDiskFull = VideoGrabberDiskFull
    OnDVDiscontinuity = VideoGrabberDVDiscontinuity
    OnDVCommandCompleted = VideoGrabberDVCommandCompleted
    OnFrameBitmap = VideoGrabberFrameBitmap
    OnFrameCaptureCompleted = VideoGrabberFrameCaptureCompleted
    OnFrameProgress2 = VideoGrabberFrameProgress2
    OnGraphBuilt = VideoGrabberGraphBuilt
    OnInactive = VideoGrabberInactive
    OnLog = VideoGrabberLog
    OnMotionDetected = VideoGrabberMotionDetected
    OnMotionNotDetected = VideoGrabberMotionNotDetected
    OnMouseDown = VideoGrabberMouseDown
    OnMouseMove = VideoGrabberMouseMove
    OnMouseUp = VideoGrabberMouseUp
    OnMultipurposeEncoderProgress = VideoGrabberMultiPurposeEncoderProgress
    OnONVIFDiscoveryCompleted = VideoGrabberONVIFDiscoveryCompleted
    OnPlayerBufferingData = VideoGrabberPlayerBufferingData
    OnPlayerEndOfPlaylist = VideoGrabberPlayerEndOfPlaylist
    OnPlayerEndOfStream = VideoGrabberPlayerEndOfStream
    OnPlayerOpened = VideoGrabberPlayerOpened
    OnPreviewStarted = VideoGrabberPreviewStarted
    OnRecordingCompleted = VideoGrabberRecordingCompleted
    OnRecordingPaused = VideoGrabberRecordingPaused
    OnRecordingReadyToStart = VideoGrabberRecordingReadyToStart
    OnRecordingStarted = VideoGrabberRecordingStarted
    OnReencodingCompleted = VideoGrabberReencodingCompleted
    OnReencodingProgress = VideoGrabberReencodingProgress
    OnReencodingStarted = VideoGrabberReencodingStarted
    OnReinitializing = VideoGrabberReinitializing
    OnResizeVideo = VideoGrabberResizeVideo
    OnVideoDeviceSelected = VideoGrabberVideoDeviceSelected
    OnVideoFromBitmapsNextFrameNeeded = VideoGrabberVideoFromBitmapsNextFrameNeeded
  end
  object pctMain: TPageControl
    Left = 7
    Top = 0
    Width = 1318
    Height = 257
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    ActivePage = tbsVideoDevice
    Anchors = [akLeft, akTop, akRight]
    MultiLine = True
    TabOrder = 4
    ExplicitWidth = 1316
    object tbsVideoDevice: TTabSheet
      Caption = 'video source'
      ImageIndex = 2
      object Label28: TLabel
        Left = 598
        Top = 0
        Width = 542
        Height = 16
        Caption = 
          'to select programmatically an item by name in a list, use the Fi' +
          'ndIndexInListByName function'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clGray
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object grbVideoDeviceDialogs: TGroupBox
        Left = 985
        Top = 20
        Width = 139
        Height = 125
        Caption = 'video device dialogs'
        TabOrder = 0
        object btnDeviceDialog: TButton
          Left = 12
          Top = 25
          Width = 111
          Height = 23
          Caption = 'device'
          TabOrder = 0
          OnClick = btnDeviceDialogClick
        end
        object btnCameraControlDialog: TButton
          Left = 12
          Top = 54
          Width = 111
          Height = 23
          Caption = 'camera control'
          TabOrder = 1
          OnClick = btnCameraControlDialogClick
        end
        object btnVideoQualityDialog: TButton
          Left = 12
          Top = 83
          Width = 111
          Height = 23
          Caption = 'video quality'
          TabOrder = 2
          OnClick = btnVideoQualityDialogClick
        end
      end
      object grbVsVideoCaptureDevice: TGroupBox
        Left = 10
        Top = 52
        Width = 700
        Height = 93
        Hint = 
          'to select programmatically an item by its name in a list, use th' +
          'e FindIndexInListByName function'
        Caption = 'video source = video capture device'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 1
        object Label2: TLabel
          Left = 522
          Top = 7
          Width = 68
          Height = 16
          Caption = 'video input:'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Label19: TLabel
          Left = 522
          Top = 47
          Width = 135
          Height = 16
          Caption = 'analog video standard'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Label81: TLabel
          Left = 246
          Top = 47
          Width = 249
          Height = 16
          Caption = 'video format (size and subtype combined)'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Label104: TLabel
          Left = 49
          Top = 47
          Width = 156
          Height = 16
          Caption = 'video size / video subtype'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Label4: TLabel
          Left = 217
          Top = 59
          Width = 23
          Height = 16
          Caption = 'OR'
        end
        object cboVideoInputs: TComboBox
          Left = 522
          Top = 23
          Width = 139
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 0
          OnChange = cboVideoInputsChange
        end
        object cboAnalogVideoStandard: TComboBox
          Left = 522
          Top = 63
          Width = 168
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 1
          OnChange = cboAnalogVideoStandardChange
        end
        object cboVideoDevices: TComboBox
          Left = 10
          Top = 20
          Width = 474
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 2
          Text = 'SELECT FIRST A VIDEO CAPTURE DEVICE'
          OnChange = cboVideoDevicesChange
        end
        object cboVideoFormats: TComboBox
          Left = 246
          Top = 63
          Width = 248
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 3
          OnChange = cboVideoFormatsChange
        end
        object cboVideoSubtypes: TComboBox
          Left = 113
          Top = 63
          Width = 100
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 4
          OnChange = cboVideoSubtypesChange
        end
        object cboVideoSizes: TComboBox
          Left = 10
          Top = 63
          Width = 100
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 5
          OnChange = cboVideoSizesChange
        end
      end
      object btnAutoRefreshPreview: TCheckBox
        Left = 546
        Top = 17
        Width = 169
        Height = 21
        Caption = 'Auto refresh preview'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 2
        OnClick = btnAutoRefreshPreviewClick
      end
      object grbVsFileOrUrl: TGroupBox
        Left = 10
        Top = 145
        Width = 543
        Height = 77
        Caption = 'video source = file or URL'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 3
        object btnSelectFileOrUrl: TSpeedButton
          Left = 10
          Top = 17
          Width = 70
          Height = 26
          Caption = 'open'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          Glyph.Data = {
            76010000424D7601000000000000760000002800000020000000100000000100
            0400000000000001000000000000000000001000000010000000000000000000
            800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
            FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
            5555555555555555555555555555555555555555555555555555555555555555
            555555555555555555555555555555555555555FFFFFFFFFF555550000000000
            55555577777777775F55500B8B8B8B8B05555775F555555575F550F0B8B8B8B8
            B05557F75F555555575F50BF0B8B8B8B8B0557F575FFFFFFFF7F50FBF0000000
            000557F557777777777550BFBFBFBFB0555557F555555557F55550FBFBFBFBF0
            555557F555555FF7555550BFBFBF00055555575F555577755555550BFBF05555
            55555575FFF75555555555700007555555555557777555555555555555555555
            5555555555555555555555555555555555555555555555555555}
          NumGlyphs = 2
          ParentFont = False
          OnClick = btnSelectFileOrUrlClick
        end
        object Label100: TLabel
          Left = 441
          Top = 21
          Width = 29
          Height = 16
          Caption = 'user:'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Label101: TLabel
          Left = 411
          Top = 50
          Width = 62
          Height = 16
          Caption = 'password:'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object edtVideoSourceFileOrUrl: TEdit
          Left = 89
          Top = 17
          Width = 336
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 0
          Text = 
            'rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mp4' +
            '>buffer=100'
          OnChange = edtVideoSourceFileOrUrlChange
        end
        object VideoSourceFileOrUrl_UserName: TEdit
          Left = 473
          Top = 16
          Width = 60
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 1
          OnChange = VideoSourceFileOrUrl_UserNameChange
        end
        object VideoSourceFileOrUrl_Password: TEdit
          Left = 473
          Top = 46
          Width = 60
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 2
          OnChange = VideoSourceFileOrUrl_PasswordChange
        end
      end
      object grbVideoSource: TGroupBox
        Left = 10
        Top = 0
        Width = 204
        Height = 53
        Caption = 'VIDEO SOURCE'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 4
        object cboVideoSource: TComboBox
          Left = 10
          Top = 20
          Width = 188
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 0
          OnChange = cboVideoSourceChange
        end
      end
      object grbPreview: TGroupBox
        Left = 219
        Top = 0
        Width = 219
        Height = 53
        Caption = 'Preview'
        TabOrder = 5
        object btnStartPreview: TBitBtn
          Left = 7
          Top = 20
          Width = 50
          Height = 23
          Caption = 'start'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clRed
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 0
          OnClick = btnStartPreviewClick
        end
        object btnStopPreview: TButton
          Left = 162
          Top = 20
          Width = 50
          Height = 23
          Caption = 'stop'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 1
          OnClick = btnStopPreviewClick
        end
        object btnPausePreview: TButton
          Left = 59
          Top = 20
          Width = 49
          Height = 23
          Caption = 'pause'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 2
          OnClick = btnPausePreviewClick
        end
        object btnResumePreview: TButton
          Left = 111
          Top = 20
          Width = 49
          Height = 23
          Caption = 'resume'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 3
          OnClick = btnResumePreviewClick
        end
      end
      object grbFrameRate: TGroupBox
        Left = 443
        Top = 0
        Width = 100
        Height = 53
        Caption = 'Frame rate'
        TabOrder = 6
        object edtFrameRate: TEdit
          Left = 5
          Top = 20
          Width = 41
          Height = 21
          TabOrder = 0
          Text = '0'
        end
        object btnFrameRate: TButton
          Left = 50
          Top = 20
          Width = 20
          Height = 26
          Caption = 'ok'
          TabOrder = 1
          OnClick = btnFrameRateClick
        end
        object btnAboutFrameRate: TButton
          Left = 75
          Top = 20
          Width = 17
          Height = 26
          Caption = '?'
          TabOrder = 2
          OnClick = btnAboutFrameRateClick
        end
      end
      object chkEnableSnapshotButton: TCheckBox
        Left = 546
        Top = 37
        Width = 175
        Height = 21
        Caption = 'webcam snapshot button'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clBlue
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 7
        OnClick = chkEnableSnapshotButtonClick
      end
      object grbVsScreenRecording: TGroupBox
        Left = 561
        Top = 145
        Width = 415
        Height = 77
        Caption = 'video source = screen recording'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 8
        object Label35: TLabel
          Left = 118
          Top = 27
          Width = 292
          Height = 16
          Caption = 'use this window: (or an empty string for full screen)'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Label90: TLabel
          Left = 10
          Top = 27
          Width = 95
          Height = 16
          Caption = 'monitor number:'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object edtScreenRecordingWindow: TEdit
          Left = 118
          Top = 44
          Width = 267
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 0
          Text = 'TVideoGrabber demo'
        end
        object btnScreenRecordingWindow: TButton
          Left = 384
          Top = 44
          Width = 22
          Height = 26
          Caption = 'ok'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 1
          OnClick = btnScreenRecordingWindowClick
        end
        object edtMonitorNumber: TEdit
          Left = 10
          Top = 44
          Width = 40
          Height = 24
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 2
          Text = '0'
          OnChange = edtMonitorNumberChange
        end
        object btnMonitorNumberInfo: TButton
          Left = 54
          Top = 44
          Width = 51
          Height = 26
          Caption = 'info?'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 3
          OnClick = btnMonitorNumberInfoClick
        end
        object chkScreenRecordingWithCursor: TCheckBox
          Left = 271
          Top = 7
          Width = 99
          Height = 24
          Caption = 'with cursor'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 4
          OnClick = chkScreenRecordingWithCursorClick
        end
      end
      object rdgPreferredVideoSize: TRadioGroup
        Left = 754
        Top = 20
        Width = 223
        Height = 125
        Caption = 'preferred video sizes (examples)'
        ItemIndex = 0
        Items.Strings = (
          'source size (default)'
          '640x360'
          '1280x720'
          '1920x1080')
        TabOrder = 9
        OnClick = rdgPreferredVideoSizeClick
      end
      object chkretchPreferredVideoSize: TCheckBox
        Left = 898
        Top = 114
        Width = 63
        Height = 21
        Alignment = taLeftJustify
        Caption = 'stretch'
        TabOrder = 10
        OnClick = chkretchPreferredVideoSizeClick
      end
    end
    object tbsIPCameras: TTabSheet
      Caption = 'IP cameras'
      ImageIndex = 12
      OnShow = tbsIPCamerasShow
      object lblChooseIPCamera: TLabel
        Left = 182
        Top = 4
        Width = 181
        Height = 16
        Caption = '(VideoSource = vs_IPCamera)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clRed
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object Label91: TLabel
        Left = 3
        Top = 52
        Width = 30
        Height = 13
        Caption = 'URL:'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object Label92: TLabel
        Left = 513
        Top = 93
        Width = 89
        Height = 13
        Caption = 'conn. timeout  (ms)'
      end
      object Label98: TLabel
        Left = 19
        Top = 138
        Width = 286
        Height = 16
        Caption = '(other recording settings in the "Recording" tab)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -14
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsItalic]
        ParentFont = False
      end
      object Label94: TLabel
        Left = 313
        Top = 98
        Width = 20
        Height = 13
        Caption = 'user'
      end
      object Label95: TLabel
        Left = 405
        Top = 98
        Width = 45
        Height = 13
        Caption = 'password'
      end
      object Label67: TLabel
        Left = 599
        Top = 76
        Width = 17
        Height = 13
        Caption = 'sec'
      end
      object Label68: TLabel
        Left = 738
        Top = 26
        Width = 48
        Height = 13
        Caption = 'IP Range:'
      end
      object Label69: TLabel
        Left = 876
        Top = 26
        Width = 12
        Height = 13
        Caption = 'to:'
      end
      object Label70: TLabel
        Left = 580
        Top = 26
        Width = 108
        Height = 13
        Caption = 'discovery timeout (sec)'
      end
      object edtIPCameraURL: TEdit
        Left = 39
        Top = 48
        Width = 563
        Height = 21
        TabOrder = 0
        Text = 
          'onvifurl://... onvif://...  rtsp://...  http://....  rtmp://... ' +
          '  udp://...   rtp://...   mms://...'
        OnChange = edtIPCameraURLChange
      end
      object btnIPCamStartPreview: TButton
        Left = 3
        Top = 77
        Width = 100
        Height = 21
        Caption = 'Start preview'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 1
        OnClick = btnIPCamStartPreviewClick
      end
      object edtIPCamConnectionTimeout: TEdit
        Left = 513
        Top = 109
        Width = 88
        Height = 21
        TabOrder = 2
        Text = '10000'
        OnChange = edtIPCamConnectionTimeoutChange
      end
      object chkOpenURLAsync: TCheckBox
        Left = 3
        Top = 3
        Width = 182
        Height = 21
        Caption = 'open asynchronously'
        Checked = True
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        State = cbChecked
        TabOrder = 3
        OnClick = chkOpenURLAsyncClick
      end
      object btnIPCameraStop: TButton
        Left = 114
        Top = 77
        Width = 50
        Height = 21
        Caption = 'Stop'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 4
        OnClick = btnIPCameraStopClick
      end
      object btnIPCameraStarttMP4Recording: TButton
        Left = 170
        Top = 77
        Width = 150
        Height = 21
        Caption = 'Start MP4 recording'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 5
        OnClick = btnIPCameraStarttMP4RecordingClick
      end
      object RichEdit1: TRichEdit
        Left = 3
        Top = 160
        Width = 613
        Height = 72
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -12
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        Lines.Strings = (
          
            'First download and install the Datastead RTSP/RTMP/HTTP/ONVIF Di' +
            'rectShow Source filter from '
          'www.datastead.com'
          
            'The filter supports configuration parameters at the end of the U' +
            'RL prefixed by a ">" or "!" character:'
          
            'low delay: ">lowdelay=1" |  no buffer: ">buffer=0"  |  no latenc' +
            'y: ">vidsync=0"'
          'e.g.: rtsp://192.168.5.25/live.sdp>lowdelay=1>buffer=0>vidsync=0'
          'Complete list of extra parameters at the end of this document:'
          
            'https://www.datastead.com/_releases/rtspdssrc/Datastead_RTSP-RTM' +
            'P-HTTP-'
          'ONVIF_DirectShow_Source_Filter_Manual.pdf')
        ParentFont = False
        ReadOnly = True
        ScrollBars = ssVertical
        TabOrder = 6
      end
      object edtBacktimedRecordingSeconds: TEdit
        Left = 568
        Top = 72
        Width = 34
        Height = 21
        TabOrder = 7
        Text = '5'
      end
      object chkBacktimedRecordingSeconds: TCheckBox
        Left = 328
        Top = 77
        Width = 234
        Height = 17
        Caption = 'backtimed recording (pre-roll):'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -14
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 8
      end
      object edtIPCamUserName: TEdit
        Left = 311
        Top = 111
        Width = 88
        Height = 21
        TabOrder = 9
        OnChange = edtIPCamUserNameChange
      end
      object edtIPCamPassword: TEdit
        Left = 403
        Top = 111
        Width = 88
        Height = 21
        TabOrder = 10
        OnChange = edtIPCamPasswordChange
      end
      object chkUseExternalAudioforRTSP: TCheckBox
        Left = 3
        Top = 25
        Width = 524
        Height = 21
        Caption = 
          'audio: instead of the camera audio, use the audio device listed ' +
          'in the "Audio Devices" list'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 11
        OnClick = chkUseExternalAudioforRTSPClick
      end
      object rdgIRCutFilter: TRadioGroup
        Left = 1144
        Top = 0
        Width = 177
        Height = 41
        Caption = ' IR Cut filter of Axis cameras '
        Columns = 3
        Items.Strings = (
          'auto'
          'enabled'
          'disabled')
        TabOrder = 12
        OnClick = rdgIRCutFilterClick
      end
      object GroupBox9: TGroupBox
        Left = 980
        Top = 41
        Width = 329
        Height = 185
        Caption = 'ONVIF PTZ'
        TabOrder = 13
        object Label114: TLabel
          Left = 226
          Top = 45
          Width = 55
          Height = 13
          Caption = 'speed ratio:'
        end
        object PageControl1: TPageControl
          Left = 8
          Top = 18
          Width = 209
          Height = 159
          ActivePage = TabSheet2
          TabOrder = 0
          object TabSheet2: TTabSheet
            Caption = 'Continuous'
            object Label108: TLabel
              Left = 0
              Top = 6
              Width = 36
              Height = 13
              Caption = 'pan/tilt:'
            end
            object Label109: TLabel
              Left = 120
              Top = 6
              Width = 28
              Height = 13
              Caption = 'zoom:'
            end
            object Label99: TLabel
              Left = 0
              Top = 69
              Width = 92
              Height = 13
              Caption = 'move duration (ms):'
            end
            object Label110: TLabel
              Left = 0
              Top = 91
              Width = 146
              Height = 13
              Caption = '(duration 0 = continuous move)'
            end
            object btnPTZTiltUp: TButton
              Left = 51
              Top = 4
              Width = 21
              Height = 21
              Caption = '^'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 0
              OnMouseDown = btnPTZTiltUpMouseDown
              OnMouseUp = PTZButtonsMouseUp
            end
            object btnPTZPanLeft: TButton
              Left = 28
              Top = 26
              Width = 21
              Height = 21
              Caption = '<'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 1
              OnMouseDown = btnPTZPanLeftMouseDown
              OnMouseUp = PTZButtonsMouseUp
            end
            object btnPTZPanRight: TButton
              Left = 74
              Top = 26
              Width = 21
              Height = 21
              Caption = '>'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 2
              OnMouseDown = btnPTZPanRightMouseDown
              OnMouseUp = PTZButtonsMouseUp
            end
            object btnPTZTiltDown: TButton
              Left = 51
              Top = 46
              Width = 21
              Height = 21
              Caption = 'v'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 3
              OnMouseDown = btnPTZTiltDownMouseDown
              OnMouseUp = PTZButtonsMouseUp
            end
            object btnPTZZoomOut: TButton
              Left = 122
              Top = 26
              Width = 21
              Height = 21
              Caption = '<'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 4
              OnMouseDown = btnPTZZoomOutMouseDown
              OnMouseUp = PTZButtonsMouseUp
            end
            object btnPTZZoomIn: TButton
              Left = 142
              Top = 26
              Width = 21
              Height = 21
              Caption = '>'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 5
              OnClick = btnPTZZoomInClick
              OnMouseUp = PTZButtonsMouseUp
            end
            object edtPTZDurationMs: TEdit
              Left = 98
              Top = 64
              Width = 41
              Height = 21
              TabOrder = 6
              Text = '0'
              OnChange = edtPTZDurationMsChange
            end
            object btnPTZHelpDuration: TButton
              Left = 146
              Top = 63
              Width = 25
              Height = 25
              Caption = '?'
              TabOrder = 7
              OnClick = btnPTZHelpDurationClick
            end
            object chkPTZMouseUpStop: TCheckBox
              Left = 0
              Top = 110
              Width = 249
              Height = 17
              Caption = 'if duration 0, mouse button up -> stop'
              Checked = True
              State = cbChecked
              TabOrder = 8
            end
          end
          object TabSheet3: TTabSheet
            Caption = 'Absolute'
            ImageIndex = 1
            object Label111: TLabel
              Left = 2
              Top = 38
              Width = 21
              Height = 13
              Caption = 'pan:'
            end
            object Label112: TLabel
              Left = 2
              Top = 82
              Width = 28
              Height = 13
              Caption = 'zoom:'
            end
            object Label113: TLabel
              Left = 122
              Top = 38
              Width = 13
              Height = 13
              Caption = 'tilt:'
            end
            object btnPTZSetTrackbarLimits: TButton
              Left = 0
              Top = 12
              Width = 129
              Height = 20
              Caption = 'retrieve camera position'
              TabOrder = 0
              OnClick = btnPTZSetTrackbarLimitsClick
            end
            object tbrPTZPan: TTrackBar
              Left = -4
              Top = 54
              Width = 133
              Height = 24
              Max = 100
              Min = -100
              TabOrder = 1
              ThumbLength = 16
              OnChange = tbrPTZPanChange
            end
            object tbrPTZZoom: TTrackBar
              Left = -4
              Top = 98
              Width = 133
              Height = 24
              Max = 50
              TabOrder = 2
              ThumbLength = 16
              OnChange = tbrPTZZoomChange
            end
            object tbrPTZTilt: TTrackBar
              Left = 128
              Top = 23
              Width = 24
              Height = 105
              Max = 100
              Min = -100
              Orientation = trVertical
              TabOrder = 3
              ThumbLength = 16
              OnChange = tbrPTZTiltChange
            end
          end
          object TabSheet4: TTabSheet
            Caption = 'Relative'
            ImageIndex = 2
            object Label115: TLabel
              Left = 0
              Top = 75
              Width = 66
              Height = 13
              Caption = 'relative move:'
            end
            object Label117: TLabel
              Left = 8
              Top = 3
              Width = 36
              Height = 13
              Caption = 'pan/tilt:'
            end
            object Label118: TLabel
              Left = 128
              Top = 3
              Width = 28
              Height = 13
              Caption = 'zoom:'
            end
            object edtPTZRelativeMove: TEdit
              Left = 96
              Top = 73
              Width = 57
              Height = 21
              TabOrder = 0
              Text = '0,01'
              OnChange = edtPTZRelativeMoveChange
            end
            object btnRelativePanLeft: TButton
              Left = 36
              Top = 23
              Width = 21
              Height = 21
              Caption = '<'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 1
              OnClick = btnRelativePanLeftClick
            end
            object btnRelativeTiltUp: TButton
              Left = 59
              Top = 1
              Width = 21
              Height = 21
              Caption = '^'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 2
              OnClick = btnRelativeTiltUpClick
            end
            object btnRelativePanRight: TButton
              Left = 82
              Top = 23
              Width = 21
              Height = 21
              Caption = '>'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 3
              OnClick = btnRelativePanRightClick
            end
            object btnRelativeTiltDown: TButton
              Left = 59
              Top = 43
              Width = 21
              Height = 21
              Caption = 'v'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 4
              OnClick = btnRelativeTiltDownClick
            end
            object btnRelativeZoomOut: TButton
              Left = 130
              Top = 23
              Width = 21
              Height = 21
              Caption = '<'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 5
              OnClick = btnRelativeZoomOutClick
            end
            object btnRelativeZoomIn: TButton
              Left = 152
              Top = 23
              Width = 21
              Height = 21
              Caption = '>'
              Font.Charset = DEFAULT_CHARSET
              Font.Color = clWindowText
              Font.Height = -15
              Font.Name = 'MS Sans Serif'
              Font.Style = [fsBold]
              ParentFont = False
              TabOrder = 6
              OnClick = btnRelativeZoomInClick
            end
          end
        end
        object PTZStop: TButton
          Left = 232
          Top = 105
          Width = 89
          Height = 69
          Caption = 'STOP'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -14
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 1
          OnClick = PTZStopClick
        end
        object tbrPTZSpeedRatio: TTrackBar
          Left = 224
          Top = 65
          Width = 105
          Height = 24
          Max = 100
          Position = 50
          TabOrder = 2
          ThumbLength = 16
          OnChange = tbrPTZSpeedRatioChange
        end
        object btnHelpPTZSpeedRatio: TButton
          Left = 287
          Top = 34
          Width = 25
          Height = 25
          Caption = '?'
          TabOrder = 3
          OnClick = btnHelpPTZSpeedRatioClick
        end
      end
      object btnONVIFReplayRecordingsList: TButton
        Left = 980
        Top = 3
        Width = 158
        Height = 33
        Caption = 'replay recordings (onvif://... url)'
        TabOrder = 14
        OnClick = btnONVIFReplayRecordingsListClick
      end
      object btnIPCamStartPTZ: TButton
        Left = 3
        Top = 107
        Width = 302
        Height = 25
        Caption = 'Start PTZ control only (onvifurl://...)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 15
        OnClick = btnIPCamStartPTZClick
      end
      object btnDiscoverONVIFFromMulticast: TButton
        Left = 369
        Top = -1
        Width = 233
        Height = 21
        Caption = 'discover ONVIF cameras (multicast)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clBlue
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 16
        OnClick = btnDiscoverONVIFFromMulticastClick
      end
      object edtOnvifDiscoveryIPRange_FirstIP: TEdit
        Left = 790
        Top = 23
        Width = 78
        Height = 21
        TabOrder = 17
        Text = '192.168.1.1'
      end
      object edtOnvifDiscoveryIPRange_LastIP: TEdit
        Left = 896
        Top = 23
        Width = 78
        Height = 21
        TabOrder = 18
        Text = '192.168.1.60'
      end
      object lsbOnvifURLsDiscovered: TListBox
        Left = 632
        Top = 50
        Width = 345
        Height = 177
        ItemHeight = 13
        TabOrder = 19
        OnClick = lsbOnvifURLsDiscoveredClick
      end
      object btnDiscoverONVIFFromIPRange: TButton
        Left = 608
        Top = -1
        Width = 233
        Height = 21
        Caption = 'discover ONVIF cameras (IP range)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clBlue
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 20
        OnClick = btnDiscoverONVIFFromIPRangeClick
      end
      object edtDiscoveryTimeoutSeconds: TEdit
        Left = 696
        Top = 23
        Width = 30
        Height = 21
        TabOrder = 21
        Text = '2'
      end
      object btnCancelDiscovery: TButton
        Left = 847
        Top = -1
        Width = 127
        Height = 21
        Caption = 'cancel discovery'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clBlue
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 22
        OnClick = btnCancelDiscoveryClick
      end
    end
    object tbsAudio: TTabSheet
      Caption = 'audio'
      ImageIndex = 10
      object grbAudioRendering: TGroupBox
        Left = 817
        Top = 59
        Width = 307
        Height = 159
        Caption = 'audio renderer'
        TabOrder = 0
        object Label1: TLabel
          Left = 12
          Top = 57
          Width = 34
          Height = 13
          Caption = 'volume'
        end
        object Label17: TLabel
          Left = 12
          Top = 103
          Width = 38
          Height = 13
          Caption = 'balance'
        end
        object tbrAudioVolume: TTrackBar
          Left = 2
          Top = 71
          Width = 304
          Height = 31
          Max = 65535
          Frequency = 400
          TabOrder = 0
          ThumbLength = 15
          OnChange = tbrAudioVolumeChange
        end
        object tbrAudioBalance: TTrackBar
          Left = 2
          Top = 118
          Width = 295
          Height = 31
          Max = 32767
          Min = -32768
          Frequency = 800
          TabOrder = 1
          ThumbLength = 15
          OnChange = tbrAudioBalanceChange
        end
        object chkMuteAudioRendering: TCheckBox
          Left = 10
          Top = 27
          Width = 60
          Height = 21
          Caption = 'mute'
          TabOrder = 2
          OnClick = chkMuteAudioRenderingClick
        end
        object cboAudioRenderers: TComboBox
          Left = 69
          Top = 25
          Width = 234
          Height = 21
          TabOrder = 3
          Text = 'default (AudioRenderer property = -1)'
          OnChange = cboAudioRenderersChange
        end
      end
      object rdgVUMeters: TRadioGroup
        Left = 414
        Top = 59
        Width = 247
        Height = 41
        Caption = 'VU Meters'
        Columns = 3
        Items.Strings = (
          'disabled'
          'analog'
          'bargraph')
        TabOrder = 1
        OnClick = rdgVUMetersClick
      end
      object pnLeftVUMeter: TPanel
        Left = 414
        Top = 108
        Width = 158
        Height = 110
        Caption = 'Left VU Meter'
        TabOrder = 2
      end
      object pnRightVUMeter: TPanel
        Left = 581
        Top = 108
        Width = 149
        Height = 110
        Caption = 'Right VU Meter'
        TabOrder = 3
      end
      object GroupBox2: TGroupBox
        Left = 414
        Top = 0
        Width = 710
        Height = 60
        Caption = 
          'AUDIO rendering / recording /streaming ONLY   (you can activate ' +
          'the streaming in the "network streaming" tab)'
        TabOrder = 4
        object btnStartAudioRendering: TButton
          Left = 10
          Top = 25
          Width = 100
          Height = 23
          Caption = 'start rendering'
          TabOrder = 0
          OnClick = btnStartAudioRenderingClick
        end
        object btnStartWAVRecording: TButton
          Left = 118
          Top = 25
          Width = 90
          Height = 23
          Caption = 'record WAV'
          TabOrder = 1
          OnClick = btnStartWAVRecordingClick
        end
        object btnStartMP3Recording: TButton
          Left = 217
          Top = 25
          Width = 89
          Height = 23
          Caption = 'record MP3'
          TabOrder = 2
          OnClick = btnStartMP3RecordingClick
        end
        object btnStopAudio: TButton
          Left = 423
          Top = 25
          Width = 80
          Height = 23
          Caption = 'stop'
          TabOrder = 3
          OnClick = btnStopAudioClick
        end
        object btnStartASFRecording: TButton
          Left = 315
          Top = 25
          Width = 100
          Height = 23
          Caption = 'record to ASF'
          TabOrder = 4
          OnClick = btnStartASFRecordingClick
        end
      end
      object chkRenderAudioDevice: TCheckBox
        Left = 14
        Top = 3
        Width = 237
        Height = 21
        Caption = 'AUDIO DEVICE RENDERING'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 5
        OnClick = chkRenderAudioDeviceClick
      end
      object btnBargraphOverlay: TButton
        Left = 670
        Top = 69
        Width = 139
        Height = 31
        Caption = 'bargraph overlay'
        TabOrder = 6
        OnClick = btnBargraphOverlayClick
      end
      object grbAudioCaptureDevice: TGroupBox
        Left = 12
        Top = 27
        Width = 396
        Height = 112
        Caption = 'Audio capture device (if default selected above)'
        TabOrder = 7
        object Label26: TLabel
          Left = 10
          Top = 50
          Width = 55
          Height = 13
          Caption = 'audio input:'
        end
        object Label49: TLabel
          Left = 194
          Top = 52
          Width = 48
          Height = 13
          Caption = 'input level'
        end
        object Label36: TLabel
          Left = 175
          Top = 82
          Width = 64
          Height = 13
          Caption = 'input balance'
        end
        object cboAudioDevices: TComboBox
          Left = 89
          Top = 20
          Width = 296
          Height = 21
          TabOrder = 0
          Text = 'SELECT AN AUDIO CAPTURE DEVICE'
          OnChange = cboAudioDevicesChange
        end
        object cboAudioInputs: TComboBox
          Left = 10
          Top = 73
          Width = 149
          Height = 21
          TabOrder = 1
          OnChange = cboAudioInputsChange
        end
        object tbrAudioInputLevel: TTrackBar
          Left = 264
          Top = 50
          Width = 124
          Height = 31
          Max = 65535
          Frequency = 900
          Position = 50000
          TabOrder = 2
          ThumbLength = 15
          OnChange = tbrAudioInputLevelChange
        end
        object tbrAudioInputBalance: TTrackBar
          Left = 264
          Top = 79
          Width = 124
          Height = 31
          Max = 32767
          Min = -32768
          Frequency = 900
          TabOrder = 3
          ThumbLength = 15
          OnChange = tbrAudioInputBalanceChange
        end
      end
    end
    object tbsRecording: TTabSheet
      Caption = 'recording'
      ImageIndex = 5
      object Label6: TLabel
        Left = 916
        Top = 6
        Width = 126
        Height = 16
        Caption = 'video compressor'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object Label16: TLabel
        Left = 918
        Top = 70
        Width = 126
        Height = 16
        Caption = 'audio compressor'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object Label24: TLabel
        Left = 344
        Top = 175
        Width = 111
        Height = 13
        Caption = '(auto file name if empty)'
      end
      object Label65: TLabel
        Left = 10
        Top = 200
        Width = 121
        Height = 13
        Caption = 'auto file names based on:'
      end
      object Label66: TLabel
        Left = 0
        Top = 213
        Width = 126
        Height = 13
        Caption = '(also for the frame grabber)'
      end
      object Label46: TLabel
        Left = 296
        Top = 202
        Width = 97
        Height = 13
        Caption = 'auto file name prefix:'
      end
      object btnRenewRecordingFile: TButton
        Left = 3
        Top = 172
        Width = 142
        Height = 23
        Caption = 'new file while recording:'
        TabOrder = 0
        OnClick = btnRenewRecordingFileClick
      end
      object btnStopRecording: TButton
        Left = 299
        Top = 5
        Width = 140
        Height = 23
        Caption = 'stop'
        TabOrder = 1
        OnClick = btnStopRecordingClick
      end
      object btnStartRecordingControlled: TBitBtn
        Left = 153
        Top = 5
        Width = 140
        Height = 23
        Caption = 'start (controlled)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clRed
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 2
        OnClick = btnStartRecordingControlledClick
      end
      object btnStartRecordingImmediately: TBitBtn
        Left = 7
        Top = 4
        Width = 140
        Height = 23
        Caption = 'start (immediately)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clRed
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 3
        OnClick = btnStartRecordingImmediatelyClick
      end
      object chkAudioRecording: TCheckBox
        Left = 7
        Top = 64
        Width = 138
        Height = 21
        Caption = 'audio recording'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 4
        OnClick = chkAudioRecordingClick
      end
      object chkPreserveNativeFormat: TCheckBox
        Left = 7
        Top = 34
        Width = 247
        Height = 21
        Caption = 'RECORD IN NATIVE FORMAT'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clBlack
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 5
        OnClick = chkPreserveNativeFormatClick
      end
      object chkAVISaveToThisFile: TCheckBox
        Left = 3
        Top = 145
        Width = 317
        Height = 21
        Hint = 
          'if disabled, a file name is generated automatically, according t' +
          'o the "AutoFileName" property (shown in the "frame grabber" tab)'
        Caption = 'do not generate file names automatically, save to:'
        TabOrder = 6
        OnClick = chkAVISaveToThisFileClick
      end
      object edtRecordingFileName: TEdit
        Left = 266
        Top = 145
        Width = 230
        Height = 21
        TabOrder = 7
        Text = 'VideoClip.avi'
        OnChange = edtRecordingFileNameChange
      end
      object rdgRecordingMethod: TRadioGroup
        Left = 502
        Top = 69
        Width = 257
        Height = 156
        Caption = 'recording method'
        Columns = 2
        Items.Strings = (
          'AVI'
          'ASF (wmv)'
          'send to DV'
          'MKV'
          'FLV'
          'MP4'
          'WebM (vp8)'
          'MPG'
          'Multiplexer (other)'
          'MOV'
          'TS')
        TabOrder = 8
        OnClick = rdgRecordingMethodClick
      end
      object GroupBox5: TGroupBox
        Left = 256
        Top = 34
        Width = 238
        Height = 96
        Caption = 'Recording timer'
        TabOrder = 9
        object Label29: TLabel
          Left = 10
          Top = 69
          Width = 114
          Height = 13
          Caption = 'timer interval (seconds) :'
        end
        object grbRecordingTimer: TRadioGroup
          Left = 0
          Top = 0
          Width = 238
          Height = 60
          Caption = 'Recording Timer'
          Columns = 2
          ItemIndex = 0
          Items.Strings = (
            'disabled'
            'new file every...'
            'stop after ...'
            'start after ...')
          TabOrder = 0
          OnClick = grbRecordingTimerClick
        end
        object edtRecordingTimerInterval: TEdit
          Left = 167
          Top = 64
          Width = 61
          Height = 21
          TabOrder = 1
          Text = '20'
          OnChange = edtRecordingTimerIntervalChange
        end
      end
      object chkRecordingCanPause: TCheckBox
        Left = 507
        Top = 7
        Width = 166
        Height = 21
        Caption = 'recording can pause'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 10
        OnClick = chkRecordingCanPauseClick
      end
      object chkRecordingPauseCreatesNewFile: TCheckBox
        Left = 507
        Top = 27
        Width = 159
        Height = 21
        Caption = 'pause creates new file'
        TabOrder = 11
        OnClick = chkRecordingPauseCreatesNewFileClick
      end
      object chkRecordingOnMotion: TCheckBox
        Left = 507
        Top = 44
        Width = 228
        Height = 26
        Caption = 'pause/resume on motion detection'
        TabOrder = 12
        OnClick = chkRecordingOnMotionClick
      end
      object btnPauseRecording: TButton
        Left = 684
        Top = 0
        Width = 56
        Height = 21
        Caption = 'pause'
        TabOrder = 13
        OnClick = btnPauseRecordingClick
      end
      object btnResumeRecording: TButton
        Left = 684
        Top = 22
        Width = 56
        Height = 21
        Caption = 'resume'
        TabOrder = 14
        OnClick = btnResumeRecordingClick
      end
      object cboVideoCompressors: TComboBox
        Left = 916
        Top = 23
        Width = 234
        Height = 21
        TabOrder = 15
        OnChange = cboVideoCompressorsChange
      end
      object btnVideoCompressorSettings: TButton
        Left = 916
        Top = 47
        Width = 79
        Height = 21
        Caption = 'Settings'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 16
        OnClick = btnVideoCompressorSettingsClick
      end
      object cboAudioCompressors: TComboBox
        Left = 916
        Top = 87
        Width = 234
        Height = 21
        TabOrder = 17
        OnChange = cboAudioCompressorsChange
      end
      object btnAudioCompressorSettings: TButton
        Left = 918
        Top = 114
        Width = 78
        Height = 21
        Caption = 'Settings'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 18
        OnClick = btnAudioCompressorSettingsClick
      end
      object rdgCompressMode: TRadioGroup
        Left = 766
        Top = 22
        Width = 119
        Height = 74
        Caption = 'compression mode'
        ItemIndex = 0
        Items.Strings = (
          'no'
          'on the fly'
          'after capture')
        TabOrder = 19
        OnClick = rdgCompressModeClick
      end
      object BtnCodecExamples: TButton
        Left = 770
        Top = 180
        Width = 444
        Height = 27
        Caption = 
          'About the Datastead Encoder settings (Multipurpose Encoder requi' +
          'red)'
        TabOrder = 20
        OnClick = BtnCodecExamplesClick
      end
      object edtNewFileDuringRecording: TEdit
        Left = 151
        Top = 172
        Width = 187
        Height = 21
        TabOrder = 21
      end
      object cboAutoFileName: TComboBox
        Left = 200
        Top = 200
        Width = 87
        Height = 21
        TabOrder = 22
        Text = 'guid'
        Items.Strings = (
          'sequential'
          'date/time'
          'counter'
          'modulo'
          'guid')
      end
      object edtAVIAutoFilePrefix: TEdit
        Left = 424
        Top = 200
        Width = 66
        Height = 21
        TabOrder = 23
        OnChange = edtAVIAutoFilePrefixChange
      end
    end
    object tbsMPE: TTabSheet
      Caption = 'Multipurpose Encoder'
      ImageIndex = 12
      object PageControl2: TPageControl
        Left = 0
        Top = 0
        Width = 1310
        Height = 229
        ActivePage = TabSheet7
        Align = alClient
        TabOrder = 0
        object tbsDatasteadEncoder: TTabSheet
          Caption = 'Datastead Encoder'
          object Label140: TLabel
            Left = 880
            Top = 8
            Width = 3
            Height = 13
          end
          object Label11: TLabel
            Left = 1064
            Top = 123
            Width = 82
            Height = 13
            Caption = 'Extra parameters:'
          end
          object video: TGroupBox
            Left = 336
            Top = 0
            Width = 561
            Height = 193
            Caption = 'Video:'
            TabOrder = 0
            object Label128: TLabel
              Left = 152
              Top = 16
              Width = 302
              Height = 13
              Caption = 'Codec name, e.g. "h264", "hevc", "mpeg4" or empty for default'
            end
            object Label129: TLabel
              Left = 440
              Top = 28
              Width = 3
              Height = 13
            end
            object Label130: TLabel
              Left = 152
              Top = 46
              Width = 65
              Height = 13
              Caption = 'Bit rate (kbps)'
            end
            object Label134: TLabel
              Left = 152
              Top = 76
              Width = 128
              Height = 13
              Caption = 'IDR Interval (GOP), e.g. 30'
            end
            object Label135: TLabel
              Left = 152
              Top = 106
              Width = 125
              Height = 13
              Caption = 'Max B-frames, 0 by default'
            end
            object Label137: TLabel
              Left = 152
              Top = 136
              Width = 231
              Height = 13
              Caption = 'Thread count, 1 by default (4 by default for h264)'
            end
            object Label136: TLabel
              Left = 152
              Top = 166
              Width = 161
              Height = 13
              Caption = 'GPU H/W accel (none by default)'
            end
            object edtDatasteadEncoder_VideoCodecName: TEdit
              Left = 56
              Top = 12
              Width = 89
              Height = 21
              TabOrder = 0
              OnChange = edtDatasteadEncoder_VideoCodecNameChange
            end
            object edtDatasteadEncoder_Video_Bitrate_kb: TEdit
              Left = 56
              Top = 42
              Width = 89
              Height = 21
              TabOrder = 1
              OnChange = edtDatasteadEncoder_Video_Bitrate_kbChange
            end
            object GroupBox10: TGroupBox
              Left = 400
              Top = 55
              Width = 145
              Height = 117
              Caption = 'rate control (kbps):'
              TabOrder = 2
              object Label131: TLabel
                Left = 68
                Top = 24
                Width = 51
                Height = 13
                Caption = 'min bit rate'
              end
              object Label132: TLabel
                Left = 68
                Top = 56
                Width = 54
                Height = 13
                Caption = 'max bit rate'
              end
              object Label133: TLabel
                Left = 68
                Top = 88
                Width = 48
                Height = 13
                Caption = 'buffer size'
              end
              object edtDatasteadEncoder_Video_rc_MinBitRate_kb: TEdit
                Left = 4
                Top = 21
                Width = 60
                Height = 21
                TabOrder = 0
                OnChange = edtDatasteadEncoder_Video_rc_MinBitRate_kbChange
              end
              object edtDatasteadEncoder_Video_rc_MaxBitRate_kb: TEdit
                Left = 4
                Top = 53
                Width = 60
                Height = 21
                TabOrder = 1
                OnChange = edtDatasteadEncoder_Video_rc_MaxBitRate_kbChange
              end
              object edtDatasteadEncoder_Video_rc_BufferSize_kb: TEdit
                Left = 4
                Top = 85
                Width = 60
                Height = 21
                TabOrder = 2
                OnChange = edtDatasteadEncoder_Video_rc_BufferSize_kbChange
              end
            end
            object edtDatasteadEncoder_Video_IDRInterval: TEdit
              Left = 56
              Top = 72
              Width = 89
              Height = 21
              TabOrder = 3
              OnChange = edtDatasteadEncoder_Video_IDRIntervalChange
            end
            object edtDatasteadEncoder_Video_MaxBframes: TEdit
              Left = 56
              Top = 102
              Width = 89
              Height = 21
              TabOrder = 4
              OnChange = edtDatasteadEncoder_Video_MaxBframesChange
            end
            object edtDatasteadEncoder_Video_ThreadCount: TEdit
              Left = 56
              Top = 132
              Width = 89
              Height = 21
              TabOrder = 5
              OnChange = edtDatasteadEncoder_Video_ThreadCountChange
            end
            object cmbGPUEncoder: TComboBox
              Left = 56
              Top = 162
              Width = 90
              Height = 21
              TabOrder = 6
              OnChange = cmbGPUEncoderChange
              Items.Strings = (
                'None'
                'Auto'
                'Intel_QSV'
                'NVidia_NVENC'
                'AMD_AMF')
            end
          end
          object GroupBox12: TGroupBox
            Left = 912
            Top = 0
            Width = 401
            Height = 114
            Caption = 'Audio:'
            TabOrder = 1
            object Label138: TLabel
              Left = 111
              Top = 84
              Width = 125
              Height = 13
              Caption = 'Bit rate (kbps) e.g. 64, 128'
            end
            object Label139: TLabel
              Left = 111
              Top = 48
              Width = 160
              Height = 13
              Caption = 'samples per sec (44100, 22050...)'
            end
            object Label38: TLabel
              Left = 74
              Top = 32
              Width = 3
              Height = 13
            end
            object Label32: TLabel
              Left = 111
              Top = 16
              Width = 211
              Height = 13
              Caption = 'Codec name, e.g. "aac", or empty for default'
            end
            object edtDatasteadEncoder_Audio_SamplesPerSecond: TEdit
              Left = 16
              Top = 50
              Width = 89
              Height = 21
              TabOrder = 0
              OnChange = edtDatasteadEncoder_Audio_SamplesPerSecondChange
            end
            object edtDatasteadEncoder_Audio_BitRate_kb: TEdit
              Left = 16
              Top = 80
              Width = 89
              Height = 21
              TabOrder = 1
              OnChange = edtDatasteadEncoder_Audio_BitRate_kbChange
            end
            object edtDatasteadEncoder_AudioCodecName: TEdit
              Left = 16
              Top = 12
              Width = 89
              Height = 21
              TabOrder = 2
              OnChange = edtDatasteadEncoder_AudioCodecNameChange
            end
          end
          object Memo2: TMemo
            Left = 8
            Top = 2
            Width = 321
            Height = 191
            Color = clBtnFace
            Font.Charset = DEFAULT_CHARSET
            Font.Color = clWindowText
            Font.Height = -13
            Font.Name = 'MS Sans Serif'
            Font.Style = []
            Lines.Strings = (
              'To use this mode, in the "recording" tab, select:'
              ''
              '- "Datastead Multipurpose Encoder" as compressor'
              '- CompressionMode = cm_CompressOnTheFly'
              ''
              'The format (e.g. mp4, avi, flv, etc...) is determined by '
              'the extension of the RecordingFileName, or by the '
              'RecordingMethod property if RecordingFileName is '
              'empty')
            ParentFont = False
            ReadOnly = True
            TabOrder = 2
          end
          object mmoExtraParameters: TMemo
            Left = 1064
            Top = 141
            Width = 241
            Height = 57
            TabOrder = 3
            OnChange = mmoExtraParametersChange
          end
        end
        object TabSheet7: TTabSheet
          Caption = 'Command line encoder'
          ImageIndex = 1
          object pgcMPE: TPageControl
            Left = 0
            Top = 0
            Width = 1302
            Height = 201
            ActivePage = tbsMPEReencodingLog
            Align = alClient
            TabOrder = 0
            object tshMPESettings: TTabSheet
              Caption = 'Settings'
              object GroupBox1: TGroupBox
                Left = 4
                Top = 54
                Width = 1123
                Height = 55
                Caption = 
                  'STREAMING: enable it then start the preview in the "video source' +
                  '" tab or recording in the "Recording" tab        (note: it super' +
                  'sedes ALL the streaming settings of the "WM Streaming" tab)'
                TabOrder = 0
                object chkMPEStreaming: TCheckBox
                  Left = 4
                  Top = 21
                  Width = 80
                  Height = 21
                  Caption = 'enable'
                  TabOrder = 0
                  OnClick = chkMPEStreamingClick
                end
                object edtMPEStreaming: TEdit
                  Left = 69
                  Top = 23
                  Width = 1051
                  Height = 21
                  TabOrder = 1
                  Text = 
                    'ffmpegLGPL.exe -i %PIPE% -pix_fmt yuv420p -threads 8 -c:v h264 -' +
                    'b:v 2M -an -force_key_frames "expr:gte(t,n_forced*0.5)" -vf setp' +
                    'ts=(RTCTIME-RTCSTART)/(TB*1000000) -acodec aac -ab 128k -ac 2 -f' +
                    ' mpegts udp://239.255.0.1:10124'
                  OnChange = edtMPEStreamingChange
                end
              end
              object grbMPErecord: TGroupBox
                Left = 4
                Top = 0
                Width = 1123
                Height = 48
                Caption = 
                  'RECORDING: enable it then start the recording in the "Recording"' +
                  ' tab         (note: it supersedes ALL the compression and codec ' +
                  'settings of the "Recording" tab)'
                TabOrder = 1
                object chkMPERecording: TCheckBox
                  Left = 4
                  Top = 26
                  Width = 80
                  Height = 21
                  Caption = 'enable'
                  TabOrder = 0
                  OnClick = chkMPERecordingClick
                end
                object edtMPERecording: TEdit
                  Left = 69
                  Top = 23
                  Width = 1051
                  Height = 21
                  TabOrder = 1
                  Text = 
                    'ffmpegLGPL.exe -i %PIPE% -pix_fmt yuv420p -threads 8 -c:v h264 -' +
                    'b:v 2M -an -force_key_frames "expr:gte(t,n_forced*0.5)" -vf setp' +
                    'ts=(RTCTIME-RTCSTART)/(TB*1000000) -acodec aac -ab 128k -ac 2 -f' +
                    ' mp4 %FILENAME%'
                  OnChange = edtMPERecordingChange
                end
              end
              object GroupBox6: TGroupBox
                Left = 4
                Top = 108
                Width = 1123
                Height = 55
                Caption = 
                  'Direct transcoding: replace these sample file names by the real ' +
                  'files to process, specify more FFmpeg settings if needed, then c' +
                  'lick "Start MPE reencoding"'
                TabOrder = 2
                object edtMPEReencoding: TEdit
                  Left = 4
                  Top = 22
                  Width = 883
                  Height = 21
                  TabOrder = 0
                  Text = 
                    'ffmpegLGPL.exe -i "c:\folder\ClipToReencode.avi" -f mp4 "c:\fold' +
                    'er\ClipReencodedToMP4.mp4"'
                  OnChange = edtMPEReencodingChange
                end
                object btnStartMPEReencoding: TButton
                  Left = 895
                  Top = 21
                  Width = 139
                  Height = 31
                  Caption = 'start MPE reencoding'
                  TabOrder = 1
                  OnClick = btnStartMPEReencodingClick
                end
                object btnStopMPEReencoding: TButton
                  Left = 1041
                  Top = 21
                  Width = 70
                  Height = 31
                  Caption = 'stop'
                  TabOrder = 2
                  OnClick = btnStopMPEReencodingClick
                end
              end
            end
            object tbsMPERecordingLog: TTabSheet
              Caption = 'Recording log'
              ImageIndex = 1
              object lblMPERecordingProgressInfo: TLabel
                Left = 0
                Top = 158
                Width = 66
                Height = 13
                Caption = 'progress info: '
              end
              object mmoMPERecordingLog: TMemo
                Left = 8
                Top = 0
                Width = 1129
                Height = 139
                Lines.Strings = (
                  
                    'The log and progress info is available only if SHOWCONSOLE has n' +
                    'ot been specified'
                  '')
                TabOrder = 0
              end
            end
            object tbsMPEStreamingLog: TTabSheet
              Caption = 'Streaming log'
              ImageIndex = 2
              object lblMPEStreamingProgressInfo: TLabel
                Left = 0
                Top = 158
                Width = 66
                Height = 13
                Caption = 'progress info: '
              end
              object mmoMPEStreamingLog: TMemo
                Left = 0
                Top = 0
                Width = 1129
                Height = 149
                Lines.Strings = (
                  
                    'The log and progress info is available only if SHOWCONSOLE has n' +
                    'ot been specified'
                  '')
                TabOrder = 0
              end
            end
            object tbsMPEReencodingLog: TTabSheet
              Caption = 'Reencoding Log'
              ImageIndex = 3
              object lblMPEReencodingProgressInfo: TLabel
                Left = 0
                Top = 158
                Width = 66
                Height = 13
                Caption = 'progress info: '
              end
              object mmoMPEReencodingLog: TMemo
                Left = 0
                Top = 0
                Width = 1129
                Height = 149
                Lines.Strings = (
                  
                    'The log and progress info is available only if SHOWCONSOLE has n' +
                    'ot been specified')
                TabOrder = 0
              end
            end
          end
        end
      end
    end
    object TabSheet5: TTabSheet
      Caption = 'streaming'
      ImageIndex = 13
      object Label120: TLabel
        Left = 943
        Top = 5
        Width = 271
        Height = 16
        Caption = 'NDI (requires the Datastead NDI filters)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -14
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object Label10: TLabel
        Left = 315
        Top = 3
        Width = 316
        Height = 13
        Caption = 'Encoder (requires the Datastead Multipurpose Encoder)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object chkStreamingVideoEnabled: TCheckBox
        Left = 12
        Top = 13
        Width = 121
        Height = 25
        Caption = 'video enabled'
        Checked = True
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -14
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        State = cbChecked
        TabOrder = 0
      end
      object chkStreamingAudioEnabled: TCheckBox
        Left = 12
        Top = 37
        Width = 121
        Height = 25
        Caption = 'audio enabled'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -14
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 1
      end
      object GroupBox3: TGroupBox
        Left = 211
        Top = 18
        Width = 585
        Height = 208
        Caption = 'Examples'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 2
        object Label5: TLabel
          Left = 123
          Top = 120
          Width = 364
          Height = 13
          Caption = 'FOR MORE EXAMPLES PLEASE CONTACT US at support@datastead.com'
        end
        object btnMultipurposeUDPStreaming: TButton
          Left = 20
          Top = 24
          Width = 558
          Height = 25
          Caption = 'UDP streaming 2Mb/s, destination : udp://@239.255.0.1:10124'
          TabOrder = 0
          OnClick = btnMultipurposeUDPStreamingClick
        end
        object btnPauseStreaming: TButton
          Left = 120
          Top = 55
          Width = 97
          Height = 25
          Caption = 'pause streaming'
          TabOrder = 1
          OnClick = btnPauseStreamingClick
        end
        object btnResumeStreaming: TButton
          Left = 223
          Top = 55
          Width = 97
          Height = 25
          Caption = 'resume streaming'
          TabOrder = 2
          OnClick = btnResumeStreamingClick
        end
      end
      object GroupBox7: TGroupBox
        Left = 813
        Top = 111
        Width = 487
        Height = 115
        Caption = 
          'client side: play a NDI source (if already sending, run 2nd Main' +
          'Demo.exe)'
        TabOrder = 3
        object Label34: TLabel
          Left = 16
          Top = 62
          Width = 84
          Height = 13
          Caption = 'ndi session name:'
        end
        object Label39: TLabel
          Left = 11
          Top = 85
          Width = 197
          Height = 13
          Caption = 'e.g.:   ndi://DESKTOP-FIH4B (MyStream)'
        end
        object Label44: TLabel
          Left = 184
          Top = 26
          Width = 94
          Height = 13
          Caption = 'receive timeout (ms)'
        end
        object btnNDIStreamingClientView: TButton
          Left = 425
          Top = 56
          Width = 57
          Height = 25
          Caption = 'View'
          TabOrder = 0
          OnClick = btnNDIStreamingClientViewClick
        end
        object edtNDIRemoteHostAndSession: TEdit
          Left = 118
          Top = 58
          Width = 301
          Height = 21
          TabOrder = 1
          Text = 'ndi://'
        end
        object btnNDISessions: TButton
          Left = 16
          Top = 23
          Width = 145
          Height = 25
          Caption = 'List NDI sessions available'
          TabOrder = 2
          OnClick = btnNDISessionsClick
        end
        object edtNDIReceiveTimeout: TEdit
          Left = 284
          Top = 24
          Width = 89
          Height = 21
          TabOrder = 3
          OnChange = edtNDIReceiveTimeoutChange
        end
      end
      object GroupBox11: TGroupBox
        Left = 813
        Top = 34
        Width = 356
        Height = 71
        Caption = 'server side (send the TVideoGrabber output to the network): '
        TabOrder = 4
        object Label125: TLabel
          Left = 11
          Top = 22
          Width = 67
          Height = 13
          Caption = 'session name:'
        end
        object Label127: TLabel
          Left = 11
          Top = 48
          Width = 190
          Height = 13
          Caption = '(then, start e.g. the preview or playback)'
        end
        object edtNDISessionName: TEdit
          Left = 104
          Top = 21
          Width = 113
          Height = 21
          TabOrder = 0
          Text = 'MyStream'
        end
        object btnNDIStreamingOK: TButton
          Left = 223
          Top = 19
          Width = 74
          Height = 25
          Caption = 'configure'
          TabOrder = 1
          OnClick = btnNDIStreamingOKClick
        end
      end
    end
    object tbsPlayer: TTabSheet
      Caption = 'player'
      ImageIndex = 1
      object btnOpenLastClipRecorded: TSpeedButton
        Left = 261
        Top = 54
        Width = 129
        Height = 24
        Caption = 'Last clip recorded'
        NumGlyphs = 2
        OnClick = btnOpenLastClipRecordedClick
      end
      object btnPlayerOpenFile: TSpeedButton
        Left = 10
        Top = 22
        Width = 119
        Height = 26
        Caption = 'Choose a clip'
        Glyph.Data = {
          76010000424D7601000000000000760000002800000020000000100000000100
          0400000000000001000000000000000000001000000010000000000000000000
          800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
          5555555555555555555555555555555555555555555555555555555555555555
          555555555555555555555555555555555555555FFFFFFFFFF555550000000000
          55555577777777775F55500B8B8B8B8B05555775F555555575F550F0B8B8B8B8
          B05557F75F555555575F50BF0B8B8B8B8B0557F575FFFFFFFF7F50FBF0000000
          000557F557777777777550BFBFBFBFB0555557F555555557F55550FBFBFBFBF0
          555557F555555FF7555550BFBFBF00055555575F555577755555550BFBF05555
          55555575FFF75555555555700007555555555557777555555555555555555555
          5555555555555555555555555555555555555555555555555555}
        NumGlyphs = 2
        OnClick = btnPlayerOpenFileClick
      end
      object Label23: TLabel
        Left = 66
        Top = 175
        Width = 97
        Height = 13
        Caption = 'ff/rewind speed ratio'
      end
      object Label8: TLabel
        Left = 64
        Top = 142
        Width = 86
        Height = 13
        Caption = 'normal speed ratio'
      end
      object Label40: TLabel
        Left = 0
        Top = 0
        Width = 115
        Height = 16
        Caption = 'Player functions.'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object Label41: TLabel
        Left = 374
        Top = 2
        Width = 751
        Height = 16
        Caption = 
          'to use only the player and disable the live video functions, set' +
          ' VideoDevice = -1 and AudioDevice = -1 from the Object Inspector' +
          '.'
        Color = clBtnFace
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clGray
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentColor = False
        ParentFont = False
      end
      object btnPlayerOpenStreamingURL: TSpeedButton
        Left = 10
        Top = 54
        Width = 100
        Height = 24
        Caption = 'demo URL ?'
        NumGlyphs = 2
      end
      object btnOpenLastClipPlayed: TSpeedButton
        Left = 116
        Top = 54
        Width = 139
        Height = 24
        Caption = 'Open last clip played'
        NumGlyphs = 2
        OnClick = btnOpenLastClipPlayedClick
      end
      object Label77: TLabel
        Left = 319
        Top = 111
        Width = 33
        Height = 13
        Caption = 'start (*)'
      end
      object Label80: TLabel
        Left = 403
        Top = 111
        Width = 105
        Height = 13
        Caption = 'stop (*)    (* default: -1)'
      end
      object Label89: TLabel
        Left = 207
        Top = 183
        Width = 373
        Height = 16
        Caption = '(times are expressed in 100ns units, e.g. 3 seconds = 30000000)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clGray
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object edtPlayerFastSeekSpeed: TEdit
        Left = 7
        Top = 170
        Width = 37
        Height = 21
        Color = clSilver
        ReadOnly = True
        TabOrder = 0
        Text = '1'
      end
      object edtPlayerSpeedRatio: TEdit
        Left = 7
        Top = 137
        Width = 53
        Height = 21
        TabOrder = 1
        Text = '1'
        OnChange = edtPlayerSpeedRatioChange
      end
      object updPlayerFastSeekSpeed: TUpDown
        Left = 44
        Top = 170
        Width = 16
        Height = 26
        Min = 1
        Position = 1
        TabOrder = 2
        OnClick = updPlayerFastSeekSpeedClick
      end
      object btnAutoPlay: TCheckBox
        Left = 172
        Top = 84
        Width = 130
        Height = 21
        Caption = 'auto start playing'
        TabOrder = 3
        OnClick = btnAutoPlayClick
      end
      object edtPlayerClip: TEdit
        Left = 138
        Top = 22
        Width = 375
        Height = 21
        TabOrder = 4
        Text = 'Choose a clip...'
      end
      object chkPlayerAudioRendering: TCheckBox
        Left = 5
        Top = 84
        Width = 164
        Height = 21
        Caption = 'render player audio'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 5
        OnClick = chkPlayerAudioRenderingClick
      end
      object chkRefreshPausedDisplay: TCheckBox
        Left = 5
        Top = 202
        Width = 626
        Height = 21
        Caption = 
          'refresh periodically paused display when the frame grabber is en' +
          'abled (e.g. to apply graphic overlays)'
        TabOrder = 6
        OnClick = chkRefreshPausedDisplayClick
      end
      object btnOpenClip: TButton
        Left = 519
        Top = 22
        Width = 73
        Height = 26
        Caption = 'Open'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 7
        OnClick = btnOpenClipClick
      end
      object btnPlayerCloseClip: TButton
        Left = 599
        Top = 22
        Width = 62
        Height = 26
        Caption = 'Close'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 8
        OnClick = btnPlayerCloseClipClick
      end
      object btnGetClipDuration: TButton
        Left = 591
        Top = 54
        Width = 72
        Height = 24
        Caption = 'duration?'
        TabOrder = 9
        OnClick = btnGetClipDurationClick
      end
      object btnGeneralInfo: TButton
        Left = 396
        Top = 54
        Width = 93
        Height = 24
        Caption = 'general info?'
        TabOrder = 10
        OnClick = btnGeneralInfoClick
      end
      object btnHeaderInfo: TButton
        Left = 495
        Top = 54
        Width = 91
        Height = 24
        Caption = 'header info?'
        TabOrder = 11
        OnClick = btnHeaderInfoClick
      end
      object chkUseClock: TCheckBox
        Left = 172
        Top = 103
        Width = 85
        Height = 21
        Caption = 'use clock'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 12
        OnClick = chkUseClockClick
      end
      object grbPlayList: TGroupBox
        Left = 758
        Top = 25
        Width = 454
        Height = 195
        Caption = 'Playlist'
        TabOrder = 13
        object btnAddToPlaylist: TSpeedButton
          Left = 10
          Top = 21
          Width = 70
          Height = 23
          Caption = 'Add'
          Glyph.Data = {
            76010000424D7601000000000000760000002800000020000000100000000100
            0400000000000001000000000000000000001000000010000000000000000000
            800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
            FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
            5555555555555555555555555555555555555555555555555555555555555555
            555555555555555555555555555555555555555FFFFFFFFFF555550000000000
            55555577777777775F55500B8B8B8B8B05555775F555555575F550F0B8B8B8B8
            B05557F75F555555575F50BF0B8B8B8B8B0557F575FFFFFFFF7F50FBF0000000
            000557F557777777777550BFBFBFBFB0555557F555555557F55550FBFBFBFBF0
            555557F555555FF7555550BFBFBF00055555575F555577755555550BFBF05555
            55555575FFF75555555555700007555555555557777555555555555555555555
            5555555555555555555555555555555555555555555555555555}
          NumGlyphs = 2
          OnClick = btnAddToPlaylistClick
        end
        object chkPlaylistLoop: TCheckBox
          Left = 10
          Top = 59
          Width = 60
          Height = 21
          Caption = 'Loop'
          TabOrder = 0
          OnClick = chkPlaylistLoopClick
        end
        object btnPlaylistPlay: TButton
          Left = 84
          Top = 21
          Width = 53
          Height = 23
          Caption = 'Play'
          TabOrder = 1
          OnClick = btnPlaylistPlayClick
        end
        object btnPlaylistNext: TButton
          Left = 142
          Top = 21
          Width = 49
          Height = 23
          Caption = 'Next'
          TabOrder = 2
          OnClick = btnPlaylistNextClick
        end
        object btnPlaylistPrevious: TButton
          Left = 196
          Top = 21
          Width = 69
          Height = 23
          Caption = 'Previous'
          TabOrder = 3
          OnClick = btnPlaylistPreviousClick
        end
        object chkPlaylistRandom: TCheckBox
          Left = 10
          Top = 89
          Width = 80
          Height = 21
          Caption = 'Random'
          TabOrder = 4
          OnClick = chkPlaylistRandomClick
        end
        object btnPlaylistStop: TButton
          Left = 268
          Top = 21
          Width = 120
          Height = 23
          Caption = 'Stop after current'
          TabOrder = 5
          OnClick = btnPlaylistStopClick
        end
        object lstPlaylist: TListBox
          Left = 89
          Top = 49
          Width = 355
          Height = 139
          ItemHeight = 13
          TabOrder = 6
          OnClick = lstPlaylistClick
        end
        object btnClosePlaylist: TButton
          Left = 393
          Top = 21
          Width = 51
          Height = 23
          Caption = 'Close'
          TabOrder = 7
          OnClick = btnClosePlaylistClick
        end
      end
      object btnOpenAtFrames: TButton
        Left = 191
        Top = 128
        Width = 119
        Height = 26
        Caption = 'Open at frames ->'
        TabOrder = 14
        OnClick = btnOpenAtFramesClick
      end
      object btnOpenAtTimes: TButton
        Left = 191
        Top = 158
        Width = 119
        Height = 25
        Caption = 'Open at times ->'
        TabOrder = 15
        OnClick = btnOpenAtTimesClick
      end
      object edtartFrame: TEdit
        Left = 319
        Top = 128
        Width = 74
        Height = 21
        TabOrder = 16
      end
      object edtopFrame: TEdit
        Left = 403
        Top = 128
        Width = 74
        Height = 21
        TabOrder = 17
      end
      object edtartTime: TEdit
        Left = 319
        Top = 158
        Width = 74
        Height = 21
        TabOrder = 18
      end
      object edtopTime: TEdit
        Left = 403
        Top = 158
        Width = 74
        Height = 21
        TabOrder = 19
      end
      object chkKeepBounds: TCheckBox
        Left = 486
        Top = 138
        Width = 99
        Height = 21
        Caption = 'keep bounds'
        Checked = True
        State = cbChecked
        TabOrder = 20
      end
      object chkReopen: TCheckBox
        Left = 486
        Top = 160
        Width = 126
        Height = 21
        Caption = 'reopen if opened'
        TabOrder = 21
      end
      object chkPlayerLoop: TCheckBox
        Left = 5
        Top = 108
        Width = 164
        Height = 21
        Caption = 'loop (repeat indefinitely)'
        TabOrder = 22
        OnClick = chkPlayerLoopClick
      end
      object rgdHwAccel: TRadioGroup
        Left = 642
        Top = 86
        Width = 100
        Height = 113
        Caption = 'H/W accel.'
        Items.Strings = (
          'none'
          'CUDA'
          'QuickSync'
          'dxva2'
          'd3d11')
        TabOrder = 23
        OnClick = rgdHwAccelClick
      end
      object chk360VideoDecoding: TCheckBox
        Left = 320
        Top = 84
        Width = 305
        Height = 25
        Caption = '360'#176' video decoding with mouse control'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -14
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 24
        OnClick = chk360VideoDecodingClick
      end
    end
    object tbsFrameGrabber: TTabSheet
      Caption = 'frame grabber'
      object Label42: TLabel
        Left = 0
        Top = 0
        Width = 108
        Height = 16
        Caption = 'Frame grabber.'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object Label43: TLabel
        Left = 108
        Top = 0
        Width = 631
        Height = 13
        Caption = 
          'The frame grabber handles frame capture, frame overlay and video' +
          ' processing, so these features are not available when it is disa' +
          'bled. '
      end
      object Label72: TLabel
        Left = 788
        Top = 123
        Width = 67
        Height = 13
        Caption = 'capture width:'
      end
      object Label73: TLabel
        Left = 788
        Top = 170
        Width = 71
        Height = 13
        Caption = 'capture height:'
      end
      object rgdFrameGrabberFormat: TRadioGroup
        Left = 118
        Top = 20
        Width = 169
        Height = 99
        Caption = 'frame grabber format'
        Columns = 2
        Items.Strings = (
          'default'
          'RGB32'
          'RGB24'
          'RGB565'
          'RGB555'
          'RGB8')
        TabOrder = 0
        OnClick = rgdFrameGrabberFormatClick
      end
      object rgdFrameGrabber: TRadioGroup
        Left = 0
        Top = 20
        Width = 110
        Height = 119
        Caption = 'Frame grabber'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clNavy
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        Items.Strings = (
          'both streams'
          'preview'
          'capture'
          'disabled')
        ParentFont = False
        TabOrder = 1
        OnClick = rgdFrameGrabberClick
      end
      object grbOneShot: TGroupBox
        Left = 298
        Top = 20
        Width = 481
        Height = 75
        Caption = 'one-shot frame capture to...'
        TabOrder = 2
        object edtUseThisFileName: TEdit
          Left = 384
          Top = 44
          Width = 80
          Height = 21
          Enabled = False
          TabOrder = 0
          Text = 'CapFile01'
        end
        object btnOneShotTBitmap: TButton
          Left = 10
          Top = 22
          Width = 63
          Height = 21
          Caption = 'TBitmap'
          TabOrder = 1
          OnClick = btnOneShotTBitmapClick
        end
        object btnOneShotBMPFile: TButton
          Left = 81
          Top = 22
          Width = 64
          Height = 21
          Caption = '.BMP'
          TabOrder = 2
          OnClick = btnOneShotBMPFileClick
        end
        object btnOneShotJPEGFile: TButton
          Left = 153
          Top = 22
          Width = 56
          Height = 21
          Caption = '.JPG'
          TabOrder = 3
          OnClick = btnOneShotJPEGFileClick
        end
        object chkUseThisFileName: TCheckBox
          Left = 10
          Top = 49
          Width = 365
          Height = 21
          Caption = 'do not create the file name automatically, use this file name:'
          TabOrder = 4
          OnClick = chkUseThisFileNameClick
        end
        object btnOneShotClipboard: TButton
          Left = 347
          Top = 22
          Width = 74
          Height = 21
          Caption = 'clipboard'
          TabOrder = 5
          OnClick = btnOneShotClipboardClick
        end
        object btnOneShotPngFile: TButton
          Left = 217
          Top = 22
          Width = 56
          Height = 21
          Caption = '.PNG'
          TabOrder = 6
          OnClick = btnOneShotPngFileClick
        end
        object BtnOneShotTiffFile: TButton
          Left = 281
          Top = 22
          Width = 56
          Height = 21
          Caption = '.TIFF'
          TabOrder = 7
          OnClick = BtnOneShotTiffFileClick
        end
      end
      object grbBurstMode: TGroupBox
        Left = 298
        Top = 103
        Width = 481
        Height = 120
        Caption = 'burst-mode frame capture to... '
        TabOrder = 3
        object Label14: TLabel
          Left = 74
          Top = 52
          Width = 234
          Height = 13
          Caption = 'frames to capture  (0 = capture frames indefinitely)'
        end
        object Label15: TLabel
          Left = 79
          Top = 95
          Width = 210
          Height = 13
          Caption = 'frames to skip between each frame captured'
        end
        object btnBurstModeBMPFile: TButton
          Left = 81
          Top = 22
          Width = 64
          Height = 21
          Caption = '.BMP'
          TabOrder = 0
          OnClick = btnBurstModeBMPFileClick
        end
        object btnBurstModeJPEGFile: TButton
          Left = 153
          Top = 22
          Width = 56
          Height = 21
          Caption = '.JPG'
          TabOrder = 1
          OnClick = btnBurstModeJPEGFileClick
        end
        object edtBurstCount: TEdit
          Left = 10
          Top = 49
          Width = 55
          Height = 21
          TabOrder = 2
          Text = '3'
          OnChange = edtBurstCountChange
        end
        object edtBurstInterval: TEdit
          Left = 10
          Top = 90
          Width = 55
          Height = 21
          TabOrder = 3
          Text = '0'
          OnChange = edtBurstIntervalChange
        end
        object btnBurstModeStop: TButton
          Left = 424
          Top = 22
          Width = 49
          Height = 21
          Caption = 'stop'
          TabOrder = 4
          OnClick = btnBurstModeStopClick
        end
        object btnBurstModeTBitmap: TButton
          Left = 10
          Top = 22
          Width = 63
          Height = 21
          Caption = 'TBitmap'
          TabOrder = 5
          OnClick = btnBurstModeTBitmapClick
        end
        object btnBurstModeClipboard: TButton
          Left = 347
          Top = 22
          Width = 74
          Height = 21
          Caption = 'clipboard'
          TabOrder = 6
          OnClick = btnBurstModeClipboardClick
        end
        object chkModulo: TCheckBox
          Left = 71
          Top = 71
          Width = 403
          Height = 21
          Caption = 
            'modulo (when the count is reached, overwrite frame 1 and next...' +
            ')'
          TabOrder = 7
          OnClick = chkModuloClick
        end
        object btnBurstModePNGFile: TButton
          Left = 217
          Top = 22
          Width = 56
          Height = 21
          Caption = '.PNG'
          TabOrder = 8
          OnClick = btnBurstModePNGFileClick
        end
        object btnBurstModeTIFFFile: TButton
          Left = 281
          Top = 22
          Width = 56
          Height = 21
          Caption = '.TIFF'
          TabOrder = 9
          OnClick = btnBurstModeTIFFFileClick
        end
      end
      object grbZoomSize: TGroupBox
        Left = 784
        Top = 20
        Width = 90
        Height = 102
        Caption = 'Zoom size'
        TabOrder = 4
        object Label12: TLabel
          Left = 15
          Top = 20
          Width = 21
          Height = 13
          Caption = 'size:'
        end
        object tbrCaptureZoomSize: TTrackBar
          Left = 10
          Top = 15
          Width = 31
          Height = 85
          Max = 300
          Orientation = trVertical
          Position = 100
          TabOrder = 0
          ThumbLength = 14
          OnChange = tbrCaptureZoomSizeChange
        end
        object edtCaptureZoomSize: TEdit
          Left = 42
          Top = 44
          Width = 40
          Height = 21
          Color = clSilver
          ReadOnly = True
          TabOrder = 1
          Text = '100%'
        end
        object btnResetCaptureZoomSize: TButton
          Left = 46
          Top = 23
          Width = 30
          Height = 18
          Caption = 'rst'
          TabOrder = 2
          OnClick = btnResetCaptureZoomSizeClick
        end
      end
      object mmoFrameCaptureLog: TMemo
        Left = 879
        Top = 25
        Width = 252
        Height = 189
        Color = clSilver
        Lines.Strings = (
          '   log:')
        TabOrder = 5
      end
      object edtFrameCaptureWidth: TEdit
        Left = 788
        Top = 140
        Width = 80
        Height = 21
        TabOrder = 6
        OnChange = edtFrameCaptureWidthChange
      end
      object edtFrameCaptureHeight: TEdit
        Left = 788
        Top = 187
        Width = 80
        Height = 21
        TabOrder = 7
        OnChange = edtFrameCaptureHeightChange
      end
    end
    object TabSheet1: TTabSheet
      Caption = 'motion detection'
      ImageIndex = 11
      DesignSize = (
        1310
        229)
      object Label53: TLabel
        Left = 0
        Top = 0
        Width = 115
        Height = 16
        Caption = 'Motion detection'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object lblMotionDetectorRequiresFrameGrabber: TLabel
        Left = 138
        Top = 0
        Width = 218
        Height = 16
        Caption = 'The frame grabber must be enabled.'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clRed
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object Label54: TLabel
        Left = 0
        Top = 49
        Width = 85
        Height = 13
        Caption = 'detection method:'
      end
      object imgMotionDetected: TImage
        Left = 492
        Top = 5
        Width = 130
        Height = 105
      end
      object mmoSensitivityGrid: TMemo
        Left = 630
        Top = 5
        Width = 248
        Height = 214
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'Courier New'
        Font.Style = []
        ParentFont = False
        ScrollBars = ssBoth
        TabOrder = 0
        WordWrap = False
      end
      object mmoMotionGrid: TMemo
        Left = 886
        Top = 5
        Width = 248
        Height = 214
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'Courier New'
        Font.Style = []
        ParentFont = False
        ScrollBars = ssBoth
        TabOrder = 1
        WordWrap = False
      end
      object chkMotionDetectionEnabled: TCheckBox
        Left = 0
        Top = 22
        Width = 218
        Height = 21
        Caption = 'ENABLE MOTION DETECTION'
        TabOrder = 2
        OnClick = chkMotionDetectionEnabledClick
      end
      object chkReduceVideoNoise: TCheckBox
        Left = 226
        Top = 22
        Width = 140
        Height = 21
        Caption = 'reduce video noise'
        TabOrder = 3
        OnClick = chkReduceVideoNoiseClick
      end
      object btnShowGridDialog: TButton
        Left = 382
        Top = 1
        Width = 102
        Height = 24
        Caption = 'show grid dialog'
        TabOrder = 4
        OnClick = btnShowGridDialogClick
      end
      object chkCompareRed: TCheckBox
        Left = 118
        Top = 47
        Width = 41
        Height = 21
        Caption = 'red'
        TabOrder = 5
        OnClick = chkCompareRedClick
      end
      object chkCompareGreen: TCheckBox
        Left = 167
        Top = 47
        Width = 61
        Height = 21
        Caption = 'green'
        TabOrder = 6
        OnClick = chkCompareGreenClick
      end
      object chkCompareBlue: TCheckBox
        Left = 236
        Top = 47
        Width = 51
        Height = 21
        Caption = 'blue'
        TabOrder = 7
        OnClick = chkCompareBlueClick
      end
      object chk_GreyScale: TCheckBox
        Left = 295
        Top = 47
        Width = 90
        Height = 21
        Caption = 'grey scale'
        TabOrder = 8
        OnClick = chk_GreyScaleClick
      end
      object grbMotionRatio: TGroupBox
        Left = 490
        Top = 113
        Width = 132
        Height = 52
        Caption = 'Global motion ratio'
        TabOrder = 9
        object shpMotionDetected: TShape
          Left = 16
          Top = 22
          Width = 18
          Height = 19
          Brush.Color = clScrollBar
          Shape = stCircle
        end
        object edtMotionRatio: TEdit
          Left = 42
          Top = 20
          Width = 79
          Height = 21
          Color = clSilver
          ReadOnly = True
          TabOrder = 0
        end
      end
      object grbXYMaxMotion: TGroupBox
        Left = 414
        Top = 167
        Width = 208
        Height = 52
        Caption = 'max motion location:'
        TabOrder = 10
        object edtMaxMotionXY: TEdit
          Left = 12
          Top = 20
          Width = 78
          Height = 21
          Color = clSilver
          ReadOnly = True
          TabOrder = 0
        end
        object edtMaxMotionCoord: TEdit
          Left = 96
          Top = 20
          Width = 102
          Height = 21
          Color = clSilver
          ReadOnly = True
          TabOrder = 1
        end
      end
      object grbCellsSensitivity: TGroupBox
        Left = 165
        Top = 139
        Width = 237
        Height = 80
        Caption = 'cells sensitivity  (0 based index)'
        TabOrder = 11
        object Label57: TLabel
          Left = 10
          Top = 20
          Width = 26
          Height = 13
          Caption = 'X cell'
        end
        object Label58: TLabel
          Left = 69
          Top = 20
          Width = 26
          Height = 13
          Caption = 'Y cell'
        end
        object Label59: TLabel
          Left = 128
          Top = 20
          Width = 78
          Height = 13
          Caption = 'sensitivity (0 .. 9)'
        end
        object edtXCell: TEdit
          Left = 10
          Top = 39
          Width = 37
          Height = 21
          TabOrder = 0
          Text = '2'
        end
        object updXCell: TUpDown
          Left = 47
          Top = 39
          Width = 18
          Height = 21
          Associate = edtXCell
          Max = 1000
          Position = 2
          TabOrder = 1
        end
        object edtYCell: TEdit
          Left = 69
          Top = 39
          Width = 37
          Height = 21
          TabOrder = 2
          Text = '1'
        end
        object updYCell: TUpDown
          Left = 106
          Top = 39
          Width = 18
          Height = 21
          Associate = edtYCell
          Max = 1000
          Position = 1
          TabOrder = 3
        end
        object edtCellSensitivity: TEdit
          Left = 128
          Top = 39
          Width = 37
          Height = 21
          TabOrder = 4
          Text = '6'
        end
        object updCellSensitivity: TUpDown
          Left = 165
          Top = 39
          Width = 18
          Height = 21
          Associate = edtCellSensitivity
          Max = 9
          Position = 6
          TabOrder = 5
        end
        object btnSetCellsSensitivity: TButton
          Left = 187
          Top = 39
          Width = 41
          Height = 26
          Caption = 'SET'
          TabOrder = 6
          OnClick = btnSetCellsSensitivityClick
        end
      end
      object grbGridSize: TGroupBox
        Left = 0
        Top = 139
        Width = 159
        Height = 80
        Caption = 'grid size'
        TabOrder = 12
        object Label55: TLabel
          Left = 5
          Top = 20
          Width = 44
          Height = 13
          Caption = 'col count'
        end
        object Label56: TLabel
          Left = 66
          Top = 20
          Width = 47
          Height = 13
          Caption = 'row count'
        end
        object edtGridColCount: TEdit
          Left = 7
          Top = 39
          Width = 37
          Height = 21
          TabOrder = 0
          Text = '10'
        end
        object updGridColCount: TUpDown
          Left = 44
          Top = 39
          Width = 19
          Height = 21
          Associate = edtGridColCount
          Position = 10
          TabOrder = 1
        end
        object edtGridRowCount: TEdit
          Left = 66
          Top = 39
          Width = 37
          Height = 21
          TabOrder = 2
          Text = '10'
        end
        object updGridRowCount: TUpDown
          Left = 103
          Top = 39
          Width = 19
          Height = 21
          Associate = edtGridRowCount
          Position = 10
          TabOrder = 3
        end
        object btnApplyGridSize: TButton
          Left = 123
          Top = 39
          Width = 28
          Height = 26
          Caption = 'OK'
          TabOrder = 4
          OnClick = btnApplyGridSizeClick
        end
      end
      object grbGridString: TGroupBox
        Left = 0
        Top = 69
        Width = 470
        Height = 70
        Anchors = [akLeft, akTop, akRight]
        Caption = 'grid string'
        TabOrder = 13
        DesignSize = (
          470
          70)
        object Label51: TLabel
          Left = 51
          Top = 15
          Width = 62
          Height = 13
          Caption = 'sensitivity +/-'
        end
        object lblGridValid: TLabel
          Left = 24
          Top = 34
          Width = 22
          Height = 13
          Caption = 'valid'
        end
        object shpGridValid: TShape
          Left = 5
          Top = 35
          Width = 15
          Height = 17
          Brush.Color = clScrollBar
          Shape = stRoundRect
        end
        object edtGrid: TEdit
          Left = 66
          Top = 34
          Width = 401
          Height = 21
          Anchors = [akLeft, akTop, akRight]
          TabOrder = 0
          OnChange = edtGridChange
        end
        object updGlobalGridSensitivity: TUpDown
          Left = 52
          Top = 34
          Width = 15
          Height = 25
          Max = 10000
          Position = 5000
          TabOrder = 1
          OnClick = updGlobalGridSensitivityClick
        end
      end
      object chkTriggered: TCheckBox
        Left = 404
        Top = 30
        Width = 80
        Height = 20
        Caption = 'triggered'
        TabOrder = 14
        OnClick = chkTriggeredClick
      end
      object btnTriggerNow: TButton
        Left = 404
        Top = 49
        Width = 80
        Height = 21
        Caption = 'trigger now'
        TabOrder = 15
        OnClick = btnTriggerNowClick
      end
    end
    object tbsFrameOverlay: TTabSheet
      Caption = 'overlays'
      ImageIndex = 8
      object lblFrameOverlayRequiresFrameGrabber: TLabel
        Left = 946
        Top = 10
        Width = 188
        Height = 16
        Caption = 'frame grabber must be enabled'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clRed
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object btnPIPFromAnotherTVideoGrabber: TSpeedButton
        Left = 648
        Top = 196
        Width = 258
        Height = 25
        Caption = 'PIP from other TVideoGrabber (e.g. clip)'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        Glyph.Data = {
          76010000424D7601000000000000760000002800000020000000100000000100
          0400000000000001000000000000000000001000000010000000000000000000
          800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
          5555555555555555555555555555555555555555555555555555555555555555
          555555555555555555555555555555555555555FFFFFFFFFF555550000000000
          55555577777777775F55500B8B8B8B8B05555775F555555575F550F0B8B8B8B8
          B05557F75F555555575F50BF0B8B8B8B8B0557F575FFFFFFFF7F50FBF0000000
          000557F557777777777550BFBFBFBFB0555557F555555557F55550FBFBFBFBF0
          555557F555555FF7555550BFBFBF00055555575F555577755555550BFBF05555
          55555575FFF75555555555700007555555555557777555555555555555555555
          5555555555555555555555555555555555555555555555555555}
        NumGlyphs = 2
        ParentFont = False
        OnClick = btnPIPFromAnotherTVideoGrabberClick
      end
      object grbFreeHand: TGroupBox
        Left = 943
        Top = 32
        Width = 192
        Height = 186
        Caption = 'FrameBitmap event drawing'
        TabOrder = 0
        object Label27: TLabel
          Left = 2
          Top = 20
          Width = 164
          Height = 26
          Caption = 'the sample code is located in the VideoGrabberFrameBitmap event'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -10
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsItalic]
          ParentFont = False
          WordWrap = True
        end
        object chkFreeHandEnabled: TCheckBox
          Left = 9
          Top = 135
          Width = 172
          Height = 16
          Caption = '"free hand" mouse draw'
          TabOrder = 0
          OnClick = chkFreeHandEnabledClick
        end
        object btnFreeHandErase: TButton
          Left = 9
          Top = 158
          Width = 169
          Height = 20
          Caption = 'Erase "free hand" drawing'
          TabOrder = 1
          OnClick = btnFreeHandEraseClick
        end
        object chkChangePixels: TCheckBox
          Left = 9
          Top = 112
          Width = 109
          Height = 21
          Caption = 'change pixels'
          TabOrder = 2
          OnClick = chkChangePixelsClick
        end
        object chkDrawGridOverFrames: TCheckBox
          Left = 9
          Top = 91
          Width = 89
          Height = 21
          Caption = 'draw grid'
          TabOrder = 3
          OnClick = chkDrawGridOverFramesClick
        end
        object chkDrawTarget: TCheckBox
          Left = 9
          Top = 69
          Width = 172
          Height = 21
          Caption = 'mouse-controlled target'
          TabOrder = 4
          OnClick = chkDrawGridOverFramesClick
        end
      end
      object grbTextOverlay: TGroupBox
        Left = 1
        Top = 0
        Width = 458
        Height = 222
        Caption = 
          'Text overlays   (to show while component is inactive, set Target' +
          'Display = -3)'
        TabOrder = 1
        object Label13: TLabel
          Left = 287
          Top = 68
          Width = 14
          Height = 13
          Caption = 'left'
        end
        object Label20: TLabel
          Left = 248
          Top = 68
          Width = 15
          Height = 13
          Caption = 'top'
        end
        object Label22: TLabel
          Left = 327
          Top = 68
          Width = 20
          Height = 13
          Caption = 'right'
        end
        object Label33: TLabel
          Left = 370
          Top = 89
          Width = 21
          Height = 13
          Caption = 'size:'
        end
        object Label37: TLabel
          Left = 98
          Top = 20
          Width = 100
          Height = 16
          Caption = 'target display:'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label3: TLabel
          Left = 339
          Top = 198
          Width = 50
          Height = 13
          Caption = 'speed (+-):'
        end
        object Label106: TLabel
          Left = 354
          Top = 156
          Width = 66
          Height = 13
          Caption = 'coeff (0..255):'
        end
        object rdgTextOverlayAlign: TRadioGroup
          Left = 256
          Top = 114
          Width = 198
          Height = 39
          Caption = 'Text align'
          Columns = 3
          ItemIndex = 0
          Items.Strings = (
            'left'
            'center'
            'right')
          TabOrder = 3
          OnClick = rdgTextOverlayAlignClick
        end
        object chkTextOverlayEnabled: TCheckBox
          Left = 10
          Top = 20
          Width = 87
          Height = 21
          Caption = 'enabled'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 0
          OnClick = chkTextOverlayEnabledClick
        end
        object chkTextOverlayTransparent: TCheckBox
          Left = 187
          Top = 47
          Width = 89
          Height = 21
          Caption = 'transparent'
          TabOrder = 2
          OnClick = chkTextOverlayTransparentClick
        end
        object mmoTextOverlayString: TMemo
          Left = 5
          Top = 128
          Width = 240
          Height = 90
          ScrollBars = ssVertical
          TabOrder = 1
          WordWrap = False
          OnChange = mmoTextOverlayStringChange
        end
        object edtTextOverlayTop: TEdit
          Left = 248
          Top = 90
          Width = 34
          Height = 21
          TabOrder = 4
          Text = '5'
          OnChange = edtTextOverlayTopChange
        end
        object edtTextOverlayLeft: TEdit
          Left = 287
          Top = 90
          Width = 35
          Height = 21
          TabOrder = 5
          Text = '5'
          OnChange = edtTextOverlayLeftChange
        end
        object edtTextOverlayRight: TEdit
          Left = 327
          Top = 90
          Width = 34
          Height = 21
          TabOrder = 6
          Text = '140'
          OnChange = edtTextOverlayRightChange
        end
        object chkTextOverlayShadow: TCheckBox
          Left = 286
          Top = 47
          Width = 72
          Height = 21
          Caption = 'shadow'
          TabOrder = 7
          OnClick = chkTextOverlayShadowClick
        end
        object updTextOverlaySize: TUpDown
          Left = 407
          Top = 88
          Width = 21
          Height = 21
          TabOrder = 8
          OnClick = updTextOverlaySizeClick
        end
        object rdgTextOverlaySelector: TRadioGroup
          Left = 5
          Top = 69
          Width = 237
          Height = 57
          Caption = 'overlay selector (0..n), 0 = default'
          Columns = 5
          ItemIndex = 0
          Items.Strings = (
            '0'
            '1'
            '2'
            '3'
            '4'
            '5'
            '6'
            '7'
            '8'
            '9')
          TabOrder = 9
          OnClick = rdgTextOverlaySelectorClick
        end
        object btnTextOverlayColor: TButton
          Left = 268
          Top = 20
          Width = 37
          Height = 17
          Caption = 'color'
          TabOrder = 10
          OnClick = btnTextOverlayColorClick
        end
        object btnBkgndColor: TButton
          Left = 318
          Top = 20
          Width = 36
          Height = 17
          Caption = 'bkgn'
          TabOrder = 11
          OnClick = btnBkgndColorClick
        end
        object chkTextOverlayHighResFont: TCheckBox
          Left = 10
          Top = 39
          Width = 168
          Height = 21
          Caption = 'high resolution font'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 12
          OnClick = chkTextOverlayHighResFontClick
        end
        object edtTextOverlayTargetDisplay: TEdit
          Left = 201
          Top = 17
          Width = 30
          Height = 21
          TabOrder = 13
          Text = '0'
          OnChange = edtTextOverlayTargetDisplayChange
        end
        object btnTargetDisplayInfo: TButton
          Left = 234
          Top = 18
          Width = 28
          Height = 24
          Caption = '?'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 14
          OnClick = btnTargetDisplayInfoClick
        end
        object chkTextOverlayScrolling: TCheckBox
          Left = 256
          Top = 198
          Width = 74
          Height = 21
          Caption = 'scrolling'
          TabOrder = 15
          OnClick = chkTextOverlayScrollingClick
        end
        object edtTextOverlayScrollingSpeed: TEdit
          Left = 411
          Top = 196
          Width = 31
          Height = 21
          TabOrder = 16
          Text = '0'
          OnChange = edtTextOverlayScrollingSpeedChange
        end
        object chkOverlayOrientation: TRadioGroup
          Left = 364
          Top = 16
          Width = 90
          Height = 69
          Caption = 'orientation'
          ItemIndex = 0
          Items.Strings = (
            'horiz.'
            'vert.'
            'vert.inv.')
          TabOrder = 17
          OnClick = chkOverlayOrientationClick
        end
        object chkTextOverlayAlphablend: TCheckBox
          Left = 249
          Top = 161
          Width = 99
          Height = 21
          Caption = 'alpha blend'
          TabOrder = 18
          OnClick = chkTextOverlayAlphablendClick
        end
        object tbrTextOverlayAlphablendValue: TTrackBar
          Left = 344
          Top = 170
          Width = 100
          Height = 22
          Max = 255
          Position = 100
          TabOrder = 19
          ThumbLength = 15
          OnChange = tbrTextOverlayAlphablendValueChange
        end
      end
      object chkAdjustOverlayAspectRatio: TCheckBox
        Left = 463
        Top = 199
        Width = 186
        Height = 21
        Caption = 'adjust overlay aspect ratio'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 2
        OnClick = chkAdjustOverlayAspectRatioClick
      end
      object grbBitmapOverlay: TGroupBox
        Left = 463
        Top = 2
        Width = 474
        Height = 189
        Caption = 
          'Image overlays   (to show while component is inactive, set Targe' +
          'tDisplay = -3)'
        TabOrder = 3
        object Label48: TLabel
          Left = 266
          Top = 57
          Width = 14
          Height = 13
          Caption = 'left'
        end
        object btnLoadImageOverlayFromFile: TSpeedButton
          Left = 10
          Top = 57
          Width = 159
          Height = 25
          Caption = 'select an image file...'
          Glyph.Data = {
            76010000424D7601000000000000760000002800000020000000100000000100
            0400000000000001000000000000000000001000000010000000000000000000
            800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
            FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
            5555555555555555555555555555555555555555555555555555555555555555
            555555555555555555555555555555555555555FFFFFFFFFF555550000000000
            55555577777777775F55500B8B8B8B8B05555775F555555575F550F0B8B8B8B8
            B05557F75F555555575F50BF0B8B8B8B8B0557F575FFFFFFFF7F50FBF0000000
            000557F557777777777550BFBFBFBFB0555557F555555557F55550FBFBFBFBF0
            555557F555555FF7555550BFBFBF00055555575F555577755555550BFBF05555
            55555575FFF75555555555700007555555555557777555555555555555555555
            5555555555555555555555555555555555555555555555555555}
          NumGlyphs = 2
          OnClick = btnLoadImageOverlayFromFileClick
        end
        object Label25: TLabel
          Left = 315
          Top = 57
          Width = 15
          Height = 13
          Caption = 'top'
        end
        object Label82: TLabel
          Left = 364
          Top = 57
          Width = 25
          Height = 13
          Caption = 'width'
        end
        object Label96: TLabel
          Left = 414
          Top = 57
          Width = 29
          Height = 13
          Caption = 'height'
        end
        object Label47: TLabel
          Left = 138
          Top = 86
          Width = 66
          Height = 13
          Caption = 'coeff (0..255):'
        end
        object Label102: TLabel
          Left = 212
          Top = 135
          Width = 136
          Height = 13
          Caption = 'chroma key RGB color (hex):'
        end
        object Label103: TLabel
          Left = 345
          Top = 108
          Width = 47
          Height = 13
          Caption = 'leeway %:'
        end
        object Label97: TLabel
          Left = 246
          Top = 162
          Width = 100
          Height = 16
          Caption = 'target display:'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object edtImageOverlayTransparentColorValue: TEdit
          Left = 140
          Top = 130
          Width = 68
          Height = 21
          TabOrder = 6
          Text = '0'
          OnChange = edtImageOverlayTransparentColorValueChange
        end
        object rdgImageOverlaySelector: TRadioGroup
          Left = 7
          Top = 16
          Width = 457
          Height = 42
          Caption = 
            '________________overlay selector (0..n), 0 = default____________' +
            '_____'
          Columns = 10
          ItemIndex = 0
          Items.Strings = (
            '0'
            '1'
            '2'
            '3'
            '4'
            '5'
            '6'
            '7'
            '8'
            '9')
          TabOrder = 3
          OnClick = rdgImageOverlaySelectorClick
        end
        object edtChromaKeyLeewayPercent: TTrackBar
          Left = 404
          Top = 101
          Width = 66
          Height = 22
          Max = 100
          TabOrder = 15
          ThumbLength = 15
          OnChange = edtChromaKeyLeewayPercentChange
        end
        object chkImageOverlayEnabled: TCheckBox
          Left = 175
          Top = 59
          Width = 92
          Height = 21
          Caption = 'enabled'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 0
          OnClick = chkImageOverlayEnabledClick
        end
        object edtImageOverlayLeft: TEdit
          Left = 266
          Top = 73
          Width = 40
          Height = 21
          TabOrder = 1
          Text = '50'
          OnChange = edtImageOverlayLeftChange
        end
        object edtImageOverlayTop: TEdit
          Left = 315
          Top = 73
          Width = 41
          Height = 21
          TabOrder = 2
          Text = '50'
          OnChange = edtImageOverlayTopChange
        end
        object chkImageOverlayTransparent: TCheckBox
          Left = 5
          Top = 106
          Width = 124
          Height = 21
          Caption = 'transparent'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 4
          OnClick = chkImageOverlayTransparentClick
        end
        object chkImageOverlayUseTransparentColor: TCheckBox
          Left = 5
          Top = 133
          Width = 124
          Height = 21
          Caption = 'transp.color (hex):'
          TabOrder = 5
          OnClick = chkImageOverlayUseTransparentColorClick
        end
        object btnImageOverlayPickupColor: TButton
          Left = 5
          Top = 160
          Width = 183
          Height = 21
          Caption = 'pick up the transparent color'
          TabOrder = 7
          OnClick = btnImageOverlayPickupColorClick
        end
        object btnImageOverlayPickupHelp: TButton
          Left = 190
          Top = 160
          Width = 30
          Height = 21
          Caption = '?'
          TabOrder = 8
          OnClick = btnImageOverlayPickupHelpClick
        end
        object edtImageOverlayWidth: TEdit
          Left = 364
          Top = 73
          Width = 41
          Height = 21
          Hint = '-1 = current image width'
          TabOrder = 9
          Text = '-1'
          OnChange = edtImageOverlayWidthChange
        end
        object edtImageOverlayHeight: TEdit
          Left = 414
          Top = 73
          Width = 40
          Height = 21
          Hint = '-1 = current image height'
          TabOrder = 10
          Text = '-1'
          OnChange = edtImageOverlayHeightChange
        end
        object chkImageOverlayAlphaBlend: TCheckBox
          Left = 25
          Top = 89
          Width = 99
          Height = 21
          Caption = 'alpha blend'
          TabOrder = 11
          OnClick = chkImageOverlayAlphaBlendClick
        end
        object chkImageOverlayAlphablendCoeff: TTrackBar
          Left = 128
          Top = 101
          Width = 100
          Height = 22
          Max = 255
          Position = 100
          TabOrder = 12
          ThumbLength = 15
          OnChange = chkImageOverlayAlphablendCoeffChange
        end
        object chkImageOverlayChromaKey: TCheckBox
          Left = 231
          Top = 106
          Width = 107
          Height = 21
          Caption = 'chroma key'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 13
          OnClick = chkImageOverlayChromaKeyClick
        end
        object edtChromaKeyColorValue: TEdit
          Left = 394
          Top = 130
          Width = 70
          Height = 21
          TabOrder = 14
          Text = '0'
          OnChange = edtChromaKeyColorValueChange
        end
        object edtImageOverlayTargetDisplay: TEdit
          Left = 348
          Top = 158
          Width = 31
          Height = 21
          TabOrder = 16
          Text = '0'
          OnChange = edtImageOverlayTargetDisplayChange
        end
        object btnImageOverlayInfo: TButton
          Left = 382
          Top = 159
          Width = 28
          Height = 23
          Caption = '?'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 17
        end
      end
      object btnPIPStop: TButton
        Left = 910
        Top = 196
        Width = 29
        Height = 25
        Caption = 'stop'
        TabOrder = 4
        OnClick = btnPIPStopClick
      end
    end
    object tbsVideoProcessing: TTabSheet
      Caption = 'video processing'
      ImageIndex = 9
      object grbCropping: TGroupBox
        Left = 798
        Top = 2
        Width = 326
        Height = 157
        Caption = 'Cropping'
        TabOrder = 0
        object Label85: TLabel
          Left = 252
          Top = 69
          Width = 27
          Height = 13
          Caption = 'Y pos'
        end
        object Label86: TLabel
          Left = 113
          Top = 15
          Width = 53
          Height = 13
          Caption = 'Area width:'
        end
        object Label87: TLabel
          Left = 108
          Top = 44
          Width = 57
          Height = 13
          Caption = 'Area height:'
        end
        object Label84: TLabel
          Left = 84
          Top = 118
          Width = 27
          Height = 13
          Caption = 'X pos'
        end
        object Label88: TLabel
          Left = 10
          Top = 69
          Width = 72
          Height = 13
          Caption = 'cropping zoom:'
        end
        object chkCroppingEnabled: TCheckBox
          Left = 10
          Top = 20
          Width = 90
          Height = 21
          Caption = 'enabled'
          TabOrder = 0
          OnClick = chkCroppingEnabledClick
        end
        object trkCroppingX: TTrackBar
          Left = 118
          Top = 111
          Width = 159
          Height = 31
          TabOrder = 1
          OnChange = trkCroppingXChange
        end
        object trkCroppingY: TTrackBar
          Left = 286
          Top = 9
          Width = 30
          Height = 140
          Orientation = trVertical
          TabOrder = 2
          OnChange = trkCroppingYChange
        end
        object edtCroppingWidth: TEdit
          Left = 187
          Top = 10
          Width = 70
          Height = 21
          TabOrder = 3
          OnChange = edtCroppingWidthChange
        end
        object edtCroppingHeight: TEdit
          Left = 187
          Top = 39
          Width = 70
          Height = 21
          TabOrder = 4
          OnChange = edtCroppingHeightChange
        end
        object trkCroppingZoom: TTrackBar
          Left = 2
          Top = 89
          Width = 255
          Height = 21
          Max = 1000
          Position = 100
          TabOrder = 5
          ThumbLength = 14
          OnChange = trkCroppingZoomChange
        end
        object chkCroppingOutbounds: TCheckBox
          Left = 10
          Top = 39
          Width = 90
          Height = 21
          Caption = 'out bounds'
          TabOrder = 6
          OnClick = chkCroppingOutboundsClick
        end
        object btnCroppingZoomReset: TButton
          Left = 10
          Top = 114
          Width = 50
          Height = 18
          Caption = 'reset'
          TabOrder = 7
          OnClick = btnCroppingZoomResetClick
        end
      end
      object grbVMR9Adjust: TGroupBox
        Left = 603
        Top = 2
        Width = 186
        Height = 157
        Hint = 
          'Conditions: VMR9 selected, frame grabber disabled or on the capt' +
          'ure stream, MPEG2 video source'
        Caption = 'VMR9 image adjustment'
        TabOrder = 1
        object Label7: TLabel
          Left = 49
          Top = 128
          Width = 100
          Height = 13
          Caption = 'bright. cont. sat.  hue'
        end
        object Label21: TLabel
          Left = 10
          Top = 49
          Width = 27
          Height = 13
          Caption = 'range'
        end
        object tbrVMR9Brightness: TTrackBar
          Left = 53
          Top = 20
          Width = 27
          Height = 110
          Max = 128
          Min = -128
          Orientation = trVertical
          Frequency = 5
          TabOrder = 0
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrVMR9BrightnessChange
        end
        object tbrVMR9Contrast: TTrackBar
          Left = 85
          Top = 20
          Width = 25
          Height = 110
          Max = 128
          Min = -128
          Orientation = trVertical
          Frequency = 5
          TabOrder = 1
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrVMR9ContrastChange
        end
        object tbrVMR9Saturation: TTrackBar
          Left = 116
          Top = 20
          Width = 23
          Height = 110
          Max = 64
          Min = -64
          Orientation = trVertical
          TabOrder = 2
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrVMR9SaturationChange
        end
        object tbrVMR9Hue: TTrackBar
          Left = 148
          Top = 20
          Width = 21
          Height = 110
          Max = 180
          Min = -180
          Orientation = trVertical
          TabOrder = 3
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrVMR9HueChange
        end
        object vmr9FixRange: TCheckBox
          Left = 10
          Top = 30
          Width = 40
          Height = 20
          Caption = 'fix'
          Checked = True
          State = cbChecked
          TabOrder = 4
          OnClick = vmr9FixRangeClick
        end
      end
      object grbSoftwareVideoProcessing: TGroupBox
        Left = 10
        Top = 2
        Width = 582
        Height = 213
        Caption = 'Software video processing   (requires the frame grabber enabled)'
        TabOrder = 2
        object Label31: TLabel
          Left = 443
          Top = 140
          Width = 103
          Height = 13
          Caption = 'bright. cont. sat.  hue.'
        end
        object Label50: TLabel
          Left = 448
          Top = 177
          Width = 53
          Height = 13
          Caption = 'pixellization'
        end
        object Label60: TLabel
          Left = 5
          Top = 160
          Width = 171
          Height = 13
          Caption = 'custom rotation angle (<= 360'#176'),e.g.:'
        end
        object rdgVideoRotation: TRadioGroup
          Left = 10
          Top = 30
          Width = 267
          Height = 119
          Caption = 'Video rotation (in degrees)'
          Columns = 2
          ItemIndex = 0
          Items.Strings = (
            'no rotation'
            '90'#176
            '180'#176
            '270'#176
            '0'#176'  mirror'
            '90'#176'  mirror'
            '180'#176' mirror'
            '270'#176' mirror'
            'custom angle'
            'cust. angle mirror')
          TabOrder = 0
          OnClick = rdgVideoRotationClick
        end
        object rdgDeinterlacing: TRadioGroup
          Left = 288
          Top = 20
          Width = 100
          Height = 139
          Caption = 'Deinterlacing'
          ItemIndex = 0
          Items.Strings = (
            'disabled'
            'half-size'
            'full size'
            'DScaler'
            'AVISynth'
            'FFDShow')
          TabOrder = 1
          OnClick = rdgDeinterlacingClick
        end
        object chkFlipVertical: TCheckBox
          Left = 347
          Top = 166
          Width = 73
          Height = 21
          Caption = 'flip vert.'
          TabOrder = 2
          OnClick = chkFlipVerticalClick
        end
        object chkFlipHorizontal: TCheckBox
          Left = 347
          Top = 187
          Width = 75
          Height = 21
          Caption = 'flip horz.'
          TabOrder = 3
          OnClick = chkFlipHorizontalClick
        end
        object chkGreyScale: TCheckBox
          Left = 258
          Top = 187
          Width = 83
          Height = 19
          Caption = 'greyscale'
          TabOrder = 4
          OnClick = chkGreyScaleClick
        end
        object chkInvertColors: TCheckBox
          Left = 258
          Top = 166
          Width = 84
          Height = 21
          Caption = 'inv.colors'
          TabOrder = 5
          OnClick = chkInvertColorsClick
        end
        object btnResetAll: TButton
          Left = 398
          Top = 98
          Width = 41
          Height = 31
          Caption = 'reset'
          TabOrder = 6
          OnClick = btnResetAllClick
        end
        object tbrBrightness: TTrackBar
          Left = 447
          Top = 10
          Width = 27
          Height = 133
          Max = 128
          Min = -128
          Orientation = trVertical
          Frequency = 5
          TabOrder = 7
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrBrightnessChange
        end
        object tbrConstrast: TTrackBar
          Left = 479
          Top = 10
          Width = 24
          Height = 133
          Max = 128
          Min = -128
          Orientation = trVertical
          Frequency = 5
          TabOrder = 8
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrConstrastChange
        end
        object tbrSaturation: TTrackBar
          Left = 510
          Top = 10
          Width = 23
          Height = 133
          Max = 64
          Min = -64
          Orientation = trVertical
          TabOrder = 9
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrSaturationChange
        end
        object tbrHue: TTrackBar
          Left = 542
          Top = 10
          Width = 30
          Height = 133
          Max = 180
          Min = -180
          Orientation = trVertical
          TabOrder = 10
          ThumbLength = 18
          TickMarks = tmBoth
          TickStyle = tsNone
          OnChange = tbrHueChange
        end
        object edtPixellization: TEdit
          Left = 522
          Top = 172
          Width = 31
          Height = 21
          ReadOnly = True
          TabOrder = 11
          Text = '1'
        end
        object updPixellization: TUpDown
          Left = 553
          Top = 172
          Width = 18
          Height = 21
          Associate = edtPixellization
          Min = 1
          Position = 1
          TabOrder = 12
          OnClick = updPixellizationClick
        end
        object edtCustomRotationAngle: TEdit
          Left = 5
          Top = 175
          Width = 85
          Height = 21
          TabOrder = 13
          OnChange = edtCustomRotationAngleChange
        end
      end
      object rdgDetectVideoSignal: TRadioGroup
        Left = 601
        Top = 167
        Width = 523
        Height = 46
        Caption = 'Detect video signal (adjustable)'
        Columns = 3
        ItemIndex = 0
        Items.Strings = (
          'disabled'
          'no signal (dark screen)'
          'Connexant blue screen')
        TabOrder = 3
      end
    end
    object tbsDisplay: TTabSheet
      Caption = 'display'
      ImageIndex = 10
      object imgLogo: TImage
        Left = 165
        Top = 148
        Width = 112
        Height = 71
        Center = True
        Picture.Data = {
          0A544A504547496D6167659F420000FFD8FFE000104A46494600010102001C00
          1C0000FFDB0043000503040404030504040405050506070C08070707070F0B0B
          090C110F1212110F111113161C1713141A1511111821181A1D1D1F1F1F131722
          24221E241C1E1F1EFFDB0043010505050706070E08080E1E1411141E1E1E1E1E
          1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E1E
          1E1E1E1E1E1E1E1E1E1E1E1E1EFFC00011080120016003012200021101031101
          FFC4001F0000010501010101010100000000000000000102030405060708090A
          0BFFC400B5100002010303020403050504040000017D01020300041105122131
          410613516107227114328191A1082342B1C11552D1F02433627282090A161718
          191A25262728292A3435363738393A434445464748494A535455565758595A63
          6465666768696A737475767778797A838485868788898A92939495969798999A
          A2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6
          D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F01000301
          01010101010101010000000000000102030405060708090A0BFFC400B5110002
          0102040403040705040400010277000102031104052131061241510761711322
          328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728
          292A35363738393A434445464748494A535455565758595A636465666768696A
          737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7
          A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3
          E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F8C8
          52E281D69C2B48453131B8A314FC518ADBD88AE3314629F8A3147B10B8CC518A
          7E28C51EC42E3314629F8A3147B10B8CC518A7E28C51EC42E3314629F8A3147B
          10B8CC518A7E28C51EC42E3314629F8A3147B10B8CC518A7E28C51EC42E33146
          29F8A3147B10B8CC518A7E28C51EC42E3314629F8A3147B10B8CC518A7E28C51
          EC42E3314629F8A3147B10B8CC518A7E28C51EC42E3314629F8A3147B10B8CC5
          18A7E28C51EC42E3314629F8A3147B10B8CC518A7E28C51EC42E3314629F8A31
          47B10B8CC5069C7A534D6538A43403AD3853475A70A74818E152AC60806A2156
          13EE8AF460AE653761BE50F5A3CA1EB5281462B6549B33E6645E50F5A3CA1EB5
          2E28C51EC5873322F287AD1E50F5A9714628F62C399917943D68F287AD4B8A31
          47B161CCC8BCA1EB47943D6A5C518A3D8B0E6645E50F5A3CA1EB52E28C51EC58
          73322F287AD1E50F5A9714628F62C399917943D68F287AD4B8A3147B161CCC8B
          CA1EB47943D6A5C518A3D8B0E6645E50F5A3CA1EB52E28C51EC5873322F287AD
          1E50F5A9714628F62C399917943D68F287AD4B8A3147B161CCC8BCA1EB47943D
          6A5C518A3D8B0E6645E50F5A3CA1EB52E28C51EC5873322F287AD1E50F5A9714
          628F62C399917943D68F287AD4B8A3147B161CCC8BCA1EB47943D6A5C518A3D8
          B0E6645E50F5A3CA1EB52E28C51EC9873322318C75A88D583D2AB9AC66AC8D20
          EE30F4A69A71E94D35E7D535403AD3853475A70A54818E15613EE8AAE2BDAFF6
          3FF0AE81E32F8B36FA278934F5BFB092DE576899D9325636239520F503BD7773
          F24798CE4AFA1E3E29C2BED3FDAD7E10FC3BF067C229759F0D78723B1BE1791C
          5E689E57F94AB9230CC47615F168AEDC1D65595EC6538F2863EB463D8D4F0FDC
          A9315E82A699839D8A98F63463D8D5BC518A7EC839CA98F63463D8D5BC518A3D
          90739531EC68C7B1AB78A3147B20E72A63D8D18F6356F15F4D7EC53F0E7C1BE3
          CB0F12378AF454D45ACDEDC404CD247B37799BBEE30CE768EBE95CD8A9AC3C39
          DAB974FDF763E5AC7B1A31EC6BE96FDB57C01E12F026A3E1F83C29A4269D1DD4
          323CC04AEFB886C0E5C9C7E15F3A629E1A6ABD3E74AC153DC762A63D8D18F635
          6F1462BA3D911CE54C7B1A31EC6ADE28C51EC839CA98F63463D8D5BC518A3D90
          739531EC68C7B1AB78A3147B20E72A63D8D18F6356F14628F641CE54C7B1A31E
          C6ADE28C51EC839CA98F63463D8D5BC518A3D90739531EC68C7B1AB78A3147B2
          0E72A63D8D18F6356F14628F641CE54C7B1A31F5AB78A649F70D2F6690299588
          A434E34D3D6B9EA1A2187A55735FA1FF00073E067C2CD7BE17787758D57C2915
          C5F5DD8A4B3CBF69997731EA701C01F80AF88FE3869761A27C59F12E91A5DBAD
          BD959EA33C3044093B116460A32793C01D6BC68D7551DAC74A8729C49E94D34E
          3D29A6B9AA968075A70A68EB4E14A9031C2BE85FD833FE4BAD9FFD7ACFFF00A2
          9EBE7A15F42FEC19FF0025D6CFFEBD67FF00D14F5D757F84C8EA8FAC3F6B7F0B
          EBBE30F84DFD89E1DD3A6BFBE97508488E3C642E1C1639200032326BC37E157E
          CC1E0CD5A4D4B4AF1078EE0BCD7ECC6DB8B1D2DD49B56CF3B8B0F9C03C1DA000
          78CD7D0FFB4C78C2FF00C0FF0007359D6F4A9BC9D430905B49DD19D802C3DC2E
          E23DEBE09F801E2AD4F46F8D9A06B09772F9B71A824772DB8FEF11DB0E0FAE41
          35961E355D39383B25A849ABAB9BBFB40FC12D67E145EC3334E97FA3DDBB0B7B
          A452BC8FE16073B5B1EE73D41EB8F33D1F4EBCD5F53B7D374FB792E2EAE2411C
          51A292CCC4E00007BD7E947ED2BE1EB4F11FC16F11DBDD441DAD2D5AF613DD5E
          205B8FAA865FA135F9EDF0C3C697DF0FBC5B0F88F4CB1B2BBBEB7565845D2164
          424105B008E704F7AF53018AAB529492D64B639EAD38C649F467B8D9FECF7E02
          F0A5ADBB7C55F8896FA55FCD1873A7DA90D2A023B9E4FF00E3A4707935D5F857
          E037ECFDE307FB1F867C73A95EDE05DC235BA8D5D80EA42346091F4AF9F9F43F
          893F18BC597DAFDA6877FAA5D5ECC5E59238C88A338185DC7E550060004F4C57
          B77C07FD9C3C75E1AF1B689E2CF106A961A22D9DCA486DD67F326939E63F97E5
          F98647DEE84F158D74E10E69D7F7FB2FCB42E166ECA3A1E77FB417ECF9ACFC33
          B6FEDBB2BB1AAE82CE10CE1763C2C7A075C9C0F420907D8E01F15B6825B9B848
          208DA496460AAA064926BF4D3F68CB786EBE0878AE29D03A8B06700F66560C0F
          E6057C7DFB15F84AD7C43F18A0BBBFB759A0D2A07BD556E54BA950B91ECCEAC3
          FDDAE8C163E5F56A93A9AB8DADF322A525CE92EA757F0E7F653793C3C7C43F11
          F5D5D06D844657B65C0789319DD2393B53BF1CFBE0F15BFA27ECF1F053C6D15D
          43E08F1EDEDC5DDB8F9C1749367FB4536A315F7071EF5D57EDEDAEDD587C36D3
          346B59CC4351BC2D3007EFA460707DB73A9FA815F21FC2DF1BEB9F0EFC571788
          F42F24DCC68D198E604C6EAC30430046477EBD40ACB0D43178CA52AD19BBA7A2
          FEB42A73A74E4A2D1AFF001C7E116BFF000AF5A8AD75264BBB1B905AD6F22076
          4801C107D1864647B8EBD6BDFF00FE09D7FF0020EF187FBF69FF00B5ABC77E2A
          7C7AF15FC47F0C9D03C43A4689E40944D1CB044EB246E011904B1EC48E95EC9F
          F04EE52B61E3007FBF69FF00B5AB4C6C310B05FED0ACD35DB5FB89A4E0EAFB8C
          C9FF0082897FC867C2BFF5EF37FE842BC9FF00678F82FAB7C51D77CC944967A0
          5B30FB65E6DEBDF6267AB91F80EA7B03F567ED11F07F53F8A9E3DF0B0F356D74
          2B2865FED0B9DC378F981088BDD88CF3D077F43D778F2F2D7E107C18BB9FC23A
          12B45A5C0A96F6F18C852CC17CC7EED82771EE7D7BD7053C73A7865469FC4FA9
          B3A49CF99EC7CC1FB47FC31F841F0BB48169637BADDEF88EE143416CF7111489
          73F7E4C460E0E0E06727E82BC17C19E19D5BC63E27B4D0342B433DEDE49B6341
          C01DC924F4000249F40693C55ADEAFE27D76EB5AD66EE4BBBDB972F249236492
          7FCFD0741815F4EFFC13E7C350BEA3E20F13CF0AB4B0451DB5BBFF00777962FF
          008E107E0C6BD79D2A997E11D49CAF37F81CEA51AD52CB62CDEFECA1E13D03C0
          775A8F8A7C70D637B14619EF0A016B0B13C020FCCDD70304127B76AE6BE13FEC
          C773A978BDE3F14486F3C2D3D89B8B1D5F49B9431CCDB97601B81232A49C151D
          2B7FFE0A0DE22BB37FE1FF000A4133A5B881AF67407891998A213F4D8DFF007D
          55CFD827C77A8DD36A5E02D46669ADEDE137B6258E4C6032ABA0F62581FAE7D6
          BCCB62BEA8EBF3E8DFF4FEF36FDDFB4E4B6A725FB53FC0DF07FC32F02596B5E1
          FB8D526B9B8BF5B661752A328528CD91B5179CA8AD0FD9B3E007827E227C354F
          116B973AB45766E9E12B6D322A6D55520E1909CFCC7BD7A17FC140067E13E920
          7FD0613FF45495B3FB0E0C7C0E41FF005119BFF408EA1D5A9F5352E677E6EFE4
          3E58FB4B5BA1E43E29FD9EBC17E1AF887767C4DAEDCE85E098A08FECB7971321
          9EF2760374681579DA7249DBC0C7AE478AFC70D0FC17E1EF1B4BA5F81F549B55
          D323891BED523AB866619214A80081903A0E41AF5CFDBF754BABAF89BA6691E6
          936B69A6ABAA760EEEC58FE2027E42BE6E6476396E4F4E4D7AD95612AD58C6BC
          E6EDAE8615EA462DC523AEF847F0DBC43F12FC4ABA3E85000AA375CDCC991140
          9EAC7F90EA6BE8DD53F672F83BE0CB4B287C75E3EB9B5BDBB1B232244843B7F7
          8290C4283DC903DC57A87EC71E1283C35F062C2F7C955BDD619AEE77EE572563
          1F4DA338F5635F227ED4BE20BBF11FC6EF10C92CCEF158DD35940A5B88D623B3
          03D01209FA935C91AB5B30C4BA74E5CB1D762DC63461792BB3BCF8D3FB2EDF78
          674293C49E0CD4DB5BD3628FCD9612A3CD44C67782090EB8E723181D8F26BE72
          863FF4A48E453F7C2B0FC6BF42BF634F105C7887E07D9C37D234F269B7125865
          F9CA285651F401C2FD00AF923F695F06DB7833E35EA5A769F108EC26952E6DD0
          70115C06DA3D81240FA56997E2AA3A92C3D5776AF67E82AD4E365389F457857F
          654F86FAA785F4AD4EE2F75F59AEECA19E409711050CE818E3F77D326BE2DF11
          DA4563AF5ED9C00F950CCC8B9EB80715FA99F0F7FE441F0EFF00D82EDBFF0045
          2D7E5F78CA327C57AA1007FC7D3FF3A8C9253AB5A4A4DBD3F543C4A518AB1F46
          FECD9F003C13F113E1AA788B5CB9D5A2BB374F095B6991536AAA9070C84E7E63
          DEBCB3F682F00E89E03F8B47C2DA33DD4962A9136EB875673BD149E4003A93DA
          BEAEFD87063E0720FF00A88CDFFA0475F3F7ED90A4FED13211DA2B6FFD1695CF
          46A5478A9C799FDAEBE4CB9463C89DBB1ED1A87EC97F0E63D2AE27B5BBF10C97
          0B033C49E7C477385240C797EB5F397877E0ACE353B61E3EF1069DE08B6BB7CC
          316A2DFE92EB9EBE50E557B6E72A3DCD7E8B348B0DA195B3B523DC71E8057E5B
          FC56F176A1E36F1EEABE23BF77DF73704C685B3E52038441EC0003F0A597FD62
          BCE508CEDA6FB856E4824DA3E9CF1D7EC83A41F0F4975E0AD7AEA5BF4883C70D
          E6D649F8E8ACB8DB9ED907EBDEBE39D4AD67B2B99ED2E6368A685CA488C30548
          3C822BF4BBF662D46E754F813E17BABA767905B3C2198E4ED8E4745FC9540AF8
          8FF68BD2D3FE1A27C41A7DBC6A7CED44B6D0300973B88C7E38AAC0E2EA29B854
          774BF4155A6AC9A3A5FD9DFF0066DD47E226929E23D7AF1B4AD11D8AC384CCB3
          E3825471819E327B82307B6A7C5BFD9AB4DB5F12368DF0E3C4F6DAA6AD15BF9D
          368B733A0BB50319208C29EA0ED3B4E39C1AFB26386D3C11F0D8C56A8A96DA26
          944A2FA88A227F5C7EB5F9856DE32F1058FC413E2FB7D4EE13565BB33FDA437C
          C58B6493EB9F4E8735CF0AB5ABCDC94B6346A31563F4BFE09E9D7DA4FC26F0D6
          9BA9DACB69796F611A4D0C830D1B7A11EB5F9BBFB467FC971F187FD85EE7FF00
          46B57E9CF8135A3E23F05689AFB2046D42C21B9651D159D0311F9935F98DFB46
          7FC971F187FD85EE7FF46B57361FE234679E9E94D34E3D29A68AA08075A70A68
          EB4E14A9031C2BE85FD833FE4BAD9FFD7ACFFF00A29EBE7A15F42FEC19FF0025
          D6CFFEBD67FF00D14F5D757F84C8EA8FA67F6E689E4F80F72517212FA2663E83
          6B8FE640FC6BE0FF0086B04973E3DD12DE238796F63453EE4E057E92FED047C2
          127C2ED46C3C6F7EFA7E937EC96DF69489A4314A5B28D800F00AE4FB035F34FC
          00FD9CB5EB3F8B167E22D467B2B9F0BE9D38BBB2BFB7B84916FB69CC65029240
          C804E71C6475A8C3578D3A538BDD84E2DC933EAEF8BB70969F0AFC5571205654
          D1EEB861907313000D7E7F7ECE5F0FEDBE25FC558748BE95E3D3E20F7775B3EF
          346A7EE83DB24A8CF6CE6BEA7FDB63E22D87877E1D4DE12B5BA46D6357DA1A25
          6F9A280364B37A6E2A001DC6EF4AF9BFF638F16E9DE13F8CB6B26A932C16DA8C
          0F64D2B1C2A1720A93E8372A8CF6049AD70919C70D5671F2FF008245469CE299
          F5DFC74F195AFC17F84493F86F4DB58641225969D06CFDD46C413B881D7014F5
          EA48CF7AF903E1DF8EBC5FE3AF8E5E13BAF126B577A938D6AD5D6366FDDC7FBD
          5CED41C28FA015F62FED35F0EEF3E25FC339348D29A2FED1B6B85BBB5123ED59
          182B295CF4190C719E32074EB5E1DFB32FC0ED5BC23F1174FD7FE204B65A4DCC
          6CDFD97A749751B4D772853C8018F0A3E6F5C814616786861AA39AF7DE8BFE00
          E6A6E6ADB1F447ED03FF002457C59FF60E93FA57CD1FF04FFBC862F1CEB962E1
          7CD9F4E2E84F501644C81F5DDFA57D2FFB40FF00C915F167FD83A4FE95F04FC1
          0F1BCDF0FF00E22E99E22552F6F1BF977518FE38586D61F500E47B815B6030F2
          AF84AF18EEB95FDD726AC946A45BF33E88FF0082845BBB68BE14BAE7624D7287
          1EA44447FE826BE3CDA7D0D7E85FC70F0AD87C6CF847149E12D46D6F278A5177
          6122C8023B0055A363FC2704F071860338AF10F815FB35F8866F178BBF88DA22
          DB68B6F1B16B76B952D72E4615418DB2003C9391D00E726BB72ACCA8E1709253
          F893D177D8CABD0954A89A3E63DA7D0D7D7BFF0004F318B2F187FBD69FFB5AB9
          9FDABB43F847E0AD3E2F0EF84B43813C472C8AF3C89772C9F6588738219C8DCD
          C7047033D322BA7FF827BFFC7A78C3FDEB4FFDAD5AE638A78BCBFDAF272AE65F
          3151A5ECEADAF7D0F70F8DBF13747F865E157D4AF4A4FA84C0AD8D96EC34CFEA
          7D106464FE03922B98FD9DBC7DFF000B87E1AEA96BE278EDE6BD4924B5BE8910
          22BC3203B4EDEC31B97FE039AF23FF008282FF00C87BC2DFF5EB37FE842B85FD
          8E3C623C2FF16EDF4FB9976596B49F6293270A2427319FAEEC2FFC0CD79B4F2C
          E7CB9E263BA7F87F5A9BBAB6ABC9D0F3CF8BDE0DBBF02FC40D53C3B72AC56098
          9864231E6467956FC4107DB38ED5F51FFC13F668CF823C436C1BF7A97D1BB0F4
          0C840FFD04D49FB727C3FF00ED5F0DDAF8E34F8375D69D882F368E5A163F237F
          C058E3FE063D2BC8FF00639F88769E0BF1F4FA66AF7096FA56B3188A495F858E
          55398D89ECBCB03FEF64F02BBAACE58ECAF996B28357FF003FBBF5318C152AFE
          4CD8FDBFA293FE16668D2946D8748401B1C1225973FCEAAFEC130C87E2EEA128
          4628BA3CBB9B1C0FDE455EE5FB59FC29D4BE2478734FD53C36B1DC6AFA66EF2E
          02E145C44FB72031E323191938E4FB552FD94FC2FE17F01B5CE8136B36777E38
          BDB7FB46A16B04BE67D96242008CB2E54302E370CE727B800D71FD7692CB3D87
          DABFE17BDFF434F64FDBF3F4297EDF9CFC2AD23FEC309FFA2A4AD8FD87FF00E4
          882FFD84A6FF00D063AC8FDBE7FE496E8FFF006184FF00D15256C7EC43FF0024
          487FD84A6FFD063AE66BFE13D3FEFBFC917FF2F7E47CF7FB704AD37C71B84238
          86CA041EFF00206FFD9ABC2F69F435EE5FB6AFFC974BFF00FAF6B7FF00D14B5E
          275F6392D2E6C0D3F9FE6CF3F12BF7ACFD2BFD9FAF21BDF82BE129A0605574C8
          A138FEF463630FCD4D7E7DFC67B792DFE2DF8B22954861AC5D7FE8D6AFA4FF00
          629F8A9A5C1A19F87DAEDEC5693452B49A6492B0559039CB4593FC5B8923D771
          1DB9A1FB4BFC02F176BBF1227F12F83B4F4D42D7542AF711899236825C00C7E6
          2320E37647727A719F9ACB9C72FC74A15F4DD7EABEF3B2B47DB524E2767FB045
          BCB17C23D4A5752165D624D99EF88A2AF14FDB62F20BCF8E862876EEB4B58209
          71FDEC07E7F0703F0AFA6FC2CBA1FC05F81F6707882FE1125AC4D24A1586EB9B
          97F98C71FF007B9C283E832702BE0DF1CF892FFC59E2FD43C47A832FDA6F6769
          582F45C9E147B01803D80ABCA70F2C5E3275A2B4577F7DEDF98ABB50A6A2FC8F
          D2DF87BFF220F877FEC176DFFA296BF313C5C09F146A7C1FF8F97FE75FA29FB3
          AF8AECBC5BF08F42BAB79D1EE2CED52CEED01F9A392350BC8ED90030F635F29F
          C5BF80FE25D17C77A9EA33C96165E159AF1A65D56E2E11638A37624294CEF2C0
          71B54124F4AC326C453C2D79BADA68FEFBAD0AC4C1D48AE53E84FD8AA010FC0A
          B290023CFBC9DCE7D885E3FEF9AF9DFF006C6FF93879BFEB95B7FE8B4AFAF3E0
          6EABE13D4FE1C69C9E0B9259348B006CD1E484C6CEC806E620F7627767FDAAF9
          0FF6C5FF0093869FFEB95B7FE8B4AC3052E6C54A4FAA97E4CAAAAD4D2F4FCCFB
          87C40CCBE17D419490C2CA5208EC761AFC9FBDFF008FA9BFEBA37F3AFD5FF117
          FC8ABA8FFD78CBFF00A01AFCA1BDFF008FB9BFEBA37F3AEBC87E39FA118AD91F
          A39FB257FC9BEF863FDC9FFF004A24AF917E3DDCC767FB55EA77532AB4716A51
          BB06E8400BC1AFAEBF64AFF937DF0C7FB93FFE94495F177ED5D218BF680F134A
          B8CA5D2B0CFB28AE0C2479EB4A3DD334A8ED14FD0FD04F8996EF7DF0DBC4B6B0
          F2F3E917489C752626C57E4F5CA917722F7DE47EB5FA6FFB3D78FB4BF88FF0C2
          C651731CB7F6F6CB6BA94048DC182EDDC47A3019FCC7506BE5AF107ECD3A8681
          F126F2FBC43A85B699E03B69BCF7D5A5997262CE446133B8C87EEE31D7D4759C
          2D5545C948A9C79AD63EBAF80B0C907C18F08A4A30C74A85B1ECCB91FA115F9C
          7FB467FC971F187FD85EE7FF0046B57E9DF826F746D43C23A4DE7878E74892D2
          3FB17C857F741405183C8E077AFCC4FDA33FE4B8F8C3FEC2F73FFA35AB1C3FC4
          5B3CF4F4A69A71E94D34550403AD3853475A70A54818E15D4FC3FF00197883C0
          DAD2EB7E1ABC1677EA85165F2D5F00820F0C08E84D72C2AC27DD15E8462A4ACC
          CA6EC7A478E3E35FC46F1B682DA1F8975D17D60CE24311B78D3E6008072A01EE
          6AA782BE2C7C40F07698FA6787FC4B7B6766D9FDC890955CF5207407DC73EF5C
          28A78AECA5429B5671D0C9C9F735756D5F53D6EFA5D4756BEB8BDBB95B73CB34
          85D98FB93C9AAE84AB0652411C822A187EE54A3AD7A74A29689687349EB73D1B
          40F8D9F13F43D2574BD3BC5B7F1DAA2ED4467DFB07A29392A3E98AC787C7FE30
          6F1641E2A9B5FBDB8D66D9C3C3753C864643DB1BB3C7B74AE4C74A9A1EF5D14B
          0386B3F716BE44CAACEDB9EA1AEFC75F8A3AEE8D75A46ABE266B9B1BB8CC53C4
          6DA201D4F5190A0D79DAF6A8054EBDABD2C26168D0FE1C6D73375253F899D1F8
          33C65E29F0ADCB49E1FD76FF004E2DF7D609D955F1D3700707F1AE9F57F8CBF1
          3F55B636F77E32D5046460F912F9248E3AECC67A579CC1F7FF000AB03A0AE879
          6612ACF9E74D37E84CAB548E898B3969E5696666924724B33B6493EA4D751E02
          F881E2FF000225DAF857576D385E1433ED891F7EDCEDFBC0E31B8F4F5AE63028
          C0F4AEBAB97D2AD4D539C538F6E8651AB38BBA7A9D178F7C73E2AF1D4F6D378A
          B546D464B552B0B34489B013923E502B9EB3924B4BA8AEAD98C5344E1E375382
          AC390452607A5181E94E9E02952A7ECA11B47B7A83AB26F99BD4F45D5BE387C5
          0D5B4BB9D2F51F13B5CD9DD44D0CF13DAC387461823EE7A5743FB3AFC27F0AFC
          50B0D662BED6AF34FD6ED30F6D1C3B761539F98A919203633823823D6BC6703D
          2AFE83AC6A9A0EA716A7A35FDCD85E4272934121461F88AF2F1991AF6128E0FD
          C9795D5FC99B52C4BE64EA6A8F52D6ED7E3D781EC6EBC244F89A3D2F263536CB
          2490B20381E5C8A3E553E808E3A8ED5DE7EC51E07F1469FE3BD47C4DAAE93796
          362B60F6CB25D44D1996467438507A8014E48E3A5723A5FED41F13ECA058A797
          4ABF2A31BEE2D0063EFF00215A875EFDA6BE28EA768D6F6F77A7697B860C9676
          BF3FE05CB63EA315F3F3CAB349D2745508ABEED59376F9FE875AAF454B9B999D
          F7EDE9E27B59DF43F07C122C93425AF6E803F73236C60FBE379FA11EB5E19E0C
          F8ADE3EF0768DFD8FE1BD7DEC2C7CC32F94B046DF31001396527B0AE4F52BDBC
          D4EFA5BED46EA7BBBA99B74934CE5DDCFA9279355F03D2BE83019053A385546B
          A5277BBED7FF0086392AE2A529F345D8D5F1978935BF186B6FAD788AF0DF5FC8
          AAAD3145524280070A00E80563796BFDD152607A5181E95EBD1C2468C1429AB2
          4612A9293BB6315029CA8C1F515DEE89F187E2668DA7A585878BF524B78D76A2
          C8FE66D1E80B671F8570B81E94607A5655F2DA188FE2C13F51C6B4E3F0B34FC5
          1E23D7BC4F7BF6CF106AD7BA94C0615AE6769368F4193C0F6AC8F2D7FBA2A4C0
          F4A302B5A5848518F253565E42954949DDB363C21E2BF127846F1AEFC37AC5E6
          992B8C3F912950E3D187423EB4FF001D78EFC5DE31788F8935EBDD4563E52392
          43B14FA851C03F415867BD4171FC35C93C061BDAFB5705CDDEC690AB3F86FA1D
          A782FE2E7C40F06E8A346F0DEBED63622432F94208DBE6200272CA4F615CEF8C
          3C5FAFF8B3C4275ED7EFBED9A890A0CC6355C85000E1401D00AC7350B7535C13
          C061A3373505777FC77359559DAD73D42F3F686F8B935A496D2F8ADDE2910C6E
          A6D61E548C11F77D2BC9657323B3B632C49352CDF747D6A03D2B92385A342EE9
          C6C57B494D7BCCF47F0AFC71F899E16D02D741D0BC446D34EB50C21845BC6DB7
          2C58F2CA4F524FE35C478C7C43AAF8AB5CBAD775BB9FB4EA172774D2ED0BBCF4
          CE07159A6A393EE3579EF0D4A9CF9A31B335E793D1B34FC23E2BF10F84B525D4
          7C3BAB5D69F72BFC50CA5323D0E0F23DAB4BC7BF12FC6FE39318F137882EEFA3
          8C7CB133E231EE14700FBE39AE48D34D71D5A5072E6B6A6D193B58F52D0BF684
          F8AFA168B6BA3E95E2416D6369188A0885AC44228E832549AF33F136B5A8788B
          5DBCD6F55944D7D792B4D3C8140DEEC4927038E493558F4AAE6BCF74E31D5236
          836F7187A534D38F4A69AE1AA6A8075A70A68EB4E14A9031C2AC27DD155C5584
          FBA2BD1A66331E29E29829E2BD1A262C9E1FB9528EB5143F72A51D6BBE9EE612
          DC70E95343DEA11D2A687BD7A34B6329EC4A2A75ED500A9D7B577D23389241F7
          FF000AB03A0AAF07DFFC2AC0E82BBA9EE673DC7D2A8CF18E692BE8BFD973E0F7
          847E22783351D5BC427501736DA81B78FECF32A2EC11A3720A9E72C6A731CD29
          E5B4555A916D376D3E6FF41D1A2EB4B9533E77F2DBFBA68F2DBFBA6BD57F693F
          03E8BE00F8870E85A09BA368FA7C7707ED12076DECEE0F200E30A2BCCF15DD96
          E2A19861A38882B277DFC9D8C6B4654A6E0CADE5B7F74D1E5B7F74D59C518AEE
          F65E465CECADE5B7F74D1E5B7F74D59C518A3D979073B2B796DFDD34796DFDD3
          56714628F65E41CECADE5B7F74D1E5B7F74D59C518A3D979073B2B796DFDD347
          96DFDD3567148697B3B073B2B30C70460D36A49BEF9FA5475854564691771A7B
          D4171FC3539EF505C7F0D79F5373586E426A16EA6A6350B7535C154D644537DD
          1F5A80F4A9E6FBA3EB501E95C150B86C34D4727DC6A90D4727DC6AF3AA6E6D1D
          CAE69A69C69A6B82A9BA187A5573560F4AAE6BCE99B4061E94D34E3D29A6BCEA
          A6C8075A70A68EB4E14A9031C2AC27DD155C5584FBA2BD1A66331E29E29829E2
          BD1A262C9E1FB9528EB5143F72A51D6BBE9EE612DC70E95343DEA11D2A687BD7
          A34B6329EC4A2A75ED500A9D7B577D23389241F7FF000AB03A0AAF07DFFC2AC0
          E82BBA9EE673DC7D7D9FFB06FF00C932D6BFEC30DFFA263AF8C2BECFFD837FE4
          996B5FF6186FFD131D783C5FFEE30FF17E8CEACBFF0088FD0F2FFDB73FE4B25B
          7FD81A1FFD192D7977803C1BE20F1CEBABA37876C4DCDC11BE4763B63853FBCE
          DD87EA7B66BD47F6DBE7E325A81FF40787FF00464B5F407ECB3E0EB4F0BFC28D
          36F0428350D6235BDBA940E595B98D7E8108E3D49F5AE6A39DCF2BC8E8AA5F1C
          DCADE4949DDFF9152C32AF8A9736CADF91E389FB31D958C36D6FE24F891A6699
          AA5E0DB6F6E21521DFD14BBA97E7D00AE03E2F7C12F167C3A84EA33F95AAE8DB
          829BEB6523CB27A7988794C9E33923DF27158BF1AFC4F75E2BF8A1AEEA934F23
          C22EDE0B505B848518AA01E99033F527D6BECDF827A9C3E3BF821A57F6CA8BD1
          3D9BD8DF2CBF379BB098CEEF76001FC6B2AD8ECE32BA5431B52AF346A6B67B77
          B7CD762A34B0F5E52A6A3668FCFEC577DF07FE14788BE25DFCA9A618ACF4FB66
          02E6FA7525109FE1503EF3E39C7E6464671FE2478713C2BE3AD6BC3EA5CA58DD
          BC71963C94CE509F72A54FE35F77FC1EF0F5A7843E1768DA6C512C4C966B7174
          547DE95D77C87F3240F60057BBC47C492A182A32C23B3AAAF7ECBFCEFA7C99CB
          83C1A9D4929FD93E57F88BFB39F887C3B71043A06B165E219A480CA6CD4AC176
          42FDE6488B1DEA3D8E7DAB5FE1DFECC97DE26F07D8EB7AA7886E343BBB9DE5EC
          67D2CEF8B6BB28CE5D4F2003D075AF2DD5BC77E20BEF894DE3E4BE93FB512EFC
          FB6666CAC6809DB181FDCDBF291DC13EB5F7B7C3AF11A78BBC0DA3F89122111B
          FB5595E307211FA3283ECC08FC2BE7335C667580C3D1F6B55DA6B9935BF4D1BE
          B6D3EF3AE8430D5672E58EDA1F9EFF0011BC35FF0008878E355F0D7DB3EDBFD9
          F3795E7F97B37F00E76E4E3AFAD69FC2EF865E2AF88B7D2C1E1FB5896DEDC817
          17970C521889ED9C125B1D8026B4BF6888F7FC6EF1480AC58DE8000EA7E45AFB
          3BC07A069FF0DBE14C1630C4AA34EB06B9BB603996509BE463F520FD0003B57A
          D9871157C1E57878D377AB52376DEAD2FF0037FA1851C242A579DD7BA99F3F1F
          D97F4D4B88F489BE265847AEC89E62D9FD957715EE42994311EF8AF22F8AFF00
          0B7C55F0E2F923D6EDD25B2998ADBDF5B92D0CA7D324655B1CED3F867AD73F7F
          E25D6AF7C572F8AA6BE946AD25D7DAFED0A7959376411EC38C0F40057DF777A6
          E9BF157E0EDB41AA443C9D6F4C8AE01039865640CAEBEEADCFE15E7E271F9AE4
          D3A352BD5E78CD5DA7F8AF55DD1AC28D0C4A94631B347E724DF7CFD2A3AB9ACD
          9CDA76A9736172009ADE468A400E70CA706A9D7DDAAB1AB4E3523B349AF99E6F
          2B8BB31A7BD4171FC3539EF505C7F0D7154DCD21B909A85BA9A98D42DD4D7055
          359114DF747D6A03D2A79BEE8FAD407A570542E1B0D351C9F71AA4351C9F71AB
          CEA9B9B4772B9A69A71A69AE0AA6E861E955CD583D2AB9AF3A66D0187A534D38
          F4A69AF3AA9B201D69C29A3AD3852A40C70AB09F7455715613EE8AF46998CC78
          A78A60A78AF46898B2787EE54A3AD450FDCA9475AEFA7B984B71C3A54D0F7A84
          74A9A1EF5E8D2D8CA7B128A9D7B5402A75ED5DF48CE24907DFFC2AC0E82ABC1F
          7FF0AB03A0AEEA7B99CF71F5F67FEC1BFF0024CB5AFF00B0C37FE898EBE30AFB
          3FF60DFF009265AD7FD861BFF44C75E0F17FFB8C3FC5FA33AB2FFE23F43CC3F6
          D9FF0092CD69CE3FE24F07FE8C96BEB5F86724537C38F0D4B08C46DA4DA95E31
          C794B5F24FEDB9FF002592DBFEC0D0FF00E8C96BD8FF00643F88363AF7816DFC
          2779788BAC692A512376C34D6F9CAB28EFB73B48EC003DEBE6F1D869CB27C2D7
          4B45CC9FCE5A7EA75D29A5889C7D3F23E3BD7C15D7AFD581045CC9907FDE35F6
          AFEC74AEBF052D4BB6435F5C1518C606FF00D79CFE75E0BF1CFE0F78CACFE28E
          A52E81E1DBFD4F4ED56E9AEAD65B488C8A8646CB2391C26189EB818C1CF5AFA5
          B449749F833F04AC63D6EE228FFB36D0991158667B96CBB227F78976207B735E
          9710667431795E128D277925AAED6497E2F631C250953AF5252D8F94BF69F921
          97E397899A30190490AB63BB08230DFAD7DC4EEB37860BDBB6D592CB319EB805
          383EF5F9C9AFEA977AEEB97BABDF396B9BD9DE794E7F89D8B103D8678F6AFB7F
          F66BF19DB78C3E17E9F0C92A9D4B4B896CAF6227E6F906D47FA328073EBB876A
          7C4F9556C1E030729ADA2D3F277E6B7E2FEE1606BC6A55A96EFF00F00F83E15F
          DD2F07A57DE5FB2E2491FC09F0D8973931CCCB93FC267908FD2BE71F10FC0AF1
          6DB7C4B97C3F6F67247A24B334B16B0EB9B786DB392CEDD0328E369C12471C1C
          D7D7BF0FA0D0AD3C15A4D9786AF21BDD26D6D960B69E29048B204F949DC38272
          0E7DF34F8AF37C2E370B84A541DDC6379793B256F5D1FE0180C34E94EA4A5D59
          F15FC639A1B7FDA3F56B8B8C79316B503C99E9B47964FE95F667C544926F861E
          298E1E5DF47BB0B83D4F92D5F127ED0FFF0025AFC55FF5FBFF00B22D7D6BF027
          C71A77C45F86D6F0DC5C42DA9C16DF64D4EDB77CE081B77E3AED71CE7A72476A
          E1CF70B3581C1E26DEEB872FCD36FF001BFE06984A8BDAD4875BDCF804FDDAFD
          12F8088E9F063C2424EA74B85873D8AE47E8457C7FA9FC0AF8816FE3F6F0BDB6
          877935B35C6C8753F289B63093C48CFD071C95CE7B62BEAAF8A9E2FD2BE11FC2
          88AD6DE74FB74362B63A5404FCCEEA810391FDD5E093F87522BAB8A730A398AC
          34283E676E9DDDB4F5D08C0D1951E773D0F873E2A491CBF12BC4D2C2311BEAB7
          2C9CF632B11FA573353DEC8F35CBCB2316773B9893924D415F7786A0F0F85A74
          A5BC6297DC8F3672E79B92EA34F7A82E3F86A73DEA0B8FE1AC2A6E543721350B
          753531A85BA9AE0AA6B2229BEE8FAD407A54F37DD1F5A80F4AE0A85C361A6A39
          3EE35486A393EE3579D537368EE5734D34E34D35C154DD0C3D2AB9AB07A55735
          E74CDA030F4A69A71E94D35E75536403AD3853475A70A54818E15613EE8AAE2A
          C27DD15E8D33198F14F14C14F15E8D13164F0FDCA9475A8A1FB9528EB5DF4F73
          096E3874A9A1EF508E95343DEBD1A5B194F625153AF6A8054EBDABBE919C4920
          FBFF0085581D055783EFFE15607415DD4F7339EE3EBD17E177C60F17FC3CD1E7
          D23C3AF64B6F73706E24F3E0DE77950BC1CF4C28AF3AA7C5F7D7EB5BD7C0D0C6
          C142BC7992D7AEFF0022635654DDE2EC75DF11BC6DADF8FBC429AE6BED035DA5
          BADB8F263D8BB14B11C7AE58D61E9D7B79A75EC57B61753DADD42DBA39A190A3
          A1F504722AB0A70AEFC2E030F4A87D5A305C9AE9BAD75EA73CEACE53E76F53D6
          F4EFDA23E2A5A587D91B5C82E78C2CD359C66551F5C60FD4835C578BFC5BE24F
          17DF0BDF126B175A94CBC279AC02463FD941855FC00CD7363AD5915A60F87F2D
          C3555569514A5DF576F4BEC2AD8BAD38F2CA5A0AFB8292BF7B1C715EF1AA7C35
          F19FC32D174EF881F0FF00C4F75ABC1730AB4ED6569B5922701958A6E71227AE
          47CA707DC78466BD0FE1AFC66F1C7812D974FD36F61BED314FCB657C86448F27
          27610432FD338F6AE0E2BCBF30C5284F09EFC57C507B4BCF5B7E69F635CBEB52
          A7755347D194FC75F147C71E348D6C75ED72792DD7086D21410A3B7FB48A06E3
          9F5FC315F5FF00ECEBA6DDF87FE08E816BAB426CE58E096791251B4C68F2BC83
          703D3E560483D2BC413F6A3D4BCAF326F06694F77C1F3048C067F104FA77AE23
          E247C75F1CF8D74D97499E6B5D2F4D986D9A0B146532AF757762491EC300F7AF
          8CC564999E631A787A7838D18C6FADFBF56DB6DFE27A50C5D0A579BA8E4D9C77
          C4DD6E2F127C42F106BB6EDBE0BCBF96481B18CC7BB087FEF902B1744D6355D0
          3578F54D1750B9D3EF623F24D04851B1E871D47B1E0D406ABBFDF35FA552CB28
          D3C14707512946292D56F6EA78BEDE52AAEA2D1B3D67FE1A33E2B7F678B53ADD
          B7983FE5E058C4243FF8EEDFD2BCD3C4FE20D6FC4BAA3EA7AFEA973A8DE3F596
          77C903D00E807B0E05671A69AF2E8E4980C1CFDA51A493EFABFBAF7B1BCF1356
          A2B4A5A15E6FBE7E951D4937DF3F4A8EB5ABB0E3B0D3DEA0B8FE1A9CF7A82E3F
          86BCEA9B9AC3721350B753531A85BA9AE0AA6B2229BEE8FAD407A54F37DD1F5A
          80F4AE0A85C361A6A393EE35486A393EE3579D537368EE5734D34E34D35C154D
          D0C3D2AB9AB07A55735E74CDA030F4A69A71E94D35E75536403AD3853475A70A
          54818E15613EE8AAE2AC27DD15E8D33198F14F14C14F15E8D13164F0FDCA9475
          A8A1FB9528EB5DF4F73096E3874A9A1EF508E95343DEBD1A5B194F625153AF6A
          8054EBDABBE919C4920FBFF85581D055783EFF00E15607415DD4F7339EE3E9F1
          7DF5FAD329F17DF5FAD7A548C645914E14D14A2BBE91CEC78EB52F9A3D0D419A
          335D6AAA25C6E4FE68F43479A3D0D419A334FDAA172227F347A1A3CD1E86A0CD
          19A3DAA0E444FE68F4351B1CB134CCD19A5ED5028D80D34D389A69AE5AAEE5A2
          BCDF7CFD2A3A92604B9C0CF151907D0FE55E5D7AF4A0F965249FA9D308C9ABA4
          34F7A82E3F86A73DEA0B8FE1AE3A9B9A43721350B753531A85BA9AE0AA6B2229
          BEE8FAD407A54F37DD1F5A80F4AE0A85C361A6A393EE35486A393EE3579D5373
          68EE5734D34E34D35C154DD0C3D2AB9AB07A55735E74CDA030F4A69A71E94D35
          E75536403AD3853475A70A54818E15613EE8AAE2AC27DD15E8D33198F14F14C1
          4F15E8D13164F0FDCA9475A8A1FB9528EB5DF4F73096E3874A9A1EF508E95343
          DEBD1A5B194F625153AF6A4B1B69AF2EA2B5B78DA49A570888A32589E800AFB5
          3C15FB3AFC3FF06F829FC43F117CCD46E2DADBED5780C8C90DB851B8AA84C331
          1D3AF3D80ACB199AD2C0A4A4AEDF42A851954BD8F8C20FBFF85581D057D53A17
          C42FD9AB58D620F0FB7800595ABB79715ECF6680649C65995CB81CF539C77C55
          9F8E9FB35E8D67E1CBBF10F80FED30CD69199A5D3DE43223C639628C7E6C8193
          824E71C63BE74789230A8A188A4E17EBFAECB42A783725783B9F2853E2FBEBF5
          A96C2C6EAFB518B4FB685A4B99A411246A325989C003DF35F455E781FE10FC1D
          B5B05F8906FF00C49E23B8884EDA75991E543CF19E5723391966E707E5AF7F1F
          9D52C0B8C145CE72D92396961A555377B247CF19A5CD7D3BE13F883FB3B78835
          2B4D0EEBE1DC7A49B893CA8E792D9046A58E06E746DC3AF5C71F4AD5F8EBFB39
          786A1F0B6A1E22F0524FA75DD8C4F73259995A48A6451960BB8965600123920E
          31819CD79F0E3054EAAA78AA2E9DFF00ABDAC8D1E5D78DE12B9F26E69335E99F
          B2D687A57887E3059693AEE9F0DFD9B433978261B94958D88E3D88AFA4FE30FC
          07F0DEB5E0F369E0FD2343D07514B8495EEE4564511007782403EA0F4ED5AE63
          C591C162DE1DD3BA56D6FDD27B5BF526965EEA53E6E63E21CD19AF7DF83BA6FC
          0BB4F1EDB785B5396FBC4DA94D28862D4278847A7BCDD36AA6EDC413C02D9049
          E82BD4BE2A7ECD1E15D76C44DE0C8E1F0FEA4AD9219E46B7957D08C92A476C71
          EDDC672E33A50ACA13A52517D5EF6EF6EDF31ACB64E3752573E30CD19AF78D37
          C3DF093E1278AA1D2BE20DD4BE2CD61980B88ED223F64D3C1E9BC120C8DCE71D
          87F0E715EC9E3CF80BF0F7C69E1417FE13B48349BC9E013D8DD5A3110CA186E5
          0C99C6D3C720023F4A5578CE9D3A8BF752E47B4B6BF9A5D7EF1C72D935F12BF6
          3E23CD266B6FC17A68FF00859DA268BAA5BEE53AC416D75049DC79CAAE8C3F30
          6BEDBF1EFC13F066A1E0DD56CBC37E14D16CF589ADD96CE7285047276391923F
          2ADF34E2B8E06AC611873A9454AF7B6F7F264D0CBDD48B6DDADA1F056692BE88
          F857E1DF845E0CF1EC7E0FF1D4D0EBFE229B113CE577E9D6B31E3C8EB967F566
          18078E0835B5FB4AFC03D1B4BF0CDD78BFC136EF686C8092F2C158B218FF0089
          D32720AF523A6324631CE51E31A0EBAA7383507B49FE76EDF31BCB67CB74F5EC
          78D7ECE48927C73F0BA3AABA9BAE430C83F2357D6DFB55DA5AC7F01BC46F1DB4
          28C05BE0AA0047FA4475F247ECD24FFC2F4F0B039CFDACF5FF0071ABEBDFDABF
          FE481F893E96FF00FA511D7CD71434F3556ED13BB04AD43EF3F3E4F7A82E3F86
          B6FC29A06A7E28F11D9681A3C067BEBD94471276F727D001924F600D7D6563F0
          6FE167C24F060F137C457FED8BA871BB76EF2DA43C88E38C11BFA7F1923827E5
          15F499B6734B03354EDCD27D11C787C3CAA7BDB23E2C350B7535F6BF843C1BF0
          1BE3668F792F873499B45D4A0FF5D144E639610780DB09642A7D40FCABE60F8D
          7F0E754F869E329B43BF61342CA25B5B85521668C93823D0F0411D883D7A9F3F
          0D9CD3C55474A717097666B5B0EE11E64EE8E0A6FBA3EB501E953CDF747D6A03
          D2BAAA194361A6A393EE35486A393EE3579D537368EE5734D34E34D35C154DD0
          C3D2AB9AB07A55735E74CDA030F4A69A71E94D35E75536403AD3853475A70A54
          818E15613EE8AAE2AC27DD15E8D33198F14F14C14F15E8D13164F0FDCA9475A8
          A1FB9528EB5DF4F73096E3874A9A1EF508E95343DEBD1A5B194F63A8F863A9DA
          E8DF10BC3FAB5F006D6D3518279B233F22C8AC78FA0AFD36D5AC349F157862E3
          4FBAD979A5EA76C518C6FC491BAF5561EC7208AFCA88C333008096ED8EB5EAFF
          000CFE37FC46F025AC3A7D85F1BCD322E16CEF62F323519E8A7865FA020578D9
          D65D3C44D54A6D5ED6B376FB8E8C255514E2CF4DF889FB27EB9A7CF2DEF82353
          8B54B61F32DA5D308E71EC1BEE37E3B7E95E6FE23F1A7C67F0B5C0D235DF1078
          9F4D91136886E27914151C719E08ED91C57BD7813F6B4F0DEA33436BE2AD16E3
          4877386B9B77F3A207D4AE0301F4DD5EDDE3BF09F87BE20784A5D3355B682EED
          EE612D6D3ED05A2665F96446EC7907DFA1E2BCD58FC461A7186369F3A5FCCB5B
          793FF873A1D28CD5E9BB7A1F9AFA6EA37BA6EA30EA361732DB5DC0E248A68DB0
          C8C0E4107D41AF4DF067C31F897F182FDF5F98CF2C52B059354D4A5215F031C1
          3967C018F941C631C5735F0AFC2D0F88FE2FE91E13BD6FDC497E12E0038DD1A1
          DCE01F70A457DCFF0019B5BFF8579F06357D4740B64B53616A96F6490A00B06E
          658D481D30BBB3F857B39B66EA8D482C24129B4BDEB2BA4F648E6C3E1DC93F68
          F4EC7CFF003FC01F007819E1BDF891F122289010E2CEDD3CB92400F41CB391EE
          147E15F58EA51413F87EE611F3C125ABAF5EAA508FE55F98371A8EA1AFEB82E2
          FEF2E6F6F6EA61BE5958C8EEC4FA9E4D7EA05C47E56872459CECB62BF92D7879
          D61F1146A47EB1539E4D7DDFD7C8EAC3CA324F95591F0DFEC6E777C77B027AFD
          9EE7FF0045357D2DFB5AEBD7BA0FC15D49AC256865BE963B2675EA11F25C7E2A
          A57F1AF99FF634607E3BD881DA0B9FFD14D5F40FEDB671F0573E9A9C3FFA0C95
          5985A798414BAF27E4854AEA93F99F16F84A7920F15E9571192248EF229149F5
          0E08AFD34F11DF9D2FC3DA96A61771B3B49670BEBB10B63F4AFCC3F0BC8ADE23
          D38027FE3E53FF004215FA5FF10BFE441F117FD82EE7FF00453576F163BE2A1F
          E1FD599E0135077EE7E67EB7A8DE6ABABDDEA5A84CF3DDDD4CF2CD2375676249
          3F99AFD0CFD9CA76B8F821E1591FA8B2F2FF00057651FCABF39669544CE327EF
          1AFD14FD9A3FE486785FFEBD9FFF0046BD6FC4C92A1878A5A24FF24460AFCD36
          CF91BC476D1DA7ED60F0C4309FF0972301E99B907FAD7DBDF133579F40F879E2
          1D6AD4817165A6CF3444F6754257F5C57C4DE3061FF0D74CBDFF00E12B8BFF00
          4A057DA1F17F4F9B55F859E28D3EDA3F3679F4AB858D3FBCDE59200F7CD78B9A
          4AEA85FF00917E6CE9A0ADCDEACFCD76B89A5BC37324B234CF26F690B12C589C
          939F5AFD32F085CFFC249F0EB48BBBF456FED3D26179D4F20F99102C3F535F98
          8AEBE684C9FBD8CE2BF4DFE1D44FA4FC31F0F437C3CA7B4D1ED96707F80AC2BB
          BF2C1AF5B8A792F4793B3FBB4B1CF81E6F7AE7C41F016D1B4FFDA3F43B07397B
          7D4A4898FF00B41581FD6BEB1FDABFFE481F893E96FF00FA511D7C9FF032FE3D
          4FF69AD22FA3042DCEA92CD8C74DC18E3F5AFABFF6B0E3E017894FFB36FF00FA
          511D79D9A4A52C4D272DF961F91B505684ADDD9E17FB076896D77E34D6F5D953
          74BA7D9AC5167F84CADF787BE1187E26BB4FDB8744F17F88ACFC35A7787344D4
          F54B4479E5B95B3B67942B8D810B6D071C16C7D4D72FFB00EAB02EB5E28D2199
          7CEB8B782E231DCAC6CCADFF00A356BBAFDAE7E25F8E3E1D4DA049E16B982DAD
          6F566133496CB292EA57032C0E386AD31B3AD2CDE4E0AF2E6D2FF80A924A824F
          6B1E57FB23784BC77E18F8C76973AA784F5BD3EC2E2D6686E27B8B378E351B0B
          0C9231CB2AD7A3FEDEFA24377F0DF4BD7044A6E2CAFF00C9DF8E4248849FD517
          F3AF125FDA6FE2F31C2EAF66C7DB4F88FF00ECB5CF7C40F8D9F11BC6DE1B9B40
          F115DC13E9F23ABB2AD924672A720E4006B5AD83C6CF18ABD4494AEB66BA7CC9
          F694D53E54795CDF747D6A03D2A79BEE8FAD407A57D2D43861B0D351C9F71AA4
          351C9F71ABCEA9B9B4772B9A69A71A69AE0AA6E861E955CD583D2AB9AF3A66D0
          187A534D38F4A69AF3AA9B201D69C29A3AD3852A40C70AB09F7455715613EE8A
          F46998CC78A78A60A78AF46898B2787EE54A3AD450FDCA9475AEFA7B984B71C3
          A54D0F7A8474A9A1EF5E8D2D8CA7B17B4BBC974FD42DEF603896090488719C10
          723AD7DE1F0CFE22FC2CF8A1E106D2B548347D2B54BAB76B6BBB399122662CB8
          2D1310339E4800E47EA7E06069C92321CA3153EA0E2B9332CAE18D4A57B49154
          310E969D0FAB07EC8F3AEB7E749E38D3D7450FBCC8203E76CCF4C676F4EF9FC2
          BD5FE307C61F07FC3AF0249A4E83AB5ADEEAF1DA8B4B0B7B6904BE490BB559C8
          381B473827271F523E00FB5DCEDDBF68976FA6F38A8DE4776DCECCC7D49C9AE2
          964D5B1138BC4D5BA46DF5A8C57B913A8F00F8A66F0CFC40D2BC51F348D67789
          3C8A0F2EA18165CFB8C8FC6BF4324BDF087C5CF8717B6561AAC375A76A96A639
          0C6C3CC8188046E53CAB29C1C1F4AFCC9CD4B1DCCF12ED8E69107A2B915D1996
          511C5CA33A72E5695BE4B6228E2B9159A3E9BF0DFC2FF87DF0B3E2169DA978DF
          C75A7EAB2C57D18B0D3AC1373F99B86D92719F9114F247B753D0FD85A9491FF6
          6DCFCEBFEA5FBFB1AFCA06964660CCEC48E849E9527DB6EFFE7EA7FF00BF86B8
          B1191D7AF2539D5BBF3348E2E1156513DBBF631603E3D5992401E45CF5FF00AE
          6F5F41FEDBAEA7E09901949FED287A1FF664AF82A39A58D8B4723A31EA55B069
          F25D5CC8BB649E575F4672456F5B279D4C4C6B73AD397BF44BFC898E292838D8
          D4F0A1FF008A9B4DE7FE5E53FF004215FA69F10A44FF008407C43F3AFF00C82E
          E7BFFD326AFCB2562A4329208EE0D4C6F6EC8C1B99883FF4D0D6D9B6593C7555
          38C92B2B134312A9C6CD0F9CFEFE4E7F88FF003AFD1AFD9A1D07C0BF0B02EA0F
          D99FBFFD357AFCDC2C49C9E4D4AB7974AA156E66007401CD699A65F2C6C29C54
          ADCBFF000054710A9B6DADCF68F18107F6BF3820FF00C55517FE940AFB8FC79E
          208BC2BE0DD57C453DABDDC7A7DB34ED02B0064C7F0E4F02BF367E1248F27C57
          F0AB3B3331D62D792727FD6AD7E83FED03FF002457C59FF60E93FA57CDE7149D
          2A94E9B77B452FC59DB879F3C5CBCCF9EBE1E7C28F86FF0013FC74BE31F0F6BA
          96BA27982E2F3C3F2285B9864CE4C639C7944F461DB81CF4F49FDA9FE2F68BE1
          5F05DF786748BFB7B9D775189AD8C70C80FD963618666C74383803AF39EDCFC1
          B0DC4D082229648C1EBB588CD35E4791B73B331F52735EC7F61CA7562EAD4E68
          C765D6DD8E6FADA4B48EA7A8FECC0F9F8F1E18666EB744927FDD6AFB13F6B074
          3F007C4A03A93B60EFFF004F11D7E754723C6DBA37646F55383523DDDCBA957B
          89994F505C915AE6194CF158955A324969F8134B12A10E568EBFE1078E2F3E1F
          78F74FF12DA299520629710EEC09A2618653F8723DC03DABECDF1637C38FDA1B
          E1FC7A759788A1B6BD56F3ED43B05B8B6970461A3246E5E4838E0F63C57E7EE6
          9F1CD247FEAE474EFF002B62B6CC72B58AA8AB53972CD7E9B134B13C8B95ABA3
          EE1F829F04343F8537B7DE26F1AF88346BC7F20C7179A02C30AE797264EAD818
          E9C64F5CD789FED5FF0014740F186A56FE1FF085A5AA68F6321792EA280466E6
          5C63238076819033D724FA57863DD5C3FDF9E56EDCB935166B1C3E512F6FF58C
          44F9A439E26F0E482B11CDF747D6A03D2A79BEE8FAD407A57A950C61B0D351C9
          F71AA4351C9F71ABCEA9B9B4772B9A69A71A69AE0AA6E861E955CD583D2AB9AF
          3A66D0187A534D38F4A69AF3AA9B201D69C29A3AD3852A40C70AB09F74557156
          13EE8AF46998CC78A78A60A78AF46898B2787EE54A3AD450FDCA94577D3DCC25
          B8E1D29C188E848A6668CD75C6AA8A22C49BDBFBC68DEDFDE351E68CD57B7172
          926F6FEF1A37B7F78D479A3347B70E524DEDFDE346F6FEF1A8F34668F6E1CA49
          BDBFBC68DEDFDE351E68CD1EDC394937B7F78D1BDBFBC6A3CD19A3DB872926F6
          FEF1A37B7F78D479A3347B70E524DEDFDE346F6FEF1A8F34668F6E1CA5BD3B50
          BBD3AFE0BFB2B8920B9B79165864438647072181EC41AEBB55F8B7F12355D3A7
          D3B52F196B17569708526865B8664753D88CF22B86CD19AC2A428D57CD38A6CB
          8CA51564C937B7F78D1BDBFBC6A3CD19ADFDB91CA49BDBFBC68DEDFDE351E68C
          D1EDC394937B7F78D1BDBFBC6A3CD19A3DB872926F6FEF1A37B7F78D479A3347
          B70E51E589EA49A69E9499A3349D54D0EC21A8E4FB8D521A8E4FB8D5C95372E3
          B95CD34D38D34D705537430F4AAE6AC1E955CD79D33680C3D29A69C7A534D79D
          54D900EB4E14D1D69C295206385584FBA2AB8AB09F7457A34CC663C53C530538
          57A149D8C593C4404EA29FB87A8AAB9F6A33ED5D3ED110E05ADC3D451B87A8AA
          B9F6A33ED4FDA8B90B5B87A8A370F515573ED467DA8F6A1C85ADC3D451B87A8A
          AB9F6A33ED47B50E42D6E1EA28DC3D4555CFB519F6A3DA87216B70F5146E1EA2
          AAE7DA8CFB51ED4390B5B87A8A370F515573ED467DA8F6A1C85ADC3D451B87A8
          AAB9F6A33ED47B50E42D6E1EA28DC3D4555CFB519F6A3DA87216B70F5146E1EA
          2AAE7DA8CFB51ED4390B5B87A8A370F515573ED467DA8F6A1C85ADC3D451B87A
          8AAB9F6A33ED47B50E42D6E1EA28DC3D4555CFB519F6A3DA87216B70F5146E1E
          A2AAE7DA8CFB51ED4390B5B87A8A370F515573ED467DA8F6A1C85ADC3D452484
          143C8AAD9F6A33ED4BDA21F20A69A6949A435854772D0C3D2AB9AB07A55735E7
          4CDA030F4A69A71E94D35E75536403AD3853475A70A54818E15613EE8AAE2A41
          2606315E841D8CA4AE4F9A3350F9BED479BED5AFB5239193668CD43E6FB51E6F
          B53F6AC39193668CD43E6FB51E6FB51ED5872326CD19A87CDF6A3CDF6A3DAB0E
          464D9A3350F9BED479BED47B561C8C9B3466A1F37DA8F37DA8F6AC39193668CD
          43E6FB51E6FB51ED5872326CD19A87CDF6A3CDF6A3DAB0E464D9A3350F9BED47
          9BED47B561C8C9B3466A1F37DA8F37DA8F6AC39193668CD43E6FB51E6FB51ED5
          872326CD19A87CDF6A3CDF6A3DAB0E464D9A3350F9BED479BED47B561C8C9B34
          66A1F37DA8F37DA8F6AC39193668CD43E6FB51E6FB51ED5872326CD19A87CDF6
          A3CDF6A3DAB0E464D9A3350F9BED479BED47B561C8C9B3466A1F37DA8F37DA8F
          6A1C8C90F4AAE69FE6FB5466B29B4D1704D0D3D29A69C7A534D79F54D500EB4E
          14CA5CD4424A20C7E68CD333466B5F6C2B0FCD19A6668CD1ED82C3F3466999A3
          347B60B0FCD19A6668CD1ED82C3F3466999A3347B60B0FCD19A6668CD1ED82C3
          F3466999A3347B60B0FCD19A6668CD1ED82C3F3466999A3347B60B0FCD19A666
          8CD1ED82C3F3466999A3347B60B0FCD19A6668CD1ED82C3F3466999A3347B60B
          0FCD19A6668CD1ED82C3F3466999A3347B60B0FCD19A6668CD1ED82C3F346699
          9A3347B60B0FCD19A6668CD1ED82C3F3466999A3347B60B0FCD19A6668CD1ED8
          2C38F4A69A33486B39C94868FFD9}
        Stretch = True
      end
      object Label76: TLabel
        Left = 364
        Top = 138
        Width = 139
        Height = 13
        Caption = ' (SyncPreview = sp_disabled)'
      end
      object grbMainVideoWindow: TGroupBox
        Left = 561
        Top = 44
        Width = 573
        Height = 178
        Caption = 'display settings:'
        TabOrder = 0
        object Label74: TLabel
          Left = 158
          Top = 118
          Width = 86
          Height = 13
          Caption = 'pan-scan: (0..100)'
        end
        object edtAssignToMonitorLabel: TLabel
          Left = 354
          Top = 49
          Width = 120
          Height = 13
          Caption = 'assign to monitor number:'
        end
        object chkEmbedded: TCheckBox
          Left = 10
          Top = 39
          Width = 100
          Height = 21
          Caption = 'embedded'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 0
          OnClick = chkEmbeddedClick
        end
        object chkFullScreen: TCheckBox
          Left = 187
          Top = 30
          Width = 90
          Height = 20
          Caption = 'full screen'
          TabOrder = 1
          OnClick = chkFullScreenClick
        end
        object chkStayOnTop: TCheckBox
          Left = 354
          Top = 10
          Width = 90
          Height = 21
          Caption = 'stay on top'
          TabOrder = 2
          OnClick = chkStayOnTopClick
        end
        object chkUseVideoPort: TCheckBox
          Left = 453
          Top = 10
          Width = 109
          Height = 21
          Caption = 'use video port'
          TabOrder = 3
          OnClick = chkUseVideoPortClick
        end
        object chkMouseMovesWindow: TCheckBox
          Left = 187
          Top = 10
          Width = 159
          Height = 21
          Caption = 'mouse moves window'
          TabOrder = 4
          OnClick = chkMouseMovesWindowClick
        end
        object chkAutoSize: TCheckBox
          Left = 89
          Top = 20
          Width = 99
          Height = 21
          Caption = 'auto size'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 5
          OnClick = chkAutoSizeClick
        end
        object btnNewLocation2: TButton
          Left = 394
          Top = 118
          Width = 168
          Height = 22
          Caption = 'e.g. pos. 20,20 (640x480)'
          TabOrder = 6
          OnClick = btnNewLocation2Click
        end
        object rdgAspectRatio: TRadioGroup
          Left = 10
          Top = 71
          Width = 129
          Height = 98
          Caption = 'aspect ratio'
          Items.Strings = (
            'box'
            'no resize'
            'stretch'
            'pan-scan')
          TabOrder = 7
          OnClick = rdgAspectRatioClick
        end
        object chkVisible: TCheckBox
          Left = 10
          Top = 20
          Width = 70
          Height = 21
          Caption = 'visible'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 8
          OnClick = chkVisibleClick
        end
        object tbrPanScan: TTrackBar
          Left = 158
          Top = 138
          Width = 168
          Height = 21
          Max = 100
          Position = 50
          TabOrder = 9
          ThumbLength = 15
          OnChange = tbrPanScanChange
        end
        object btnTestPanScan: TButton
          Left = 394
          Top = 150
          Width = 119
          Height = 21
          Caption = 'test pan-scan (e.g.)'
          TabOrder = 10
          OnClick = btnTestPanScanClick
        end
        object chkAlphablend: TCheckBox
          Left = 158
          Top = 69
          Width = 178
          Height = 21
          Caption = 'alphablending: (0..255)'
          TabOrder = 11
          OnClick = chkAlphablendClick
        end
        object chkTranspColor: TCheckBox
          Left = 354
          Top = 84
          Width = 140
          Height = 21
          Caption = 'transp.color (hex):'
          TabOrder = 12
          OnClick = chkTranspColorClick
        end
        object tbrAlphablend: TTrackBar
          Left = 158
          Top = 89
          Width = 178
          Height = 21
          Max = 255
          Position = 180
          TabOrder = 13
          ThumbLength = 15
          OnChange = tbrAlphablendChange
        end
        object edttranspColor: TEdit
          Left = 482
          Top = 81
          Width = 80
          Height = 21
          TabOrder = 14
          OnChange = edttranspColorChange
        end
        object edtAssignToMonitorNumber: TEdit
          Left = 507
          Top = 44
          Width = 41
          Height = 21
          TabOrder = 15
          Text = '0'
          OnChange = edtAssignToMonitorNumberChange
        end
      end
      object rdgVideoRenderer: TRadioGroup
        Left = 10
        Top = 0
        Width = 149
        Height = 225
        Caption = 'VIDEO RENDERER'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        Items.Strings = (
          'Auto select'
          'EVR'
          'VMR9'
          'VMR7'
          'Standard'
          'Overlay'
          'Recording Priority'
          'None (saves cpu)'
          'madVR')
        ParentFont = False
        TabOrder = 1
        OnClick = rdgVideoRendererClick
      end
      object chkVideoVisibleWhenStopped: TCheckBox
        Left = 165
        Top = 23
        Width = 172
        Height = 21
        Caption = 'don'#39't close video window'
        TabOrder = 2
        OnClick = chkVideoVisibleWhenStoppedClick
      end
      object chkChangeCursor: TCheckBox
        Left = 165
        Top = 63
        Width = 173
        Height = 21
        Caption = 'change cursor (e.g.cross)'
        TabOrder = 3
        OnClick = chkChangeCursorClick
      end
      object chkBorder: TCheckBox
        Left = 165
        Top = 84
        Width = 63
        Height = 21
        Caption = 'border'
        TabOrder = 4
        OnClick = chkBorderClick
      end
      object chkTransparency: TCheckBox
        Left = 165
        Top = 103
        Width = 102
        Height = 21
        Caption = 'transparency'
        TabOrder = 5
        OnClick = chkTransparencyClick
      end
      object chkSetLogo: TCheckBox
        Left = 165
        Top = 123
        Width = 139
        Height = 21
        Caption = 'show logo, e.g.:'
        TabOrder = 6
        OnClick = chkSetLogoClick
      end
      object chkAdjustPixelAspectRatio: TCheckBox
        Left = 165
        Top = 43
        Width = 169
        Height = 21
        Caption = 'adjust pixel aspect ratio'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 7
        OnClick = chkAdjustPixelAspectRatioClick
      end
      object chkBlackMagicDecklink: TCheckBox
        Left = 165
        Top = 2
        Width = 201
        Height = 21
        Caption = 'BlackMagic Decklink output'
        TabOrder = 8
        OnClick = chkBlackMagicDecklinkClick
      end
      object rdgDisplaySelected: TRadioGroup
        Left = 364
        Top = 0
        Width = 770
        Height = 41
        Caption = 'display # selected:'
        Columns = 10
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ItemIndex = 0
        Items.Strings = (
          '0'
          '1'
          '2'
          '3'
          '4'
          '5'
          '6'
          '7'
          '8'
          '9')
        ParentFont = False
        TabOrder = 9
        OnClick = rdgDisplaySelectedClick
      end
      object chkDisplayActive: TCheckBox
        Left = 364
        Top = 49
        Width = 189
        Height = 21
        Caption = 'DISPLAY ACTIVE ->'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 10
        OnClick = chkDisplayActiveClick
      end
      object chkZeroLatency: TCheckBox
        Left = 364
        Top = 118
        Width = 110
        Height = 21
        Caption = 'no latency'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 11
        OnClick = chkZeroLatencyClick
      end
    end
    object tbsClipReencoding: TTabSheet
      Caption = 'reencoding'
      ImageIndex = 6
      object btnSourceVideoClip: TSpeedButton
        Left = 106
        Top = 7
        Width = 181
        Height = 24
        Caption = 'source video clip:'
        Glyph.Data = {
          76010000424D7601000000000000760000002800000020000000100000000100
          0400000000000001000000000000000000001000000010000000000000000000
          800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
          5555555555555555555555555555555555555555555555555555555555555555
          555555555555555555555555555555555555555FFFFFFFFFF555550000000000
          55555577777777775F55500B8B8B8B8B05555775F555555575F550F0B8B8B8B8
          B05557F75F555555575F50BF0B8B8B8B8B0557F575FFFFFFFF7F50FBF0000000
          000557F557777777777550BFBFBFBFB0555557F555555557F55550FBFBFBFBF0
          555557F555555FF7555550BFBFBF00055555575F555577755555550BFBF05555
          55555575FFF75555555555700007555555555557777555555555555555555555
          5555555555555555555555555555555555555555555555555555}
        NumGlyphs = 2
        OnClick = btnSourceVideoClipClick
      end
      object Label75: TLabel
        Left = 103
        Top = 37
        Width = 149
        Height = 13
        Caption = 'file name for the new video clip:'
      end
      object Label45: TLabel
        Left = 1
        Top = 55
        Width = 233
        Height = 13
        Caption = '(extension will be ".wmv" if WMV output enabled)'
      end
      object grbReencodingSettings: TGroupBox
        Left = 591
        Top = 5
        Width = 533
        Height = 154
        Caption = 'reencoding settings'
        TabOrder = 0
        object chkIncludeVideoStream: TCheckBox
          Left = 10
          Top = 48
          Width = 178
          Height = 21
          Caption = 'includes the video stream'
          TabOrder = 0
        end
        object chkIncludeAudioStream: TCheckBox
          Left = 207
          Top = 48
          Width = 178
          Height = 21
          Caption = 'includes the audio stream'
          TabOrder = 1
        end
        object chkUseCurrentVideoCompressor: TCheckBox
          Left = 10
          Top = 73
          Width = 405
          Height = 21
          Caption = 
            'use the current video compressor (selected in the "recording" ta' +
            'b)'
          TabOrder = 2
        end
        object chkUseCurrentAudioCompressor: TCheckBox
          Left = 10
          Top = 98
          Width = 424
          Height = 21
          Caption = 
            'use the current audio compressor (selected in the "recording" ta' +
            'b)'
          TabOrder = 3
        end
        object chkUseFrameGrabber: TCheckBox
          Left = 10
          Top = 123
          Width = 517
          Height = 21
          Caption = 
            'use the frame grabber (allows text overlay, graphics overlay, vi' +
            'deo processing, etc...)'
          TabOrder = 4
        end
        object chkWMVOutput: TCheckBox
          Left = 10
          Top = 22
          Width = 109
          Height = 21
          Caption = 'WMV output'
          TabOrder = 5
        end
      end
      object edtSourceVideoClip: TEdit
        Left = 295
        Top = 7
        Width = 287
        Height = 21
        TabOrder = 1
      end
      object edtDestinationVideoClip: TEdit
        Left = 295
        Top = 42
        Width = 287
        Height = 21
        TabOrder = 2
      end
      object grbStartStopTime: TGroupBox
        Left = 0
        Top = 79
        Width = 582
        Height = 144
        Caption = 
          'START / STOP   (OPTIONAL). Times are expressed in 100ns units, e' +
          '.g. 2 seconds = 20000000'
        TabOrder = 3
        object Label78: TLabel
          Left = 23
          Top = 84
          Width = 185
          Height = 13
          Caption = 'START position (-1 = beginning of clip):'
        end
        object Label79: TLabel
          Left = 63
          Top = 113
          Width = 150
          Height = 13
          Caption = 'STOP position (-1 = end of clip):'
        end
        object Label61: TLabel
          Left = 266
          Top = 30
          Width = 118
          Height = 13
          Caption = 'the TIME (in 100ns units)'
        end
        object Label62: TLabel
          Left = 446
          Top = 30
          Width = 105
          Height = 13
          Caption = 'the FRAME NUMBER'
        end
        object Label63: TLabel
          Left = 418
          Top = 30
          Width = 23
          Height = 16
          Caption = 'OR'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label64: TLabel
          Left = 197
          Top = 30
          Width = 64
          Height = 16
          Caption = 'SPECIFY'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -15
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object edtReencStartTime: TEdit
          Left = 266
          Top = 79
          Width = 149
          Height = 21
          TabOrder = 0
          Text = '-1'
        end
        object edtReencDuration: TEdit
          Left = 266
          Top = 49
          Width = 149
          Height = 21
          Color = clBtnFace
          ReadOnly = True
          TabOrder = 1
        end
        object edtReencStopTime: TEdit
          Left = 266
          Top = 108
          Width = 149
          Height = 21
          TabOrder = 2
          Text = '-1'
        end
        object btnDuration: TButton
          Left = 5
          Top = 52
          Width = 242
          Height = 21
          Caption = 'source duration and/or frame count?'
          TabOrder = 3
          OnClick = btnDurationClick
        end
        object edtReencFrameCount: TEdit
          Left = 463
          Top = 49
          Width = 98
          Height = 21
          Color = clBtnFace
          ReadOnly = True
          TabOrder = 4
        end
        object edtReencStartFrame: TEdit
          Left = 463
          Top = 79
          Width = 98
          Height = 21
          TabOrder = 5
          Text = '-1'
        end
        object edtReencStopFrame: TEdit
          Left = 463
          Top = 108
          Width = 98
          Height = 21
          TabOrder = 6
          Text = '-1'
        end
      end
      object btnStartReencoding: TButton
        Left = 876
        Top = 178
        Width = 100
        Height = 26
        Caption = 'Start'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 4
        OnClick = btnStartReencodingClick
      end
      object btnStopReencoding: TButton
        Left = 985
        Top = 178
        Width = 99
        Height = 26
        Caption = 'Stop'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -15
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 5
        OnClick = btnStopReencodingClick
      end
      object rdgReencodingMethod: TRadioGroup
        Left = 591
        Top = 165
        Width = 227
        Height = 53
        Caption = 'reencoding method'
        Columns = 2
        Items.Strings = (
          'AVI / MPEG '
          'ASF (wmv)')
        TabOrder = 6
      end
    end
  end
  object tbrZoomY: TTrackBar
    Left = 213
    Top = 358
    Width = 17
    Height = 277
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Max = 1
    Orientation = trVertical
    TabOrder = 6
    ThumbLength = 8
    OnChange = tbrZoomYChange
  end
  object tbrZoomX: TTrackBar
    Left = 326
    Top = 358
    Width = 340
    Height = 17
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Max = 1
    TabOrder = 7
    ThumbLength = 8
    OnChange = tbrZoomXChange
  end
  object tbrZoom: TTrackBar
    Left = 302
    Top = 336
    Width = 467
    Height = 24
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Max = 20000
    Min = 1000
    Frequency = 100
    Position = 1000
    TabOrder = 8
    ThumbLength = 12
    OnChange = tbrZoomChange
  end
  object edtIPCameraNTPTime: TEdit
    Left = 4
    Top = 399
    Width = 202
    Height = 21
    Margins.Left = 2
    Margins.Top = 2
    Margins.Right = 2
    Margins.Bottom = 2
    Color = clSilver
    ReadOnly = True
    TabOrder = 9
  end
  object MainMenu1: TMainMenu
    Left = 1272
    Top = 291
    object mnuFile: TMenuItem
      Caption = 'File'
      object mnuExit: TMenuItem
        Caption = 'Exit'
        OnClick = mnuExitClick
      end
    end
    object Options1: TMenuItem
      Caption = 'Options'
      object Resetvideocapturedevicesettings1: TMenuItem
        Caption = 'Reset video capture device settings'
        OnClick = Resetvideocapturedevicesettings1Click
      end
    end
    object mnuAbout: TMenuItem
      Caption = 'About'
      OnClick = mnuAboutClick
    end
  end
end
