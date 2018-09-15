using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class PositiveTile : Tile
	{
		private int _position;

		public PositiveTile(int position) : base(position)
		{
			_position = position;
		}
	}
}
