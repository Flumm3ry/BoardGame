using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public abstract class Tile
	{
		private int _position;
		private IItem _item;
		//ADD colour

		public Tile (int position)
		{
			_position = position;

			Random rnd = new Random();

			int randItem = rnd.Next(1, 12);

			if (randItem == 1)
				_item = new Bomb();

			else if (randItem == 2)
				_item = new Medkit();

			else
			_item = null;
		}

		public virtual void Landed(Player p)
		{
			if (_item != null)
			{
				p.Health += _item.HealthMod;

				//Ensures the health of a player never goes beyond the boundries of 0-100
				if (p.Health > 100)
					p.Health = 100;
				else if (p.Health < 0)
					p.Health = 0;

				p.SpeedMod += _item.SpeedMod;
			}

			_item = null;

			//ADD colour change (changes to red for where previous bombs where are green where medkits were found)

		}

		abstract public string SpecialEvent(Player player);
	}
}
