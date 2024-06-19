using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MainDemoWPF;
using System.Drawing;

using VidGrabWPF;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for Display.xaml
    /// </summary>
    public partial class Display : Grid
    {

        private VideoGrabberWPF VideoGrabber;

        public Display(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }
		
        private int FDisplaySelected = 0;
        private bool boolPanScan;
        private double PanScanVGWidth;
        private double PanScanVGHeight;

        public void RefreshDisplayOptions()
        {
            // this procedure is called each time a setting of this form is changed,
            // to show what features can be used, according to their respective states
            chkDisplayActive.IsChecked = VideoGrabber.GetDisplayActive(FDisplaySelected);
            chkVisible.IsChecked = VideoGrabber.GetDisplayVisible(FDisplaySelected);
            chkEmbedded.IsChecked = VideoGrabber.GetDisplayEmbedded(FDisplaySelected);
            chkFullScreen.IsChecked = VideoGrabber.GetDisplayFullScreen(FDisplaySelected);
            chkStayOnTop.IsChecked = VideoGrabber.GetDisplayStayOnTop(FDisplaySelected);
            chkUseVideoPort.IsChecked = VideoGrabber.GetDisplayVideoPortEnabled(FDisplaySelected);
            chkMouseMovesWindow.IsChecked = VideoGrabber.GetDisplayMouseMovesWindow(FDisplaySelected);
            chkAutoSize.IsChecked = VideoGrabber.GetDisplayAutoSize(FDisplaySelected);
            Helpers.SetRadioButtonInGroupUsingTag(cnvAspectRatio, (short)VideoGrabber.GetDisplayAspectRatio(FDisplaySelected));
            // TADA tbrPanScan.Value = VideoGrabber.GetDisplayPanScanRatio(FDisplaySelected);
            chkAlphablend.IsChecked = VideoGrabber.GetDisplayAlphaBlendEnabled(FDisplaySelected);
            // TADA tbrAlphablend.Value = VideoGrabber.GetDisplayAlphaBlendValue(FDisplaySelected);
            chkTransparentColor.IsChecked = VideoGrabber.GetDisplayTransparentColorEnabled(FDisplaySelected);
            txtTransparentColor.Text = VideoGrabber.GetDisplayTransparentColorValue(FDisplaySelected).ToString();
            txtDisplayMonitor.Text = VideoGrabber.GetDisplayMonitor(FDisplaySelected).ToString();

            Helpers.SetRadioButtonInGroupUsingTag(cnvVideoRenderer, (short)VideoGrabber.VideoRenderer);

            
            chkAdjustPixelAspectRatio.IsChecked = VideoGrabber.AdjustPixelAspectRatio;

            grbMainVideoWindow.IsEnabled = VideoGrabber.GetDisplayActive (FDisplaySelected);

            if (VideoGrabber.GetDisplayActive (FDisplaySelected))
            {
                chkStayOnTop.IsEnabled = (!VideoGrabber.GetDisplayEmbedded (FDisplaySelected)) || VideoGrabber.GetDisplayFullScreen (FDisplaySelected);
                lblMonitorNumber.IsEnabled = !VideoGrabber.GetDisplayEmbedded(FDisplaySelected);
                txtDisplayMonitor.IsEnabled = !VideoGrabber.GetDisplayEmbedded(FDisplaySelected);
                chkMouseMovesWindow.IsEnabled = !VideoGrabber.GetDisplayEmbedded(FDisplaySelected);
                btnNewLocation.IsEnabled = !VideoGrabber.GetDisplayEmbedded (FDisplaySelected);
                btnNewLocation2.IsEnabled = !VideoGrabber.GetDisplayEmbedded (FDisplaySelected);
                chkUseVideoPort.IsEnabled = VideoGrabber.IsVideoPortAvailable;
                chkAlphablend.IsEnabled = ! VideoGrabber.GetDisplayEmbedded (FDisplaySelected);
                chkTransparentColor.IsEnabled = !VideoGrabber.GetDisplayEmbedded(FDisplaySelected);
            }
        }

        private void rdgSelectDisplay_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                FDisplaySelected = Convert.ToInt32((sender as Control).TabIndex);
                RefreshDisplayOptions();
            }
        }

        private void chkDisplayActive_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetDisplayActive (FDisplaySelected, chkDisplayActive.IsChecked == true);
            RefreshDisplayOptions();
        }

        private void chkVisible_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetDisplayVisible(FDisplaySelected, chkVisible.IsChecked == true);
            RefreshDisplayOptions();
        }


		private void btnNewLocation_Click(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayAutoSize (FDisplaySelected, true); // the component"s video size will be used
			VideoGrabber.SetDisplayEmbedded (FDisplaySelected, false); // detach from component
            VideoGrabber.SetDisplayLocation(FDisplaySelected, 10, 10, 320, 240); // 320 and 240 are not used because of AutoSize above
			RefreshDisplayOptions();
		}

		private void btnNewLocation2_Click(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayAutoSize (FDisplaySelected, false); // we will specify the size below
			VideoGrabber.SetDisplayEmbedded (FDisplaySelected, false); // detach from component
			VideoGrabber.SetDisplayLocation (FDisplaySelected, 20, 20, 480, 200); // new size: 480 x 360
			RefreshDisplayOptions();
		}



		private void chkAutoSize_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayAutoSize (FDisplaySelected, chkAutoSize.IsChecked == true);
			RefreshDisplayOptions();

            
            // disabling Display_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainFormWPF_Load values if Display_AutoSize has been disabled:
            if (!VideoGrabber.GetDisplayAutoSize(FDisplaySelected))
            {
                if (VideoGrabber.GetDisplayEmbedded(FDisplaySelected))
                {
                    VideoGrabber.Width = MainDemoWPF.MainForm.MainFormInstance.StartupVGWidth;
                    VideoGrabber.Height = MainDemoWPF.MainForm.MainFormInstance.StartupVGHeight;
                }
                else
                {
                    VideoGrabber.SetDisplayWidth (FDisplaySelected, (int)MainDemoWPF.MainForm.MainFormInstance.StartupVGWidth);
                    VideoGrabber.SetDisplayHeight (FDisplaySelected, (int)MainDemoWPF.MainForm.MainFormInstance.StartupVGHeight);
                }
            }
            
		}

		private void chkEmbedded_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayEmbedded (FDisplaySelected, chkEmbedded.IsChecked == true);
			RefreshDisplayOptions();
		}

		private void chkFullScreen_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayFullScreen (FDisplaySelected, chkFullScreen.IsChecked == true);
		}

        private void chkAlphablend_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetDisplayAlphaBlendEnabled(FDisplaySelected, chkAlphablend.IsChecked == true);
        }

        private void chkTransparentColor_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetDisplayTransparentColorEnabled(FDisplaySelected, chkTransparentColor.IsChecked == true);
        }

        private void txtTransparentColor_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(txtTransparentColor.Text))
            {
                VideoGrabber.SetDisplayTransparentColorValue(FDisplaySelected, Convert.ToInt32(txtTransparentColor.Text));
            }
        }

		private void chkMouseMovesWindow_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayMouseMovesWindow (FDisplaySelected, chkMouseMovesWindow.IsChecked == true);
			RefreshDisplayOptions();
		}

		private void chkStayOnTop_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayStayOnTop (FDisplaySelected, chkStayOnTop.IsChecked == true);
			RefreshDisplayOptions();
		}

		private void chkUseVideoPort_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.SetDisplayVideoPortEnabled (FDisplaySelected, chkUseVideoPort.IsChecked == true);
			RefreshDisplayOptions();
		}

        private void chkBlackMagicOutput_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true)
            {
                VideoGrabber.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_BlackMagic_Decklink;
            }
            else
            {
                VideoGrabber.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            }
        }

		private void chkVideoVisibleWhenStopped_CheckedChanged(object sender, RoutedEventArgs e)
		{
			VideoGrabber.VideoVisibleWhenStopped = chkVideoVisibleWhenStopped.IsChecked == true;
		}

        private void chkAdjustPixelAspectRatio_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AdjustPixelAspectRatio = chkAdjustPixelAspectRatio.IsChecked == true;
        }

        private void chkBorder_CheckedChanged(object sender, RoutedEventArgs e)
		{
#if (! VS2003) 
			if (chkBorder.IsChecked == true) 
			{
				//TODO VideoGrabber.BorderStyle = BorderStyle.Fixed3D;
			}
			else {
                //TODO VideoGrabber.BorderStyle = BorderStyle.None;
            }
#endif
        }

		private void chkChangeCursor_CheckedChanged(object sender, RoutedEventArgs e)
		{
			if (chkChangeCursor.IsChecked == true) {
				VideoGrabber.VideoCursor = VidGrab.TCursors.cr_cross;
			}
			else {
				VideoGrabber.VideoCursor = VidGrab.TCursors.cr_Default;
			}
		}

		private void chkSetLogo_CheckedChanged(object sender, RoutedEventArgs e)
		{
			if (chkSetLogo.IsChecked == true) {

                VideoGrabber.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
                Bitmap TempBmp = Helpers.CreateBitmapHandleFromPictureBox(imgLogo); // TODO LOAD IMAGE FROM RESOURCE
                VideoGrabber.SetLogoFromHBitmap(TempBmp.GetHbitmap());
                VideoGrabber.LogoDisplayed = true;
			}
            else {
                VideoGrabber.LogoDisplayed = false;
            }
        }

		private void chkTransparency_CheckedChanged(object sender, RoutedEventArgs e)
		{
            /* TODO
            frmTransparentWindow.TransparencyKey= Color.FromArgb((int) VideoGrabber.ColorKey);
            frmTransparentWindow.BackColor = ColorTranslator.FromWin32 (frmTransparentWindow.TransparencyKey.ToArgb());
            frmTransparentWindow.TransparentLabel.ForeColor = Color.Red;
            frmTransparentWindow.Show();
            */
		}

		private void rdgVideoRenderer_CheckedChanged(object sender, RoutedEventArgs e)
		{
			if ((sender as RadioButton).IsChecked == true) 
			{
				VideoGrabber.VideoRenderer = (VidGrab.TVideoRenderer) Convert.ToInt32 ((sender as RadioButton).TabIndex);
			}
		
		}

		private void rdgDisplayAspectRatio_CheckedChanged(object sender, RoutedEventArgs e)
		{
			if ((sender as RadioButton).IsChecked == true) 
			{
				VideoGrabber.SetDisplayAspectRatio (FDisplaySelected, (VidGrab.TAspectRatio) Convert.ToInt32 ((sender as Control).TabIndex));
			}
		}

        private void txtDisplayMonitor_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(txtDisplayMonitor.Text))
            {
                VideoGrabber.SetDisplayMonitor(FDisplaySelected, Convert.ToInt32(txtDisplayMonitor.Text));
                RefreshDisplayOptions();
            }
        }

		private void btnTestPanScan_Click(object sender, RoutedEventArgs e)
		{
            
            chkEmbedded.IsChecked = true;
            VideoGrabber.SetDisplayEmbedded (FDisplaySelected, true);
            chkAdjustPixelAspectRatio.IsChecked = false;
            VideoGrabber.AdjustPixelAspectRatio = false;

            chkAutoSize.IsChecked = false;
            VideoGrabber.SetDisplayAutoSize (FDisplaySelected, false);

            // disabling Display_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainFormWPF_Load values if Display_AutoSize is enabled
            if (!VideoGrabber.GetDisplayAutoSize (FDisplaySelected))
            {
                if (VideoGrabber.GetDisplayEmbedded (FDisplaySelected))
                {
                    VideoGrabber.Width = MainDemoWPF.MainForm.MainFormInstance.StartupVGWidth;
                    VideoGrabber.Height = MainDemoWPF.MainForm.MainFormInstance.StartupVGHeight;
                }
                else
                {
                    VideoGrabber.SetDisplayWidth (FDisplaySelected, (int)MainDemoWPF.MainForm.MainFormInstance.StartupVGWidth);
                    VideoGrabber.SetDisplayHeight  (FDisplaySelected, (int)MainDemoWPF.MainForm.MainFormInstance.StartupVGHeight);
                }
            }

            // for pan / scan demonstration, change video Width and Height to a
            //  16 x 9 aspect ratio, or restore to pre-demonstration Width and Height
            if (boolPanScan)
            {
                VideoGrabber.Width = PanScanVGWidth;
                VideoGrabber.Height = PanScanVGHeight;
            }
            else
            {
                Single h = 9;
                Single w = 16;
                PanScanVGWidth = VideoGrabber.Width;
                PanScanVGHeight = VideoGrabber.Height;
                VideoGrabber.Width =Convert.ToInt32(Convert.ToSingle( VideoGrabber.Height) * (w / h));
            }
            boolPanScan = !boolPanScan;

            // setting Display_AspectRatio to ar_PanScan (pan and scan)
            rdgDisplayAspectRatioPanScan.IsChecked = true;
            VideoGrabber.SetDisplayAspectRatio (FDisplaySelected, VidGrab.TAspectRatio.ar_PanScan);
            
        }

		private void Display_VisibleChanged(object sender, RoutedEventArgs e)
		{
			if (IsVisible) 
			{
				RefreshDisplayOptions();
			}
		
		}

        private void btnTestPanScanHelp_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Test Display_AspectRatio settings with Display_AutoSize disabled:\n\nWith Display_AutoSize = False and AdjustPixelAspectRatio= False, the Display_AspectRatio setting\n  determines how the video is displayed within the control Width and Height properties:\n  ar_Box: video appears in full with correct aspect ratio (e.g. letterbox)\n  ar_NoResize: video appears in \"native\" size with correct aspect ratio\n  ar_Stretch: video is stretched to fill the control, regardless of correct aspect ratio\n  ar_PanScan: Display_PanScanRatio (0-100) determines setting between \"letterbox\" and \"pan-scan\"\n\n(see Help: \"User guide.Display - Dual display.Video window\")",
                    "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
            
        }

        private void tbrAlphablend_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetDisplayAlphaBlendValue(FDisplaySelected, (int)tbrAlphablend.Value);
        }

        private void tbrPanScan_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetDisplayPanScanRatio(FDisplaySelected, (int)tbrPanScan.Value);
        }

        private void rdgDisplayAspectRatioBox_Checked(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
        }

        private void rdgDisplayAspectRatioPan_Checked(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Display_AspectRatio = VidGrab.TAspectRatio.ar_NoResize;
        }

        private void rdgDisplayAspectRatioStretch_Checked(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Display_AspectRatio = VidGrab.TAspectRatio.ar_Stretch;
        }

        private void rdgDisplayAspectRatioPanScan_Checked(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Display_AspectRatio = VidGrab.TAspectRatio.ar_PanScan;
        }
    }
}
