using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Board
	{
		private Tile[] _tiles;

		public Board(int BoardLength)
		{
			_tiles = new Tile[BoardLength];
			for (int i = 0; i < BoardLength; i++)
			{
				_tiles[i] = new Tile(i);
			}
		}

		public Tile[] Tiles { get => _tiles;}
	}
}
