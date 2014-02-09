using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class RestartButton : Button
    {
        public void OnGameStateChanged(State state)
        {
            if (state == State.Initial)
                Text = Localization.RestartButton;

            Visible = state == State.GameOver;
        }
    }
}
