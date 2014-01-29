using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class OpponentsFieldPictureBox : PictureBox
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
            foreach (var ship in OpponentsField.Instance.Ships)
            {
                _painter.PaintShip(ship);
            }
        }

        private void DrawMissed()
        {
            foreach (var miss in OpponentsField.Instance.Misses)
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
                    _painter.PaintCell(GuiConstants.UnknownImage, i, j);
                }
            }
        }
    }
}
