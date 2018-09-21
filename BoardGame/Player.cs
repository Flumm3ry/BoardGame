using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public abstract class Player
	{
		private string _name;
		private int _position;
		private int _speedMod;
		private Dice[] _dice;
		private int _health;

		//A field used while the player is moving in the process of a turn
		private int _currentMove;

		public Player(string name)
		{
			_name = name;
			_position = 0;
			_speedMod = 0;
			_currentMove = 0;
			_health = 100;

			_dice = new Dice[2];

			for(int i=0; i < 2; i++)
			{
				_dice[i] = new Dice();
			}
		}

		public void Roll()
		{
			int totalRolled = 0;

			foreach (Dice d in _dice)
			{
				d.Roll();
				totalRolled += d.Value;
			}

			_currentMove = totalRolled + _speedMod;
			
		}

		public Dice[] Dice { get => _dice;}
		public int Position { get => _position; set => _position = value; }
		public string Name { get => _name;}
		public int SpeedMod { get => _speedMod; set => _speedMod = value; }
		public int CurrentMove { get => _currentMove; set => _currentMove = value; }
		public int Health { get => _health; set => _health = value; }

	}
}
