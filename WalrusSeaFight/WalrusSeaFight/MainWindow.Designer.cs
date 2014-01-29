using System.Windows.Forms;
using Logic;

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
            this.myGameField = new WalrusSeaFight.MyFieldPictureBox();
            this.opponentsFieldPictureBox = new WalrusSeaFight.OpponentsFieldPictureBox();
            this.header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myGameField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentsFieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myGameField
            // 
            this.myGameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myGameField.Location = new System.Drawing.Point(48, 159);
            this.myGameField.Name = "myGameField";
            this.myGameField.Size = new System.Drawing.Size(300, 300);
            this.myGameField.TabIndex = 0;
            this.myGameField.TabStop = false;
            // 
            // opponentsFieldPictureBox
            // 
            this.opponentsFieldPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.opponentsFieldPictureBox.Location = new System.Drawing.Point(434, 159);
            this.opponentsFieldPictureBox.Name = "opponentsFieldPictureBox";
            this.opponentsFieldPictureBox.Size = new System.Drawing.Size(300, 300);
            this.opponentsFieldPictureBox.TabIndex = 2;
            this.opponentsFieldPictureBox.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.Color.DarkMagenta;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(784, 65);
            this.header.TabIndex = 3;
            this.header.Text = "МОРЖЕБОЙ";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WalrusSeaFight.Properties.Resources.MainBackground;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.header);
            this.Controls.Add(this.opponentsFieldPictureBox);
            this.Controls.Add(this.myGameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Моржебой!";
            ((System.ComponentModel.ISupportInitialize)(this.myGameField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentsFieldPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpponentsFieldPictureBox opponentsFieldPictureBox;
        private MyFieldPictureBox myGameField;
        private Label header;
    }
}