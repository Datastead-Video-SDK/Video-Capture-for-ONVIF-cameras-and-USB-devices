
#include "TVideoGrabber.h"

const int MAXSTRINGLEN = 500;

BOOL CanClose = false;

//________________________________________________________________________________________________________________
class CVgExample
{
	CVideoGrabber *m_VideoGrabber;
public:
	CVgExample();
	~CVgExample();
	BOOL InitVideoWindowAndCallbacks();
	BOOL PreviewDevice();
	BOOL RecordScreen();
	BOOL PlayClip();
	CVideoGrabber *VideoGrabber() { return m_VideoGrabber; };
};

//________________________________________________________________________________________________________________
static void CALLBACK OnFrameBitmap (void *Object, void *Sender,  TFrameInfo *FrameInfo,  TFrameBitmapInfo *BitmapInfo)
{
	CVgExample *VgExample = (CVgExample*) Sender;

	HBITMAP CurrentBitmap = BitmapInfo->bitmapHandle;
	// ...
	// do what you need with the Current frame bitmap handle
	// ...
}

//________________________________________________________________________________________________________________
void InfoFromCallback (wchar_t *info)
{
	wcscat (info, L"\n\n- click on the video window to get an OnClick event callback");
	wcscat (info, L"\n\n- then press ESC to exit");
	MessageBoxW (0, info, NULL, 0);
}

//________________________________________________________________________________________________________________
static void CALLBACK OnPreviewStarted (void *Object, void *Sender) 
{
	CVgExample *VgExample = (CVgExample*) Sender;

	const int INFOSIZE = 2048;

	wchar_t info[INFOSIZE];
	wcscpy (info, L"started preview of this device: ");
	wcscat (info, VgExample->VideoGrabber()->GetVideoDeviceName ());
	InfoFromCallback (info);
}

//________________________________________________________________________________________________________________
static void CALLBACK OnRecordingStarted (void *Object, void *Sender, const wchar_t *FileName)
{
	CVgExample *VgExample = (CVgExample*) Sender;

	const int INFOSIZE = 2048;

	wchar_t info[INFOSIZE];

	wcscpy (info, L"currently recording the screen to : ");
	wcscat (info, FileName);
	InfoFromCallback (info);
}

//________________________________________________________________________________________________________________
static void CALLBACK OnPlayerOpened (void *Object, void *Sender)
{
	CVgExample *VgExample = (CVgExample*) Sender;

	const int INFOSIZE = 2048;

	wchar_t info[INFOSIZE];

	wcscpy (info, L"currently playing: ");
	wcscat (info, VgExample->VideoGrabber()->GetPlayerFileName());
	InfoFromCallback (info);
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
	m_VideoGrabber->SetOnRecordingStarted (OnRecordingStarted);
	m_VideoGrabber->SetOnPlayerOpened (OnPlayerOpened);
	m_VideoGrabber->SetOnFrameBitmap (OnFrameBitmap);

	return true;
};

//________________________________________________________________________________________________________________
BOOL CVgExample::PreviewDevice()
{
	m_VideoGrabber->SetVideoDevice (0); // 1st video capture in the VideoDevices list

	/*
	 // THIS CODE SELECTS THE VIDEODEVICE FROM ITS NAME IN THE VIDEODEVICES LIST
	int VideoDeviceIndex = m_VideoGrabber->VideoDeviceIndex ("Logitech QuickCam Ultra Vision (WDM)"); // replace by the name of your capture device as it appears in the VideoDevices list
	if (VideoDeviceIndex > -1) {
		m_VideoGrabber->SetVideoDevice (VideoDeviceIndex); 
	}
	*/

	int AnalogVideoStandardIndex = m_VideoGrabber->AnalogVideoStandardIndex (L"PAL B");
	if (AnalogVideoStandardIndex > -1) {
		m_VideoGrabber->SetAnalogVideoStandard (AnalogVideoStandardIndex);
	}

	int VideoSizeIndex = m_VideoGrabber->VideoSizeIndex (L"640x480");
	if (VideoSizeIndex > -1) {
		m_VideoGrabber->SetVideoSize (VideoSizeIndex);
	}

	return m_VideoGrabber->StartPreview();
};

//________________________________________________________________________________________________________________
BOOL CVgExample::RecordScreen()
{
	m_VideoGrabber->SetVideoSource (TVideoSource::vs_ScreenRecording);
	m_VideoGrabber->SetRecordingMethod (TRecordingMethod::rm_ASF);
	m_VideoGrabber->SetASFVideoBitRate (1500000);
	return m_VideoGrabber->StartRecording();
};

//________________________________________________________________________________________________________________
BOOL CVgExample::PlayClip()
{
	m_VideoGrabber->SetPlayerFileName (m_VideoGrabber->GetLast_Recording_FileName());
	return m_VideoGrabber->OpenPlayer();
};

//________________________________________________________________________________________________________________
int APIENTRY WinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR     lpCmdLine,
                     int       nCmdShow)
{
	CVgExample *VgExample = new CVgExample();

	VgExample->InitVideoWindowAndCallbacks();

	int MsgBoxResponse;

	MsgBoxResponse = MessageBoxW (0, L"start the preview of the default capture device?", L"", MB_OKCANCEL);

	if (MsgBoxResponse == IDOK) 
	{
		if (VgExample->PreviewDevice()) 
		{ 
			// device is previewing
		}

	}
	else 
	{
		MsgBoxResponse = MessageBoxW (0, L"perform a screen recording?", L"", MB_OKCANCEL);

		if (MsgBoxResponse == IDOK) 
		{
			if (VgExample->RecordScreen()) 
			{ 
				// screen being recorded
			}
		}
		else 
		{
			MsgBoxResponse = MessageBoxW (0, L"play the last clip recorded", L"", MB_OKCANCEL);

			if (MsgBoxResponse == IDOK) 
			{
				if (VgExample->PlayClip()) 
				{
					// clip playing
				}
			}
		}
	}

	MSG msg;
	while(GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
		if (CanClose) {
			break;
		}
	}

	delete (VgExample);

	return 0;
}




