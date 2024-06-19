#include "QTRtspDemo.h"
#include "ui_QTRtspDemo.h"

void CALLBACK OnVideoGrabberLogCb (void *Object, void *Sender, TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ((QTRtspDemo*) Sender)->OnVideoGrabberLog(LogType, Severity, InfoMsg);
}

QTRtspDemo::QTRtspDemo(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::QTRtspDemo),
    m_VideoGrabber(NULL)
{
    ui->setupUi(this);
    m_VideoGrabber = new CVideoGrabber(this); // this is returned as "Sender" parameter by the callbacks to retrieve the current class instance, see OnVideoGrabberLogCb above
    ui->wdgVideoGrabberContainer->setStyleSheet("background-color:black;");
    m_VideoGrabber->SetParentWindow((HWND)ui->wdgVideoGrabberContainer->winId());
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
    m_VideoGrabber->SetDisplay_AspectRatio(TAspectRatio::ar_Box);
    m_VideoGrabber->SetOnLog(&OnVideoGrabberLogCb);
}

QTRtspDemo::~QTRtspDemo()
{
    delete m_VideoGrabber;
    delete ui;
}

void QTRtspDemo::OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ui->txtLog->append(QString::fromWCharArray(InfoMsg));
}

void QTRtspDemo::on_btnSartIPCameraPreview_clicked()
{
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_IPCamera);
    //m_VideoGrabber->SetAuthentication(at_IPCamera, L"username", L"password"); // if needed

    m_VideoGrabber->SetIPCameraURL(L"rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov");
    m_VideoGrabber->SetAudioDeviceRendering(true); // if audio rendering needed
    m_VideoGrabber->StartPreview();
}

void QTRtspDemo::on_btnResizeWidgetContainer_clicked()
{
    ui->wdgVideoGrabberContainer->resize(800, 600);
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
}

void QTRtspDemo::on_btnStop_clicked()
{
    m_VideoGrabber->Stop();
}

