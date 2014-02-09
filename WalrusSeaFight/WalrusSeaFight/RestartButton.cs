using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class RestartButton : Button
    {
        public void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.Initial)
                Text = Localization.RestartButton;

            Visible = e.NewState == State.GameOver;
        }
    }
}
