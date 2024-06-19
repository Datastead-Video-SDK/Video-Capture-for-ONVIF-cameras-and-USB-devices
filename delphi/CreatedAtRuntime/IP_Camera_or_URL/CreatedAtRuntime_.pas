unit CreatedAtRuntime_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, VidGrab, ExtCtrls, Menus;

type
  TDemoForm = class(TForm)
    imgCapturedFrame: TImage;
    GroupBox1: TGroupBox;
    btnCreate: TButton;
    btnCapture: TButton;
    btnDestroy: TButton;
    chkVisible: TCheckBox;
    edtURL: TEdit;
    procedure btnCreateClick(Sender: TObject);
    procedure btnCaptureClick(Sender: TObject);
    procedure btnDestroyClick(Sender: TObject);
    procedure chkVisibleClick(Sender: TObject);
  private
    VideoGrabber: TVideoGrabber;
  public
    procedure VideoDeviceSelected (Sender: TObject);
    procedure OnFrameCaptureCompleted(Sender: TObject;
      FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: Integer;
      FrameNumber: Cardinal; FrameTime: Int64; DestType: TFrameCaptureDest;
      FileName: String; Success: Boolean; FrameId: Integer);
    procedure OnResizeVideo(Sender: TObject; SourceWidth,
              SourceHeight: Integer);
  end;

var
  DemoForm: TDemoForm;

implementation

{$R *.DFM}

procedure TDemoForm.btnCreateClick(Sender: TObject);
begin
   if not assigned (VideoGrabber) then begin

      VideoGrabber := TVideoGrabber.Create (Self);
      VideoGrabber.Visible := chkVisible.Checked;

      VideoGrabber.OnFrameCaptureCompleted := OnFrameCaptureCompleted;
      VideoGrabber.OnResizeVideo := OnResizeVideo;

      VideoGrabber.VideoSource := vs_IPCamera;
      VideoGrabber.IPCameraURL := edtURL.Text;

      VideoGrabber.Left := 8;
      VideoGrabber.Top := 55;

      VideoGrabber.Parent := Self;

      VideoGrabber.StartPreview();
   end;
end;

procedure TDemoForm.btnCaptureClick(Sender: TObject);
begin
   if assigned (VideoGrabber) then begin
      VideoGrabber.CaptureFrameTo (fc_TBitmap, '');
   end;
end;

procedure TDemoForm.btnDestroyClick(Sender: TObject);
var
   TempVideoGrabber: TVideoGrabber;
begin
   if assigned (VideoGrabber) then begin
      VideoGrabber.Free;
      VideoGrabber := nil;
   end;
end;

procedure TDemoForm.VideoDeviceSelected (Sender: TObject);
begin

end;

procedure TDemoForm.OnFrameCaptureCompleted(Sender: TObject;
      FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: Integer;
      FrameNumber: Cardinal; FrameTime: Int64; DestType: TFrameCaptureDest;
      FileName: String; Success: Boolean; FrameId: Integer);
var
   AlternateOption: Boolean;
begin
   imgCapturedFrame.Left := VideoGrabber.Left + VideoGrabber.Width + 10;
   imgCapturedFrame.AutoSize := true;

   AlternateOption := False; // you can choose one of the 2 methods below

   if not AlternateOption then begin // this code reuses directly the bitmap hancle (saves CPU)
      imgCapturedFrame.Picture.Bitmap.Handle := FrameBitmap.Handle;
      FrameBitmap.ReleaseHandle;
   end
   else begin // or make a copy of the video frame captured
      imgCapturedFrame.Picture.Assign (FrameBitmap);
   end;
end;

procedure TDemoForm.OnResizeVideo(Sender: TObject; SourceWidth, SourceHeight: Integer);
var
   NewWidth: longint;
begin
   imgCapturedFrame.Picture.Assign (nil);
   Height := VideoGrabber.Top + VideoGrabber.Height + 80;
   imgCapturedFrame.Left := VideoGrabber.Left + VideoGrabber.Width + 20;
   imgCapturedFrame.Top := 55;
   imgCapturedFrame.Width := VideoGrabber.Width;
   imgCapturedFrame.Height := VideoGrabber.Height;
   NewWidth := imgCapturedFrame.Left + VideoGrabber.Width + 15;
   if NewWidth < GroupBox1.Width + 20 then begin
      NewWidth := GroupBox1.Width + 20;
   end;
   Width := NewWidth;
end;

procedure TDemoForm.chkVisibleClick(Sender: TObject);
begin
   if assigned (VideoGrabber) then begin
      VideoGrabber.Visible := chkVisible.Checked;
   end;
end;

end.
