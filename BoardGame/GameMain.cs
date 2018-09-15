using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
	class GameMain
	{
		private List<Player> _players;
		private Board _board;
		private GameState _gameState;

		public GameMain (Player[] players, Board board)
		{
			_players = new List<Player>();

			foreach (Player p in players)
			{
				_players.Add(p);
			}

			_board = board;
		}

		public void DrawGame()
		{

		}
	}
}
