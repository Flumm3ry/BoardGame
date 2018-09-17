using BoardGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class PlayerTests
	{

		[TestMethod()]
		public void PlayerNamesInit()
		{
			var jonny = new HumanPlayer("Jonny");
			var papa = new HumanPlayer("Papa");

			Assert.AreEqual(jonny.Name, "Jonny");
			Assert.AreEqual(papa.Name, "Papa");
		}

		[TestMethod()]
		public void PlayerPositionInit()
		{
			var jonny = new HumanPlayer("Jonny");
			var papa = new HumanPlayer("Papa");

			Assert.AreEqual(jonny.Position, 0);
			Assert.AreEqual(papa.Position, 0);
		}

		[TestMethod()]
		public void PlayerTurnsMovePlayer()
		{
			var jonny = new HumanPlayer("Jonny");
			var papa = new HumanPlayer("Papa");

			jonny.Turn();
			papa.Turn();

			Assert.IsTrue(jonny.Position > 0);
			Assert.IsTrue(papa.Position > 0);
		}
	}
}
