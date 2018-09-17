using System;

namespace BoardGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var jonny = new HumanPlayer("Jonny");
			var papa = new HumanPlayer("Papa");

			GameMain myGame = new GameMain(new Player[] {jonny, papa}, 100);

			for (int i = 0; i < 7; i++)
				myGame.PlayGame();

			Console.ReadKey();
		}
	}
}
