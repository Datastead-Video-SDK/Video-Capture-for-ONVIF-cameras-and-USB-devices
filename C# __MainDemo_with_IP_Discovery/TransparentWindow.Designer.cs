using System.Windows.Forms;

namespace MainDemo
{
    partial class TransparentWindow : Form
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
            this.TransparentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransparentLabel
            // 
            this.TransparentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparentLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransparentLabel.Location = new System.Drawing.Point(12, 77);
            this.TransparentLabel.Name = "TransparentLabel";
            this.TransparentLabel.Size = new System.Drawing.Size(482, 62);
            this.TransparentLabel.TabIndex = 2;
            this.TransparentLabel.Text = "transparent window";
            this.TransparentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TransparentWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(505, 197);
            this.Controls.Add(this.TransparentLabel);
            this.Name = "TransparentWindow";
            this.Text = "transparent window";
            this.ResumeLayout(false);

        }
        #endregion

        internal System.Windows.Forms.Label TransparentLabel;
    }
}

