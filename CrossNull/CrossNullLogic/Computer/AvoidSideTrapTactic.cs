using System;
using System.Drawing;
using System.Linq;

namespace CrossNullLogic.Computer
{
    class AvoidSideTrapTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            x = 0;
            y = 0;

            Point[] opponentSides;
            return (OpponentHasAdjacentSides(player.OpponentSymbol, out opponentSides) &&
                    EmptyCornerBetweenSides(opponentSides, out x, out y));
        }

        private static bool OpponentHasAdjacentSides(Symbol opponentSymbol, out Point[] opponentSides)
        {
            opponentSides = GameField.Sides.Where(point => GameField.Field[point.X, point.Y] == opponentSymbol).ToArray();
            
            return opponentSides.Length == 2 &&
                   opponentSides[0].X != opponentSides[1].X &&
                   opponentSides[0].Y != opponentSides[1].Y;
        }

        private static bool EmptyCornerBetweenSides(Point[] sides, out int x, out int y)
        {
            x = sides.Any(side => side.X == 0 && side.Y == 1) ? 0 : 2;
            y = sides.Any(side => side.X == 1 && side.Y == 0) ? 0 : 2;

            return GameField.Field[x, y] == Symbol.NoOne;
        }
    }
}
