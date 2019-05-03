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
    public partial class Villains : Form
    {
        Start villain = new Start();
        Image picture1, picture2;
        string name_hero, name_vill;
        int hero_att, hero_hlt, vill_att, vill_hlt;
        public Villains(Image img, string nume, int hero_att, int hero_hlt)
        {
            InitializeComponent();
            pictureBox2.Image = imageList1.Images[0];
            int a = villain.characters.FindIndex(x => x.addName == thanos.Text);
            villAttack.Text = Convert.ToString(villain.characters[a].addAttack);
            villHealth.Text = Convert.ToString(villain.characters[a].addHealth);
            description.Text = villain.characters[a].addDescription;
            name.Text = villain.characters[a].addName;
            picture1 = img;
            picture2 = pictureBox2.Image;
            name_hero = nume;
            name_vill = name.Text;
            this.hero_att = hero_att;
            this.hero_hlt = hero_hlt;
            vill_att = villain.characters[a].addAttack;
            vill_hlt = villain.characters[a].addHealth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
            int a = villain.characters.FindIndex(x => x.addName == thanos.Text);
            villAttack.Text = Convert.ToString(villain.characters[a].addAttack);
            villHealth.Text = Convert.ToString(villain.characters[a].addHealth);
            description.Text = villain.characters[a].addDescription;
            name.Text = villain.characters[a].addName;
            picture2 = pictureBox2.Image;
            name_vill = name.Text;
            vill_att = villain.characters[a].addAttack;
            vill_hlt = villain.characters[a].addHealth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[1];
            int a = villain.characters.FindIndex(x => x.addName == loki.Text);
            villAttack.Text = Convert.ToString(villain.characters[a].addAttack);
            villHealth.Text = Convert.ToString(villain.characters[a].addHealth);
            description.Text = villain.characters[a].addDescription;
            name.Text = villain.characters[a].addName;
            picture2 = pictureBox2.Image;
            name_vill = name.Text;
            vill_att = villain.characters[a].addAttack;
            vill_hlt = villain.characters[a].addHealth;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[2];
            int a = villain.characters.FindIndex(x => x.addName == juggernaut.Text);
            villAttack.Text = Convert.ToString(villain.characters[a].addAttack);
            villHealth.Text = Convert.ToString(villain.characters[a].addHealth);
            description.Text = villain.characters[a].addDescription;
            name.Text = villain.characters[a].addName;
            picture2 = pictureBox2.Image;
            name_vill = name.Text;
            vill_att = villain.characters[a].addAttack;
            vill_hlt = villain.characters[a].addHealth;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Planets f = new Planets(picture1, picture2, name_hero, name_vill, hero_att, hero_hlt, vill_att, vill_hlt);
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
