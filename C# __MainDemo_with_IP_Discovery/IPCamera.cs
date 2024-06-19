using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using VidGrab;

namespace MainDemo
{
    public partial class IPCamera : Form
    {
        public IPCamera()
        {
            InitializeComponent();
        }


        public void RefreshDisplayOptions()
        {
            lblFirstSelectIPCamera.Visible = (MainForm.cMainForm.VideoGrabber1.VideoSource != TVideoSource.vs_IPCamera);
        }

        private void btnIPCamera_Click(object sender, System.EventArgs e)
        {
            Helpers.ShellExecute((System.IntPtr)0, "open", "http://www.datastead.com/demo/IPCam.htm", "", "", Helpers.ShowCommands.SW_SHOWNORMAL);
        }

        private void edtIPCameraURL_TextChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text;
        }

        private void edtIPCamUserName_TextChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetAuthentication(TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text);
        }

        private void edtIPCamPassword_TextChanged(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetAuthentication(TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text);
        }

        private void edtIPCamConnectionTimeout_TextChanged(object sender, System.EventArgs e)
        {
            if (Helpers.IsNumeric(edtIPCamConnectionTimeout.Text))
            {
                MainForm.cMainForm.VideoGrabber1.SetIPCameraSetting(TIPCameraSetting.ips_ConnectionTimeout, Convert.ToInt32(edtIPCamConnectionTimeout.Text));
            }
        }

        private void btnIPCamStartPreview_Click(object sender, System.EventArgs e)
        {
            MainForm.cMainForm.ChangeVideoSource(TVideoSource.vs_IPCamera);
            MainForm.cMainForm.VideoGrabber1.StartPreview();
        }

        private void btnIPCamStop_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.Stop();
        }

        public async Task<TOpenURLAsyncStatus> Wait4OpenURLAsyncSuccessOrFailure()
        {
            TOpenURLAsyncStatus OpenURLAsyncStatus = MainForm.cMainForm.VideoGrabber1.OpenURLAsyncStatus();
            while (OpenURLAsyncStatus < TOpenURLAsyncStatus.oas_Completed_Success)
            {
                await Task.Delay(50);
                OpenURLAsyncStatus = MainForm.cMainForm.VideoGrabber1.OpenURLAsyncStatus();
            }
            return OpenURLAsyncStatus;
        }

        private async void btnIPCamStartAsyncPreviewAndWait_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.ChangeVideoSource(TVideoSource.vs_IPCamera);
            MainForm.cMainForm.VideoGrabber1.StartPreview();
            if (MainForm.cMainForm.VideoGrabber1.OpenURLAsync)
            {
                TOpenURLAsyncStatus OpenResult = await Wait4OpenURLAsyncSuccessOrFailure();
                if (OpenResult == TOpenURLAsyncStatus.oas_Completed_Success)
                {
                    Helpers.AddLog(MainForm.cMainForm.mmoLog, "async connection succeeded");
                }
                else if (OpenResult == TOpenURLAsyncStatus.oas_Completed_Error)
                {
                    Helpers.AddLog(MainForm.cMainForm.mmoLog, "async connection failed");
                }
            }
        }

        private void chkUseExternalAudioforRTSP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseExternalAudioforRTSP.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = TAudioSource.as_UseExternalAudio;
            }
            else
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = TAudioSource.as_Default;
            }
        }

        private void btnIPCamStartMP4Recording_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.ChangeVideoSource(TVideoSource.vs_IPCamera);
            MainForm.cMainForm.frmRecording.rdgRecordingMethodMP4.Checked = true;

            if (chkBacktimedRecording.Checked)
            {
                int BacktimedRecordingDurationInSeconds;
                if (int.TryParse(txtBacktimedRecordingSeconds.Text, out BacktimedRecordingDurationInSeconds)) {
                    if (BacktimedRecordingDurationInSeconds > 0)
                    {
                        // to activate a pre-roll of 5 seconds on the RTSP filter add ">backtimed=5" at the end of the RTSP URL
                        MainForm.cMainForm.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text + ">backtimed=" + BacktimedRecordingDurationInSeconds.ToString();
                        MainForm.cMainForm.VideoGrabber1.HoldRecording = true; // to start the recording in "preview mode", ready to start the recording when MainForm.cMainForm.VideoGrabber1.ResumeRecording will be invoked
                    }
                }
            }
           
            MainForm.cMainForm.VideoGrabber1.StartRecording();

        }

        private void chkOpenURLAsync_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.OpenURLAsync = chkOpenURLAsync.Checked;
        }

        private void IPCamera_VisibleChanged(object sender, System.EventArgs e)
        {
            if (Visible)
            {
                RefreshDisplayOptions();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        double m_PTZSpeedRatio = 1;
        bool m_UpdatingPTZTrackbars = false;
        int m_PTZMoveDurationMs = 300;
        double m_PTZRelativeMove = 0.01;

        private void tbrPTZSpeedRatio_Scroll(object sender, EventArgs e)
        {
            m_PTZSpeedRatio = Convert.ToDouble(tbrPTZSpeedRatio.Value) / 100;
        }

        private void edtPTZDurationMs_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(edtPTZDurationMs.Text, out m_PTZMoveDurationMs);
        }

        private void StartContinousPTZMove(string PTZType, bool OppositeDirection)
        {
            if (MainForm.cMainForm.VideoGrabber1.ONVIFPTZStartMove(PTZType, OppositeDirection, m_PTZSpeedRatio, m_PTZMoveDurationMs))
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "continuous move started");
            }
            else
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "PTZ move command failed, verify that this camera supports ONVIF and start the camera with an \"ONVIF://user:password@IPADDRESS\" URL syntax");
            }
        }
        private void StopContinousPTZMove()
        {
            MainForm.cMainForm.VideoGrabber1.ONVIFPTZStopMove("Pan");
            MainForm.cMainForm.VideoGrabber1.ONVIFPTZStopMove("Tilt");
            MainForm.cMainForm.VideoGrabber1.ONVIFPTZStopMove("Zoom");
        }

        private void btnPTZStop_Click(object sender, EventArgs e)
        {
            StopContinousPTZMove();
        }

        private void ContinuousPTZButtons_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkStopOnRelease.Checked)
            {
                StopContinousPTZMove();
            }
        }

        public static class PTZTypes
        {
            public static string Pan = "Pan";
            public static string Tilt = "Tilt";
            public static string Zoom = "Zoom";
        }
        private void ContinuousPtzTiltUp_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinousPTZMove(PTZTypes.Tilt, false);
        }

        private void ContinuousPtzTiltDown_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinousPTZMove(PTZTypes.Tilt, true);
        }

        private void ContinuousPtzPanLeft_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinousPTZMove(PTZTypes.Pan, false);
        }

        private void ContinuousPtzPanRight_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinousPTZMove(PTZTypes.Pan, true);
        }

        private void ContinuousPtzZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinousPTZMove(PTZTypes.Zoom, false);
        }

        private void ContinuousPtzZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinousPTZMove(PTZTypes.Zoom, true);
        }

        void DoPTZAbsolute()
        {
            if (!m_UpdatingPTZTrackbars)
            {
                // let's divide by 100, the trackbars are in the 0..100 range, and the PTZ values must be in the 0.0 ... 1.0 range
                double dPan = Convert.ToDouble(tbrAbsolutePTZPan.Value) / 100;
                double dTilt = Convert.ToDouble(tbrAbsolutePTZTilt.Value) / 100;
                double dZoom = Convert.ToDouble(tbrAbsolutePTZZoom.Value) / 100;

                if (MainForm.cMainForm.VideoGrabber1.ONVIFPTZSetPosition(dPan, dTilt, dZoom, m_PTZSpeedRatio, false))
                {
                    Helpers.AddLog(MainForm.cMainForm.mmoLog, "absolute PTZ move Ok");
                }
                else
                {
                    Helpers.AddLog(MainForm.cMainForm.mmoLog, "absolute PTZ move command failed, verify that this camera supports ONVIF and has the absolute PTZ feature.  The camera must be started with an \"ONVIF://user:password@IPADDRESS\" URL syntax");
                }
            }
        }

        private void DoPTZRelative(double dPan, double dTilt, double dZoom)
        {
            if (MainForm.cMainForm.VideoGrabber1.ONVIFPTZSetPosition(dPan, dTilt, dZoom, m_PTZSpeedRatio, true))
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "relative PTZ move Ok");
            }
            else
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "relative PTZ move command failed, verify that this camera supports ONVIF and has the absolute PTZ feature.  The camera must be started with an \"ONVIF://user:password@IPADDRESS\" URL syntax");
            }
        }

        private void tbrAbsolutePTZ_MouseUp(object sender, MouseEventArgs e)
        {
            DoPTZAbsolute();
        }

        private void btnPTZActualiseTrackbars_Click(object sender, EventArgs e)
        {
            double dPan_Min, dPan_Max;
            double dTilt_Min, dTilt_Max;
            double dZoom_Min, dZoom_Max;

            if (MainForm.cMainForm.VideoGrabber1.ONVIFPTZGetLimits (out dPan_Min, out dPan_Max, out dTilt_Min, out dTilt_Max, out dZoom_Min, out dZoom_Max))
            {
                // let's multiply by 100, the trackbars are in the 0..100 range, and the PTZ values must be in the 0.0 ... 1.0 range

                tbrAbsolutePTZPan.Minimum = Convert.ToInt32(dPan_Min * 100.0);
                tbrAbsolutePTZPan.Maximum = Convert.ToInt32(dPan_Max * 100.0);
                tbrAbsolutePTZTilt.Minimum = Convert.ToInt32(dTilt_Min * 100.0);
                tbrAbsolutePTZTilt.Maximum = Convert.ToInt32(dTilt_Max * 100.0);
                tbrAbsolutePTZZoom.Minimum = Convert.ToInt32(dZoom_Min * 100.0);
                tbrAbsolutePTZZoom.Maximum = Convert.ToInt32(dZoom_Max * 100.0);
                tbrPTZSpeedRatio.Minimum = 0;
                tbrPTZSpeedRatio.Maximum = 100;
                tbrPTZSpeedRatio.Value = Convert.ToInt32(m_PTZSpeedRatio * 100.0);

                double dPan, dTilt, dZoom;
                long UTCTime;
                int IsMoving;

                if (MainForm.cMainForm.VideoGrabber1.ONVIFPTZGetPosition (out dPan, out dTilt, out dZoom, out UTCTime, out IsMoving)) 
                {
                    m_UpdatingPTZTrackbars = true;
                    tbrAbsolutePTZPan.Value = Convert.ToInt32(dPan * 100.0);
                    tbrAbsolutePTZTilt.Value = Convert.ToInt32(dTilt * 100.0);
                    tbrAbsolutePTZZoom.Value = Convert.ToInt32(dZoom * 100.0);
                    m_UpdatingPTZTrackbars = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The \"PTZ speed adjustment\" and \"absolute PTZ move\" capabilities are not supported by all the brands/models of ONVIF cameras");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Duration of the motion expressed in milliseconds.\n0 = continuous move\n\nNote: some cameras may not support a motion duration and move continuously even if a duration is specified.\n In this case invoke StartMove(), wait the desired duration with a timer then invoke StopMove()");
        }

        private void txtPTZRelativeMove_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtPTZRelativeMove.Text, out m_PTZRelativeMove);
        }

        private void btnRelativePTZTiltUp_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, m_PTZRelativeMove, 0);
        }

        private void btnRelativePTZTiltDown_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, -m_PTZRelativeMove, 0);
        }

        private void btnRelativePTZPanLeft_Click(object sender, EventArgs e)
        {
            DoPTZRelative(m_PTZRelativeMove, 0, 0);
        }

        private void btnRelativePTZPanRight_Click(object sender, EventArgs e)
        {
            DoPTZRelative(-m_PTZRelativeMove, 0, 0);
        }

        private void btnRelativePTZZoomOut_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, 0, -m_PTZRelativeMove);
        }

        private void btnRelativePTZZoomIn_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, 0, m_PTZRelativeMove);
        }

        private void rdbIrCutFilterAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIrCutFilterAuto.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.ONVIF_SetStr("RTSP_Source_Axis_IrCutFilter_str", "auto");
            }
        }

        private void rdbIrCutFilterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIrCutFilterEnabled.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.ONVIF_SetStr("RTSP_Source_Axis_IrCutFilter_str", "enabled");
            }
        }

        private void rdbIrCutFilterDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIrCutFilterDisabled.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.ONVIF_SetStr("RTSP_Source_Axis_IrCutFilter_str", "disabled");
            }
        }

        private void btnMulticastDiscovery_Click(object sender, EventArgs e)
        {
            lbxCamerasDiscovered.Items.Clear();

            if (MainForm.cMainForm.VideoGrabber1.ONVIFDiscoverCameras_Multicast(Int32.Parse(tbxDiscoveryTimeoutSec.Text))) {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "ONVIF discovery from multicast in progress...");
            }
            else
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "failed to start ONVIF discovery from multicast");
            }
        }
        private void btnIPRangeDiscovery_Click(object sender, EventArgs e)
        {
            lbxCamerasDiscovered.Items.Clear();
                
            if (MainForm.cMainForm.VideoGrabber1.ONVIFDiscoverCameras_IPRange(txbIPRange_FirstIP.Text, txbIPRange_LastIP.Text, Int32.Parse(tbxDiscoveryTimeoutSec.Text)))
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "ONVIF discovery from IP range in progress...");
            }
            else
            {
                Helpers.AddLog(MainForm.cMainForm.mmoLog, "failed to start ONVIF discovery from IP range");
            }
        }
    }
}

