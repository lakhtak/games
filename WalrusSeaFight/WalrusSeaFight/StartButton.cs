using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class StartButton : Button
    {
        public void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.Initial)
                Text = Localization.StartButton;

            Visible = e.NewState == State.Allocated;
        }
    }
}
