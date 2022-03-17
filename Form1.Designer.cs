
namespace projectgomoku
{
    partial class GoMoKu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoMoKu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelplayer1 = new System.Windows.Forms.Label();
            this.labelplayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(308, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2";
            // 
            // labelplayer1
            // 
            this.labelplayer1.AutoSize = true;
            this.labelplayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelplayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelplayer1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelplayer1.Location = new System.Drawing.Point(66, 50);
            this.labelplayer1.Name = "labelplayer1";
            this.labelplayer1.Size = new System.Drawing.Size(85, 26);
            this.labelplayer1.TabIndex = 3;
            this.labelplayer1.Text = "Player 1";
            this.labelplayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelplayer2
            // 
            this.labelplayer2.AutoSize = true;
            this.labelplayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelplayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelplayer2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelplayer2.Location = new System.Drawing.Point(308, 50);
            this.labelplayer2.Name = "labelplayer2";
            this.labelplayer2.Size = new System.Drawing.Size(85, 26);
            this.labelplayer2.TabIndex = 4;
            this.labelplayer2.Text = "Player 2";
            this.labelplayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoMoKu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 561);
            this.Controls.Add(this.labelplayer2);
            this.Controls.Add(this.labelplayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoMoKu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoMoKu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelplayer1;
        private System.Windows.Forms.Label labelplayer2;
    }
}

