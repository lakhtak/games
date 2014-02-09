using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class InfoBox : Label
    {
        public void OnGameStateChanged(State state)
        {
            switch (state)
            {
                case State.Initial:
                    Text = Localization.PleaseAllocateShips;
                    break;
                case State.Allocated:
                    Text = Localization.PleaseAllocateShips;
                    break;
                case State.PlayerTurn:
                    Text = Localization.ItsYourTurn;
                    break;
                case State.OpponentsTurn:
                    Text = Localization.ItsOpponentsTurn;
                    break;
                case State.GameOver:
                    Text = Localization.GameOver;
                    break;
            }
        }
    }
}
