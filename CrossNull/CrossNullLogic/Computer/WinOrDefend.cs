using System.Linq;

namespace CrossNullLogic.Computer
{
    static class WinOrDefend
    {
        public static bool FindOneCellLeftLine(Symbol symbol, out int x, out int y)
        {
            y = 0;

            if (OneCellLeft(symbol, GameField.Diagonal1, out x))
            {
                y = x;
                return true;
            }

            if (OneCellLeft(symbol, GameField.Diagonal2, out x))
            {
                y = GameField.FieldSize - x - 1;
                return true;
            }

            for (var i = 0; i < GameField.FieldSize; i++)
            {
                x = i;
                if (OneCellLeft(symbol, GameField.Row(i), out y))
                {
                    return true;
                }
            }

            for (var i = 0; i < GameField.FieldSize; i++)
            {
                y = i;
                if (OneCellLeft(symbol, GameField.Column(i), out x))
                {
                    return true;
                }
            }

            return false;            
        }

        private static bool OneCellLeft(Symbol symbol, Symbol[] line, out int cellNumber)
        {
            cellNumber = 0;

            for (var i = 0; i < line.Length; i++)
            {
                if (line[i] == Symbol.NoOne)
                    cellNumber = i;
            }

            return line.Any(cell => cell == Symbol.NoOne) &&
                   line.Count(cell => cell == symbol) == GameField.FieldSize - 1;
        }
    }
}
