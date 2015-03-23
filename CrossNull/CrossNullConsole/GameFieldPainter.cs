using System;
using System.Linq;
using CrossNullLogic;

namespace CrossNullConsole
{
    public class GameFieldPainter : GameField
    {
        public static void Paint()
        {
            foreach (var row in Rows)
            {
                Console.WriteLine(string.Join(" ", row.Select(ReplaceNoOneCell)));
            }
        }

        public static void Paint(int x, int y)
        {
            for (var i = 0; i < FieldSize; i++)
            {
                var rowNumber = i;
                Console.WriteLine(string.Join(string.Empty,
                    Row(rowNumber)
                        .Select(
                            (cell, index) =>
                                rowNumber == x && index == y
                                    ? ReplaceSelectedCell(ReplaceNoOneCell(cell))
                                    : " " + ReplaceNoOneCell(cell) + " ")) + "\r\n");
            }
        }

        private static string ReplaceNoOneCell(Symbol cell)
        {
            return cell.ToString().Replace(Symbol.NoOne.ToString(), "*");
        }

        private static string ReplaceSelectedCell(string cell)
        {
            return cell.Replace(cell, "[" + cell + "]");
        }
    }
}