using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class Display : Form
    {


        private void Display_Load(object sender, System.EventArgs e)
        {
            frmTransparentWindow = new TransparentWindow();
        }

		public Display()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        private int FDisplaySelected = 0;

        public void RefreshDisplayOptions()
        {
            // this procedure is called each time a setting of this form is changed,
            // to show what features can be used, according to their respective states
            chkDisplayActive.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayActive(FDisplaySelected);
            chkVisible.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayVisible(FDisplaySelected);
            chkEmbedded.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected);
            chkFullScreen.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayFullScreen(FDisplaySelected);
            chkStayOnTop.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayStayOnTop(FDisplaySelected);
            chkUseVideoPort.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayVideoPortEnabled(FDisplaySelected);
            chkMouseMovesWindow.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayMouseMovesWindow(FDisplaySelected);
            chkAutoSize.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayAutoSize(FDisplaySelected);
            Helpers.SetRadioButtonInGroupUsingTag(rdgAspectRatio, (short)MainForm.cMainForm.VideoGrabber1.GetDisplayAspectRatio(FDisplaySelected));
            tbrPanScan.Value = MainForm.cMainForm.VideoGrabber1.GetDisplayPanScanRatio(FDisplaySelected);
            chkAlphablend.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayAlphaBlendEnabled(FDisplaySelected);
            tbrAlphablend.Value = MainForm.cMainForm.VideoGrabber1.GetDisplayAlphaBlendValue(FDisplaySelected);
            chkTransparentColor.Checked = MainForm.cMainForm.VideoGrabber1.GetDisplayTransparentColorEnabled(FDisplaySelected);
            txtTransparentColor.Text = MainForm.cMainForm.VideoGrabber1.GetDisplayTransparentColorValue(FDisplaySelected).ToString();
            txtDisplayMonitor.Text = MainForm.cMainForm.VideoGrabber1.GetDisplayMonitor(FDisplaySelected).ToString();

            Helpers.SetRadioButtonInGroupUsingTag(rdgVideoRenderer, (short)MainForm.cMainForm.VideoGrabber1.VideoRenderer);

            
            chkAdjustPixelAspectRatio.Checked = MainForm.cMainForm.VideoGrabber1.AdjustPixelAspectRatio;

            grbMainVideoWindow.Enabled = MainForm.cMainForm.VideoGrabber1.GetDisplayActive (FDisplaySelected);

            if (MainForm.cMainForm.VideoGrabber1.GetDisplayActive (FDisplaySelected))
            {
                chkStayOnTop.Enabled = (!MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded (FDisplaySelected)) || MainForm.cMainForm.VideoGrabber1.GetDisplayFullScreen (FDisplaySelected);
                lblMonitorNumber.Enabled = !MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected);
                txtDisplayMonitor.Enabled = !MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected);
                chkMouseMovesWindow.Enabled = !MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected);
                btnNewLocation.Enabled = !MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded (FDisplaySelected);
                btnNewLocation2.Enabled = !MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded (FDisplaySelected);
                chkUseVideoPort.Enabled = MainForm.cMainForm.VideoGrabber1.IsVideoPortAvailable;
                chkAlphablend.Enabled = ! MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded (FDisplaySelected);
                chkTransparentColor.Enabled = !MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected);
            }
        }

        private void rdgSelectDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                FDisplaySelected = Convert.ToInt32((sender as Control).Tag);
                RefreshDisplayOptions();
            }
        }

        private void chkDisplayActive_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetDisplayActive (FDisplaySelected, chkDisplayActive.Checked);
            RefreshDisplayOptions();
        }

        private void chkVisible_CheckedChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetDisplayVisible(FDisplaySelected, chkVisible.Checked);
            RefreshDisplayOptions();
        }


		private void btnNewLocation_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayAutoSize (FDisplaySelected, true); // the component"s video size will be used
			MainForm.cMainForm.VideoGrabber1.SetDisplayEmbedded (FDisplaySelected, false); // detach from component
            MainForm.cMainForm.VideoGrabber1.SetDisplayLocation(FDisplaySelected, 10, 10, 320, 240); // 320 and 240 are not used because of AutoSize above
			RefreshDisplayOptions();
		}

		private void btnNewLocation2_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayAutoSize (FDisplaySelected, false); // we will specify the size below
			MainForm.cMainForm.VideoGrabber1.SetDisplayEmbedded (FDisplaySelected, false); // detach from component
			MainForm.cMainForm.VideoGrabber1.SetDisplayLocation (FDisplaySelected, 20, 20, 480, 200); // new size: 480 x 360
			RefreshDisplayOptions();
		}



		private void chkAutoSize_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayAutoSize (FDisplaySelected, chkAutoSize.Checked);
			RefreshDisplayOptions();

            
            // disabling Display_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainForm_Load values if Display_AutoSize has been disabled:
            if (!MainForm.cMainForm.VideoGrabber1.GetDisplayAutoSize(FDisplaySelected))
            {
                if (MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected))
                {
                    MainForm.cMainForm.VideoGrabber1.Width = MainForm.cMainForm.StartupVGWidth;
                    MainForm.cMainForm.VideoGrabber1.Height = MainForm.cMainForm.StartupVGHeight;
                }
                else
                {
                    MainForm.cMainForm.VideoGrabber1.SetDisplayWidth (FDisplaySelected, MainForm.cMainForm.StartupVGWidth);
                    MainForm.cMainForm.VideoGrabber1.SetDisplayHeight (FDisplaySelected, MainForm.cMainForm.StartupVGHeight);
                }
            }
            
		}

		private void chkEmbedded_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayEmbedded (FDisplaySelected, chkEmbedded.Checked);
			RefreshDisplayOptions();
		}

		private void chkFullScreen_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayFullScreen (FDisplaySelected, chkFullScreen.Checked);
		}

        private void chkAlphablend_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetDisplayAlphaBlendEnabled(FDisplaySelected, chkAlphablend.Checked);
        }

        private void tbrAlphablend_Scroll(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetDisplayAlphaBlendValue(FDisplaySelected, tbrAlphablend.Value);
        }

        private void chkTransparentColor_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetDisplayTransparentColorEnabled(FDisplaySelected, chkTransparentColor.Checked);
        }

        private void txtTransparentColor_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(txtTransparentColor.Text))
            {
                MainForm.cMainForm.VideoGrabber1.SetDisplayTransparentColorValue(FDisplaySelected, Convert.ToInt32(txtTransparentColor.Text));
            }
        }

		private void chkMouseMovesWindow_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayMouseMovesWindow (FDisplaySelected, chkMouseMovesWindow.Checked);
			RefreshDisplayOptions();
		}

		private void chkStayOnTop_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayStayOnTop (FDisplaySelected, chkStayOnTop.Checked);
			RefreshDisplayOptions();
		}

		private void chkUseVideoPort_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayVideoPortEnabled (FDisplaySelected, chkUseVideoPort.Checked);
			RefreshDisplayOptions();
		}

        private void chkBlackMagicOutput_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                MainForm.cMainForm.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_BlackMagic_Decklink;
            }
            else
            {
                MainForm.cMainForm.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            }
        }

		private void chkVideoVisibleWhenStopped_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoVisibleWhenStopped = chkVideoVisibleWhenStopped.Checked;
		}

        private void chkAdjustPixelAspectRatio_CheckedChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.AdjustPixelAspectRatio = chkAdjustPixelAspectRatio.Checked;
        }

		private void chkBorder_CheckedChanged(object sender, System.EventArgs e)
		{
#if (! VS2003) 
			if (chkBorder.Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.BorderStyle = BorderStyle.Fixed3D;
			}
			else {
				MainForm.cMainForm.VideoGrabber1.BorderStyle = BorderStyle.None;
			}
#endif
		}

		private void chkChangeCursor_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkChangeCursor.Checked) {
				MainForm.cMainForm.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_cross;
			}
			else {
				MainForm.cMainForm.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default;
			}
		}

		private void chkSetLogo_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSetLogo.Checked) {

                MainForm.cMainForm.VideoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
                Bitmap TempBmp = Helpers.CreateBitmapHandleFromPictureBox(imgLogo);
                MainForm.cMainForm.VideoGrabber1.SetLogoFromHBitmap(TempBmp.GetHbitmap());
                MainForm.cMainForm.VideoGrabber1.LogoDisplayed = true;
			}
            else {
                MainForm.cMainForm.VideoGrabber1.LogoDisplayed = false;
            }
        }

		private void chkTransparency_CheckedChanged(object sender, System.EventArgs e)
		{
            frmTransparentWindow.TransparencyKey= Color.FromArgb((int) MainForm.cMainForm.VideoGrabber1.ColorKey);
            frmTransparentWindow.BackColor = ColorTranslator.FromWin32 (frmTransparentWindow.TransparencyKey.ToArgb());
            frmTransparentWindow.TransparentLabel.ForeColor = Color.Red;
            frmTransparentWindow.Show();
		}

		private void rdgVideoRenderer_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.VideoRenderer = (VidGrab.TVideoRenderer) Convert.ToInt32 ((sender as Control).Tag);
			}
		
		}

		private void rdgDisplayAspectRatio_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.SetDisplayAspectRatio (FDisplaySelected, (VidGrab.TAspectRatio) Convert.ToInt32 ((sender as Control).Tag));
			}
		}

        private void txtDisplayMonitor_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(txtDisplayMonitor.Text))
            {
                MainForm.cMainForm.VideoGrabber1.SetDisplayMonitor(FDisplaySelected, Convert.ToInt32(txtDisplayMonitor.Text));
                RefreshDisplayOptions();
            }
        }

		private void tbrPanScan_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetDisplayPanScanRatio (FDisplaySelected, tbrPanScan.Value);
		}

		private void btnTestPanScan_Click(object sender, System.EventArgs e)
		{
            
            chkEmbedded.Checked = true;
            MainForm.cMainForm.VideoGrabber1.SetDisplayEmbedded (FDisplaySelected, true);
            chkAdjustPixelAspectRatio.Checked = false;
            MainForm.cMainForm.VideoGrabber1.AdjustPixelAspectRatio = false;

            chkAutoSize.Checked = false;
            MainForm.cMainForm.VideoGrabber1.SetDisplayAutoSize (FDisplaySelected, false);

            // disabling Display_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainForm_Load values if Display_AutoSize is enabled
            if (!MainForm.cMainForm.VideoGrabber1.GetDisplayAutoSize (FDisplaySelected))
            {
                if (MainForm.cMainForm.VideoGrabber1.GetDisplayEmbedded (FDisplaySelected))
                {
                    MainForm.cMainForm.VideoGrabber1.Width = MainForm.cMainForm.StartupVGWidth;
                    MainForm.cMainForm.VideoGrabber1.Height = MainForm.cMainForm.StartupVGHeight;
                }
                else
                {
                    MainForm.cMainForm.VideoGrabber1.SetDisplayWidth (FDisplaySelected, MainForm.cMainForm.StartupVGWidth);
                    MainForm.cMainForm.VideoGrabber1.SetDisplayHeight  (FDisplaySelected, MainForm.cMainForm.StartupVGHeight);
                }
            }

            // for pan / scan demonstration, change video Width and Height to a
            //  16 x 9 aspect ratio, or restore to pre-demonstration Width and Height
            if (boolPanScan)
            {
                MainForm.cMainForm.VideoGrabber1.Width = PanScanVGWidth;
                MainForm.cMainForm.VideoGrabber1.Height = PanScanVGHeight;
            }
            else
            {
                Single h = 9;
                Single w = 16;
                PanScanVGWidth = MainForm.cMainForm.VideoGrabber1.Width;
                PanScanVGHeight = MainForm.cMainForm.VideoGrabber1.Height;
                MainForm.cMainForm.VideoGrabber1.Width =Convert.ToInt32(Convert.ToSingle( MainForm.cMainForm.VideoGrabber1.Height) * (w / h));
            }
            boolPanScan = !boolPanScan;

            // setting Display_AspectRatio to ar_PanScan (pan and scan)
            rdgDisplayAspectRatioPanScan.Checked = true;
            MainForm.cMainForm.VideoGrabber1.SetDisplayAspectRatio (FDisplaySelected, VidGrab.TAspectRatio.ar_PanScan);
            
        }

		private void Display_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		
		}

        private void btnTestPanScanHelp_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Test Display_AspectRatio settings with Display_AutoSize disabled:\n\nWith Display_AutoSize = False and AdjustPixelAspectRatio= False, the Display_AspectRatio setting\n  determines how the video is displayed within the control Width and Height properties:\n  ar_Box: video appears in full with correct aspect ratio (e.g. letterbox)\n  ar_NoResize: video appears in \"native\" size with correct aspect ratio\n  ar_Stretch: video is stretched to fill the control, regardless of correct aspect ratio\n  ar_PanScan: Display_PanScanRatio (0-100) determines setting between \"letterbox\" and \"pan-scan\"\n\n(see Help: \"User guide.Display - Dual display.Video window\")",
                    "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
            
        }



	}
}
