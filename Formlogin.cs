using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectgomoku
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
        public static string player1, player2;
        private void playgame_Click(object sender, EventArgs e)
        {
            if(textBoxplayer1.Text!="" && textBoxplayer2.Text != "")
            {
                player1 = textBoxplayer1.Text;
                player2 = textBoxplayer2.Text;
                GoMoKu fr1 = new GoMoKu();
                this.Hide();
                fr1.Show();
            }
        }
    }
}
