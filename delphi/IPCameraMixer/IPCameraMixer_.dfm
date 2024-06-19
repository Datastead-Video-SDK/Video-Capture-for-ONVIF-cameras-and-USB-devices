object Form1: TForm1
  Left = 428
  Top = 146
  Width = 1239
  Height = 750
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -13
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 120
  TextHeight = 16
  object VideoGrabber1: TVideoGrabber
    Left = 40
    Top = 24
    Width = 377
    Height = 265
    Caption = 'VideoGrabber1'
    Color = clBlack
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    Cropping_Zoom = 1
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
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -17
    TextOverlay_Font.Name = 'Arial'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 10
    TextOverlay_HighResFont = True
    TextOverlay_Left = 0
    TextOverlay_Top = 0
    TextOverlay_Right = -1
    TextOverlay_Orientation = to_Horizontal
    TextOverlay_Scrolling = False
    TextOverlay_ScrollingSpeed = 1
    TextOverlay_Shadow = True
    TextOverlay_ShadowColor = clBlack
    TextOverlay_ShadowDirection = cd_Center
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
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
  end
  object VideoGrabber2: TVideoGrabber
    Left = 423
    Top = 24
    Width = 377
    Height = 265
    Caption = 'VideoGrabber1'
    Color = clBlack
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    Cropping_Zoom = 1
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
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -17
    TextOverlay_Font.Name = 'Arial'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 10
    TextOverlay_HighResFont = True
    TextOverlay_Left = 0
    TextOverlay_Top = 0
    TextOverlay_Right = -1
    TextOverlay_Orientation = to_Horizontal
    TextOverlay_Scrolling = False
    TextOverlay_ScrollingSpeed = 1
    TextOverlay_Shadow = True
    TextOverlay_ShadowColor = clBlack
    TextOverlay_ShadowDirection = cd_Center
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
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
  end
  object VideoGrabber3: TVideoGrabber
    Left = 40
    Top = 295
    Width = 377
    Height = 265
    Caption = 'VideoGrabber1'
    Color = clBlack
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    Cropping_Zoom = 1
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
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -17
    TextOverlay_Font.Name = 'Arial'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 10
    TextOverlay_HighResFont = True
    TextOverlay_Left = 0
    TextOverlay_Top = 0
    TextOverlay_Right = -1
    TextOverlay_Orientation = to_Horizontal
    TextOverlay_Scrolling = False
    TextOverlay_ScrollingSpeed = 1
    TextOverlay_Shadow = True
    TextOverlay_ShadowColor = clBlack
    TextOverlay_ShadowDirection = cd_Center
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
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
  end
  object VideoGrabber4: TVideoGrabber
    Left = 423
    Top = 295
    Width = 377
    Height = 265
    Caption = 'VideoGrabber1'
    Color = clBlack
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    Cropping_Zoom = 1
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
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -17
    TextOverlay_Font.Name = 'Arial'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 10
    TextOverlay_HighResFont = True
    TextOverlay_Left = 0
    TextOverlay_Top = 0
    TextOverlay_Right = -1
    TextOverlay_Orientation = to_Horizontal
    TextOverlay_Scrolling = False
    TextOverlay_ScrollingSpeed = 1
    TextOverlay_Shadow = True
    TextOverlay_ShadowColor = clBlack
    TextOverlay_ShadowDirection = cd_Center
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
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
  end
  object VideoGrabber5: TVideoGrabber
    Left = 824
    Top = 424
    Width = 377
    Height = 265
    Caption = 'VideoGrabber1'
    Color = clBlack
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    Cropping_Zoom = 1
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
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Enabled = False
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -17
    TextOverlay_Font.Name = 'Arial'
    TextOverlay_Font.Style = []
    TextOverlay_FontColor = clAqua
    TextOverlay_FontSize = 10
    TextOverlay_HighResFont = True
    TextOverlay_Left = 0
    TextOverlay_Top = 0
    TextOverlay_Right = -1
    TextOverlay_Orientation = to_Horizontal
    TextOverlay_Scrolling = False
    TextOverlay_ScrollingSpeed = 1
    TextOverlay_Shadow = True
    TextOverlay_ShadowColor = clBlack
    TextOverlay_ShadowDirection = cd_Center
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
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
  end
  object btnStartRecording: TButton
    Left = 904
    Top = 48
    Width = 113
    Height = 33
    Caption = 'Start recording'
    TabOrder = 5
    OnClick = btnStartRecordingClick
  end
  object btnStop: TButton
    Left = 1032
    Top = 48
    Width = 89
    Height = 33
    Caption = 'Stop'
    TabOrder = 6
    OnClick = btnStopClick
  end
end
