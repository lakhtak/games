using System;

namespace Logic
{
    public class ShipPart
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Bombed { get; set; }

        public ShipPart(int x, int y, bool bombed = false)
        {
            X = x;
            Y = y;
            Bombed = bombed;
        }

        public bool Equals(int x, int y)
        {
            return X == x && Y == y;
        }

        public bool IsBeside(ShipPart otherPart)
        {
            return Math.Abs(X - otherPart.X) <= 1 && Math.Abs(Y - otherPart.Y) <= 1;
        }
    }
}
