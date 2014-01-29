using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Logic
{
    public class GameField
    {
        public List<Ship> Ships { get; private set; }
        public List<Point> Misses { get; private set; }

        public GameField()
        {
            Ships = new List<Ship>();
            Misses = new List<Point>();
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
            if (!Ships.Select(ship => ship.Bomb(x, y)).Any(bombed => bombed))
            {
                Misses.Add(new Point(x, y));
            }
            return true;
        }

        //public bool Bomb(int x, int y)
        //{
        //    var bombed = false;

        //    foreach (var ship in Ships)
        //    {
        //        bombed = ship.Bomb(x, y);
        //        if (bombed)
        //            break;
        //    }
        //    if (!bombed)
        //        Misses.Add(new Point(x, y));

        //    return bombed;
        //}

        public override string ToString()
        {
            return string.Join("\r\n", Ships);
        }
    }
}
