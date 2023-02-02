using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    public abstract class Insanlar
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} yemek yedi");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} yemek yedi");
        }

    }
}
