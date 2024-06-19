using System.Windows.Forms;

namespace MainDemo
{
    partial class SnapForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SnapImage = new System.Windows.Forms.PictureBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SnapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SnapImage
            // 
            this.SnapImage.Location = new System.Drawing.Point(11, 12);
            this.SnapImage.Name = "SnapImage";
            this.SnapImage.Size = new System.Drawing.Size(288, 224);
            this.SnapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SnapImage.TabIndex = 1;
            this.SnapImage.TabStop = false;
            this.SnapImage.Resize += new System.EventHandler(this.SnapImage_Resize);
            // 
            // SnapForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(535, 317);
            this.Controls.Add(this.SnapImage);
            this.Name = "SnapForm";
            this.Text = "Captured frame";
            ((System.ComponentModel.ISupportInitialize)(this.SnapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        internal System.Windows.Forms.PictureBox SnapImage;
        private System.Windows.Forms.ToolTip ToolTip1;
    }
}

