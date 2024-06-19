program PictureInPictureMixer;

uses
  Forms,
  PictureInPictureMixer_ in 'PictureInPictureMixer_.pas' {Form1};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
