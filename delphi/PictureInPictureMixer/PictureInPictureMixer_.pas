unit PictureInPictureMixer_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab, Buttons;

type
  TForm1 = class(TForm)
    VideoGrabberSrc1: TVideoGrabber;
    btnSrc1Start: TButton;
    btnSrc2Start: TButton;
    VideoGrabberSrc2: TVideoGrabber;
    cboVideoDevices1: TComboBox;
    btnSrc2Stop: TButton;
    btnSrc1Stop: TButton;
    Label1: TLabel;
    cboVideoDevices2: TComboBox;
    GroupBox1: TGroupBox;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    btnDestStart: TButton;
    edtDestWidth: TEdit;
    edtDestHeight: TEdit;
    btnSizeOk: TButton;
    btnStartRecording: TButton;
    Button2: TButton;
    edtOutputFrameRate: TEdit;
    btnFrameRateOk: TButton;
    btnPlayRecorded: TButton;
    VideoGrabberMixer: TVideoGrabber;
    ChkSendToMixer1: TCheckBox;
    mmoLog: TMemo;
    ChkSendToMixer2: TCheckBox;
    chkPipA: TCheckBox;
    edtLeftA: TEdit;
    edtTopA: TEdit;
    edtWidthA: TEdit;
    edtHeightA: TEdit;
    Label3: TLabel;
    chkPipB: TCheckBox;
    edtLeftB: TEdit;
    Label4: TLabel;
    edtTopB: TEdit;
    edtWidthB: TEdit;
    edtHeightB: TEdit;
    btnMoveToTop: TButton;
    Button1: TButton;
    Label2: TLabel;
    Label8: TLabel;
    btnOpenClipA: TSpeedButton;
    btnPlayClipA: TButton;
    btnStopClipA: TButton;
    Label9: TLabel;
    btnOpenClipB: TSpeedButton;
    btnPlayClipB: TButton;
    btnStopClipB: TButton;
    OpenDialog: TOpenDialog;
    procedure btnSrc1StartClick(Sender: TObject);
    procedure btnDestStartClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnSrc2StartClick(Sender: TObject);
    procedure btnDestStopClick(Sender: TObject);
    procedure cboVideoDevices1Change(Sender: TObject);
    procedure cboVideoDevices2Change(Sender: TObject);
    procedure btnSrc1StopClick(Sender: TObject);
    procedure btnSrc2StopClick(Sender: TObject);
    procedure btnStartRecordingClick(Sender: TObject);
    procedure btnPlayRecordedClick(Sender: TObject);
    procedure btnFrameRateOkClick(Sender: TObject);
    procedure VideoGrabberSrc1VideoDeviceSelected(Sender: TObject);
    procedure VideoGrabberSrc2VideoDeviceSelected(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType;
      Severity, InfoMsg: String);
    procedure VideoGrabberMixerRecordingStarted(Sender: TObject;
      FileName: String);
    procedure VideoGrabberMixerPlayerOpened(Sender: TObject);
    procedure btnSizeOkClick(Sender: TObject);
    procedure VideoGrabberMixerPreviewStarted(Sender: TObject);
    procedure ChkSendToMixer1Click(Sender: TObject);
    procedure ChkSendToMixer2Click(Sender: TObject);
    procedure SetPipA (Sender: TObject);
    procedure SetPipB (Sender: TObject);
    procedure btnOpenClipAClick(Sender: TObject);
    procedure btnOpenClipBClick(Sender: TObject);
    procedure btnPlayClipAClick(Sender: TObject);
    procedure btnStopClipAClick(Sender: TObject);
    procedure btnPlayClipBClick(Sender: TObject);
    procedure btnStopClipBClick(Sender: TObject);
  private
    FCurrentMixer1ID: LongInt;
    FCurrentMixer2ID: LongInt;
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

