unit miscCameraControl;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, VidGrab, ExtCtrls;

type
  TSettingGroup = record
     tbrValue: TTrackbar;
     chkAuto: TCheckBox;
     btnDefault: TButton;
  end;

  TfrmCameraControl = class(TForm)
    btnClose: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    tbrExposure: TTrackBar;
    tbrFocus: TTrackBar;
    tbrIris: TTrackBar;
    tbrPan: TTrackBar;
    tbrRoll: TTrackBar;
    tbrTilt: TTrackBar;
    tbrZoom: TTrackBar;
    chkZoom: TCheckBox;
    chkPan: TCheckBox;
    chkTilt: TCheckBox;
    chkRoll: TCheckBox;
    chkExposure: TCheckBox;
    chkIris: TCheckBox;
    chkFocus: TCheckBox;
    btnZoom: TButton;
    btnPan: TButton;
    btnTilt: TButton;
    btnRoll: TButton;
    btnExposure: TButton;
    btnIris: TButton;
    btnFocus: TButton;
    edtExposure: TEdit;
    procedure btnCloseClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure OnSetValue (Sender: TObject);
    procedure OnSetDefault (Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
     FSettingGroup: array[low(TCameraControl)..high(TCameraControl)] of TSettingGroup;
     FInitializing: Boolean;
     procedure InitTrackBar (chkAuto: TCheckBox; btnDefault: TButton; tbrValue: TTrackBar; Setting: TCameraControl);
  public
     procedure InitTrackBars;
  end;

var
  frmCameraControl: TfrmCameraControl;

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


procedure TfrmCameraControl.FormCreate(Sender: TObject);
begin
   FInitializing := False;
end;

procedure TfrmCameraControl.InitTrackBar (chkAuto: TCheckBox; btnDefault: TButton; tbrValue: TTrackBar; Setting: TCameraControl);
begin
   tbrValue.Tag := integer (Setting);
   chkAuto.Tag := integer (Setting);
   btnDefault.Tag := integer (Setting);

   FSettingGroup[Setting].tbrValue := tbrValue;
   FSettingGroup[Setting].chkAuto := chkAuto;
   FSettingGroup[Setting].btnDefault := btnDefault;

   if not frmMainForm.VideoGrabber.IsCameraControlSettingAvailable (Setting) then begin
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
      ChkAuto.Checked := frmMainForm.VideoGrabber.CameraControlAuto (Setting);
      tbrValue.Enabled := not ChkAuto.Checked;
      btnDefault.Enabled := not ChkAuto.Checked;
      tbrValue.Min := frmMainForm.VideoGrabber.CameraControlMin (Setting);
      tbrValue.Max := frmMainForm.VideoGrabber.CameraControlMax (Setting);
      tbrValue.Frequency := frmMainForm.VideoGrabber.CameraControlStep (Setting);
      SetVerticalTrackbarPosition (tbrValue, frmMainForm.VideoGrabber.CameraControlValue (Setting));
      if Setting = cc_Exposure then begin
         edtExposure.Text := frmMainForm.VideoGrabber.GetCameraExposureAsString();
      end;
   end;
end;

procedure TfrmCameraControl.InitTrackBars;
begin
   FInitializing := True;
   InitTrackBar (chkPan,      btnPan,      tbrPan,      cc_Pan);
   InitTrackBar (chkTilt,     btnTilt,     tbrTilt,     cc_Tilt);
   InitTrackBar (chkRoll,     btnRoll,     tbrRoll,     cc_Roll);
   InitTrackBar (chkZoom,     btnZoom,     tbrZoom,     cc_Zoom);
   InitTrackBar (chkExposure, btnExposure, tbrExposure, cc_Exposure);
   InitTrackBar (chkIris,     btnIris,     tbrIris,     cc_Iris);
   InitTrackBar (chkFocus,    btnFocus,    tbrFocus,    cc_Focus);
   FInitializing := False;
end;

procedure TfrmCameraControl.OnSetValue (Sender: TObject);
var
   Setting: TCameraControl;
begin
   if FInitializing then Exit;
   Setting := TCameraControl (TComponent(Sender).Tag);
   frmMainForm.VideoGrabber.SetCameraControl (Setting, FSettingGroup[Setting].ChkAuto.Checked, False, GetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
   FSettingGroup[Setting].tbrValue.Enabled := not FSettingGroup[Setting].ChkAuto.Checked;
   FSettingGroup[Setting].btnDefault.Enabled := not FSettingGroup[Setting].ChkAuto.Checked;
   if Setting = cc_Exposure then begin
      edtExposure.Text := frmMainForm.VideoGrabber.GetCameraExposureAsString();
   end;
end;

procedure TfrmCameraControl.OnSetDefault (Sender: TObject);
var
   Setting: TCameraControl;
begin
   if FInitializing then Exit;
   Setting := TCameraControl (TComponent(Sender).Tag);
   frmMainForm.VideoGrabber.SetCameraControl (Setting, FSettingGroup[Setting].ChkAuto.Checked, True, GetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
   SetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue, frmMainForm.VideoGrabber.CameraControlValue (Setting));
   if Setting = cc_Exposure then begin
      edtExposure.Text := frmMainForm.VideoGrabber.GetCameraExposureAsString();
   end;
end;

procedure TfrmCameraControl.FormShow(Sender: TObject);
begin
   frmCameraControl.InitTrackBars;
end;

procedure TfrmCameraControl.btnCloseClick(Sender: TObject);
begin
   Close;
end;

end.
