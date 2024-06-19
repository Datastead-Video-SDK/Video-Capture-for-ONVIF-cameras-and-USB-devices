program Multipurpose_Merge_Clips_SideBySide;

uses
  Vcl.Forms,
  Multipurpose_Merge_Clips_SideBySide_ in 'Multipurpose_Merge_Clips_SideBySide_.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
