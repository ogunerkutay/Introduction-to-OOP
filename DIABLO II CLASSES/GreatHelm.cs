using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES
{
    public class GreatHelm : Armor
    {

        private string name = "GreatHelm";
        private string type = Enum.GetName(ArmorType.Helm);
        private int mindefense;
        private int maxdefense;
        private int minstrength;
        private int currentdurability;
        private int maxdurability;
        private int qualitylevel;

        public override string Name { get => name; }
        public override string Type { get => type; }
        public override int Mindefense { get => mindefense; }
        public override int Maxdefense { get => maxdefense; }
        public override int Minstrength { get => minstrength; }
        public override int Currentdurability { get => currentdurability; }
        public override int Maxdurability { get => maxdurability; }
        public override int Qualitylevel { get => qualitylevel; }


        public override void Drop()
        {
            Console.WriteLine($"{Name} been dropped");
        }

        public override void PutInToStash()
        {
            Console.WriteLine($"{Name} been put to stash");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Name} been repaired");
        }

        public override void Wear()
        {
            Console.WriteLine($"{Name} been weared");
        }
    }
}
