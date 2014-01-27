namespace WalrusSeaFight
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
    }
}
