using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Dice
	{
		private int _value;

		private Random _rnd;

		public Dice()
		{
			_rnd = new Random();
		}

		public int roll()
		{
			return _rnd.Next(1, 6);
		}
	}
}
