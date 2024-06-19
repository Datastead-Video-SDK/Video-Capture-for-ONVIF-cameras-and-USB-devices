object DemoForm: TDemoForm
  Left = 336
  Top = 250
  Caption = 
    'TVideoGrabber demo project: component dynamically created at run' +
    'time'
  ClientHeight = 781
  ClientWidth = 1343
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Position = poDesktopCenter
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
    Width = 1257
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
    object edtURL: TEdit
      Left = 336
      Top = 16
      Width = 913
      Height = 21
      TabOrder = 4
      Text = 'http://74.142.49.38:8000/axis-cgi/mjpg/video.cgi'
    end
  end
end
