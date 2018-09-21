using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	public class GameMain
	{
		private List<Player> _players;
		private Board _board;
		private GameState _gameState;

		public GameMain (Player[] players, int boardLength)
		{
			_players = new List<Player>();

			foreach (Player p in players)
			{
				_players.Add(p);
			}

			_board = new Board(boardLength);
		}

		public void PlayGame()
		{
			foreach (Player p in _players)
			{
				p.Roll();
				_board.Move(p);
				Console.WriteLine(p.Name + " is now at position " + p.Position);
				Console.WriteLine(_board.Tiles[p.Position].SpecialEvent(p));
			}
		}

		public void DrawGame()
		{

		}
	}
}
