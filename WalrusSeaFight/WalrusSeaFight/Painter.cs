using System.Drawing;
using Logic;

namespace WalrusSeaFight
{
    public class Painter
    {
        public static void PaintShip(Graphics drawAera, Ship ship, bool hide = false)
        {
            foreach (var shipPart in ship.Parts)
            {
                if (hide && !shipPart.Bombed)
                    continue;

                PaintShipPart(drawAera, shipPart, ship.Killed);
            }
        }

        public static void PaintShipPart(Graphics drawAera, ShipPart part, bool shipKilled)
        {
            PaintCell(drawAera, part.Bombed ? shipKilled ? GuiConstants.KilledImage : GuiConstants.BombedImage : GuiConstants.ShipImage, part.X, part.Y);
        }

        public static void PaintCell(Graphics drawAera, Bitmap image, int x, int y)
        {
            drawAera.DrawImage(image, (x - 1) * GuiConstants.CellSize, (y - 1) * GuiConstants.CellSize);            
        }
    }
}
