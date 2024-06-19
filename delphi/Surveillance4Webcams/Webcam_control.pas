unit Webcam_control;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, ExtCtrls, VidGrab;

type
  TFrmWebcam = class(TForm)
    edtGlobalSensitivity: TEdit;
    updGlobalSensitivity: TUpDown;
    Label2: TLabel;
    edtMaxDetectionsPerSecond: TEdit;
    updMaxDetectionsPerSecond: TUpDown;
    Label1: TLabel;
    Label3: TLabel;
    mmoMotionGrid: TMemo;
    shpMotionDetected: TShape;
    Label4: TLabel;
    cboVideoDevices: TComboBox;
    Label5: TLabel;
    cboVideoSize: TComboBox;
    Label6: TLabel;
    cboVideoInput: TComboBox;
    Label7: TLabel;
    cboAnalogVideoStandard: TComboBox;
    VideoGrabber: TVideoGrabber;
    StartPreview1: TButton;
    StopPreview1: TButton;
    StartRecording1: TButton;
    StopRecording1: TButton;
    StartPlayback1: TButton;
    StopPlayback2: TButton;
    chkCaptureFrame: TCheckBox;
    procedure updGlobalSensitivityClick(Sender: TObject; Button: TUDBtnType);
    procedure StartPreview1Click(Sender: TObject);
    procedure StopPreview1Click(Sender: TObject);
    procedure StartRecording1Click(Sender: TObject);
    procedure StopRecording1Click(Sender: TObject);
    procedure StartPlayback1Click(Sender: TObject);
    procedure StopPlayback2Click(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure updMaxDetectionsPerSecondClick(Sender: TObject;
      Button: TUDBtnType);
    procedure cboVideoDevicesChange(Sender: TObject);
    procedure VideoGrabberVideoDeviceSelected(Sender: TObject);
    procedure cboVideoSizeChange(Sender: TObject);
    procedure cboVideoInputChange(Sender: TObject);
    procedure cboAnalogVideoStandardChange(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure VideoGrabberMotionDetected(Sender: TObject;
      GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: LongInt;
      FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
      FrameId: LongInt; var CaptureFrame: Boolean);
    procedure VideoGrabberMotionNotDetected(Sender: TObject;
      FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
      FrameId: LongInt; var CaptureFrame: Boolean);
  private
  public
  end;

var
  frmWebcam: TfrmWebcam;

implementation

uses Surveillance_4_Webcams_;

{$R *.DFM}

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer);
begin
   ComboBox.Text := '';
   ComboBox.Items.Text := List;
   if ComboBox.Items.Count > 0 then begin
      ComboBox.ItemIndex := Index;
   end;
end;

procedure TfrmWebcam.FormShow(Sender: TObject);
begin
   AssignListToComboBox (cboVideoDevices, VideoGrabber.VideoDevices, VideoGrabber.VideoDevice);
   UpdMaxDetectionsPerSecond.Position := Round (VideoGrabber.MotionDetector_MaxDetectionsPerSecond);
end;

procedure TfrmWebcam.updGlobalSensitivityClick(Sender: TObject; Button: TUDBtnType);
begin
   VideoGrabber.MotionDetector_ResetGlobalSensitivity (UpdGlobalSensitivity.Position);
end;

procedure TfrmWebcam.updMaxDetectionsPerSecondClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.MotionDetector_MaxDetectionsPerSecond := UpdMaxDetectionsPerSecond.Position;
end;

procedure TfrmWebcam.StartPreview1Click(Sender: TObject);
begin
   VideoGrabber.StartPreview;
end;

procedure TfrmWebcam.StopPreview1Click(Sender: TObject);
begin
   VideoGrabber.StopPreview;
end;

procedure TfrmWebcam.StartRecording1Click(Sender: TObject);
begin
   VideoGrabber.StartRecording;
end;

procedure TfrmWebcam.StopRecording1Click(Sender: TObject);
begin
   VideoGrabber.StopRecording;
end;

procedure TfrmWebcam.StartPlayback1Click(Sender: TObject);
begin
   VideoGrabber.PlayerFileName := VideoGrabber.Last_Recording_FileName;
   VideoGrabber.OpenPlayer;
end;

procedure TfrmWebcam.StopPlayback2Click(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TFrmWebcam.VideoGrabberMotionDetected(Sender: TObject;
  GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: LongInt;
  FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
  FrameId: LongInt; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Brush.Color := clLime;
   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;
   CaptureFrame := chkCaptureFrame.Checked;
end;

procedure TFrmWebcam.VideoGrabberMotionNotDetected(Sender: TObject;
  FrameBitmap: TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
  FrameId: LongInt; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Brush.Color := clGreen;
   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;
end;

procedure TFrmWebcam.cboVideoDevicesChange(Sender: TObject);
begin
   VideoGrabber.VideoDevice := cboVideoDevices.ItemIndex;
end;

procedure TFrmWebcam.VideoGrabberVideoDeviceSelected(Sender: TObject);
begin
   if cboVideoDevices.ItemIndex <> VideoGrabber.VideoDevice then begin
      cboVideoDevices.ItemIndex := VideoGrabber.VideoDevice;
   end;
   AssignListToComboBox (cboVideoSize, VideoGrabber.VideoSizes, VideoGrabber.VideoSize);
   AssignListToComboBox (cboVideoInput, VideoGrabber.VideoInputs, VideoGrabber.VideoInput);
   AssignListToComboBox (cboAnalogVideoStandard, VideoGrabber.AnalogVideoStandards, VideoGrabber.AnalogVideoStandard);
end;

procedure TFrmWebcam.cboVideoSizeChange(Sender: TObject);
begin
   VideoGrabber.VideoSize := cboVideoSize.ItemIndex;
end;

procedure TFrmWebcam.cboVideoInputChange(Sender: TObject);
begin
   VideoGrabber.VideoInput := cboVideoInput.ItemIndex;
end;

procedure TFrmWebcam.cboAnalogVideoStandardChange(Sender: TObject);
begin
   VideoGrabber.AnalogVideoStandard := cboAnalogVideoStandard.ItemIndex;
end;

procedure TFrmWebcam.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   frmMaster.mmoLog.Lines.Add (Name + ': ' + InfoMsg);
end;

end.
