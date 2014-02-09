using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class RandomAllocationButton : Button
    {
        public void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.Initial)
                Text = Localization.RandomAllocationButton;

            Visible = e.NewState == State.Initial || e.NewState == State.Allocated;
        }
    }
}
