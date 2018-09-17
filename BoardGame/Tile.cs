using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public abstract class Tile
	{
		private int _position;

		public Tile (int position)
		{
			_position = position;
		}

		abstract public void SpecialEvent(Player player);
	}
}
