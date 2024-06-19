#include "QTRtspDemo.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QTRtspDemo w;
    w.show();

    return a.exec();
}
