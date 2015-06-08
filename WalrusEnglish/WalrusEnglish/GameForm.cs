using System.Windows.Forms;
using WalrusEngishLogc;

namespace WalrusEnglishGui
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            labelEnglishMessage.Text = GameMessage.English(MessageType.Hello);
            labelRussianMessage.Text = GameMessage.Russian(MessageType.Hello);
            
            labelPlayer1Name.Visible = false;
            labelPlayer1Points.Visible = false;
            labelPlayer1Fails.Visible = false;

            labelPlayer2Name.Visible = false;
            labelPlayer2Points.Visible = false;
            labelPlayer2Fails.Visible = false;

            labelTheWord.Visible = false;
            buttonYes.Visible = false;
            panelVariants.Visible = false;

            buttonStart.Visible = true;
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            Game.StartNew(true);
        }
    }
}
