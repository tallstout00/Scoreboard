using System;
using Scoreboard;


namespace Scoreboard
{
	public partial class Settings : Gtk.Window
	{
		public Settings () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}

		protected void OnSpinbuttonLapsChanged (object sender, EventArgs e)
		{
			GlobalVar.numLaps = ((int)spinbuttonLaps.Value);
		}
	}
}

