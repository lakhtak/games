using System.Collections.Generic;
using System.Linq;

namespace WalrusSeaFight
{
    public class GameField
    {
        public List<Ship> Ships { get; private set; }

        public GameField()
        {
            Ships = new List<Ship>();
        }

        public bool AddShip(Ship shipToAdd)
        {
            if (!shipToAdd.ValidatePosition())
                return false;

            if (Ships.Any(ship => ship.IntersectsWith(shipToAdd)))
                return false;

            Ships.Add(shipToAdd);
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
