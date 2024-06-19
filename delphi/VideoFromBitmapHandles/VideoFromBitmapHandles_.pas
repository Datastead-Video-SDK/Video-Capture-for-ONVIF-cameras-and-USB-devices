unit VideoFromBitmapHandles_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab;

Type
  TForm1 = class(TForm)
    VideoGrabber: TVideoGrabber;
    btnStartPreview: TButton;
    btnStartRecording: TButton;
    btnStop: TButton;
    mmoLog: TMemo;
    btnPlay: TButton;
    edtFrameProgress: TEdit;
    edtRecordingFrameRate: TEdit;
    Label2: TLabel;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    Image4: TImage;
    Label1: TLabel;
    edtFinalFrameRate: TEdit;
    Label4: TLabel;
    chkMakeBitmapCopy: TCheckBox;
    procedure btnStartPreviewClick(Sender: TObject);
    procedure btnStartRecordingClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure btnPlayClick(Sender: TObject);
    procedure VideoGrabberPreviewStarted(Sender: TObject);
    procedure VideoGrabberInactive(Sender: TObject);
    procedure VideoGrabberRecordingStarted(Sender: TObject;
      FileName: String);
    procedure VideoGrabberRecordingCompleted(Sender: TObject;
      FileName: String; Success: Boolean);
    procedure VideoGrabberPlayerOpened(Sender: TObject);
    procedure VideoGrabberVideoFromBitmapsNextFrameNeeded(Sender: TObject;
      FirstSample: Boolean);
    procedure VideoGrabberAVIDurationUpdated(Sender: TObject; FileName: string;
      FrameCount: LongWord; var FrameRate: Double; var Duration: LargeInteger);
    procedure VideoGrabberFrameProgress(Sender: TObject; FrameNumber: LongWord;
      FrameTime: LargeInteger; FrameId: LongInt);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
      FImageIndex: LongInt;
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure TForm1.btnStartPreviewClick(Sender: TObject);
begin
   FImageIndex := 0;
   VideoGrabber.VideoSource := vs_JPEGsOrBitmaps;
   VideoGrabber.FrameRate := StrToIntDef (edtRecordingFrameRate.Text, 200);
   VideoGrabber.StartPreview;
end;

procedure TForm1.btnStartRecordingClick(Sender: TObject);
begin
   FImageIndex := 0;
   VideoGrabber.VideoSource := vs_JPEGsOrBitmaps;
   VideoGrabber.FrameRate := StrToIntDef (edtRecordingFrameRate.Text, 200);
   VideoGrabber.StartRecording;
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
   VideoGrabber.Stop();
end;

procedure TForm1.btnPlayClick(Sender: TObject);
begin
   VideoGrabber.PlayerFileName := VideoGrabber.Last_Recording_FileName;
   VideoGrabber.OpenPlayer;
end;

procedure TForm1.VideoGrabberFrameProgress(Sender: TObject;
  FrameNumber: LongWord; FrameTime: LargeInteger; FrameId: LongInt);
begin
   edtFrameProgress.Text := 'frame # ' + IntToStr (FrameNumber);
end;

procedure TForm1.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add (InfoMsg);
end;

procedure TForm1.VideoGrabberPreviewStarted(Sender: TObject);
begin
   mmoLog.Lines.Add ('previewing');
end;

procedure TForm1.VideoGrabberInactive(Sender: TObject);
begin
   mmoLog.Lines.Add ('done.');
end;

procedure TForm1.VideoGrabberRecordingStarted(Sender: TObject;
  FileName: String);
begin
   mmoLog.Lines.Add ('recording to: ' + FileName);
end;

procedure TForm1.VideoGrabberRecordingCompleted(Sender: TObject;
  FileName: String; Success: Boolean);
begin
   if Success then begin
      mmoLog.Lines.Add ('recording completed: ' + FileName);
   end
   else begin
      mmoLog.Lines.Add ('recording failed: ' + FileName);
   end;
end;

procedure TForm1.VideoGrabberPlayerOpened(Sender: TObject);
begin
   mmoLog.Lines.Add ('playing ' + VideoGrabber.PlayerFileName);
end;

procedure TForm1.VideoGrabberAVIDurationUpdated(Sender: TObject;
  FileName: string; FrameCount: LongWord; var FrameRate: Double;
  var Duration: LargeInteger);
begin
   FrameRate := StrToIntDef (edtFinalFrameRate.Text, 10);
end;

procedure TForm1.VideoGrabberVideoFromBitmapsNextFrameNeeded(
  Sender: TObject; FirstSample: Boolean);
var
   Bitmap: TBitmap;
   BitmapHandle: THandle;
   CanFreeBitmapHandle: Boolean;
begin
   BitmapHandle := 0;
   if chkMakeBitmapCopy.Checked then begin
      // in this case we make a copy of the bitmap, and we pass the copy
      // and the handle will be freed by TVideoGrabber
      Bitmap := TBitmap.Create;
      case FImageIndex of
         0: Bitmap.Assign (Image1.Picture);
         1: Bitmap.Assign (Image2.Picture);
         2: Bitmap.Assign (Image3.Picture);
         3: Bitmap.Assign (Image4.Picture);
      end;
      BitmapHandle := Bitmap.Handle;
      Bitmap.ReleaseHandle;
      Bitmap.Free;
      CanFreeBitmapHandle := True; // it's a copy, TVideoGrabber can free it
   end
   else begin
      // in this case we pass directly the bitmap handle,
      // and we tell TVideoGrabber not to free it
      case FImageIndex of
         0: BitmapHandle := Image1.Picture.Bitmap.Handle;
         1: BitmapHandle := Image2.Picture.Bitmap.Handle;
         2: BitmapHandle := Image3.Picture.Bitmap.Handle;
         3: BitmapHandle := Image4.Picture.Bitmap.Handle;
      end;
      CanFreeBitmapHandle := False; // it's not a copy, TVideoGrabber must not free it
   end;
   inc (FImageIndex);
   if FImageIndex = 4 then begin
      FImageIndex := 0;
   end;
   VideoGrabber.SendImageToVideoFromBitmaps ('', BitmapHandle, CanFreeBitmapHandle, false);
end;

end.
