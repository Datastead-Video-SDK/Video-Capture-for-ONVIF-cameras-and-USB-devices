using System.Windows.Forms;

namespace MainDemo
{
    partial class miscVideoQuality : Form
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
            this.Label8 = new System.Windows.Forms.Label();
            this.chkGain = new System.Windows.Forms.CheckBox();
            this.btnGain = new System.Windows.Forms.Button();
            this.tbrGain = new System.Windows.Forms.TrackBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkWhiteBalance = new System.Windows.Forms.CheckBox();
            this.chkGamma = new System.Windows.Forms.CheckBox();
            this.chkSharpness = new System.Windows.Forms.CheckBox();
            this.chkSaturation = new System.Windows.Forms.CheckBox();
            this.chkHue = new System.Windows.Forms.CheckBox();
            this.chkContrast = new System.Windows.Forms.CheckBox();
            this.chkBrightness = new System.Windows.Forms.CheckBox();
            this.btnWhiteBalance = new System.Windows.Forms.Button();
            this.btnGamma = new System.Windows.Forms.Button();
            this.btnSharpness = new System.Windows.Forms.Button();
            this.btnSaturation = new System.Windows.Forms.Button();
            this.btnHue = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbrContrast = new System.Windows.Forms.TrackBar();
            this.tbrSaturation = new System.Windows.Forms.TrackBar();
            this.tbrHue = new System.Windows.Forms.TrackBar();
            this.tbrWhiteBalance = new System.Windows.Forms.TrackBar();
            this.tbrSharpness = new System.Windows.Forms.TrackBar();
            this.tbrGamma = new System.Windows.Forms.TrackBar();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrWhiteBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(594, 12);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(38, 20);
            this.Label8.TabIndex = 66;
            this.Label8.Text = "gain";
            // 
            // chkGain
            // 
            this.chkGain.Location = new System.Drawing.Point(582, 369);
            this.chkGain.Name = "chkGain";
            this.chkGain.Size = new System.Drawing.Size(68, 24);
            this.chkGain.TabIndex = 65;
            this.chkGain.Tag = "7";
            this.chkGain.Text = "auto";
            // 
            // btnGain
            // 
            this.btnGain.Location = new System.Drawing.Point(582, 332);
            this.btnGain.Name = "btnGain";
            this.btnGain.Size = new System.Drawing.Size(80, 29);
            this.btnGain.TabIndex = 64;
            this.btnGain.Tag = "7";
            this.btnGain.Text = "default";
            // 
            // tbrGain
            // 
            this.tbrGain.Location = new System.Drawing.Point(582, 37);
            this.tbrGain.Name = "tbrGain";
            this.tbrGain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrGain.Size = new System.Drawing.Size(56, 283);
            this.tbrGain.TabIndex = 63;
            this.tbrGain.Tag = "9";
            this.tbrGain.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 37);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkWhiteBalance
            // 
            this.chkWhiteBalance.Location = new System.Drawing.Point(504, 369);
            this.chkWhiteBalance.Name = "chkWhiteBalance";
            this.chkWhiteBalance.Size = new System.Drawing.Size(68, 24);
            this.chkWhiteBalance.TabIndex = 61;
            this.chkWhiteBalance.Tag = "6";
            this.chkWhiteBalance.Text = "auto";
            // 
            // chkGamma
            // 
            this.chkGamma.Location = new System.Drawing.Point(426, 369);
            this.chkGamma.Name = "chkGamma";
            this.chkGamma.Size = new System.Drawing.Size(71, 24);
            this.chkGamma.TabIndex = 60;
            this.chkGamma.Tag = "5";
            this.chkGamma.Text = "auto";
            // 
            // chkSharpness
            // 
            this.chkSharpness.Location = new System.Drawing.Point(348, 369);
            this.chkSharpness.Name = "chkSharpness";
            this.chkSharpness.Size = new System.Drawing.Size(74, 24);
            this.chkSharpness.TabIndex = 59;
            this.chkSharpness.Tag = "4";
            this.chkSharpness.Text = "auto";
            // 
            // chkSaturation
            // 
            this.chkSaturation.Location = new System.Drawing.Point(268, 369);
            this.chkSaturation.Name = "chkSaturation";
            this.chkSaturation.Size = new System.Drawing.Size(68, 24);
            this.chkSaturation.TabIndex = 58;
            this.chkSaturation.Tag = "3";
            this.chkSaturation.Text = "auto";
            // 
            // chkHue
            // 
            this.chkHue.Location = new System.Drawing.Point(190, 369);
            this.chkHue.Name = "chkHue";
            this.chkHue.Size = new System.Drawing.Size(68, 24);
            this.chkHue.TabIndex = 57;
            this.chkHue.Tag = "2";
            this.chkHue.Text = "auto";
            // 
            // chkContrast
            // 
            this.chkContrast.Location = new System.Drawing.Point(112, 369);
            this.chkContrast.Name = "chkContrast";
            this.chkContrast.Size = new System.Drawing.Size(68, 24);
            this.chkContrast.TabIndex = 56;
            this.chkContrast.Tag = "1";
            this.chkContrast.Text = "auto";
            // 
            // chkBrightness
            // 
            this.chkBrightness.Location = new System.Drawing.Point(34, 369);
            this.chkBrightness.Name = "chkBrightness";
            this.chkBrightness.Size = new System.Drawing.Size(71, 24);
            this.chkBrightness.TabIndex = 55;
            this.chkBrightness.Tag = "0";
            this.chkBrightness.Text = "auto";
            // 
            // btnWhiteBalance
            // 
            this.btnWhiteBalance.Location = new System.Drawing.Point(504, 332);
            this.btnWhiteBalance.Name = "btnWhiteBalance";
            this.btnWhiteBalance.Size = new System.Drawing.Size(79, 29);
            this.btnWhiteBalance.TabIndex = 54;
            this.btnWhiteBalance.Tag = "6";
            this.btnWhiteBalance.Text = "default";
            // 
            // btnGamma
            // 
            this.btnGamma.Location = new System.Drawing.Point(426, 332);
            this.btnGamma.Name = "btnGamma";
            this.btnGamma.Size = new System.Drawing.Size(78, 29);
            this.btnGamma.TabIndex = 53;
            this.btnGamma.Tag = "5";
            this.btnGamma.Text = "default";
            // 
            // btnSharpness
            // 
            this.btnSharpness.Location = new System.Drawing.Point(348, 332);
            this.btnSharpness.Name = "btnSharpness";
            this.btnSharpness.Size = new System.Drawing.Size(78, 29);
            this.btnSharpness.TabIndex = 52;
            this.btnSharpness.Tag = "4";
            this.btnSharpness.Text = "default";
            // 
            // btnSaturation
            // 
            this.btnSaturation.Location = new System.Drawing.Point(268, 332);
            this.btnSaturation.Name = "btnSaturation";
            this.btnSaturation.Size = new System.Drawing.Size(80, 29);
            this.btnSaturation.TabIndex = 51;
            this.btnSaturation.Tag = "3";
            this.btnSaturation.Text = "default";
            // 
            // btnHue
            // 
            this.btnHue.Location = new System.Drawing.Point(190, 332);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(80, 29);
            this.btnHue.TabIndex = 50;
            this.btnHue.Tag = "2";
            this.btnHue.Text = "default";
            // 
            // btnContrast
            // 
            this.btnContrast.Location = new System.Drawing.Point(112, 332);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(79, 29);
            this.btnContrast.TabIndex = 49;
            this.btnContrast.Tag = "1";
            this.btnContrast.Text = "default";
            // 
            // btnBrightness
            // 
            this.btnBrightness.Location = new System.Drawing.Point(34, 332);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(78, 29);
            this.btnBrightness.TabIndex = 48;
            this.btnBrightness.Tag = "0";
            this.btnBrightness.Text = "default";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(34, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 20);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "brightness";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(504, 12);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(73, 20);
            this.Label7.TabIndex = 46;
            this.Label7.Text = "white bal.";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(426, 12);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 20);
            this.Label6.TabIndex = 45;
            this.Label6.Text = "gamma";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(336, 12);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(73, 20);
            this.Label5.TabIndex = 44;
            this.Label5.Text = "sharpness";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(258, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 20);
            this.Label4.TabIndex = 43;
            this.Label4.Text = "saturation";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(202, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(33, 20);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "hue";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(112, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 20);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "contrast";
            // 
            // tbrContrast
            // 
            this.tbrContrast.Location = new System.Drawing.Point(112, 37);
            this.tbrContrast.Name = "tbrContrast";
            this.tbrContrast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrContrast.Size = new System.Drawing.Size(56, 283);
            this.tbrContrast.TabIndex = 40;
            this.tbrContrast.Tag = "1";
            this.tbrContrast.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrSaturation
            // 
            this.tbrSaturation.Location = new System.Drawing.Point(268, 37);
            this.tbrSaturation.Name = "tbrSaturation";
            this.tbrSaturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrSaturation.Size = new System.Drawing.Size(56, 283);
            this.tbrSaturation.TabIndex = 39;
            this.tbrSaturation.Tag = "3";
            this.tbrSaturation.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrHue
            // 
            this.tbrHue.Location = new System.Drawing.Point(190, 37);
            this.tbrHue.Name = "tbrHue";
            this.tbrHue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrHue.Size = new System.Drawing.Size(56, 283);
            this.tbrHue.TabIndex = 38;
            this.tbrHue.Tag = "2";
            this.tbrHue.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrWhiteBalance
            // 
            this.tbrWhiteBalance.Location = new System.Drawing.Point(504, 37);
            this.tbrWhiteBalance.Name = "tbrWhiteBalance";
            this.tbrWhiteBalance.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrWhiteBalance.Size = new System.Drawing.Size(56, 283);
            this.tbrWhiteBalance.TabIndex = 37;
            this.tbrWhiteBalance.Tag = "7";
            this.tbrWhiteBalance.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrSharpness
            // 
            this.tbrSharpness.Location = new System.Drawing.Point(348, 37);
            this.tbrSharpness.Name = "tbrSharpness";
            this.tbrSharpness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrSharpness.Size = new System.Drawing.Size(56, 283);
            this.tbrSharpness.TabIndex = 36;
            this.tbrSharpness.Tag = "4";
            this.tbrSharpness.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrGamma
            // 
            this.tbrGamma.Location = new System.Drawing.Point(426, 37);
            this.tbrGamma.Name = "tbrGamma";
            this.tbrGamma.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrGamma.Size = new System.Drawing.Size(56, 283);
            this.tbrGamma.TabIndex = 35;
            this.tbrGamma.Tag = "5";
            this.tbrGamma.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrBrightness
            // 
            this.tbrBrightness.Location = new System.Drawing.Point(34, 37);
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrBrightness.Size = new System.Drawing.Size(56, 283);
            this.tbrBrightness.TabIndex = 34;
            this.tbrBrightness.Tag = "0";
            this.tbrBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // miscVideoQuality
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(698, 478);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.chkGain);
            this.Controls.Add(this.btnGain);
            this.Controls.Add(this.tbrGain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkWhiteBalance);
            this.Controls.Add(this.chkGamma);
            this.Controls.Add(this.chkSharpness);
            this.Controls.Add(this.chkSaturation);
            this.Controls.Add(this.chkHue);
            this.Controls.Add(this.chkContrast);
            this.Controls.Add(this.chkBrightness);
            this.Controls.Add(this.btnWhiteBalance);
            this.Controls.Add(this.btnGamma);
            this.Controls.Add(this.btnSharpness);
            this.Controls.Add(this.btnSaturation);
            this.Controls.Add(this.btnHue);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.tbrContrast);
            this.Controls.Add(this.tbrSaturation);
            this.Controls.Add(this.tbrHue);
            this.Controls.Add(this.tbrWhiteBalance);
            this.Controls.Add(this.tbrSharpness);
            this.Controls.Add(this.tbrGamma);
            this.Controls.Add(this.tbrBrightness);
            this.Name = "miscVideoQuality";
            this.Text = "miscVideoQuality";
            this.Load += new System.EventHandler(this.miscVideoQuality_Load);
            this.VisibleChanged += new System.EventHandler(this.miscVideoQuality_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tbrGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrWhiteBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.CheckBox chkGain;
        private System.Windows.Forms.Button btnGain;
        private System.Windows.Forms.TrackBar tbrGain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkWhiteBalance;
        private System.Windows.Forms.CheckBox chkGamma;
        private System.Windows.Forms.CheckBox chkSharpness;
        private System.Windows.Forms.CheckBox chkSaturation;
        private System.Windows.Forms.CheckBox chkHue;
        private System.Windows.Forms.CheckBox chkContrast;
        private System.Windows.Forms.CheckBox chkBrightness;
        private System.Windows.Forms.Button btnWhiteBalance;
        private System.Windows.Forms.Button btnGamma;
        private System.Windows.Forms.Button btnSharpness;
        private System.Windows.Forms.Button btnSaturation;
        private System.Windows.Forms.Button btnHue;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TrackBar tbrContrast;
        private System.Windows.Forms.TrackBar tbrSaturation;
        private System.Windows.Forms.TrackBar tbrHue;
        private System.Windows.Forms.TrackBar tbrWhiteBalance;
        private System.Windows.Forms.TrackBar tbrSharpness;
        private System.Windows.Forms.TrackBar tbrGamma;
        private System.Windows.Forms.TrackBar tbrBrightness;
    }
}

