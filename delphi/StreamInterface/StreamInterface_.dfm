object Form1: TForm1
  Left = 465
  Top = 146
  Width = 1370
  Height = 942
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -13
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 120
  TextHeight = 16
  object Label1: TLabel
    Left = 848
    Top = 88
    Width = 212
    Height = 16
    Caption = 'exact frame rate, e.g. 30,0: (optional)'
  end
  object Label2: TLabel
    Left = 1104
    Top = 32
    Width = 81
    Height = 16
    Caption = 'stream format'
  end
  object VideoGrabber1: TVideoGrabber
    Left = 264
    Top = 184
    Width = 1073
    Height = 697
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
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
    OnLog = VideoGrabber1Log
    OnReinitializing = VideoGrabber1Reinitializing
    OnStoppingGraph = VideoGrabber1StoppingGraph
  end
  object btnStartPreview: TButton
    Left = 32
    Top = 112
    Width = 97
    Height = 33
    Caption = 'start preview'
    TabOrder = 1
    OnClick = btnStartPreviewClick
  end
  object btnStartMP4Recording: TButton
    Left = 144
    Top = 112
    Width = 137
    Height = 33
    Caption = 'start MP4 recording'
    TabOrder = 2
    OnClick = btnStartMP4RecordingClick
  end
  object btnStop: TButton
    Left = 296
    Top = 112
    Width = 97
    Height = 33
    Caption = 'stop'
    TabOrder = 3
    OnClick = btnStopClick
  end
  object edtDumpFile: TEdit
    Left = 312
    Top = 40
    Width = 433
    Height = 24
    TabOrder = 4
  end
  object btnSelectStreamDump: TButton
    Left = 32
    Top = 40
    Width = 265
    Height = 25
    Caption = 'select the file containing the stream dump'
    TabOrder = 5
    OnClick = btnSelectStreamDumpClick
  end
  object mmoLog: TMemo
    Left = 8
    Top = 184
    Width = 241
    Height = 689
    Lines.Strings = (
      'log:')
    TabOrder = 6
  end
  object chkIsRealTime: TCheckBox
    Left = 848
    Top = 56
    Width = 121
    Height = 25
    Caption = 'realtime stream'
    Checked = True
    State = cbChecked
    TabOrder = 7
  end
  object edtFrameRate: TEdit
    Left = 848
    Top = 112
    Width = 113
    Height = 24
    TabOrder = 8
  end
  object chkOpenURLAsync: TCheckBox
    Left = 848
    Top = 32
    Width = 193
    Height = 25
    Caption = 'open URL asynchronously'
    Checked = True
    State = cbChecked
    TabOrder = 9
  end
  object lstStreamFormat: TListBox
    Left = 1104
    Top = 56
    Width = 153
    Height = 113
    ItemHeight = 16
    Items.Strings = (
      'h264'
      'mjpeg'
      'mpegts'
      'other...')
    TabOrder = 10
  end
  object OpenDialog1: TOpenDialog
    Left = 1296
    Top = 8
  end
end
