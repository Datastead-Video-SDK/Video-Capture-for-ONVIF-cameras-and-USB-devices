program CreatedAtRuntime;

uses
  Forms,
  CreatedAtRuntime_ in 'CreatedAtRuntime_.pas' {DemoForm};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TDemoForm, DemoForm);
  Application.Run;
end.
