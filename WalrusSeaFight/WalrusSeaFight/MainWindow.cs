using System;
using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {

        }

        private void buttonRandomAllocation_Click(object sender, System.EventArgs e)
        {
            Allocator.AllocateShipsRandomly(MyField.Instance);
            myFieldPictureBox.Invalidate();

            Allocator.AllocateShipsRandomly(OpponentsField.Instance);
            opponentsFieldPictureBox.Invalidate();
        }

        private void opponentsFieldPictureBox_Click(object sender, MouseEventArgs e)
        {
            var cellX = e.X / GuiConstants.CellSize + 1;
            var cellY = e.Y / GuiConstants.CellSize + 1;

            OpponentsField.Instance.Bomb(cellX, cellY);
            opponentsFieldPictureBox.Invalidate();
        }
    }
}
