using System.Drawing;
using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class PlayerFieldPictureBox : PictureBox
    {
        private Graphics _drawArea;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            _drawArea = pe.Graphics;

            DrawEmptyCells();
            DrawMissed();
            DrawShips();
        }

        public void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState != State.OpponentsTurn)
                Invalidate();
        }

        private void DrawShips()
        {
            foreach (var ship in PlayerField.Instance.Ships)
            {
                Painter.PaintShip(_drawArea, ship);
            }
        }

        private void DrawMissed()
        {
            foreach (var miss in PlayerField.Instance.Misses)
            {
                Painter.PaintCell(_drawArea, GuiConstants.MissImage, miss.X, miss.Y);
            }
        }

        private void DrawEmptyCells()
        {
            for (var i = 1; i <= GameConstants.CellCount; i++)
            {
                for (var j = 1; j <= GameConstants.CellCount; j++)
                {
                    Painter.PaintCell(_drawArea, GuiConstants.EmptyImage, i, j);
                }
            }
        }
    }
}
