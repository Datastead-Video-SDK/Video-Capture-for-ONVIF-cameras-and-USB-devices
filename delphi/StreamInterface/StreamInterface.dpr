program StreamInterface;

uses
  Forms,
  StreamInterface_ in 'StreamInterface_.pas' {Form1};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
