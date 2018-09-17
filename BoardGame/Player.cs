using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	abstract class Player
	{
		private string _name;
		private int _position;
		private int _speedMod;
		private Dice[] _dice;

		public Player(string name)
		{
			_name = name;
			_position = 0;
			_speedMod = 0;

			_dice = new Dice[2];

			for(int i=0; i < 2; i++)
			{
				_dice[i] = new Dice();
			}
		}

		public virtual void Turn()
		{
			int totalRolled = 0;

			foreach (Dice d in _dice)
			{
				d.Roll();
				totalRolled += d.Value;
			}

			Move(totalRolled, true);
		}

		public Dice[] Dice { get => _dice; set => _dice = value; }

		public void Move(int places, bool speedModApplied)
		{
			_position += places;
			if (speedModApplied)
				_position += _speedMod;
		}


	}
}
