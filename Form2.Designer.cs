
namespace projectgomoku
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.playagain = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bangers", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(142, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORRY, ALL THE BOARDS ";
            // 
            // playagain
            // 
            this.playagain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain.ForeColor = System.Drawing.Color.LawnGreen;
            this.playagain.Location = new System.Drawing.Point(390, 312);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(146, 41);
            this.playagain.TabIndex = 1;
            this.playagain.Text = "PLAY AGAIN";
            this.playagain.UseVisualStyleBackColor = false;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(91, 312);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(146, 41);
            this.exit.TabIndex = 2;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bangers", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(223, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "ARE FILLED!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form2";
            this.Text = "Boards Filled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
    }
}