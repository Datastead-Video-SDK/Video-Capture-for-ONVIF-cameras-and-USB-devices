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
    /// Interaction logic for miscCameraControl.xaml
    /// </summary>
    public partial class miscCameraControl : Window
    {
        private VideoGrabberWPF VideoGrabber;

        public miscCameraControl(VideoGrabberWPF MainFormVideoGrabber)
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

        private void miscCameraControl_Load(object sender, RoutedEventArgs e)
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

        private void InitTrackBar(CheckBox chkAuto, Button btnDefault, Slider tbrValue, VidGrab.TCameraControl Setting)
        {
            tbrValue.Tag = Setting;

            //TODO tbrValue.ValueChanged += RoutedPropertyChangedEventHandler<double>(tbrSetValue);
            //TODO btnDefault.Click += new RoutedEventHandler(btnSetDefault);
            //TODO chkAuto.CheckedChanged += new System.EventHandler(tbrSetValue);

            tbrValue.Tag = Setting;
            chkAuto.Tag = Setting;
            btnDefault.Tag = Setting;

            int iSetting = Convert.ToInt32(Setting);

            FSettingGroup[iSetting].tbrValue = tbrValue;
            FSettingGroup[iSetting].chkAuto = chkAuto;
            FSettingGroup[iSetting].btnDefault = btnDefault;

            if (!VideoGrabber.IsCameraControlSettingAvailable(Setting))
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
                chkAuto.IsChecked = VideoGrabber.CameraControlAuto(Setting);
                tbrValue.IsEnabled = !chkAuto.IsChecked == true;
                btnDefault.IsEnabled = !chkAuto.IsChecked == true;

                int MinValue = VideoGrabber.CameraControlMin(Setting);
                int MaxValue = VideoGrabber.CameraControlMax(Setting);
                int CurrentValue = VideoGrabber.CameraControlValue(Setting);

                tbrValue.Minimum = MinValue;
                tbrValue.Maximum = MaxValue;
                tbrValue.TickFrequency = VideoGrabber.CameraControlStep(Setting);
                tbrValue.Value = CurrentValue;
            }
        }

        private void tbrSetValue(Object sender, RoutedPropertyChangedEventHandler<double> e)
        {
            int Setting = Convert.ToInt32((sender as Control).TabIndex);

            VideoGrabber.SetCameraControl((VidGrab.TCameraControl)Setting, FSettingGroup[Setting].chkAuto.IsChecked == true, false, (int) FSettingGroup[Setting].tbrValue.Value);

            FSettingGroup[Setting].tbrValue.IsEnabled = !FSettingGroup[Setting].chkAuto.IsChecked == true;
            FSettingGroup[Setting].btnDefault.IsEnabled = !FSettingGroup[Setting].chkAuto.IsChecked == true;
        }

        private void btnSetDefault(System.Object sender, RoutedEventHandler e)
        {
            int Setting = Convert.ToInt32((sender as Control).TabIndex);

            VideoGrabber.SetCameraControl((VidGrab.TCameraControl)Setting, FSettingGroup[Setting].chkAuto.IsChecked == true, true, (int) FSettingGroup[Setting].tbrValue.Value);
            FSettingGroup[Setting].tbrValue.Value = VideoGrabber.CameraControlValue((VidGrab.TCameraControl)Setting);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void miscCameraControl_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

    }
}
