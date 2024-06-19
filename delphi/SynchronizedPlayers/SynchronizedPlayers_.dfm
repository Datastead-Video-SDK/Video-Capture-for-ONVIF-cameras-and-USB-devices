object Form1: TForm1
  Left = 512
  Top = 145
  Caption = 'TVideoGrabber synchronized players demo'
  ClientHeight = 692
  ClientWidth = 805
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Position = poScreenCenter
  TextHeight = 13
  object btnPlayerOpenFile: TSpeedButton
    Left = 8
    Top = 9
    Width = 129
    Height = 21
    Caption = 'Choose a video clip'
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
  object btnPause: TSpeedButton
    Left = 367
    Top = 40
    Width = 36
    Height = 17
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
    OnClick = btnPauseClick
  end
  object btnStop: TSpeedButton
    Left = 322
    Top = 40
    Width = 36
    Height = 17
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
    OnClick = btnStopClick
  end
  object btnPlay: TSpeedButton
    Left = 412
    Top = 40
    Width = 36
    Height = 17
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
    OnClick = btnPlayClick
  end
  object edtFileName: TEdit
    Left = 144
    Top = 8
    Width = 425
    Height = 21
    TabOrder = 0
    Text = 'c:\MyVideoClip.avi'
  end
  object VideoGrabber2: TVideoGrabber
    Left = 408
    Top = 88
    Width = 369
    Height = 281
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
    PlayerTrackBar = TrackBar2
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
  end
  object VideoGrabber3: TVideoGrabber
    Left = 8
    Top = 408
    Width = 369
    Height = 281
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
    PlayerTrackBar = TrackBar3
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
  end
  object VideoGrabber4: TVideoGrabber
    Left = 408
    Top = 408
    Width = 369
    Height = 281
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
    PlayerTrackBar = TrackBar4
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
  end
  object VideoGrabber1: TVideoGrabber
    Left = 8
    Top = 88
    Width = 369
    Height = 281
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
    PlayerTrackBar = TrackBar1
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
  end
  object btnOpen: TButton
    Left = 144
    Top = 40
    Width = 81
    Height = 17
    Caption = 'Open'
    TabOrder = 5
    OnClick = btnOpenClick
  end
  object btnClose: TButton
    Left = 232
    Top = 40
    Width = 73
    Height = 17
    Caption = 'Close'
    TabOrder = 6
    OnClick = btnCloseClick
  end
  object TrackBar1: TTrackBar
    Left = 0
    Top = 64
    Width = 337
    Height = 17
    Max = 1
    Min = 1
    PageSize = 1
    Position = 1
    TabOrder = 7
    ThumbLength = 14
  end
  object TrackBar2: TTrackBar
    Left = 400
    Top = 64
    Width = 337
    Height = 17
    Max = 1
    Min = 1
    PageSize = 1
    Position = 1
    TabOrder = 8
    ThumbLength = 14
  end
  object TrackBar3: TTrackBar
    Left = 0
    Top = 384
    Width = 337
    Height = 17
    Max = 1
    Min = 1
    PageSize = 1
    Position = 1
    TabOrder = 9
    ThumbLength = 14
  end
  object TrackBar4: TTrackBar
    Left = 400
    Top = 384
    Width = 337
    Height = 17
    Max = 1
    Min = 1
    PageSize = 1
    Position = 1
    TabOrder = 10
    ThumbLength = 14
  end
  object chkSync1: TCheckBox
    Left = 336
    Top = 64
    Width = 41
    Height = 17
    Caption = 'sync'
    Checked = True
    State = cbChecked
    TabOrder = 11
    OnClick = chkSync1Click
  end
  object chkSync2: TCheckBox
    Left = 736
    Top = 72
    Width = 41
    Height = 17
    Caption = 'sync'
    Checked = True
    State = cbChecked
    TabOrder = 12
    OnClick = chkSync2Click
  end
  object chkSync3: TCheckBox
    Left = 336
    Top = 384
    Width = 41
    Height = 17
    Caption = 'sync'
    Checked = True
    State = cbChecked
    TabOrder = 13
    OnClick = chkSync3Click
  end
  object chkSync4: TCheckBox
    Left = 736
    Top = 384
    Width = 41
    Height = 17
    Caption = 'sync'
    Checked = True
    State = cbChecked
    TabOrder = 14
    OnClick = chkSync4Click
  end
  object dlgOpen: TOpenDialog
    Left = 9
    Top = 32
  end
end
