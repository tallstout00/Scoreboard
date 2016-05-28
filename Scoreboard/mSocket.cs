using System;
using System.Threading;
using System.Net.Sockets;

namespace Scoreboard
{
	public class mSocket
	{
		public mSocket ()
		{
			TcpListener serverSocket = new TcpListener (4444);
			TcpClient clientSocket = default(TcpClient);
			int counter = 0;
			serverSocket.Start ();
			Console.WriteLine (">> server started");
			counter = 0;
			while (true) {
				counter++;
				clientSocket = serverSocket.AcceptTcpClient ();
				Console.WriteLine (">> Client No: {0} started", counter);
				clientThread client = new clientThread ();
				client.startClient (clientSocket, counter);

			}
	}

	}

		public class clientThread
		{
			TcpClient clientSocket;
			TcpListener serverSocket;
			//int clno;

			public void startClient(TcpClient inClientSocket, int clino)
			{
				
				this.clientSocket = inClientSocket;
				//this.clno = clino;
			if (clino == 1) {
				Thread ctThread = new Thread (doChat1);
					ctThread.Start ();
			} else if (clino == 2) {
				Thread ctThread = new Thread (doChat2);
					ctThread.Start ();
			}else if (clino == 3) {
				Thread ctThread = new Thread (doChat3);
					ctThread.Start ();
			}else if (clino == 4) {
				Thread ctThread = new Thread (doChat4);
					ctThread.Start ();
			}

			}

		private void doChat1()
		{
			byte[] bytesFrom = new byte[10025];

			while (GlobalVar.comm1 != 5) {
				try{
					
					NetworkStream networkStream = clientSocket.GetStream();
					networkStream.Read(bytesFrom, 0, bytesFrom.Length);
					if(System.BitConverter.ToInt32(bytesFrom, 0) != 0){
						GlobalVar.comm1 = System.BitConverter.ToInt32(bytesFrom, 0);
						Console.WriteLine(">> Player 1: {0}", GlobalVar.comm1);
					}
						networkStream.Flush();
				}
				catch(Exception ex) {
					Console.WriteLine (">> " + ex.ToString ());
				}
			}
		}

		private void doChat2()
		{
			byte[] bytesFrom = new byte[10025];

			while (GlobalVar.comm2 != 5) {
				try{
					NetworkStream networkStream = clientSocket.GetStream();
					networkStream.Read(bytesFrom, 0, bytesFrom.Length);
					GlobalVar.comm1 = System.BitConverter.ToInt32(bytesFrom, 0);
					Console.WriteLine(">> Player 1: {0}", GlobalVar.comm2);
					networkStream.Flush();
				}
				catch(Exception ex) {
					Console.WriteLine (">> " + ex.ToString ());
				}
			}
		}

		private void doChat3()
		{
			byte[] bytesFrom = new byte[10025];

			while (GlobalVar.comm3 != 5) {
				try{
					NetworkStream networkStream = clientSocket.GetStream();
					networkStream.Read(bytesFrom, 0, bytesFrom.Length);
					GlobalVar.comm1 = System.BitConverter.ToInt32(bytesFrom,0);
					Console.WriteLine(">> Player 1: {0}", GlobalVar.comm3);
					networkStream.Flush();
				}
				catch(Exception ex) {
					Console.WriteLine (">> " + ex.ToString ());
				}
			}
		}

		private void doChat4()
		{
			byte[] bytesFrom = new byte[10025];

			while (GlobalVar.comm4 != 5) {
				try{
					NetworkStream networkStream = clientSocket.GetStream();
					networkStream.Read(bytesFrom, 0, bytesFrom.Length);
					GlobalVar.comm1 = System.BitConverter.ToInt32(bytesFrom, 0);
					Console.WriteLine(">> Player 1: {0}", GlobalVar.comm4);
					networkStream.Flush();
				}
				catch(Exception ex) {
					Console.WriteLine (">> " + ex.ToString ());
				}
			}
		}
	}
}


