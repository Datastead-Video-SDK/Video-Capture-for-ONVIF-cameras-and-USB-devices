# This Makefile will build a DLL and an application using the DLL.

all: vgtest.exe

vgtest.exe:
	g++ -c vgtest.cpp TVideoGrabber.cpp
	g++ -o vgtest vgtest.o TVideoGrabber.o

clean:
	rm vgtest.o TVideoGrabber.o vgtest.exe