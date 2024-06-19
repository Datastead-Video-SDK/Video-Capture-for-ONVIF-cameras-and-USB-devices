unit Multipurpose_Merge_Clips_SideBySide_;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, VidGrab, Vcl.ExtCtrls;

type
  TForm1 = class(TForm)
    edtSourceClip1: TEdit;
    Label1: TLabel;
    edtSourceClip2: TEdit;
    Label2: TLabel;
    edtDestinationClip: TEdit;
    Label3: TLabel;
    mmoLog: TMemo;
    btnStart: TButton;
    edtMultipurposeFolder: TEdit;
    Label4: TLabel;
    Label5: TLabel;
    VideoGrabber1: TVideoGrabber;
    btnStop: TButton;
    edtBitrateKb: TEdit;
    Label6: TLabel;
    Label7: TLabel;
    procedure VideoGrabber1Log(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: string);
    procedure VideoGrabber1RecordingStarted(Sender: TObject; FileName: string);
    procedure VideoGrabber1ReencodingProgress(Sender: TObject; Percent: Integer;
      Position, Duration: Int64);
    procedure VideoGrabber1ReencodingCompleted(Sender: TObject; SourceFile,
      DestFile: string; Success: Boolean);
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
  private
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnStartClick(Sender: TObject);
var
   CommandLine: string;
   BitRate_Kbps: LongInt;
begin
   BitRate_Kbps := StrToIntDef (edtBitRateKb.Text, 8000);
   VideoGrabber1.ExtraDLLPath := edtMultipurposeFolder.Text;
   VideoGrabber1.Reencoding_SourceVideoClip := 'N/A';
   VideoGrabber1.Reencoding_NewVideoClip := edtDestinationClip.Text;
  CommandLine := CommandLine + 'FFmpegLGPL.exe -i ';
  CommandLine := CommandLine + edtSourceClip1.Text;
  CommandLine := CommandLine + ' -i ';
  CommandLine := CommandLine + edtSourceClip2.Text;
  CommandLine := CommandLine + ' -filter_complex hstack';
  CommandLine := CommandLine + ' -c:v h264 -b:v ' + IntToStr (BitRate_Kbps) + 'k ';
  CommandLine := CommandLine + VideoGrabber1.Reencoding_NewVideoClip;
  VideoGrabber1.EnableMultipurposeEncoder (mpe_Reencoding, true);
  VideoGrabber1.SetMultipurposeEncoderSettings (mpe_Reencoding, CommandLine);
  VideoGrabber1.StartReencoding();
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber1.Stop();
end;

procedure TForm1.VideoGrabber1Log(Sender: TObject; LogType: TLogType; Severity,
  InfoMsg: string);
begin
   mmoLog.Lines.add (InfoMsg);
end;

procedure TForm1.VideoGrabber1RecordingStarted(Sender: TObject;
  FileName: string);
begin
   mmoLog.Lines.Add('processing ' + FileName);
end;

procedure TForm1.VideoGrabber1ReencodingProgress(Sender: TObject;
  Percent: Integer; Position, Duration: Int64);
begin
   mmoLog.Lines.Add(VideoGrabber1.MultipurposeEncoder_GetLastLog(mpe_Reencoding));
end;

procedure TForm1.VideoGrabber1ReencodingCompleted(Sender: TObject; SourceFile,
  DestFile: string; Success: Boolean);
begin
   if Success then begin
   mmoLog.Lines.Add(DestFile + ' successfully created');
   end
   else begin
   mmoLog.Lines.Add('error: failed to create ' + DestFile);
   end;
end;


end.
