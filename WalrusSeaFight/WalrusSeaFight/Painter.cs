using System.Drawing;
using Logic;

namespace WalrusSeaFight
{
    public class Painter
    {
        private readonly Graphics _drawArea;

        public Painter(Graphics drawArea)
        {
            _drawArea = drawArea;
        }

        public void PaintShip(Ship ship)
        {
            foreach (var shipPart in ship.Parts)
            {
                PaintShipPart(shipPart);
            }
        }

        public void PaintShipPart(ShipPart part)
        {
            PaintCell(part.Bombed ? GuiConstants.BombedImage : GuiConstants.ShipImage, part.X, part.Y);
        }

        public void PaintCell(Bitmap image, int x, int y)
        {
            _drawArea.DrawImage(image, (x - 1) * GuiConstants.CellSize, (y - 1) * GuiConstants.CellSize);            
        }
    }
}
