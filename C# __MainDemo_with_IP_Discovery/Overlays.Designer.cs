using System.Windows.Forms;

namespace MainDemo
{
    partial class Overlays : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlays));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDrawGridColor = new System.Windows.Forms.Button();
            this.edtDrawGrid = new System.Windows.Forms.TextBox();
            this.btnFreeHandColor = new System.Windows.Forms.Button();
            this.edtTextOverlayTargetDisplay = new System.Windows.Forms.TextBox();
            this.edtImageOverlayTargetDisplay = new System.Windows.Forms.TextBox();
            this.grbDrawGrid = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.grbTextOverlay = new System.Windows.Forms.GroupBox();
            this.btnTargetDisplayHelp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkTextOverlayTransparent = new System.Windows.Forms.CheckBox();
            this.chkHighResFont = new System.Windows.Forms.CheckBox();
            this.mmoTextOverlayString = new System.Windows.Forms.TextBox();
            this.rdgTextOverlayAlign = new System.Windows.Forms.GroupBox();
            this.rdgTextOverlayAlignCenter = new System.Windows.Forms.RadioButton();
            this.rdgTextOverlayAlignLeft = new System.Windows.Forms.RadioButton();
            this.rdgTextOverlayAlignRight = new System.Windows.Forms.RadioButton();
            this.chkTextOverlayScrolling = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtTextOverlayScrollingSpeed = new System.Windows.Forms.TextBox();
            this.edtTextOverlayLeft = new System.Windows.Forms.TextBox();
            this.btnSelectShadowColor = new System.Windows.Forms.Button();
            this.grbOverlaySelector = new System.Windows.Forms.GroupBox();
            this.TextSelector4 = new System.Windows.Forms.RadioButton();
            this.TextSelector3 = new System.Windows.Forms.RadioButton();
            this.TextSelector2 = new System.Windows.Forms.RadioButton();
            this.TextSelector1 = new System.Windows.Forms.RadioButton();
            this.TextSelector0 = new System.Windows.Forms.RadioButton();
            this.chkTextOverlayEnabled = new System.Windows.Forms.CheckBox();
            this.chkTextOverlayShadow = new System.Windows.Forms.CheckBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.edtTextOverlayTop = new System.Windows.Forms.TextBox();
            this.btnSelectFontColor = new System.Windows.Forms.Button();
            this.edtTextOverlayRight = new System.Windows.Forms.TextBox();
            this.Label43 = new System.Windows.Forms.Label();
            this.chkAdjustOverlayAspectRatio = new System.Windows.Forms.CheckBox();
            this.grbFreeHand = new System.Windows.Forms.GroupBox();
            this.chkFreeHandEnabled = new System.Windows.Forms.CheckBox();
            this.btnFreeHandErase = new System.Windows.Forms.Button();
            this.grbBitmapOverlay = new System.Windows.Forms.GroupBox();
            this.btn2TargetDisplayHelp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbrChromaKeyLeeway = new System.Windows.Forms.TrackBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.edtImageOverlayChromaKeyColorValue = new System.Windows.Forms.TextBox();
            this.chkImageOverlayChromaKey = new System.Windows.Forms.CheckBox();
            this.tbrImageOverlayAlphaBlending = new System.Windows.Forms.TrackBar();
            this.btnImageOverlayPickupTransparentColorHelp = new System.Windows.Forms.Button();
            this.btnImageOverlayPickupTransparentColor = new System.Windows.Forms.Button();
            this.grpImageOverlaySelector = new System.Windows.Forms.GroupBox();
            this.ImageSelector9 = new System.Windows.Forms.RadioButton();
            this.ImageSelector8 = new System.Windows.Forms.RadioButton();
            this.ImageSelector7 = new System.Windows.Forms.RadioButton();
            this.ImageSelector6 = new System.Windows.Forms.RadioButton();
            this.ImageSelector5 = new System.Windows.Forms.RadioButton();
            this.ImageSelector4 = new System.Windows.Forms.RadioButton();
            this.ImageSelector3 = new System.Windows.Forms.RadioButton();
            this.ImageSelector2 = new System.Windows.Forms.RadioButton();
            this.ImageSelector1 = new System.Windows.Forms.RadioButton();
            this.ImageSelector0 = new System.Windows.Forms.RadioButton();
            this.edtImageOverlayWidth = new System.Windows.Forms.TextBox();
            this.edtImageOverlayHeight = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.edtImageOverlayTransparentColorValue = new System.Windows.Forms.TextBox();
            this.btnImageOverlayFromFile = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkImageOverlayAlphaBlend = new System.Windows.Forms.CheckBox();
            this.chkImageOverlayUseTransparentColor = new System.Windows.Forms.CheckBox();
            this.chkImageOverlayEnabled = new System.Windows.Forms.CheckBox();
            this.chkImageOverlayTransparent = new System.Windows.Forms.CheckBox();
            this.edtImageOverlayLeft = new System.Windows.Forms.TextBox();
            this.edtImageOverlayTop = new System.Windows.Forms.TextBox();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.btnPIP = new System.Windows.Forms.Button();
            this.chkTargetAtMouseLocation = new System.Windows.Forms.CheckBox();
            this.grbDrawGrid.SuspendLayout();
            this.grbTextOverlay.SuspendLayout();
            this.rdgTextOverlayAlign.SuspendLayout();
            this.grbOverlaySelector.SuspendLayout();
            this.grbFreeHand.SuspendLayout();
            this.grbBitmapOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrChromaKeyLeeway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrImageOverlayAlphaBlending)).BeginInit();
            this.grpImageOverlaySelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrawGridColor
            // 
            this.btnDrawGridColor.Location = new System.Drawing.Point(40, 15);
            this.btnDrawGridColor.Name = "btnDrawGridColor";
            this.btnDrawGridColor.Size = new System.Drawing.Size(19, 23);
            this.btnDrawGridColor.TabIndex = 46;
            this.ToolTip1.SetToolTip(this.btnDrawGridColor, "select grid color from a color dialog");
            this.btnDrawGridColor.Click += new System.EventHandler(this.btnDrawGridColor_Click);
            // 
            // edtDrawGrid
            // 
            this.edtDrawGrid.Location = new System.Drawing.Point(58, 16);
            this.edtDrawGrid.Name = "edtDrawGrid";
            this.edtDrawGrid.Size = new System.Drawing.Size(30, 22);
            this.edtDrawGrid.TabIndex = 44;
            this.edtDrawGrid.Text = "0";
            this.ToolTip1.SetToolTip(this.edtDrawGrid, "enter a number between 2 and 100 to activate grid drawing");
            this.edtDrawGrid.TextChanged += new System.EventHandler(this.edtDrawGrid_TextChanged);
            // 
            // btnFreeHandColor
            // 
            this.btnFreeHandColor.Location = new System.Drawing.Point(103, 20);
            this.btnFreeHandColor.Name = "btnFreeHandColor";
            this.btnFreeHandColor.Size = new System.Drawing.Size(19, 25);
            this.btnFreeHandColor.TabIndex = 16;
            this.ToolTip1.SetToolTip(this.btnFreeHandColor, "select \"free hand\" drawng color from a color dialog");
            this.btnFreeHandColor.Click += new System.EventHandler(this.btnFreeHandColor_Click);
            // 
            // edtTextOverlayTargetDisplay
            // 
            this.edtTextOverlayTargetDisplay.Location = new System.Drawing.Point(204, 16);
            this.edtTextOverlayTargetDisplay.Name = "edtTextOverlayTargetDisplay";
            this.edtTextOverlayTargetDisplay.Size = new System.Drawing.Size(30, 23);
            this.edtTextOverlayTargetDisplay.TabIndex = 46;
            this.edtTextOverlayTargetDisplay.Text = "-1";
            this.ToolTip1.SetToolTip(this.edtTextOverlayTargetDisplay, "enter a number between 2 and 100 to activate grid drawing");
            this.edtTextOverlayTargetDisplay.TextChanged += new System.EventHandler(this.edtTextOverlayTargetDisplay_TextChanged);
            // 
            // edtImageOverlayTargetDisplay
            // 
            this.edtImageOverlayTargetDisplay.Location = new System.Drawing.Point(506, 121);
            this.edtImageOverlayTargetDisplay.Name = "edtImageOverlayTargetDisplay";
            this.edtImageOverlayTargetDisplay.Size = new System.Drawing.Size(30, 23);
            this.edtImageOverlayTargetDisplay.TabIndex = 49;
            this.edtImageOverlayTargetDisplay.Text = "-1";
            this.ToolTip1.SetToolTip(this.edtImageOverlayTargetDisplay, "enter a number between 2 and 100 to activate grid drawing");
            this.edtImageOverlayTargetDisplay.TextChanged += new System.EventHandler(this.edtImageOverlayTargetDisplay_TextChanged);
            // 
            // grbDrawGrid
            // 
            this.grbDrawGrid.Controls.Add(this.label6);
            this.grbDrawGrid.Controls.Add(this.btnDrawGridColor);
            this.grbDrawGrid.Controls.Add(this.Label5);
            this.grbDrawGrid.Controls.Add(this.edtDrawGrid);
            this.grbDrawGrid.Location = new System.Drawing.Point(702, 18);
            this.grbDrawGrid.Name = "grbDrawGrid";
            this.grbDrawGrid.Size = new System.Drawing.Size(143, 43);
            this.grbDrawGrid.TabIndex = 49;
            this.grbDrawGrid.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "grid:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(96, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(46, 17);
            this.Label5.TabIndex = 45;
            this.Label5.Text = "facets";
            // 
            // grbTextOverlay
            // 
            this.grbTextOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.grbTextOverlay.Controls.Add(this.btnTargetDisplayHelp);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayTargetDisplay);
            this.grbTextOverlay.Controls.Add(this.label8);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayTransparent);
            this.grbTextOverlay.Controls.Add(this.chkHighResFont);
            this.grbTextOverlay.Controls.Add(this.mmoTextOverlayString);
            this.grbTextOverlay.Controls.Add(this.rdgTextOverlayAlign);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayScrolling);
            this.grbTextOverlay.Controls.Add(this.label7);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayScrollingSpeed);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayLeft);
            this.grbTextOverlay.Controls.Add(this.btnSelectShadowColor);
            this.grbTextOverlay.Controls.Add(this.grbOverlaySelector);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayEnabled);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayShadow);
            this.grbTextOverlay.Controls.Add(this.btnBackColor);
            this.grbTextOverlay.Controls.Add(this.btnSelectFont);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayTop);
            this.grbTextOverlay.Controls.Add(this.btnSelectFontColor);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayRight);
            this.grbTextOverlay.Controls.Add(this.Label43);
            this.grbTextOverlay.Font = new System.Drawing.Font("Arial", 8F);
            this.grbTextOverlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbTextOverlay.Location = new System.Drawing.Point(5, 0);
            this.grbTextOverlay.Name = "grbTextOverlay";
            this.grbTextOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbTextOverlay.Size = new System.Drawing.Size(433, 205);
            this.grbTextOverlay.TabIndex = 47;
            this.grbTextOverlay.TabStop = false;
            this.grbTextOverlay.Text = "text overlays:";
            // 
            // btnTargetDisplayHelp
            // 
            this.btnTargetDisplayHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTargetDisplayHelp.Location = new System.Drawing.Point(241, 15);
            this.btnTargetDisplayHelp.Name = "btnTargetDisplayHelp";
            this.btnTargetDisplayHelp.Size = new System.Drawing.Size(33, 24);
            this.btnTargetDisplayHelp.TabIndex = 47;
            this.btnTargetDisplayHelp.Text = "?";
            this.btnTargetDisplayHelp.Click += new System.EventHandler(this.btnTargetDisplayHelp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(101, 21);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "target display: ";
            // 
            // chkTextOverlayTransparent
            // 
            this.chkTextOverlayTransparent.BackColor = System.Drawing.SystemColors.Control;
            this.chkTextOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkTextOverlayTransparent.Font = new System.Drawing.Font("Arial", 8F);
            this.chkTextOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkTextOverlayTransparent.Location = new System.Drawing.Point(130, 58);
            this.chkTextOverlayTransparent.Name = "chkTextOverlayTransparent";
            this.chkTextOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkTextOverlayTransparent.Size = new System.Drawing.Size(98, 18);
            this.chkTextOverlayTransparent.TabIndex = 17;
            this.chkTextOverlayTransparent.Text = "transparent";
            this.chkTextOverlayTransparent.UseVisualStyleBackColor = false;
            this.chkTextOverlayTransparent.CheckedChanged += new System.EventHandler(this.chkTextOverlayTransparent_CheckedChanged);
            // 
            // chkHighResFont
            // 
            this.chkHighResFont.BackColor = System.Drawing.SystemColors.Control;
            this.chkHighResFont.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkHighResFont.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkHighResFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkHighResFont.Location = new System.Drawing.Point(7, 38);
            this.chkHighResFont.Name = "chkHighResFont";
            this.chkHighResFont.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHighResFont.Size = new System.Drawing.Size(172, 23);
            this.chkHighResFont.TabIndex = 44;
            this.chkHighResFont.Text = "high resolution font";
            this.chkHighResFont.UseVisualStyleBackColor = false;
            this.chkHighResFont.CheckedChanged += new System.EventHandler(this.chkHighResFont_CheckedChanged);
            // 
            // mmoTextOverlayString
            // 
            this.mmoTextOverlayString.AcceptsReturn = true;
            this.mmoTextOverlayString.BackColor = System.Drawing.SystemColors.Window;
            this.mmoTextOverlayString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoTextOverlayString.Font = new System.Drawing.Font("Arial", 8F);
            this.mmoTextOverlayString.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoTextOverlayString.Location = new System.Drawing.Point(0, 123);
            this.mmoTextOverlayString.MaxLength = 0;
            this.mmoTextOverlayString.Multiline = true;
            this.mmoTextOverlayString.Name = "mmoTextOverlayString";
            this.mmoTextOverlayString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoTextOverlayString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmoTextOverlayString.Size = new System.Drawing.Size(217, 81);
            this.mmoTextOverlayString.TabIndex = 26;
            this.mmoTextOverlayString.TextChanged += new System.EventHandler(this.mmoTextOverlayString_TextChanged);
            // 
            // rdgTextOverlayAlign
            // 
            this.rdgTextOverlayAlign.Controls.Add(this.rdgTextOverlayAlignCenter);
            this.rdgTextOverlayAlign.Controls.Add(this.rdgTextOverlayAlignLeft);
            this.rdgTextOverlayAlign.Controls.Add(this.rdgTextOverlayAlignRight);
            this.rdgTextOverlayAlign.Location = new System.Drawing.Point(226, 128);
            this.rdgTextOverlayAlign.Name = "rdgTextOverlayAlign";
            this.rdgTextOverlayAlign.Size = new System.Drawing.Size(207, 43);
            this.rdgTextOverlayAlign.TabIndex = 43;
            this.rdgTextOverlayAlign.TabStop = false;
            // 
            // rdgTextOverlayAlignCenter
            // 
            this.rdgTextOverlayAlignCenter.AutoSize = true;
            this.rdgTextOverlayAlignCenter.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTextOverlayAlignCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTextOverlayAlignCenter.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgTextOverlayAlignCenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTextOverlayAlignCenter.Location = new System.Drawing.Point(62, 14);
            this.rdgTextOverlayAlignCenter.Name = "rdgTextOverlayAlignCenter";
            this.rdgTextOverlayAlignCenter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTextOverlayAlignCenter.Size = new System.Drawing.Size(69, 20);
            this.rdgTextOverlayAlignCenter.TabIndex = 41;
            this.rdgTextOverlayAlignCenter.TabStop = true;
            this.rdgTextOverlayAlignCenter.Tag = "1";
            this.rdgTextOverlayAlignCenter.Text = "center";
            this.rdgTextOverlayAlignCenter.UseVisualStyleBackColor = false;
            // 
            // rdgTextOverlayAlignLeft
            // 
            this.rdgTextOverlayAlignLeft.AutoSize = true;
            this.rdgTextOverlayAlignLeft.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTextOverlayAlignLeft.Checked = true;
            this.rdgTextOverlayAlignLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTextOverlayAlignLeft.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgTextOverlayAlignLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTextOverlayAlignLeft.Location = new System.Drawing.Point(7, 14);
            this.rdgTextOverlayAlignLeft.Name = "rdgTextOverlayAlignLeft";
            this.rdgTextOverlayAlignLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTextOverlayAlignLeft.Size = new System.Drawing.Size(48, 20);
            this.rdgTextOverlayAlignLeft.TabIndex = 42;
            this.rdgTextOverlayAlignLeft.TabStop = true;
            this.rdgTextOverlayAlignLeft.Tag = "0";
            this.rdgTextOverlayAlignLeft.Text = "left";
            this.rdgTextOverlayAlignLeft.UseVisualStyleBackColor = false;
            // 
            // rdgTextOverlayAlignRight
            // 
            this.rdgTextOverlayAlignRight.AutoSize = true;
            this.rdgTextOverlayAlignRight.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTextOverlayAlignRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTextOverlayAlignRight.Font = new System.Drawing.Font("Arial", 8F);
            this.rdgTextOverlayAlignRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTextOverlayAlignRight.Location = new System.Drawing.Point(137, 14);
            this.rdgTextOverlayAlignRight.Name = "rdgTextOverlayAlignRight";
            this.rdgTextOverlayAlignRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTextOverlayAlignRight.Size = new System.Drawing.Size(57, 20);
            this.rdgTextOverlayAlignRight.TabIndex = 40;
            this.rdgTextOverlayAlignRight.TabStop = true;
            this.rdgTextOverlayAlignRight.Tag = "2";
            this.rdgTextOverlayAlignRight.Text = "right";
            this.rdgTextOverlayAlignRight.UseVisualStyleBackColor = false;
            // 
            // chkTextOverlayScrolling
            // 
            this.chkTextOverlayScrolling.AutoSize = true;
            this.chkTextOverlayScrolling.Font = new System.Drawing.Font("Arial", 8F);
            this.chkTextOverlayScrolling.Location = new System.Drawing.Point(232, 178);
            this.chkTextOverlayScrolling.Name = "chkTextOverlayScrolling";
            this.chkTextOverlayScrolling.Size = new System.Drawing.Size(82, 20);
            this.chkTextOverlayScrolling.TabIndex = 39;
            this.chkTextOverlayScrolling.Text = "scrolling";
            this.chkTextOverlayScrolling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTextOverlayScrolling.UseVisualStyleBackColor = true;
            this.chkTextOverlayScrolling.CheckedChanged += new System.EventHandler(this.chkTextOverlayScrolling_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(269, 178);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "-> speed(+-)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtTextOverlayScrollingSpeed
            // 
            this.edtTextOverlayScrollingSpeed.Location = new System.Drawing.Point(386, 177);
            this.edtTextOverlayScrollingSpeed.Name = "edtTextOverlayScrollingSpeed";
            this.edtTextOverlayScrollingSpeed.Size = new System.Drawing.Size(38, 23);
            this.edtTextOverlayScrollingSpeed.TabIndex = 37;
            this.edtTextOverlayScrollingSpeed.TextChanged += new System.EventHandler(this.edtTextOverlayScrollingSpeed_TextChanged);
            // 
            // edtTextOverlayLeft
            // 
            this.edtTextOverlayLeft.AcceptsReturn = true;
            this.edtTextOverlayLeft.BackColor = System.Drawing.SystemColors.Window;
            this.edtTextOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTextOverlayLeft.Font = new System.Drawing.Font("Arial", 8F);
            this.edtTextOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTextOverlayLeft.Location = new System.Drawing.Point(229, 106);
            this.edtTextOverlayLeft.MaxLength = 0;
            this.edtTextOverlayLeft.Name = "edtTextOverlayLeft";
            this.edtTextOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTextOverlayLeft.Size = new System.Drawing.Size(40, 23);
            this.edtTextOverlayLeft.TabIndex = 20;
            this.edtTextOverlayLeft.Text = "5";
            this.edtTextOverlayLeft.TextChanged += new System.EventHandler(this.edtTextOverlayLeft_TextChanged);
            // 
            // btnSelectShadowColor
            // 
            this.btnSelectShadowColor.Location = new System.Drawing.Point(323, 54);
            this.btnSelectShadowColor.Name = "btnSelectShadowColor";
            this.btnSelectShadowColor.Size = new System.Drawing.Size(103, 24);
            this.btnSelectShadowColor.TabIndex = 36;
            this.btnSelectShadowColor.Text = "shadow color";
            this.btnSelectShadowColor.Click += new System.EventHandler(this.btnSelectShadowColor_Click);
            // 
            // grbOverlaySelector
            // 
            this.grbOverlaySelector.Controls.Add(this.TextSelector4);
            this.grbOverlaySelector.Controls.Add(this.TextSelector3);
            this.grbOverlaySelector.Controls.Add(this.TextSelector2);
            this.grbOverlaySelector.Controls.Add(this.TextSelector1);
            this.grbOverlaySelector.Controls.Add(this.TextSelector0);
            this.grbOverlaySelector.Location = new System.Drawing.Point(0, 84);
            this.grbOverlaySelector.Name = "grbOverlaySelector";
            this.grbOverlaySelector.Size = new System.Drawing.Size(217, 39);
            this.grbOverlaySelector.TabIndex = 34;
            this.grbOverlaySelector.TabStop = false;
            this.grbOverlaySelector.Text = "text selector [0 - n]  0 = default";
            // 
            // TextSelector4
            // 
            this.TextSelector4.Location = new System.Drawing.Point(170, 16);
            this.TextSelector4.Name = "TextSelector4";
            this.TextSelector4.Size = new System.Drawing.Size(29, 19);
            this.TextSelector4.TabIndex = 4;
            this.TextSelector4.Tag = "4";
            this.TextSelector4.Text = "4";
            this.TextSelector4.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector3
            // 
            this.TextSelector3.Location = new System.Drawing.Point(132, 16);
            this.TextSelector3.Name = "TextSelector3";
            this.TextSelector3.Size = new System.Drawing.Size(29, 19);
            this.TextSelector3.TabIndex = 3;
            this.TextSelector3.Tag = "3";
            this.TextSelector3.Text = "3";
            this.TextSelector3.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector2
            // 
            this.TextSelector2.Location = new System.Drawing.Point(94, 16);
            this.TextSelector2.Name = "TextSelector2";
            this.TextSelector2.Size = new System.Drawing.Size(28, 19);
            this.TextSelector2.TabIndex = 2;
            this.TextSelector2.Tag = "2";
            this.TextSelector2.Text = "2";
            this.TextSelector2.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector1
            // 
            this.TextSelector1.Location = new System.Drawing.Point(55, 16);
            this.TextSelector1.Name = "TextSelector1";
            this.TextSelector1.Size = new System.Drawing.Size(29, 19);
            this.TextSelector1.TabIndex = 1;
            this.TextSelector1.Tag = "1";
            this.TextSelector1.Text = "1";
            this.TextSelector1.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector0
            // 
            this.TextSelector0.Location = new System.Drawing.Point(17, 16);
            this.TextSelector0.Name = "TextSelector0";
            this.TextSelector0.Size = new System.Drawing.Size(29, 19);
            this.TextSelector0.TabIndex = 0;
            this.TextSelector0.Tag = "0";
            this.TextSelector0.Text = "0";
            this.TextSelector0.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // chkTextOverlayEnabled
            // 
            this.chkTextOverlayEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkTextOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkTextOverlayEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkTextOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkTextOverlayEnabled.Location = new System.Drawing.Point(7, 21);
            this.chkTextOverlayEnabled.Name = "chkTextOverlayEnabled";
            this.chkTextOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkTextOverlayEnabled.Size = new System.Drawing.Size(87, 18);
            this.chkTextOverlayEnabled.TabIndex = 25;
            this.chkTextOverlayEnabled.Text = "enabled";
            this.chkTextOverlayEnabled.UseVisualStyleBackColor = false;
            this.chkTextOverlayEnabled.CheckedChanged += new System.EventHandler(this.chkTextOverlayEnabled_CheckedChanged);
            // 
            // chkTextOverlayShadow
            // 
            this.chkTextOverlayShadow.Location = new System.Drawing.Point(235, 59);
            this.chkTextOverlayShadow.Name = "chkTextOverlayShadow";
            this.chkTextOverlayShadow.Size = new System.Drawing.Size(81, 17);
            this.chkTextOverlayShadow.TabIndex = 31;
            this.chkTextOverlayShadow.Text = "shadow";
            this.chkTextOverlayShadow.CheckedChanged += new System.EventHandler(this.chkTextOverlayShadow_CheckedChanged);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(359, 23);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(61, 24);
            this.btnBackColor.TabIndex = 33;
            this.btnBackColor.Text = "bkgnd";
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(362, 97);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(62, 24);
            this.btnSelectFont.TabIndex = 30;
            this.btnSelectFont.Text = "font dlg";
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // edtTextOverlayTop
            // 
            this.edtTextOverlayTop.AcceptsReturn = true;
            this.edtTextOverlayTop.BackColor = System.Drawing.SystemColors.Window;
            this.edtTextOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTextOverlayTop.Font = new System.Drawing.Font("Arial", 8F);
            this.edtTextOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTextOverlayTop.Location = new System.Drawing.Point(316, 107);
            this.edtTextOverlayTop.MaxLength = 0;
            this.edtTextOverlayTop.Name = "edtTextOverlayTop";
            this.edtTextOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTextOverlayTop.Size = new System.Drawing.Size(39, 23);
            this.edtTextOverlayTop.TabIndex = 19;
            this.edtTextOverlayTop.Text = "5";
            this.edtTextOverlayTop.TextChanged += new System.EventHandler(this.edtTextOverlayTop_TextChanged);
            // 
            // btnSelectFontColor
            // 
            this.btnSelectFontColor.Location = new System.Drawing.Point(294, 23);
            this.btnSelectFontColor.Name = "btnSelectFontColor";
            this.btnSelectFontColor.Size = new System.Drawing.Size(61, 24);
            this.btnSelectFontColor.TabIndex = 32;
            this.btnSelectFontColor.Text = "color";
            this.btnSelectFontColor.Click += new System.EventHandler(this.btnSelectFontColor_Click);
            // 
            // edtTextOverlayRight
            // 
            this.edtTextOverlayRight.AcceptsReturn = true;
            this.edtTextOverlayRight.BackColor = System.Drawing.SystemColors.Window;
            this.edtTextOverlayRight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTextOverlayRight.Font = new System.Drawing.Font("Arial", 8F);
            this.edtTextOverlayRight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTextOverlayRight.Location = new System.Drawing.Point(272, 106);
            this.edtTextOverlayRight.MaxLength = 0;
            this.edtTextOverlayRight.Name = "edtTextOverlayRight";
            this.edtTextOverlayRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTextOverlayRight.Size = new System.Drawing.Size(40, 23);
            this.edtTextOverlayRight.TabIndex = 18;
            this.edtTextOverlayRight.Text = "-1";
            this.edtTextOverlayRight.TextChanged += new System.EventHandler(this.edtTextOverlayRight_TextChanged);
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.BackColor = System.Drawing.SystemColors.Control;
            this.Label43.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label43.Font = new System.Drawing.Font("Arial", 8F);
            this.Label43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label43.Location = new System.Drawing.Point(229, 89);
            this.Label43.Name = "Label43";
            this.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label43.Size = new System.Drawing.Size(123, 16);
            this.Label43.TabIndex = 29;
            this.Label43.Text = "left      right      top";
            // 
            // chkAdjustOverlayAspectRatio
            // 
            this.chkAdjustOverlayAspectRatio.AutoSize = true;
            this.chkAdjustOverlayAspectRatio.BackColor = System.Drawing.SystemColors.Control;
            this.chkAdjustOverlayAspectRatio.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAdjustOverlayAspectRatio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkAdjustOverlayAspectRatio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkAdjustOverlayAspectRatio.Location = new System.Drawing.Point(712, 8);
            this.chkAdjustOverlayAspectRatio.Name = "chkAdjustOverlayAspectRatio";
            this.chkAdjustOverlayAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAdjustOverlayAspectRatio.Size = new System.Drawing.Size(216, 20);
            this.chkAdjustOverlayAspectRatio.TabIndex = 40;
            this.chkAdjustOverlayAspectRatio.Text = "adjust overlay aspect ratio";
            this.chkAdjustOverlayAspectRatio.UseVisualStyleBackColor = false;
            this.chkAdjustOverlayAspectRatio.CheckedChanged += new System.EventHandler(this.chkAdjustOverlayAspectRatio_CheckedChanged);
            // 
            // grbFreeHand
            // 
            this.grbFreeHand.BackColor = System.Drawing.SystemColors.Control;
            this.grbFreeHand.Controls.Add(this.chkFreeHandEnabled);
            this.grbFreeHand.Controls.Add(this.btnFreeHandErase);
            this.grbFreeHand.Controls.Add(this.btnFreeHandColor);
            this.grbFreeHand.Font = new System.Drawing.Font("Arial", 8F);
            this.grbFreeHand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFreeHand.Location = new System.Drawing.Point(445, 0);
            this.grbFreeHand.Name = "grbFreeHand";
            this.grbFreeHand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbFreeHand.Size = new System.Drawing.Size(251, 57);
            this.grbFreeHand.TabIndex = 46;
            this.grbFreeHand.TabStop = false;
            this.grbFreeHand.Text = "\"free hand\" mouse overlay USING DC";
            // 
            // chkFreeHandEnabled
            // 
            this.chkFreeHandEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkFreeHandEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFreeHandEnabled.Font = new System.Drawing.Font("Arial", 8F);
            this.chkFreeHandEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkFreeHandEnabled.Location = new System.Drawing.Point(19, 23);
            this.chkFreeHandEnabled.Name = "chkFreeHandEnabled";
            this.chkFreeHandEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFreeHandEnabled.Size = new System.Drawing.Size(78, 20);
            this.chkFreeHandEnabled.TabIndex = 15;
            this.chkFreeHandEnabled.Text = "enabled";
            this.chkFreeHandEnabled.UseVisualStyleBackColor = false;
            this.chkFreeHandEnabled.CheckedChanged += new System.EventHandler(this.chkFreeHandEnabled_CheckedChanged);
            // 
            // btnFreeHandErase
            // 
            this.btnFreeHandErase.BackColor = System.Drawing.SystemColors.Control;
            this.btnFreeHandErase.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFreeHandErase.Font = new System.Drawing.Font("Arial", 8F);
            this.btnFreeHandErase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFreeHandErase.Location = new System.Drawing.Point(122, 20);
            this.btnFreeHandErase.Name = "btnFreeHandErase";
            this.btnFreeHandErase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFreeHandErase.Size = new System.Drawing.Size(118, 25);
            this.btnFreeHandErase.TabIndex = 14;
            this.btnFreeHandErase.Text = "erase drawing";
            this.btnFreeHandErase.UseVisualStyleBackColor = false;
            this.btnFreeHandErase.Click += new System.EventHandler(this.btnFreeHandErase_Click);
            // 
            // grbBitmapOverlay
            // 
            this.grbBitmapOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.grbBitmapOverlay.Controls.Add(this.btn2TargetDisplayHelp);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayTargetDisplay);
            this.grbBitmapOverlay.Controls.Add(this.label9);
            this.grbBitmapOverlay.Controls.Add(this.tbrChromaKeyLeeway);
            this.grbBitmapOverlay.Controls.Add(this.Label4);
            this.grbBitmapOverlay.Controls.Add(this.Label3);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayChromaKeyColorValue);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayChromaKey);
            this.grbBitmapOverlay.Controls.Add(this.tbrImageOverlayAlphaBlending);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayPickupTransparentColorHelp);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayPickupTransparentColor);
            this.grbBitmapOverlay.Controls.Add(this.grpImageOverlaySelector);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayWidth);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayHeight);
            this.grbBitmapOverlay.Controls.Add(this.Label1);
            this.grbBitmapOverlay.Controls.Add(this.Label2);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayTransparentColorValue);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayFromFile);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayAlphaBlend);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayUseTransparentColor);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayEnabled);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayTransparent);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayLeft);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayTop);
            this.grbBitmapOverlay.Controls.Add(this.Label48);
            this.grbBitmapOverlay.Controls.Add(this.Label49);
            this.grbBitmapOverlay.Font = new System.Drawing.Font("Arial", 8F);
            this.grbBitmapOverlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbBitmapOverlay.Location = new System.Drawing.Point(445, 54);
            this.grbBitmapOverlay.Name = "grbBitmapOverlay";
            this.grbBitmapOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbBitmapOverlay.Size = new System.Drawing.Size(647, 151);
            this.grbBitmapOverlay.TabIndex = 45;
            this.grbBitmapOverlay.TabStop = false;
            this.grbBitmapOverlay.Text = "image overlay";
            // 
            // btn2TargetDisplayHelp
            // 
            this.btn2TargetDisplayHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2TargetDisplayHelp.Location = new System.Drawing.Point(544, 120);
            this.btn2TargetDisplayHelp.Name = "btn2TargetDisplayHelp";
            this.btn2TargetDisplayHelp.Size = new System.Drawing.Size(32, 24);
            this.btn2TargetDisplayHelp.TabIndex = 50;
            this.btn2TargetDisplayHelp.Text = "?";
            this.btn2TargetDisplayHelp.Click += new System.EventHandler(this.btn2TargetDisplayHelp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(403, 126);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "target display: ";
            // 
            // tbrChromaKeyLeeway
            // 
            this.tbrChromaKeyLeeway.AutoSize = false;
            this.tbrChromaKeyLeeway.Location = new System.Drawing.Point(520, 95);
            this.tbrChromaKeyLeeway.Maximum = 100;
            this.tbrChromaKeyLeeway.Name = "tbrChromaKeyLeeway";
            this.tbrChromaKeyLeeway.Size = new System.Drawing.Size(105, 18);
            this.tbrChromaKeyLeeway.TabIndex = 44;
            this.tbrChromaKeyLeeway.TickFrequency = 10;
            this.tbrChromaKeyLeeway.Scroll += new System.EventHandler(this.tbrChromaKeyLeeway_Scroll);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(400, 75);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(154, 16);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "chroma key RGB color:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(400, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 18);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "chroma key leeway:";
            // 
            // edtImageOverlayChromaKeyColorValue
            // 
            this.edtImageOverlayChromaKeyColorValue.Location = new System.Drawing.Point(552, 70);
            this.edtImageOverlayChromaKeyColorValue.Name = "edtImageOverlayChromaKeyColorValue";
            this.edtImageOverlayChromaKeyColorValue.Size = new System.Drawing.Size(67, 23);
            this.edtImageOverlayChromaKeyColorValue.TabIndex = 41;
            this.edtImageOverlayChromaKeyColorValue.Text = "0";
            this.edtImageOverlayChromaKeyColorValue.TextChanged += new System.EventHandler(this.edtImageOverlayChromaKeyColorValue_TextChanged);
            // 
            // chkImageOverlayChromaKey
            // 
            this.chkImageOverlayChromaKey.BackColor = System.Drawing.SystemColors.Control;
            this.chkImageOverlayChromaKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkImageOverlayChromaKey.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkImageOverlayChromaKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkImageOverlayChromaKey.Location = new System.Drawing.Point(403, 53);
            this.chkImageOverlayChromaKey.Name = "chkImageOverlayChromaKey";
            this.chkImageOverlayChromaKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageOverlayChromaKey.Size = new System.Drawing.Size(141, 21);
            this.chkImageOverlayChromaKey.TabIndex = 39;
            this.chkImageOverlayChromaKey.Text = "chroma key";
            this.chkImageOverlayChromaKey.UseVisualStyleBackColor = false;
            this.chkImageOverlayChromaKey.CheckedChanged += new System.EventHandler(this.chkImageOverlayChromaKey_CheckedChanged);
            // 
            // tbrImageOverlayAlphaBlending
            // 
            this.tbrImageOverlayAlphaBlending.AutoSize = false;
            this.tbrImageOverlayAlphaBlending.Location = new System.Drawing.Point(253, 95);
            this.tbrImageOverlayAlphaBlending.Maximum = 255;
            this.tbrImageOverlayAlphaBlending.Name = "tbrImageOverlayAlphaBlending";
            this.tbrImageOverlayAlphaBlending.Size = new System.Drawing.Size(115, 18);
            this.tbrImageOverlayAlphaBlending.TabIndex = 38;
            this.tbrImageOverlayAlphaBlending.TickFrequency = 26;
            this.tbrImageOverlayAlphaBlending.Scroll += new System.EventHandler(this.tbrImageOverlayAlphaBlending_Scroll);
            // 
            // btnImageOverlayPickupTransparentColorHelp
            // 
            this.btnImageOverlayPickupTransparentColorHelp.Location = new System.Drawing.Point(331, 118);
            this.btnImageOverlayPickupTransparentColorHelp.Name = "btnImageOverlayPickupTransparentColorHelp";
            this.btnImageOverlayPickupTransparentColorHelp.Size = new System.Drawing.Size(33, 24);
            this.btnImageOverlayPickupTransparentColorHelp.TabIndex = 37;
            this.btnImageOverlayPickupTransparentColorHelp.Text = "?";
            this.btnImageOverlayPickupTransparentColorHelp.Click += new System.EventHandler(this.btnImageOverlayPickupTransparentColorHelp_Click);
            // 
            // btnImageOverlayPickupTransparentColor
            // 
            this.btnImageOverlayPickupTransparentColor.Location = new System.Drawing.Point(139, 118);
            this.btnImageOverlayPickupTransparentColor.Name = "btnImageOverlayPickupTransparentColor";
            this.btnImageOverlayPickupTransparentColor.Size = new System.Drawing.Size(185, 24);
            this.btnImageOverlayPickupTransparentColor.TabIndex = 36;
            this.btnImageOverlayPickupTransparentColor.Text = "pick up transparent color";
            this.btnImageOverlayPickupTransparentColor.Click += new System.EventHandler(this.btnImageOverlayPickupTransparentColor_Click);
            // 
            // grpImageOverlaySelector
            // 
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector9);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector8);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector7);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector6);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector5);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector4);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector3);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector2);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector1);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector0);
            this.grpImageOverlaySelector.Location = new System.Drawing.Point(234, 13);
            this.grpImageOverlaySelector.Name = "grpImageOverlaySelector";
            this.grpImageOverlaySelector.Size = new System.Drawing.Size(404, 39);
            this.grpImageOverlaySelector.TabIndex = 35;
            this.grpImageOverlaySelector.TabStop = false;
            this.grpImageOverlaySelector.Text = "image selector [0..9] 0 = default";
            // 
            // ImageSelector9
            // 
            this.ImageSelector9.Location = new System.Drawing.Point(362, 17);
            this.ImageSelector9.Name = "ImageSelector9";
            this.ImageSelector9.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector9.TabIndex = 9;
            this.ImageSelector9.Tag = "9";
            this.ImageSelector9.Text = "9";
            this.ImageSelector9.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector8
            // 
            this.ImageSelector8.Location = new System.Drawing.Point(324, 17);
            this.ImageSelector8.Name = "ImageSelector8";
            this.ImageSelector8.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector8.TabIndex = 8;
            this.ImageSelector8.Tag = "8";
            this.ImageSelector8.Text = "8";
            this.ImageSelector8.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector7
            // 
            this.ImageSelector7.Location = new System.Drawing.Point(286, 17);
            this.ImageSelector7.Name = "ImageSelector7";
            this.ImageSelector7.Size = new System.Drawing.Size(28, 19);
            this.ImageSelector7.TabIndex = 7;
            this.ImageSelector7.Tag = "7";
            this.ImageSelector7.Text = "7";
            this.ImageSelector7.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector6
            // 
            this.ImageSelector6.Location = new System.Drawing.Point(247, 17);
            this.ImageSelector6.Name = "ImageSelector6";
            this.ImageSelector6.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector6.TabIndex = 6;
            this.ImageSelector6.Tag = "6";
            this.ImageSelector6.Text = "6";
            this.ImageSelector6.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector5
            // 
            this.ImageSelector5.Location = new System.Drawing.Point(209, 17);
            this.ImageSelector5.Name = "ImageSelector5";
            this.ImageSelector5.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector5.TabIndex = 5;
            this.ImageSelector5.Tag = "5";
            this.ImageSelector5.Text = "5";
            this.ImageSelector5.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector4
            // 
            this.ImageSelector4.Location = new System.Drawing.Point(173, 17);
            this.ImageSelector4.Name = "ImageSelector4";
            this.ImageSelector4.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector4.TabIndex = 4;
            this.ImageSelector4.Tag = "4";
            this.ImageSelector4.Text = "4";
            this.ImageSelector4.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector3
            // 
            this.ImageSelector3.Location = new System.Drawing.Point(134, 17);
            this.ImageSelector3.Name = "ImageSelector3";
            this.ImageSelector3.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector3.TabIndex = 3;
            this.ImageSelector3.Tag = "3";
            this.ImageSelector3.Text = "3";
            this.ImageSelector3.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector2
            // 
            this.ImageSelector2.Location = new System.Drawing.Point(96, 17);
            this.ImageSelector2.Name = "ImageSelector2";
            this.ImageSelector2.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector2.TabIndex = 2;
            this.ImageSelector2.Tag = "2";
            this.ImageSelector2.Text = "2";
            this.ImageSelector2.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector1
            // 
            this.ImageSelector1.Location = new System.Drawing.Point(58, 17);
            this.ImageSelector1.Name = "ImageSelector1";
            this.ImageSelector1.Size = new System.Drawing.Size(28, 19);
            this.ImageSelector1.TabIndex = 1;
            this.ImageSelector1.Tag = "1";
            this.ImageSelector1.Text = "1";
            this.ImageSelector1.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector0
            // 
            this.ImageSelector0.Location = new System.Drawing.Point(19, 17);
            this.ImageSelector0.Name = "ImageSelector0";
            this.ImageSelector0.Size = new System.Drawing.Size(29, 19);
            this.ImageSelector0.TabIndex = 0;
            this.ImageSelector0.Tag = "0";
            this.ImageSelector0.Text = "0";
            this.ImageSelector0.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // edtImageOverlayWidth
            // 
            this.edtImageOverlayWidth.AcceptsReturn = true;
            this.edtImageOverlayWidth.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayWidth.Font = new System.Drawing.Font("Arial", 8F);
            this.edtImageOverlayWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayWidth.Location = new System.Drawing.Point(23, 110);
            this.edtImageOverlayWidth.MaxLength = 0;
            this.edtImageOverlayWidth.Name = "edtImageOverlayWidth";
            this.edtImageOverlayWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayWidth.Size = new System.Drawing.Size(39, 23);
            this.edtImageOverlayWidth.TabIndex = 19;
            this.edtImageOverlayWidth.Text = "-1";
            this.edtImageOverlayWidth.TextChanged += new System.EventHandler(this.edtImageOverlayWidth_TextChanged);
            // 
            // edtImageOverlayHeight
            // 
            this.edtImageOverlayHeight.AcceptsReturn = true;
            this.edtImageOverlayHeight.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayHeight.Font = new System.Drawing.Font("Arial", 8F);
            this.edtImageOverlayHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayHeight.Location = new System.Drawing.Point(73, 110);
            this.edtImageOverlayHeight.MaxLength = 0;
            this.edtImageOverlayHeight.Name = "edtImageOverlayHeight";
            this.edtImageOverlayHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayHeight.Size = new System.Drawing.Size(40, 23);
            this.edtImageOverlayHeight.TabIndex = 18;
            this.edtImageOverlayHeight.Text = "-1";
            this.edtImageOverlayHeight.TextChanged += new System.EventHandler(this.edtImageOverlayHeight_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(22, 95);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(40, 16);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "width";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(70, 95);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(47, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "height";
            // 
            // edtImageOverlayTransparentColorValue
            // 
            this.edtImageOverlayTransparentColorValue.Location = new System.Drawing.Point(296, 70);
            this.edtImageOverlayTransparentColorValue.Name = "edtImageOverlayTransparentColorValue";
            this.edtImageOverlayTransparentColorValue.Size = new System.Drawing.Size(68, 23);
            this.edtImageOverlayTransparentColorValue.TabIndex = 17;
            this.edtImageOverlayTransparentColorValue.Text = "0";
            this.edtImageOverlayTransparentColorValue.TextChanged += new System.EventHandler(this.edtImageOverlayTransparentColorValue_TextChanged);
            // 
            // btnImageOverlayFromFile
            // 
            this.btnImageOverlayFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImageOverlayFromFile.ImageIndex = 0;
            this.btnImageOverlayFromFile.ImageList = this.ImageList1;
            this.btnImageOverlayFromFile.Location = new System.Drawing.Point(115, 17);
            this.btnImageOverlayFromFile.Name = "btnImageOverlayFromFile";
            this.btnImageOverlayFromFile.Size = new System.Drawing.Size(109, 28);
            this.btnImageOverlayFromFile.TabIndex = 16;
            this.btnImageOverlayFromFile.Text = " load image...";
            this.btnImageOverlayFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImageOverlayFromFile.Click += new System.EventHandler(this.btnImageOverlayFromFile_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.ImageList1.Images.SetKeyName(0, "");
            // 
            // chkImageOverlayAlphaBlend
            // 
            this.chkImageOverlayAlphaBlend.Location = new System.Drawing.Point(139, 92);
            this.chkImageOverlayAlphaBlend.Name = "chkImageOverlayAlphaBlend";
            this.chkImageOverlayAlphaBlend.Size = new System.Drawing.Size(127, 21);
            this.chkImageOverlayAlphaBlend.TabIndex = 14;
            this.chkImageOverlayAlphaBlend.Text = "alpha blending:";
            this.chkImageOverlayAlphaBlend.CheckedChanged += new System.EventHandler(this.chkImageOverlayAlphaBlend_CheckedChanged);
            // 
            // chkImageOverlayUseTransparentColor
            // 
            this.chkImageOverlayUseTransparentColor.Location = new System.Drawing.Point(139, 73);
            this.chkImageOverlayUseTransparentColor.Name = "chkImageOverlayUseTransparentColor";
            this.chkImageOverlayUseTransparentColor.Size = new System.Drawing.Size(167, 20);
            this.chkImageOverlayUseTransparentColor.TabIndex = 12;
            this.chkImageOverlayUseTransparentColor.Text = "use transparent color:";
            this.chkImageOverlayUseTransparentColor.CheckedChanged += new System.EventHandler(this.chkImageOverlayUseTransparentColor_CheckedChanged);
            // 
            // chkImageOverlayEnabled
            // 
            this.chkImageOverlayEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkImageOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkImageOverlayEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkImageOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkImageOverlayEnabled.Location = new System.Drawing.Point(19, 18);
            this.chkImageOverlayEnabled.Name = "chkImageOverlayEnabled";
            this.chkImageOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageOverlayEnabled.Size = new System.Drawing.Size(84, 20);
            this.chkImageOverlayEnabled.TabIndex = 6;
            this.chkImageOverlayEnabled.Text = "enabled";
            this.chkImageOverlayEnabled.UseVisualStyleBackColor = false;
            this.chkImageOverlayEnabled.CheckedChanged += new System.EventHandler(this.chkImageOverlayEnabled_CheckedChanged);
            // 
            // chkImageOverlayTransparent
            // 
            this.chkImageOverlayTransparent.BackColor = System.Drawing.SystemColors.Control;
            this.chkImageOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkImageOverlayTransparent.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkImageOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkImageOverlayTransparent.Location = new System.Drawing.Point(139, 53);
            this.chkImageOverlayTransparent.Name = "chkImageOverlayTransparent";
            this.chkImageOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageOverlayTransparent.Size = new System.Drawing.Size(157, 21);
            this.chkImageOverlayTransparent.TabIndex = 5;
            this.chkImageOverlayTransparent.Text = "transparent";
            this.chkImageOverlayTransparent.UseVisualStyleBackColor = false;
            this.chkImageOverlayTransparent.CheckedChanged += new System.EventHandler(this.chkImageOverlayTransparent_CheckedChanged);
            // 
            // edtImageOverlayLeft
            // 
            this.edtImageOverlayLeft.AcceptsReturn = true;
            this.edtImageOverlayLeft.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayLeft.Font = new System.Drawing.Font("Arial", 8F);
            this.edtImageOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayLeft.Location = new System.Drawing.Point(23, 68);
            this.edtImageOverlayLeft.MaxLength = 0;
            this.edtImageOverlayLeft.Name = "edtImageOverlayLeft";
            this.edtImageOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayLeft.Size = new System.Drawing.Size(39, 23);
            this.edtImageOverlayLeft.TabIndex = 4;
            this.edtImageOverlayLeft.Text = "10";
            this.edtImageOverlayLeft.TextChanged += new System.EventHandler(this.edtImageOverlayLeft_TextChanged);
            // 
            // edtImageOverlayTop
            // 
            this.edtImageOverlayTop.AcceptsReturn = true;
            this.edtImageOverlayTop.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayTop.Font = new System.Drawing.Font("Arial", 8F);
            this.edtImageOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayTop.Location = new System.Drawing.Point(73, 68);
            this.edtImageOverlayTop.MaxLength = 0;
            this.edtImageOverlayTop.Name = "edtImageOverlayTop";
            this.edtImageOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayTop.Size = new System.Drawing.Size(40, 23);
            this.edtImageOverlayTop.TabIndex = 3;
            this.edtImageOverlayTop.Text = "10";
            this.edtImageOverlayTop.TextChanged += new System.EventHandler(this.edtImageOverlayTop_TextChanged);
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.BackColor = System.Drawing.SystemColors.Control;
            this.Label48.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label48.Font = new System.Drawing.Font("Arial", 8F);
            this.Label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label48.Location = new System.Drawing.Point(22, 53);
            this.Label48.Name = "Label48";
            this.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label48.Size = new System.Drawing.Size(27, 16);
            this.Label48.TabIndex = 10;
            this.Label48.Text = "left";
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.BackColor = System.Drawing.SystemColors.Control;
            this.Label49.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label49.Font = new System.Drawing.Font("Arial", 8F);
            this.Label49.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label49.Location = new System.Drawing.Point(70, 53);
            this.Label49.Name = "Label49";
            this.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label49.Size = new System.Drawing.Size(28, 16);
            this.Label49.TabIndex = 9;
            this.Label49.Text = "top";
            // 
            // btnPIP
            // 
            this.btnPIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPIP.ImageIndex = 0;
            this.btnPIP.ImageList = this.ImageList1;
            this.btnPIP.Location = new System.Drawing.Point(848, 35);
            this.btnPIP.Name = "btnPIP";
            this.btnPIP.Size = new System.Drawing.Size(264, 25);
            this.btnPIP.TabIndex = 51;
            this.btnPIP.Text = "PIP from another TVideoGrabber control";
            this.btnPIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPIP.Click += new System.EventHandler(this.btnPIP_Click);
            // 
            // chkTargetAtMouseLocation
            // 
            this.chkTargetAtMouseLocation.Location = new System.Drawing.Point(930, 9);
            this.chkTargetAtMouseLocation.Name = "chkTargetAtMouseLocation";
            this.chkTargetAtMouseLocation.Size = new System.Drawing.Size(182, 19);
            this.chkTargetAtMouseLocation.TabIndex = 52;
            this.chkTargetAtMouseLocation.Text = "target at mouse location";
            this.chkTargetAtMouseLocation.CheckedChanged += new System.EventHandler(this.chkTargetAtMouseLocation_CheckedChanged);
            // 
            // Overlays
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1335, 290);
            this.ControlBox = false;
            this.Controls.Add(this.chkAdjustOverlayAspectRatio);
            this.Controls.Add(this.chkTargetAtMouseLocation);
            this.Controls.Add(this.btnPIP);
            this.Controls.Add(this.grbDrawGrid);
            this.Controls.Add(this.grbTextOverlay);
            this.Controls.Add(this.grbFreeHand);
            this.Controls.Add(this.grbBitmapOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlays";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Overlays_Load);
            this.VisibleChanged += new System.EventHandler(this.Overlays_VisibleChanged);
            this.grbDrawGrid.ResumeLayout(false);
            this.grbDrawGrid.PerformLayout();
            this.grbTextOverlay.ResumeLayout(false);
            this.grbTextOverlay.PerformLayout();
            this.rdgTextOverlayAlign.ResumeLayout(false);
            this.rdgTextOverlayAlign.PerformLayout();
            this.grbOverlaySelector.ResumeLayout(false);
            this.grbFreeHand.ResumeLayout(false);
            this.grbBitmapOverlay.ResumeLayout(false);
            this.grbBitmapOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrChromaKeyLeeway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrImageOverlayAlphaBlending)).EndInit();
            this.grpImageOverlaySelector.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private  System.Windows.Forms.ToolTip ToolTip1;
        private  GroupBox grbDrawGrid;
        private  Button btnDrawGridColor;
        private  Label Label5;
        private  TextBox edtDrawGrid;
        private GroupBox grbTextOverlay;
        private TextBox edtTextOverlayLeft;
        private  Button btnSelectShadowColor;
        private  GroupBox grbOverlaySelector;
        private  RadioButton TextSelector4;
        private  RadioButton TextSelector3;
        private  RadioButton TextSelector2;
        private  RadioButton TextSelector1;
        private  RadioButton TextSelector0;
        private  Button btnBackColor;
        private  Button btnSelectFontColor;
        private  CheckBox chkTextOverlayShadow;
        private  Button btnSelectFont;
        private TextBox mmoTextOverlayString;
        private CheckBox chkTextOverlayEnabled;
        private TextBox edtTextOverlayTop;
        private TextBox edtTextOverlayRight;
        private CheckBox chkTextOverlayTransparent;
        private Label Label43;
        private GroupBox grbFreeHand;
        internal CheckBox chkFreeHandEnabled;
        private Button btnFreeHandErase;
        private  Button btnFreeHandColor;
        private GroupBox grbBitmapOverlay;
        private  TrackBar tbrChromaKeyLeeway;
        private  Label Label4;
        private  Label Label3;
        private  TextBox edtImageOverlayChromaKeyColorValue;
        private CheckBox chkImageOverlayChromaKey;
        private  TrackBar tbrImageOverlayAlphaBlending;
        private  Button btnImageOverlayPickupTransparentColorHelp;
        private  Button btnImageOverlayPickupTransparentColor;
        private  GroupBox grpImageOverlaySelector;
        private  RadioButton ImageSelector9;
        private  RadioButton ImageSelector8;
        private  RadioButton ImageSelector7;
        private  RadioButton ImageSelector6;
        private  RadioButton ImageSelector5;
        private  RadioButton ImageSelector4;
        private  RadioButton ImageSelector3;
        private  RadioButton ImageSelector2;
        private  RadioButton ImageSelector1;
        private  RadioButton ImageSelector0;
        private TextBox edtImageOverlayWidth;
        private TextBox edtImageOverlayHeight;
        private Label Label1;
        private Label Label2;
        private  TextBox edtImageOverlayTransparentColorValue;
        private  Button btnImageOverlayFromFile;
        private  CheckBox chkImageOverlayAlphaBlend;
        private  CheckBox chkImageOverlayUseTransparentColor;
        private CheckBox chkImageOverlayEnabled;
        private CheckBox chkImageOverlayTransparent;
        private TextBox edtImageOverlayLeft;
        private TextBox edtImageOverlayTop;
        private Label Label48;
        private Label Label49;
        private  ImageList ImageList1;
        private  Button btnPIP;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.CheckBox chkTargetAtMouseLocation;
        private CheckBox chkTextOverlayScrolling;
        private Label label7;
        private TextBox edtTextOverlayScrollingSpeed;
        private CheckBox chkAdjustOverlayAspectRatio;
        private RadioButton rdgTextOverlayAlignLeft;
        private RadioButton rdgTextOverlayAlignRight;
        private RadioButton rdgTextOverlayAlignCenter;
        private GroupBox rdgTextOverlayAlign;

        private VidGrab.VideoGrabber PIPVideoGrabber;

        private int m_ImageOverlayIndex = 0;
        private CheckBox chkHighResFont;
        private  Button btnTargetDisplayHelp;
        private  TextBox edtTextOverlayTargetDisplay;
        private Label label8;
        private  Button btn2TargetDisplayHelp;
        private  TextBox edtImageOverlayTargetDisplay;
        private Label label9;
        private int m_TextOverlayIndex = 0;
    }
}

