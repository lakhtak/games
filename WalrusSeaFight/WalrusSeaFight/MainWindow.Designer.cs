using System.Drawing;
using System.Windows.Forms;
using Logic;
using WalrusSeaFight.Properties;

namespace WalrusSeaFight
{
    partial class MainWindow
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
            this.header = new System.Windows.Forms.Label();
            this.randomAllocationButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.Label();
            this.opponentsFieldPictureBox = new WalrusSeaFight.OpponentsFieldPictureBox();
            this.playerFieldPictureBox = new WalrusSeaFight.PlayerFieldPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.opponentsFieldPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.Color.DarkMagenta;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 65);
            this.header.TabIndex = 3;
            this.header.Text = "МОРЖЕБОЙ";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomAllocationButton
            // 
            this.randomAllocationButton.AutoSize = true;
            this.randomAllocationButton.Location = new System.Drawing.Point(48, 518);
            this.randomAllocationButton.Name = "randomAllocationButton";
            this.randomAllocationButton.Size = new System.Drawing.Size(138, 24);
            this.randomAllocationButton.TabIndex = 4;
            this.randomAllocationButton.Text = "Random allocation";
            this.randomAllocationButton.UseVisualStyleBackColor = true;
            this.randomAllocationButton.Click += new System.EventHandler(this.buttonRandomAllocation_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(273, 518);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(77, 24);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.Location = new System.Drawing.Point(273, 518);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(77, 24);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.AutoSize = true;
            this.leaveButton.Location = new System.Drawing.Point(273, 518);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(77, 24);
            this.leaveButton.TabIndex = 5;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.Transparent;
            this.infoBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBox.ForeColor = System.Drawing.Color.Purple;
            this.infoBox.Location = new System.Drawing.Point(0, 134);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(284, 30);
            this.infoBox.TabIndex = 6;
            this.infoBox.Text = "Моржебой загружается...";
            this.infoBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opponentsFieldPictureBox
            // 
            this.opponentsFieldPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.opponentsFieldPictureBox.Location = new System.Drawing.Point(434, 201);
            this.opponentsFieldPictureBox.Name = "opponentsFieldPictureBox";
            this.opponentsFieldPictureBox.Size = new System.Drawing.Size(300, 300);
            this.opponentsFieldPictureBox.TabIndex = 2;
            this.opponentsFieldPictureBox.TabStop = false;
            this.opponentsFieldPictureBox.MouseClick += new MouseEventHandler(opponentsFieldPictureBox_Click);
            // 
            // playerFieldPictureBox
            // 
            this.playerFieldPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerFieldPictureBox.Location = new System.Drawing.Point(48, 201);
            this.playerFieldPictureBox.Name = "playerFieldPictureBox";
            this.playerFieldPictureBox.Size = new System.Drawing.Size(300, 300);
            this.playerFieldPictureBox.TabIndex = 0;
            this.playerFieldPictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WalrusSeaFight.Properties.Resources.MainBackground;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.randomAllocationButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.opponentsFieldPictureBox);
            this.Controls.Add(this.playerFieldPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Моржебой!";
            ((System.ComponentModel.ISupportInitialize)(this.opponentsFieldPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFieldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpponentsFieldPictureBox opponentsFieldPictureBox;
        private PlayerFieldPictureBox playerFieldPictureBox;
        private Label header;
        private Button randomAllocationButton;
        private Button startButton;
        private Button restartButton;
        private Button leaveButton;
        private Label infoBox;
    }
}