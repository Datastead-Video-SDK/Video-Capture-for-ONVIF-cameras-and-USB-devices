unit StreamInterface_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab;

type

   TStreamSender = class (TThread)
   public
      constructor Create(VideoGrabber: TVideoGrabber; DumpFile: string);
   private
      m_VideoGrabber: TVideoGrabber;
      m_DumpFile: string;
   protected
      procedure Execute; override;
   end;

  TForm1 = class(TForm)
    VideoGrabber1: TVideoGrabber;
    btnStartPreview: TButton;
    btnStartMP4Recording: TButton;
    btnStop: TButton;
    OpenDialog1: TOpenDialog;
    edtDumpFile: TEdit;
    btnSelectStreamDump: TButton;
    mmoLog: TMemo;
    chkIsRealTime: TCheckBox;
    edtFrameRate: TEdit;
    Label1: TLabel;
    chkOpenURLAsync: TCheckBox;
    lstStreamFormat: TListBox;
    Label2: TLabel;
    procedure btnSelectStreamDumpClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnStartPreviewClick(Sender: TObject);
    procedure VideoGrabber1Reinitializing(Sender: TObject);
    procedure VideoGrabber1Log(Sender: TObject; LogType: TLogType;
      Severity, InfoMsg: String);
    procedure VideoGrabber1StoppingGraph(Sender: TObject);
    procedure btnStartMP4RecordingClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
  private
    m_StreamSender: TStreamSender;
    procedure SetCommonOptions;
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure TForm1.FormCreate(Sender: TObject);
begin
   m_StreamSender := nil;
   lstStreamFormat.ItemIndex := 0;
end;

constructor TStreamSender.Create(VideoGrabber: TVideoGrabber; DumpFile: string);
begin
   inherited Create(True);
   m_VideoGrabber := VideoGrabber;
   m_DumpFile := DumpFile;
   Resume;
end;

procedure TStreamSender.Execute;
const
   PushSize = 8192;
var
   fs: TFileStream;
   SizeRead, SizeWritten: LongInt;
   Buffer: pByte;
begin
   fs := TFileStream.create (m_DumpFile, fmOpenRead);
   if fs.Size > 0 then
   begin
      fs.Seek(0, soFromBeginning);
      GetMem (Buffer, PushSize);
      while not Terminated do
      begin
         SizeRead := fs.Read (Buffer^, PushSize);
         if SizeRead = 0 then
         begin
            Sleep(1);
         end
         else
         begin
            SizeWritten := m_VideoGrabber.StreamInterface_PushData (Buffer, SizeRead);
            if SizeWritten = -1 then
            begin
               Terminate;
            end
            else if SizeRead < PushSize then
            begin
               Terminate;
            end;
         end;
      end;
      FreeMem (Buffer);
   end;
   fs.Free;
end;

procedure TForm1.btnSelectStreamDumpClick(Sender: TObject);
begin
   if OpenDialog1.Execute() then begin
      edtDumpFile.Text := OpenDialog1.FileName;
   end;
end;

procedure TForm1.SetCommonOptions;
begin
   VideoGrabber1.VideoSource := vs_StreamInterface;
   VideoGrabber1.OpenURLAsync := chkOpenURLAsync.Checked;

   VideoGrabber1.StreamInterface_Format := lstStreamFormat.Items[lstStreamFormat.ItemIndex];

   VideoGrabber1.StreamInterface_IsRealTime := chkIsRealTime.Checked;

   if edtFrameRate.Text <> '' then begin
      VideoGrabber1.StreamInterface_FrameRate := StrToFloat(edtFrameRate.Text);
   end;
   ;
end;

procedure TForm1.btnStartPreviewClick(Sender: TObject);
begin
   if FileExists (edtDumpFile.Text) then begin
      SetCommonOptions();
      videograbber1.StartPreview();
   end
   else begin
      mmoLog.Lines.Add ('dump not found!');
   end;
end;

procedure TForm1.btnStartMP4RecordingClick(Sender: TObject);
begin
   if FileExists (edtDumpFile.Text) then begin
      SetCommonOptions();
      Videograbber1.RecordingMethod := rm_MP4;
      Videograbber1.StartRecording();
   end
   else begin
      mmoLog.Lines.Add ('dump not found!');
   end;
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber1.Stop();
end;

procedure TForm1.VideoGrabber1Reinitializing(Sender: TObject);
begin
   mmoLog.Clear;
   if VideoGrabber1.VideoSource = vs_StreamInterface then begin
      if not assigned (m_StreamSender) then begin
         m_StreamSender := TStreamSender.Create (VideoGrabber1, edtDumpFile.Text);
      end;
   end;
end;

procedure TForm1.VideoGrabber1StoppingGraph(Sender: TObject);
begin
   if assigned (m_StreamSender) then
   begin
      m_StreamSender.Terminate;
      m_StreamSender.Free;
      m_StreamSender := nil;
   end;
end;

procedure TForm1.VideoGrabber1Log(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add ('[' + Severity + '] ' + InfoMsg);
end;

end.
