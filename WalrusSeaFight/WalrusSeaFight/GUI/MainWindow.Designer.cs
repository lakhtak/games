using System.Windows.Forms;

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
            this.myGameField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // myGameField
            // 
            this.myGameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myGameField.Location = new System.Drawing.Point(240, 145);
            this.myGameField.Name = "myGameField";
            this.myGameField.Size = new System.Drawing.Size(300, 300);
            this.myGameField.TabIndex = 0;
            this.myGameField.TabStop = false;
            this.myGameField.Paint += new PaintEventHandler(MyGameField.Paint);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WalrusSeaFight.Properties.Resources.MainBackground;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.myGameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Моржебой :[";
            ((System.ComponentModel.ISupportInitialize)(this.myGameField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myGameField;
    }
}