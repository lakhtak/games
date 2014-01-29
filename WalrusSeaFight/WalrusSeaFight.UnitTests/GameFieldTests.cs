using System.Diagnostics;
using System.Linq;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WalrusSeaFight.UnitTests
{
    [TestClass]
    public class GameFieldTests
    {
        [TestMethod]
        public void AddShipTest()
        {
            var gameField = MyGameField.Instance;

            var goodShip1 = new Ship(1, 2, 3);
            var goodShip2 = new Ship(GameConstants.CellCount - 1, GameConstants.CellCount - 2, 2, false);
            var goodShip3 = new Ship(5, 4, GameConstants.MaxLength);
            Assert.IsTrue(gameField.AddShip(goodShip1), goodShip1.ToString());
            Assert.IsTrue(gameField.AddShip(goodShip2), goodShip2.ToString());
            Assert.IsTrue(gameField.AddShip(goodShip3), goodShip3.ToString());
            Debug.WriteLine(gameField);

            var badShip1 = new Ship(0, 2, 3);
            var badShip2 = new Ship(7, 0, 1);
            var badShip3 = new Ship(7, 1, 0);
            var badShip4 = new Ship(GameConstants.CellCount, GameConstants.CellCount, 2);
            var badShip5 = new Ship(GameConstants.CellCount, GameConstants.CellCount, 2, false);
            var badShip6 = new Ship(1, 1, GameConstants.MaxLength + 1);
            Assert.IsFalse(gameField.AddShip(badShip1), badShip1.ToString());
            Assert.IsFalse(gameField.AddShip(badShip2), badShip2.ToString());
            Assert.IsFalse(gameField.AddShip(badShip3), badShip3.ToString());
            Assert.IsFalse(gameField.AddShip(badShip4), badShip4.ToString());
            Assert.IsFalse(gameField.AddShip(badShip5), badShip5.ToString());
            Assert.IsFalse(gameField.AddShip(badShip6), badShip6.ToString());
        }

        [TestMethod]
        public void BombTest()
        {
            var gameField = MyGameField.Instance;

            gameField.AddShip(new Ship(1, 2, 3));
            gameField.AddShip(new Ship(GameConstants.CellCount - 1, GameConstants.CellCount - 2, 2, false));
            gameField.AddShip(new Ship(5, 4, GameConstants.MaxLength));
            Debug.WriteLine(gameField);

            Assert.IsTrue(gameField.Bomb(3, 2), "Bomb(3, 2)");
            Assert.IsTrue(gameField.Bomb(GameConstants.CellCount - 1, GameConstants.CellCount - 1), "Bomb(GameConstants.CellCount - 1, GameConstants.CellCount - 1)");
            Assert.IsTrue(gameField.Bomb(GameConstants.CellCount - 1, GameConstants.CellCount - 2), "Bomb(GameConstants.CellCount - 1, GameConstants.CellCount - 2)");
            Assert.IsTrue(gameField.Ships.Count(ship => ship.Killed) == 1, "Killed ships count != 1");
            Assert.IsTrue(gameField.Bomb(5, 4), "Bomb(5, 4)");
        }
    }
}
