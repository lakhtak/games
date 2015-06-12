namespace WalrusEnglishGui
{
    partial class NewGameDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPlayerNumber = new System.Windows.Forms.Panel();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.radioTwoPlayers = new System.Windows.Forms.RadioButton();
            this.radioOnePlayer = new System.Windows.Forms.RadioButton();
            this.panelPointsToWin = new System.Windows.Forms.Panel();
            this.labelPointsToWin = new System.Windows.Forms.Label();
            this.radioPoints3 = new System.Windows.Forms.RadioButton();
            this.radioPoints2 = new System.Windows.Forms.RadioButton();
            this.radioPoints1 = new System.Windows.Forms.RadioButton();
            this.labelPlayerOneName = new System.Windows.Forms.Label();
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.labelPlayerTwoName = new System.Windows.Forms.Label();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.panelFailsToLose = new System.Windows.Forms.Panel();
            this.labelFailCount = new System.Windows.Forms.Label();
            this.radioFails3 = new System.Windows.Forms.RadioButton();
            this.radioFails2 = new System.Windows.Forms.RadioButton();
            this.radioFails1 = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCance = new System.Windows.Forms.Button();
            this.panelTranslation = new System.Windows.Forms.Panel();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.radioRussianEnglish = new System.Windows.Forms.RadioButton();
            this.radioEnglishRussian = new System.Windows.Forms.RadioButton();
            this.panelPlayerNumber.SuspendLayout();
            this.panelPointsToWin.SuspendLayout();
            this.panelFailsToLose.SuspendLayout();
            this.panelTranslation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayerNumber
            // 
            this.panelPlayerNumber.Controls.Add(this.labelPlayers);
            this.panelPlayerNumber.Controls.Add(this.radioTwoPlayers);
            this.panelPlayerNumber.Controls.Add(this.radioOnePlayer);
            this.panelPlayerNumber.Location = new System.Drawing.Point(12, 12);
            this.panelPlayerNumber.Name = "panelPlayerNumber";
            this.panelPlayerNumber.Size = new System.Drawing.Size(370, 96);
            this.panelPlayerNumber.TabIndex = 0;
            this.panelPlayerNumber.Tag = "";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(4, 5);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(41, 13);
            this.labelPlayers.TabIndex = 2;
            this.labelPlayers.Text = "Players";
            // 
            // radioTwoPlayers
            // 
            this.radioTwoPlayers.AutoSize = true;
            this.radioTwoPlayers.Checked = true;
            this.radioTwoPlayers.Location = new System.Drawing.Point(10, 57);
            this.radioTwoPlayers.Name = "radioTwoPlayers";
            this.radioTwoPlayers.Size = new System.Drawing.Size(82, 17);
            this.radioTwoPlayers.TabIndex = 1;
            this.radioTwoPlayers.TabStop = true;
            this.radioTwoPlayers.Text = "Two players";
            this.radioTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // radioOnePlayer
            // 
            this.radioOnePlayer.AutoSize = true;
            this.radioOnePlayer.Location = new System.Drawing.Point(10, 27);
            this.radioOnePlayer.Name = "radioOnePlayer";
            this.radioOnePlayer.Size = new System.Drawing.Size(76, 17);
            this.radioOnePlayer.TabIndex = 0;
            this.radioOnePlayer.TabStop = true;
            this.radioOnePlayer.Text = "One player";
            this.radioOnePlayer.UseVisualStyleBackColor = true;
            this.radioOnePlayer.CheckedChanged += new System.EventHandler(this.radioOnePlayer_CheckedChanged);
            // 
            // panelPointsToWin
            // 
            this.panelPointsToWin.Controls.Add(this.labelPointsToWin);
            this.panelPointsToWin.Controls.Add(this.radioPoints3);
            this.panelPointsToWin.Controls.Add(this.radioPoints2);
            this.panelPointsToWin.Controls.Add(this.radioPoints1);
            this.panelPointsToWin.Location = new System.Drawing.Point(12, 134);
            this.panelPointsToWin.Name = "panelPointsToWin";
            this.panelPointsToWin.Size = new System.Drawing.Size(76, 100);
            this.panelPointsToWin.TabIndex = 1;
            // 
            // labelPointsToWin
            // 
            this.labelPointsToWin.AutoSize = true;
            this.labelPointsToWin.Location = new System.Drawing.Point(1, 10);
            this.labelPointsToWin.Name = "labelPointsToWin";
            this.labelPointsToWin.Size = new System.Drawing.Size(67, 13);
            this.labelPointsToWin.TabIndex = 3;
            this.labelPointsToWin.Text = "Points to win";
            // 
            // radioPoints3
            // 
            this.radioPoints3.AutoSize = true;
            this.radioPoints3.Location = new System.Drawing.Point(4, 76);
            this.radioPoints3.Name = "radioPoints3";
            this.radioPoints3.Size = new System.Drawing.Size(68, 17);
            this.radioPoints3.TabIndex = 2;
            this.radioPoints3.Text = "15 points";
            this.radioPoints3.UseVisualStyleBackColor = true;
            // 
            // radioPoints2
            // 
            this.radioPoints2.AutoSize = true;
            this.radioPoints2.Checked = true;
            this.radioPoints2.Location = new System.Drawing.Point(4, 52);
            this.radioPoints2.Name = "radioPoints2";
            this.radioPoints2.Size = new System.Drawing.Size(68, 17);
            this.radioPoints2.TabIndex = 1;
            this.radioPoints2.TabStop = true;
            this.radioPoints2.Text = "10 points";
            this.radioPoints2.UseVisualStyleBackColor = true;
            // 
            // radioPoints1
            // 
            this.radioPoints1.AutoSize = true;
            this.radioPoints1.Location = new System.Drawing.Point(4, 28);
            this.radioPoints1.Name = "radioPoints1";
            this.radioPoints1.Size = new System.Drawing.Size(62, 17);
            this.radioPoints1.TabIndex = 0;
            this.radioPoints1.Text = "5 points";
            this.radioPoints1.UseVisualStyleBackColor = true;
            // 
            // labelPlayerOneName
            // 
            this.labelPlayerOneName.AutoSize = true;
            this.labelPlayerOneName.Location = new System.Drawing.Point(147, 41);
            this.labelPlayerOneName.Name = "labelPlayerOneName";
            this.labelPlayerOneName.Size = new System.Drawing.Size(89, 13);
            this.labelPlayerOneName.TabIndex = 2;
            this.labelPlayerOneName.Text = "Player one name:";
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(233, 38);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(139, 20);
            this.textBoxPlayer1Name.TabIndex = 3;
            // 
            // labelPlayerTwoName
            // 
            this.labelPlayerTwoName.AutoSize = true;
            this.labelPlayerTwoName.Location = new System.Drawing.Point(148, 71);
            this.labelPlayerTwoName.Name = "labelPlayerTwoName";
            this.labelPlayerTwoName.Size = new System.Drawing.Size(88, 13);
            this.labelPlayerTwoName.TabIndex = 4;
            this.labelPlayerTwoName.Text = "Player two name:";
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(233, 68);
            this.textBoxPlayer2Name.MaxLength = 20;
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(139, 20);
            this.textBoxPlayer2Name.TabIndex = 5;
            // 
            // panelFailsToLose
            // 
            this.panelFailsToLose.Controls.Add(this.labelFailCount);
            this.panelFailsToLose.Controls.Add(this.radioFails3);
            this.panelFailsToLose.Controls.Add(this.radioFails2);
            this.panelFailsToLose.Controls.Add(this.radioFails1);
            this.panelFailsToLose.Location = new System.Drawing.Point(112, 134);
            this.panelFailsToLose.Name = "panelFailsToLose";
            this.panelFailsToLose.Size = new System.Drawing.Size(82, 100);
            this.panelFailsToLose.TabIndex = 6;
            // 
            // labelFailCount
            // 
            this.labelFailCount.AutoSize = true;
            this.labelFailCount.Location = new System.Drawing.Point(1, 10);
            this.labelFailCount.Name = "labelFailCount";
            this.labelFailCount.Size = new System.Drawing.Size(77, 13);
            this.labelFailCount.TabIndex = 3;
            this.labelFailCount.Text = "Number of fails";
            // 
            // radioFails3
            // 
            this.radioFails3.AutoSize = true;
            this.radioFails3.Location = new System.Drawing.Point(4, 76);
            this.radioFails3.Name = "radioFails3";
            this.radioFails3.Size = new System.Drawing.Size(52, 17);
            this.radioFails3.TabIndex = 2;
            this.radioFails3.Text = "3 fails";
            this.radioFails3.UseVisualStyleBackColor = true;
            // 
            // radioFails2
            // 
            this.radioFails2.AutoSize = true;
            this.radioFails2.Checked = true;
            this.radioFails2.Location = new System.Drawing.Point(4, 52);
            this.radioFails2.Name = "radioFails2";
            this.radioFails2.Size = new System.Drawing.Size(52, 17);
            this.radioFails2.TabIndex = 1;
            this.radioFails2.TabStop = true;
            this.radioFails2.Text = "2 fails";
            this.radioFails2.UseVisualStyleBackColor = true;
            // 
            // radioFails1
            // 
            this.radioFails1.AutoSize = true;
            this.radioFails1.Location = new System.Drawing.Point(4, 28);
            this.radioFails1.Name = "radioFails1";
            this.radioFails1.Size = new System.Drawing.Size(47, 17);
            this.radioFails1.TabIndex = 0;
            this.radioFails1.Text = "1 fail";
            this.radioFails1.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(211, 247);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCance
            // 
            this.buttonCance.Location = new System.Drawing.Point(307, 247);
            this.buttonCance.Name = "buttonCance";
            this.buttonCance.Size = new System.Drawing.Size(75, 23);
            this.buttonCance.TabIndex = 8;
            this.buttonCance.Text = "Cancel";
            this.buttonCance.UseVisualStyleBackColor = true;
            this.buttonCance.Click += new System.EventHandler(this.buttonCance_Click);
            // 
            // panelTranslation
            // 
            this.panelTranslation.Controls.Add(this.labelTranslation);
            this.panelTranslation.Controls.Add(this.radioRussianEnglish);
            this.panelTranslation.Controls.Add(this.radioEnglishRussian);
            this.panelTranslation.Location = new System.Drawing.Point(211, 134);
            this.panelTranslation.Name = "panelTranslation";
            this.panelTranslation.Size = new System.Drawing.Size(171, 100);
            this.panelTranslation.TabIndex = 9;
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(3, 10);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(59, 13);
            this.labelTranslation.TabIndex = 6;
            this.labelTranslation.Text = "Translation";
            // 
            // radioRussianEnglish
            // 
            this.radioRussianEnglish.AutoSize = true;
            this.radioRussianEnglish.Location = new System.Drawing.Point(6, 52);
            this.radioRussianEnglish.Name = "radioRussianEnglish";
            this.radioRussianEnglish.Size = new System.Drawing.Size(138, 17);
            this.radioRussianEnglish.TabIndex = 5;
            this.radioRussianEnglish.Text = "From Russian to English";
            this.radioRussianEnglish.UseVisualStyleBackColor = true;
            // 
            // radioEnglishRussian
            // 
            this.radioEnglishRussian.AutoSize = true;
            this.radioEnglishRussian.Checked = true;
            this.radioEnglishRussian.Location = new System.Drawing.Point(6, 28);
            this.radioEnglishRussian.Name = "radioEnglishRussian";
            this.radioEnglishRussian.Size = new System.Drawing.Size(138, 17);
            this.radioEnglishRussian.TabIndex = 4;
            this.radioEnglishRussian.TabStop = true;
            this.radioEnglishRussian.Text = "From English to Russian";
            this.radioEnglishRussian.UseVisualStyleBackColor = true;
            // 
            // NewGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.panelTranslation);
            this.Controls.Add(this.buttonCance);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelFailsToLose);
            this.Controls.Add(this.textBoxPlayer2Name);
            this.Controls.Add(this.labelPlayerTwoName);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Controls.Add(this.labelPlayerOneName);
            this.Controls.Add(this.panelPointsToWin);
            this.Controls.Add(this.panelPlayerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGameDialog";
            this.Text = "Start New Game";
            this.Load += new System.EventHandler(this.NewGameDialog_Load);
            this.panelPlayerNumber.ResumeLayout(false);
            this.panelPlayerNumber.PerformLayout();
            this.panelPointsToWin.ResumeLayout(false);
            this.panelPointsToWin.PerformLayout();
            this.panelFailsToLose.ResumeLayout(false);
            this.panelFailsToLose.PerformLayout();
            this.panelTranslation.ResumeLayout(false);
            this.panelTranslation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayerNumber;
        private System.Windows.Forms.RadioButton radioTwoPlayers;
        private System.Windows.Forms.RadioButton radioOnePlayer;
        private System.Windows.Forms.Panel panelPointsToWin;
        private System.Windows.Forms.RadioButton radioPoints3;
        private System.Windows.Forms.RadioButton radioPoints2;
        private System.Windows.Forms.RadioButton radioPoints1;
        private System.Windows.Forms.Label labelPointsToWin;
        private System.Windows.Forms.Label labelPlayerOneName;
        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label labelPlayerTwoName;
        private System.Windows.Forms.TextBox textBoxPlayer2Name;
        private System.Windows.Forms.Panel panelFailsToLose;
        private System.Windows.Forms.Label labelFailCount;
        private System.Windows.Forms.RadioButton radioFails3;
        private System.Windows.Forms.RadioButton radioFails2;
        private System.Windows.Forms.RadioButton radioFails1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCance;
        private System.Windows.Forms.Panel panelTranslation;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.RadioButton radioRussianEnglish;
        private System.Windows.Forms.RadioButton radioEnglishRussian;
    }
}