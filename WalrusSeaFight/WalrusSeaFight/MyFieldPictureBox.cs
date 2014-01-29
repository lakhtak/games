using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class MyFieldPictureBox : PictureBox
    {
        private Painter _painter;

        protected override void OnPaint(PaintEventArgs pe)
        {
            _painter = new Painter(pe.Graphics);

            DrawEmptyCells();
            DrawMissed();
            DrawShips();
        }

        private void DrawShips()
        {
            foreach (var ship in MyGameField.Instance.Ships)
            {
                _painter.PaintShip(ship);
            }
        }

        private void DrawMissed()
        {
            foreach (var miss in MyGameField.Instance.Misses)
            {
                _painter.PaintCell(GuiConstants.MissImage, miss.X, miss.Y);
            }
        }

        private void DrawEmptyCells()
        {
            for (var i = 1; i <= GameConstants.CellCount; i++)
            {
                for (var j = 1; j <= GameConstants.CellCount; j++)
                {
                    _painter.PaintCell(GuiConstants.EmptyImage, i, j);
                }
            }
        }
    }
}
