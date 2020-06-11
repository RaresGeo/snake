namespace Snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbArena = new System.Windows.Forms.PictureBox();
            this.lScore = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.delta = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArena)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArena
            // 
            this.pbArena.Location = new System.Drawing.Point(13, 13);
            this.pbArena.Name = "pbArena";
            this.pbArena.Size = new System.Drawing.Size(570, 570);
            this.pbArena.TabIndex = 0;
            this.pbArena.TabStop = false;
            this.pbArena.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArena_Paint);
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lScore.Location = new System.Drawing.Point(610, 13);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(163, 55);
            this.lScore.TabIndex = 1;
            this.lScore.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScore.Location = new System.Drawing.Point(779, 13);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 55);
            this.labelScore.TabIndex = 2;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGameOver.Location = new System.Drawing.Point(84, 31);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(0, 37);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1216, 596);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.pbArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#";
            ((System.ComponentModel.ISupportInitialize)(this.pbArena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArena;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer delta;
        private System.Windows.Forms.Label labelGameOver;
    }
}

