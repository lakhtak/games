using System;
using System.Drawing;
using System.Linq;

namespace CrossNullLogic.Computer
{
    class SideTrapTactic : ITactic
    {
        private readonly Random _random = new Random();

        public bool DefinePoint(Player player, out int x, out int y)
        {
            Point[] sides;
            return (ChooseAdjacentSide(player.Symbol, out x, out y) ||
                    (GotAdjacentSides(Symbol.X, out sides) ||
                     GotAdjacentSides(Symbol.O, out sides)) &&
                    ChooseEmptyCornerBetweenSides(sides, out x, out y));
        }

        private bool ChooseAdjacentSide(Symbol mySymbol, out int x, out int y)
        {
            x = 0;
            y = 0;

            if (GameField.Sides.Where(point => GameField.Field[point.X, point.Y] == Symbol.NoOne).Count() != 3)
                return false;

            var nonFreeSides = GameField.Sides.Where(point => GameField.Field[point.X, point.Y] == mySymbol).ToArray();
            if (!nonFreeSides.Any())
                return false;

            var nonFreeSide = nonFreeSides.First();
            var adjacentSides =
                GameField.Sides.Where(
                    point =>
                        GameField.Field[point.X, point.Y] == Symbol.NoOne && 
                        point.X != nonFreeSide.X &&
                        point.Y != nonFreeSide.Y).ToArray();

            var randomAdjacentSide = _random.Next(1);
            x = adjacentSides[randomAdjacentSide].X;
            y = adjacentSides[randomAdjacentSide].Y;
            return true;
        }

        private static bool GotAdjacentSides(Symbol symbol, out Point[] sides)
        {
            sides = GameField.Sides.Where(point => GameField.Field[point.X, point.Y] == symbol).ToArray();

            return sides.Length == 2 &&
                   sides[0].X != sides[1].X &&
                   sides[0].Y != sides[1].Y;
        }

        private static bool ChooseEmptyCornerBetweenSides(Point[] sides, out int x, out int y)
        {
            x = sides.Any(side => side.X == 0 && side.Y == 1) ? 0 : 2;
            y = sides.Any(side => side.X == 1 && side.Y == 0) ? 0 : 2;

            return GameField.Field[x, y] == Symbol.NoOne;
        }
    }
}
