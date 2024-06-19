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
    /// Interaction logic for MultipurposeEncoder.xaml
    /// </summary>
    public partial class MultipurposeEncoder : Grid
    {
        private VideoGrabberWPF VideoGrabber;

        private const int ENCODER_RECORDING_ID = 0;

        public MultipurposeEncoder(VideoGrabberWPF MainFormVideoGrabber)
        {
            VideoGrabber = MainFormVideoGrabber;
            InitializeComponent();
        }

        public void RefreshDisplayOptions()
        {
            tbxDatasteadEncoderInfo.Text = "To use this mode, in the \"recording\" tab, select:\r\n- \"Datastead Multipurpose Encoder\" as compressor\r\n- CompressionMode = cm_CompressOnTheFly\r\n\r\nThe format (e.g. mp4, avi, flv, etc...) is determined by the extension of the RecordingFileName, or by the RecordingMethod property if RecordingFileName is empty";
        }

        private void MultipurposeEncoder_VisibleChanged(object sender, RoutedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshDisplayOptions();
            }
        }

        private void edtDatasteadEncoder_CodecName_TextChanged(object sender, TextChangedEventArgs e)
        {
            VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, VidGrab.TEncoder_str.Enc_Video_Codec, edtDatasteadEncoder_CodecName.Text);
        }

        private void edtDatasteadEncoder_Video_Bitrate_kb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_Bitrate_kb.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_BitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_Bitrate_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Video_IDRInterval_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_IDRInterval.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_IDR_Interval, Convert.ToInt32(edtDatasteadEncoder_Video_IDRInterval.Text));
            }
        }

        private void edtDatasteadEncoder_Video_MaxBframes_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_MaxBframes.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_Max_BFrames, Convert.ToInt32(edtDatasteadEncoder_Video_MaxBframes.Text));
            }
        }

        private void edtDatasteadEncoder_Video_ThreadCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_ThreadCount.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_Thread_Count, Convert.ToInt32(edtDatasteadEncoder_Video_ThreadCount.Text));
            }
        }

        private void edtDatasteadEncoder_Video_rc_MinBitrate_kb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_rc_MinBitrate_kb.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_rc_MinBitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_MinBitrate_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Video_rc_MaxBitrate_kb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_rc_MaxBitrate_kb.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_rc_MaxBitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_MaxBitrate_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Video_rc_BufferSize_kb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_rc_BufferSize_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text));
            }
        }

        private void edtDatasteadEncoder_Audio_SamplesPerSecond_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Audio_SamplesPerSecond.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Audio_SamplesPerSec, Convert.ToInt32(edtDatasteadEncoder_Audio_SamplesPerSecond.Text));
            }
        }

        private void edtDatasteadEncoder_Audio_BitRate_kb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Helpers.IsNumeric(edtDatasteadEncoder_Audio_BitRate_kb.Text))
            {
                VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Audio_BitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Audio_BitRate_kb.Text));
            }
        }

        private void tbxExtraParameters_TextChanged(object sender, TextChangedEventArgs e)
        {
            VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, VidGrab.TEncoder_str.Enc_Extra_Parameters, tbxExtraParameters.Text);
        }

    }
}
