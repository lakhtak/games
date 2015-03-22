using System;
using System.Linq;

namespace CrossNull
{
    class Game
    {
        public Who Turn { get; private set; }

        public Player CurrentPlayer { get; private set; }

        public Player PlayerX { get; private set; }
        public Player PlayerO { get; private set; }

        public Game(Player playerX, Player playerO)
        {
            PlayerX = playerX;
            PlayerO = playerO;
            CurrentPlayer = null;
        }
        
        public void SwitchTurn()
        {
            if (CurrentPlayer == null || CurrentPlayer.Symbol == Who.O)
                CurrentPlayer = PlayerX;
            else
                CurrentPlayer = PlayerO;
        }

        public void CheckWinner()
        {
            if (GameField.Diagonal1.All(cell => cell == CurrentPlayer.Symbol) ||
                GameField.Diagonal2.All(cell => cell == CurrentPlayer.Symbol) ||
                GameField.Rows.Any(row => row.All(cell => cell == CurrentPlayer.Symbol)) ||
                GameField.Columns.Any(column => column.All(cell => cell == CurrentPlayer.Symbol)))
            {
                CurrentPlayer.Winner = true;
            }
        }
    }
}
