using System;
using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            var gameField = MyGameField.Instance;

            var goodShip1 = new Ship(1, 2, 3);
            var goodShip2 = new Ship(GameConstants.CellCount - 1, GameConstants.CellCount - 2, 2, false);
            var goodShip3 = new Ship(5, 4, GameConstants.MaxLength);
            gameField.AddShip(goodShip1);
            gameField.AddShip(goodShip2);
            gameField.AddShip(goodShip3);
            gameField.Bomb(3, 3);
            gameField.Bomb(4, 5);
            gameField.Bomb(9, 9);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
