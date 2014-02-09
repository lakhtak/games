using System.Drawing;
using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class OpponentsFieldPictureBox : PictureBox
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

        public void OnGameStateChanged(State state)
        {
            Visible = state == State.PlayerTurn || state == State.OpponentsTurn || state == State.GameOver;

            if (state != State.Initial)
                Invalidate();
        }

        private void DrawShips()
        {
            foreach (var ship in OpponentsField.Instance.Ships)
            {
                Painter.PaintShip(_drawArea, ship, hide: true);
            }
        }

        private void DrawMissed()
        {
            foreach (var miss in OpponentsField.Instance.Misses)
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
                    Painter.PaintCell(_drawArea, GuiConstants.UnknownImage, i, j);
                }
            }
        }
    }
}
