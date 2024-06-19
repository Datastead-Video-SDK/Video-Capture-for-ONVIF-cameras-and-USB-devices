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
    /// Interaction logic for miscVideoQuality.xaml
    /// </summary>
    public partial class miscVideoQuality : Window
    {
        private VideoGrabberWPF VideoGrabber;

        public miscVideoQuality(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        public struct SettingGroup
        {
            public Slider tbrValue;
            public CheckBox chkAuto;
            public Button btnDefault;
        }
        public SettingGroup[] FSettingGroup;

        private void miscVideoQuality_Load(object sender, RoutedEventArgs e)
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

        private void InitTrackBar(CheckBox chkAuto, Button btnDefault, Slider tbrValue, VidGrab.TVideoQuality Setting)
        {
            tbrValue.Tag = Setting;

            //TODO tbrValue.Scroll += new System.EventHandler(tbrSetValue);
            //TODO btnDefault.Click += new System.EventHandler(btnSetDefault);
            //TODO chkAuto.CheckedChanged += new System.EventHandler(tbrSetValue);

            tbrValue.Tag = Setting;
            chkAuto.Tag = Setting;
            btnDefault.Tag = Setting;

            int iSetting = Convert.ToInt32(Setting);

            FSettingGroup[iSetting].tbrValue = tbrValue;
            FSettingGroup[iSetting].chkAuto = chkAuto;
            FSettingGroup[iSetting].btnDefault = btnDefault;

            if (!VideoGrabber.IsVideoQualitySettingAvailable(Setting))
            {
                tbrValue.IsEnabled = false;
                tbrValue.TickFrequency = 0;
                tbrValue.Minimum = 0;
                tbrValue.Maximum = 1;
                tbrValue.Value = 1;
                chkAuto.IsEnabled = false;
                btnDefault.IsEnabled = false;
            }
            else
            {
                chkAuto.IsEnabled = true;
                chkAuto.IsChecked = VideoGrabber.VideoQualityAuto(Setting);
                tbrValue.IsEnabled = !chkAuto.IsChecked == true;
                btnDefault.IsEnabled = !chkAuto.IsChecked == true;

                int MinValue = VideoGrabber.VideoQualityMin(Setting);
                int MaxValue = VideoGrabber.VideoQualityMax(Setting);
                int CurrentValue = VideoGrabber.VideoQualityValue(Setting);

                tbrValue.Minimum = MinValue;
                tbrValue.Maximum = MaxValue;
                tbrValue.TickFrequency = VideoGrabber.VideoQualityStep(Setting);
                tbrValue.Value = CurrentValue;
            }
        }

        private void tbrSetValue(System.Object sender, RoutedEventArgs e)
        {
            int Setting = Convert.ToInt32((sender as Control).TabIndex);

            VideoGrabber.SetVideoQuality((VidGrab.TVideoQuality)Setting, FSettingGroup[Setting].chkAuto.IsChecked == true, false, (int) FSettingGroup[Setting].tbrValue.Value);

            FSettingGroup[Setting].tbrValue.IsEnabled = !FSettingGroup[Setting].chkAuto.IsChecked == true;
            FSettingGroup[Setting].btnDefault.IsEnabled = !FSettingGroup[Setting].chkAuto.IsChecked == true;
        }

        private void btnSetDefault(System.Object sender, RoutedEventArgs e)
        {
            int Setting = Convert.ToInt32((sender as Control).TabIndex);

            VideoGrabber.SetVideoQuality((VidGrab.TVideoQuality)Setting, FSettingGroup[Setting].chkAuto.IsChecked == true, true, (int) FSettingGroup[Setting].tbrValue.Value);
            FSettingGroup[Setting].tbrValue.Value = VideoGrabber.VideoQualityValue((VidGrab.TVideoQuality)Setting);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void miscVideoQuality_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }


    }
}