const
   MAXSOURCES = 2;

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer; MaxCount: Integer = 0);
begin
   ComboBox.Items.Text := List;
   if ComboBox.Items.Count > 0 then begin
      ComboBox.ItemIndex := Index;
   end;
   if MaxCount > 0 then begin
      while ComboBox.Items.count > MaxCount do begin
         ComboBox.Items.Delete (ComboBox.Items.Count - 1);
      end;
   end;
end;

const
   OPEN_MEDIA_FILES = '*.mp*;*.vro;*.avi;*.wav;*.asf;*.wm*;*.vob;*.avs;*.mov;*.divx';

procedure TForm1.FormCreate(Sender: TObject);
begin
   FCurrentMixer1ID := 0;
   FCurrentMixer2ID := 0;

   VideoGrabberMixer.VideoSource := vs_Mixer;
   
   VideoGrabberSrc1.Display_AutoSize := false;
   VideoGrabberSrc2.Display_AutoSize := false;

   AssignListToComboBox (cboVideoDevices1, VideoGrabberSrc1.VideoDevices, VideoGrabberSrc1.VideoDevice);
   AssignListToComboBox (cboVideoDevices2, VideoGrabberSrc2.VideoDevices, VideoGrabberSrc2.VideoDevice);
end;

procedure TForm1.btnSizeOkClick(Sender: TObject);
begin
   VideoGrabberMixer.UseNearestVideoSize (StrToIntDef (edtDestWidth.Text, 320), StrToIntDef (edtDestHeight.Text, 240), true); 
end;

procedure TForm1.btnSrc1StartClick(Sender: TObject);
begin
   VideoGrabberSrc1.StartPreview;
end;

procedure TForm1.btnSrc1StopClick(Sender: TObject);
begin
   VideoGrabberSrc1.StopPreview;
end;

procedure TForm1.btnSrc2StartClick(Sender: TObject);
begin
   VideoGrabberSrc2.StartPreview;
end;

procedure TForm1.btnSrc2StopClick(Sender: TObject);
begin
   VideoGrabberSrc2.StopPreview;
end;

procedure TForm1.btnDestStartClick(Sender: TObject);
begin
   VideoGrabberMixer.VideoSource := vs_Mixer;
   VideoGrabberMixer.StartPreview;
end;

procedure TForm1.btnDestStopClick(Sender: TObject);
begin
   VideoGrabberMixer.Stop;
end;

procedure TForm1.cboVideoDevices1Change(Sender: TObject);
begin
   VideoGrabberSrc1.VideoDevice := cboVideoDevices1.ItemIndex;
end;

procedure TForm1.cboVideoDevices2Change(Sender: TObject);
begin
   VideoGrabberSrc2.VideoDevice := cboVideoDevices2.ItemIndex;
end;

procedure TForm1.SetPipA (Sender: TObject);
var
   PIPLeft, PIPTop, PIPWidth, PIPHeight: LongInt;
   ActivatePIP, MoveToTop: Boolean;
begin
   ActivatePIP := chkPipA.Checked;
   MoveToTop := TComponent(Sender).Tag = 1; // the tag of the "move to top" button = 1, if the sender's tag = 1 it's the "move to top" button that has been pressed
   PIPLeft   := StrToIntDef (EdtLeftA.Text, 0);
   PIPTop    := StrToIntDef (EdtTopA.Text, 0);
   PIPWidth  := StrToIntDef (EdtWidthA.Text, 0);
   PIPHeight := StrToIntDef (EdtHeightA.Text, 0);
   VideoGrabberMixer.Mixer_SetupPIPFromSource (VideoGrabberSrc1.UniqueId, 0, 0, 0, 0, ActivatePIP, PIPLeft, PIPTop, PIPWidth, PIPHeight, MoveToTop);
end;

procedure TForm1.SetPipB (Sender: TObject);
var
   PIPLeft, PIPTop, PIPWidth, PIPHeight: LongInt;
   ActivatePIP, MoveToTop: Boolean;
