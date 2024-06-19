
// MFCFormDlg.h : header file
//

#pragma once

#include "TVideoGrabber.h"

// CMFCFormDlg dialog
class CMFCFormDlg : public CDialogEx
{
// Construction
public:
	CMFCFormDlg(CWnd* pParent = nullptr);	// standard constructor
	~CMFCFormDlg();	// destructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MFCFORM_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;
	CVideoGrabber* m_VideoGrabber;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnSize(UINT nType, int w, int h);
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();
};
