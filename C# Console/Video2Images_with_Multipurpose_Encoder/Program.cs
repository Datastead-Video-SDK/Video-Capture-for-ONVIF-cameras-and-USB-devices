using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidGrabNoForm;

namespace Video2Images
{
    // this demo can extract all the video frames from a clip to images .jpg, .png, .bmp or .tiff
    // the output is as follows, e.g.:
    // frame_000001.jpg
    // frame_000002.jpg
    // frame_000003.jpg
    // frame_000004.jpg
    // frame_000005.jpg
    // etc...
    class Program
    {
        private static void Vg_OnLog(object sender, TOnLogEventArgs e)
        {
            Console.WriteLine(e.severity.ToString() + ": " + e.infoMsg);
        }
        static void Main(string[] args)
        {
            VideoGrabber vg = new VideoGrabber();
            vg.OnLog += Vg_OnLog;

            string SourceFileName = @"c:\videos\SourceClip.mp4";

            //Int64 StartTime = 150000000; // e.g. to start at 15 seconds. The time is expressed in 100ns units, 1 second = 10000000

			// if you have installed the Multipurpose Encoder with the .exe installer, the line below is not required
            vg.ExtraDLLPath = @"C:\Multipurpose\package.ffmpeg\Evaluation"; // specify the folder where are located the "x86" and "x64" sub-folders containing the binaries of the Multipurpose Encoder

            Console.WriteLine("opening " + SourceFileName);
            if (vg.MPEDemuxer_Open(SourceFileName))
            {

                //if (vg.MPEDemuxer_SeekToTime_100ns(StartTime)) // to start at the specified time
                {
                    Console.WriteLine("opened " + SourceFileName);
                    int FrameCounter = 0;
                    bool Done = false;
                    while (!Done)
                    {
                        if (Console.KeyAvailable)
                        {
                            Done = true;
                        }
                        else
                        {
                            string ImageFileName = "frame_" + FrameCounter.ToString().PadLeft(6, '0') + ".jpg";

                            Int64 ImageTime100ns;
                            if (vg.MPEDemuxer_GetFrameAsFile(true, ImageFileName, out ImageTime100ns)) {

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                TimeSpan ts = TimeSpan.FromMilliseconds(ImageTime100ns / 10000);
                                Console.WriteLine(ImageFileName + " -> " + ts.ToString(@"hh\:mm\:ss\:fff"));
                                FrameCounter++;
                            }
                            else
                            {
                                Done = true;
                                Console.ResetColor();
                                Console.WriteLine("last frame reached");
                            }

                        }
                    }
                }
                vg.MPEDemuxer_Close();
            }

        }
    }
}
