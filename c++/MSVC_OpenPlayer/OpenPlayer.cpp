
#include "TVideoGrabber.h"


void __stdcall OnPlayerOpened (void* Object, void* Sender)
{
	CVideoGrabber *VideoGrabberSender = (CVideoGrabber*) (Sender);

	const wchar_t *PlayerFileName = VideoGrabberSender->GetPlayerFileName ();
	MessageBoxW (0, PlayerFileName, L"playing: ", 0);
}

int APIENTRY WinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR     lpCmdLine,
                     int       nCmdShow)
{

	CVideoGrabber *VideoGrabber = new CVideoGrabber ();
	VideoGrabber->SetDisplay_Embedded (false);
	VideoGrabber->SetOnPlayerOpened (OnPlayerOpened);
	VideoGrabber->Display_SetLocation (100, 100, 1280, 720);
	// the LAV filters codecs are recommended for the file playback, download them from https://github.com/Nevcairiel/LAVFilters/releases
	#ifdef _WIN64
	VideoGrabber->SetExtraDLLPath(L"C:\\LAV_Folder\\LAVFilters-0.76-x64");
	#else _WIN64
	VideoGrabber->SetExtraDLLPath(L"C:\\LAV_Folder\\LAVFilters-0.76-x86");
	#endif _WIN64
	VideoGrabber->SetPlayerFileName(L"C:\\videos\\the_clip_to_open.mp4");
	if (! VideoGrabber->OpenPlayer())
		MessageBoxW (0, L"failed to open", NULL, 0);
	{
	}
	MessageBoxW (0, L"click OK to destroy the component", L"", 0);

	delete (VideoGrabber);

	return 0;
}



