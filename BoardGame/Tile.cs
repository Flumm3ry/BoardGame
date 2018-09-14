using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Tile
	{
		private int _position;
		private SpecialEvent _event;

		public Tile (int position)
		{
			_position = position;
		}
	}
}
