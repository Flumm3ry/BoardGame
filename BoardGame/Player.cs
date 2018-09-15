using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	abstract class Player
	{
		private string _name;
		private int _position;
		private int _speedMod;

		public Player(string name)
		{
			_name = name;
			_position = 0;
			_speedMod = 0;
		}

		public void Move(int places, bool speedModApplied)
		{
			_position += places;
			if (speedModApplied)
				_position += _speedMod;
		}
	}
}
