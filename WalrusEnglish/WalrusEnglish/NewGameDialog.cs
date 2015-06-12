using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalrusEngishLogc;

namespace WalrusEnglishGui
{
    public partial class NewGameDialog : Form
    {
        public NewGameDialog()
        {
            InitializeComponent();
        }

        private void buttonCance_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!ValidateControls()) return;

            var failsToLose = 0;
            foreach (var radioFailsToLose in panelFailsToLose.Controls.OfType<RadioButton>().Where(radioFailsToLose => radioFailsToLose.Checked))
            {
                failsToLose = Constants.FailsCount[radioFailsToLose.TabIndex];
            }

            if (failsToLose == 0)
                throw new InvalidOperationException("failsToLose = 0!");

            var pointsToWin = 0;
            foreach (var radioPointsToWin in panelPointsToWin.Controls.OfType<RadioButton>().Where(radioPointsToWin => radioPointsToWin.Checked))
            {
                pointsToWin = Constants.PointsToWin[radioPointsToWin.TabIndex];
            }

            if (pointsToWin == 0)
                throw new InvalidOperationException("pointsToWin = 0!");

            Game.StartNew(textBoxPlayer1Name.Text, textBoxPlayer2Name.Text, radioEnglishRussian.Checked, failsToLose, pointsToWin);
            Close();
            Program.TheGameForm.SetStartMessage();
            Program.TheGameForm.Redraw();
        }

        private bool ValidateControls()
        {
            if (!string.IsNullOrWhiteSpace(textBoxPlayer1Name.Text)) return true;

            MessageBox.Show("Please enter the name of player one. Пожалуйста введите имя первого игрока.",
                "Error. Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void radioOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            labelPlayerTwoName.Visible = !radioOnePlayer.Checked;
            textBoxPlayer2Name.Visible = !radioOnePlayer.Checked;
            
            if (radioOnePlayer.Checked)
                textBoxPlayer2Name.Text = string.Empty;
        }

        private void NewGameDialog_Load(object sender, EventArgs e)
        {
            radioTwoPlayers.Checked = true;

            radioFails1.Text = Constants.FailsCount[0] + " fail(s)";
            radioFails2.Text = Constants.FailsCount[1] + " fail(s)";
            radioFails3.Text = Constants.FailsCount[2] + " fail(s)";

            radioPoints1.Text = Constants.PointsToWin[0] + " point(s)";
            radioPoints2.Text = Constants.PointsToWin[1] + " point(s)";
            radioPoints3.Text = Constants.PointsToWin[2] + " point(s)";
        }
    }
}
