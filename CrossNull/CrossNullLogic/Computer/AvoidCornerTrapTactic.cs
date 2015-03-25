using System;
using System.Linq;

namespace CrossNullLogic.Computer
{
    class AvoidCornerTrapTactic : ITactic
    {
        private readonly Random _random = new Random();

        public bool DefinePoint(Player player, out int x, out int y)
        {
            x = 0;
            y = 0;

            if (!OpponentGotOpposites(player.OpponentSymbol)) return false;

            var freeSides = GameField.Sides.Where(side => GameField.Field[side.X, side.Y] == Symbol.NoOne).ToArray();
            if (!freeSides.Any())
                return false;

            var randomSide = freeSides[_random.Next(freeSides.Length - 1)];
            x = randomSide.X;
            y = randomSide.Y;
            return true;
        }

        private static bool OpponentGotOpposites(Symbol opponentSymbol)
        {
            return GameField.Corners.Any(corner => GameField.Field[corner.X, corner.Y] == opponentSymbol &&
                                                   GameField.Field[corner.X, corner.Y] ==
                                                   GameField.Field[
                                                       GameField.FieldSize - corner.X - 1,
                                                       GameField.FieldSize - corner.Y - 1]);
        }
    }
}
