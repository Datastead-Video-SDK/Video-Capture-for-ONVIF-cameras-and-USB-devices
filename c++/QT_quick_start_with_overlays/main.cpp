#include "quick_start_with_overlays.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QuickStartWithOverlays w;
    w.show();

    return a.exec();
}
