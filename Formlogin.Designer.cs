
namespace projectgomoku
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxplayer1 = new System.Windows.Forms.TextBox();
            this.textBoxplayer2 = new System.Windows.Forms.TextBox();
            this.playgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // textBoxplayer1
            // 
            this.textBoxplayer1.Location = new System.Drawing.Point(128, 112);
            this.textBoxplayer1.Name = "textBoxplayer1";
            this.textBoxplayer1.Size = new System.Drawing.Size(152, 22);
            this.textBoxplayer1.TabIndex = 2;
            this.textBoxplayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxplayer2
            // 
            this.textBoxplayer2.Location = new System.Drawing.Point(552, 112);
            this.textBoxplayer2.Name = "textBoxplayer2";
            this.textBoxplayer2.Size = new System.Drawing.Size(152, 22);
            this.textBoxplayer2.TabIndex = 3;
            this.textBoxplayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playgame
            // 
            this.playgame.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playgame.Font = new System.Drawing.Font("Bangers", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playgame.ForeColor = System.Drawing.Color.White;
            this.playgame.Location = new System.Drawing.Point(326, 182);
            this.playgame.Name = "playgame";
            this.playgame.Size = new System.Drawing.Size(195, 51);
            this.playgame.TabIndex = 4;
            this.playgame.Text = "PLAY GAME";
            this.playgame.UseVisualStyleBackColor = false;
            this.playgame.Click += new System.EventHandler(this.playgame_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 514);
            this.Controls.Add(this.playgame);
            this.Controls.Add(this.textBoxplayer2);
            this.Controls.Add(this.textBoxplayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxplayer1;
        private System.Windows.Forms.TextBox textBoxplayer2;
        private System.Windows.Forms.Button playgame;
    }
}