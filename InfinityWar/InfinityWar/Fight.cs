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
    public partial class Fight : Form
    {
        int j = 0;
        string name_planet;
        public Fight(Image img1, Image img2, string nume_h, string nume_v, string nume_p, int hero_att, int hero_att_mod, int hero_hlt, int hero_hlt_mod, int vill_att, int vill_att_mod, int vill_hlt, int vill_hlt_mod)
        {
            InitializeComponent();
            this.name_planet = nume_p;
            this.pictureBox2.Image = img1;
            this.pictureBox3.Image = img2;
            turn.Text = "TURN 1";
            heroName.Text = nume_h;
            villName.Text = nume_v;
            heroAtt.Text = Convert.ToString(hero_att + hero_att_mod);
            heroHlt.Text = Convert.ToString(hero_hlt + hero_hlt_mod);
            villAtt.Text = Convert.ToString(vill_att + vill_att_mod);
            villHlt.Text = Convert.ToString(vill_hlt + vill_hlt_mod);
            progressBar1.Maximum = hero_hlt + hero_hlt_mod;
            progressBar1.Value = hero_hlt + hero_hlt_mod;
            progressBar2.Maximum = vill_hlt + vill_hlt_mod;
            progressBar2.Value = vill_hlt + vill_hlt_mod;
        }
        private void battle_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int i = ran.Next(1, 3);
            while (progressBar1.Value > 0 && progressBar2.Value > 0)
            {
                Random rnd = new Random();
                double num = rnd.Next(60, 101);
                if (i % 2 == 1)
                {
                    int k = (int)(Convert.ToInt16(heroAtt.Text) * num / 100);
                    sens.Text = "==>";
                    sens.Update();
                    damage.Text = Convert.ToString(-k);
                    damage.Update();
                    progressBar2.Step = -k;
                    progressBar2.PerformStep();
                    for (int l = 0; l < 4.6 * 100000000; l++)
                    {
                        j++;
                        j--;
                    }
                }
                else
                {
                    int k = (int)(Convert.ToInt16(villAtt.Text) * num / 100);
                    sens.Text = "<==";
                    sens.Update();
                    damage.Text = Convert.ToString(-k);
                    damage.Update();
                    progressBar1.Step = -k;
                    progressBar1.PerformStep();
                    for (int l = 0; l < 4.6 * 100000000; l++)
                    {
                        j++;
                        j--;
                    }
                }
                i++;
                if (i % 2 == 0)
                {
                    turn.Text = "TURN " + i / 2;
                    turn.Update();
                }
                battle.Visible = false;
                if (progressBar1.Value == 0)
                {
                    this.Hide();
                    Winner win = new Winner(villName.Text, "DEFEAT!", name_planet, pictureBox3.Image);
                    win.ShowDialog();
                }
                else
                {
                    if (progressBar2.Value == 0)
                    {
                        this.Hide();
                        Winner win = new Winner(heroName.Text, "VICTORY!", name_planet, pictureBox2.Image);
                        win.ShowDialog();
                    }
                }
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
