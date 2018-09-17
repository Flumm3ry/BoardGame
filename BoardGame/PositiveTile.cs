using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public class PositiveTile : Tile
	{
		private int _position;

		public PositiveTile(int position) : base(position)
		{
			_position = position;
		}

		public override void SpecialEvent(Player player)
		{
			
		}
	}
}
