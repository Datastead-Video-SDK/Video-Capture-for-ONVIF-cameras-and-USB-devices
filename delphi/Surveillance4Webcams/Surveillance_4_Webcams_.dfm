object frmMaster: TfrmMaster
  Left = 206
  Top = 166
  Caption = 'Master component'
  ClientHeight = 705
  ClientWidth = 1050
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OnShow = FormShow
  TextHeight = 13
  object btnStartMaster: TButton
    Left = 8
    Top = 6
    Width = 81
    Height = 19
    Caption = 'Preview all'
    TabOrder = 0
    OnClick = btnStartMasterClick
  end
  object btnStopMaster: TButton
    Left = 8
    Top = 38
    Width = 81
    Height = 19
    Caption = 'Stop all'
    TabOrder = 1
    OnClick = btnStopMasterClick
  end
  object mmoLog: TMemo
    Left = 104
    Top = 6
    Width = 513
    Height = 106
    Lines.Strings = (
      'log:')
    TabOrder = 2
  end
end
