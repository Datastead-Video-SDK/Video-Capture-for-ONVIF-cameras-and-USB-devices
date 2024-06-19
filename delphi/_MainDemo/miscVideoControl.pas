unit miscVideoControl;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, VidGrab, ExtCtrls, Menus;

type
  TfrmVideoControl = class(TForm)
    btnClose: TButton;
    chkFlipVertically: TCheckBox;
    chkFlipHorizontally: TCheckBox;
    chkExternalTrigger: TCheckBox;
    chkEmulateTrigger: TCheckBox;
    procedure btnCloseClick(Sender: TObject);
    procedure ApplyVideoControlMode(Sender: TObject);
  private
  public
    procedure RefreshControls;
  end;

var
  frmVideoControl: TfrmVideoControl;

implementation

uses MainForm;

{$R *.DFM}

procedure TfrmVideoControl.RefreshControls;
begin
   chkFlipVertically.Enabled := frmMainForm.VideoGrabber.IsVideoControlModeAvailable (vc_FlipHorizontal);
   chkFlipHorizontally.Enabled := frmMainForm.VideoGrabber.IsVideoControlModeAvailable (vc_FlipVertical);
   chkExternalTrigger.Enabled := frmMainForm.VideoGrabber.IsVideoControlModeAvailable (vc_ExternalTriggerEnable);
   chkEmulateTrigger.Enabled := frmMainForm.VideoGrabber.IsVideoControlModeAvailable (vc_Trigger);
end;

procedure TfrmVideoControl.ApplyVideoControlMode (Sender: TObject);
begin
   frmMainForm.VideoGrabber.SetVideoControlMode (chkFlipHorizontally.Checked, chkFlipVertically.Checked, chkExternalTrigger.Checked, chkEmulateTrigger.Checked);
end;

procedure TfrmVideoControl.btnCloseClick(Sender: TObject);
begin
   Close;
end;

end.
