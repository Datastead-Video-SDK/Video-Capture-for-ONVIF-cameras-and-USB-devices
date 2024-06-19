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
    /// Interaction logic for Audio.xaml
    /// </summary>
    public partial class Audio : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        public Audio(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        private const int VU_LEFT = 0;
        private const int VU_RIGHT = 1;

        public void RefreshDisplayOptions()
        {
            Helpers.AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices, VideoGrabber.AudioDevice);

            if (VideoGrabber.AudioDevice >= 0)
            { // if an audio capture device has been selected
                Helpers.AssignListToComboBox(cboAudioInputs, VideoGrabber.AudioInputs, VideoGrabber.AudioInput);
            }

            tbrAudioInputLevel.Value = VideoGrabber.AudioInputLevel;
            tbrAudioInputBalance.Value = VideoGrabber.AudioInputBalance;
            chkAudioInputMono.IsChecked = VideoGrabber.AudioInputMono;

            Helpers.AssignListToComboBox(cboAudioRenderers, VideoGrabber.AudioRenderers, VideoGrabber.AudioRenderer);

            chkRenderAudioDevice.IsChecked = VideoGrabber.AudioDeviceRendering;
            chkExternalAudio.IsChecked = (VideoGrabber.AudioSource == VidGrab.TAudioSource.as_UseExternalAudio);
            chkMuteAudioRendering.IsChecked = VideoGrabber.MuteAudioRendering;

            if (VideoGrabber.AudioDevice == -1)
            {
                cboAudioDevices.Text = "SELECT AND AUDIO CAPTURE DEVICE IN THIS LIST";
            }
            if (VideoGrabber.AudioRenderer == -1)
            {
                cboAudioRenderers.Text = "default (AudioRenderer = -1)";
            }
        }

        private void cboAudioDevices_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioDevice = cboAudioDevices.SelectedIndex;
        }

        private void btnAudioDeviceDialog_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.ShowDialog(VidGrab.TDialog.dlg_AudioDevice);
        }

        private void cboAudioInputs_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioInput = cboAudioInputs.SelectedIndex;
        }

        private void chkAudioInputMono_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioInputMono = chkAudioInputMono.IsChecked == true;

        }

        private void chkRenderAudioDevice_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioDeviceRendering = chkRenderAudioDevice.IsChecked == true;
        }

        private void chkExternalAudio_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkExternalAudio.IsChecked == true)
            {
                VideoGrabber.AudioSource = VidGrab.TAudioSource.as_UseExternalAudio;
            }
            else
            {
                VideoGrabber.AudioSource = VidGrab.TAudioSource.as_Default;
            }
        }

        private void chkMuteAudioRendering_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.MuteAudioRendering = chkMuteAudioRendering.IsChecked == true;
        }

        private void cboAudioRenderers_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            VideoGrabber.AudioRenderer = cboAudioRenderers.SelectedIndex;
        }


        private void rdgVUMeter_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).IsChecked == true)
            {
                switch (Convert.ToInt32((sender as RadioButton).Tag))
                {
                    case 0:
                        VideoGrabber.VuMeter = VidGrab.TVuMeter.vu_Disabled;
                        VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, (IntPtr)0); // VU_LEFT = 0, VU_RIGHT = 1;
                        VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, (IntPtr)0);
                        break;
                    case 1:
                        VideoGrabber.VuMeter = VidGrab.TVuMeter.vu_Analog;

                        pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 4) / 3;
                        pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 4) / 3;

                        VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0); // VU_LEFT = 0, VU_RIGHT = 1
                        VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0);
                        //TODO VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterLeft.Handle); // VU_LEFT = 0, VU_RIGHT = 1
                        //TODO VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterRight.Handle);
                        break;
                    case 2:
                        VideoGrabber.VuMeter = VidGrab.TVuMeter.vu_Bargraph;

                        pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 2) / 10;
                        pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 2) / 10;

                        VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0x404040); // VU_LEFT = 0, VU_RIGHT = 1
                        VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0x404040);
                        //TODO VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterLeft.Handle); // VU_LEFT = 0, VU_RIGHT = 1
                        //TODO VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterRight.Handle);
                        break;
                }
            }
        }

        private void btnBargraphOverlay_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.SetVUMeterSetting(2, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr)10);
            VideoGrabber.SetVUMeterSetting(3, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr)140);
            for (uint i = 2; i <= 3; i++)
            {
                VideoGrabber.SetVuMeter_Enabled(Convert.ToInt32(i), VidGrab.TVuMeter.vu_BargraphOverlay);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_Transparent, (IntPtr)1);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayTop, (IntPtr)10);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayWidth, (IntPtr)100);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayHeight, (IntPtr)60);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0x800000);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_NormalColor, (IntPtr)0x000080);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningColor, (IntPtr)0x00A5FF);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakColor, (IntPtr)0x00FFFF);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningPercent, (IntPtr)20);
                VideoGrabber.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakPercent, (IntPtr)40);
            }
        }

        private void btnStartAudioRendering_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.StartAudioRendering();
            if (!VideoGrabber.AudioDeviceRendering)
            {
                if (btnStartAudioRendering.Tag == null)
                {
                    btnStartAudioRendering.Tag = 1; //' to show the popup only one time
                    MessageBox.Show("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers",
                                "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
                }
            }
        }

        private void btnStartWavRecording_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
            VideoGrabber.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
            VideoGrabber.StartAudioRecording();
        }

        private void btnSartMP3Recording_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
            VideoGrabber.CompressionType = VidGrab.TCompressionType.ct_Audio;
            VideoGrabber.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;

            VideoGrabber.AudioCompressor = VideoGrabber.FindIndexInListByName(VideoGrabber.AudioCompressors, "LAME Audio Encoder", false, true);
            if (VideoGrabber.AudioCompressor == -1)
            {
                MessageBox.Show("The LAME 3.99.5 DirectShow Filter is required, download it from https://www.rarewares.org/mp3-lame-dshow-acm.php and register lame.ax with regsvr32.exe",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButton.OK);
            }
            else
            {
                VideoGrabber.StartAudioRecording();
            }
        }

        private void btnStartWMVRecording_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
            VideoGrabber.RecordingMethod = VidGrab.TRecordingMethod.rm_ASF;
            VideoGrabber.StartAudioRecording();
        }

        private void btnStopAudio_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Stop();
        }

        private void chkUseAudioOfVideoCaptureDevice_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkUseAudioOfVideoCaptureDevice.IsChecked == true)
            {
                VideoGrabber.VideoDevice = 0; // in this demo, by default we choose the 1st
            }
            else
            {
                VideoGrabber.VideoDevice = -1; // this deactivates the video capture device
            }
        }

        private void Audio_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void tbrAudioInputLevel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.AudioInputLevel = (int)tbrAudioInputLevel.Value;
        }

        private void tbrAudioInputBalance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.AudioInputBalance = (int)tbrAudioInputBalance.Value;
        }

        private void tbrAudioVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.AudioVolume = (int)tbrAudioVolume.Value;
        }

        private void tbrAudioBalance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoGrabber.AudioBalance = (int)tbrAudioBalance.Value;
        }

        private void cboAudioDevices_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.AudioDevice = cboAudioDevices.SelectedIndex;
        }

        private void cboAudioInputs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.AudioInput = cboAudioInputs.SelectedIndex;
        }

        private void cboAudioRenderers_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGrabber.AudioRenderer = cboAudioRenderers.SelectedIndex;
        }
    }
}
