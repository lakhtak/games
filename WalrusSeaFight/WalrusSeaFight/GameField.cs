using System.Collections.Generic;
using System.Linq;

namespace WalrusSeaFight
{
    public class GameField
    {
        public List<Ship> Ships { get; private set; }
        private readonly int _size;

        public GameField(int size)
        {
            _size = size;
            Ships = new List<Ship>();
        }

        public bool AddShip(Ship ship)
        {
            if (!ship.CheckBorders(_size))
                return false;

            Ships.Add(ship);
            return true;
        }

        public bool Bomb(int x, int y)
        {
            return Ships.Select(ship => ship.Bomb(x, y)).Any(bombed => bombed);
        }

        public override string ToString()
        {
            return string.Join("\r\n", Ships);
        }
    }
}
