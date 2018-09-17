using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public class NegativeTile : Tile
	{
		private int _position;

		public NegativeTile(int position) : base(position)
		{
			_position = position;
		}

		public override string SpecialEvent(Player p)
		{
			Random rnd = new Random();

			int negEvent = rnd.Next(1, 2);

			switch(negEvent)
			{
				case 1:
					return SpeedMod(p);
				case 2:
					return PositionMod(p);
			}

			return "Error with negative special event";
		}

		public string SpeedMod(Player p)
		{
			Random rnd = new Random();

			int mod = rnd.Next(1,4);

			p.SpeedMod += mod;

			return "You feel an empowering burst of energy and your speed has been increased by " + mod.ToString();
		}

		public string PositionMod(Player p)
		{
			Random rnd = new Random();

			int mod = rnd.Next(2, 10);

			p.Position -= mod;

			return "A sudden gust of wind knocks you back " + mod.ToString() + " spaces";
		}
	}
}
