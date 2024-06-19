#include "QTWebcamStreamingDemo.h"
#include "ui_QTWebcamStreamingDemo.h"

void CALLBACK OnVideoGrabberLogCb (void *Object, void *Sender, TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ((QTWebcamStreamingDemo*) Sender)->OnVideoGrabberLog(LogType, Severity, InfoMsg);
}

QTWebcamStreamingDemo::QTWebcamStreamingDemo(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::QTWebcamStreamingDemo),
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

QTWebcamStreamingDemo::~QTWebcamStreamingDemo()
{
    delete m_VideoGrabber;
    delete ui;
}

void QTWebcamStreamingDemo::OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ui->txtLog->append(QString::fromWCharArray(InfoMsg));
}

void QTWebcamStreamingDemo::on_btnStartWebcamStreaming_clicked()
{
    /// define HIDEPREVIEW if you do not want to see the live preview
    #ifdef HIDEPREVIEW
    m_VideoGrabber.SetVideoRenderer(vr_None);
    #endif

    m_VideoGrabber->SetVideoSource(TVideoSource::vs_VideoCaptureDevice);
    int DeviceIndex = m_VideoGrabber->VideoDeviceIndex (L"webcam name"); /// replace "webcam name" by the real name of the camera
    if (DeviceIndex > -1) {
        m_VideoGrabber->SetVideoDevice(DeviceIndex);
        m_VideoGrabber->SetFrameGrabber(TFrameGrabber::fg_Disabled);
        m_VideoGrabber->SetNetworkStreamingType(TNetworkStreamingType::nst_VideoStreaming);
        m_VideoGrabber->EnableMultipurposeEncoder (TMultipurposeEncoderInstance::mpe_Streaming, true);
        m_VideoGrabber->SetMultipurposeEncoderSettings (TMultipurposeEncoderInstance::mpe_Streaming, L"ffmpegLGPL.exe -flags low_delay -fflags nobuffer -i %PIPE% -vcodec libopenh264 -ratecontrol 1 -max_nal_size 4096 -b:v 1000k -maxrate 1000k -avioflags direct -f mpegts udp://127.0.0.1:12801?pkt_size=1316");
        m_VideoGrabber->StartPreview();
    }
    else {
    // camera not found
    }
}

void QTWebcamStreamingDemo::on_btnResizeWidgetContainer_clicked()
{
    ui->wdgVideoGrabberContainer->resize(800, 600);
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
}

void QTWebcamStreamingDemo::on_btnStop_clicked()
{
    m_VideoGrabber->Stop();
}

