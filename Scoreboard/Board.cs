using System;
using Scoreboard;
using System.Threading;
using System.Timers;
using System.Net.Sockets;
using Gtk;

namespace Scoreboard
{
	public partial class Board : Gtk.Window
	{

		System.Timers.Timer race;
		protected static DateTime start;
		protected static TimeSpan raceTime;
		protected static int lapPlayer1, lapPlayer2, lapPlayer3, lapPlayer4;
		protected static TimeSpan lap1, lap2, lap3, lap4;
		protected static DateTime lastLap1, lastLap2, lastLap3, lastLap4;
		protected int numOfPlayers;
		protected int[] PlayerPos = new int[4];

		Gdk.Pixbuf zero = new Gdk.Pixbuf ("./zero.bmp");
		Gdk.Pixbuf one = new Gdk.Pixbuf ("./one.bmp");
		Gdk.Pixbuf two = new Gdk.Pixbuf ("./two.bmp");
		Gdk.Pixbuf three = new Gdk.Pixbuf ("./three.bmp");
		Gdk.Pixbuf four = new Gdk.Pixbuf ("./four.bmp");
		Gdk.Pixbuf five = new Gdk.Pixbuf ("./five.bmp");
		Gdk.Pixbuf six = new Gdk.Pixbuf ("./six.bmp");
		Gdk.Pixbuf seven = new Gdk.Pixbuf ("./seven.bmp");
		Gdk.Pixbuf eight = new Gdk.Pixbuf ("./eight.bmp");
		Gdk.Pixbuf nine = new Gdk.Pixbuf ("./nine.bmp");

		public Board () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelName1.LabelProp = GlobalVar.player1;//set player names
			labelName2.LabelProp = GlobalVar.player2;
			labelName3.LabelProp = GlobalVar.player3;
			labelName4.LabelProp = GlobalVar.player4;

			DeleteEvent += OnDelete; 

			lapPlayer1 = 1;//initialize player lap numbers
			lapPlayer2 = 1;
			lapPlayer3 = 1;
			lapPlayer4 = 1;

			numOfPlayers = 1; //set number of players

			PlayerPos [0] = 1;
			if (GlobalVar.player2 != "NONE") {
				numOfPlayers++;
				PlayerPos [1] = 2;
			}
			if (GlobalVar.player3 != "NONE") {
				numOfPlayers++;
				PlayerPos [2] = 3;
			}
			if (GlobalVar.player4 != "NONE") {
				numOfPlayers++;
				PlayerPos [3] = 4;
			}


			race = new System.Timers.Timer (100);//set timer to track a 1/10 sec
			race.Elapsed += OnTimedEvent;
			race.Enabled = true;

			raceTime = new TimeSpan ();//set starting race time

		}



		private void OnDelete (object o, EventArgs args){
			race.Stop ();//stop the timer when the race ends
			race.Dispose ();
		}

		public void setLap(int playerNum, TimeSpan lap){

			switch (playerNum) {
			case 1:
				labelLap1.LabelProp = lap.ToString();
				break;
			case 2:
				labelLap2.LabelProp = lap.ToString();
				break;
			case 3:
				labelLap3.LabelProp = lap.ToString();
				break;
			case 4:
				labelLap4.LabelProp = lap.ToString();
				break;
			default:
				break;
			}

		}

		private void OnTimedEvent (object source, ElapsedEventArgs e){


			TimeSpan temp = new TimeSpan (0, 0, 0, 0, 100);//temp for incrementing timer by 100 miliseconds
			raceTime += temp;

			switch (raceTime.Milliseconds / 100) {
			case 0:
				this.imageMills.Pixbuf = zero;
				switch ((raceTime.Seconds) % 10) {
				case 0:
					this.imageSecOnes.Pixbuf = zero;
					switch ((raceTime.Seconds) / 10) {
					case 0:
						this.imageSecTens.Pixbuf = zero;
						switch ((raceTime.Minutes) % 10) {
						case 0:
							imageMinOnes.Pixbuf = zero;
							break;
						case 1:
							this.imageMinOnes.Pixbuf = one;
							break;
						case 2:
							this.imageMinOnes.Pixbuf = two;
							break;
						case 3:
							this.imageMinOnes.Pixbuf = three;
							break;
						case 4:
							this.imageMinOnes.Pixbuf = four;
							break;
						case 5:
							this.imageMinOnes.Pixbuf = five;
							break;
						case 6:
							this.imageMinOnes.Pixbuf = six;
							break;
						case 7:
							this.imageMinOnes.Pixbuf = seven;
							break;
						case 8:
							this.imageMinOnes.Pixbuf = eight;
							break;
						case 9:
							this.imageMinOnes.Pixbuf = nine;
							break;
						}
						break;
					case 1:
						imageSecTens.Pixbuf = one;
						break;
					case 2:
						this.imageSecTens.Pixbuf = two;
						break;
					case 3:
						this.imageSecTens.Pixbuf = three;
						break;
					case 4:
						this.imageSecTens.Pixbuf = four;
						break;
					case 5:
						this.imageSecTens.Pixbuf = five;
						break;
					case 6:
						this.imageSecTens.Pixbuf = six;
						break;
					case 7:
						this.imageSecTens.Pixbuf = seven;
						break;
					case 8:
						this.imageSecTens.Pixbuf = eight;
						break;
					case 9:
						this.imageSecTens.Pixbuf = nine;
						break;
					}
					break;
				case 1:
					imageSecOnes.Pixbuf = one;
					break;
				case 2:
					this.imageSecOnes.Pixbuf = two;
					break;
				case 3:
					this.imageSecOnes.Pixbuf = three;
					break;
				case 4:
					this.imageSecOnes.Pixbuf = four;
					break;
				case 5:
					this.imageSecOnes.Pixbuf = five;
					break;
				case 6:
					this.imageSecOnes.Pixbuf = six;
					break;
				case 7:
					this.imageSecOnes.Pixbuf = seven;
					break;
				case 8:
					this.imageSecOnes.Pixbuf = eight;
					break;
				case 9:
					this.imageSecOnes.Pixbuf = nine;
					break;
				}
				break;
			case 1:
				this.imageMills.Pixbuf = one;
				break;
			case 2:
				this.imageMills.Pixbuf = two;
				break;
			case 3:
				this.imageMills.Pixbuf = three;
				break;
			case 4:
				this.imageMills.Pixbuf = four;
				break;
			case 5:
				this.imageMills.Pixbuf = five;
				break;
			case 6:
				this.imageMills.Pixbuf = six;
				break;
			case 7:
				this.imageMills.Pixbuf = seven;
				break;
			case 8:
				this.imageMills.Pixbuf = eight;
				break;
			case 9:
				this.imageMills.Pixbuf = nine;
				break;
			}
		}

