using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class VideoProcessing : Form
	{
        

		public VideoProcessing()
		{
			InitializeComponent();
		}

		public void RefreshDisplayOptions()
		{
			Helpers.SetRadioButtonInGroupUsingTag(rdgVideoRotation, (short) MainForm.cMainForm.VideoGrabber1.VideoProcessing_Rotation);
			edtCustomRotationAngle.Text = MainForm.cMainForm.VideoGrabber1.VideoProcessing_RotationCustomAngle.ToString();

			Helpers.SetRadioButtonInGroupUsingTag(rdgDeinterlacing, (short) MainForm.cMainForm.VideoGrabber1.VideoProcessing_Deinterlacing);

            updVideoPixelization.Value = MainForm.cMainForm.VideoGrabber1.VideoProcessing_Pixellization;

            tbrBrightness.Value = MainForm.cMainForm.VideoGrabber1.VideoProcessing_Brightness;
			tbrContrast.Value = MainForm.cMainForm.VideoGrabber1.VideoProcessing_Contrast;
			tbrSaturation.Value = MainForm.cMainForm.VideoGrabber1.VideoProcessing_Saturation;
			tbrHue.Value = MainForm.cMainForm.VideoGrabber1.VideoProcessing_Hue;

			chkGreyScale.Checked = MainForm.cMainForm.VideoGrabber1.VideoProcessing_GrayScale;
			chkInvertColors.Checked = MainForm.cMainForm.VideoGrabber1.VideoProcessing_InvertColors;
			chkFlipVertical.Checked = MainForm.cMainForm.VideoGrabber1.VideoProcessing_FlipVertical;
			chkFlipHorizontal.Checked = MainForm.cMainForm.VideoGrabber1.VideoProcessing_FlipHorizontal;

			chkCroppingEnabled.Checked = MainForm.cMainForm.VideoGrabber1.Cropping_Enabled;
			chkCroppingOutbounds.Checked = MainForm.cMainForm.VideoGrabber1.Cropping_Outbounds;
			edtCroppingWidth.Text = MainForm.cMainForm.VideoGrabber1.Cropping_Width.ToString();
			edtCroppingHeight.Text = MainForm.cMainForm.VideoGrabber1.Cropping_Height.ToString();
			trkCroppingZoom.Value = (int) MainForm.cMainForm.VideoGrabber1.Cropping_Zoom * 100;

			// trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event;
			trkCroppingY.Value = MainForm.cMainForm.VideoGrabber1.Cropping_Y;
			trkCroppingX.Value = MainForm.cMainForm.VideoGrabber1.Cropping_X;

            lblSWVideoProcessingRequiresFrameGrabber.Visible = MainForm.cMainForm.VideoGrabber1.FrameGrabber == VidGrab.TFrameGrabber.fg_Disabled;

            RefreshVMR9Processing();

		}

        public void RefreshVMR9Processing()
        {
            int MinValue = 0;
            int MaxValue = 0;
            int StepSize = 0;
            int DefaultValue = 0;
            int CurrentValue = 0;

            lblVMR9Available.BackColor = Color.Red;
            if (MainForm.cMainForm.VideoGrabber1.IsVMR9ImageAdjustmentAvailable(true))
            {
                tbrVMR9Brightness.Enabled = MainForm.cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness,out MinValue,out MaxValue,out StepSize,out DefaultValue,out CurrentValue);
                if (tbrVMR9Brightness.Enabled)
                {
                    tbrVMR9Brightness.Minimum = MinValue;
                    tbrVMR9Brightness.Maximum = MaxValue;
                    tbrVMR9Brightness.SmallChange = StepSize;
                    tbrVMR9Brightness.LargeChange = StepSize;
                    tbrVMR9Brightness.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Brightness.Value = tbrVMR9Brightness.Minimum + ((tbrVMR9Brightness.Maximum - tbrVMR9Brightness.Minimum) / 2);
                }
                tbrVMR9Contrast.Enabled = MainForm.cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Contrast.Enabled)
                {
                    tbrVMR9Contrast.Minimum = MinValue;
                    tbrVMR9Contrast.Maximum = MaxValue;
                    tbrVMR9Contrast.SmallChange = StepSize;
                    tbrVMR9Contrast.LargeChange = StepSize;
                    tbrVMR9Contrast.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Contrast.Value = tbrVMR9Contrast.Minimum + ((tbrVMR9Contrast.Maximum - tbrVMR9Contrast.Minimum) / 2);
                }
                tbrVMR9Hue.Enabled = MainForm.cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Hue.Enabled)
                {
                    tbrVMR9Hue.Minimum = MinValue;
                    tbrVMR9Hue.Maximum = MaxValue;
                    tbrVMR9Hue.SmallChange = StepSize;
                    tbrVMR9Hue.LargeChange = StepSize;
                    tbrVMR9Hue.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Hue.Value = tbrVMR9Hue.Minimum + ((tbrVMR9Hue.Maximum - tbrVMR9Hue.Minimum) / 2);
                }
                tbrVMR9Saturation.Enabled = MainForm.cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Saturation.Enabled)
                {
                    tbrVMR9Saturation.Minimum = MinValue;
                    tbrVMR9Saturation.Maximum = MaxValue;
                    tbrVMR9Saturation.SmallChange = StepSize;
                    tbrVMR9Saturation.LargeChange = StepSize;
                    tbrVMR9Saturation.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Saturation.Value = tbrVMR9Saturation.Minimum + ((tbrVMR9Saturation.Maximum - tbrVMR9Saturation.Minimum) / 2);
                }
            }
            else
            {
                tbrVMR9Brightness.Enabled = false;
                tbrVMR9Contrast.Enabled = false;
                tbrVMR9Hue.Enabled = false;
                tbrVMR9Saturation.Enabled = false;
            }

        }

		private void btnCroppingZoomReset_Click(object sender, System.EventArgs e)
		{
			trkCroppingZoom.Value = 100;
            MainForm.cMainForm.VideoGrabber1.Cropping_Zoom = trkCroppingZoom.Value / 100;
		}

		private void btnResetAll_Click(object sender, System.EventArgs e)
		{
			rdgVideoRotation0.Checked = true;
			rdgDeinterlacingDisabled.Checked = true;
			tbrBrightness.Value = 0;
			tbrContrast.Value = 0;
			tbrSaturation.Value = 0;
			tbrHue.Value = 0;
			chkGreyScale.Checked = false;
			chkInvertColors.Checked = false;
			chkFlipVertical.Checked = false;
			chkFlipHorizontal.Checked = false;
		}

		private void chkCroppingEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Cropping_Enabled = chkCroppingEnabled.Checked;
		}

		private void chkCroppingOutbounds_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Cropping_Outbounds = chkCroppingOutbounds.Checked;
		}

		private void chkFlipHorizontal_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_FlipHorizontal = chkFlipHorizontal.Checked;
		}

		private void chkFlipVertical_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_FlipVertical = chkFlipVertical.Checked;
		}

		private void chkGreyScale_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_GrayScale = chkGreyScale.Checked;
		}

		private void chkInvertColors_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_InvertColors = chkInvertColors.Checked;
		}

		private void edtCroppingHeight_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtCroppingHeight.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.Cropping_Height = Convert.ToInt32 (edtCroppingHeight.Text);
			}
		}

		private void edtCroppingWidth_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtCroppingWidth.Text)) 
			{
				;
				MainForm.cMainForm.VideoGrabber1.Cropping_Width = Convert.ToInt32 (edtCroppingWidth.Text);
			};
		}

		private void rdgDeinterlacing_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.VideoProcessing_Deinterlacing = (VidGrab.TVideoDeinterlacing) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void rdgVideoRotation_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				MainForm.cMainForm.VideoGrabber1.VideoProcessing_Rotation = (VidGrab.TVideoRotation) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void tbrBrightness_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_Brightness = -tbrBrightness.Value;
		}

		private void tbrContrast_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_Contrast = -tbrContrast.Value;
		}

		private void tbrSaturation_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_Saturation = -tbrSaturation.Value;
		}

		private void tbrHue_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.VideoProcessing_Hue = -tbrHue.Value;
		}

		private void tbrVMR9Brightness_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness, tbrVMR9Brightness.Value, false);
		}

		private void tbrVMR9Contrast_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, tbrVMR9Contrast.Value, vmr9FixRange.Checked);
		}

		private void tbrVMR9Saturation_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, tbrVMR9Saturation.Value, vmr9FixRange.Checked);
		}

		private void tbrVMR9Hue_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, tbrVMR9Hue.Value, false);
		}

		private void trkCroppingX_Scroll(object sender, System.EventArgs e)
		{
			// trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event;
			MainForm.cMainForm.VideoGrabber1.Cropping_X = trkCroppingX.Value;
		}

		private void trkCroppingY_Scroll(object sender, System.EventArgs e)
		{
			// trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event;
			MainForm.cMainForm.VideoGrabber1.Cropping_Y = trkCroppingY.Value;
		}

		private void trkCroppingZoom_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Cropping_Zoom = trkCroppingZoom.Value / 100;
		}

		private void vmr9FixRange_CheckedChanged(object sender, System.EventArgs e)
		{
			// fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below;
		}

		private void edtCustomRotationAngle_TextChanged(object sender, System.EventArgs e)
		{
			if (Helpers.IsNumeric(edtCustomRotationAngle.Text)) 
			{
				MainForm.cMainForm.VideoGrabber1.VideoProcessing_RotationCustomAngle = Convert.ToDouble (edtCustomRotationAngle.Text);
			}
		}

		private void VideoProcessing_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

        private void updVideoPixelization_ValueChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.VideoProcessing_Pixellization =Convert.ToInt32(updVideoPixelization.Value);
        }

        private void rdgDetectVideoSignalDisabled_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoProcessing_DetectNoVideoSignal = false;
            MainForm.cMainForm.VideoProcessing_DetectConnexantBlueScreen = false;
        }

        private void rdgNoVideoSignal_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoProcessing_DetectNoVideoSignal = true;
            MainForm.cMainForm.VideoProcessing_DetectConnexantBlueScreen = false;
        }

        private void rdgConnexantbluescreen_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoProcessing_DetectConnexantBlueScreen = true;
            MainForm.cMainForm.VideoProcessing_DetectNoVideoSignal = false;
        }

	}
}
