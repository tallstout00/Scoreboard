using System;
using System.Threading;

namespace Scoreboard
{
	public static class GlobalVar
	{
		static private Object commLock1 = new object ();
		static private Object commLock2 = new object ();
		static private Object commLock3 = new object ();
		static private Object commLock4 = new object ();

		static private Object sendLock1 = new object ();
		static private Object sendLock2 = new object ();
		static private Object sendLock3 = new object ();
		static private Object sendLock4 = new object ();

		static string _player1 = "NONE";
		static string _player2 = "NONE";
		static string _player3 = "NONE";
		static string _player4 = "NONE";

		static int _comm1 = 0;
		static int _comm2 = 0;
		static int _comm3 = 0;
		static int _comm4 = 0;

		static int _send1 = 0;
		static int _send2 = 0;
		static int _send3 = 0;
		static int _send4 = 0;

		static int _numLaps = 5;

		static int _Player1laps = 1;
		static int _Player2laps = 1;
		static int _Player3laps = 1;
		static int _Player4laps = 1;

		public static int send1 {
			get {
				return _send1;
			}
			set {
				lock (sendLock1) {
					_send1 = value;
				}
			}
		}

		public static int send2 {
			get {
				return _send2;
			}
			set {
				lock (sendLock2) {
					_send2 = value;
				}
			}
		}

		public static int send3 {
			get {
				return _send3;
			}
			set {
				lock (sendLock3) {
					_send3 = value;
				}
			}
		}

		public static int send4 {
			get {
				return _send4;
			}
			set {
				lock (sendLock4) {
					_send4 = value;
				}
			}
		}

		public static int comm1{
			get{
				return _comm1;
			}
			set{
				lock (commLock1) {
					_comm1 = value;
				}

			}
		}

		public static int comm2{
			get{
				return _comm2;
			}
			set{
				lock (commLock2) {
					_comm2 = value;
				}
			}
		}

		public static int comm3{
			get{
				return _comm3;
			}
			set{
				lock (commLock3) {
					_comm3 = value;
				}
			}
		}

		public static int comm4{
			get{
				return _comm4;
			}
			set{
				lock (commLock4) {
					_comm4 = value;
				}
			}
		}

		public static int Player1laps {
			get {
				return _Player1laps;
			}
			set {
				_Player1laps = value;
			}
		}

		public static int Player2laps {
			get {
				return _Player2laps;
			}
			set {
				_Player2laps = value;
			}
		}

		public static int Player3laps {
			get {
				return _Player3laps;
			}
			set {
				_Player3laps = value;
			}
		}

		public static int Player4laps {
			get {
				return _Player4laps;
			}
			set {
				_Player4laps = value;
			}
		}

		public static int numLaps {
			get {
				return _numLaps;
			}
			set {
				_numLaps = value;
			}
		}

		public static string player1{
			get {
				return _player1;
			}
			set{
				_player1 = value;
			}
		}

		public static string player2{
			get {
				return _player2;
			}
			set{
				_player2 = value;
			}
		}

		public static string player3{
			get {
				return _player3;
			}
			set{
				_player3 = value;
			}
		}

		public static string player4{
			get {
				return _player4;
			}
			set{
				_player4 = value;
			}
		}
	}
}

