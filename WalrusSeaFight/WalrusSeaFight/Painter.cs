using System.Drawing;
using Logic;

namespace WalrusSeaFight
{
    public class Painter
    {
        public static void PaintShip(Graphics drawAera, Ship ship)
        {
            foreach (var shipPart in ship.Parts)
            {
                PaintShipPart(drawAera, shipPart);
            }
        }

        public static void PaintShipPart(Graphics drawAera, ShipPart part)
        {
            PaintCell(drawAera, part.Bombed ? GuiConstants.BombedImage : GuiConstants.ShipImage, part.X, part.Y);
        }

        public static void PaintCell(Graphics drawAera, Bitmap image, int x, int y)
        {
            drawAera.DrawImage(image, (x - 1) * GuiConstants.CellSize, (y - 1) * GuiConstants.CellSize);            
        }
    }
}
