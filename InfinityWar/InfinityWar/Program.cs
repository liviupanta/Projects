using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityWar
{
    public class Character
    {
        public int addAttack { get; set; }
        public string addDescription { get; set; }
        public int addHealth { get; set; }
        public int addId { get; set; }
        public bool addIsVillain { get; set; }
        public string addName { get; set; }
        public override string ToString()
        {
            return "Id: " + addId +
                "\nName: " + addName +
                "\nDescription: " + addDescription +
                "\nAttack: " + addAttack +
                "\nHealth: " + addHealth +
                "\nisVillain: " + addIsVillain;
        }
    }
    public class Planet
    {
        public string addName { get; set; }
        public string addDescription { get; set; }
        public int addId { get; set; }
        public int addHeroAttackModifier { get; set; }
        public int addHeroHealthModifier { get; set; }
        public int addVillainAttackModifier { get; set; }
        public int addVillainHealthModifier { get; set; }
        public override string ToString()
        {
            return "Id: " + addId +
                "\nName: " + addName +
                "\nDescription: " + addDescription +
                "\nHero attck modifier: " + addHeroAttackModifier +
                "\nHero health modifier: " + addHeroHealthModifier +
                "\nVillain attack modifier: " + addVillainAttackModifier +
                "\nVillain health modifier: " + addVillainHealthModifier;
        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
