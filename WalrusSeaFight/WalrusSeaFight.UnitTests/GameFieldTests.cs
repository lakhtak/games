using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WalrusSeaFight.UnitTests
{
    [TestClass]
    public class GameFieldTests
    {
        [TestMethod]
        public void AddShipTest()
        {
            var gameField = new GameField(Constants.CellCount);

            var goodShip1 = new Ship(1, 2, 3);
            var goodShip2 = new Ship(Constants.CellCount - 1, Constants.CellCount - 2, 2, false);
            var goodShip3 = new Ship(5, 4, Constants.MaxLength);
            Assert.IsTrue(gameField.AddShip(goodShip1), goodShip1.ToString());
            Assert.IsTrue(gameField.AddShip(goodShip2), goodShip2.ToString());
            Assert.IsTrue(gameField.AddShip(goodShip3), goodShip3.ToString());
            Debug.WriteLine(gameField);

            var badShip1 = new Ship(0, 2, 3);
            var badShip2 = new Ship(7, 0, 1);
            var badShip3 = new Ship(7, 1, 0);
            var badShip4 = new Ship(Constants.CellCount, Constants.CellCount, 2);
            var badShip5 = new Ship(Constants.CellCount, Constants.CellCount, 2, false);
            var badShip6 = new Ship(1, 1, Constants.MaxLength + 1);
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
            var gameField = new GameField(Constants.CellCount);
            gameField.AddShip(new Ship(1, 2, 3));
            gameField.AddShip(new Ship(Constants.CellCount - 1, Constants.CellCount - 2, 2, false));
            gameField.AddShip(new Ship(5, 4, Constants.MaxLength));
            Debug.WriteLine(gameField);

            Assert.IsTrue(gameField.Bomb(3, 2), "Bomb(3, 2)");
            Assert.IsTrue(gameField.Bomb(Constants.CellCount - 1, Constants.CellCount - 1), "Bomb(Constants.CellCount - 1, Constants.CellCount - 1)");
            Assert.IsTrue(gameField.Bomb(Constants.CellCount - 1, Constants.CellCount - 2), "Bomb(Constants.CellCount - 1, Constants.CellCount - 2)");
            Assert.IsTrue(gameField.Ships.Count(ship => ship.Killed) == 1, "Killed ships count != 1");
            Assert.IsTrue(gameField.Bomb(5, 4), "Bomb(5, 4)");
        }
    }
}
