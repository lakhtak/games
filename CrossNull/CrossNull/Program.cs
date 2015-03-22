using System;

namespace CrossNull
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            try
            {
                do
                {
                    Console.WriteLine("Добро пожаловать в игру КРЕСТИКИ-НОЛИКИ.");

                    Console.Write("Введите имя игрока за крестики (пустое имя если это будет Компьютер): ");
                    var playerXName = Console.ReadLine();
                    var playerX = string.IsNullOrWhiteSpace(playerXName)
                        ? (Player) new Computer(Who.X)
                        : new Human(Who.X, playerXName);

                    Console.Write("Введите имя игрока за нолики (пустое имя если это будет Компьютер): ");
                    var playerOName = Console.ReadLine();
                    var playerO = string.IsNullOrWhiteSpace(playerOName)
                        ? (Player) new Computer(Who.O)
                        : new Human(Who.O, playerOName);

                    var game = new Game(playerX, playerO);
                    do
                    {
                        Console.Clear();
                        GameField.Print();
                        game.SwitchTurn();
                        int x;
                        int y;
                        game.CurrentPlayer.Move(out x, out y);
                        GameField.Field[x, y] = game.CurrentPlayer.Symbol;
                        game.CheckWinner();
                    } while (!game.CurrentPlayer.Winner && !GameField.Filled);

                    Console.Clear();
                    GameField.Print();

                    if (GameField.Filled)
                        Console.WriteLine("ЭТО НИЧЬЯ, ГОСПОДА...");
                    else
                        Console.WriteLine("УУУУУРРРРРРРРААААААА!!!!!! {0} ПОБЕЖДАЕТ!!!\r\n\r\n", game.CurrentPlayer.Name);

                    Console.Write("Чтобы сыграть еще разочек напечатайте 'go': ");
                } while (Console.ReadLine() == "go");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
