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
    public partial class Planets : Form
    {
        string name_hero, name_vill, name_planet;
        Image picture1, picture2;
        int hero_att, hero_hlt, vill_att, vill_hlt, hero_att_mod, hero_hlt_mod, vill_att_mod, vill_hlt_mod;
        Start planet = new Start();
        public Planets(Image img1, Image img2, string nume_h, string nume_v, int hero_att, int hero_hlt, int vill_att, int vill_hlt)
        {
            InitializeComponent();
            pictureBox2.Image = imageList1.Images[0];
            int a = planet.planet.FindIndex(x => x.addName == earth.Text);
            descriere.Text = Convert.ToString(planet.planet[a].addDescription);
            heroAttMod.Text = Convert.ToString(planet.planet[a].addHeroAttackModifier);
            heroHltMod.Text = Convert.ToString(planet.planet[a].addHeroHealthModifier);
            villAttMod.Text = Convert.ToString(planet.planet[a].addVillainAttackModifier);
            villHltMod.Text = Convert.ToString(planet.planet[a].addVillainHealthModifier);
            nume.Text = planet.planet[a].addName;
            picture1 = img1;
            picture2 = img2;
            name_hero = nume_h;
            name_vill = nume_v;
            this.hero_att = hero_att;
            this.hero_hlt = hero_hlt;
            this.vill_att = vill_att;
            this.vill_hlt = vill_hlt;
            hero_att_mod = planet.planet[a].addHeroAttackModifier;
            hero_hlt_mod = planet.planet[a].addHeroHealthModifier;
            vill_att_mod = planet.planet[a].addVillainAttackModifier;
            vill_hlt_mod = planet.planet[a].addVillainHealthModifier;
            name_planet = planet.planet[a].addName;
            if (planet.planet[a].addHeroAttackModifier > 0)
            {
                heroAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addHeroHealthModifier > 0)
            {
                heroHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroHltMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainAttackModifier < 0)
            {
                villAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainHealthModifier < 0)
            {
                villHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villHltMod.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void earth_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
            int a = planet.planet.FindIndex(x => x.addName == earth.Text);
            descriere.Text = Convert.ToString(planet.planet[a].addDescription);
            heroAttMod.Text = Convert.ToString(planet.planet[a].addHeroAttackModifier);
            heroHltMod.Text = Convert.ToString(planet.planet[a].addHeroHealthModifier);
            villAttMod.Text = Convert.ToString(planet.planet[a].addVillainAttackModifier);
            villHltMod.Text = Convert.ToString(planet.planet[a].addVillainHealthModifier);
            nume.Text = planet.planet[a].addName;
            hero_att_mod = planet.planet[a].addHeroAttackModifier;
            hero_hlt_mod = planet.planet[a].addHeroHealthModifier;
            vill_att_mod = planet.planet[a].addVillainAttackModifier;
            vill_hlt_mod = planet.planet[a].addVillainHealthModifier;
            name_planet = planet.planet[a].addName;
            if (planet.planet[a].addHeroAttackModifier > 0)
            {
                heroAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addHeroHealthModifier > 0)
            {
                heroHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroHltMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainAttackModifier < 0)
            {
                villAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainHealthModifier < 0)
            {
                villHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villHltMod.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void asgard_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[1];
            int a = planet.planet.FindIndex(x => x.addName == asgard.Text);
            descriere.Text = Convert.ToString(planet.planet[a].addDescription);
            heroAttMod.Text = Convert.ToString(planet.planet[a].addHeroAttackModifier);
            heroHltMod.Text = Convert.ToString(planet.planet[a].addHeroHealthModifier);
            villAttMod.Text = Convert.ToString(planet.planet[a].addVillainAttackModifier);
            villHltMod.Text = Convert.ToString(planet.planet[a].addVillainHealthModifier);
            nume.Text = planet.planet[a].addName;
            hero_att_mod = planet.planet[a].addHeroAttackModifier;
            hero_hlt_mod = planet.planet[a].addHeroHealthModifier;
            vill_att_mod = planet.planet[a].addVillainAttackModifier;
            vill_hlt_mod = planet.planet[a].addVillainHealthModifier;
            name_planet = planet.planet[a].addName;
            if (planet.planet[a].addHeroAttackModifier > 0)
            {
                heroAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addHeroHealthModifier > 0)
            {
                heroHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroHltMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainAttackModifier < 0)
            {
                villAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainHealthModifier < 0)
            {
                villHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villHltMod.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void xandar_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[2];
            int a = planet.planet.FindIndex(x => x.addName == xandar.Text);
            descriere.Text = Convert.ToString(planet.planet[a].addDescription);
            heroAttMod.Text = Convert.ToString(planet.planet[a].addHeroAttackModifier);
            heroHltMod.Text = Convert.ToString(planet.planet[a].addHeroHealthModifier);
            villAttMod.Text = Convert.ToString(planet.planet[a].addVillainAttackModifier);
            villHltMod.Text = Convert.ToString(planet.planet[a].addVillainHealthModifier);
            nume.Text = planet.planet[a].addName;
            hero_att_mod = planet.planet[a].addHeroAttackModifier;
            hero_hlt_mod = planet.planet[a].addHeroHealthModifier;
            vill_att_mod = planet.planet[a].addVillainAttackModifier;
            vill_hlt_mod = planet.planet[a].addVillainHealthModifier;
            name_planet = planet.planet[a].addName;
            if (planet.planet[a].addHeroAttackModifier > 0)
            {
                heroAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addHeroHealthModifier > 0)
            {
                heroHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroHltMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainAttackModifier < 0)
            {
                villAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainHealthModifier < 0)
            {
                villHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villHltMod.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void conjunction_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[3];
            int a = planet.planet.FindIndex(x => x.addName == conjunction.Text);
            descriere.Text = Convert.ToString(planet.planet[a].addDescription);
            heroAttMod.Text = Convert.ToString(planet.planet[a].addHeroAttackModifier);
            heroHltMod.Text = Convert.ToString(planet.planet[a].addHeroHealthModifier);
            villAttMod.Text = Convert.ToString(planet.planet[a].addVillainAttackModifier);
            villHltMod.Text = Convert.ToString(planet.planet[a].addVillainHealthModifier);
            nume.Text = planet.planet[a].addName;
            hero_att_mod = planet.planet[a].addHeroAttackModifier;
            hero_hlt_mod = planet.planet[a].addHeroHealthModifier;
            vill_att_mod = planet.planet[a].addVillainAttackModifier;
            vill_hlt_mod = planet.planet[a].addVillainHealthModifier;
            name_planet = planet.planet[a].addName;
            if (planet.planet[a].addHeroAttackModifier > 0)
            {
                heroAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addHeroHealthModifier > 0)
            {
                heroHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroHltMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainAttackModifier < 0)
            {
                villAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainHealthModifier < 0)
            {
                villHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villHltMod.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void praxius_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[4];
            int a = planet.planet.FindIndex(x => x.addName == praxius.Text);
            descriere.Text = Convert.ToString(planet.planet[a].addDescription);
            heroAttMod.Text = Convert.ToString(planet.planet[a].addHeroAttackModifier);
            heroHltMod.Text = Convert.ToString(planet.planet[a].addHeroHealthModifier);
            villAttMod.Text = Convert.ToString(planet.planet[a].addVillainAttackModifier);
            villHltMod.Text = Convert.ToString(planet.planet[a].addVillainHealthModifier);
            nume.Text = planet.planet[a].addName;
            hero_att_mod = planet.planet[a].addHeroAttackModifier;
            hero_hlt_mod = planet.planet[a].addHeroHealthModifier;
            vill_att_mod = planet.planet[a].addVillainAttackModifier;
            vill_hlt_mod = planet.planet[a].addVillainHealthModifier;
            name_planet = planet.planet[a].addName;
            if (planet.planet[a].addHeroAttackModifier > 0)
            {
                heroAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addHeroHealthModifier > 0)
            {
                heroHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                heroHltMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainAttackModifier < 0)
            {
                villAttMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villAttMod.ForeColor = System.Drawing.Color.Red;
            }
            if (planet.planet[a].addVillainHealthModifier < 0)
            {
                villHltMod.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                villHltMod.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void choose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fight f = new Fight(picture1, picture2, name_hero, name_vill, name_planet, hero_att, hero_att_mod, hero_hlt, hero_hlt_mod, vill_att, vill_att_mod, vill_hlt, vill_hlt_mod);
            f.ShowDialog();
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
