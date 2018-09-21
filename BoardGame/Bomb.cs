using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Bomb : IItem
	{
		private int _healthMod;
		private int _speedMod;
		private string _message;

		public Bomb()
		{
			Random rnd = new Random();
			_healthMod = - rnd.Next(5,25);
			_speedMod = 0;
			_message = "You hit a bomb and took " + _healthMod + " damage!";
		}

		public int HealthMod { get => _healthMod;}
		public int SpeedMod { get => _speedMod;}
		public string Message { get => _message;}
	}
}
