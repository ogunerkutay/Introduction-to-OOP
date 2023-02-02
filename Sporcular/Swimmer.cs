using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    internal class Swimmer : Insanlar,ISwim,IJump
    {
        public int SwimmingSpeed { get; set; }
        public int SwimmingDistance { get; set; }

        public void Swim()
        {
            Console.WriteLine($"{Name} {SwimmingSpeed} m/s ile {SwimmingDistance} metre yüzdü");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} havuza atladı");
        }
    }
}
