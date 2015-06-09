using System;
using System.Globalization;
using System.Linq;
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

            labelFails.Visible = false;
            labelPoints.Visible = false;

            buttonStart.Visible = true;
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            var startDialog = new NewGameDialog();
            startDialog.ShowDialog();
        }

        public void Redraw()
        {
            labelEnglishMessage.Text = string.Format(GameMessage.English(MessageType.MakeMove), Game.CurrentPlayer.Name);
            labelRussianMessage.Text = string.Format(GameMessage.Russian(MessageType.MakeMove), Game.CurrentPlayer.Name);

            labelPlayer1Name.Text = Game.PlayerOne.Name;
            labelPlayer1Name.Visible = true;
            labelPlayer1Points.Text = Game.PlayerOne.Points.ToString(CultureInfo.InvariantCulture);
            labelPlayer1Points.Visible = true;
            labelPlayer1Fails.Text = new String('X', Game.PlayerOne.Fails);
            labelPlayer1Fails.Visible = true;

            if (Game.PlayerTwo != null)
            {
                labelPlayer2Name.Text = Game.PlayerTwo.Name;
                labelPlayer2Points.Text = Game.PlayerTwo.Points.ToString(CultureInfo.InvariantCulture);
                labelPlayer2Fails.Text = new String('X', Game.PlayerTwo.Fails);
            }
            labelPlayer2Name.Visible = Game.PlayerTwo != null;
            labelPlayer2Points.Visible = Game.PlayerTwo != null;
            labelPlayer2Fails.Visible = Game.PlayerTwo != null;

            buttonYes.Visible = true;
            panelVariants.Visible = true;

            labelFails.Text = string.Format("Играем до {0} промахов.", Game.FailsToLose.ToString(CultureInfo.InvariantCulture));
            labelFails.Visible = true;

            labelPoints.Text = string.Format("Играем до {0} очков.", Game.PointsToWin.ToString(CultureInfo.InvariantCulture));
            labelPoints.Visible = true;

            buttonStart.Visible = false;

            labelTheWord.Text = Game.WordDictionary.GetNextWord();
            labelTheWord.Visible = true;

            var variants = Game.WordDictionary.GetVariants();
            foreach (var radioVariant in panelVariants.Controls.OfType<RadioButton>())
            {
                radioVariant.Text = variants[radioVariant.TabIndex];
            }
            
            Refresh();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (!panelVariants.Controls.OfType<RadioButton>().Any(radioVariant => radioVariant.Checked))
            {
                MessageBox.Show("Please choose correct word translation. Пожалуйста выберите правильный перевод слова.",
                "Error. Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var correctAnswer =
                Game.WordDictionary.IsAnswerCorrect(
                    panelVariants.Controls.OfType<RadioButton>().First(radioVariant => radioVariant.Checked).Text);

            labelEnglishMessage.Text = string.Format(GameMessage.English(correctAnswer ? MessageType.CorrectAnswer : MessageType.IncorrectAnswer), Game.CurrentPlayer.Name, Constants.OneSuccessCost);
            labelRussianMessage.Text = string.Format(GameMessage.Russian(correctAnswer ? MessageType.CorrectAnswer : MessageType.IncorrectAnswer), Game.CurrentPlayer.Name, Game.CurrentPlayer.Fails);
        }
    }
}
