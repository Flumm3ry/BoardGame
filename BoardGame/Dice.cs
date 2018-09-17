using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public class Dice
	{
		private int _value;
		private string _diceImage;

		private Random _rnd;

		public Dice()
		{
			_rnd = new Random();
		}

		public int Value { get => _value; set => _value = value; }
		public string DiceImage { get => _diceImage; set => _diceImage = value; }

		public void Roll()
		{
			_value = _rnd.Next(1, 6);
			_diceImage = "Dice" + _value.ToString();
		}
	}
}
