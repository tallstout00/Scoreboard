using System;
using Scoreboard;
using Gtk;

namespace Scoreboard
{
	public partial class Player : Gtk.Window
	{

		int currentPlayer;

		public Player () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			currentPlayer = 1;
		}

		protected void OnButtonQClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "Q";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "Q";
		}

		protected void OnButtonWClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "W";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "W";		}

		protected void OnButtonEClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "E";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "E";		}

		protected void OnButtonRClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "R";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "R";		}

		protected void OnButtonTClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "T";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "T";		}

		protected void OnButtonYClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "Y";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "Y";		}

		protected void OnButtonUClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "U";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "U";
		}

		protected void OnButtonIClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "I";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "I";		}

		protected void OnButtonOClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "O";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "O";		}

		protected void OnButtonPClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "P";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "P";		}

		protected void OnButtonAClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "A";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "A";		}

		protected void OnButtonSClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "S";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "S";		}

		protected void OnButtonDClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "D";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "D";		}

		protected void OnButtonFClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "F";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "F";		}

		protected void OnButtonGClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "G";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "G";		}

		protected void OnButtonHClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "H";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "H";
		}

		protected void OnButtonJClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "J";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "J";		}

		protected void OnButtonKClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "K";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "K";		}

		protected void OnButtonLClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "L";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "L";	}

		protected void OnButtonZClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "Z";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "Z";		}

		protected void OnButtonXClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "X";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "X";		}

		protected void OnButtonCClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "C";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "C";		}

		protected void OnButtonVClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "V";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "V";		}

		protected void OnButtonBClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "B";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "B";		}

		protected void OnButtonNClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "N";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "N";		}

		protected void OnButtonMClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = "M";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + "M";		}

		protected void OnButtonSpaceClicked (object sender, EventArgs e)
		{
			if (textview1.Buffer.Text == "Enter player name" || textview1.Buffer.Text == "NONE")
				textview1.Buffer.Text = " ";
			else
				textview1.Buffer.Text = textview1.Buffer.Text + " ";		}

		protected void OnButtonkNoneClicked (object sender, EventArgs e)
		{
			textview1.Buffer.Text = "NONE";
		}

		protected void OnButtonBKSpaceClicked (object sender, EventArgs e)
		{
			
			if (textview1.Buffer.Text != "NONE" && textview1.Buffer.Text != "Enter player name" && textview1.Buffer.Text != "")
				textview1.Buffer.Text = textview1.Buffer.Text.Remove(textview1.Buffer.Text.Length - 1);		}

		protected void assignName(int nextPlayer)
		{
			switch (currentPlayer) {//store previous entry

			case 1:
				GlobalVar.player1 = textview1.Buffer.Text;
				break;
			case 2:
				GlobalVar.player2 = textview1.Buffer.Text;
				break;
			case 3:
				GlobalVar.player3 = textview1.Buffer.Text;
				break;
			case 4:
				GlobalVar.player4 = textview1.Buffer.Text;
				break;
			}
			currentPlayer = nextPlayer;//set selected player

			switch (currentPlayer) {//put selected player value into the textview
				
			case 1:
				textview1.Buffer.Text = GlobalVar.player1;
				break;
			case 2:
				textview1.Buffer.Text = GlobalVar.player2;
				break;
			case 3:
				textview1.Buffer.Text = GlobalVar.player3;
				break;
			case 4:
				textview1.Buffer.Text = GlobalVar.player4;
				break;
			}
		}

		protected void OnButtonPlay1Clicked (object sender, EventArgs e)
		{
			assignName (1);
			buttonPlay1.Relief = Gtk.ReliefStyle.None;
			buttonPlay2.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay3.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay4.Relief = Gtk.ReliefStyle.Normal;
		}

		protected void OnButtonPlay2Clicked (object sender, EventArgs e)
		{
			assignName (2);
			buttonPlay1.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay2.Relief = Gtk.ReliefStyle.None;
			buttonPlay3.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay4.Relief = Gtk.ReliefStyle.Normal;
		}

		protected void OnButtonPlay3Clicked (object sender, EventArgs e)
		{
			assignName (3);
			buttonPlay1.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay2.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay3.Relief = Gtk.ReliefStyle.None;
			buttonPlay4.Relief = Gtk.ReliefStyle.Normal;
		}

		protected void OnButtonPlay4Clicked (object sender, EventArgs e)
		{
			assignName (4);
			buttonPlay1.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay2.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay3.Relief = Gtk.ReliefStyle.Normal;
			buttonPlay4.Relief = Gtk.ReliefStyle.None;
		}

		protected void OnButtonReturnClicked (object sender, EventArgs e)
		{
			if(GlobalVar.player2 == "NONE" && (GlobalVar.player3 != "NONE" || GlobalVar.player4 !="NONE")){
				MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "You can't skip a player!");
				md.Run ();
				md.Destroy ();
			}
			else if(GlobalVar.player3 == "NONE" && GlobalVar.player4 != "NONE"){
				MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "You can't skip a player!");
				md.Run ();
				md.Destroy ();
			}
			else{
			assignName (currentPlayer);
			this.Hide ();
			}
		}
	}
}