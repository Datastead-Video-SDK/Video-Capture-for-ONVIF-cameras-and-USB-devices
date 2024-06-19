object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 782
  ClientWidth = 1480
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = 'Segoe UI'
  Font.Style = []
  PixelsPerInch = 96
  TextHeight = 15
  object Label1: TLabel
    Left = 136
    Top = 107
    Width = 66
    Height = 15
    Caption = 'source clip 1'
  end
  object Label2: TLabel
    Left = 136
    Top = 147
    Width = 66
    Height = 15
    Caption = 'source clip 2'
  end
  object Label3: TLabel
    Left = 121
    Top = 187
    Width = 81
    Height = 15
    Caption = 'destination clip'
  end
  object Label4: TLabel
    Left = 816
    Top = 56
    Width = 522
    Height = 15
    Caption = 
      'path to the folder containing the "x86" and "x64" subfolders of ' +
      'the Datastead Multipurpose Encoder'
  end
  object Label5: TLabel
    Left = 816
    Top = 77
    Width = 406
    Height = 15
    Caption = 
      '(not required if you installed the Multipurpose Encoder with the' +
      ' .exe installer)'
  end
  object Label6: TLabel
    Left = 144
    Top = 228
    Width = 58
    Height = 15
    Caption = 'bitrate (kb)'
  end
  object Label7: TLabel
    Left = 87
    Top = 67
    Width = 115
    Height = 15
    Caption = 'Multipurpose binaries'
  end
  object edtSourceClip1: TEdit
    Left = 208
    Top = 104
    Width = 593
    Height = 23
    TabOrder = 0
    Text = 'c:\folder\sourceclip1.mp4'
  end
  object edtSourceClip2: TEdit
    Left = 208
    Top = 144
    Width = 593
    Height = 23
    TabOrder = 1
    Text = 'c:\folder\sourceclip2.mp4'
  end
  object edtDestinationClip: TEdit
    Left = 208
    Top = 184
    Width = 593
    Height = 23
    TabOrder = 2
    Text = 'c:\folder\destinationclip.mp4'
  end
  object mmoLog: TMemo
    Left = 704
    Top = 309
    Width = 737
    Height = 361
    Lines.Strings = (
      'Log:')
    TabOrder = 3
  end
  object btnStart: TButton
    Left = 208
    Top = 254
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 4
    OnClick = btnStartClick
  end
  object edtMultipurposeFolder: TEdit
    Left = 208
    Top = 64
    Width = 593
    Height = 23
    TabOrder = 5
    Text = 'c:\MultipurposeBinaries\'
  end
  object VideoGrabber1: TVideoGrabber
    Left = 112
    Top = 309
    Width = 577
    Height = 361
    Caption = 'VideoGrabber1'
    Color = clBlack
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
    OnLog = VideoGrabber1Log
    OnRecordingStarted = VideoGrabber1RecordingStarted
    OnReencodingCompleted = VideoGrabber1ReencodingCompleted
    OnReencodingProgress = VideoGrabber1ReencodingProgress
  end
  object btnStop: TButton
    Left = 296
    Top = 254
    Width = 75
    Height = 25
    Caption = 'Stop'
    TabOrder = 7
    OnClick = btnStopClick
  end
  object edtBitrateKb: TEdit
    Left = 208
    Top = 225
    Width = 49
    Height = 23
    TabOrder = 8
    Text = '8000'
  end
end
