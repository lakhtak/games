using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class MyFieldPictureBox : PictureBox
    {
        private Painter _painter;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            _painter = new Painter(pe.Graphics);

            DrawEmptyCells();
            DrawMissed();
            DrawShips();
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            drgevent.Effect = drgevent.Data.GetDataPresent(DataFormats.Bitmap) ? DragDropEffects.All : DragDropEffects.None;
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            var shipPicture = (Bitmap)drgevent.Data.GetData(DataFormats.Bitmap);
            
            var verticalLength = shipPicture.Height / GuiConstants.CellSize;
            var horizontalLength = shipPicture.Width / GuiConstants.CellSize;
            var isHorizontal = horizontalLength > 1;
            
            var unit = GraphicsUnit.Point;
            var rectangle = shipPicture.GetBounds(ref unit);
            var upperLeftX = (rectangle.X - Bounds.X) / GuiConstants.CellSize;
            var upperLeftY = (rectangle.Y - Bounds.Y) / GuiConstants.CellSize;

            Debug.WriteLine("verticalLength=" + verticalLength);
            Debug.WriteLine("horizontalLength=" + horizontalLength);
            Debug.WriteLine("isHorizontal=" + isHorizontal);
            Debug.WriteLine("rectangle.X=" + rectangle.X);
            Debug.WriteLine("rectangle.Y=" + rectangle.Y);
            Debug.WriteLine("Bounds.X=" + Bounds.X);
            Debug.WriteLine("Bounds.Y=" + Bounds.Y);

            //MyGameField.Instance.AddShip(new Ship())
        }

        private void DrawShips()
        {
            foreach (var ship in MyField.Instance.Ships)
            {
                _painter.PaintShip(ship);
            }
        }

        private void DrawMissed()
        {
            foreach (var miss in MyField.Instance.Misses)
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
