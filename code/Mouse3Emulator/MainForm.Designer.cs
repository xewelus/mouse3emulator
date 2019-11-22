namespace Mouse3Emulator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.cmNotify.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.cmNotify;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Mouse 3 Emulator";
			this.notifyIcon.Visible = true;
			// 
			// cmNotify
			// 
			this.cmNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miQuit});
			this.cmNotify.Name = "cmNotify";
			this.cmNotify.Size = new System.Drawing.Size(110, 26);
			// 
			// miQuit
			// 
			this.miQuit.Name = "miQuit";
			this.miQuit.Size = new System.Drawing.Size(109, 22);
			this.miQuit.Text = "Выйти";
			this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(120, 23);
			this.ControlBox = false;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.cmNotify.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip cmNotify;
		private System.Windows.Forms.ToolStripMenuItem miQuit;
	}
}

