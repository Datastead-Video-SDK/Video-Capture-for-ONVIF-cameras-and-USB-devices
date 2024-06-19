program MainDemo;

uses
  Forms,
  MainForm in 'MainForm.pas' {frmMainForm},
  miscVideoQuality in 'miscVideoQuality.pas' {frmVideoQuality},
  miscCameraControl in 'miscCameraControl.pas' {frmCameraControl};
{$R *.RES}

begin
  Application.Initialize;
  Application.Title := 'Datastead TVideoGrabber VCL component demo';
  Application.CreateForm(TfrmMainForm, frmMainForm);
  Application.CreateForm(TfrmVideoQuality, frmVideoQuality);
  Application.CreateForm(TfrmCameraControl, frmCameraControl);
  Application.Run;
end.
