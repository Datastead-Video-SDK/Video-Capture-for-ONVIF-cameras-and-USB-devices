#ifndef QTRtspDemo_H
#define QTRtspDemo_H

#include <QMainWindow>
#include "TVideoGrabber.h"

namespace Ui {
class QTRtspDemo;
}

class QTRtspDemo : public QMainWindow
{
    Q_OBJECT

public:
    explicit QTRtspDemo(QWidget *parent = 0);
    virtual ~QTRtspDemo();

    void OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg);

private slots:
    void on_btnSartIPCameraPreview_clicked();

    void on_btnResizeWidgetContainer_clicked();

    void on_btnStop_clicked();

    //void OnVideoGrabberLogCb (void *Object, void *Sender, TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg);

private:
    Ui::QTRtspDemo *ui;
    CVideoGrabber *m_VideoGrabber;
};

#endif // QTRtspDemo_H
