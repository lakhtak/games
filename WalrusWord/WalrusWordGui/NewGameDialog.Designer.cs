namespace EnglishQuestionGui
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelPlayerNumber = new System.Windows.Forms.Panel();
            this.radioTwoPlayers = new System.Windows.Forms.RadioButton();
            this.radioOnePlayer = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioThirty = new System.Windows.Forms.RadioButton();
            this.radioTwenty = new System.Windows.Forms.RadioButton();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.labelPointsToWin = new System.Windows.Forms.Label();
            this.labelPlayerOneName = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panelPlayerNumber.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayerNumber
            // 
            this.panelPlayerNumber.Controls.Add(this.labelPlayerNumber);
            this.panelPlayerNumber.Controls.Add(this.radioTwoPlayers);
            this.panelPlayerNumber.Controls.Add(this.radioOnePlayer);
            this.panelPlayerNumber.Location = new System.Drawing.Point(44, 13);
            this.panelPlayerNumber.Name = "panelPlayerNumber";
            this.panelPlayerNumber.Size = new System.Drawing.Size(116, 69);
            this.panelPlayerNumber.TabIndex = 0;
            // 
            // radioTwoPlayers
            // 
            this.radioTwoPlayers.AutoSize = true;
            this.radioTwoPlayers.Location = new System.Drawing.Point(4, 48);
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
            this.radioOnePlayer.Location = new System.Drawing.Point(4, 29);
            this.radioOnePlayer.Name = "radioOnePlayer";
            this.radioOnePlayer.Size = new System.Drawing.Size(76, 17);
            this.radioOnePlayer.TabIndex = 0;
            this.radioOnePlayer.TabStop = true;
            this.radioOnePlayer.Text = "One player";
            this.radioOnePlayer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelPointsToWin);
            this.panel2.Controls.Add(this.radioThirty);
            this.panel2.Controls.Add(this.radioTwenty);
            this.panel2.Controls.Add(this.radioTen);
            this.panel2.Location = new System.Drawing.Point(264, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 100);
            this.panel2.TabIndex = 1;
            // 
            // radioThirty
            // 
            this.radioThirty.AutoSize = true;
            this.radioThirty.Location = new System.Drawing.Point(4, 76);
            this.radioThirty.Name = "radioThirty";
            this.radioThirty.Size = new System.Drawing.Size(68, 17);
            this.radioThirty.TabIndex = 2;
            this.radioThirty.TabStop = true;
            this.radioThirty.Text = "30 points";
            this.radioThirty.UseVisualStyleBackColor = true;
            // 
            // radioTwenty
            // 
            this.radioTwenty.AutoSize = true;
            this.radioTwenty.Location = new System.Drawing.Point(4, 52);
            this.radioTwenty.Name = "radioTwenty";
            this.radioTwenty.Size = new System.Drawing.Size(68, 17);
            this.radioTwenty.TabIndex = 1;
            this.radioTwenty.TabStop = true;
            this.radioTwenty.Text = "20 points";
            this.radioTwenty.UseVisualStyleBackColor = true;
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.Location = new System.Drawing.Point(4, 28);
            this.radioTen.Name = "radioTen";
            this.radioTen.Size = new System.Drawing.Size(68, 17);
            this.radioTen.TabIndex = 0;
            this.radioTen.TabStop = true;
            this.radioTen.Text = "10 points";
            this.radioTen.UseVisualStyleBackColor = true;
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.AutoSize = true;
            this.labelPlayerNumber.Location = new System.Drawing.Point(4, 10);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(92, 13);
            this.labelPlayerNumber.TabIndex = 2;
            this.labelPlayerNumber.Text = "Number of players";
            // 
            // labelPointsToWin
            // 
            this.labelPointsToWin.AutoSize = true;
            this.labelPointsToWin.Location = new System.Drawing.Point(4, 10);
            this.labelPointsToWin.Name = "labelPointsToWin";
            this.labelPointsToWin.Size = new System.Drawing.Size(67, 13);
            this.labelPointsToWin.TabIndex = 3;
            this.labelPointsToWin.Text = "Points to win";
            // 
            // labelPlayerOneName
            // 
            this.labelPlayerOneName.AutoSize = true;
            this.labelPlayerOneName.Location = new System.Drawing.Point(44, 125);
            this.labelPlayerOneName.Name = "labelPlayerOneName";
            this.labelPlayerOneName.Size = new System.Drawing.Size(89, 13);
            this.labelPlayerOneName.TabIndex = 2;
            this.labelPlayerOneName.Text = "Player one name:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(44, 142);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(139, 20);
            this.textBox.TabIndex = 3;
            // 
            // NewGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 275);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelPlayerOneName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPlayerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGameDialog";
            this.Text = "Start New Game";
            this.panelPlayerNumber.ResumeLayout(false);
            this.panelPlayerNumber.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelPlayerNumber;
        private System.Windows.Forms.RadioButton radioTwoPlayers;
        private System.Windows.Forms.RadioButton radioOnePlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioThirty;
        private System.Windows.Forms.RadioButton radioTwenty;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.Label labelPointsToWin;
        private System.Windows.Forms.Label labelPlayerOneName;
        private System.Windows.Forms.TextBox textBox;
    }
}