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
            ConfigureLayout();
            SubscribeToGameEvents();
            TheGame.ChangeState(State.Initial);
        }

        private void ConfigureLayout()
        {
            header.Text = Localization.Header;
            header.Width = ClientSize.Width;
            infoBox.Width = ClientSize.Width;
        }

        private void SubscribeToGameEvents()
        {
            TheGame.GameStateChanged += infoBox.OnGameStateChanged;
            TheGame.GameStateChanged += restartButton.OnGameStateChanged;
            TheGame.GameStateChanged += startButton.OnGameStateChanged;
            TheGame.GameStateChanged += leaveButton.OnGameStateChanged;
            TheGame.GameStateChanged += randomAllocationButton.OnGameStateChanged;
            TheGame.GameStateChanged += opponentsFieldPictureBox.OnGameStateChanged;
            TheGame.GameStateChanged += playerFieldPictureBox.OnGameStateChanged;
            TheGame.GameStateChanged += OpponentsField.OnGameStateChanged;
            TheGame.GameStateChanged += PlayerField.OnGameStateChanged;
            TheGame.GameStateChanged += Computer.OnGameStateChanged;
            TheGame.GameStateChanged += Mouse.OnGameStateChanged;
        }

        private void buttonRandomAllocation_Click(object sender, EventArgs e)
        {
            if (TheGame.State != State.Allocated && TheGame.State != State.Initial)
                return;

            GameAction.AllocateShipsRandomly(PlayerField.Instance);
            TheGame.ChangeState(State.Allocated);
        }

        private void opponentsFieldPictureBox_Click(object sender, MouseEventArgs e)
        {
            if (TheGame.State != State.PlayerTurn)
                return;

            var cellX = e.X / GuiConstants.CellSize + 1;
            var cellY = e.Y / GuiConstants.CellSize + 1;

            GameAction.BombOpponent(cellX, cellY);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (TheGame.State != State.Allocated)
                return;

            GameAction.AllocateShipsRandomly(OpponentsField.Instance);
            opponentsFieldPictureBox.Invalidate();

            TheGame.ChangeState(State.PlayerTurn);
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            if (TheGame.State != State.GameOver)
                return;

            TheGame.ChangeState(State.Initial);
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            if (TheGame.State != State.PlayerTurn && TheGame.State != State.OpponentsTurn)
                return;

            Computer.Destroy();

            TheGame.ChangeState(State.Initial);
        }
    }
}
