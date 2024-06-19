#ifndef QUICKSTARTMAINDEMO_H
#define QUICKSTARTMAINDEMO_H

#include <QMainWindow>
#include "TVideoGrabber.h"

namespace Ui {
class QuickStartWithOverlays;
}

class QuickStartWithOverlays : public QMainWindow
{
    Q_OBJECT

public:
    explicit QuickStartWithOverlays(QWidget *parent = 0);
    ~QuickStartWithOverlays();

    void OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg);

    void QtOnFrameBitmapCb  (TFrameInfo *FrameInfo, TFrameBitmapInfo *BitmapInfo);
    void QtOnFrameProgressCb  (unsigned int  FrameNumber, __int64  FrameTime, int  FrameId);

private slots:
    void on_btnStartScreenCapture_clicked();

    void on_btnSartIPCameraPreview_clicked();

    void on_btnResizeWidgetContainer_clicked();

    void on_btnStop_clicked();
private:
    Ui::QuickStartWithOverlays *ui;
    CVideoGrabber *m_VideoGrabber;

    void GenerateAndApplyGraphicOverlay(int overlayindex, int width, int height, int leftlocation, int toplocation, bool transparent);
};

#endif // QUICKSTARTMAINDEMO_H
