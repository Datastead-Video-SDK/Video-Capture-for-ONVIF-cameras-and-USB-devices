unit PlayerControlByFrame_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, Buttons, ExtCtrls, VidGrab;

type
  TForm1 = class(TForm)
    VideoGrabber: TVideoGrabber;
    dlgOpen: TOpenDialog;
    edtPlayerClip: TEdit;
    Image1: TImage;
    MemoLog: TMemo;
    GroupBox1: TGroupBox;
    btnStop: TSpeedButton;
    btnPlay: TSpeedButton;
    btnPause: TSpeedButton;
    GroupBox2: TGroupBox;
    edtReachFrameNumber: TEdit;
    btnReachFrame: TButton;
    btnPlayerOpenFile: TSpeedButton;
    btnOpenClip: TButton;
    chkUseClock: TCheckBox;
    procedure btnOpenClipClick(Sender: TObject);
    procedure btnPlayerOpenFileClick(Sender: TObject);
    procedure btnPlayClick(Sender: TObject);
    procedure btnReachFrameClick(Sender: TObject);
    procedure btnPauseClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure chkUseClockClick(Sender: TObject);
    procedure VideoGrabberFrameCaptureCompleted(Sender: TObject;
      FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: LongInt;
      FrameNumber: LongWord_; FrameTime: LargeInteger;
      DestType: TFrameCaptureDest; FileName: string; Success: Boolean;
      FrameId: LongInt);
    procedure VideoGrabberFrameProgress(Sender: TObject; FrameNumber: LongWord;
      FrameTime: LargeInteger; FrameId: LongInt);
  private
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure TForm1.FormCreate(Sender: TObject);
begin
   ChkUseClock.Checked := VideoGrabber.UseClock;
end;

procedure TForm1.btnOpenClipClick(Sender: TObject);
begin
   Image1.AutoSize := True;
   VideoGrabber.Display_AutoSize := False;
   VideoGrabber.PlayerFileName := edtPlayerClip.Text;
   VideoGrabber.PlayerRefreshPausedDisplay := False;
   VideoGrabber.AutoStartPlayer := False;
   VideoGrabber.BurstCount := 0;
   VideoGrabber.BurstInterval := 0;
   VideoGrabber.BurstMode := True;
   VideoGrabber.OpenPlayer;
end;

procedure TForm1.btnPlayerOpenFileClick(Sender: TObject);
begin
   dlgOpen.FileName := '*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob';
   if dlgOpen.Execute then begin
      edtPlayerClip.Text :=dlgOpen.FileName;
   end;
end;

procedure TForm1.btnPlayClick(Sender: TObject);
begin
   VideoGrabber.RunPlayer;
end;

procedure TForm1.btnPauseClick(Sender: TObject);
begin
   VideoGrabber.PausePlayer;
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber.StopPlayer;
end;

procedure TForm1.btnReachFrameClick(Sender: TObject);
begin
   VideoGrabber.PlayerFramePosition := StrToIntDef (edtReachFrameNumber.Text, 1);
end;

procedure TForm1.VideoGrabberFrameProgress(Sender: TObject;
  FrameNumber: LongWord; FrameTime: LargeInteger; FrameId: LongInt);
begin
   MemoLog.Lines.Add ('frame #' + IntToStr (FrameNumber) + ' reached');
end;

procedure TForm1.VideoGrabberFrameCaptureCompleted(Sender: TObject;
  FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: LongInt;
  FrameNumber: LongWord_; FrameTime: LargeInteger; DestType: TFrameCaptureDest;
  FileName: string; Success: Boolean; FrameId: LongInt);
begin
   Image1.Picture.Assign(FrameBitmap);
   Image1.Update;
   MemoLog.Lines.Add ('frame #' + IntToStr (FrameNumber) + ' CAPTURED');
end;

procedure TForm1.chkUseClockClick(Sender: TObject);
begin
   VideoGrabber.UseClock := ChkUseClock.Checked;
end;

end.
