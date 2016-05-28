using System;
using System.Net.Sockets;
using Scoreboard;

namespace Scoreboard
{
	public class SSocket
	{
		public SSocket (int port, int players)
		{
			TcpListener	serverSocket = new TcpListener (port);
			int requestCount;
			TcpClient clientSocket = default(TcpClient);
			serverSocket.Start ();
			Console.WriteLine (" >>Server started");
			clientSocket = serverSocket.AcceptTcpClient ();
			Console.WriteLine (" >>Accept connection from client");
			requestCount++;
			byte[] bytesFrom = new byte[10025];

			while (comm != 5) {
				try
				{
					//requestCount++;
					clientSocket = serverSocket.AcceptTcpClient ();
					NetworkStream networkStream = clientSocket.GetStream();
					var max_size = Math.Min(clientSocket.ReceiveBufferSize, bytesFrom.Length);
					networkStream.Read(bytesFrom, 0, max_size);
					if(System.BitConverter.ToInt32(bytesFrom,0) != 0){
						comm = System.BitConverter.ToInt32(bytesFrom,0);
						Console.WriteLine(">> from client: " + comm.ToString());
					}
					networkStream.Flush();
				}
				catch(Exception ex)
				{
					Console.WriteLine (ex.ToString ());
				}
			}
			clientSocket.Close ();
			serverSocket.Stop ();
			Console.WriteLine (" >> exit");
		}
	}
}

