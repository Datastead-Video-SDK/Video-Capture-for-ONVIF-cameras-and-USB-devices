using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class MotionDetection : Form
    {
              

		public MotionDetection()
		{
			InitializeComponent();
		}

		public void RefreshDisplayOptions()
		{
			chkMotionDetectionEnabled.Checked = MainForm.cMainForm.VideoGrabber1.MotionDetector_Enabled;
			chkCompareRed.Checked = MainForm.cMainForm.VideoGrabber1.MotionDetector_CompareRed;
			chkCompareGreen.Checked = MainForm.cMainForm.VideoGrabber1.MotionDetector_CompareGreen;
			chkCompareBlue.Checked = MainForm.cMainForm.VideoGrabber1.MotionDetector_CompareBlue;
			chk_GreyScale.Checked = MainForm.cMainForm.VideoGrabber1.MotionDetector_GreyScale;
			chkReduceVideoNoise.Checked = MainForm.cMainForm.VideoGrabber1.MotionDetector_ReduceVideoNoise;
			edtGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Get2DTextGrid();
			updGridColCount.Value = MainForm.cMainForm.VideoGrabber1.MotionDetector_GridXCount;
			updGridRowCount.Value = MainForm.cMainForm.VideoGrabber1.MotionDetector_GridYCount;
			lblMotionDetectorRequiresFrameGrabber.Visible = MainForm.cMainForm.VideoGrabber1.FrameGrabber == VidGrab.TFrameGrabber.fg_Disabled;
			updGlobalGridSensitivity.Tag = updGlobalGridSensitivity.Value;
		}

		private void btnApplyGridSize_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_SetGridSize(Convert.ToInt32(updGridColCount.Value), Convert.ToInt32(updGridRowCount.Value));
			edtGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Get2DTextGrid();
		}

		private void btnSetCellsSensitivity_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_SetCellSensitivity(Convert.ToInt32(updXCell.Value), Convert.ToInt32(updYCell.Value), Convert.ToInt32(updCellSensitivity.Value));
			edtGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Get2DTextGrid();
		}

		private void btnShowGridDialog_Click(object sender, System.EventArgs e)
		{
			if ((MainForm.cMainForm.VideoGrabber1.CurrentState != VidGrab.TCurrentState.cs_Preview) && (MainForm.cMainForm.VideoGrabber1.CurrentState != VidGrab.TCurrentState.cs_Recording)) 
			{
				MessageBox.Show ("you should start preview or recording to see the video frame under the grid",
                            "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
			}
			if (! MainForm.cMainForm.VideoGrabber1.MotionDetector_Enabled) 
			{
                MessageBox.Show("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
			};
			if ((MainForm.cMainForm.VideoGrabber1.MotionDetector_GridXCount > 30) || (MainForm.cMainForm.VideoGrabber1.MotionDetector_GridYCount > 30)) 
			{
                MessageBox.Show("the grid will be too dense to be edited through the dialog, you should use SetGridCell",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
			}
			MainForm.cMainForm.VideoGrabber1.MotionDetector_ShowGridDialog();
			edtGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Get2DTextGrid();
		}

		private void chk_triggered_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_Triggered = chk_triggered.Checked;
		}

		private void btn_TriggerNow_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_TriggerNow();
		}

		private void chk_GreyScale_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_GreyScale = chk_GreyScale.Checked;
		}

		private void chkCompareBlue_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_CompareBlue = chkCompareBlue.Checked;
		}

		private void chkCompareGreen_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_CompareGreen = chkCompareGreen.Checked;
		}

		private void chkCompareRed_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_CompareRed = chkCompareRed.Checked;
		}

		private void chkMotionDetectionEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_Enabled = chkMotionDetectionEnabled.Checked;
            MotionDetected = false;
		}

		private void chkReduceVideoNoise_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_ReduceVideoNoise = chkReduceVideoNoise.Checked;
		}

		private void edtGrid_TextChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MotionDetector_Grid = edtGrid.Text;
			if (MainForm.cMainForm.VideoGrabber1.MotionDetector_IsGridValid) 
			{
				lblGridValid.Text = "valid";
                lblGridValid.ForeColor = Color.Green;
			}
			else {
				lblGridValid.Text = "invalid";
                lblGridValid.ForeColor = Color.Red;
			}
			mmoSensitivityGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Get2DTextGrid();
		}

		private void updGlobalGridSensitivity_ValueChanged(object sender, System.EventArgs e)
		{
			if (updGlobalGridSensitivity.Value > Convert.ToInt32(updGlobalGridSensitivity.Tag)) 
			{
				MainForm.cMainForm.VideoGrabber1.MotionDetector_GloballyIncOrDecSensitivity(1);
			}
			else 
			{
				MainForm.cMainForm.VideoGrabber1.MotionDetector_GloballyIncOrDecSensitivity(-1);
			}
			updGlobalGridSensitivity.Tag = updGlobalGridSensitivity.Value;
			edtGrid.Text = MainForm.cMainForm.VideoGrabber1.MotionDetector_Grid;
		}

		private void MotionDetection_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

        private void grbMotionRatio_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = null;
            g = e.Graphics;
            g.FillEllipse((MainForm.cMainForm.boolMotionRatio ? MainForm.cMainForm.brushMotionRatio : Brushes.DarkGreen), 10, 20, 15, 15);
            g.DrawEllipse(Pens.Blue, 10, 20, 15, 15);
        }

        
        public bool MotionDetected
        {
            get
            {
                return MainForm.cMainForm.boolMotionRatio;
            }
            set
            {
                MainForm.cMainForm.boolMotionRatio = value;
                MainForm.cMainForm.brushMotionRatio = (MainForm.cMainForm.boolMotionRatio ? Brushes.SpringGreen : Brushes.DarkGreen);
                grbMotionRatio.Refresh();
            }
        }
        

	}
}
