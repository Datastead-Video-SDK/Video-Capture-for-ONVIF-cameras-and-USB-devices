program SynchronizedPlayers;

uses
  Forms,
  SynchronizedPlayers_ in 'SynchronizedPlayers_.pas' {Form1};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
