using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIABLO_II_CLASSES
{
    public class Necromancer : Character
    {
        private int strength = 100;
        private int dexterity = 60;
        private int vitality = 80;
        private int energy = 50;
        private int life = 80;
        private int stamina = 80;
        private int mana = 50;

        public override int Strength { get => strength; }
        public override int Dexterity { get => dexterity; }
        public override int Vitality { get => vitality; }
        public override int Energy { get => energy; }
        public override int Life { get => life; }
        public override int Stamina { get => stamina; }
        public override int Mana { get => mana; }

        

        public void Revive()
        {
            MessageBox.Show($"{this.GetType().Name} used {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
        public void BoneSpirit()
        {
            MessageBox.Show($"{this.GetType().Name} used {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
        public void LowerResist()
        {
            MessageBox.Show($"{this.GetType().Name} used {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
    }
}
