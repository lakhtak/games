using System;
using CrossNullLogic;

namespace CrossNullConsole
{
    internal class SmartPlayerInteraction : IPlayerInteraction
    {
        private int coordX;
        private int coordY;

        public bool TryGetCoordinates(Player player, out int x, out int y)
        {
            SelectCell(player);

            x = coordX;
            y = coordY;
            
            return CheckCellFree(x, y, player.Symbol);
        }

        private bool CheckCellFree(int x, int y, Symbol symbol)
        {
            if (GameField.Field[x, y] == Symbol.NoOne) return true;

            Console.WriteLine("Ошибка: Поле ({0}, {1}) уже занято, вы не можете поставить туда {2}.", x + 1, y + 1, symbol);
            Console.ReadKey();
            return false;
        }

        private void SelectCell(Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Игрок {0} ходит {1}-ками.\r\n", player.Name, player.Symbol);
                GameFieldPainter.Paint(coordX, coordY);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        coordY = coordY - 1 < 0 ? coordY : coordY - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        coordY = coordY + 1 > GameField.FieldSize - 1 ? coordY : coordY + 1;
                        break;
                    case ConsoleKey.DownArrow:
                        coordX = coordX + 1 > GameField.FieldSize - 1 ? coordX : coordX + 1;
                        break;
                    case ConsoleKey.UpArrow:
                        coordX = coordX - 1 < 0 ? coordX : coordX - 1;
                        break;
                    case ConsoleKey.Enter:
                        return;
                }
            }
        }
    }
}
