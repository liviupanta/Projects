using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityWar
{
    public partial class Winner : Form
    {
        public Winner(string win_name, string conclusion, string name_planet, Image winner)
        {
            InitializeComponent();
            name.Text = win_name + " WINS!";
            this.conclusion.Text = conclusion;
            pictureBox1.Image = winner;
            if (conclusion == "VICTORY!")
            {
                this.BackColor = Color.FromArgb(0, 204, 204);
                this.conclusion.ForeColor = System.Drawing.Color.Gold;
                planet.ForeColor = System.Drawing.Color.Green;
                planet.Text = "Planet " + name_planet + " is saved!";
            }
            if (conclusion == "DEFEAT!")
            {
                this.BackColor = Color.FromArgb(160, 160, 160);
                this.conclusion.ForeColor = System.Drawing.Color.Black;
                planet.ForeColor = System.Drawing.Color.Red;
                planet.Text = "Planet " + name_planet + " is distroyed!";
            }
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Heroes f = new Heroes();
            f.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