begin
   ActivatePIP := chkPipB.Checked;
   MoveToTop := TComponent(Sender).Tag = 1; // the tag of the "move to top" button = 1, if the sender's tag = 1 it's the "move to top" button that has been pressed
   PIPLeft   := StrToIntDef (EdtLeftB.Text, 0);
   PIPTop    := StrToIntDef (EdtTopB.Text, 0);
   PIPWidth  := StrToIntDef (EdtWidthB.Text, 0);
   PIPHeight := StrToIntDef (EdtHeightB.Text, 0);
   VideoGrabberMixer.Mixer_SetupPIPFromSource (VideoGrabberSrc2.UniqueId, 0, 0, 0, 0, ActivatePIP, PIPLeft, PIPTop, PIPWidth, PIPHeight, MoveToTop);
end;

procedure TForm1.ChkSendToMixer1Click(Sender: TObject);
begin
   VideoGrabberMixer.Mixer_Activation (FCurrentMixer1ID, ChkSendToMixer1.Checked);
end;

procedure TForm1.ChkSendToMixer2Click(Sender: TObject);
begin
   VideoGrabberMixer.Mixer_Activation (FCurrentMixer2ID, ChkSendToMixer2.Checked);
end;

procedure TForm1.btnStartRecordingClick(Sender: TObject);
begin
   VideoGrabberMixer.VideoSource := vs_Mixer;
   VideoGrabberMixer.StartRecording;
end;

procedure TForm1.btnPlayRecordedClick(Sender: TObject);
begin
   VideoGrabberMixer.PlayerFileName := VideoGrabberMixer.Last_Recording_FileName;
   VideoGrabberMixer.OpenPlayer;
end;

procedure TForm1.btnFrameRateOkClick(Sender: TObject);
begin
   VideoGrabberMixer.FrameRate := StrToFloatDef (edtOutputFrameRate.Text, 30);
end;

procedure TForm1.VideoGrabberSrc1VideoDeviceSelected(Sender: TObject);
begin
   cboVideoDevices1.ItemIndex := VideoGrabberSrc1.VideoDevice;
end;

procedure TForm1.VideoGrabberSrc2VideoDeviceSelected(Sender: TObject);
begin
   cboVideoDevices2.ItemIndex := VideoGrabberSrc2.VideoDevice;
end;

procedure TForm1.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add ('[' + Severity + '] ' + InfoMsg);
end;

procedure TForm1.VideoGrabberMixerPreviewStarted(Sender: TObject);
begin
   mmoLog.Lines.Add ('previewing');
end;

procedure TForm1.VideoGrabberMixerRecordingStarted(Sender: TObject;
  FileName: String);
begin
   mmoLog.Lines.Add ('recording to ' + FileName);
end;

procedure TForm1.VideoGrabberMixerPlayerOpened(Sender: TObject);
begin
   mmoLog.Lines.Add ('playing ' + TVideoGrabber(Sender).PlayerFileName);
end;


procedure TForm1.btnOpenClipAClick(Sender: TObject);
begin
   OpenDialog.FileName := OPEN_MEDIA_FILES;
   if OpenDialog.Execute then begin
      VideoGrabberSrc1.PlayerFileName := OpenDialog.FileName;
      VideoGrabberSrc1.OpenPlayer;
   end;
end;

procedure TForm1.btnOpenClipBClick(Sender: TObject);
begin
   OpenDialog.FileName := OPEN_MEDIA_FILES;
   if OpenDialog.Execute then begin
      VideoGrabberSrc2.PlayerFileName := OpenDialog.FileName;
      VideoGrabberSrc2.OpenPlayer;
   end;
end;

procedure TForm1.btnPlayClipAClick(Sender: TObject);
begin
   VideoGrabberSrc1.RunPlayer;
end;

procedure TForm1.btnStopClipAClick(Sender: TObject);
begin
   VideoGrabberSrc1.StopPlayer;
end;

procedure TForm1.btnPlayClipBClick(Sender: TObject);
begin
   VideoGrabberSrc2.RunPlayer;
end;

procedure TForm1.btnStopClipBClick(Sender: TObject);
begin
   VideoGrabberSrc2.StopPlayer;
end;

end.

