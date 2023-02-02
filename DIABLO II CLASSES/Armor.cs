using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES
{
    public class Armor
    {
        private string name;
        private string type;
        private int mindefense;
        private int maxdefense;
        private int minstrength;
        private int currentdurability;
        private int maxdurability;
        private int qualitylevel;

        public virtual string Name { get => name;}
        public virtual string Type { get => type;}
        public virtual int Mindefense { get => mindefense;}
        public virtual int Maxdefense { get => maxdefense;}
        public virtual int Minstrength { get => minstrength;}
        public virtual int Currentdurability { get => currentdurability;}
        public virtual int Maxdurability { get => maxdurability;}
        public virtual int Qualitylevel { get => qualitylevel;}

        public virtual void Wear()
        {
            Console.WriteLine($"{Name} been weared");
        }
        public virtual void Drop()
        {
            Console.WriteLine($"{Name} been dropped");
        }
        public virtual void PutInToStash()
        {
            Console.WriteLine($"{Name} been put to stash");
        }
        public virtual void Repair()
        {
            Console.WriteLine($"{Name} been repaired");
        }

    }
}
