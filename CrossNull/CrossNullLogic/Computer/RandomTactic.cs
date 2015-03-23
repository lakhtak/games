using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CrossNullLogic.Computer
{
    class RandomTactic : ITactic
    {
        private readonly Random _random = new Random();

        public bool DefinePoint(Player player, out int x, out int y)
        {
            var emptyCells = GameField.EmptyCells;
            var randomEmptyCell = emptyCells[_random.Next(emptyCells.Length - 1)];
            x = randomEmptyCell.X;
            y = randomEmptyCell.Y;
            return true;
        }
    }
}
