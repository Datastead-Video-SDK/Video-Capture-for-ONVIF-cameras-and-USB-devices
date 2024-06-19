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
using Microsoft.Win32;

using VidGrabWPF;
using VidGrab;

namespace MainDemoWPF
{
    /// <summary>
    /// Interaction logic for NetworkStreaming.xaml
    /// </summary>
    public partial class NetworkStreaming : Grid
    {

        private VideoGrabberWPF VideoGrabber;
        private int m_MultipurposeUDPStreamingID = -1;

        public NetworkStreaming(VideoGrabberWPF MainFormVideoGrabber)
        {
            InitializeComponent();
            VideoGrabber = MainFormVideoGrabber;
        }

        public void RefreshDisplayOptions()
        {
        }

        private void NetworkStreaming_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void btnNDIStreamingOK_Click(object sender, RoutedEventArgs e)
        {
            if ((chkVideoStreamingEnabled.IsChecked == true) && (chkVideoStreamingEnabled.IsChecked == true))
            {
                VideoGrabber.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            }
            else if (chkVideoStreamingEnabled.IsChecked == true)
            {
                VideoGrabber.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_VideoStreaming;
            }
            else if (chkAudioStreamingEnabled.IsChecked == true)
            {
                VideoGrabber.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioStreaming;
            }
            VideoGrabber.NDIName = edtNDISessionName.Text;
            VideoGrabber.NetworkStreaming = TNetworkStreaming.ns_NDI;
            Helpers.AddLog(MainForm.MainFormInstance.mmoLog, "NDI streaming enabled");
        }

        private void btnNDIStreamingClientView_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            VideoGrabber.VideoDevice = VideoGrabber.VideoDeviceIndex("NewTek NDI Video");
            if (VideoGrabber.VideoDevice >= 0)
            {
                // VideoGrabber.AudioDeviceRendering := true; /// enable if audio needed
                VideoGrabber.StartPreview();
            }
            else
            {
                Helpers.AddLog(MainForm.MainFormInstance.mmoLog, "Error: the NEWTEK NDI Runtime is not installed");
            }
        }

        private void btnEncoderPauseStreaming_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Encoder_Pause(m_MultipurposeUDPStreamingID);
        }

        private void btnEncoderResumeStreaming_Click(object sender, RoutedEventArgs e)
        {
            VideoGrabber.Encoder_Resume(m_MultipurposeUDPStreamingID);
        }

        private void btnUDPStreaming_Click(object sender, RoutedEventArgs e)
        {
            if (m_MultipurposeUDPStreamingID == -1)
            {
                m_MultipurposeUDPStreamingID = VideoGrabber.Encoders_CreateInstanceForStreaming("udp://239.255.0.1:10124");
            }
            if (m_MultipurposeUDPStreamingID > -1)
            {
                /// uncomment one of the lines below to use a specific codec, e.g.:
                //VideoGrabber.Encoder_SetStr (FMultipurposeUDPStreamingID, TEncoder_str.Enc_Video_Codec, "hevc");
                //VideoGrabber.Encoder_SetStr (FMultipurposeUDPStreamingID, TEncoder_str.Enc_Video_Codec, "h264");

                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_Enabled_bool, 1);
                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Audio_Enabled_bool, 1);
                if (chkVideoStreamingEnabled.IsChecked == false)
                {
                    VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_Enabled_bool, 0);
                }
                if (chkAudioStreamingEnabled.IsChecked == false)
                {
                    VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Audio_Enabled_bool, 0);
                }
                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_BitRate_kb, 2000);
                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_rc_MinBitRate_kb, 1800);
                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_rc_MaxBitRate_kb, 2200);
                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_IDR_Interval, 30);
                /// uncomment to enable the GPU encoder, if (available for h264 or hevc
                // VideoGrabber.Encoder_SetInt (FStreamingEncoderId, TEncoder_int.Enc_Video_GPU_Encoder, LongInt (TEncoder_int.Enc_GPU_Auto));  // or specify directly Enc_GPU_Intel_QSV, Enc_GPU_NVidia_NVENC or Enc_GPU_AMD_AMF
                VideoGrabber.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_IsActive_bool, 1);
            }

        }

        private void btnNDIView_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("select \"NewTek NDI Video\" in the \"video devices\" list and click \"Start Preview\"");
        }
    }
}
