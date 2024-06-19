unit VideoFromBMPorJPEGfiles_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab;

Type

   // TFileSearch: small class around FindFirst and FindNext to make the search easier
   TFileSearch = class (TComponent)
   private
      Opened: Boolean;
      Path: String;
      SearchRec: TSearchRec;
   public
      constructor Create (AOwner: TComponent); override;
      function FirstFile (SearchPath: string; FileKind: string): string;
      function NextFile: string;
      procedure Close;
      destructor Destroy; override;
   end;

  TForm1 = class(TForm)
    VideoGrabber: TVideoGrabber;
    btnStartPreview: TButton;
    edtFilesLocation: TEdit;
    btnStartRecording: TButton;
    btnStop: TButton;
    mmoLog: TMemo;
    btnPlay: TButton;
    edtFrameProgress: TEdit;
    Label1: TLabel;
    rdgSearchForBMPorJPEG: TRadioGroup;
    edtRecordingFrameRate: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    edtFinalFrameRate: TEdit;
    Label4: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure btnStartPreviewClick(Sender: TObject);
    procedure btnStartRecordingClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure btnPlayClick(Sender: TObject);
    procedure VideoGrabberInactive(Sender: TObject);
    procedure VideoGrabberPreviewStarted(Sender: TObject);
    procedure VideoGrabberRecordingStarted(Sender: TObject;
      FileName: String);
    procedure VideoGrabberRecordingCompleted(Sender: TObject;
      FileName: String; Success: Boolean);
    procedure VideoGrabberPlayerOpened(Sender: TObject);
    procedure VideoGrabberVideoFromBitmapsNextFrameNeeded(Sender: TObject;
      FirstSample: Boolean);
    procedure VideoGrabberFrameProgress(Sender: TObject; FrameNumber: LongWord;
      FrameTime: LargeInteger; FrameId: LongInt);
    procedure VideoGrabberAVIDurationUpdated(Sender: TObject; FileName: string;
      FrameCount: LongWord; var FrameRate: Double; var Duration: LargeInteger);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
    SearchForFiles: TFileSearch;
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

constructor TFileSearch.Create (AOwner: TComponent);
begin
   inherited Create (AOwner);
   Opened := False;
end;

function TFileSearch.FirstFile (SearchPath: string; FileKind: String): String;
begin
   Result := '';

   if Opened then begin
      Close; // let's close any previous opened search
   end;

   if Length(SearchPath) > 0 then begin // let's add a trailing slash if required
      if SearchPath[length(SearchPath)] = '\' then begin
         Path := SearchPath;
      end
      else begin
         Path := SearchPath + '\';
      end;
   end
   else begin
      Path := '.\';
   end;

   if FindFirst (Path + FileKind, faAnyFile, SearchRec) = 0 then begin
      Result := Path + SearchRec.Name;
      Opened := True;
   end;
end;

function TFileSearch.NextFile: String;
begin
   Result := '';
   if Opened then begin
      if FindNext (SearchRec) = 0 then begin
         Result := Path + SearchRec.Name;
      end
      else begin
         Close;
      end;
   end;
end;

procedure TFileSearch.Close;
begin
   if Opened then begin
      FindClose (SearchRec);
      Opened := False;
   end;
end;

destructor TFileSearch.Destroy;
begin
   Close;
   inherited Destroy;
end;


procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
   VideoGrabber.Stop();
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
   SearchForFiles := TFileSearch.Create (Self);
end;

procedure TForm1.btnStartPreviewClick(Sender: TObject);
begin
   VideoGrabber.VideoSource := vs_JPEGsOrBitmaps;
   VideoGrabber.FrameRate := StrToIntDef (edtRecordingFrameRate.Text, 50);
   VideoGrabber.StartPreview;
end;

procedure TForm1.btnStartRecordingClick(Sender: TObject);
begin
   VideoGrabber.VideoSource := vs_JPEGsOrBitmaps;
   VideoGrabber.FrameRate := StrToIntDef (edtRecordingFrameRate.Text, 50);
   VideoGrabber.StartRecording;
end;

procedure TForm1.btnStopClick(Sender: TObject);
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
   ImageFile: string;
   EndOfData: Boolean;
begin
   // you can pass to this event:
   // - either the path to a BMP file or a JPEG file (this is the case in this example)
   // - either a the HBITMAP handle of a bitmap (see the VideoFromBitmapHandles demo project)

   // in this version we pass a JPEG or BMP file so BitmapHandle and CanFreeBitmapHandle are not used

   // FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)

   ImageFile := '';
   EndOfData := false;

   if FirstSample then begin
      if rdgSearchForBMPorJPEG.ItemIndex = 0 then begin
         ImageFile := SearchForFiles.FirstFile (edtFilesLocation.Text, '*.bmp');
      end
      else begin
         ImageFile := SearchForFiles.FirstFile (edtFilesLocation.Text, '*.jpg');
      end;
   end
   else begin
      ImageFile := SearchForFiles.NextFile;
   end;

   if ImageFile = '' then begin
      EndOfData := True;
   end;

   VideoGrabber.SendImageToVideoFromBitmaps (ImageFile, 0, false, EndOfData);
end;

end.

