using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    public class RandomAllocationButton : Button
    {
        public void OnGameStateChanged(State state)
        {
            if (state == State.Initial)
                Text = Localization.RandomAllocationButton;

            Visible = state == State.Initial || state == State.Allocated;
        }
    }
}
