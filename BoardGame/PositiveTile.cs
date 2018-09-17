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

		public override string SpecialEvent(Player p)
		{
			Random rnd = new Random();

			int posEvent = rnd.Next(1, 2);

			switch (posEvent)
			{
				case 1:
					return SpeedMod(p);
				case 2:
					return PositionMod(p);
			}

			return "Error with positive special event";
		}

		public string SpeedMod(Player p)
		{
			Random rnd = new Random();

			int mod = rnd.Next(1,4);

			p.SpeedMod -= mod;

			return "You ran into a trap that slowed your speed by " + mod.ToString();
		}

		public string PositionMod(Player p)
		{
			Random rnd = new Random();

			int mod = rnd.Next(2, 10);

			p.Position += mod;

			return "A wild phoenix carries you " + mod.ToString() + " spaces forwards";
		}
	}
}
