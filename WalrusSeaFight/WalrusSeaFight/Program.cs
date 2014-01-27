using System;
using System.Diagnostics;

namespace WalrusSeaFight
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            //using (var example = new Game())
            //{
            //    example.Run(30.0, 0.0);
            //}

            var gameField = new GameField(Constants.CellCount);
            Debug.WriteLine(gameField.AddShip(new Ship(1, 1, 4)));
            Debug.WriteLine(gameField.AddShip(new Ship(10, 10, 2)));
            Debug.WriteLine(gameField.Bomb(1, 2));
            Debug.WriteLine(gameField.Bomb(3, 3));
            Debug.WriteLine(gameField);
        }
    }
}
