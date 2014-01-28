using System;
using System.Drawing;
using System.Windows.Forms;

namespace WalrusSeaFight
{
    public static class MyGameField
    {
        public static GameField Field { get; private set; }

        static MyGameField()
        {
            Field = new GameField();
        }

        public static void Paint(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox) sender;
            var drawArea = Graphics.FromImage(new Bitmap(pictureBox.Width, pictureBox.Height));
            Field.Paint(drawArea);
        }
    }
}
