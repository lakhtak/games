using System.Drawing;
using System.Linq;

namespace CrossNullLogic.Computer
{
    class GetCornerTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            x = 0;
            y = 0;

            if (OpponentGotOpposites(player.OpponentSymbol)) return false;

            return GetFreeOppositeCorner(player.Symbol, out x, out y) || GetFirstFreeCorner(GameField.Corners, out x, out y);
        }

        private static bool OpponentGotOpposites(Symbol opponentSymbol)
        {
            return GameField.Corners.Any(corner => GameField.Field[corner.X, corner.Y] == opponentSymbol &&
                                                   GameField.Field[corner.X, corner.Y] ==
                                                   GameField.Field[
                                                       GameField.FieldSize - corner.X - 1,
                                                       GameField.FieldSize - corner.Y - 1]);
        }

        private static bool GetFreeOppositeCorner(Symbol mySymbol, out int x, out int y)
        {
            x = 0;
            y = 0;

            var myCorners = GameField.Corners.Where(corner => GameField.Field[corner.X, corner.Y] == mySymbol).ToArray();
            return myCorners.Any() && GetFirstFreeCorner(myCorners, out x, out y);
        }

        private static bool GetFirstFreeCorner(Point[] corners, out int x, out int y)
        {
            x = 0;
            y = 0;

            foreach (var corner in corners)
            {
                x = GameField.FieldSize - corner.X - 1;
                y = GameField.FieldSize - corner.Y - 1;
                if (GameField.Field[x, y] == Symbol.NoOne)
                    return true;
            }
            return false;
        }
    }
}
