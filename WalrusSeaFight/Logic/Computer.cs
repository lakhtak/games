using System;
using System.ComponentModel;
using System.Threading;

namespace Logic
{
    public class Computer
    {
        private static BackgroundWorker _computerThread;
        private static bool _interrupt;

        public static void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.OpponentsTurn)
                Move();
        }

        private static void Move()
        {
            if (TheGame.State != State.OpponentsTurn)
                return;

            _interrupt = false;
            _computerThread = new BackgroundWorker();
            _computerThread.DoWork += delegate
            {
                Thread.Sleep(GameConstants.ComputerThinkTime);
            };
            _computerThread.RunWorkerCompleted += delegate
            {
                if (!_interrupt)
                    BombPlayer();
            };
            _computerThread.RunWorkerAsync();
        }

        public static void BombPlayer()
        {
            var random = new Random();
            var x = random.Next(1, GameConstants.CellCount);
            var y = random.Next(1, GameConstants.CellCount);
            GameAction.BombPlayer(x, y);            
        }

        public static void Destroy()
        {
            _interrupt = true;
        }
    }
}
