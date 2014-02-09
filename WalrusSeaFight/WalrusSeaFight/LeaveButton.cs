using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class LeaveButton : Button
    {
        public void OnGameStateChanged(State state)
        {
            if (state == State.Initial)
                Text = Localization.LeaveButton;

            Visible = state == State.PlayerTurn || state == State.OpponentsTurn;
        }
    }
}
