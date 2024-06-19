using System;
using System.Text;

namespace ConsoleApplicationWithoutForms
{
    class Program
    {
        static private VidGrabNoForm.VideoGrabber vg = null;
        static private bool frame_captured = false;
        static void ContinueUntilKeyPressedOrInactive()
        {
            while ((!Console.KeyAvailable) && (!frame_captured))
            {
                vg.ContinueProcessing();
            }
        }
        static void Main(string[] args)
        {
            vg = new VidGrabNoForm.VideoGrabber();
            vg.OnFirstFrameReceived += VideoGrabber_OnFirstFrameReceived;
            //vg.PlayerFileName = "... specify the file name of the video clip
            if (vg.OpenPlayer())
            {
                Console.WriteLine("capturing...");
                ContinueUntilKeyPressedOrInactive();
            }
            else
            {
                Console.WriteLine("failed to open the clip");
            }
            vg.ClosePlayer();
            vg.Dispose();
            Console.WriteLine("process completed, press a key to exit");
            Console.ReadKey();
        }

        static private void VideoGrabber_OnFirstFrameReceived(object sender, EventArgs e)
        {
            vg.CaptureFrameSyncTo(VidGrabNoForm.TFrameCaptureDest.fc_JpegFile, @"captured.jpg");
            frame_captured = true;
            Console.WriteLine("captured.");
        }
    }
}

