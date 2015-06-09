namespace WalrusEnglishGui
{
    partial class GameForm
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
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer2Points = new System.Windows.Forms.Label();
            this.labelPlayer1Points = new System.Windows.Forms.Label();
            this.labelEnglishMessage = new System.Windows.Forms.Label();
            this.labelRussianMessage = new System.Windows.Forms.Label();
            this.labelTheWord = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelVariants = new System.Windows.Forms.Panel();
            this.radioButtonVariant4 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant3 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant2 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant1 = new System.Windows.Forms.RadioButton();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelPlayer1Fails = new System.Windows.Forms.Label();
            this.labelPlayer2Fails = new System.Windows.Forms.Label();
            this.labelFails = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panelVariants.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Name.Location = new System.Drawing.Point(24, 27);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(61, 20);
            this.labelPlayer1Name.TabIndex = 0;
            this.labelPlayer1Name.Text = "Player1";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Name.Location = new System.Drawing.Point(390, 27);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(61, 20);
            this.labelPlayer2Name.TabIndex = 1;
            this.labelPlayer2Name.Text = "Player2";
            this.labelPlayer2Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPlayer2Points
            // 
            this.labelPlayer2Points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2Points.AutoSize = true;
            this.labelPlayer2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Points.Location = new System.Drawing.Point(427, 50);
            this.labelPlayer2Points.Name = "labelPlayer2Points";
            this.labelPlayer2Points.Size = new System.Drawing.Size(24, 25);
            this.labelPlayer2Points.TabIndex = 2;
            this.labelPlayer2Points.Text = "0";
            this.labelPlayer2Points.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPlayer1Points
            // 
            this.labelPlayer1Points.AutoSize = true;
            this.labelPlayer1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Points.Location = new System.Drawing.Point(23, 47);
            this.labelPlayer1Points.Name = "labelPlayer1Points";
            this.labelPlayer1Points.Size = new System.Drawing.Size(24, 25);
            this.labelPlayer1Points.TabIndex = 3;
            this.labelPlayer1Points.Text = "0";
            // 
            // labelEnglishMessage
            // 
            this.labelEnglishMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnglishMessage.Location = new System.Drawing.Point(81, 30);
            this.labelEnglishMessage.Name = "labelEnglishMessage";
            this.labelEnglishMessage.Size = new System.Drawing.Size(303, 68);
            this.labelEnglishMessage.TabIndex = 4;
            this.labelEnglishMessage.Text = "Hello";
            this.labelEnglishMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRussianMessage
            // 
            this.labelRussianMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRussianMessage.Location = new System.Drawing.Point(84, 133);
            this.labelRussianMessage.Name = "labelRussianMessage";
            this.labelRussianMessage.Size = new System.Drawing.Size(300, 68);
            this.labelRussianMessage.TabIndex = 5;
            this.labelRussianMessage.Text = "Привет";
            this.labelRussianMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheWord
            // 
            this.labelTheWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTheWord.AutoSize = true;
            this.labelTheWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheWord.Location = new System.Drawing.Point(170, 231);
            this.labelTheWord.Name = "labelTheWord";
            this.labelTheWord.Size = new System.Drawing.Size(126, 25);
            this.labelTheWord.TabIndex = 6;
            this.labelTheWord.Text = "THE WORD";
            this.labelTheWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(484, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "Меню";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "New game...";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelVariants
            // 
            this.panelVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelVariants.Controls.Add(this.radioButtonVariant4);
            this.panelVariants.Controls.Add(this.radioButtonVariant3);
            this.panelVariants.Controls.Add(this.radioButtonVariant2);
            this.panelVariants.Controls.Add(this.radioButtonVariant1);
            this.panelVariants.Location = new System.Drawing.Point(28, 272);
            this.panelVariants.Name = "panelVariants";
            this.panelVariants.Size = new System.Drawing.Size(324, 103);
            this.panelVariants.TabIndex = 8;
            // 
            // radioButtonVariant4
            // 
            this.radioButtonVariant4.AutoSize = true;
            this.radioButtonVariant4.Location = new System.Drawing.Point(10, 77);
            this.radioButtonVariant4.Name = "radioButtonVariant4";
            this.radioButtonVariant4.Size = new System.Drawing.Size(78, 17);
            this.radioButtonVariant4.TabIndex = 3;
            this.radioButtonVariant4.TabStop = true;
            this.radioButtonVariant4.Text = "Перевод 4";
            this.radioButtonVariant4.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariant3
            // 
            this.radioButtonVariant3.AutoSize = true;
            this.radioButtonVariant3.Location = new System.Drawing.Point(10, 54);
            this.radioButtonVariant3.Name = "radioButtonVariant3";
            this.radioButtonVariant3.Size = new System.Drawing.Size(78, 17);
            this.radioButtonVariant3.TabIndex = 2;
            this.radioButtonVariant3.TabStop = true;
            this.radioButtonVariant3.Text = "Перевод 3";
            this.radioButtonVariant3.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariant2
            // 
            this.radioButtonVariant2.AutoSize = true;
            this.radioButtonVariant2.Location = new System.Drawing.Point(10, 31);
            this.radioButtonVariant2.Name = "radioButtonVariant2";
            this.radioButtonVariant2.Size = new System.Drawing.Size(78, 17);
            this.radioButtonVariant2.TabIndex = 1;
            this.radioButtonVariant2.TabStop = true;
            this.radioButtonVariant2.Text = "Перевод 2";
            this.radioButtonVariant2.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariant1
            // 
            this.radioButtonVariant1.AutoSize = true;
            this.radioButtonVariant1.Location = new System.Drawing.Point(10, 8);
            this.radioButtonVariant1.Name = "radioButtonVariant1";
            this.radioButtonVariant1.Size = new System.Drawing.Size(78, 17);
            this.radioButtonVariant1.TabIndex = 0;
            this.radioButtonVariant1.TabStop = true;
            this.radioButtonVariant1.Text = "Перевод 1";
            this.radioButtonVariant1.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYes.Location = new System.Drawing.Point(359, 272);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(99, 103);
            this.buttonYes.TabIndex = 9;
            this.buttonYes.Text = "Да!";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(203, 235);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(81, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelPlayer1Fails
            // 
            this.labelPlayer1Fails.AutoSize = true;
            this.labelPlayer1Fails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Fails.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer1Fails.Location = new System.Drawing.Point(23, 72);
            this.labelPlayer1Fails.Name = "labelPlayer1Fails";
            this.labelPlayer1Fails.Size = new System.Drawing.Size(54, 25);
            this.labelPlayer1Fails.TabIndex = 11;
            this.labelPlayer1Fails.Text = "XXX";
            // 
            // labelPlayer2Fails
            // 
            this.labelPlayer2Fails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2Fails.AutoSize = true;
            this.labelPlayer2Fails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Fails.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer2Fails.Location = new System.Drawing.Point(397, 75);
            this.labelPlayer2Fails.Name = "labelPlayer2Fails";
            this.labelPlayer2Fails.Size = new System.Drawing.Size(54, 25);
            this.labelPlayer2Fails.TabIndex = 12;
            this.labelPlayer2Fails.Text = "XXX";
            this.labelPlayer2Fails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFails
            // 
            this.labelFails.AutoSize = true;
            this.labelFails.Location = new System.Drawing.Point(336, 235);
            this.labelFails.Name = "labelFails";
            this.labelFails.Size = new System.Drawing.Size(122, 13);
            this.labelFails.TabIndex = 13;
            this.labelFails.Text = "Играем до 0 промахов";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(25, 231);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(102, 13);
            this.labelPoints.TabIndex = 14;
            this.labelPoints.Text = "Играем до 0 очков";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelFails);
            this.Controls.Add(this.labelPlayer2Fails);
            this.Controls.Add(this.labelPlayer1Fails);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTheWord);
            this.Controls.Add(this.labelRussianMessage);
            this.Controls.Add(this.labelEnglishMessage);
            this.Controls.Add(this.labelPlayer1Points);
            this.Controls.Add(this.labelPlayer2Points);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panelVariants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "English Question";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelVariants.ResumeLayout(false);
            this.panelVariants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer2Points;
        private System.Windows.Forms.Label labelPlayer1Points;
        private System.Windows.Forms.Label labelEnglishMessage;
        private System.Windows.Forms.Label labelRussianMessage;
        private System.Windows.Forms.Label labelTheWord;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Panel panelVariants;
        private System.Windows.Forms.RadioButton radioButtonVariant4;
        private System.Windows.Forms.RadioButton radioButtonVariant3;
        private System.Windows.Forms.RadioButton radioButtonVariant2;
        private System.Windows.Forms.RadioButton radioButtonVariant1;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPlayer1Fails;
        private System.Windows.Forms.Label labelPlayer2Fails;
        private System.Windows.Forms.Label labelFails;
        private System.Windows.Forms.Label labelPoints;
    }
}

