using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace NerpasPresent
{
    public partial class Present : Form
    {
        readonly Timer _timer = new Timer();
        private const int TimeInterval = 400;
        private const int WaitReading = 10 * 1000;

        public Present()
        {
            InitializeComponent();
            //var player = new SoundPlayer(Resources.klingon_style);
            //player.PlayLooping();
        }

        private void buttonKit_Click(object sender, EventArgs e)
        {

        }

        private void buttonTulen_Click(object sender, EventArgs e)
        {

        }

        private void buttonLosos_Click(object sender, EventArgs e)
        {

        }

        private void buttonLakhtak_Click(object sender, EventArgs e)
        {

        }

        private void buttonUtya_Click(object sender, EventArgs e)
        {
            HideButtons();
            ShowCloud(215, 366, 454, 146, "test", false);
            Thread.Sleep(WaitReading);
            text.Visible = false;
            MoveAnimal(pictureUtya, 469, 172);
            ShowHeart(1, 1);
            MoveAnimal(pictureUtya, 675, 318);
            ShowButtons();
        }

        private void ShowHeart(int x, int y)
        {
            Thread.Sleep(3000);
        }

        private void MoveAnimal(PictureBox pictureBox, int x, int y)
        {
            const int steps = 10;
            const int moveSpeed = 200;
            var oldX = pictureBox.Location.X;
            var oldY = pictureBox.Location.Y;

            var diffX = Math.Abs(oldX - x);
            var stepX = oldX > x ? diffX / 10 : -diffX / 10;

            var diffY = Math.Abs(oldY - y);
            var stepY = oldY > y ? diffY / 10 : -diffY / 10;
            
            for (var i = 0; i < steps; i++)
            {
                var newX = pictureBox.Location.X + stepX;
                if ((stepY > 0 && newX > x) || (stepY < 0 && newX < x)) newX = x;

                var newY = pictureBox.Location.Y + stepY;
                if ((stepY > 0 && newY > y) || (stepY < 0 && newY < y)) newY = y;

                pictureBox.Location = new Point(pictureBox.Location.X + stepX, pictureBox.Location.Y + stepY);
                pictureBox.Refresh();
                Thread.Sleep(moveSpeed);
            }
        }

        private void ShowCloud(int x, int y, int width, int height, string textToShow, bool flip)
        {
            text.Location = new Point(x, y);
            text.Width = width;
            text.Height = height;
            text.Visible = true;
            if (flip)
            {
                text.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                text.ImageAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                text.ImageAlign = ContentAlignment.MiddleRight;                
            }
            text.Refresh();
        }

        private void HideButtons()
        {
            buttonKit.Visible = false;
            buttonLakhtak.Visible = false;
            buttonUtya.Visible = false;
            buttonLosos.Visible = false;
            buttonTulen.Visible = false;
            Refresh();
        }

        private void ShowButtons()
        {
            buttonKit.Visible = true;
            buttonLakhtak.Visible = true;
            buttonUtya.Visible = true;
            buttonLosos.Visible = true;
            buttonTulen.Visible = true;
            Refresh();
        }

        private void Present_Load(object sender, EventArgs e)
        {
            _timer.Interval = TimeInterval;
            _timer.Start();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }
    }
}
