using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class Medkit : IItem
	{
		private int _healthMod;
		private int _speedMod;
		private string _message;

		public Medkit()
		{
			Random rnd = new Random();
			_healthMod = rnd.Next(5,15);
			_speedMod = 0;
			_message = "You found a medkiut and recieved " + _healthMod + " health!";
		}

		public int HealthMod { get => _healthMod;}
		public int SpeedMod { get => _speedMod;}
		public string Message { get => _message;}
	}
}
