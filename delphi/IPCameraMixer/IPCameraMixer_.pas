unit IPCameraMixer_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab;

type
  TForm1 = class(TForm)
    VideoGrabber1: TVideoGrabber;
    VideoGrabber2: TVideoGrabber;
    VideoGrabber3: TVideoGrabber;
    VideoGrabber4: TVideoGrabber;
    VideoGrabber5: TVideoGrabber;
    btnStartRecording: TButton;
    btnStop: TButton;
    procedure btnStartRecordingClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
  private
    { Déclarations privées }
  public
    { Déclarations publiques }
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure SetupVG (vgx: TVideoGrabber);
begin
   vgx.VideoSource := vs_IPcamera;
   vgx.SyncPreview := sp_Disabled;
   vgx.IPCameraURL := 'rtsp://root:admin@192.168.5.25/axis-media/media.amp?videocodec=h264';
   vgx.StartPreview();
end;

procedure TForm1.btnStartRecordingClick(Sender: TObject);
begin
   SetupVG (VideoGrabber1);
   SetupVG (VideoGrabber2);
   SetupVG (VideoGrabber3);
   SetupVG (VideoGrabber4);
   VideoGrabber5.VideoSource := vs_Mixer;
   VideoGrabber5.Mixer_MosaicLines := 2;
   VideoGrabber5.Mixer_MosaicColumns := 2;
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber1.UniqueID, 0, 1, 1, 0, 0, True, True);
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber2.UniqueID, 0, 1, 2, 0, 0, True, True);
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber3.UniqueID, 0, 2, 1, 0, 0, True, True);
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber4.UniqueID, 0, 2, 2, 0, 0, True, True);
   VideoGrabber5.RecordingMethod := rm_ASF;
   VideoGrabber5.ASFVideoBitRate := 3000000;
   VideoGrabber5.ASFVideoWidth := 1536;
   VideoGrabber5.ASFVideoHeight := 1152;
   VideoGrabber5.StartRecording();
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber5.Stop();
   VideoGrabber1.Stop();
   VideoGrabber2.Stop();
   VideoGrabber3.Stop();
   VideoGrabber4.Stop();
end;

end.
