using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public class miscDVCommands : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
	{
		internal System.Windows.Forms.GroupBox grbDVCommands;
		internal System.Windows.Forms.Button btnPlaySlowestRev;
		internal System.Windows.Forms.Button btnPlayFastestRev;
		internal System.Windows.Forms.Button btnPlaySlowestFwd;
		internal System.Windows.Forms.Button btnPlayFastestFwd;
		internal System.Windows.Forms.Button btnModeShuttle;
		internal System.Windows.Forms.Button btnStepRev;
		internal System.Windows.Forms.Button btnStepFwd;
		internal System.Windows.Forms.Button btnRecordStrobe;
		internal System.Windows.Forms.Button btnRecordFreeze;
		internal System.Windows.Forms.Button btnRecord;
		internal System.Windows.Forms.Button btnRew;
		internal System.Windows.Forms.Button btnFF;
		internal System.Windows.Forms.Button btnThaw;
		internal System.Windows.Forms.Button btnFreeze;
		internal System.Windows.Forms.Button btnStop;
		internal System.Windows.Forms.Button btnPlay;
		private System.ComponentModel.Container components = null;
        private VidGrab.VideoGrabber  VideoGrabber = MainForm.cMainForm.VideoGrabber1;      

		public miscDVCommands()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grbDVCommands = new System.Windows.Forms.GroupBox();
			this.btnPlaySlowestRev = new System.Windows.Forms.Button();
			this.btnPlayFastestRev = new System.Windows.Forms.Button();
			this.btnPlaySlowestFwd = new System.Windows.Forms.Button();
			this.btnPlayFastestFwd = new System.Windows.Forms.Button();
			this.btnModeShuttle = new System.Windows.Forms.Button();
			this.btnStepRev = new System.Windows.Forms.Button();
			this.btnStepFwd = new System.Windows.Forms.Button();
			this.btnRecordStrobe = new System.Windows.Forms.Button();
			this.btnRecordFreeze = new System.Windows.Forms.Button();
			this.btnRecord = new System.Windows.Forms.Button();
			this.btnRew = new System.Windows.Forms.Button();
			this.btnFF = new System.Windows.Forms.Button();
			this.btnThaw = new System.Windows.Forms.Button();
			this.btnFreeze = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.grbDVCommands.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbDVCommands
			// 
			this.grbDVCommands.Controls.Add(this.btnPlaySlowestRev);
			this.grbDVCommands.Controls.Add(this.btnPlayFastestRev);
			this.grbDVCommands.Controls.Add(this.btnPlaySlowestFwd);
			this.grbDVCommands.Controls.Add(this.btnPlayFastestFwd);
			this.grbDVCommands.Controls.Add(this.btnModeShuttle);
			this.grbDVCommands.Controls.Add(this.btnStepRev);
			this.grbDVCommands.Controls.Add(this.btnStepFwd);
			this.grbDVCommands.Controls.Add(this.btnRecordStrobe);
			this.grbDVCommands.Controls.Add(this.btnRecordFreeze);
			this.grbDVCommands.Controls.Add(this.btnRecord);
			this.grbDVCommands.Controls.Add(this.btnRew);
			this.grbDVCommands.Controls.Add(this.btnFF);
			this.grbDVCommands.Controls.Add(this.btnThaw);
			this.grbDVCommands.Controls.Add(this.btnFreeze);
			this.grbDVCommands.Controls.Add(this.btnStop);
			this.grbDVCommands.Controls.Add(this.btnPlay);
			this.grbDVCommands.Location = new System.Drawing.Point(8, 8);
			this.grbDVCommands.Name = "grbDVCommands";
			this.grbDVCommands.Size = new System.Drawing.Size(528, 152);
			this.grbDVCommands.TabIndex = 17;
			this.grbDVCommands.TabStop = false;
			this.grbDVCommands.Text = "Send DV commands";
			// 
			// btnPlaySlowestRev
			// 
			this.btnPlaySlowestRev.Location = new System.Drawing.Point(400, 120);
			this.btnPlaySlowestRev.Name = "btnPlaySlowestRev";
			this.btnPlaySlowestRev.Size = new System.Drawing.Size(120, 24);
			this.btnPlaySlowestRev.TabIndex = 31;
			this.btnPlaySlowestRev.Text = "Play slowest rev";
			this.btnPlaySlowestRev.Click += new System.EventHandler(this.btnPlaySlowestRev_Click);
			// 
			// btnPlayFastestRev
			// 
			this.btnPlayFastestRev.Location = new System.Drawing.Point(272, 120);
			this.btnPlayFastestRev.Name = "btnPlayFastestRev";
			this.btnPlayFastestRev.Size = new System.Drawing.Size(120, 24);
			this.btnPlayFastestRev.TabIndex = 30;
			this.btnPlayFastestRev.Text = "Play fastest rev";
			this.btnPlayFastestRev.Click += new System.EventHandler(this.btnPlayFastestRev_Click);
			// 
			// btnPlaySlowestFwd
			// 
			this.btnPlaySlowestFwd.Location = new System.Drawing.Point(144, 120);
			this.btnPlaySlowestFwd.Name = "btnPlaySlowestFwd";
			this.btnPlaySlowestFwd.Size = new System.Drawing.Size(120, 24);
			this.btnPlaySlowestFwd.TabIndex = 29;
			this.btnPlaySlowestFwd.Text = "Play slowest fwd";
			this.btnPlaySlowestFwd.Click += new System.EventHandler(this.btnPlaySlowestFwd_Click);
			// 
			// btnPlayFastestFwd
			// 
			this.btnPlayFastestFwd.Location = new System.Drawing.Point(16, 120);
			this.btnPlayFastestFwd.Name = "btnPlayFastestFwd";
			this.btnPlayFastestFwd.Size = new System.Drawing.Size(120, 24);
			this.btnPlayFastestFwd.TabIndex = 28;
			this.btnPlayFastestFwd.Text = "Play fastest fwd";
			this.btnPlayFastestFwd.Click += new System.EventHandler(this.btnPlayFastestFwd_Click);
			// 
			// btnModeShuttle
			// 
			this.btnModeShuttle.Location = new System.Drawing.Point(400, 88);
			this.btnModeShuttle.Name = "btnModeShuttle";
			this.btnModeShuttle.Size = new System.Drawing.Size(120, 24);
			this.btnModeShuttle.TabIndex = 27;
			this.btnModeShuttle.Text = "Mode Shhuttle";
			this.btnModeShuttle.Click += new System.EventHandler(this.btnModeShuttle_Click);
			// 
			// btnStepRev
			// 
			this.btnStepRev.Location = new System.Drawing.Point(272, 88);
			this.btnStepRev.Name = "btnStepRev";
			this.btnStepRev.Size = new System.Drawing.Size(120, 24);
			this.btnStepRev.TabIndex = 26;
			this.btnStepRev.Text = "Step Rev";
			this.btnStepRev.Click += new System.EventHandler(this.btnStepRev_Click);
			// 
			// btnStepFwd
			// 
			this.btnStepFwd.Location = new System.Drawing.Point(144, 88);
			this.btnStepFwd.Name = "btnStepFwd";
			this.btnStepFwd.Size = new System.Drawing.Size(120, 24);
			this.btnStepFwd.TabIndex = 25;
			this.btnStepFwd.Text = "Step Fwd";
			this.btnStepFwd.Click += new System.EventHandler(this.btnStepFwd_Click);
			// 
			// btnRecordStrobe
			// 
			this.btnRecordStrobe.Location = new System.Drawing.Point(16, 88);
			this.btnRecordStrobe.Name = "btnRecordStrobe";
			this.btnRecordStrobe.Size = new System.Drawing.Size(120, 24);
			this.btnRecordStrobe.TabIndex = 24;
			this.btnRecordStrobe.Text = "Record strobe";
			this.btnRecordStrobe.Click += new System.EventHandler(this.btnRecordStrobe_Click);
			// 
			// btnRecordFreeze
			// 
			this.btnRecordFreeze.Location = new System.Drawing.Point(400, 56);
			this.btnRecordFreeze.Name = "btnRecordFreeze";
			this.btnRecordFreeze.Size = new System.Drawing.Size(120, 24);
			this.btnRecordFreeze.TabIndex = 23;
			this.btnRecordFreeze.Text = "Record freeze";
			this.btnRecordFreeze.Click += new System.EventHandler(this.btnRecordFreeze_Click);
			// 
			// btnRecord
			// 
			this.btnRecord.Location = new System.Drawing.Point(272, 56);
			this.btnRecord.Name = "btnRecord";
			this.btnRecord.Size = new System.Drawing.Size(120, 24);
			this.btnRecord.TabIndex = 22;
			this.btnRecord.Text = "Record";
			this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
			// 
			// btnRew
			// 
			this.btnRew.Location = new System.Drawing.Point(144, 56);
			this.btnRew.Name = "btnRew";
			this.btnRew.Size = new System.Drawing.Size(120, 24);
			this.btnRew.TabIndex = 21;
			this.btnRew.Text = "Rewind";
			this.btnRew.Click += new System.EventHandler(this.btnRew_Click);
			// 
			// btnFF
			// 
			this.btnFF.Location = new System.Drawing.Point(16, 56);
			this.btnFF.Name = "btnFF";
			this.btnFF.Size = new System.Drawing.Size(120, 24);
			this.btnFF.TabIndex = 20;
			this.btnFF.Text = "FF";
			this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
			// 
			// btnThaw
			// 
			this.btnThaw.Location = new System.Drawing.Point(400, 24);
			this.btnThaw.Name = "btnThaw";
			this.btnThaw.Size = new System.Drawing.Size(120, 24);
			this.btnThaw.TabIndex = 19;
			this.btnThaw.Text = "Thaw";
			this.btnThaw.Click += new System.EventHandler(this.btnThaw_Click);
			// 
			// btnFreeze
			// 
			this.btnFreeze.Location = new System.Drawing.Point(272, 24);
			this.btnFreeze.Name = "btnFreeze";
			this.btnFreeze.Size = new System.Drawing.Size(120, 24);
			this.btnFreeze.TabIndex = 18;
			this.btnFreeze.Text = "Freeze";
			this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(144, 24);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(120, 24);
			this.btnStop.TabIndex = 17;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(16, 24);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(120, 24);
			this.btnPlay.TabIndex = 16;
			this.btnPlay.Text = "Play";
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// miscDVCommands
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 165);
			this.Controls.Add(this.grbDVCommands);
			this.Name = "miscDVCommands";
			this.Text = "Send commands to the DV camcorder";
			this.VisibleChanged += new System.EventHandler(this.miscDVCommands_VisibleChanged);
			this.grbDVCommands.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public void RefreshDisplayOptions()
		{
			grbDVCommands.Enabled = cMainForm.VideoGrabber1.IsDigitalVideoIn;
		}
		
		private void SendDVCommand(VidGrab.TDVCommand DvCommand)
		{
			if (cMainForm.VideoGrabber1.SendDVCommand(DvCommand))
			{
				AddLog(cMainForm.mmoLog, "DV command sent...");
			}
			else 
			{
				if ((cMainForm.VideoGrabber1.CurrentState != VidGrab.TCurrentState.cs_Preview) && (cMainForm.VideoGrabber1.CurrentState != VidGrab.TCurrentState.cs_Recording)) 
				{
					AddLog(cMainForm.mmoLog, "DV command failed. Preview must be running!");
				}
				else
				{
					AddLog(cMainForm.mmoLog, "DV command failed.");
				}
			}
		}

		private void btnPlay_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Play);
		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Stop);
		}

		private void btnFreeze_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Freeze);
		}

		private void btnThaw_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Thaw);
		}

		private void btnFF_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Ff);
		}

		private void btnRew_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Rew);
		}

		private void btnRecord_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_Record);
		}

		private void btnRecordFreeze_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_RecordFreeze);
		}

		private void btnRecordStrobe_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_RecordStrobe);
		}

		private void btnStepFwd_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_StepFwd);
		}

		private void btnStepRev_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_StepRev);
		}

		private void btnModeShuttle_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_ModeShuttle);
		}

		private void btnPlayFastestFwd_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_PlayFastestFwd);
		}

		private void btnPlaySlowestFwd_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_PlaySlowestFwd);
		}

		private void btnPlayFastestRev_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_PlayFastestRev);
		}

		private void btnPlaySlowestRev_Click(object sender, System.EventArgs e)
		{
			SendDVCommand(VidGrab.TDVCommand.dv_PlaySlowestRev);
		}

		private void miscDVCommands_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}
	}
}
