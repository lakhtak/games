namespace SeaLines
{
    partial class SeaLinesWindow
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
            this.gameFieldPictureBox1 = new SeaLines.GameFieldPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameFieldPictureBox1
            // 
            this.gameFieldPictureBox1.BackColor = System.Drawing.Color.White;
            this.gameFieldPictureBox1.Location = new System.Drawing.Point(3, 2);
            this.gameFieldPictureBox1.Name = "gameFieldPictureBox1";
            this.gameFieldPictureBox1.Size = new System.Drawing.Size(450, 450);
            this.gameFieldPictureBox1.TabIndex = 2;
            this.gameFieldPictureBox1.TabStop = false;
            this.gameFieldPictureBox1.Click += new System.EventHandler(this.gameFieldPictureBox1_Click);
            // 
            // SeaLinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 456);
            this.Controls.Add(this.gameFieldPictureBox1);
            this.Name = "SeaLinesWindow";
            this.Text = "<<<SeaLines>>>";
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GameFieldPictureBox gameFieldPictureBox1;
    }
}

