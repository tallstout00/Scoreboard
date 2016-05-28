using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Scoreboard;

class ListenPorts
{
	Socket[] serverSocket;	//Server socket declaration
	IPEndPoint[] players;	//Players network declaration

	public ListenPorts(IPEndPoint[] players)
	{
		this.players = players;
		serverSocket = new Socket[players.Length];
	}

	//Iterate through each "player" array and create a socket for each one
	public void beginListen()
	{
		for (int i = 0; i < players.Length; i++)
		{
			serverSocket[i] = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			serverSocket[i].Bind(players[i]);
			Thread thread = new Thread(threadListen);
			thread.Start(serverSocket[i]);
		}
	}

	//Thread function to be used for the different ports
	public void threadListen(object objs)
	{
		Socket serverSocket = objs as Socket;
		int playerNumber;
		playerNumber = getPlayer (serverSocket);
		byte[] command = new byte[1024];
		IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
		EndPoint Remote = (EndPoint)(sender);

		//Print the command sent from the app and the ip address
		while(true)
		{
			serverSocket.Listen(4);
			Socket client = serverSocket.Accept();
			client.ReceiveFrom(command, ref Remote);
			setComm (playerNumber, System.BitConverter.ToInt32 (command, 0));
			Console.WriteLine ("Command Received {0} from {1} ", System.BitConverter.ToInt32 (command, 0), playerNumber.ToString());

		}
	}

	protected int getPlayer(Socket player){
		if (player.Equals (serverSocket [0])) {
			return 1;
		} else if (player.Equals (serverSocket [1])) {
			return 2;
		} else if (player.Equals (serverSocket [2])) {
			return 3;
		} else if (player.Equals (serverSocket [3])) {
			return 4;
		} else
			return 0;
	}

	protected void setComm(int player, int command){
		switch (player) {
		case 1:
			GlobalVar.comm1 = command;
			break;
		case 2:
			GlobalVar.comm2 = command;
			break;
		case 3:
			GlobalVar.comm3 = command;
			break;
		case 4:
			GlobalVar.comm4 = command;
			Console.WriteLine("test Command Received {0} from {1}", GlobalVar.comm4.ToString(), player.ToString());
			break;
		}
	}
}

	class listenCars{
		Socket[] serverSocket;	//Server socket declaration
		IPEndPoint[] players;	//Players network declaration

		public listenCars(IPEndPoint[] players)
		{
			this.players = players;
			serverSocket = new Socket[players.Length];
		}

		//Iterate through each "player" array and create a socket for each one
		public void beginListen()
		{
			for (int i = 0; i < players.Length; i++)
			{
				serverSocket[i] = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				serverSocket[i].Bind(players[i]);
				Thread thread = new Thread(threadListen);
				thread.Start(serverSocket[i]);
			}
		}

		//Thread function to be used for the different ports
		public void threadListen(object objs)
		{
			Socket serverSocket = objs as Socket;
			int playerNumber;
			int controlI;
			playerNumber = getPlayer (serverSocket);
			byte[] command = new byte[1024];
			byte[] control = new byte[1024];
			IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
			EndPoint Remote = (EndPoint)(sender);

			//Print the command sent from the app and the ip address
			while(true)
			{
				serverSocket.Listen(4);
				Socket client = serverSocket.Accept();
				client.ReceiveFrom(command, ref Remote);
				setComm (playerNumber, System.BitConverter.ToInt32 (command, 0));
				controlI = getComm (playerNumber);
				if (controlI != 0) {
					control = BitConverter.GetBytes (controlI);
					client.SendTo (control, Remote);
				}
				Console.WriteLine ("Command Received {0} from {1} ", 
				System.BitConverter.ToInt32 (command, 0), playerNumber.ToString());

			}
		}

	protected int getComm(int player){
		switch (player) {
		case 1:
			return GlobalVar.send1;
		case 2:
			return GlobalVar.send2;
		case 3:
			return GlobalVar.send3;
		case 4:
			return GlobalVar.send4;
		}
		return 0;
	}

		protected int getPlayer(Socket player){
			if (player.Equals (serverSocket [0])) {
				return 1;
			} else if (player.Equals (serverSocket [1])) {
				return 2;
			} else if (player.Equals (serverSocket [2])) {
				return 3;
			} else if (player.Equals (serverSocket [3])) {
				return 4;
			} else
				return 0;
		}

		protected void setComm(int player, int command){
			switch (player) {
			case 1:
				GlobalVar.comm1 = command;
				break;
			case 2:
				GlobalVar.comm2 = command;
				break;
			case 3:
				GlobalVar.comm3 = command;
				break;
			case 4:
				GlobalVar.comm4 = command;
				//Console.WriteLine("test Command Received {0} from {1}", GlobalVar.comm4.ToString(), player.ToString());
				break;
			}
	}
}