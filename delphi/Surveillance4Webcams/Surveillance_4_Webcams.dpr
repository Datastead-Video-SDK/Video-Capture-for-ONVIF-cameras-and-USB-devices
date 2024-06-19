program Surveillance_4_Webcams;

uses
  Forms,
  Surveillance_4_Webcams_ in 'Surveillance_4_Webcams_.pas' {frmMaster};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TfrmMaster, frmMaster);
  Application.Run;
end.
