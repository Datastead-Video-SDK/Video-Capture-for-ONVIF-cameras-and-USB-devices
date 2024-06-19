unit miscVideoQuality;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, VidGrab;

type
  TSettingGroup = record
     tbrValue: TTrackbar;
     chkAuto: TCheckBox;
     btnDefault: TButton;
  end;

  TfrmVideoQuality = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    btnClose: TButton;
    tbrHue: TTrackBar;
    tbrContrast: TTrackBar;
    tbrSaturation: TTrackBar;
    tbrBrightness: TTrackBar;
    tbrSharpness: TTrackBar;
    tbrGamma: TTrackBar;
    tbrWhiteBalance: TTrackBar;
    chkBrightness: TCheckBox;
    chkContrast: TCheckBox;
    chkHue: TCheckBox;
    chkSaturation: TCheckBox;
    chkSharpness: TCheckBox;
    chkGamma: TCheckBox;
    chkWhiteBalance: TCheckBox;
    btnBrightness: TButton;
    btnContrast: TButton;
    btnHue: TButton;
    btnSaturation: TButton;
    btnSharpness: TButton;
    btnGamma: TButton;
    btnWhiteBalance: TButton;
    tbrGain: TTrackBar;
    btnGain: TButton;
    chkGain: TCheckBox;
    Label9: TLabel;
    tbrBacklight: TTrackBar;
    btnBacklight: TButton;
    chkBacklight: TCheckBox;
    Label10: TLabel;
    tbrColorEnable: TTrackBar;
    btnColorEnable: TButton;
    chkColorEnable: TCheckBox;
    procedure btnCloseClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure OnSetValue (Sender: TObject);
    procedure OnSetDefault (Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
     FSettingGroup: array[low(TVideoQuality)..high(TVideoQuality)] of TSettingGroup;
     FInitializing: Boolean;
     procedure InitTrackBar (chkAuto: TCheckBox; btnDefault: TButton; tbrValue: TTrackBar; Setting: TVideoQuality);
  public
     procedure InitTrackBars;
  end;

var
  frmVideoQuality: TfrmVideoQuality;

implementation

uses MainForm;

{$R *.DFM}

// ----------------------------------------------------
// used because the vertical trackbar positions are inverted
procedure SetVerticalTrackbarPosition (Trackbar: TTrackbar; Position: Integer);
begin
    Trackbar.Position := Trackbar.Max - Position + Trackbar.Min;
end;
function GetVerticalTrackbarPosition (Trackbar: TTrackbar): Integer;
begin
    Result := Trackbar.Max - Trackbar.Position + Trackbar.Min;
end;
// ----------------------------------------------------

procedure TfrmVideoQuality.FormCreate(Sender: TObject);
begin
   FInitializing := False;
end;

procedure TfrmVideoQuality.InitTrackBar (chkAuto: TCheckBox; btnDefault: TButton; tbrValue: TTrackBar; Setting: TVideoQuality);
begin
   tbrValue.Tag := integer (Setting);
   chkAuto.Tag := integer (Setting);
   btnDefault.Tag := integer (Setting);

   FSettingGroup[Setting].tbrValue := tbrValue;
   FSettingGroup[Setting].chkAuto := chkAuto;
   FSettingGroup[Setting].btnDefault := btnDefault;

   if not frmMainForm.VideoGrabber.IsVideoQualitySettingAvailable (Setting) then begin
      tbrValue.Enabled := False;
      tbrValue.Frequency := 0;
      tbrValue.Min := 0;
      tbrValue.Max := 1;
      tbrValue.Position := 1;
      ChkAuto.Enabled := False;
      btnDefault.Enabled := False;
   end
   else begin
      ChkAuto.Enabled := True;
      ChkAuto.Checked := frmMainForm.VideoGrabber.VideoQualityAuto (Setting);
      tbrValue.Enabled := not ChkAuto.Checked;
      btnDefault.Enabled := not ChkAuto.Checked;
      tbrValue.Min := frmMainForm.VideoGrabber.VideoQualityMin (Setting);
      tbrValue.Max := frmMainForm.VideoGrabber.VideoQualityMax (Setting);
      tbrValue.Frequency := frmMainForm.VideoGrabber.VideoQualityStep (Setting);
      SetVerticalTrackbarPosition (tbrValue, frmMainForm.VideoGrabber.VideoQualityValue (Setting));
   end;
end;


procedure TfrmVideoQuality.InitTrackBars;
begin
   FInitializing := True;
   InitTrackBar (chkBrightness,    btnBrightness,   tbrBrightness,   vq_Brightness);
   InitTrackBar (chkContrast,      btnContrast,     tbrContrast,     vq_Contrast);
   InitTrackBar (chkHue,           btnHue,          tbrHue,          vq_Hue);
   InitTrackBar (chkSaturation,    btnSaturation,   tbrSaturation,   vq_Saturation);
   InitTrackBar (chkSharpness,     btnSharpness,    tbrSharpness,    vq_Sharpness);
   InitTrackBar (chkGamma,         btnGamma,        tbrGamma,        vq_Gamma);
   InitTrackBar (chkWhiteBalance,  btnWhiteBalance, tbrWhiteBalance, vq_WhiteBalance);
   InitTrackBar (chkGain,          btnGain,         tbrGain,         vq_Gain);
   InitTrackBar (chkBacklight,     btnBacklight,    tbrBackLight,    vq_BacklightCompensation);
   InitTrackBar (chkColorEnable,   btnColorEnable,  tbrColorEnable,  vq_ColorEnable);
   FInitializing := False;
end;

procedure TfrmVideoQuality.OnSetValue (Sender: TObject);
var
   Setting: TVideoQuality;
begin
   if FInitializing then Exit;
   Setting := TVideoQuality (TComponent(Sender).Tag);
   frmMainForm.VideoGrabber.SetVideoQuality (Setting, FSettingGroup[Setting].ChkAuto.Checked, False, GetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
   FSettingGroup[Setting].tbrValue.Enabled := not FSettingGroup[Setting].ChkAuto.Checked;
   FSettingGroup[Setting].btnDefault.Enabled := not FSettingGroup[Setting].ChkAuto.Checked;
end;

procedure TfrmVideoQuality.OnSetDefault (Sender: TObject);
var
   Setting: TVideoQuality;
begin
   if FInitializing then Exit;
   Setting := TVideoQuality (TComponent(Sender).Tag);
   frmMainForm.VideoGrabber.SetVideoQuality (Setting, FSettingGroup[Setting].ChkAuto.Checked, True, GetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
   SetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue, frmMainForm.VideoGrabber.VideoQualityValue (Setting));
end;

procedure TfrmVideoQuality.FormShow(Sender: TObject);
begin
   frmVideoQuality.InitTrackBars;
end;

procedure TfrmVideoQuality.btnCloseClick(Sender: TObject);
begin
   Close;
end;

end.
