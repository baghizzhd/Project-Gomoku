
namespace projectgomoku
{
    partial class winner
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
            this.playagainbut = new System.Windows.Forms.Button();
            this.exitbut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playagainbut
            // 
            this.playagainbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainbut.Location = new System.Drawing.Point(489, 356);
            this.playagainbut.Margin = new System.Windows.Forms.Padding(4);
            this.playagainbut.Name = "playagainbut";
            this.playagainbut.Size = new System.Drawing.Size(222, 64);
            this.playagainbut.TabIndex = 1;
            this.playagainbut.Text = "PLAY AGAIN!";
            this.playagainbut.UseVisualStyleBackColor = true;
            this.playagainbut.Click += new System.EventHandler(this.playagainbut_Click);
            // 
            // exitbut
            // 
            this.exitbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbut.ForeColor = System.Drawing.Color.Maroon;
            this.exitbut.Location = new System.Drawing.Point(120, 356);
            this.exitbut.Margin = new System.Windows.Forms.Padding(4);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(222, 64);
            this.exitbut.TabIndex = 2;
            this.exitbut.Text = "EXIT";
            this.exitbut.UseVisualStyleBackColor = true;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bangers", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 106);
            this.label1.TabIndex = 3;
            this.label1.Text = "GAME  OVER";
            // 
            // winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projectgomoku.Properties.Resources.Screenshot_2022_03_17_103152;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbut);
            this.Controls.Add(this.playagainbut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "winner";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playagainbut;
        private System.Windows.Forms.Button exitbut;
        private System.Windows.Forms.Label label1;
    }
}