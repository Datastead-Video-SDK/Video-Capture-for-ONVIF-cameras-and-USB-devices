using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VidGrab;

namespace MainDemo
{
    public partial class NetworkStreaming : Form
    {

        public NetworkStreaming()
        {
            InitializeComponent();
        }

        private void NetworkStreaming_Load(object sender, System.EventArgs e)
        {

        }

        public void RefreshDisplayOptions()
        {
        }

        private void NetworkStreaming_VisibleChanged(object sender, System.EventArgs e)
        {
            if (Visible)
            {
                RefreshDisplayOptions();
            }
        }

        private void btnNDIClientHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("select \"NewTek NDI Video\" in the \"video devices\" list and click \"Start Preview\"");
        }

        private void btnNDIStreamingClientView_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            MainForm.cMainForm.VideoGrabber1.VideoDevice = MainForm.cMainForm.VideoGrabber1.VideoDeviceIndex("NewTek NDI Video");
            if (MainForm.cMainForm.VideoGrabber1.VideoDevice >= 0)
            {
                // MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering := true; /// enable if audio needed
                MainForm.cMainForm.VideoGrabber1.StartPreview();
            }
            else
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "Error: the NEWTEK NDI Runtime is not installed");
            }
        }

        private void btnNDIStreamingOK_Click(object sender, EventArgs e)
        {
            if (chkVideoStreamingEnabled.Checked && chkVideoStreamingEnabled.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            }
            else if (chkVideoStreamingEnabled.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_VideoStreaming;
            }
            else if (chkAudioStreamingEnabled.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioStreaming;
            }
            MainForm.cMainForm.VideoGrabber1.NDIName = edtNDISessionName.Text;
            MainForm.cMainForm.VideoGrabber1.NetworkStreaming = TNetworkStreaming.ns_NDI;
            Helpers.AddLog(MainForm.cMainForm.mmoLog, "NDI streaming enabled");
        }

        private void btnPauseStreaming_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.Encoder_Pause(m_MultipurposeUDPStreamingID);
        }

        private void btnResumeStreaming_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.Encoder_Resume(m_MultipurposeUDPStreamingID);
        }

        private void btnMultipurposeUDPStreaming_Click(object sender, EventArgs e)
        {
            if (m_MultipurposeUDPStreamingID == -1)
            {
            m_MultipurposeUDPStreamingID = MainForm.cMainForm.VideoGrabber1.Encoders_CreateInstanceForStreaming("udp://239.255.0.1:10124");
            }
            if (m_MultipurposeUDPStreamingID > -1)
            {
                /// uncomment one of the lines below to use a specific codec, e.g.:
                //MainForm.cMainForm.VideoGrabber1.Encoder_SetStr (FMultipurposeUDPStreamingID, TEncoder_str.Enc_Video_Codec, "hevc");
                //MainForm.cMainForm.VideoGrabber1.Encoder_SetStr (FMultipurposeUDPStreamingID, TEncoder_str.Enc_Video_Codec, "h264");

                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_Enabled_bool, 1);
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Audio_Enabled_bool, 1);
                if (! chkVideoStreamingEnabled.Checked ) {
                    MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_Enabled_bool, 0);
                }
                if (!chkAudioStreamingEnabled.Checked ) {
                    MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Audio_Enabled_bool, 0);
                }
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_BitRate_kb, 2000);
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_rc_MinBitRate_kb, 1800);
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_rc_MaxBitRate_kb, 2200);
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_Video_IDR_Interval, 30);
                /// uncomment to enable the GPU encoder, if (available for h264 or hevc
                // MainForm.cMainForm.VideoGrabber1.Encoder_SetInt (FStreamingEncoderId, TEncoder_int.Enc_Video_GPU_Encoder, LongInt (TEncoder_int.Enc_GPU_Auto));  // or specify directly Enc_GPU_Intel_QSV, Enc_GPU_NVidia_NVENC or Enc_GPU_AMD_AMF
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, TEncoder_int.Enc_IsActive_bool, 1);
            }
        }
    }
}
