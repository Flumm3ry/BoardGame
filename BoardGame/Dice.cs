using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Dice
	{
		private int _value;
		private string _diceImage;

		private Random _rnd;

		public Dice()
		{
			_rnd = new Random();
		}

		public void roll()
		{
			_value = _rnd.Next(1, 6);
			_diceImage = "Dice" + _value.ToString();
		}
	}
}
