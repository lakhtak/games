using System;
using System.Threading;
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
            ChangeState();
        }

        private void ConfigureLayout()
        {
            header.Text = Localization.Header;
            header.Width = ClientSize.Width;
            
            infoBox.Width = ClientSize.Width;

            randomAllocationButton.Text = Localization.RandomAllocationButton;
            startButton.Text = Localization.StartButton;
            restartButton.Text = Localization.RestartButton;
            leaveButton.Text = Localization.LeaveButton;
        }

        public void ChangeState()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    ChangeControlVisibility();
                    PerformStateActions();                    
                }));
            }
            else
            {
                ChangeControlVisibility();
                PerformStateActions();
            }
        }

        private void ChangeControlVisibility()
        {
            switch (GameState.State)
            {
                case State.Initial:
                    opponentsFieldPictureBox.Visible = false;
                    randomAllocationButton.Visible = true;
                    startButton.Visible = false;
                    restartButton.Visible = false;
                    leaveButton.Visible = false;
                    break;
                case State.Allocated:
                    opponentsFieldPictureBox.Visible = false;
                    randomAllocationButton.Visible = true;
                    startButton.Visible = true;
                    restartButton.Visible = false;
                    leaveButton.Visible = false;
                    break;
                case State.PlayerTurn:
                    opponentsFieldPictureBox.Visible = true;
                    randomAllocationButton.Visible = false;
                    startButton.Visible = false;
                    restartButton.Visible = false;
                    leaveButton.Visible = true;
                    break;
                case State.Wait:
                    opponentsFieldPictureBox.Visible = true;
                    randomAllocationButton.Visible = false;
                    startButton.Visible = false;
                    restartButton.Visible = false;
                    leaveButton.Visible = true;
                    break;
                case State.GameOver:
                    opponentsFieldPictureBox.Visible = true;
                    randomAllocationButton.Visible = false;
                    startButton.Visible = false;
                    restartButton.Visible = true;
                    leaveButton.Visible = false;
                    break;
            }
        }

        private void PerformStateActions()
        {
            switch (GameState.State)
            {
                case State.Initial:
                    PlayerField.Instance.Clear();
                    playerFieldPictureBox.Invalidate();
                    infoBox.Text = Localization.PleaseAllocateShips;
                    break;
                case State.Allocated:
                    GameAction.AllocateShipsRandomly(PlayerField.Instance);
                    playerFieldPictureBox.Invalidate();
                    break;
                case State.PlayerTurn:
                    Mouse.FlushAllEvents();
                    opponentsFieldPictureBox.Invalidate();
                    playerFieldPictureBox.Invalidate();
                    infoBox.Text = Localization.ItsYourTurn;
                    break;
                case State.Wait:
                    infoBox.Text = Localization.ItsOpponentsTurn;
                    opponentsFieldPictureBox.Refresh();
                    infoBox.Refresh();
                    ComputerMove();
                    break;
                case State.GameOver:
                    Mouse.FlushAllEvents();
                    opponentsFieldPictureBox.Invalidate();
                    playerFieldPictureBox.Invalidate();
                    infoBox.Text = Localization.GameOver;
                    break;
            }
        }

        public Thread ComputerThread;

        private void ComputerMove()
        {
            if (GameState.State != State.Wait)
                return;

            ComputerThread = new Thread(() =>
            {
                Thread.Sleep(GameConstants.ComputerThinkTime);
                GameState.State = State.PlayerTurn;
                ChangeState();
            });
            ComputerThread.Start();
        }

        private void buttonRandomAllocation_Click(object sender, EventArgs e)
        {
            if (GameState.State != State.Allocated && GameState.State != State.Initial)
                return;

            GameState.State = State.Allocated;
            ChangeState();
        }

        private void opponentsFieldPictureBox_Click(object sender, MouseEventArgs e)
        {
            if (GameState.State != State.PlayerTurn)
                return;

            var cellX = e.X / GuiConstants.CellSize + 1;
            var cellY = e.Y / GuiConstants.CellSize + 1;

            GameAction.BombOpponent(cellX, cellY);
            ChangeState();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (GameState.State != State.Allocated)
                return;

            GameAction.AllocateShipsRandomly(OpponentsField.Instance);
            opponentsFieldPictureBox.Invalidate();

            GameState.State = State.PlayerTurn;
            ChangeState();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            if (GameState.State != State.GameOver)
                return;

            GameState.State = State.Initial;
            ChangeState();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            if (GameState.State != State.PlayerTurn && GameState.State != State.Wait)
                return;

            ComputerThread.Abort();

            GameState.State = State.Initial;
            ChangeState();
        }
    }
}
