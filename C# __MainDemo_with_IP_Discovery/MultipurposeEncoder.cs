using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VidGrab;

namespace MainDemo
{
    public partial class MultipurposeEncoder : Form
    {

        const int ENCODER_RECORDING_ID = 0; /// always use 0 for default encoder (used when invoking StartRecording())

        public MultipurposeEncoder()
        {
            InitializeComponent();
        }


        public void RefreshDisplayOptions()
        {
            tbxDatasteadEncoderInfo.Text = "To use this mode, in the \"recording\" tab, select:\r\n- \"Datastead Multipurpose Encoder\" as compressor\r\n- CompressionMode = cm_CompressOnTheFly\r\n\r\nThe format (e.g. mp4, avi, flv, etc...) is determined by the extension of the RecordingFileName, or by the RecordingMethod property if generated automatically.";
        }

        private void MultipurposeEncoder_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                RefreshDisplayOptions();
            }
        }

        private void edtMPERecording_TextChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetMultipurposeEncoderSettings(TMultipurposeEncoderInstance.mpe_Recording, edtMPERecording.Text);
        }

        private void edtMPEStreaming_TextChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetMultipurposeEncoderSettings(TMultipurposeEncoderInstance.mpe_Streaming, edtMPEStreaming.Text);
        }

        private void edtMPEReencoding_TextChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetMultipurposeEncoderSettings(TMultipurposeEncoderInstance.mpe_Reencoding, edtMPEReencoding.Text);
        }

        private void chkMPERecording_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.EnableMultipurposeEncoder(TMultipurposeEncoderInstance.mpe_Recording, chkMPERecording.Checked);
            edtMPERecording_TextChanged(edtMPERecording, e); // to apply the eventual default recording settings of the demo, if unchanged
        }

        private void chkMPEStreaming_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.EnableMultipurposeEncoder(TMultipurposeEncoderInstance.mpe_Streaming, chkMPEStreaming.Checked);
            edtMPEStreaming_TextChanged(edtMPEStreaming, e); // to apply the eventual default Streaming settings of the demo, if unchanged
        }

        private void btnStartMPEReencoding_Click(object sender, EventArgs e)
        {
            edtMPEStreaming_TextChanged(edtMPEReencoding, e); // to apply the eventual default Reencoding settings of the demo, if unchanged
            MainForm.cMainForm.VideoGrabber1.EnableMultipurposeEncoder(TMultipurposeEncoderInstance.mpe_Reencoding, true);
            MainForm.cMainForm.VideoGrabber1.StartReencoding();
        }

        private void btnStopMPEReencoding_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.Stop();
        }

        private void edtDatasteadEncoder_CodecName_TextChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.Encoder_SetStr(ENCODER_RECORDING_ID, TEncoder_str.Enc_Video_Codec, edtDatasteadEncoder_CodecName.Text);
        }

        private void edtDatasteadEncoder_Video_Bitrate_kb_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_Bitrate_kb.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_BitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_Bitrate_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Video_IDRInterval_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_IDRInterval.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_IDR_Interval, Convert.ToInt32(edtDatasteadEncoder_Video_IDRInterval.Text));
            }
        }

        private void edtDatasteadEncoder_Video_MaxBframes_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_MaxBframes.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_Max_BFrames, Convert.ToInt32(edtDatasteadEncoder_Video_MaxBframes.Text));
            }
        }

        private void edtDatasteadEncoder_Video_ThreadCount_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_ThreadCount.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_Thread_Count, Convert.ToInt32(edtDatasteadEncoder_Video_ThreadCount.Text));
            }
        }

        private void cmbGPUEncoder_SelectedIndexChanged(object sender, EventArgs e)
        {
               MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_GPU_Encoder, cmbGPUEncoder.SelectedIndex);
        }

        private void edtDatasteadEncoder_Video_rc_MinBitRate_kb_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_rc_MinBitRate_kb.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_rc_MinBitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_MinBitRate_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Video_rc_MaxBitRate_kb_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_rc_MaxBitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Video_rc_BufferSize_kb_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Video_rc_BufferSize_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Audio_SamplesPerSecond_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Audio_SamplesPerSecond.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Audio_SamplesPerSec, Convert.ToInt32(edtDatasteadEncoder_Audio_SamplesPerSecond.Text));
            }
        }

        private void edtDatasteadEncoder_Audio_BitRate_kb_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Audio_BitRate_kb.Text))
            {
                MainForm.cMainForm.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, TEncoder_int.Enc_Audio_BitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Audio_BitRate_kb.Text));
            }
        }

        private void mmoExtraParameters_TextChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.Encoder_SetStr(ENCODER_RECORDING_ID, TEncoder_str.Enc_Extra_Parameters, tbxExtraParameters.Text);
        }
    }

}
