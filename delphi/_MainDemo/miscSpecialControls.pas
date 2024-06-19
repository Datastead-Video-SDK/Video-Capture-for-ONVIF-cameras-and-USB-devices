unit miscSpecialControls;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  ExtCtrls, StdCtrls, VidGrab;

type
  TfrmSpecialControls = class(TForm)
    GroupBox1: TGroupBox;
    btnPanTiltUp: TButton;
    btnPanTiltLeft: TButton;
    btnPanTiltHome: TButton;
    btnPanTiltRight: TButton;
    btnPanTiltDown: TButton;
    rdgGpio0: TRadioGroup;
    rdgGpio1: TRadioGroup;
    rdgGpio2: TRadioGroup;
    rdgGpio3: TRadioGroup;
    procedure rdgGpio0Click(Sender: TObject);
    procedure rdgGpio2Click(Sender: TObject);
    procedure rdgGpio1Click(Sender: TObject);
    procedure rdgGpio3Click(Sender: TObject);
    procedure btnPanTiltUpClick(Sender: TObject);
    procedure btnPanTiltDownClick(Sender: TObject);
    procedure btnPanTiltLeftClick(Sender: TObject);
    procedure btnPanTiltRightClick(Sender: TObject);
    procedure btnPanTiltHomeClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmSpecialControls: TfrmSpecialControls;

implementation

uses MainForm;

{$R *.DFM}

procedure TfrmSpecialControls.btnPanTiltUpClick(Sender: TObject);
begin
   frmMainForm.VideoGrabber.SendCameraCommand (0, 1, true);
end;

procedure TfrmSpecialControls.btnPanTiltDownClick(Sender: TObject);
begin
   frmMainForm.VideoGrabber.SendCameraCommand (0, -1, true);
end;

procedure TfrmSpecialControls.btnPanTiltLeftClick(Sender: TObject);
begin
   frmMainForm.VideoGrabber.SendCameraCommand (-1, 0, true);
end;

procedure TfrmSpecialControls.btnPanTiltRightClick(Sender: TObject);
begin
   frmMainForm.VideoGrabber.SendCameraCommand (1, 0, true);
end;

procedure TfrmSpecialControls.btnPanTiltHomeClick(Sender: TObject);
begin
   frmMainForm.VideoGrabber.SendCameraCommand (0, 0, false);
end;

procedure TfrmSpecialControls.rdgGpio0Click(Sender: TObject);
begin
   frmMainForm.VideoGrabber.PutMiscDeviceControl (mdc_GPIO, 0, rdgGpio0.ItemIndex);
end;

procedure TfrmSpecialControls.rdgGpio1Click(Sender: TObject);
begin
   frmMainForm.VideoGrabber.PutMiscDeviceControl (mdc_GPIO, 1, rdgGpio1.ItemIndex);
end;

procedure TfrmSpecialControls.rdgGpio2Click(Sender: TObject);
begin
   frmMainForm.VideoGrabber.PutMiscDeviceControl (mdc_GPIO, 2, rdgGpio2.ItemIndex);
end;

procedure TfrmSpecialControls.rdgGpio3Click(Sender: TObject);
begin
   frmMainForm.VideoGrabber.PutMiscDeviceControl (mdc_GPIO, 3, rdgGpio3.ItemIndex);
end;

end.


