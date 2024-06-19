object Form1: TForm1
  Left = 424
  Top = 247
  Caption = 'TVideoGrabber frame capture demo'
  ClientHeight = 502
  ClientWidth = 831
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Position = poScreenCenter
  OnCreate = FormCreate
  TextHeight = 13
  object Image1: TImage
    Left = 432
    Top = 144
    Width = 377
    Height = 297
    AutoSize = True
  end
  object GroupBox2: TGroupBox
    Left = 2
    Top = 46
    Width = 479
    Height = 46
    Caption = 'single frame capture'
    TabOrder = 0
    object Button6: TButton
      Left = 72
      Top = 20
      Width = 60
      Height = 17
      Caption = 'to JPEG file'
      TabOrder = 0
      OnClick = Button6Click
    end
    object Button7: TButton
      Left = 136
      Top = 20
      Width = 60
      Height = 17
      Caption = 'to BMP file'
      TabOrder = 1
      OnClick = Button7Click
    end
    object Button4: TButton
      Left = 8
      Top = 20
      Width = 60
      Height = 17
      Caption = 'to TImage'
      TabOrder = 2
      OnClick = Button4Click
    end
    object Edit2: TEdit
      Left = 312
      Top = 17
      Width = 153
      Height = 21
      Enabled = False
      TabOrder = 3
      Text = 'file_name_if_not_auto'
    end
    object CheckBox3: TCheckBox
      Left = 212
      Top = 20
      Width = 89
      Height = 17
      Caption = 'auto file name'
      Checked = True
      State = cbChecked
      TabOrder = 4
      OnClick = CheckBox3Click
    end
  end
  object GroupBox3: TGroupBox
    Left = 2
    Top = 0
    Width = 769
    Height = 46
    Caption = 'video device'
    TabOrder = 1
    object ComboBox1: TComboBox
      Left = 104
      Top = 18
      Width = 233
      Height = 21
      TabOrder = 0
      Text = 'SELECT FIRST A CAPTURE DEVICE'
      OnChange = ComboBox1Change
    end
    object ComboBox2: TComboBox
      Left = 600
      Top = 18
      Width = 105
      Height = 21
      TabOrder = 1
      OnChange = ComboBox2Change
    end
    object ComboBox4: TComboBox
      Left = 504
      Top = 18
      Width = 89
      Height = 21
      TabOrder = 2
      OnChange = ComboBox4Change
    end
    object ComboBox5: TComboBox
      Left = 408
      Top = 18
      Width = 89
      Height = 21
      TabOrder = 3
      OnChange = ComboBox5Change
    end
    object Button10: TButton
      Left = 712
      Top = 20
      Width = 49
      Height = 17
      Caption = 'tv tuner'
      TabOrder = 4
      OnClick = Button10Click
    end
    object Button9: TButton
      Left = 352
      Top = 20
      Width = 49
      Height = 17
      Caption = 'device'
      TabOrder = 5
      OnClick = Button9Click
    end
    object Button3: TButton
      Left = 8
      Top = 20
      Width = 40
      Height = 17
      Caption = 'Start'
      TabOrder = 6
      OnClick = Button3Click
    end
    object Button8: TButton
      Left = 56
      Top = 20
      Width = 40
      Height = 17
      Caption = 'Stop'
      TabOrder = 7
      OnClick = Button8Click
    end
  end
  object VideoGrabber1: TVideoGrabber
    Left = 8
    Top = 144
    Width = 385
    Height = 297
    Color = clBlack
    ASFMediaServerPublishingPoint = 'http://YourWindowsMediaServer/YourPublishingPoint'
    ASFVideoWidth = 320
    AspectRatioToUse = -1.000000000000000000
    AudioCompressor = 0
    AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
    AutoFilePrefix = 'vg'
    CaptureFileExt = 'avi'
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
    OnFrameCaptureCompleted = VideoGrabber1FrameCaptureCompleted
    OnResizeVideo = VideoGrabber1ResizeVideo
    OnVideoDeviceSelected = VideoGrabber1VideoDeviceSelected
  end
  object GroupBox1: TGroupBox
    Left = 2
    Top = 92
    Width = 479
    Height = 46
    Caption = 'automated frame capture'
    TabOrder = 3
    object Label2: TLabel
      Left = 400
      Top = 21
      Width = 37
      Height = 13
      Caption = 'interval:'
    end
    object Label1: TLabel
      Left = 272
      Top = 13
      Width = 84
      Height = 13
      Caption = 'number of frames:'
    end
    object Label4: TLabel
      Left = 284
      Top = 26
      Width = 70
      Height = 13
      Caption = '(0 = don'#39't stop)'
    end
    object Button2: TButton
      Left = 200
      Top = 20
      Width = 60
      Height = 17
      Caption = 'stop'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 0
      OnClick = Button2Click
    end
    object Button1: TButton
      Left = 72
      Top = 20
      Width = 60
      Height = 17
      Caption = 'to JPEG file'
      TabOrder = 1
      OnClick = Button1Click
    end
    object Button5: TButton
      Left = 136
      Top = 20
      Width = 60
      Height = 17
      Caption = 'to BMP file'
      TabOrder = 2
      OnClick = Button5Click
    end
    object Button11: TButton
      Left = 8
      Top = 20
      Width = 60
      Height = 17
      Caption = 'to TImage'
      TabOrder = 3
      OnClick = Button11Click
    end
    object Edit3: TEdit
      Left = 440
      Top = 17
      Width = 30
      Height = 21
      TabOrder = 4
      Text = '0'
      OnChange = Edit3Change
    end
    object Edit1: TEdit
      Left = 360
      Top = 17
      Width = 30
      Height = 21
      TabOrder = 5
      Text = '4'
      OnChange = Edit1Change
    end
  end
  object Memo1: TMemo
    Left = 486
    Top = 51
    Width = 285
    Height = 86
    Color = clSilver
    Lines.Strings = (
      'Memo1')
    TabOrder = 4
  end
end
