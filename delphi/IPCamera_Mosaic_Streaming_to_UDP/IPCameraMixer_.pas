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
    procedure FormCreate(Sender: TObject);
  private
    FStreamingEncoderId: LongInt;
  public
    { Déclarations publiques }
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure SetupVG (vgx: TVideoGrabber; URL: string);
begin
   vgx.VideoSource := vs_IPcamera;
   vgx.SyncPreview := sp_Disabled;
   vgx.IPCameraURL := URL;
   vgx.StartPreview();
end;

procedure TForm1.btnStartRecordingClick(Sender: TObject);
begin
   SetupVG (VideoGrabber1, 'rtsp://... put your URL 1 here);
   SetupVG (VideoGrabber2, 'rtsp://... put your URL 2 here);
   SetupVG (VideoGrabber3, 'rtsp://... put your URL 3 here);
   SetupVG (VideoGrabber4, 'rtsp://... put your URL 3 here);
   VideoGrabber5.VideoSource := vs_Mixer;
   VideoGrabber5.UseNearestVideoSize (1280, 720, true); // to start the mixer in 1280x720
   VideoGrabber5.Mixer_MosaicLines := 2;
   VideoGrabber5.Mixer_MosaicColumns := 2;
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber1.UniqueID, 0, 1, 1, 0, 0, True, True);
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber2.UniqueID, 0, 1, 2, 0, 0, True, True);
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber3.UniqueID, 0, 2, 1, 0, 0, True, True);
   VideoGrabber5.Mixer_AddToMixer (VideoGrabber4.UniqueID, 0, 2, 2, 0, 0, True, True);
   if FStreamingEncoderId = -1 then begin
      FStreamingEncoderId := VideoGrabber5.Encoders_CreateInstanceForStreaming ('udp://127.0.0.1:10124'); // destination IP/port for the UDP streaming
   end;
   if FStreamingEncoderId = -1 then begin
      showmessage ('error: multipurpose encoder not installed!');
   end
   else begin
       Videograbber5.Encoder_SetStr (FStreamingEncoderId, Enc_Video_Codec, 'h264'); /// or h264
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Video_Enabled_bool, 1);
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Audio_Enabled_bool, 1);
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Video_BitRate_kb, 2000);
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Video_rc_MinBitRate_kb, 1800);
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Video_rc_MaxBitRate_kb, 2200);
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Video_IDR_Interval, 30);
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_Video_GPU_Encoder, LongInt (Enc_GPU_Auto));
       Videograbber5.Encoder_SetInt (FStreamingEncoderId, Enc_IsActive_bool, 1);
       VideoGrabber5.StartPreview();
   end;
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber5.Stop();
   VideoGrabber1.Stop();
   VideoGrabber2.Stop();
   VideoGrabber3.Stop();
   VideoGrabber4.Stop();
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
   FStreamingEncoderId := -1;
end;

end.
