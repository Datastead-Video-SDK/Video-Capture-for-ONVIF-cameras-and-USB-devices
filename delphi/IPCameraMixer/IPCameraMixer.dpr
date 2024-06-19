program IPCameraMixer;

uses
  Forms,
  IPCameraMixer_ in 'IPCameraMixer_.pas' {Form1};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
