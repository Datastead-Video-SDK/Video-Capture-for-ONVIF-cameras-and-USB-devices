#ifndef QTWebcamStreamingDemo_H
#define QTWebcamStreamingDemo_H

#include <QMainWindow>
#include "TVideoGrabber.h"

namespace Ui {
class QTWebcamStreamingDemo;
}

class QTWebcamStreamingDemo : public QMainWindow
{
    Q_OBJECT

public:
    explicit QTWebcamStreamingDemo(QWidget *parent = 0);
    ~QTWebcamStreamingDemo();

    void OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg);

private slots:
    void on_btnStartWebcamStreaming_clicked();

    void on_btnResizeWidgetContainer_clicked();

    void on_btnStop_clicked();

    //void OnVideoGrabberLogCb (void *Object, void *Sender, TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg);

private:
    Ui::QTWebcamStreamingDemo *ui;
    CVideoGrabber *m_VideoGrabber;
};

#endif // QTWebcamStreamingDemo_H
