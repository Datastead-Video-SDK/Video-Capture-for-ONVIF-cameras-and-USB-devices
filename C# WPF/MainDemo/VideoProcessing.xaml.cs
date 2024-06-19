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

using VidGrabWPF;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for VideoProcessing.xaml
    /// </summary>
    public partial class VideoProcessing : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public VideoProcessing(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        public void RefreshDisplayOptions()
        {
            Helpers.SetRadioButtonInGroupUsingTag(rdgVideoRotation, (short)VideoGrabber.VideoProcessing_Rotation);
            edtCustomRotationAngle.Text = VideoGrabber.VideoProcessing_RotationCustomAngle.ToString();

            Helpers.SetRadioButtonInGroupUsingTag(rdgDeinterlacing, (short)VideoGrabber.VideoProcessing_Deinterlacing);

            updVideoPixelization.Value = VideoGrabber.VideoProcessing_Pixellization;

            tbrBrightness.Value = VideoGrabber.VideoProcessing_Brightness;
            tbrContrast.Value = VideoGrabber.VideoProcessing_Contrast;
            tbrSaturation.Value = VideoGrabber.VideoProcessing_Saturation;
            tbrHue.Value = VideoGrabber.VideoProcessing_Hue;

            chkGreyScale.IsChecked = VideoGrabber.VideoProcessing_GrayScale;
            chkInvertColors.IsChecked = VideoGrabber.VideoProcessing_InvertColors;
            chkFlipVertical.IsChecked = VideoGrabber.VideoProcessing_FlipVertical;
            chkFlipHorizontal.IsChecked = VideoGrabber.VideoProcessing_FlipHorizontal;

            chkCroppingEnabled.IsChecked = VideoGrabber.Cropping_Enabled;
            chkCroppingOutbounds.IsChecked = VideoGrabber.Cropping_Outbounds;
            edtCroppingWidth.Text = VideoGrabber.Cropping_Width.ToString();
            edtCroppingHeight.Text = VideoGrabber.Cropping_Height.ToString();
            trkCroppingZoom.Value = (int)VideoGrabber.Cropping_Zoom * 100;

            // trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event;
            trkCroppingY.Value = VideoGrabber.Cropping_Y;
            trkCroppingX.Value = VideoGrabber.Cropping_X;

            if (VideoGrabber.FrameGrabber == VidGrab.TFrameGrabber.fg_Disabled)
            {
                lblSWVideoProcessingRequiresFrameGrabber.Visibility = Visibility.Visible;
            }
            else
            {
                lblSWVideoProcessingRequiresFrameGrabber.Visibility = Visibility.Hidden;
            }

            RefreshVMR9Processing();

        }

        public void RefreshVMR9Processing()
        {
            int MinValue = 0;
            int MaxValue = 0;
            int StepSize = 0;
            int DefaultValue = 0;
            int CurrentValue = 0;

            lblVMR9Available.Background = Brushes.Black;
            if (VideoGrabber.IsVMR9ImageAdjustmentAvailable(true))
            {
                tbrVMR9Brightness.IsEnabled = VideoGrabber.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Brightness.IsEnabled)
                {
                    tbrVMR9Brightness.Minimum = MinValue;
                    tbrVMR9Brightness.Maximum = MaxValue;
                    tbrVMR9Brightness.SmallChange = StepSize;
                    tbrVMR9Brightness.LargeChange = StepSize;
                    tbrVMR9Brightness.Value = CurrentValue;
                    lblVMR9Available.Background = Brushes.Green;
                }
                else
                {
                    tbrVMR9Brightness.Value = tbrVMR9Brightness.Minimum + ((tbrVMR9Brightness.Maximum - tbrVMR9Brightness.Minimum) / 2);
                }
                tbrVMR9Contrast.IsEnabled = VideoGrabber.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Contrast.IsEnabled)
                {
                    tbrVMR9Contrast.Minimum = MinValue;
                    tbrVMR9Contrast.Maximum = MaxValue;
                    tbrVMR9Contrast.SmallChange = StepSize;
                    tbrVMR9Contrast.LargeChange = StepSize;
                    tbrVMR9Contrast.Value = CurrentValue;
                    lblVMR9Available.Background = Brushes.Green;
                }
                else
                {
                    tbrVMR9Contrast.Value = tbrVMR9Contrast.Minimum + ((tbrVMR9Contrast.Maximum - tbrVMR9Contrast.Minimum) / 2);
                }
                tbrVMR9Hue.IsEnabled = VideoGrabber.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Hue.IsEnabled)
                {
                    tbrVMR9Hue.Minimum = MinValue;
                    tbrVMR9Hue.Maximum = MaxValue;
                    tbrVMR9Hue.SmallChange = StepSize;
                    tbrVMR9Hue.LargeChange = StepSize;
                    tbrVMR9Hue.Value = CurrentValue;
                    lblVMR9Available.Background = Brushes.Green;
                }
                else
                {
                    tbrVMR9Hue.Value = tbrVMR9Hue.Minimum + ((tbrVMR9Hue.Maximum - tbrVMR9Hue.Minimum) / 2);
                }
                tbrVMR9Saturation.IsEnabled = VideoGrabber.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Saturation.IsEnabled)
                {
                    tbrVMR9Saturation.Minimum = MinValue;
                    tbrVMR9Saturation.Maximum = MaxValue;
                    tbrVMR9Saturation.SmallChange = StepSize;
                    tbrVMR9Saturation.LargeChange = StepSize;
                    tbrVMR9Saturation.Value = CurrentValue;
                    lblVMR9Available.Background = Brushes.Green;
                }
                else
                {
                    tbrVMR9Saturation.Value = tbrVMR9Saturation.Minimum + ((tbrVMR9Saturation.Maximum - tbrVMR9Saturation.Minimum) / 2);
                }
            }
            else
            {
                tbrVMR9Brightness.IsEnabled = false;
                tbrVMR9Contrast.IsEnabled = false;
                tbrVMR9Hue.IsEnabled = false;
                tbrVMR9Saturation.IsEnabled = false;
            }

        }

        private void btnCroppingZoomReset_Click(object sender, RoutedEventArgs e)
        {
            trkCroppingZoom.Value = 100;
            VideoGrabber.Cropping_Zoom = trkCroppingZoom.Value / 100;
        }

        private void btnResetAll_Click(object sender, RoutedEventArgs e)
        {
            rdgVideoRotation0.IsChecked = true;
            rdgDeinterlacingDisabled.IsChecked = true;
            tbrBrightness.Value = 0;
            tbrContrast.Value = 0;
            tbrSaturation.Value = 0;
            tbrHue.Value = 0;
            chkGreyScale.IsChecked = false;
            chkInvertColors.IsChecked = false;
            chkFlipVertical.IsChecked = false;
            chkFlipHorizontal.IsChecked = false;
        }

        private void chkCroppingEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Cropping_Enabled = chkCroppingEnabled.IsChecked == true;
        }

        private void chkCroppingOutbounds_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Cropping_Outbounds = chkCroppingOutbounds.IsChecked == true;
        }

        private void chkFlipHorizontal_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoProcessing_FlipHorizontal = chkFlipHorizontal.IsChecked == true;
        }

        private void chkFlipVertical_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoProcessing_FlipVertical = chkFlipVertical.IsChecked == true;
        }

        private void chkGreyScale_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoProcessing_GrayScale = chkGreyScale.IsChecked == true;
        }

        private void chkInvertColors_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoProcessing_InvertColors = chkInvertColors.IsChecked == true;
        }

        private void edtCroppingHeight_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtCroppingHeight.Text))
            {
                VideoGrabber.Cropping_Height = Convert.ToInt32(edtCroppingHeight.Text);
            }
        }

        private void edtCroppingWidth_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtCroppingWidth.Text))
            {
                ;
                VideoGrabber.Cropping_Width = Convert.ToInt32(edtCroppingWidth.Text);
            };
        }

        private void rdgDeinterlacing_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.VideoProcessing_Deinterlacing = (VidGrab.TVideoDeinterlacing)Convert.ToInt32((sender as Control).TabIndex);
            }
        }

        private void rdgVideoRotation_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                VideoGrabber.VideoProcessing_Rotation = (VidGrab.TVideoRotation)Convert.ToInt32((sender as Control).TabIndex);
            }
        }

        private void vmr9FixRange_CheckedChanged(object sender, RoutedEventArgs e)
        {
            // fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below;
        }

        private void edtCustomRotationAngle_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Helpers.IsNumeric(edtCustomRotationAngle.Text))
            {
                VideoGrabber.VideoProcessing_RotationCustomAngle = Convert.ToDouble(edtCustomRotationAngle.Text);
            }
        }

        private void VideoProcessing_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void updVideoPixelization_ValueChanged(object sender, EventArgs e)
        {
            VideoGrabber.VideoProcessing_Pixellization = Convert.ToInt32(updVideoPixelization.Value);
        }

        private void rdgDetectVideoSignalDisabled_CheckedChanged(object sender, EventArgs e)
        {
            MainDemoWPF.MainForm.MainFormInstance.VideoProcessing_DetectNoVideoSignal = false;
            MainDemoWPF.MainForm.MainFormInstance.VideoProcessing_DetectConnexantBlueScreen = false;
        }

        private void rdgNoVideoSignal_CheckedChanged(object sender, EventArgs e)
        {
            MainDemoWPF.MainForm.MainFormInstance.VideoProcessing_DetectNoVideoSignal = true;
            MainDemoWPF.MainForm.MainFormInstance.VideoProcessing_DetectConnexantBlueScreen = false;
        }

        private void rdgConnexantbluescreen_CheckedChanged(object sender, EventArgs e)
        {
            MainDemoWPF.MainForm.MainFormInstance.VideoProcessing_DetectConnexantBlueScreen = true;
            MainDemoWPF.MainForm.MainFormInstance.VideoProcessing_DetectNoVideoSignal = false;
        }

        private void tbrBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.VideoProcessing_Brightness = (int)-tbrBrightness.Value;
        }

        private void tbrContrast_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.VideoProcessing_Contrast = (int)-tbrContrast.Value;
        }

        private void tbrSaturation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.VideoProcessing_Saturation = (int)-tbrSaturation.Value;
        }

        private void tbrHue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.VideoProcessing_Hue = (int)-tbrHue.Value;
        }

        private void tbrVMR9Brightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness, (int)tbrVMR9Brightness.Value, false);
        }

        private void tbrVMR9Contrast_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, (int)tbrVMR9Contrast.Value, vmr9FixRange.IsChecked == true);
        }
        private void tbrVMR9Saturation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, (int)tbrVMR9Saturation.Value, vmr9FixRange.IsChecked == true);
        }
        private void tbrVMR9Hue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, (int)tbrVMR9Hue.Value, false);
        }

        private void trkCroppingZoom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.Cropping_Zoom = trkCroppingZoom.Value / 100;
        }

        private void trkCroppingX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event;
            VideoGrabber.Cropping_X = (int)trkCroppingX.Value;
        }

        private void trkCroppingY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event;
            VideoGrabber.Cropping_Y = (int)trkCroppingY.Value;
        }
    }
}
