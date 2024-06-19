unit SynchronizedPlayers_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab, Buttons, ComCtrls;

type
  TForm1 = class(TForm)
    edtFileName: TEdit;
    btnPlayerOpenFile: TSpeedButton;
    VideoGrabber2: TVideoGrabber;
    VideoGrabber3: TVideoGrabber;
    VideoGrabber4: TVideoGrabber;
    VideoGrabber1: TVideoGrabber;
    btnOpen: TButton;
    btnClose: TButton;
    btnPause: TSpeedButton;
    btnStop: TSpeedButton;
    btnPlay: TSpeedButton;
    dlgOpen: TOpenDialog;
    TrackBar1: TTrackBar;
    TrackBar2: TTrackBar;
    TrackBar3: TTrackBar;
    TrackBar4: TTrackBar;
    chkSync1: TCheckBox;
    chkSync2: TCheckBox;
    chkSync3: TCheckBox;
    chkSync4: TCheckBox;
    procedure btnPlayerOpenFileClick(Sender: TObject);
    procedure btnOpenClick(Sender: TObject);
    procedure btnCloseClick(Sender: TObject);
    procedure btnPauseClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure btnPlayClick(Sender: TObject);
    procedure chkSync1Click(Sender: TObject);
    procedure chkSync2Click(Sender: TObject);
    procedure chkSync3Click(Sender: TObject);
    procedure chkSync4Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure TForm1.btnPlayerOpenFileClick(Sender: TObject);
begin
   dlgOpen.FileName := '*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob';
   if dlgOpen.Execute then begin
      edtFileName.Text := dlgOpen.FileName;
   end;
end;

procedure SetupPlayer (VideoGrabber: TVideoGrabber; SynchronizationRole: TSynchronizationRole; VideoClip: String);
begin
   VideoGrabber.Synchronized := True;
   VideoGrabber.SynchronizationRole := SynchronizationRole;
   VideoGrabber.TextOverlay_Enabled := True;
   VideoGrabber.AutoStartPlayer := False;
   VideoGrabber.PlayerFileName := VideoClip;
end;

// NOTE 1:
// when its Synchronized property is enabled, invoking the command applied on one component
// is applied to all the other components that have also their Synchronized property enabled
// (within the same application).

// NOTE 2:
// the trackbars are associated to the TVideoGrabber components through their "PlayerTrackbar" property

procedure TForm1.btnOpenClick(Sender: TObject);
begin
   SetupPlayer (VideoGrabber1, sr_Master, edtFileName.Text);
   SetupPlayer (VideoGrabber2, sr_Slave, edtFileName.Text);
   SetupPlayer (VideoGrabber3, sr_Slave, edtFileName.Text);
   SetupPlayer (VideoGrabber4, sr_Slave, edtFileName.Text);

   VideoGrabber1.ClosePlayer; // to close synchroneously any clip previously opened
   VideoGrabber1.OpenPlayer;
   VideoGrabber1.StartSynchronized;
end;

procedure TForm1.btnCloseClick(Sender: TObject);
begin
   VideoGrabber1.ClosePlayer;
end;

procedure TForm1.btnPauseClick(Sender: TObject);
begin
   VideoGrabber1.PausePlayer;
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber1.StopPlayer;
end;

procedure TForm1.btnPlayClick(Sender: TObject);
begin
   VideoGrabber1.RunPlayer;
end;

procedure TForm1.chkSync1Click(Sender: TObject);
begin
   VideoGrabber1.Synchronized := chkSync1.Checked;
end;

procedure TForm1.chkSync2Click(Sender: TObject);
begin
   VideoGrabber2.Synchronized := chkSync2.Checked;
end;

procedure TForm1.chkSync3Click(Sender: TObject);
begin
   VideoGrabber3.Synchronized := chkSync3.Checked;
end;

procedure TForm1.chkSync4Click(Sender: TObject);
begin
   VideoGrabber4.Synchronized := chkSync4.Checked;
end;

end.
