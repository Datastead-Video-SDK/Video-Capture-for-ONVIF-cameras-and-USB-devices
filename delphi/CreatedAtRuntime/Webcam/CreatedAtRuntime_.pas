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
    cmbVideoDevices: TComboBox;
    cmbVideoSizes: TComboBox;
    cmbVideoInputs: TComboBox;
    btnTVTuner: TButton;
    procedure btnCreateClick(Sender: TObject);
    procedure btnCaptureClick(Sender: TObject);
    procedure cmbVideoSizesChange(Sender: TObject);
    procedure cmbVideoDevicesChange(Sender: TObject);
    procedure cmbVideoInputsChange(Sender: TObject);
    procedure btnDestroyClick(Sender: TObject);
    procedure btnTVTunerClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure chkVisibleClick(Sender: TObject);
  private
    VideoGrabber: TVideoGrabber;
    FullyCreated: Boolean;
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

procedure TDemoForm.FormCreate(Sender: TObject);
var
   vg: TVideoGrabber;
begin
   FullyCreated := False;
   vg := TVideoGrabber.Create (nil); // to get the list of the video capture devices before creating the main component
   cmbVideoDevices.Items.Text := vg.VideoDevices;
   cmbVideoDevices.ItemIndex := 0;
   vg.Free;
end;

procedure TDemoForm.btnCreateClick(Sender: TObject);
begin
   if not assigned (VideoGrabber) then begin

      VideoGrabber := TVideoGrabber.Create (Self);
      VideoGrabber.Visible := chkVisible.Checked;

      VideoGrabber.OnVideoDeviceSelected := VideoDeviceSelected;
      VideoGrabber.OnFrameCaptureCompleted := OnFrameCaptureCompleted;
      VideoGrabber.OnResizeVideo := OnResizeVideo;

      VideoGrabber.VideoDevice := cmbVideoDevices.ItemIndex;

      VideoGrabber.Left := 8;
      VideoGrabber.Top := 55;

      VideoGrabber.Parent := Self;

      VideoGrabber.StartPreview;
      FullyCreated := True;
   end;
end;

procedure TDemoForm.btnCaptureClick(Sender: TObject);
begin
   if FullyCreated then begin
      VideoGrabber.CaptureFrameTo (fc_TBitmap, '');
   end;
end;

procedure TDemoForm.btnDestroyClick(Sender: TObject);
var
   TempVideoGrabber: TVideoGrabber;
begin
   if FullyCreated then begin
      TempVideoGrabber := VideoGrabber;
      VideoGrabber := nil;
      FullyCreated := False;

      TempVideoGrabber.Free;
   end;
end;

procedure TDemoForm.VideoDeviceSelected (Sender: TObject);
begin
   imgCapturedFrame.Picture.Assign (nil);

   cmbVideoSizes.Clear;
   cmbVideoSizes.Items.Text := VideoGrabber.VideoSizes;
   cmbVideoSizes.ItemIndex := VideoGrabber.VideoSize;

   cmbVideoInputs.Clear;
   cmbVideoInputs.Items.Text := VideoGrabber.VideoInputs;
   cmbVideoInputs.ItemIndex := VideoGrabber.VideoInput;

   btnTVTuner.Enabled := VideoGrabber.IsTVTunerAvailable;
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
   else begin // this code makes a copy of the video frame
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

procedure TDemoForm.btnTVTunerClick(Sender: TObject);
begin
   if FullyCreated then begin
      VideoGrabber.ShowDialog (dlg_TVTuner);
   end;
end;

procedure TDemoForm.cmbVideoDevicesChange(Sender: TObject);
begin
   if FullyCreated then begin
      VideoGrabber.VideoDevice :=cmbVideoDevices.ItemIndex;
   end;
end;

procedure TDemoForm.cmbVideoSizesChange(Sender: TObject);
begin
   if FullyCreated then begin
      VideoGrabber.VideoSize :=cmbVideoSizes.ItemIndex;
   end;
end;

procedure TDemoForm.cmbVideoInputsChange(Sender: TObject);
begin
   if FullyCreated then begin
      VideoGrabber.VideoInput :=cmbVideoInputs.ItemIndex;
   end;
end;

procedure TDemoForm.chkVisibleClick(Sender: TObject);
begin
   if FullyCreated then begin
      VideoGrabber.Visible := chkVisible.Checked;
   end;
end;

end.
