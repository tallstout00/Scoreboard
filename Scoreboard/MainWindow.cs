using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		Scoreboard.Player play = new Scoreboard.Player ();
		play.Show ();
	}

	protected void OnButton5Clicked (object sender, EventArgs e)
	{
		if (Scoreboard.GlobalVar.player1 != "NONE") {
			Scoreboard.Board game = new Scoreboard.Board ();
			game.Show ();
			Scoreboard.TestingWindow testing = new Scoreboard.TestingWindow(game);
			testing.Show();
		} else {
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "You need at least one player to play a game!");
			md.Run ();
			md.Destroy ();
		}
	}

	protected void OnButton6Clicked (object sender, EventArgs e)
	{
		Scoreboard.Settings sets = new Scoreboard.Settings ();
		sets.Show ();
	}
}
