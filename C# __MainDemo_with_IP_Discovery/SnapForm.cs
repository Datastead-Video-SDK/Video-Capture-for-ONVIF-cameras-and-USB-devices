using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class SnapForm : Form
	{
       
		public SnapForm()
		{
			InitializeComponent();
		}

		private void SnapImage_Resize(object sender, System.EventArgs e)
		{
			this.Width = SnapImage.Width + 25;
			this.Height = SnapImage.Height + 40;
		}

	}
}
