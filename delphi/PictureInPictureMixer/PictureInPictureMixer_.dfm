object Form1: TForm1
  Left = 405
  Top = 242
  Width = 935
  Height = 812
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 388
    Width = 64
    Height = 13
    Caption = 'SOURCE B'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label3: TLabel
    Left = 112
    Top = 84
    Width = 177
    Height = 13
    Caption = 'Left          Top         Width        Height'
  end
  object Label4: TLabel
    Left = 112
    Top = 465
    Width = 177
    Height = 13
    Caption = 'Left          Top         Width        Height'
  end
  object Label2: TLabel
    Left = 8
    Top = 6
    Width = 64
    Height = 13
    Caption = 'SOURCE A'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label8: TLabel
    Left = 208
    Top = 28
    Width = 19
    Height = 13
    Caption = 'OR'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object btnOpenClipA: TSpeedButton
    Left = 232
    Top = 24
    Width = 137
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
    OnClick = btnOpenClipAClick
  end
  object Label9: TLabel
    Left = 200
    Top = 409
    Width = 19
    Height = 13
    Caption = 'OR'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object btnOpenClipB: TSpeedButton
    Left = 224
    Top = 405
    Width = 137
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
    OnClick = btnOpenClipBClick
  end
  object VideoGrabberSrc1: TVideoGrabber
    Left = 16
    Top = 137
    Width = 329
    Height = 248
    Color = clGray
    FullRepaint = False
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFilePrefix = 'vg'
    DualDisplay_Left = 400
    DualDisplay_Top = 20
    Cropping_Zoom = 1
    LicenseString = 'N/A'
    MotionDetector_Grid = 
      '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
      '5 5555555555 5555555555 5555555555 5555555555 '
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -16
    TextOverlay_Font.Name = 'MS Sans Serif'
    TextOverlay_Font.Style = []
    TextOverlay_String = 
      '_Selector=1 to see a demo with variables.'
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
    OnLog = VideoGrabberLog
    OnVideoDeviceSelected = VideoGrabberSrc1VideoDeviceSelected
  end
  object btnSrc1Start: TButton
    Left = 8
    Top = 50
    Width = 81
    Height = 19
    Caption = 'start preview'
    TabOrder = 1
    OnClick = btnSrc1StartClick
  end
  object btnSrc2Start: TButton
    Left = 8
    Top = 432
    Width = 81
    Height = 19
    Caption = 'start preview'
    TabOrder = 2
    OnClick = btnSrc2StartClick
  end
  object VideoGrabberSrc2: TVideoGrabber
    Tag = 1
    Left = 8
    Top = 508
    Width = 329
    Height = 257
    Color = clGray
    FullRepaint = False
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFilePrefix = 'vg'
    DualDisplay_Left = 400
    DualDisplay_Top = 20
    Cropping_Zoom = 1
    LicenseString = 'N/A'
    MotionDetector_Grid = 
      '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
      '5 5555555555 5555555555 5555555555 5555555555 '
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -16
    TextOverlay_Font.Name = 'MS Sans Serif'
    TextOverlay_Font.Style = []
    TextOverlay_String = 
      '_Selector=1 to see a demo with variables.'
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
    OnLog = VideoGrabberLog
    OnVideoDeviceSelected = VideoGrabberSrc2VideoDeviceSelected
  end
  object cboVideoDevices1: TComboBox
    Left = 8
    Top = 24
    Width = 193
    Height = 21
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ItemHeight = 13
    ParentFont = False
    TabOrder = 4
    Text = 'SELECT THE FIRST CAPTURE DEVICE'
    OnChange = cboVideoDevices1Change
  end
  object btnSrc2Stop: TButton
    Left = 95
    Top = 432
    Width = 73
    Height = 19
    Caption = 'stop'
    TabOrder = 5
    OnClick = btnSrc2StopClick
  end
  object btnSrc1Stop: TButton
    Left = 96
    Top = 50
    Width = 73
    Height = 19
    Caption = 'stop'
    TabOrder = 6
    OnClick = btnSrc1StopClick
  end
  object cboVideoDevices2: TComboBox
    Left = 8
    Top = 405
    Width = 185
    Height = 21
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ItemHeight = 13
    ParentFont = False
    TabOrder = 7
    Text = 'SELECT THE SECOND CAPTURE DEVICE'
    OnChange = cboVideoDevices2Change
  end
  object GroupBox1: TGroupBox
    Left = 384
    Top = 16
    Width = 521
    Height = 107
    TabOrder = 8
    object Label5: TLabel
      Left = 382
      Top = 52
      Width = 28
      Height = 13
      Caption = 'width:'
    end
    object Label6: TLabel
      Left = 438
      Top = 52
      Width = 32
      Height = 13
      Caption = 'height:'
    end
    object Label7: TLabel
      Left = 383
      Top = 6
      Width = 80
      Height = 13
      Caption = 'output frame rate'
    end
    object btnDestStart: TButton
      Left = 19
      Top = 25
      Width = 73
      Height = 21
      Caption = 'start preview'
      TabOrder = 0
      OnClick = btnDestStartClick
    end
    object edtDestWidth: TEdit
      Left = 385
      Top = 67
      Width = 49
      Height = 21
      TabOrder = 1
      Text = '320'
    end
    object edtDestHeight: TEdit
      Left = 440
      Top = 68
      Width = 49
      Height = 21
      TabOrder = 2
      Text = '240'
    end
    object btnSizeOk: TButton
      Left = 495
      Top = 67
      Width = 17
      Height = 21
      Caption = 'ok'
      TabOrder = 3
      OnClick = btnSizeOkClick
    end
    object btnStartRecording: TButton
      Left = 98
      Top = 25
      Width = 73
      Height = 21
      Caption = 'start recording'
      TabOrder = 4
      OnClick = btnStartRecordingClick
    end
    object Button2: TButton
      Left = 19
      Top = 55
      Width = 233
      Height = 29
      Caption = 'stop'
      TabOrder = 5
      OnClick = btnDestStopClick
    end
    object edtOutputFrameRate: TEdit
      Left = 383
      Top = 25
      Width = 41
      Height = 21
      TabOrder = 6
      Text = '0'
    end
    object btnFrameRateOk: TButton
      Left = 430
      Top = 25
      Width = 17
      Height = 21
      Caption = 'ok'
      TabOrder = 7
      OnClick = btnFrameRateOkClick
    end
    object btnPlayRecorded: TButton
      Left = 177
      Top = 25
      Width = 73
      Height = 21
      Caption = 'play recorded'
      TabOrder = 8
      OnClick = btnPlayRecordedClick
    end
  end
  object VideoGrabberMixer: TVideoGrabber
    Left = 384
    Top = 129
    Width = 521
    Height = 384
    Color = clGray
    FullRepaint = False
    AspectRatioToUse = -1
    AudioCompressor = 0
    AutoFilePrefix = 'vg'
    DualDisplay_Left = 400
    DualDisplay_Top = 20
    Cropping_Zoom = 1
    LicenseString = 'N/A'
    MotionDetector_Grid = 
      '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
      '5 5555555555 5555555555 5555555555 5555555555 '
    PlayerSpeedRatio = 1
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -16
    TextOverlay_Font.Name = 'MS Sans Serif'
    TextOverlay_Font.Style = []
    TextOverlay_String = 
      '_Selector=1 to see a demo with variables.'
    VideoCompression_Quality = 1
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.5
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
    OnLog = VideoGrabberLog
    OnPlayerOpened = VideoGrabberMixerPlayerOpened
    OnPreviewStarted = VideoGrabberMixerPreviewStarted
    OnRecordingStarted = VideoGrabberMixerRecordingStarted
  end
  object ChkSendToMixer1: TCheckBox
    Left = 8
    Top = 76
    Width = 97
    Height = 17
    Caption = 'send to mixer'
    Checked = True
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    State = cbChecked
    TabOrder = 10
    OnClick = ChkSendToMixer1Click
  end
  object mmoLog: TMemo
    Left = 384
    Top = 529
    Width = 521
    Height = 232
    TabOrder = 11
  end
  object ChkSendToMixer2: TCheckBox
    Left = 8
    Top = 458
    Width = 97
    Height = 17
    Caption = 'send to mixer'
    Checked = True
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    State = cbChecked
    TabOrder = 12
    OnClick = ChkSendToMixer2Click
  end
  object chkPipA: TCheckBox
    Left = 8
    Top = 104
    Width = 104
    Height = 17
    Caption = 'Picture In Picture'
    TabOrder = 13
    OnClick = SetPipA
  end
  object edtLeftA: TEdit
    Left = 112
    Top = 102
    Width = 41
    Height = 21
    TabOrder = 14
    Text = '10'
    OnChange = SetPipA
  end
  object edtTopA: TEdit
    Left = 159
    Top = 102
    Width = 41
    Height = 21
    TabOrder = 15
    Text = '10'
    OnChange = SetPipA
  end
  object edtWidthA: TEdit
    Left = 206
    Top = 102
    Width = 41
    Height = 21
    TabOrder = 16
    Text = '80'
    OnChange = SetPipA
  end
  object edtHeightA: TEdit
    Left = 253
    Top = 102
    Width = 41
    Height = 21
    TabOrder = 17
    Text = '60'
    OnChange = SetPipA
  end
  object chkPipB: TCheckBox
    Left = 8
    Top = 482
    Width = 104
    Height = 17
    Caption = 'Picture In Picture'
    Checked = True
    State = cbChecked
    TabOrder = 18
    OnClick = SetPipB
  end
  object edtLeftB: TEdit
    Left = 112
    Top = 480
    Width = 41
    Height = 21
    TabOrder = 19
    Text = '20'
    OnChange = SetPipB
  end
  object edtTopB: TEdit
    Left = 159
    Top = 480
    Width = 41
    Height = 21
    TabOrder = 20
    Text = '20'
    OnChange = SetPipB
  end
  object edtWidthB: TEdit
    Left = 206
    Top = 480
    Width = 41
    Height = 21
    TabOrder = 21
    Text = '160'
    OnChange = SetPipB
  end
  object edtHeightB: TEdit
    Left = 253
    Top = 480
    Width = 41
    Height = 21
    TabOrder = 22
    Text = '120'
    OnChange = SetPipB
  end
  object btnMoveToTop: TButton
    Tag = 1
    Left = 304
    Top = 104
    Width = 66
    Height = 17
    Caption = 'move to top'
    TabOrder = 23
    OnClick = SetPipA
  end
  object Button1: TButton
    Tag = 1
    Left = 296
    Top = 482
    Width = 66
    Height = 17
    Caption = 'move to top'
    TabOrder = 24
    OnClick = SetPipB
  end
  object btnPlayClipA: TButton
    Left = 232
    Top = 50
    Width = 65
    Height = 19
    Caption = 'play'
    TabOrder = 25
    OnClick = btnPlayClipAClick
  end
  object btnStopClipA: TButton
    Left = 304
    Top = 50
    Width = 65
    Height = 19
    Caption = 'stop'
    TabOrder = 26
    OnClick = btnStopClipAClick
  end
  object btnPlayClipB: TButton
    Left = 224
    Top = 432
    Width = 65
    Height = 19
    Caption = 'play'
    TabOrder = 27
    OnClick = btnPlayClipBClick
  end
  object btnStopClipB: TButton
    Left = 296
    Top = 432
    Width = 57
    Height = 19
    Caption = 'stop'
    TabOrder = 28
    OnClick = btnStopClipBClick
  end
  object OpenDialog: TOpenDialog
    Left = 344
    Top = 128
  end
end
