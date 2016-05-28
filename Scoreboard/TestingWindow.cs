using System;

namespace Scoreboard
{
	
	public partial class TestingWindow : Gtk.Window
	{

		Scoreboard.Board game; 

		public TestingWindow (Scoreboard.Board board) :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			game = board;
		}

		public void OnButtonLapP1Clicked (object sender, EventArgs e)
		{
			game.lapP1 ();

		}

		protected void OnButton6Clicked (object sender, EventArgs e)
		{
			game.lapP2();
		}

		protected void OnButton7Clicked (object sender, EventArgs e)
		{
			game.lapP3();
		}

		protected void OnButton8Clicked (object sender, EventArgs e)
		{
			game.lapP4();
		}
	}
}

