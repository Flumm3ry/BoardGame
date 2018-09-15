using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class NegativeTile : Tile
	{
		private int _position;

		public NegativeTile(int position) : base(position)
		{
			_position = position;
		}
	}
}
