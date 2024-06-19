#include "quick_start_with_overlays.h"
#include "ui_quick_start_with_overlays.h"
#include <QGraphicsScene>
#include "qpainter.h"
#include <qt_windows.h>
#include <QtWin>
#include <time.h>

__stdcall void OnVideoGrabberLogCb (void *Object, void *Sender, TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ((QuickStartWithOverlays*) Sender)->OnVideoGrabberLog(LogType, Severity, InfoMsg);
}

__stdcall void OnFrameBitmapCb  (void *Object, void *Sender, TFrameInfo *FrameInfo, TFrameBitmapInfo *BitmapInfo)
{
    ((QuickStartWithOverlays*) Sender)->QtOnFrameBitmapCb(FrameInfo, BitmapInfo);
}

__stdcall void OnFrameProgressCb  (void *Object, void *Sender, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId)
{
    ((QuickStartWithOverlays*) Sender)->QtOnFrameProgressCb(FrameNumber, FrameTime, FrameId);
}

void QuickStartWithOverlays::GenerateAndApplyGraphicOverlay(int overlayindex, int width, int height, int leftlocation, int toplocation, bool transparent)
{
    QColor overlaycolor (qrand()%255, qrand()%255, qrand()%255);
    QPixmap overlay_pix0(QSize(width, height));
    if (transparent) {
        overlay_pix0.fill(Qt::transparent);
    }
    QPainter overlay_painter0 (&overlay_pix0);
    Qt::BrushStyle style = Qt::SolidPattern;
    QBrush brush(overlaycolor, style);
    overlay_painter0.setBrush(brush);
    overlay_painter0.drawEllipse(10, 10, width - 10, height - 10);
    HBITMAP hbitmap = QtWin::toHBITMAP(overlay_pix0);

    m_VideoGrabber->SetImageOverlay_LeftLocation (overlayindex, leftlocation);
    m_VideoGrabber->SetImageOverlay_TopLocation (overlayindex, toplocation);
    m_VideoGrabber->SetImageOverlayFromHBitmap3(overlayindex, hbitmap, true);

    if (transparent) {
        m_VideoGrabber->SetImageOverlay_Transparent(overlayindex, true);
    }
    m_VideoGrabber->SetImageOverlay_Enabled(overlayindex, true);
}

void QuickStartWithOverlays::QtOnFrameProgressCb  (unsigned int  FrameNumber, __int64  FrameTime, int  FrameId)
{
}

void QuickStartWithOverlays::QtOnFrameBitmapCb  (TFrameInfo *FrameInfo, TFrameBitmapInfo *BitmapInfo)
{
    GenerateAndApplyGraphicOverlay (0, 100, 150, qrand()%m_VideoGrabber->GetVideoWidth(), qrand()%m_VideoGrabber->GetVideoHeight(), false);
    GenerateAndApplyGraphicOverlay (1, 400, 400, 100 + qrand()%50, 100 + qrand()%50, true);
}


QuickStartWithOverlays::QuickStartWithOverlays(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::QuickStartWithOverlays),
    m_VideoGrabber(NULL)
{
    ui->setupUi(this);
    qsrand(time(0));
    m_VideoGrabber = new CVideoGrabber(this); // this is returned as "Sender" parameter by the callbacks to retrieve the current class instance, see OnVideoGrabberLogCb above
    ui->wdgVideoGrabberContainer->setStyleSheet("background-color:black;");
    m_VideoGrabber->SetParentWindow((HWND)ui->wdgVideoGrabberContainer->winId());
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
    m_VideoGrabber->SetDisplay_AspectRatio(TAspectRatio::ar_Box);
    m_VideoGrabber->SetOnLog(&OnVideoGrabberLogCb);
    m_VideoGrabber->SetOnFrameBitmap(&OnFrameBitmapCb);
    m_VideoGrabber->SetOnFrameProgress(&OnFrameProgressCb);
}

QuickStartWithOverlays::~QuickStartWithOverlays()
{
    delete m_VideoGrabber;
    delete ui;
}

void QuickStartWithOverlays::OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ui->txtLog->append(QString::fromWCharArray(InfoMsg));
}

void QuickStartWithOverlays::on_btnStartScreenCapture_clicked()
{
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_ScreenRecording);
    m_VideoGrabber->StartPreview();
    //m_VideoGrabber->SetRecordingMethod(TRecordingMethod::rm_ASF);
    //m_VideoGrabber->StartRecording();
}

void QuickStartWithOverlays::on_btnSartIPCameraPreview_clicked()
{
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_IPCamera);
    //m_VideoGrabber->SetAuthentication(at_IPCamera, L"username", L"password"); // if needed
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_Mixer);
    m_VideoGrabber->UseNearestVideoSize(720, 480, true);

    m_VideoGrabber->SetIPCameraURL(L"rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov");
    //m_VideoGrabber->SetAudioDeviceRendering(true); // if audio rendering needed
    m_VideoGrabber->StartPreview();
}

void QuickStartWithOverlays::on_btnResizeWidgetContainer_clicked()
{
    ui->wdgVideoGrabberContainer->resize(800, 600);
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
}

void QuickStartWithOverlays::on_btnStop_clicked()
{
    m_VideoGrabber->Stop();
}

