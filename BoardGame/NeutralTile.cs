using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public class NeutralTile : Tile
	{
		private int _position;

		public NeutralTile(int position) : base(position)
		{
			_position = position;
		}

		public override void SpecialEvent(Player player)
		{

		}

	}
}