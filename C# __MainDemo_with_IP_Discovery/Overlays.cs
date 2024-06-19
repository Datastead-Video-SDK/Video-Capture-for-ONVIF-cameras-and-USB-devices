using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class Overlays : Form
    {

        
		
		public Overlays()
		{
			InitializeComponent();
		}


		public void RefreshDisplayOptions()
		{
			btnDrawGridColor.BackColor = MainForm.cMainForm.frmOverlays_btnDrawGridColor;
            btnFreeHandColor.BackColor = MainForm.cMainForm.frmOverlays_btnFreeHandColor;
            chkAdjustOverlayAspectRatio.Checked = MainForm.cMainForm.VideoGrabber1.AdjustOverlayAspectRatio;
		}

		private void Overlays_Load(object sender, System.EventArgs e)
		{
			TextSelector0.Checked = true;
			ImageSelector0.Checked = true;
		}

        private void chkFreeHandEnabled_CheckedChanged(object sender, System.EventArgs e)
        {
            // the sample code is located in the OnMouse... events and the overlay is performed in the OnFrameBitmap event of MainForm
        }

		private void btnFreeHandErase_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.cFreeHandDrawing.iArrayCoordinates = 0;
            MainForm.cMainForm.VideoGrabber1.RefreshPlayerOverlays();
        }

		private void chkTextOverlayEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Enabled(m_TextOverlayIndex, chkTextOverlayEnabled.Checked);
			if (chkTextOverlayEnabled.Checked) 
			{
				chkTextOverlayEnabled.ForeColor = System.Drawing.Color.Black;
			}
			else 
			{
				chkTextOverlayEnabled.ForeColor = System.Drawing.Color.Red;
			}
		}

        private void edtTextOverlayTargetDisplay_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayTargetDisplay.Text)) {
                MainForm.cMainForm.VideoGrabber1.SetTextOverlay_TargetDisplay(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayTargetDisplay.Text));
            }
        }

        private void chkHighResFont_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetTextOverlay_HighResFont(m_TextOverlayIndex, chkHighResFont.Checked);
        }

        private void chkAdjustOverlayAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio.Checked;
        }

        private void chkTextOverlayTransparent_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Transparent(m_TextOverlayIndex, chkTextOverlayTransparent.Checked);
        }

        private void chkTextOverlayShadow_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Shadow(m_TextOverlayIndex, chkTextOverlayShadow.Checked);
		}

        private void btnSelectShadowColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                MainForm.cMainForm.VideoGrabber1.SetTextOverlay_ShadowColor(m_TextOverlayIndex, Convert.ToInt32(ColorTranslator.ToWin32(cd.Color)));
            }
        }

        private void edtTextOverlayTop_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtTextOverlayTop.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Top(m_TextOverlayIndex, Convert.ToInt32 (edtTextOverlayTop.Text));
			}
		}

		private void edtTextOverlayLeft_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtTextOverlayLeft.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Left(m_TextOverlayIndex, Convert.ToInt32 (edtTextOverlayLeft.Text));
			}
		}

        private void edtTextOverlayRight_TextChanged(object sender, System.EventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayRight.Text)) 
            {
                MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Right(m_TextOverlayIndex, Convert.ToInt32 (edtTextOverlayRight.Text));
            }
        }

    	private void mmoTextOverlayString_TextChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetTextOverlay_String(m_TextOverlayIndex, mmoTextOverlayString.Text);
		}

		private void rdgTextOverlayAlign_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
				MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Align(m_TextOverlayIndex, (VidGrab.TTextOverlayAlign) Convert.ToInt32 ((sender as Control).Tag));
			}

		private void btnSelectFont_Click(object sender, System.EventArgs e)
		{
			FontDialog fd = new FontDialog();
			if (fd.ShowDialog()== DialogResult.OK) 
			{
				MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Font(m_TextOverlayIndex, fd.Font.ToHfont());
			}
        }
		
		private void btnSelectFontColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK) 
			{
                MainForm.cMainForm.VideoGrabber1.SetTextOverlay_FontColor(m_TextOverlayIndex, Convert.ToInt32(ColorTranslator.ToWin32(cd.Color)));
			}
		}

		private void btnBackColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK) 
			{
                MainForm.cMainForm.VideoGrabber1.SetTextOverlay_BkColor(m_TextOverlayIndex, Convert.ToInt32(ColorTranslator.ToWin32(cd.Color)));
			}
		}

        private void edtTextOverlayScrollingSpeed_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtTextOverlayScrollingSpeed.Text))
            {
                MainForm.cMainForm.VideoGrabber1.SetTextOverlay_ScrollingSpeed(m_TextOverlayIndex, Convert.ToInt32(edtTextOverlayScrollingSpeed.Text));
            }

        }

        private void chkTextOverlayScrolling_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetTextOverlay_Scrolling(m_TextOverlayIndex, chkTextOverlayScrolling.Checked);
        }

		private void OverlaySelector_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
                m_TextOverlayIndex = Convert.ToInt32((sender as Control).Tag);

				// as we have selected another set, let's reload the corresponding values;
                chkTextOverlayEnabled.Checked = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Enabled(m_TextOverlayIndex);
                edtTextOverlayTargetDisplay.Text = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_TargetDisplay(m_TextOverlayIndex).ToString();
                chkHighResFont.Checked = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_HighResFont(m_TextOverlayIndex);

                mmoTextOverlayString.Text = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_String(m_TextOverlayIndex);
                edtTextOverlayLeft.Text = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Left(m_TextOverlayIndex).ToString();
                edtTextOverlayTop.Text = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Top(m_TextOverlayIndex).ToString();
                edtTextOverlayRight.Text = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Right(m_TextOverlayIndex).ToString();
                edtTextOverlayScrollingSpeed.Text = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_ScrollingSpeed(m_TextOverlayIndex).ToString();

                Helpers.SetRadioButtonInGroupUsingTag(rdgTextOverlayAlign, (short)MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Align(m_TextOverlayIndex));
                chkTextOverlayTransparent.Checked = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Transparent(m_TextOverlayIndex);
                chkTextOverlayShadow.Checked = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Shadow(m_TextOverlayIndex);
                chkTextOverlayScrolling.Checked = MainForm.cMainForm.VideoGrabber1.GetTextOverlay_Scrolling(m_TextOverlayIndex);
			}	
        }

        private void btnPIP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = Helpers.OPEN_MEDIA_FILES;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                if (PIPVideoGrabber == null)
                {
                    PIPVideoGrabber = new VidGrab.VideoGrabber();
                    this.Controls.Add(this.PIPVideoGrabber);
                    PIPVideoGrabber.VideoRenderer = VidGrab.TVideoRenderer.vr_None;
                    PIPVideoGrabber.Visible = false;
                    MainForm.cMainForm.VideoGrabber1.Mixer_SetupPIPFromSource(PIPVideoGrabber.UniqueID, 0, 0, 0, 0, true, 10, 10, 200, 150, false);
                }
                PIPVideoGrabber.PlayerFileName = dlgOpen.FileName;
                PIPVideoGrabber.OpenPlayer();
            }
        }

		private void Overlays_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

		private void btnImageOverlayFromFile_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();

			fd.Filter = Helpers.OPEN_PICTURE_FILES;
			if (fd.ShowDialog() == DialogResult.OK) 
			{
				MainForm.cMainForm.VideoGrabber1.SetImageOverlayFromImageFile2(m_ImageOverlayIndex, fd.FileName);
			}
		}

		private void chkImageOverlayEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_Enabled(m_ImageOverlayIndex, chkImageOverlayEnabled.Checked);
		}

        private void edtImageOverlayTargetDisplay_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayTargetDisplay.Text))
            {
                MainForm.cMainForm.VideoGrabber1.SetImageOverlay_TargetDisplay(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayTargetDisplay.Text));
            }
        }

		private void ImageSelector_CheckedChanged(object sender, System.EventArgs e)
		{
            m_ImageOverlayIndex = Convert.ToInt32((sender as Control).Tag);

            chkImageOverlayEnabled.Checked = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_Enabled(m_ImageOverlayIndex);
            edtImageOverlayTargetDisplay.Text = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_TargetDisplay(m_ImageOverlayIndex).ToString(); 
            edtImageOverlayLeft.Text = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_LeftLocation(m_ImageOverlayIndex).ToString();
            edtImageOverlayTop.Text = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_TopLocation(m_ImageOverlayIndex).ToString();
            edtImageOverlayWidth.Text = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_Width(m_ImageOverlayIndex).ToString();
            edtImageOverlayHeight.Text = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_Height(m_ImageOverlayIndex).ToString();

            chkImageOverlayTransparent.Checked = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_Transparent(m_ImageOverlayIndex);
            chkImageOverlayUseTransparentColor.Checked = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_UseTransparentColor(m_ImageOverlayIndex);
            edtImageOverlayTransparentColorValue.Text = "0x" + MainForm.cMainForm.VideoGrabber1.GetImageOverlay_TransparentColorValue(m_ImageOverlayIndex).ToString("X000000");
            chkImageOverlayAlphaBlend.Checked = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_AlphaBlend(m_ImageOverlayIndex);
            tbrImageOverlayAlphaBlending.Value = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_AlphaBlendValue(m_ImageOverlayIndex);

            chkImageOverlayChromaKey.Checked = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_ChromaKey(m_ImageOverlayIndex);
            edtImageOverlayChromaKeyColorValue.Text = "0x" + MainForm.cMainForm.VideoGrabber1.GetImageOverlay_ChromaKeyRGBColor(m_ImageOverlayIndex).ToString("X000000");
            tbrChromaKeyLeeway.Value = MainForm.cMainForm.VideoGrabber1.GetImageOverlay_ChromaKeyLeewayPercent(m_ImageOverlayIndex);
		}

		private void edtImageOverlayLeft_TextChanged(object sender, System.EventArgs e)
		{
        if (Helpers.IsNumeric(edtImageOverlayLeft.Text)) {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_LeftLocation(m_ImageOverlayIndex, Convert.ToInt32 (edtImageOverlayLeft.Text));
        }
		
		}

		private void edtImageOverlayTop_TextChanged(object sender, System.EventArgs e)
		{
        if (Helpers.IsNumeric(edtImageOverlayTop.Text)) {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_TopLocation(m_ImageOverlayIndex, Convert.ToInt32 (edtImageOverlayTop.Text));
        }
		}

		private void edtImageOverlayWidth_TextChanged(object sender, System.EventArgs e)
		{
        if (Helpers.IsNumeric(edtImageOverlayWidth.Text)) {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_Width(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayWidth.Text));
        }
		}

		private void edtImageOverlayHeight_TextChanged(object sender, System.EventArgs e)
		{
            if (Helpers.IsNumeric(edtImageOverlayHeight.Text)) {
                MainForm.cMainForm.VideoGrabber1.SetImageOverlay_Height(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayHeight.Text));
            }
		}

        private void chkImageOverlayTransparent_CheckedChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_Transparent(m_ImageOverlayIndex, chkImageOverlayTransparent.Checked);
        }

        private void chkImageOverlayUseTransparentColor_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_UseTransparentColor(m_ImageOverlayIndex, chkImageOverlayUseTransparentColor.Checked);
        }
        
        private void edtImageOverlayTransparentColorValue_TextChanged(object sender, System.EventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayTransparentColorValue.Text)) 
            {
                MainForm.cMainForm.VideoGrabber1.SetImageOverlay_TransparentColorValue(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayTransparentColorValue.Text));
            }
        }

        private void btnImageOverlayPickupTransparentColor_Click(object sender, System.EventArgs e)
        {
            if (MainForm.cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition != -1) 
            {
                MainForm.cMainForm.VideoGrabber1.SetImageOverlay_TransparentColorValue(m_ImageOverlayIndex, MainForm.cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition);
                edtImageOverlayTransparentColorValue.Text = "0x" + MainForm.cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000");
            }
        }

        private void btnImageOverlayPickupTransparentColorHelp_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("while the preview is running:\n- load the image overlay\n- enable 'transparent' and 'use transp. color value'\n- in the video window, click on the video frame on the color of the overlayed image you want to be transparent\n- click on 'pickup the transparent color'",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
        }

        private void chkImageOverlayAlphaBlend_CheckedChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_AlphaBlend(m_ImageOverlayIndex, chkImageOverlayAlphaBlend.Checked);
        }

        private void tbrImageOverlayAlphaBlending_Scroll(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_AlphaBlendValue(m_ImageOverlayIndex, Convert.ToInt32(tbrImageOverlayAlphaBlending.Value));
        }

        private void chkImageOverlayChromaKey_CheckedChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_ChromaKey(m_ImageOverlayIndex, chkImageOverlayChromaKey.Checked);
        }

        private void edtImageOverlayChromaKeyColorValue_TextChanged(object sender, System.EventArgs e)
        {
            if (Helpers.IsNumeric(edtImageOverlayChromaKeyColorValue.Text)) 
            {
                MainForm.cMainForm.VideoGrabber1.SetImageOverlay_ChromaKeyRGBColor(m_ImageOverlayIndex, Convert.ToInt32(edtImageOverlayChromaKeyColorValue.Text));
            }
        }

        private void tbrChromaKeyLeeway_Scroll(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetImageOverlay_ChromaKeyLeewayPercent(m_ImageOverlayIndex, tbrChromaKeyLeeway.Value);
        }

        private void edtDrawGrid_TextChanged(object sender, EventArgs e)
        {
            if (edtDrawGrid.Text.Length > 0)
            {
                if (Convert.ToInt32(edtDrawGrid.Text) > 100)
                {
                    MainForm.cMainForm.frmOverlays_edtDrawGrid = 100;
                }
                else if (Convert.ToInt32(edtDrawGrid.Text) > 1)
                {
                    MainForm.cMainForm.frmOverlays_edtDrawGrid = Convert.ToInt32(edtDrawGrid.Text);
                }
                else
                {
                    MainForm.cMainForm.frmOverlays_edtDrawGrid = 0;
                }
            }
            else
            {
                MainForm.cMainForm.frmOverlays_edtDrawGrid = 0;
            }
		// frmOverlays_edtDrawGrid is tested in the OnFrameOverlayUsingDC event of MainForm        
        }

        private void btnDrawGridColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                MainForm.cMainForm.frmOverlays_btnDrawGridColor = cd.Color;
                btnDrawGridColor.BackColor = cd.Color;
            }
        }

        private void btnFreeHandColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                MainForm.cMainForm.frmOverlays_btnFreeHandColor = cd.Color;
                btnFreeHandColor.BackColor = cd.Color;
            }
        }

		private void chkTargetAtMouseLocation_CheckedChanged(object sender, System.EventArgs e)
		{
			if (! chkTargetAtMouseLocation.Checked) 
			{
				MainForm.cMainForm.frmOverlays_drawTarget = false;
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
