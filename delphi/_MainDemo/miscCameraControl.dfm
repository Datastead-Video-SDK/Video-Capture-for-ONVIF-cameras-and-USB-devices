object frmCameraControl: TfrmCameraControl
  Left = 413
  Top = 334
  Width = 441
  Height = 327
  Caption = 'Camera Control settings'
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
    Left = 80
    Top = 6
    Width = 18
    Height = 13
    Caption = 'pan'
  end
  object Label2: TLabel
    Left = 138
    Top = 6
    Width = 10
    Height = 13
    Caption = 'tilt'
  end
  object Label3: TLabel
    Left = 192
    Top = 6
    Width = 13
    Height = 13
    Caption = 'roll'
  end
  object Label4: TLabel
    Left = 24
    Top = 6
    Width = 25
    Height = 13
    Caption = 'zoom'
  end
  object Label5: TLabel
    Left = 232
    Top = 6
    Width = 43
    Height = 13
    Caption = 'exposure'
  end
  object Label6: TLabel
    Left = 304
    Top = 6
    Width = 12
    Height = 13
    Caption = 'iris'
  end
  object Label7: TLabel
    Left = 352
    Top = 6
    Width = 26
    Height = 13
    Caption = 'focus'
  end
  object tbrTilt: TTrackBar
    Left = 125
    Top = 20
    Width = 40
    Height = 185
    Orientation = trVertical
    Frequency = 1
    Position = 0
    SelEnd = 0
    SelStart = 0
    TabOrder = 0
    ThumbLength = 18
    TickMarks = tmBoth
    TickStyle = tsAuto
    OnChange = OnSetValue
  end
  object tbrPan: TTrackBar
    Left = 71
    Top = 20
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
  object tbrRoll: TTrackBar
    Left = 180
    Top = 20
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
  object tbrZoom: TTrackBar
    Left = 16
    Top = 20
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
  object tbrExposure: TTrackBar
    Left = 235
    Top = 20
    Width = 40
    Height = 170
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
  object tbrIris: TTrackBar
    Left = 289
    Top = 20
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
  object tbrFocus: TTrackBar
    Left = 344
    Top = 20
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
  object btnClose: TButton
    Left = 164
    Top = 258
    Width = 73
    Height = 23
    Caption = 'Close'
    TabOrder = 7
    OnClick = btnCloseClick
  end
  object chkZoom: TCheckBox
    Left = 20
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 8
    OnClick = OnSetValue
  end
  object chkPan: TCheckBox
    Left = 76
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 9
    OnClick = OnSetValue
  end
  object chkTilt: TCheckBox
    Left = 130
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 10
    OnClick = OnSetValue
  end
  object chkRoll: TCheckBox
    Left = 186
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 11
    OnClick = OnSetValue
  end
  object chkExposure: TCheckBox
    Left = 240
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 12
    OnClick = OnSetValue
  end
  object chkIris: TCheckBox
    Left = 296
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 13
    OnClick = OnSetValue
  end
  object chkFocus: TCheckBox
    Left = 350
    Top = 230
    Width = 41
    Height = 17
    Caption = 'auto'
    TabOrder = 14
    OnClick = OnSetValue
  end
  object btnZoom: TButton
    Left = 16
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 15
    OnClick = OnSetDefault
  end
  object btnPan: TButton
    Left = 71
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 16
    OnClick = OnSetDefault
  end
  object btnTilt: TButton
    Left = 125
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 17
    OnClick = OnSetDefault
  end
  object btnRoll: TButton
    Left = 180
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 18
    OnClick = OnSetDefault
  end
  object btnExposure: TButton
    Left = 235
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 19
    OnClick = OnSetDefault
  end
  object btnIris: TButton
    Left = 289
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 20
    OnClick = OnSetDefault
  end
  object btnFocus: TButton
    Left = 344
    Top = 208
    Width = 41
    Height = 17
    Caption = 'default'
    TabOrder = 21
    OnClick = OnSetDefault
  end
  object edtExposure: TEdit
    Left = 235
    Top = 186
    Width = 41
    Height = 21
    Color = clBtnFace
    ReadOnly = True
    TabOrder = 22
  end
end
