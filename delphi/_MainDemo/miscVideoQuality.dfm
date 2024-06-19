object frmVideoQuality: TfrmVideoQuality
  Left = 413
  Top = 334
  Width = 615
  Height = 348
  Caption = 'Video quality settings'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 16
    Width = 48
    Height = 13
    Caption = 'brightness'
  end
  object Label2: TLabel
    Left = 72
    Top = 16
    Width = 38
    Height = 13
    Caption = 'contrast'
  end
  object Label3: TLabel
    Left = 144
    Top = 16
    Width = 18
    Height = 13
    Caption = 'hue'
  end
  object Label4: TLabel
    Left = 184
    Top = 16
    Width = 46
    Height = 13
    Caption = 'saturation'
  end
  object Label5: TLabel
    Left = 240
    Top = 16
    Width = 48
    Height = 13
    Caption = 'sharpness'
  end
  object Label6: TLabel
    Left = 307
    Top = 16
    Width = 34
    Height = 13
    Caption = 'gamma'
  end
  object Label7: TLabel
    Left = 357
    Top = 16
    Width = 45
    Height = 13
    Caption = 'white bal.'
  end
  object Label8: TLabel
    Left = 494
    Top = 16
    Width = 20
    Height = 13
    Caption = 'gain'
  end
  object Label9: TLabel
    Left = 408
    Top = 16
    Width = 75
    Height = 13
    Caption = 'backlight comp.'
  end
  object Label10: TLabel
    Left = 529
    Top = 16
    Width = 58
    Height = 13
    Caption = 'color enable'
  end
  object btnClose: TButton
    Left = 264
    Top = 279
    Width = 73
    Height = 23
    Caption = 'Close'
    TabOrder = 0
    OnClick = btnCloseClick
  end
  object tbrHue: TTrackBar
    Left = 132
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 1
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrContrast: TTrackBar
    Left = 74
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 2
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrSaturation: TTrackBar
    Left = 191
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 3
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrBrightness: TTrackBar
    Left = 16
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 4
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrSharpness: TTrackBar
    Left = 249
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 5
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrGamma: TTrackBar
    Left = 308
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 6
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrWhiteBalance: TTrackBar
    Left = 366
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 7
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object chkBrightness: TCheckBox
    Left = 16
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 8
    OnClick = OnSetValue
  end
  object chkContrast: TCheckBox
    Left = 74
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 9
    OnClick = OnSetValue
  end
  object chkHue: TCheckBox
    Left = 133
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 10
    OnClick = OnSetValue
  end
  object chkSaturation: TCheckBox
    Left = 192
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 11
    OnClick = OnSetValue
  end
  object chkSharpness: TCheckBox
    Left = 251
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 12
    OnClick = OnSetValue
  end
  object chkGamma: TCheckBox
    Left = 310
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 13
    OnClick = OnSetValue
  end
  object chkWhiteBalance: TCheckBox
    Left = 369
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 14
    OnClick = OnSetValue
  end
  object btnBrightness: TButton
    Left = 16
    Top = 223
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 15
    OnClick = OnSetDefault
  end
  object btnContrast: TButton
    Left = 74
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 16
    OnClick = OnSetDefault
  end
  object btnHue: TButton
    Left = 133
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 17
    OnClick = OnSetDefault
  end
  object btnSaturation: TButton
    Left = 192
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 18
    OnClick = OnSetDefault
  end
  object btnSharpness: TButton
    Left = 251
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 19
    OnClick = OnSetDefault
  end
  object btnGamma: TButton
    Left = 310
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 20
    OnClick = OnSetDefault
  end
  object btnWhiteBalance: TButton
    Left = 369
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 21
    OnClick = OnSetDefault
  end
  object tbrGain: TTrackBar
    Left = 483
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 22
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object btnGain: TButton
    Left = 487
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 23
    OnClick = OnSetDefault
  end
  object chkGain: TCheckBox
    Left = 487
    Top = 247
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 24
    OnClick = OnSetValue
  end
  object tbrBacklight: TTrackBar
    Left = 425
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 25
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object btnBacklight: TButton
    Left = 428
    Top = 224
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 26
    OnClick = OnSetDefault
  end
  object chkBacklight: TCheckBox
    Left = 428
    Top = 247
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 27
    OnClick = OnSetValue
  end
  object tbrColorEnable: TTrackBar
    Left = 542
    Top = 35
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 28
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object btnColorEnable: TButton
    Left = 546
    Top = 223
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 29
    OnClick = OnSetDefault
  end
  object chkColorEnable: TCheckBox
    Left = 546
    Top = 246
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 30
    OnClick = OnSetValue
  end
end
