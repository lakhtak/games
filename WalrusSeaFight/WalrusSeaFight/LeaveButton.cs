using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class LeaveButton : Button
    {
        public void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.Initial)
                Text = Localization.LeaveButton;

            Visible = e.NewState == State.PlayerTurn || e.NewState == State.OpponentsTurn;
        }
    }
}
