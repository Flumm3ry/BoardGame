using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Player
	{
		private string _name;
		private Tile _position;

		public Player(string name)
		{
			_name = name;
			_position = Board.Tiles[0];
		}
	}
}
