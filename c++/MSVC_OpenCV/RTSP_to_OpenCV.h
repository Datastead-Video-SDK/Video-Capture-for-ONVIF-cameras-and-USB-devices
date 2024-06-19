#pragma once

#include "TVideoGrabber.h"

#include "opencv2/imgproc.hpp"
#include "opencv2/highgui.hpp"

//________________________________________________________________________________________________________________
class CVgExample
{
	CVideoGrabber* m_VideoGrabber;
public:
	CVgExample();
	~CVgExample();
	BOOL InitVideoWindowAndCallbacks();
	BOOL StartRTSP();
	CVideoGrabber* VideoGrabber() { return m_VideoGrabber; };
};

