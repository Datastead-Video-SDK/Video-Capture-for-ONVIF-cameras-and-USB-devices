using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class miscVideoQuality : Form
	{

		public miscVideoQuality()
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

		private void miscVideoQuality_Load(object sender, System.EventArgs e)
		{
			FSettingGroup = new SettingGroup[10];
		}

		public void RefreshDisplayOptions()
		{
			if (FSettingGroup == null) return; // not yet loaded
			InitTrackBar(chkBrightness, btnBrightness, tbrBrightness, VidGrab.TVideoQuality.vq_Brightness);
			InitTrackBar(chkContrast, btnContrast, tbrContrast, VidGrab.TVideoQuality.vq_Contrast);
			InitTrackBar(chkHue, btnHue, tbrHue, VidGrab.TVideoQuality.vq_Hue);
			InitTrackBar(chkSaturation, btnSaturation, tbrSaturation, VidGrab.TVideoQuality.vq_Saturation);
			InitTrackBar(chkSharpness, btnSharpness, tbrSharpness, VidGrab.TVideoQuality.vq_Sharpness);
			InitTrackBar(chkGamma, btnGamma, tbrGamma, VidGrab.TVideoQuality.vq_Gamma);
			InitTrackBar(chkWhiteBalance, btnWhiteBalance, tbrWhiteBalance, VidGrab.TVideoQuality.vq_WhiteBalance);
			InitTrackBar(chkGain, btnGain, tbrGain, VidGrab.TVideoQuality.vq_Gain);
		}
		
		private void InitTrackBar(CheckBox chkAuto, Button btnDefault, TrackBar tbrValue, VidGrab.TVideoQuality Setting)
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

			if (! MainForm.cMainForm.VideoGrabber1.IsVideoQualitySettingAvailable(Setting)) 
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
				chkAuto.Checked = MainForm.cMainForm.VideoGrabber1.VideoQualityAuto(Setting);
				tbrValue.Enabled = ! chkAuto.Checked;
				btnDefault.Enabled = ! chkAuto.Checked;

                int MinValue = MainForm.cMainForm.VideoGrabber1.VideoQualityMin(Setting);
                int MaxValue = MainForm.cMainForm.VideoGrabber1.VideoQualityMax(Setting);
                int CurrentValue = MainForm.cMainForm.VideoGrabber1.VideoQualityValue(Setting);

                tbrValue.Minimum = MinValue;
                tbrValue.Maximum = MaxValue;
                tbrValue.TickFrequency = MainForm.cMainForm.VideoGrabber1.VideoQualityStep(Setting);
                tbrValue.Value = CurrentValue;
            }
		}

		private void tbrSetValue (System.Object sender, System.EventArgs e)
		{
			int Setting = Convert.ToInt32 ((sender as Control).Tag);

			MainForm.cMainForm.VideoGrabber1.SetVideoQuality((VidGrab.TVideoQuality) Setting, FSettingGroup[Setting].chkAuto.Checked, false, FSettingGroup[Setting].tbrValue.Value);

			FSettingGroup[Setting].tbrValue.Enabled = ! FSettingGroup[Setting].chkAuto.Checked;
			FSettingGroup[Setting].btnDefault.Enabled = ! FSettingGroup[Setting].chkAuto.Checked;
		}

		private void btnSetDefault (System.Object sender, System.EventArgs e)
		{
			int Setting = Convert.ToInt32 ((sender as Control).Tag);

			MainForm.cMainForm.VideoGrabber1.SetVideoQuality((VidGrab.TVideoQuality) Setting, FSettingGroup[Setting].chkAuto.Checked, true, FSettingGroup[Setting].tbrValue.Value);
			FSettingGroup[Setting].tbrValue.Value = MainForm.cMainForm.VideoGrabber1.VideoQualityValue((VidGrab.TVideoQuality) Setting);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miscVideoQuality_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

	}
}
