#include "QTWebcamStreamingDemo.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QTWebcamStreamingDemo w;
    w.show();

    return a.exec();
}
