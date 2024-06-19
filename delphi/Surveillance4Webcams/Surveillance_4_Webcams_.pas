unit Surveillance_4_Webcams_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, ExtCtrls, VidGrab;

type
  TfrmMaster = class(TForm)
    btnStartMaster: TButton;
    btnStopMaster: TButton;
    mmoLog: TMemo;
    procedure btnStartMasterClick(Sender: TObject);
    procedure btnStopMasterClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
  public
  end;

var
  frmMaster: TfrmMaster;

implementation

{$R *.DFM}

uses Webcam_control;

const
   FormSpacings = 5;

var
   frmWebcam1: TfrmWebcam;
   frmWebcam2: TfrmWebcam;
   frmWebcam3: TfrmWebcam;
   frmWebcam4: TfrmWebcam;

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer);
begin
   ComboBox.Text := '';
   ComboBox.Items.Text := List;
   if ComboBox.Items.Count > 0 then begin
      ComboBox.ItemIndex := Index;
   end;
end;

procedure CreateWebcamForm (VideoDeviceIndex: LongInt; var WebcamForm: TfrmWebcam; FormTop, FormLeft: LongInt);
begin
   Application.CreateForm (TfrmWebcam, WebcamForm);
   WebcamForm.Caption := 'Camera ' + IntToStr (VideoDeviceIndex);
   WebcamForm.Top := FormTop;
   WebcamForm.Left := FormLeft;
   WebcamForm.VideoGrabber.Display_AutoSize := False;
   WebcamForm.VideoGrabber.Display_AspectRatio := ar_Stretch;
   WebcamForm.VideoGrabber.AutoFilePrefix := 'CAM' + IntToStr (VideoDeviceIndex) + '_';
   WebcamForm.VideoGrabber.AutoFileName := fn_DateTime;
   WebcamForm.VideoGrabber.VideoDevice := VideoDeviceIndex;
   WebcamForm.VideoGrabber.CaptureFrameTo (fc_JpegFile, ''); // the motion detection will return frame captured as JPEG files
   WebcamForm.VideoGrabber.MotionDetector_Enabled := True;
   WebcamForm.Show;
end;

procedure TfrmMaster.FormShow(Sender: TObject);
begin
   if not assigned (frmWebcam1) then CreateWebcamForm (0, frmWebcam1, frmMaster.Top + frmMaster.Height + FormSpacings, frmMaster.Left);
   if not assigned (frmWebcam2) then CreateWebcamForm (1, frmWebcam2, frmMaster.Top + frmMaster.Height + FormSpacings, frmMaster.Left + frmWebcam1.Width + FormSpacings);
   if not assigned (frmWebcam3) then CreateWebcamForm (2, frmWebcam3, frmWebcam1.Top + frmWebcam1.Height + FormSpacings, frmMaster.Left);
   if not assigned (frmWebcam4) then CreateWebcamForm (3, frmWebcam4, frmWebcam1.Top + frmWebcam1.Height + FormSpacings, frmMaster.Left + frmWebcam1.Width + FormSpacings);
end;

procedure TfrmMaster.btnStartMasterClick(Sender: TObject);
begin
   frmWebcam1.VideoGrabber.Synchronized := True;
   frmWebcam2.VideoGrabber.Synchronized := True;
   frmWebcam3.VideoGrabber.Synchronized := True;
   frmWebcam4.VideoGrabber.Synchronized := True;
   frmWebcam1.VideoGrabber.StartPreview;
   frmWebcam2.VideoGrabber.StartPreview;
   frmWebcam3.VideoGrabber.StartPreview;
   frmWebcam4.VideoGrabber.StartPreview;
end;

procedure TfrmMaster.btnStopMasterClick(Sender: TObject);
begin
   frmWebcam1.VideoGrabber.StopPreview;
   frmWebcam2.VideoGrabber.StopPreview;
   frmWebcam3.VideoGrabber.StopPreview;
   frmWebcam4.VideoGrabber.StopPreview;
end;

end.
