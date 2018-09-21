using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	interface IItem
	{
		int HealthMod
		{
			get;
		}

		int SpeedMod
		{
			get;
		}

		string Message
		{
			get;
		}
	}
}
