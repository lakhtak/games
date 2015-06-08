using System.Drawing;

namespace SeaLines
{
    public static class Painter
    {
        public static void PaintCell(Graphics drawAera, Color color, int x, int y)
        {
            PaintBorder(drawAera, x, y);
            drawAera.FillEllipse(new SolidBrush(color),
                x * Constants.CellSize,
                y * Constants.CellSize,
                Constants.CellSize,
                Constants.CellSize);
        }

        public static void PaintPath(Graphics drawAera, Color color, int x, int y)
        {
            PaintBorder(drawAera, x, y);
            drawAera.FillEllipse(new SolidBrush(color),
                x * Constants.CellSize + Constants.CellSize / 3,
                y * Constants.CellSize + Constants.CellSize / 3,
                Constants.CellSize / 3,
                Constants.CellSize / 3);
        }

        public static void PaintSelected(Graphics drawAera, Color color, int x, int y)
        {
            
        }

        private const int BorderWidth = 1;
        private static readonly Color BorderColor = Color.Black;

        private static void PaintBorder(Graphics drawAera, int x, int y)
        {
            drawAera.DrawRectangle(new Pen(BorderColor, BorderWidth),
                x * Constants.CellSize,
                y * Constants.CellSize,
                Constants.CellSize,
                Constants.CellSize);            
        }
    }
}
