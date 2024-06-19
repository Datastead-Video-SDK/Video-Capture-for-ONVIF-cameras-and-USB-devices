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
using Microsoft.Win32;

using VidGrabWPF;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for Overlays.xaml
    /// </summary>
    public partial class Overlays : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public Overlays(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        private int m_TextOverlayIndex = 0;
        private VideoGrabberWPF PIPVideoGrabber = null;
        private int m_ImageOverlayIndex = 0;

        public void RefreshDisplayOptions()
        {
            btnDrawGridColor.Background = MainDemoWPF.MainForm.MainFormInstance.frmOverlays_btnDrawGridColor;
            btnFreeHandColor.Background = MainDemoWPF.MainForm.MainFormInstance.frmOverlays_btnFreeHandColor;
            chkAdjustOverlayAspectRatio.IsChecked = VideoGrabber.AdjustOverlayAspectRatio;
        }

        private void Overlays_Load(object sender, RoutedEventArgs e)
        {
            TextSelector0.IsChecked = true;
            ImageSelector0.IsChecked = true;
        }

        private void chkFreeHandEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            // the sample code is located in the OnMouse... events and the overlay is performed in the OnFrameBitmap event of MainForm
        }

        private void btnFreeHandErase_Click(object sender, RoutedEventArgs e)
        {
            MainDemoWPF.MainForm.MainFormInstance.cFreeHandDrawing.iArrayCoordinates = 0;
            VideoGrabber.RefreshPlayerOverlays();
        }

        private void chkTextOverlayEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetTextOverlay_Enabled(m_TextOverlayIndex, chkTextOverlayEnabled.IsChecked == true);
            if (chkTextOverlayEnabled.IsChecked == true)
            {
                chkTextOverlayEnabled.Foreground = System.Windows.Media.Brushes.Black;
            }
            else
            {
                chkTextOverlayEnabled.Foreground = System.Windows.Media.Brushes.Red;
            }
        }

        private void edtTextOverlayTargetDisplay_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayTargetDisplay.Text))
            {
                VideoGrabber.SetTextOverlay_TargetDisplay(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayTargetDisplay.Text));
            }
        }

        private void chkHighResFont_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.SetTextOverlay_HighResFont(m_TextOverlayIndex, chkHighResFont.IsChecked == true);
        }

        private void chkAdjustOverlayAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio.IsChecked == true;
        }

        private void chkTextOverlayTransparent_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.SetTextOverlay_Transparent(m_TextOverlayIndex, chkTextOverlayTransparent.IsChecked == true);
        }

        private void chkTextOverlayShadow_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetTextOverlay_Shadow(m_TextOverlayIndex, chkTextOverlayShadow.IsChecked == true);
        }

        private void btnSelectShadowColor_Click(object sender, EventArgs e)
        {
            VideoGrabber.SetTextOverlay_ShadowColor(m_TextOverlayIndex, Convert.ToInt32(Color.FromRgb(120, 50, 200)));
        }

        private void edtTextOverlayTop_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayTop.Text))
            {
                VideoGrabber.SetTextOverlay_Top(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayTop.Text));
            }
        }

        private void edtTextOverlayLeft_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayLeft.Text))
            {
                VideoGrabber.SetTextOverlay_Left(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayLeft.Text));
            }
        }

        private void edtTextOverlayRight_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayRight.Text))
            {
                VideoGrabber.SetTextOverlay_Right(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayRight.Text));
            }
        }

        private void mmoTextOverlayString_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetTextOverlay_String(m_TextOverlayIndex, mmoTextOverlayString.Text);
        }

        private void rdgTextOverlayAlign_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
                VideoGrabber.SetTextOverlay_Align(m_TextOverlayIndex, (VidGrab.TTextOverlayAlign)Convert.ToInt32((sender as Control).TabIndex));
        }

        private void btnSelectFontColor_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetTextOverlay_FontColor(m_TextOverlayIndex, Convert.ToInt32(Color.FromRgb(90, 140, 110)));
        }

        private void btnBackColor_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetTextOverlay_BkColor(m_TextOverlayIndex, Convert.ToInt32(Color.FromRgb(150, 80, 120)));
        }

        private void edtTextOverlayScrollingSpeed_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayScrollingSpeed.Text))
            {
                VideoGrabber.SetTextOverlay_ScrollingSpeed(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayScrollingSpeed.Text));
            }

        }

        private void chkTextOverlayScrolling_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.SetTextOverlay_Scrolling(m_TextOverlayIndex, chkTextOverlayScrolling.IsChecked == true);
        }

        private void TextSelector_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                m_TextOverlayIndex = Convert.ToInt32((sender as Control).TabIndex);

                // as we have selected another set, let's reload the corresponding values;
                chkTextOverlayEnabled.IsChecked = VideoGrabber.GetTextOverlay_Enabled(m_TextOverlayIndex);
                edtTextOverlayTargetDisplay.Text = VideoGrabber.GetTextOverlay_TargetDisplay(m_TextOverlayIndex).ToString();
                chkHighResFont.IsChecked = VideoGrabber.GetTextOverlay_HighResFont(m_TextOverlayIndex);

                mmoTextOverlayString.Text = VideoGrabber.GetTextOverlay_String(m_TextOverlayIndex);
                edtTextOverlayLeft.Text = VideoGrabber.GetTextOverlay_Left(m_TextOverlayIndex).ToString();
                edtTextOverlayTop.Text = VideoGrabber.GetTextOverlay_Top(m_TextOverlayIndex).ToString();
                edtTextOverlayRight.Text = VideoGrabber.GetTextOverlay_Right(m_TextOverlayIndex).ToString();
                edtTextOverlayScrollingSpeed.Text = VideoGrabber.GetTextOverlay_ScrollingSpeed(m_TextOverlayIndex).ToString();

                Helpers.SetRadioButtonInGroupUsingTag(rdgTextOverlayAlign, (short)VideoGrabber.GetTextOverlay_Align(m_TextOverlayIndex));
                chkTextOverlayTransparent.IsChecked = VideoGrabber.GetTextOverlay_Transparent(m_TextOverlayIndex);
                chkTextOverlayShadow.IsChecked = VideoGrabber.GetTextOverlay_Shadow(m_TextOverlayIndex);
                chkTextOverlayScrolling.IsChecked = VideoGrabber.GetTextOverlay_Scrolling(m_TextOverlayIndex);
            }
        }

        private void btnPIP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = Helpers.OPEN_MEDIA_FILES;
            if (dlgOpen.ShowDialog() == true)
            {
                if (PIPVideoGrabber == null)
                {
                    PIPVideoGrabber = new VideoGrabberWPF();
                    //TODO this.Controls.Add(this.PIPVideoGrabber);
                    PIPVideoGrabber.VideoRenderer = VidGrab.TVideoRenderer.vr_None;
                    PIPVideoGrabber.Visibility = Visibility.Hidden;
                    VideoGrabber.Mixer_SetupPIPFromSource(PIPVideoGrabber.UniqueID, 0, 0, 0, 0, true, 10, 10, 200, 150, false);
                }
                PIPVideoGrabber.PlayerFileName = dlgOpen.FileName;
                PIPVideoGrabber.OpenPlayer();
            }
        }

        private void Overlays_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void btnImageOverlayFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = Helpers.OPEN_PICTURE_FILES;
            if (fd.ShowDialog() == true)
            {
                VideoGrabber.SetImageOverlayFromImageFile2(m_ImageOverlayIndex, fd.FileName);
            }
        }

        private void chkImageOverlayEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetImageOverlay_Enabled(m_ImageOverlayIndex, chkImageOverlayEnabled.IsChecked == true);
        }

        private void edtImageOverlayTargetDisplay_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayTargetDisplay.Text))
            {
                VideoGrabber.SetImageOverlay_TargetDisplay(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayTargetDisplay.Text));
            }
        }

        private void ImageSelector_CheckedChanged(object sender, RoutedEventArgs e)
        {
            m_ImageOverlayIndex = Convert.ToInt32((sender as Control).TabIndex);

            chkImageOverlayEnabled.IsChecked = VideoGrabber.GetImageOverlay_Enabled(m_ImageOverlayIndex);
            edtImageOverlayTargetDisplay.Text = VideoGrabber.GetImageOverlay_TargetDisplay(m_ImageOverlayIndex).ToString();
            edtImageOverlayLeft.Text = VideoGrabber.GetImageOverlay_LeftLocation(m_ImageOverlayIndex).ToString();
            edtImageOverlayTop.Text = VideoGrabber.GetImageOverlay_TopLocation(m_ImageOverlayIndex).ToString();
            edtImageOverlayWidth.Text = VideoGrabber.GetImageOverlay_Width(m_ImageOverlayIndex).ToString();
            edtImageOverlayHeight.Text = VideoGrabber.GetImageOverlay_Height(m_ImageOverlayIndex).ToString();

            chkImageOverlayTransparent.IsChecked = VideoGrabber.GetImageOverlay_Transparent(m_ImageOverlayIndex);
            chkImageOverlayUseTransparentColor.IsChecked = VideoGrabber.GetImageOverlay_UseTransparentColor(m_ImageOverlayIndex);
            edtImageOverlayTransparentColorValue.Text = "0x" + VideoGrabber.GetImageOverlay_TransparentColorValue(m_ImageOverlayIndex).ToString("X000000");
            chkImageOverlayAlphaBlend.IsChecked = VideoGrabber.GetImageOverlay_AlphaBlend(m_ImageOverlayIndex);
            tbrImageOverlayAlphaBlending.Value = VideoGrabber.GetImageOverlay_AlphaBlendValue(m_ImageOverlayIndex);

            chkImageOverlayChromaKey.IsChecked = VideoGrabber.GetImageOverlay_ChromaKey(m_ImageOverlayIndex);
            edtImageOverlayChromaKeyColorValue.Text = "0x" + VideoGrabber.GetImageOverlay_ChromaKeyRGBColor(m_ImageOverlayIndex).ToString("X000000");
            tbrChromaKeyLeeway.Value = VideoGrabber.GetImageOverlay_ChromaKeyLeewayPercent(m_ImageOverlayIndex);
        }

        private void edtImageOverlayLeft_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayLeft.Text))
            {
                VideoGrabber.SetImageOverlay_LeftLocation(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayLeft.Text));
            }

        }

        private void edtImageOverlayTop_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayTop.Text))
            {
                VideoGrabber.SetImageOverlay_TopLocation(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayTop.Text));
            }
        }

        private void edtImageOverlayWidth_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayWidth.Text))
            {
                VideoGrabber.SetImageOverlay_Width(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayWidth.Text));
            }
        }

        private void edtImageOverlayHeight_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayHeight.Text))
            {
                VideoGrabber.SetImageOverlay_Height(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayHeight.Text));
            }
        }

        private void chkImageOverlayTransparent_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetImageOverlay_Transparent(m_ImageOverlayIndex, chkImageOverlayTransparent.IsChecked == true);
        }

        private void chkImageOverlayUseTransparentColor_CheckedChanged(object sender, EventArgs e)
        {
            VideoGrabber.SetImageOverlay_UseTransparentColor(m_ImageOverlayIndex, chkImageOverlayUseTransparentColor.IsChecked == true);
        }

        private void edtImageOverlayTransparentColorValue_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayTransparentColorValue.Text))
            {
                VideoGrabber.SetImageOverlay_TransparentColorValue(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayTransparentColorValue.Text));
            }
        }

        private void btnImageOverlayPickupTransparentColor_Click(object sender, RoutedEventArgs e)
        {
            if (MainDemoWPF.MainForm.MainFormInstance.cPickupColor.LastRGBPixelValueAtMousePosition != -1)
            {
                VideoGrabber.SetImageOverlay_TransparentColorValue(m_ImageOverlayIndex, MainDemoWPF.MainForm.MainFormInstance.cPickupColor.LastRGBPixelValueAtMousePosition);
                edtImageOverlayTransparentColorValue.Text = "0x" + MainDemoWPF.MainForm.MainFormInstance.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000");
            }
        }

        private void btnImageOverlayPickupTransparentColorHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("while the preview is running:\n- load the image overlay\n- enable 'transparent' and 'use transp. color value'\n- in the video window, click on the video frame on the color of the overlayed image you want to be transparent\n- click on 'pickup the transparent color'",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
        }

        private void chkImageOverlayAlphaBlend_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetImageOverlay_AlphaBlend(m_ImageOverlayIndex, chkImageOverlayAlphaBlend.IsChecked == true);
        }

        private void tbrImageOverlayAlphaBlending_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetImageOverlay_AlphaBlendValue(m_ImageOverlayIndex, Convert.ToInt32(tbrImageOverlayAlphaBlending.Value));
        }

        private void tbrChromaKeyLeeway_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetImageOverlay_ChromaKeyLeewayPercent(m_ImageOverlayIndex, (int)tbrChromaKeyLeeway.Value);
        }
        private void chkImageOverlayChromaKey_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetImageOverlay_ChromaKey(m_ImageOverlayIndex, chkImageOverlayChromaKey.IsChecked == true);
        }

        private void edtImageOverlayChromaKeyColorValue_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayChromaKeyColorValue.Text))
            {
                VideoGrabber.SetImageOverlay_ChromaKeyRGBColor(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayChromaKeyColorValue.Text));
            }
        }

        private void edtDrawGrid_TextChanged(object sender, EventArgs e)
        {
            if (edtDrawGrid.Text.Length > 0)
            {
                if (Convert.ToInt32(edtDrawGrid.Text) > 100)
                {
                    MainDemoWPF.MainForm.MainFormInstance.frmOverlays_edtDrawGrid = 100;
                }
                else if (Convert.ToInt32(edtDrawGrid.Text) > 1)
                {
                    MainDemoWPF.MainForm.MainFormInstance.frmOverlays_edtDrawGrid = Convert.ToInt32(edtDrawGrid.Text);
                }
                else
                {
                    MainDemoWPF.MainForm.MainFormInstance.frmOverlays_edtDrawGrid = 0;
                }
            }
            else
            {
                MainDemoWPF.MainForm.MainFormInstance.frmOverlays_edtDrawGrid = 0;
            }
            // frmOverlays_edtDrawGrid is tested in the OnFrameOverlayUsingDC event of MainForm        
        }

        private void btnDrawGridColor_Click(object sender, EventArgs e)
        {
            //TODO MainDemoWPF.MainForm.MainFormInstance.frmOverlays_btnDrawGridColor = cd.Color;
        }

        private void btnFreeHandColor_Click(object sender, EventArgs e)
        {
            //TODO MainDemoWPF.MainForm.MainFormInstance.frmOverlays_btnFreeHandColor = cd.Color;
        }

        private void chkTargetAtMouseLocation_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (!chkTargetAtMouseLocation.IsChecked == true)
            {
                MainDemoWPF.MainForm.MainFormInstance.frmOverlays_drawTarget = false;
            }
        }

        private void btnTargetDisplayHelp_Click(object sender, EventArgs e)
        {
            TargetDisplayHelp();
        }

        private void btn2TargetDisplayHelp_Click(object sender, EventArgs e)
        {
            TargetDisplayHelp();
        }

        private void TargetDisplayHelp()
        {
            MessageBox.Show(
 @"SetTextOverlay_TargetDisplay / SetImageOverlay_TargetDisplay determines how the overlay is be applied (*):  

TargetDisplay = -1: OVERLAY APPLIED TO THE VIDEO FRAME
advantage: the overlay can applied on the recording if RecordingInNativeFormat is disabled
disadvantage: if the frame is stretched (e.g. full screen display) the overlay is stretched as well

TargetDisplay = -2: OVERLAY APPLIED TO ALL THE VIDEO WINDOWS but not to the video frames (recorded or captured)
advantage: when stretching the video windows (e.g. full screen display), the overlays are not stretched
disadvantage: it is applied the same way on all the renderers (e.g. if SetDisplayActive (1, true) or more renderers are enabled)

TargetDisplay = n (in the 0..9 range): OVERLAY APPLIED TO THE SPECIFIED DISPLAY WINDOW
advantage: when more than 1 renderer is used, it is possible to display this overlay only one the specified renderer
The TargetDisplay value corresponds to the index of the display window in the ""Display"" tab (0 for the default, 1 for the 2nd, 2 for the 3rd, etc...)
(look at the SetDisplayActive function in the user guide for more information about multiple display windows)

(*) notes:
- TargetDisplay <> -1 REQUIRES VideoRenderer to be set to vr_Auto or vr_RecordingPriority
- to quick see what happens when changing TargetDisplay, go to theDisplay tab, activate e.g. 4 or 5 video windows and try -1, -2, 0, 1, 2, 3, 4, 5 as TargetDisplay value");
        }

    }
}