		public void lapP1 (){
			DateTime now = DateTime.Now;
			TimeSpan temp = now - lastLap1;
			if (lapPlayer1 > 1) {
				if (lap1 > temp)
					lap1 = (temp);
			}
			else {
				lap1 = raceTime;
			}
			lastLap1 = now;
			lapPlayer1++;
			if (lapPlayer1 > GlobalVar.numLaps) {
				win (1);
			}
			labelLapNum1.LabelProp = lapPlayer1.ToString(); //update scoreboard lap num
			labelLap1.LabelProp = lap1.ToString();
			playerPos ();

		}

		public void lapP2 (){
			DateTime now = DateTime.Now;
			TimeSpan temp = now - lastLap2;
			if (lapPlayer2 > 1) {
				if (lap2 > temp)
					lap2 = (temp);  //better lap than before, update
			}
			else {
				lap2 = raceTime;  //only one lap, create best time
			}
			lastLap2 = now;
			lapPlayer2++;
			if (lapPlayer2 > GlobalVar.numLaps) {
				win (2);
			}
			labelLapNum2.LabelProp = lapPlayer2.ToString(); //update scoreboard lap num
			labelLap2.LabelProp = lap2.ToString();//update best time
			playerPos();

		}

		public void lapP3 (){
			DateTime now = DateTime.Now;
			TimeSpan temp = now - lastLap3;
			if (lapPlayer3 > 1) {
				if (lap3 > temp)
					lap3 = (temp);
			}
			else {
				lap3 = raceTime;
			}
			lastLap3 = now;
			lapPlayer3++;
			if (lapPlayer3 > GlobalVar.numLaps) {
				win (3);
			}
			labelLapNum3.LabelProp = lapPlayer3.ToString(); //update scoreboard lap num
			labelLap3.LabelProp = lap3.ToString();
			playerPos ();

		}

		public void lapP4 (){
			DateTime now = DateTime.Now;
			TimeSpan temp = now - lastLap4;
			if (lapPlayer4 > 1) {
					lap4 = (temp);
			}
			else {
				lap4 = raceTime;
			}
			lastLap4 = now;
			lapPlayer4++;
			if (lapPlayer4 > GlobalVar.numLaps) {
				win (4);
			}
			labelLapNum4.LabelProp = lapPlayer4.ToString(); //update scoreboard lap num
			labelLap4.LabelProp = lap4.ToString();
			playerPos ();

		}

		protected void win(int player){
			string winner;
			winner = "Player number " + player.ToString () + " wins!!!";
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, 
				MessageType.Info, ButtonsType.Ok, 
				winner);
			md.Run ();
			md.Destroy ();
			race.Stop ();
			race.Dispose ();
			this.Hide ();
		}

		protected void playerPos(){


			int i, j, swap;
			Gtk.Label temp;
			for(int x = 0; x <= (numOfPlayers - 1); x++){//compare all existing values
				for (int y = (x+1); y < numOfPlayers; y++) {
					i = getPlayerLap(PlayerPos[x]);
					j = getPlayerLap (PlayerPos [y]);
					if (i < j) {
						swap = PlayerPos [x];
						PlayerPos [x] = PlayerPos[y];
						PlayerPos [y] = swap;
					}
				}


			}
			//set player position labels
			temp = getPlayerLabel (PlayerPos[0]);
			temp.LabelProp = "1";
			if (numOfPlayers >= 2) {
				temp = getPlayerLabel (PlayerPos [1]);
				temp.LabelProp = "2";
			}
			if (numOfPlayers >= 3) {
				temp = getPlayerLabel (PlayerPos [2]);
				temp.LabelProp = "3";
			}
			if (numOfPlayers == 4){
				temp = getPlayerLabel (PlayerPos [3]);
				temp.LabelProp = "4";
			}

		}

		protected int getPlayerLap(int num){
			switch (num) {
			case 1:
				return lapPlayer1;
			case 2:
				return lapPlayer2;
			case 3:
				return lapPlayer3;
			case 4:
				return lapPlayer4;
			}
			return 0;
		}

		protected DateTime getPlayerTime(int num){
			switch(num){
			case 1:
				return lastLap1;
			case 2:
				return lastLap2;
			case 3:
				return lastLap3;
			case 4:
				return lastLap4;

			}
			return DateTime.MinValue;
		}

		protected Gtk.Label getPlayerLabel (int num){
			switch (num) {
			case 1:
				return labelPos1;
			case 2:
				return labelPos2;
			case 3:
				return labelPos3;
			case 4:
				return labelPos4;
			}
			return new Gtk.Label ("nil");
		}
	}
}

