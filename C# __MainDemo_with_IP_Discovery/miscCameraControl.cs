using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class miscCameraControl : Form
	{
		public miscCameraControl()
		{
			InitializeComponent();
		}

		public struct SettingGroup 
		{
			public TrackBar tbrValue;
			public CheckBox chkAuto;
			public Button  btnDefault;
		}
		public SettingGroup[] FSettingGroup;

		private void miscCameraControl_Load(object sender, System.EventArgs e)
		{
			FSettingGroup = new SettingGroup[7];
			}

		public void RefreshDisplayOptions()
		{
			if (FSettingGroup == null) return; // not yet loaded
			
			InitTrackBar(chkPan, btnPan, tbrPan, VidGrab.TCameraControl.cc_Pan);
			InitTrackBar(chkTilt, btnTilt, tbrTilt, VidGrab.TCameraControl.cc_Tilt);
			InitTrackBar(chkRoll, btnRoll, tbrRoll, VidGrab.TCameraControl.cc_Roll);
			InitTrackBar(chkZoom, btnZoom, tbrZoom, VidGrab.TCameraControl.cc_Zoom);
			InitTrackBar(chkExposure, btnExposure, tbrExposure, VidGrab.TCameraControl.cc_Exposure);
			InitTrackBar(chkIris, btnIris, tbrIris, VidGrab.TCameraControl.cc_Iris);
			InitTrackBar(chkFocus, btnFocus, tbrFocus, VidGrab.TCameraControl.cc_Focus);
		}
		
		private void InitTrackBar(CheckBox chkAuto, Button btnDefault, TrackBar tbrValue, VidGrab.TCameraControl Setting)
		{
			tbrValue.Tag = Setting;

			tbrValue.Scroll += new System.EventHandler (tbrSetValue);
			btnDefault.Click += new System.EventHandler (btnSetDefault);
			chkAuto.CheckedChanged += new System.EventHandler (tbrSetValue);

			tbrValue.Tag = Setting;
			chkAuto.Tag = Setting;
			btnDefault.Tag = Setting;
			
			int iSetting = Convert.ToInt32 (Setting);

			FSettingGroup[iSetting].tbrValue = tbrValue;
			FSettingGroup[iSetting].chkAuto = chkAuto;
			FSettingGroup[iSetting].btnDefault = btnDefault;

			if (! MainForm.cMainForm.VideoGrabber1.IsCameraControlSettingAvailable(Setting)) 
			{
				tbrValue.Enabled = false;
				tbrValue.TickFrequency = 0;
				tbrValue.Minimum = 0;
				tbrValue.Maximum = 1;
				tbrValue.Value = 1;
				chkAuto.Enabled = false;
				btnDefault.Enabled = false;
			}
			else 
			{
				chkAuto.Enabled = true;
				chkAuto.Checked = MainForm.cMainForm.VideoGrabber1.CameraControlAuto(Setting);
				tbrValue.Enabled = ! chkAuto.Checked;
				btnDefault.Enabled = ! chkAuto.Checked;

                int MinValue = MainForm.cMainForm.VideoGrabber1.CameraControlMin(Setting);
                int MaxValue = MainForm.cMainForm.VideoGrabber1.CameraControlMax(Setting);
                int CurrentValue = MainForm.cMainForm.VideoGrabber1.CameraControlValue(Setting);

                tbrValue.Minimum = MinValue;
                tbrValue.Maximum = MaxValue;
                tbrValue.TickFrequency = MainForm.cMainForm.VideoGrabber1.CameraControlStep(Setting);
                tbrValue.Value = CurrentValue;
            }
		}
		
		private void tbrSetValue (System.Object sender, System.EventArgs e)
		{
			int Setting = Convert.ToInt32 ((sender as Control).Tag);

			MainForm.cMainForm.VideoGrabber1.SetCameraControl((VidGrab.TCameraControl) Setting, FSettingGroup[Setting].chkAuto.Checked, false, FSettingGroup[Setting].tbrValue.Value);

			FSettingGroup[Setting].tbrValue.Enabled = ! FSettingGroup[Setting].chkAuto.Checked;
			FSettingGroup[Setting].btnDefault.Enabled = ! FSettingGroup[Setting].chkAuto.Checked;
		}

		private void btnSetDefault (System.Object sender, System.EventArgs e)
		{
			int Setting = Convert.ToInt32 ((sender as Control).Tag);

			MainForm.cMainForm.VideoGrabber1.SetCameraControl((VidGrab.TCameraControl) Setting, FSettingGroup[Setting].chkAuto.Checked, true, FSettingGroup[Setting].tbrValue.Value);
			FSettingGroup[Setting].tbrValue.Value = MainForm.cMainForm.VideoGrabber1.CameraControlValue((VidGrab.TCameraControl) Setting);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miscCameraControl_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}
	}
}
