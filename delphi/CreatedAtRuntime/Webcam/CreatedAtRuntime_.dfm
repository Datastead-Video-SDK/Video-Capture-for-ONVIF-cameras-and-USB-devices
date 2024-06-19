object DemoForm: TDemoForm
  Left = 336
  Top = 250
  Caption = 
    'TVideoGrabber demo project: component dynamically created at run' +
    'time'
  ClientHeight = 667
  ClientWidth = 1066
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Position = poDesktopCenter
  OnCreate = FormCreate
  TextHeight = 13
  object imgCapturedFrame: TImage
    Left = 392
    Top = 56
    Width = 385
    Height = 313
  end
  object GroupBox1: TGroupBox
    Left = 8
    Top = 0
    Width = 769
    Height = 47
    Caption = 'TVideoGrabber component'
    TabOrder = 0
    object btnCreate: TButton
      Left = 13
      Top = 18
      Width = 68
      Height = 19
      Caption = '1. create'
      TabOrder = 0
      OnClick = btnCreateClick
    end
    object btnCapture: TButton
      Left = 88
      Top = 18
      Width = 89
      Height = 19
      Caption = '2. capture frames'
      TabOrder = 1
      OnClick = btnCaptureClick
    end
    object btnDestroy: TButton
      Left = 184
      Top = 18
      Width = 68
      Height = 19
      Caption = '3. destroy'
      TabOrder = 2
      OnClick = btnDestroyClick
    end
    object chkVisible: TCheckBox
      Left = 264
      Top = 19
      Width = 49
      Height = 17
      Caption = 'visible'
      Checked = True
      State = cbChecked
      TabOrder = 3
      OnClick = chkVisibleClick
    end
    object cmbVideoDevices: TComboBox
      Left = 320
      Top = 17
      Width = 201
      Height = 21
      TabOrder = 4
      Text = 'video device'
      OnChange = cmbVideoDevicesChange
    end
    object cmbVideoSizes: TComboBox
      Left = 528
      Top = 17
      Width = 81
      Height = 21
      TabOrder = 5
      Text = 'video size'
      OnChange = cmbVideoSizesChange
    end
    object cmbVideoInputs: TComboBox
      Left = 616
      Top = 17
      Width = 81
      Height = 21
      TabOrder = 6
      Text = 'video input'
      OnChange = cmbVideoInputsChange
    end
    object btnTVTuner: TButton
      Left = 704
      Top = 18
      Width = 57
      Height = 19
      Caption = 'TV tuner'
      TabOrder = 7
      OnClick = btnTVTunerClick
    end
  end
end
