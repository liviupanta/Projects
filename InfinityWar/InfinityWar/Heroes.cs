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
    public partial class Heroes : Form
    {
        Start hero = new Start();
        Image img = null;
        string name = null;
        int hero_att = 0, hero_hlt = 0;
        public Heroes()
        {
            InitializeComponent();
            pictureBox2.Image = imageList1.Images[0];
            int a = hero.characters.FindIndex(x => x.addName == captainAmerica.Text);
            heroAttack.Text = Convert.ToString(hero.characters[a].addAttack);
            heroHealth.Text = Convert.ToString(hero.characters[a].addHealth);
            description.Text = hero.characters[a].addDescription;
            heroName.Text = hero.characters[a].addName;
            img = pictureBox2.Image;
            name = heroName.Text;
            hero_att = hero.characters[a].addAttack;
            hero_hlt = hero.characters[a].addHealth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
            int a = hero.characters.FindIndex(x => x.addName == captainAmerica.Text);
            heroAttack.Text = Convert.ToString(hero.characters[a].addAttack);
            heroHealth.Text = Convert.ToString(hero.characters[a].addHealth);
            description.Text = hero.characters[a].addDescription;
            heroName.Text = hero.characters[a].addName;
            img = pictureBox2.Image;
            name = heroName.Text;
            hero_att = hero.characters[a].addAttack;
            hero_hlt = hero.characters[a].addHealth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[1];
            int a = hero.characters.FindIndex(x => x.addName == captainMarvel.Text);
            heroAttack.Text = Convert.ToString(hero.characters[a].addAttack);
            heroHealth.Text = Convert.ToString(hero.characters[a].addHealth);
            description.Text = hero.characters[a].addDescription;
            heroName.Text = hero.characters[a].addName;
            img = pictureBox2.Image;
            name = heroName.Text;
            hero_att = hero.characters[a].addAttack;
            hero_hlt = hero.characters[a].addHealth;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[2];
            int a = hero.characters.FindIndex(x => x.addName == thor.Text);
            heroAttack.Text = Convert.ToString(hero.characters[a].addAttack);
            heroHealth.Text = Convert.ToString(hero.characters[a].addHealth);
            description.Text = hero.characters[a].addDescription;
            heroName.Text = hero.characters[a].addName;
            img = pictureBox2.Image;
            name = heroName.Text;
            hero_att = hero.characters[a].addAttack;
            hero_hlt = hero.characters[a].addHealth;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[3];
            int a = hero.characters.FindIndex(x => x.addName == ironMan.Text);
            heroAttack.Text = Convert.ToString(hero.characters[a].addAttack);
            heroHealth.Text = Convert.ToString(hero.characters[a].addHealth);
            description.Text = hero.characters[a].addDescription;
            heroName.Text = hero.characters[a].addName;
            img = pictureBox2.Image;
            name = heroName.Text;
            hero_att = hero.characters[a].addAttack;
            hero_hlt = hero.characters[a].addHealth;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[4];
            int a = hero.characters.FindIndex(x => x.addName == blackPanther.Text);
            heroAttack.Text = Convert.ToString(hero.characters[a].addAttack);
            heroHealth.Text = Convert.ToString(hero.characters[a].addHealth);
            description.Text = hero.characters[a].addDescription;
            heroName.Text = hero.characters[a].addName;
            img = pictureBox2.Image;
            name = heroName.Text;
            hero_att = hero.characters[a].addAttack;
            hero_hlt = hero.characters[a].addHealth;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Villains f = new Villains(img, name, hero_att, hero_hlt);
            f.ShowDialog();
        }
    }
}
