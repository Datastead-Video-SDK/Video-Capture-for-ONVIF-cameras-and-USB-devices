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
    /// Interaction logic for SnapForm.xaml
    /// </summary>
    public partial class SnapForm : Window
    {
        public SnapForm()
        {
            InitializeComponent();
        }

        private void SnapImage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Width = SnapImage.Width + 25;
            this.Height = SnapImage.Height + 40;
        }
    }
}
