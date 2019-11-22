using MouseKeyboardLibrary;
using System;
using System.Windows.Forms;

namespace Mouse3Emulator
{
	public partial class MainForm : Form
	{
		private readonly KeyboardHook keyboardHook = new KeyboardHook();

		public MainForm()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.keyboardHook.KeyDown += new KeyEventHandler(this.keyboardHook_KeyDown);
			this.keyboardHook.Start();
		}

		private void keyboardHook_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.BrowserForward || e.KeyCode == Keys.A)
			if (e.KeyCode == Keys.BrowserForward)
			{
				MouseSimulator.Click(MouseButton.Middle);
				//KeyboardSimulator.KeyPress(Keys.B);
				e.Handled = true;
			}
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			this.Hide();
		}

		private void miQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
