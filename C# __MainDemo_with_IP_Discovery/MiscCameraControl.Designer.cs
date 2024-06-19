using System.Windows.Forms;

namespace MainDemo
{
    partial class miscCameraControl : Form
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
            this.btnClose = new System.Windows.Forms.Button();
            this.chkFocus = new System.Windows.Forms.CheckBox();
            this.chkIris = new System.Windows.Forms.CheckBox();
            this.chkExposure = new System.Windows.Forms.CheckBox();
            this.chkRoll = new System.Windows.Forms.CheckBox();
            this.chkTilt = new System.Windows.Forms.CheckBox();
            this.chkPan = new System.Windows.Forms.CheckBox();
            this.chkZoom = new System.Windows.Forms.CheckBox();
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnIris = new System.Windows.Forms.Button();
            this.btnExposure = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnTilt = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbrPan = new System.Windows.Forms.TrackBar();
            this.tbrRoll = new System.Windows.Forms.TrackBar();
            this.tbrTilt = new System.Windows.Forms.TrackBar();
            this.tbrFocus = new System.Windows.Forms.TrackBar();
            this.tbrExposure = new System.Windows.Forms.TrackBar();
            this.tbrIris = new System.Windows.Forms.TrackBar();
            this.tbrZoom = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(236, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkFocus
            // 
            this.chkFocus.Location = new System.Drawing.Point(492, 369);
            this.chkFocus.Name = "chkFocus";
            this.chkFocus.Size = new System.Drawing.Size(68, 24);
            this.chkFocus.TabIndex = 57;
            this.chkFocus.Tag = "6";
            this.chkFocus.Text = "auto";
            // 
            // chkIris
            // 
            this.chkIris.Location = new System.Drawing.Point(414, 369);
            this.chkIris.Name = "chkIris";
            this.chkIris.Size = new System.Drawing.Size(68, 24);
            this.chkIris.TabIndex = 56;
            this.chkIris.Tag = "5";
            this.chkIris.Text = "auto";
            // 
            // chkExposure
            // 
            this.chkExposure.Location = new System.Drawing.Point(336, 369);
            this.chkExposure.Name = "chkExposure";
            this.chkExposure.Size = new System.Drawing.Size(68, 24);
            this.chkExposure.TabIndex = 55;
            this.chkExposure.Tag = "4";
            this.chkExposure.Text = "auto";
            // 
            // chkRoll
            // 
            this.chkRoll.Location = new System.Drawing.Point(258, 369);
            this.chkRoll.Name = "chkRoll";
            this.chkRoll.Size = new System.Drawing.Size(71, 24);
            this.chkRoll.TabIndex = 54;
            this.chkRoll.Tag = "3";
            this.chkRoll.Text = "auto";
            // 
            // chkTilt
            // 
            this.chkTilt.Location = new System.Drawing.Point(180, 369);
            this.chkTilt.Name = "chkTilt";
            this.chkTilt.Size = new System.Drawing.Size(71, 24);
            this.chkTilt.TabIndex = 53;
            this.chkTilt.Tag = "2";
            this.chkTilt.Text = "auto";
            // 
            // chkPan
            // 
            this.chkPan.Location = new System.Drawing.Point(100, 369);
            this.chkPan.Name = "chkPan";
            this.chkPan.Size = new System.Drawing.Size(68, 24);
            this.chkPan.TabIndex = 52;
            this.chkPan.Tag = "1";
            this.chkPan.Text = "auto";
            // 
            // chkZoom
            // 
            this.chkZoom.Location = new System.Drawing.Point(22, 369);
            this.chkZoom.Name = "chkZoom";
            this.chkZoom.Size = new System.Drawing.Size(68, 24);
            this.chkZoom.TabIndex = 51;
            this.chkZoom.Tag = "0";
            this.chkZoom.Text = "auto";
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(492, 332);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(77, 29);
            this.btnFocus.TabIndex = 50;
            this.btnFocus.Tag = "6";
            this.btnFocus.Text = "default";
            // 
            // btnIris
            // 
            this.btnIris.Location = new System.Drawing.Point(414, 332);
            this.btnIris.Name = "btnIris";
            this.btnIris.Size = new System.Drawing.Size(77, 29);
            this.btnIris.TabIndex = 49;
            this.btnIris.Tag = "5";
            this.btnIris.Text = "default";
            // 
            // btnExposure
            // 
            this.btnExposure.Location = new System.Drawing.Point(336, 332);
            this.btnExposure.Name = "btnExposure";
            this.btnExposure.Size = new System.Drawing.Size(77, 29);
            this.btnExposure.TabIndex = 48;
            this.btnExposure.Tag = "4";
            this.btnExposure.Text = "default";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(258, 332);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(76, 29);
            this.btnRoll.TabIndex = 47;
            this.btnRoll.Tag = "3";
            this.btnRoll.Text = "default";
            // 
            // btnTilt
            // 
            this.btnTilt.Location = new System.Drawing.Point(180, 332);
            this.btnTilt.Name = "btnTilt";
            this.btnTilt.Size = new System.Drawing.Size(75, 29);
            this.btnTilt.TabIndex = 46;
            this.btnTilt.Tag = "2";
            this.btnTilt.Text = "default";
            // 
            // btnPan
            // 
            this.btnPan.Location = new System.Drawing.Point(100, 332);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(77, 29);
            this.btnPan.TabIndex = 45;
            this.btnPan.Tag = "1";
            this.btnPan.Text = "default";
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(22, 332);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(77, 29);
            this.btnZoom.TabIndex = 44;
            this.btnZoom.Tag = "0";
            this.btnZoom.Text = "default";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(34, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 25);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "zoom";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(504, 12);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(44, 25);
            this.Label7.TabIndex = 42;
            this.Label7.Text = "focus";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(436, 12);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(46, 25);
            this.Label6.TabIndex = 41;
            this.Label6.Text = "iris";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(324, 12);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 25);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "exposure";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(268, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 25);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "roll";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(202, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 25);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "tilt";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(112, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 25);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "pan";
            // 
            // tbrPan
            // 
            this.tbrPan.Location = new System.Drawing.Point(100, 37);
            this.tbrPan.Name = "tbrPan";
            this.tbrPan.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrPan.Size = new System.Drawing.Size(56, 283);
            this.tbrPan.TabIndex = 36;
            this.tbrPan.Tag = "1";
            this.tbrPan.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrRoll
            // 
            this.tbrRoll.Location = new System.Drawing.Point(258, 37);
            this.tbrRoll.Name = "tbrRoll";
            this.tbrRoll.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrRoll.Size = new System.Drawing.Size(56, 283);
            this.tbrRoll.TabIndex = 35;
            this.tbrRoll.Tag = "3";
            this.tbrRoll.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrTilt
            // 
            this.tbrTilt.Location = new System.Drawing.Point(180, 37);
            this.tbrTilt.Name = "tbrTilt";
            this.tbrTilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrTilt.Size = new System.Drawing.Size(56, 283);
            this.tbrTilt.TabIndex = 34;
            this.tbrTilt.Tag = "2";
            this.tbrTilt.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrFocus
            // 
            this.tbrFocus.Location = new System.Drawing.Point(492, 37);
            this.tbrFocus.Name = "tbrFocus";
            this.tbrFocus.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrFocus.Size = new System.Drawing.Size(56, 283);
            this.tbrFocus.TabIndex = 33;
            this.tbrFocus.Tag = "6";
            this.tbrFocus.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrExposure
            // 
            this.tbrExposure.Location = new System.Drawing.Point(336, 37);
            this.tbrExposure.Name = "tbrExposure";
            this.tbrExposure.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrExposure.Size = new System.Drawing.Size(56, 283);
            this.tbrExposure.TabIndex = 32;
            this.tbrExposure.Tag = "4";
            this.tbrExposure.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrIris
            // 
            this.tbrIris.Location = new System.Drawing.Point(414, 37);
            this.tbrIris.Name = "tbrIris";
            this.tbrIris.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrIris.Size = new System.Drawing.Size(56, 283);
            this.tbrIris.TabIndex = 31;
            this.tbrIris.Tag = "5";
            this.tbrIris.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrZoom
            // 
            this.tbrZoom.Location = new System.Drawing.Point(22, 37);
            this.tbrZoom.Name = "tbrZoom";
            this.tbrZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrZoom.Size = new System.Drawing.Size(56, 283);
            this.tbrZoom.TabIndex = 30;
            this.tbrZoom.Tag = "0";
            this.tbrZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // miscCameraControl
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(612, 501);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkFocus);
            this.Controls.Add(this.chkIris);
            this.Controls.Add(this.chkExposure);
            this.Controls.Add(this.chkRoll);
            this.Controls.Add(this.chkTilt);
            this.Controls.Add(this.chkPan);
            this.Controls.Add(this.chkZoom);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnIris);
            this.Controls.Add(this.btnExposure);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnTilt);
            this.Controls.Add(this.btnPan);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbrPan);
            this.Controls.Add(this.tbrRoll);
            this.Controls.Add(this.tbrTilt);
            this.Controls.Add(this.tbrFocus);
            this.Controls.Add(this.tbrExposure);
            this.Controls.Add(this.tbrIris);
            this.Controls.Add(this.tbrZoom);
            this.Name = "miscCameraControl";
            this.Text = "miscCameraControl";
            this.Load += new System.EventHandler(this.miscCameraControl_Load);
            this.VisibleChanged += new System.EventHandler(this.miscCameraControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkFocus;
        private System.Windows.Forms.CheckBox chkIris;
        private System.Windows.Forms.CheckBox chkExposure;
        private System.Windows.Forms.CheckBox chkRoll;
        private System.Windows.Forms.CheckBox chkTilt;
        private System.Windows.Forms.CheckBox chkPan;
        private System.Windows.Forms.CheckBox chkZoom;
        private System.Windows.Forms.Button btnFocus;
        private System.Windows.Forms.Button btnIris;
        private System.Windows.Forms.Button btnExposure;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnTilt;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TrackBar tbrPan;
        private System.Windows.Forms.TrackBar tbrRoll;
        private System.Windows.Forms.TrackBar tbrTilt;
        private System.Windows.Forms.TrackBar tbrFocus;
        private System.Windows.Forms.TrackBar tbrExposure;
        private System.Windows.Forms.TrackBar tbrIris;
        private System.Windows.Forms.TrackBar tbrZoom;
    }
}

