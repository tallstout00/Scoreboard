using System;
using Gtk;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Scoreboard
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Thread appthread = new Thread (listener);
			appthread.Start ();
			Thread sdkthread = new Thread (sdkListener);
			sdkthread.Start ();
			Application.Run ();
		}
	


		public static void listener(){
			//The port numbers which each player will use
			int first = 4441,
			second = 4442,
			third = 4443,
			fourth = 4444;

			//Create instances for each player
			IPEndPoint player1 = new IPEndPoint (IPAddress.Any, first);
			IPEndPoint player2 = new IPEndPoint (IPAddress.Any, second);
			IPEndPoint player3 = new IPEndPoint (IPAddress.Any, third);
			IPEndPoint player4 = new IPEndPoint (IPAddress.Any, fourth);


			//Array of players 
			IPEndPoint[] players = new IPEndPoint[4] { player1, player2, 
				player3, player4 };
			ListenPorts lp = new ListenPorts (players);
			Console.WriteLine ("Begin Listen");
			lp.beginListen ();
		}

		public static void sdkListener(){
			//the port numbers for the car controls
			int first = 4451,
			second = 4452,
			third = 4453,
			fourth = 4454;

			//Create instances for each car
			IPEndPoint player1 = new IPEndPoint (IPAddress.Any, first);
			IPEndPoint player2 = new IPEndPoint (IPAddress.Any, second);
			IPEndPoint player3 = new IPEndPoint (IPAddress.Any, third);
			IPEndPoint player4 = new IPEndPoint (IPAddress.Any, fourth);

			//Array of players 
			IPEndPoint[] players = new IPEndPoint[4] { player1, player2, 
				player3, player4 };
			listenCars lp = new listenCars (players);
			Console.WriteLine ("Begin Listen");
			lp.beginListen ();
		}
	}
}
