#include "RTSP_to_OpenCV.h"

using namespace cv;

const int MAXSTRINGLEN = 500;

BOOL CanClose = false;

//________________________________________________________________________________________________________________
static void CALLBACK OnFrameBitmap (void *Object, void *Sender,  TFrameInfo *FrameInfo,  TFrameBitmapInfo *BitmapInfo)
{
	CVgExample *VgExample = (CVgExample*) Sender;

	HBITMAP CurrentBitmap = BitmapInfo->bitmapHandle;

	Mat mat;

	if (BitmapInfo->bitmapBitsPerPixel == 32) {
		mat.create(BitmapInfo->bitmapWidth, BitmapInfo->bitmapHeight, CV_8UC4);
	}
	if (BitmapInfo->bitmapBitsPerPixel == 24) {
		mat.create(BitmapInfo->bitmapWidth, BitmapInfo->bitmapHeight, CV_8UC3);
	}
	else {
		return;
	}
	memcpy(mat.data, BitmapInfo->bitmapDataPtr, BitmapInfo->bitmapSize);
	// ...
	// do what you need with the OpenCV image
	// ...
}

//________________________________________________________________________________________________________________
static void CALLBACK OnPreviewStarted (void *Object, void *Sender) 
{
	CVgExample *VgExample = (CVgExample*) Sender;
	/// notification of preview started
}

//________________________________________________________________________________________________________________
static void CALLBACK OnClick (void *Object, void *Sender) 
{
	CVgExample *VgExample = (CVgExample*) Sender;

	MessageBoxW (0, L"clicked", L"", 0);
}

//________________________________________________________________________________________________________________
static void CALLBACK OnKeyPress (void *Object, void *Sender, int  VideoWindow, wchar_t *Key, int  PhysicalKey, int  ShiftState)
{
	CVgExample *VgExample = (CVgExample*) Sender; 

	if (*Key == wchar_t(27)) { // if ESC has been pressed
		CanClose = true;
	}
}

//________________________________________________________________________________________________________________
CVgExample::CVgExample()
{
	m_VideoGrabber = new CVideoGrabber (this); // "this" is the pointer to the current instance of CVgExample, that will be returned by the "Sender" parameters of the TVideoGrabber's events
}

//________________________________________________________________________________________________________________
CVgExample::~CVgExample()
{
	delete (m_VideoGrabber);
}

//________________________________________________________________________________________________________________
BOOL CVgExample::InitVideoWindowAndCallbacks()
{
	m_VideoGrabber->SetDisplay_Embedded (false);
	m_VideoGrabber->SetDisplay_MouseMovesWindow(false);
	m_VideoGrabber->Display_SetLocation (100, 100, 320, 240);

	m_VideoGrabber->SetOnClick (OnClick);
	m_VideoGrabber->SetOnKeyPress (OnKeyPress);
	m_VideoGrabber->SetOnPreviewStarted (OnPreviewStarted);
	m_VideoGrabber->SetOnFrameBitmap (OnFrameBitmap);

	return true;
};

//________________________________________________________________________________________________________________
BOOL CVgExample::StartRTSP()
{
	m_VideoGrabber->SetVideoSource (TVideoSource::vs_IPCamera);
	m_VideoGrabber->SetOpenURLAsync(FALSE);
	m_VideoGrabber->SetIPCameraURL(L"rtmp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov");
	return m_VideoGrabber->StartPreview();
};

//________________________________________________________________________________________________________________
int APIENTRY WinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR     lpCmdLine,
                     int       nCmdShow)
{
	CVgExample *VgExample = new CVgExample();

	VgExample->InitVideoWindowAndCallbacks();

	if (! VgExample->StartRTSP())
	{ 
		MessageBox(0, "failed to open the URL, verify that the Datastead RTSP/RTMP/HTTP/ONVIF source is installed and that the URL syntax is correct", NULL, 0);
	}
	else {
		/// rendering

		MSG msg;
		while (GetMessage(&msg, NULL, 0, 0))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
			if (CanClose) {
				break;
			}
		}
	}

	delete (VgExample);

	return 0;
}




