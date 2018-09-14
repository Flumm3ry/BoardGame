using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Player
	{
		private string _name;
		private int _position;
		private Status _status;
		private int _speedMod;

		public Player(string name)
		{
			_name = name;
			_position = 0;
			_status = Status.Healthy;
			_speedMod = 0;
		}
	}
}
