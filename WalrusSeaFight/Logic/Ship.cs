using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Ship
    {
        public List<ShipPart> Parts { get; private set; }
        public bool Killed { get; private set; }

        public Ship(int x, int y, int length, bool horizontal = true)
        {
            Killed = false;
            Parts = new List<ShipPart>();
            for (var i = 0; i < length; i++)
            {
                Parts.Add(horizontal ? new ShipPart(x + i, y) : new ShipPart(x, y + i));
            }
        }

        public bool Bomb(int x, int y)
        {
            var hitPart = Parts.FirstOrDefault(part => part.Equals(x, y));
            if (hitPart == null)
                return false;

            hitPart.Bombed = true;
            if (Parts.All(part => part.Bombed))
                Killed = true;

            return true;
        }

        public bool ValidatePosition()
        {
            return Parts.Any()
                   && Parts.All(
                       part =>
                           part.X <= GameConstants.CellCount && part.X > 0 && part.Y <= GameConstants.CellCount &&
                           part.Y > 0);
        }

        public override string ToString()
        {
            return "<" + string.Join(",", Parts.Select(part => string.Format("{0}-{1}-{2}", part.X, part.Y, part.Bombed ? "X" : "O"))) + ">";
        }

        public bool IntersectsWith(Ship ship)
        {
            return ship.Parts.Any(partToCheck => Parts.Any(part => part.IsBeside(partToCheck)));
        }
    }
}
