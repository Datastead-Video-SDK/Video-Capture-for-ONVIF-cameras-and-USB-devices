using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;


namespace MainDemo
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

        public static void SetRadioButtonInGroupUsingTag(System.Windows.Forms.Control FrameName, short Indx)
        {
            foreach (System.Windows.Forms.Control Ctrl in FrameName.Controls)
            {
                if (Ctrl.GetType() == typeof(System.Windows.Forms.RadioButton))
                {
                    if (Ctrl.Tag != null)
                    {
                        if (Ctrl.Tag.ToString() == Indx.ToString())
                        {
                            (Ctrl as System.Windows.Forms.RadioButton).Checked = true;
                        }
                    }
                }
            }
        }

        public static void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.AppendText(Environment.NewLine + Line);
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

        public static void LoadTextBox(System.Windows.Forms.ListBox Dest, string CRLFString)
        {
            Dest.Items.Clear();
            IList<string> ListItems = CRLFDelimitedStringToIList(CRLFString);
            foreach (string Item in ListItems)
            {
                Dest.Items.Add(Item);
            }
        }

        public static void AssignListToComboBox(System.Windows.Forms.ComboBox Dest, string CRLFString, int Indx)
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

        public static Bitmap CreateBitmapHandleFromPictureBox(System.Windows.Forms.PictureBox PbControl)
        {
            Bitmap bmp = new Bitmap(PbControl.ClientRectangle.Width, PbControl.ClientRectangle.Height);
            Graphics gMem = Graphics.FromImage(bmp);
            gMem.DrawImageUnscaled(PbControl.Image, new Point(0, 0));
            gMem.Dispose();
            return bmp;
        }

        private struct INSET_RECT
        {
            public int InSetLeft;
            public int InSetTop;
            public int InSetRight;
            public int InSetBottom;
        }

        public static IntPtr HWND_TOP = IntPtr.Zero;
        private const int WS_CHILD = 0X40000000;
        private const short GWL_HWNDPARENT = (-8);
        private const short GWL_STYLE = (-16);
        public const short SWP_NOSIZE = 0X1;
        public const short SWP_NOMOVE = 0X2;
        public const short SWP_NOACTIVATE = 0X10;
        public const short SWP_NOZORDER = 0X4;
        public const short SWP_SHOWWINDOW = 0X40;

        [System.Runtime.InteropServices.DllImport("USER32", EntryPoint = "GetClientRect", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int GetClientRect(IntPtr hwnd, ref INSET_RECT lpRect);
        [System.Runtime.InteropServices.DllImport("USER32", EntryPoint = "GetWindowLongA", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hwnd, int nIndex);
        [System.Runtime.InteropServices.DllImport("USER32", EntryPoint = "SetWindowLongA", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [System.Runtime.InteropServices.DllImport("USER32", EntryPoint = "GetParent", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int GetParent(IntPtr hwnd);
        [System.Runtime.InteropServices.DllImport("USER32", EntryPoint = "SetParent", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [System.Runtime.InteropServices.DllImport("USER32", EntryPoint = "SetWindowPos", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int X, int Y, int cX, int cY, int wFlags);
        private static INSET_RECT rctRect;

        public static void MakeTopWindow(IntPtr Hwnd)
        {
             SetWindowPos (Hwnd, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }


        public static void InsetForms (ref System.Windows.Forms.Form ChildForm, IntPtr InsetHWnd)
        {
            //Change style to child window, set ChildForm's parent, set parent hWnd
            int lngStyle = GetWindowLong(ChildForm.Handle, GWL_STYLE) | WS_CHILD;
            SetWindowLong(ChildForm.Handle, GWL_STYLE, lngStyle);
            SetParent(ChildForm.Handle, InsetHWnd);

            //Get dimensions of the inset area
            GetClientRect(InsetHWnd, ref rctRect);

            //Show the inset ChildForm
            SetWindowPos(ChildForm.Handle, HWND_TOP, 0, 0, rctRect.InSetRight, rctRect.InSetBottom, SWP_NOZORDER | SWP_NOACTIVATE | SWP_SHOWWINDOW);
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

