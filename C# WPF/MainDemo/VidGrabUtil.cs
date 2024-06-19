using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Controls;

using VidGrabWPF;

namespace MainDemoWPF
{
    public class Helpers
    {
        public const string AUDIO_CLIPS = "*.mp3;*.wav;*.wma;*.mid";
        public const string VIDEO_CLIPS = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.webm;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*";
        public const string IMAGE_FILES = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png";
        public const string OPEN_MEDIA_FILES = "All media files|" + VIDEO_CLIPS + AUDIO_CLIPS + IMAGE_FILES
                        + "|Video clips|" + VIDEO_CLIPS
                        + "|Audio clips|" + AUDIO_CLIPS;
        public const string OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                        + "|Image files|" + IMAGE_FILES;
        public const string OPEN_PICTURE_FILES = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg";
        public const string OPEN_PROFILES = "WMV9 profiles (*.prx)|*.prx";
        public const string OPEN_COMPRESSOR_SETTINGS = "Compressor saved settings (*.txt)|*.txt";

        public enum ShowCommands
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAP
        {
            public Int32 bmType;
            public Int32 bmWidth;
            public Int32 bmHeight;
            public Int32 bmWidthBytes;
            public Int16 bmPlanes;
            public Int16 bmBitsPixel;
            public IntPtr bmBits;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public Int16 biPlanes;
            public Int16 biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int bitClrImportant;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBTRIPLE
        {
            public byte rgbtBlue;
            public byte rgbtGreen;
            public byte rgbtRed;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DIBSECTION
        {
            public BITMAP dsBm;
            public BITMAPINFOHEADER dsBmih;
            public int dsBitField1;
            public int dsBitField2;
            public int dsBitField3;
            public IntPtr dshSection;
            public int dsOffset;
        }

        public const int SizeOf_DIBSECTION = 84;

        const int INVALID_HANDLE_VALUE = -1;

        [DllImport("gdi32")]
        public static extern int GetObject(IntPtr hObject, int nCount, IntPtr lpObject);

        [DllImport("gdi32")]
        public static extern int DeleteObject(IntPtr hObject);

        [DllImport("shell32.dll")]
        public static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        public static void SubForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        public static void SetRadioButtonInGroupUsingTag(System.Windows.Controls.Canvas Canvas, short Indx)
        {
            foreach (Object child in Canvas.Children)
            {
                if (child.GetType() == typeof (RadioButton))
                {
                    RadioButton rdb = (RadioButton) child;
                    if (rdb.TabIndex == Indx)
                    {
                        rdb.IsChecked = true;
                    }
                }
            }
        }

        public static void AddLog(TextBox TxtBox, string Line)
        {
            TxtBox.AppendText(Environment.NewLine + Line);
				TxtBox.ScrollToEnd();
        }

        static IList<string> CRLFDelimitedStringToIList(string CRLFString)
        {
            IList<string> list = new List<string>();

            if (! String.IsNullOrEmpty(CRLFString)) 
            {
                string[] lines = Regex.Split(CRLFString, "\r\n");
                foreach (string line in lines)
                {
                    list.Add(line);
                }
            }
            return list;
        }

        public static void LoadTextBox(System.Windows.Controls.ListBox Dest, string CRLFString)
        {
            Dest.Items.Clear();
            IList<string> ListItems = CRLFDelimitedStringToIList(CRLFString);
            foreach (string Item in ListItems)
            {
                Dest.Items.Add(Item);
            }
        }

        public static void AssignListToComboBox(System.Windows.Controls.ComboBox Dest, string CRLFString, int Indx)
        {
            Dest.Items.Clear();
            IList<string> ListItems = CRLFDelimitedStringToIList(CRLFString);
            foreach (string Item in ListItems)
            {
                Dest.Items.Add(Item);
            }
            if ((Indx >= 0) && (Indx < Dest.Items.Count))
            {
                Dest.SelectedIndex = Indx;
            }
            else
            {
                Dest.SelectedIndex = -1;
            }
        }

        public static bool IsNumeric(string numberString)
        {
            double Number;
            return double.TryParse(numberString, System.Globalization.NumberStyles.Any, null, out Number);
        }

        /*
        public static System.Drawing.Color ToSystemDrawingColor(System.Windows.Media.Brush color)
        {
            return System.Drawing.Color.FromArgb(color.Transform..A, color.R, color.G, color.B);
        }
         */

        public static Bitmap CreateBitmapHandleFromPictureBox(System.Windows.Controls.Image PbControl)
        {
            Bitmap bmp = new Bitmap((int) PbControl.Width, (int) PbControl.Height);
            Graphics gMem = Graphics.FromImage(bmp);
            //TADA gMem.DrawImageUnscaled(PbControl.Image, new Point(0, 0));
            gMem.Dispose();
            return bmp;
        }

    }

    public class VideoFromImagesFileList : ArrayList
    {
        private int m_CurrentIndex;
        private string m_CurrentFolder;
        private bool m_LoopIndefinitely;

        public VideoFromImagesFileList()
        {
            m_CurrentFolder = "";
            m_CurrentIndex = 0;
            m_LoopIndefinitely = false;
        }

        class FileSort : IComparer
        {
            public int Compare(object x, object y)
            {
                FileInfo d1 = x as FileInfo;
                FileInfo d2 = y as FileInfo;
                return d1.Name.CompareTo(d2.Name);
            }
        }

        public bool ReinitFolder(string Folder, string FileType, bool LoopIndefinitely)
        {
            m_CurrentFolder = Folder.Trim();
            if (m_CurrentFolder == "")
            {
                m_CurrentFolder = Directory.GetCurrentDirectory();
            }
            this.Clear();
            m_CurrentIndex = 0;
            DirectoryInfo di = new DirectoryInfo(m_CurrentFolder);
            if (di.Exists)
            {
                FileInfo[] fileInfoArray = di.GetFiles(FileType);
                Array.Sort(fileInfoArray, 0, fileInfoArray.Length, new FileSort());
                this.AddRange(fileInfoArray);
                return this.Count > 0;
            }
            else
            {
                return false;
            }
        }

        public string FirstImageFile()
        {
            m_CurrentIndex = 0;
            return NextImageFile();
        }

        public string NextImageFile()
        {
            string ImageFileFound;

            if (this.Count == 0)
            {
                return "";
            }
            else if ((m_CurrentIndex >= this.Count) && (!m_LoopIndefinitely))
            {
                m_CurrentIndex = 0;
            }
            ImageFileFound = m_CurrentFolder + "\\" + this[m_CurrentIndex++].ToString();
            return ImageFileFound;
        }


    }
}

