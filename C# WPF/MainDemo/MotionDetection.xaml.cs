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
    /// Interaction logic for MotionDetection.xaml
    /// </summary>
    /// 

    public partial class MotionDetection : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public MotionDetection(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }


        public void RefreshDisplayOptions()
        {
            chkMotionDetectionEnabled.IsChecked = VideoGrabber.MotionDetector_Enabled;
            chkCompareRed.IsChecked = VideoGrabber.MotionDetector_CompareRed;
            chkCompareGreen.IsChecked = VideoGrabber.MotionDetector_CompareGreen;
            chkCompareBlue.IsChecked = VideoGrabber.MotionDetector_CompareBlue;
            chk_GreyScale.IsChecked = VideoGrabber.MotionDetector_GreyScale;
            chkReduceVideoNoise.IsChecked = VideoGrabber.MotionDetector_ReduceVideoNoise;
            edtGrid.Text = VideoGrabber.MotionDetector_Grid;
            mmoSensitivityGrid.Text = VideoGrabber.MotionDetector_Get2DTextGrid();
            updGridColCount.Value = VideoGrabber.MotionDetector_GridXCount;
            updGridRowCount.Value = VideoGrabber.MotionDetector_GridYCount;
            if (VideoGrabber.FrameGrabber == VidGrab.TFrameGrabber.fg_Disabled)
            {
                lblMotionDetectorRequiresFrameGrabber.Visibility = Visibility.Visible;
            }
            else
            {
                lblMotionDetectorRequiresFrameGrabber.Visibility = Visibility.Hidden;
            }
        }

        private void btnApplyGridSize_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_SetGridSize(Convert.ToInt32(updGridColCount.Value), Convert.ToInt32(updGridRowCount.Value));
            edtGrid.Text = VideoGrabber.MotionDetector_Grid;
            mmoSensitivityGrid.Text = VideoGrabber.MotionDetector_Get2DTextGrid();
        }

        private void btnSetCellsSensitivity_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_SetCellSensitivity(Convert.ToInt32(updXCell.Value), Convert.ToInt32(updYCell.Value), Convert.ToInt32(updCellSensitivity.Value));
            edtGrid.Text = VideoGrabber.MotionDetector_Grid;
            mmoSensitivityGrid.Text = VideoGrabber.MotionDetector_Get2DTextGrid();
        }

        private void btnShowGridDialog_Click(object sender, RoutedEventArgs e)
        {
            if ((VideoGrabber.CurrentState != VidGrab.TCurrentState.cs_Preview) && (VideoGrabber.CurrentState != VidGrab.TCurrentState.cs_Recording))
            {
                MessageBox.Show("you should start preview or recording to see the video frame under the grid",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
            }
            if (!VideoGrabber.MotionDetector_Enabled)
            {
                MessageBox.Show("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
            };
            if ((VideoGrabber.MotionDetector_GridXCount > 30) || (VideoGrabber.MotionDetector_GridYCount > 30))
            {
                MessageBox.Show("the grid will be too dense to be edited through the dialog, you should use SetGridCell",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
            }
            VideoGrabber.MotionDetector_ShowGridDialog();
            edtGrid.Text = VideoGrabber.MotionDetector_Grid;
            mmoSensitivityGrid.Text = VideoGrabber.MotionDetector_Get2DTextGrid();
        }

        private void chk_triggered_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_Triggered = chk_triggered.IsChecked == true;
        }

        private void btn_TriggerNow_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_TriggerNow();
        }

        private void chk_GreyScale_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_GreyScale = chk_GreyScale.IsChecked == true;
        }

        private void chkCompareBlue_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_CompareBlue = chkCompareBlue.IsChecked == true;
        }

        private void chkCompareGreen_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_CompareGreen = chkCompareGreen.IsChecked == true;
        }

        private void chkCompareRed_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_CompareRed = chkCompareRed.IsChecked == true;
        }

        private void chkMotionDetectionEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_Enabled = chkMotionDetectionEnabled.IsChecked == true;
            MotionDetected = false;
        }

        private void chkReduceVideoNoise_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_ReduceVideoNoise = chkReduceVideoNoise.IsChecked == true;
        }

        private void edtGrid_TextChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MotionDetector_Grid = edtGrid.Text;
            if (VideoGrabber.MotionDetector_IsGridValid)
            {
                lblGridValid.Content = "valid";
                lblGridValid.Foreground = Brushes.Green;
            }
            else
            {
                lblGridValid.Content = "invalid";
                lblGridValid.Foreground = Brushes.Red;
            }
            mmoSensitivityGrid.Text = VideoGrabber.MotionDetector_Get2DTextGrid();
        }

        private void updGlobalGridSensitivity_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (updGlobalGridSensitivity.Value > Convert.ToInt32(updGlobalGridSensitivity.Tag))
            {
                VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(1);
            }
            else
            {
                VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(-1);
            }
            updGlobalGridSensitivity.Tag = updGlobalGridSensitivity.Value;
            edtGrid.Text = VideoGrabber.MotionDetector_Grid;
        }

        private void MotionDetection_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        /* TODO
        private void grbMotionRatio_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = null;
            g = e.Graphics;
            g.FillEllipse((MainForm.cMainForm.boolMotionRatio ? MainForm.cMainForm.brushMotionRatio : Brushes.DarkGreen), 10, 20, 15, 15);
            g.DrawEllipse(Pens.Blue, 10, 20, 15, 15);
        }
        */


        public bool MotionDetected
        {
            get
            {
                return MainDemoWPF.MainForm.MainFormInstance.boolMotionRatio;
            }
            set
            {
                MainDemoWPF.MainForm.MainFormInstance.boolMotionRatio = value;
                MainDemoWPF.MainForm.MainFormInstance.brushMotionRatio = (MainDemoWPF.MainForm.MainFormInstance.boolMotionRatio ? System.Drawing.Brushes.SpringGreen : System.Drawing.Brushes.DarkGreen);
                //TODO grbMotionRatio.Refresh();
            }
        }
    }
}
