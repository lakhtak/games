using System.Diagnostics;
using System.Linq;

namespace CrossNullLogic.Computer
{
    class DefendOrWinTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            y = 0;

            if (OneCellLeft(GameField.Diagonal1, out x))
            {
                y = x;
                Debug.WriteLine("Diagonal1: x = " + x + ", y = " + y);
                return true;
            }

            if (OneCellLeft(GameField.Diagonal2, out x))
            {
                y = GameField.FieldSize - x - 1;
                Debug.WriteLine("Diagonal2: x = " + x + ", y = " + y);
                return true;
            }

            for (var i = 0; i < GameField.FieldSize; i++)
            {
                x = i;
                if (OneCellLeft(GameField.Row(i), out y))
                {
                    Debug.WriteLine("Row" + i + ": x = " + x + ", y = " + y);
                    return true;
                }
            }

            for (var i = 0; i < GameField.FieldSize; i++)
            {
                y = i;
                if (OneCellLeft(GameField.Column(i), out x))
                {
                    Debug.WriteLine("Column" + i + ": x = " + x + ", y = " + y);
                    return true;
                }
            }

            return false;
        }

        private static bool OneCellLeft(Symbol[] line, out int cellNumber)
        {
            cellNumber = 0;

            for (var i = 0; i < line.Length; i++)
            {
                if (line[i] == Symbol.NoOne)
                    cellNumber = i;
            }

            Debug.WriteLine("OneCellLeft: X count = " + line.Count(cell => cell == Symbol.X));
            Debug.WriteLine("OneCellLeft: O count = " + line.Count(cell => cell == Symbol.O));
            Debug.WriteLine("OneCellLeft: cellNumber = " + cellNumber);

            return line.Any(cell => cell == Symbol.NoOne) &&
                   (line.Count(cell => cell == Symbol.X) == GameField.FieldSize - 1 ||
                    line.Count(cell => cell == Symbol.O) == GameField.FieldSize - 1);
        }
    }
}
