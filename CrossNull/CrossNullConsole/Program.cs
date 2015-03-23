using System;
using CrossNullLogic;

namespace CrossNullConsole
{
    class Program
    {
        static void Main()
        {
            StartGame();
        }

        static void StartGame()
        {
            try
            {
                do
                {
                    GameField.Reset();  
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать в игру КРЕСТИКИ-НОЛИКИ.\r\n");

                    Console.Write("Введите имя игрока за крестики (пустое имя если это будет Компьютер): ");
                    var playerXName = Console.ReadLine();
                    var playerX = string.IsNullOrWhiteSpace(playerXName)
                        ? (Player)new ComputerPlayer(Symbol.X)
                        : new HumanPlayer(Symbol.X, playerXName, new SmartPlayerInteraction());

                    Console.Write("Введите имя игрока за нолики (пустое имя если это будет Компьютер): ");
                    var playerOName = Console.ReadLine();
                    var playerO = string.IsNullOrWhiteSpace(playerOName)
                        ? (Player)new ComputerPlayer(Symbol.O)
                        : new HumanPlayer(Symbol.O, playerOName, new SmartPlayerInteraction());

                    var game = new Game(playerX, playerO);
                    do
                    {
                        Console.Clear();
                        GameFieldPainter.Paint();
                        game.SwitchTurn();
                        int x;
                        int y;
                        game.CurrentPlayer.Move(out x, out y);
                        GameField.Field[x, y] = game.CurrentPlayer.Symbol;
                        game.CheckWinner();
                    } while (!game.CurrentPlayer.Winner && !GameField.Filled);

                    Console.Clear();
                    GameFieldPainter.Paint();

                    if (GameField.Filled)
                        Console.WriteLine("ЭТО НИЧЬЯ, ГОСПОДА...");
                    else
                        Console.WriteLine("УУУУУРРРРРРРРААААААА!!!!!! {0} ПОБЕЖДАЕТ!!!\r\n\r\n", game.CurrentPlayer.Name);

                    Console.WriteLine("Чтобы сыграть еще разочек нажмите 'Enter'.");
                } while (Console.ReadKey().Key == ConsoleKey.Enter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
