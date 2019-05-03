using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InfinityWar
{
    public partial class Start : Form
    {
        public List<Character> characters = new List<Character>();
        public List<Planet> planet = new List<Planet>();
        public Start()
        {
            InitializeComponent();
            XmlTextReader reader = new XmlTextReader("characters.xml");
            XmlTextReader boost = new XmlTextReader("planets.xml");
            int Id = 0, attHeroMod = 0, attVillMod = 0, hltHeroMod = 0, hltVillMod = 0, atac = 0, viata = 0, count = 0;
            string descript = null, descriere = null;
            bool villain = false;
            while (reader.Read())
            {
                string num = null;
                XmlNodeType type = reader.NodeType;
                if (type == XmlNodeType.Element)
                {
                    if (reader.Name == "attack")
                    {
                        reader.Read();
                        atac = Convert.ToInt16(reader.Value);
                    }
                    else
                    if (reader.Name == "description")
                    {
                        reader.Read();
                        descriere = Convert.ToString(reader.Value);
                    }
                    else
                    if (reader.Name == "health")
                    {
                        reader.Read();
                        viata = Convert.ToInt16(reader.Value);
                    }
                    else
                    if (reader.Name == "id")
                    {
                        reader.Read();
                        count = Convert.ToInt16(reader.Value);
                    }
                    else
                    if (reader.Name == "isVillain")
                    {
                        reader.Read();
                        villain = Convert.ToBoolean(reader.Value);
                    }
                    else
                    if (reader.Name == "name")
                    {
                        reader.Read();
                        num = Convert.ToString(reader.Value);
                    }
                }
                if (num != null)
                    characters.Add(new Character()
                    {
                        addAttack = atac,
                        addDescription = descriere,
                        addHealth = viata,
                        addId = count,
                        addIsVillain = villain,
                        addName = num
                    });
            }
            while (boost.Read())
            {
                string nume = null;
                XmlNodeType type = boost.NodeType;
                if (type == XmlNodeType.Element)
                {
                    if (boost.Name == "description")
                    {
                        boost.Read();
                        descript = Convert.ToString(boost.Value);
                    }
                    else
                        if (boost.Name == "id")
                    {
                        boost.Read();
                        Id = Convert.ToInt16(boost.Value);
                    }
                    else
                        if (boost.Name == "heroAttackModifier")
                    {
                        boost.Read();
                        attHeroMod = Convert.ToInt16(boost.Value);
                    }
                    else
                        if (boost.Name == "heroHealthModifier")
                    {
                        boost.Read();
                        hltHeroMod = Convert.ToInt16(boost.Value);
                    }
                    else
                        if (boost.Name == "villainAttackModifier")
                    {
                        boost.Read();
                        attVillMod = Convert.ToInt16(boost.Value);
                    }
                    else
                        if (boost.Name == "villainHealthModifier")
                    {
                        boost.Read();
                        hltVillMod = Convert.ToInt16(boost.Value);
                    }
                    if (boost.Name == "name")
                    {
                        boost.Read();
                        nume = Convert.ToString(boost.Value);
                    }
                    if (nume != null)
                    {
                        planet.Add(new Planet()
                        {
                            addName = nume,
                            addDescription = descript,
                            addId = Id,
                            addHeroAttackModifier = attHeroMod,
                            addHeroHealthModifier = hltHeroMod,
                            addVillainAttackModifier = attVillMod,
                            addVillainHealthModifier = hltVillMod
                        });
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Heroes f1 = new Heroes();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
