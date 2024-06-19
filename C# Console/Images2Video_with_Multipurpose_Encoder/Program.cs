using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VidGrabNoForm;

namespace Images2Video
{
    class Program
    {
        static VideoGrabber vg;
        private static void Vg_OnLog(object sender, TOnLogEventArgs e)
        {
            Console.WriteLine(e.severity.ToString() + ": " + e.infoMsg);
        }

        private static void Vg_OnReencodingStarted(object sender, TOnSourceFileToDestFileStartedEventArgs e)
        {
            Console.WriteLine("reencoding " + e.sourceFile + " to " + e.destFile);
        }
        private static void Vg_OnReencodingProgress(object sender, TOnProgressEventArgs e)
        {
            Console.WriteLine(vg.MultipurposeEncoder_GetLastLog(TMultipurposeEncoderInstance.mpe_Reencoding));
        }

        private static void Vg_OnReencodingCompleted(object sender, TOnSourceFileToDestFileCompletedEventArgs e)
        {
            if (e.success)
            {
                Console.WriteLine(e.destFile + " successfully created.");
            }
            else
            {
                Console.WriteLine("error: failed to create " + e.destFile);
            }
        }

        static void Main(string[] args)
        {
            vg = new VideoGrabber();

            vg.OnLog += Vg_OnLog;
            vg.OnReencodingStarted += Vg_OnReencodingStarted;
            vg.OnReencodingProgress += Vg_OnReencodingProgress;
            vg.OnReencodingCompleted += Vg_OnReencodingCompleted;

            // if you have installed the Multipurpose Encoder with the .exe installer, the line below is not required
            vg.ExtraDLLPath = @"C:\Multipurpose\package.ffmpeg\Evaluation"; // specify the folder where are located the "x86" and "x64" sub-folders containing the binaries of the Multipurpose Encoder

            string SourceFolder = @"i:\folder_containing_the_jpeg_images\";

            vg.Reencoding_SourceVideoClip = "frame_%06d.jpg"; /// numeric format of the frames, 6 digits with left-padded zeros, e.g. frame_000001.jpg, frame_000002.jpg, etc...
            int FrameRate = 60;
            int BitRate_Kbps = 8000;

            vg.Reencoding_NewVideoClip = "VideoBuilt.mp4";

            // ffmpeg -r 1/5 -i img%03d.png -c:v libx264 -vf fps=25 -pix_fmt yuv420p out.mp4
            string CommandLine = "FFmpegLGPL.exe -i ";
            CommandLine = CommandLine + SourceFolder;
            CommandLine = CommandLine + vg.Reencoding_SourceVideoClip;
            CommandLine = CommandLine + " -c:v h264";
            CommandLine = CommandLine + " -b:v " + BitRate_Kbps.ToString() + "k";
            CommandLine = CommandLine + " -vf fps=" + FrameRate.ToString();
            CommandLine = CommandLine + " ";
            CommandLine = CommandLine + vg.Reencoding_NewVideoClip;
            vg.EnableMultipurposeEncoder(TMultipurposeEncoderInstance.mpe_Reencoding, true);
            vg.SetMultipurposeEncoderSettings(TMultipurposeEncoderInstance.mpe_Reencoding, CommandLine);

            Console.WriteLine("starting reencoding to " + vg.Reencoding_SourceVideoClip);

            vg.StartReencoding();
            Console.WriteLine("reencoding started");
            bool Done = false;
            while (! Done)
            {
                if (Console.KeyAvailable)
                {
                    Done = true;
                }
                else
                {
                    Thread.Sleep(100); 
                }
            }
        }
    }
}
