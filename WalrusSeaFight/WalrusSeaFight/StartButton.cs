using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class StartButton : Button
    {
        public void OnGameStateChanged(State state)
        {
            if (state == State.Initial)
                Text = Localization.StartButton;

            Visible = state == State.Allocated;
        }
    }
}
