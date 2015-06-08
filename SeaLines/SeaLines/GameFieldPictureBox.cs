using System.Drawing;
using System.Windows.Forms;

namespace SeaLines
{
    class GameFieldPictureBox : PictureBox
    {
        private Graphics _drawArea;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            _drawArea = pe.Graphics;

            for (var i = 0; i < GameField.Field.GetLength(0); i++)
            {
                for (var j = 0; j < GameField.Field.GetLength(1); j++)
                {
                    Painter.PaintPath(_drawArea, GameField.Field[i, j], i, j);
                }
            }
        }
    }
}
