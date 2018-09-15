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
			Random rnd = new Random();
			int tileType;

			_tiles = new Tile[BoardLength];
			for (int i = 0; i < BoardLength; i++)
			{
				tileType = rnd.Next(1, 3);

				switch(tileType)
				{
					case 1:
						_tiles[i] = new NegativeTile(i);
						break;
					case 2:
						_tiles[i] = new NeutralTile(i);
						break;
					case 3:
						_tiles[i] = new PositiveTile(i);
						break;
				}
				
			}
		}

		public Tile[] Tiles { get => _tiles;}
	}
}
