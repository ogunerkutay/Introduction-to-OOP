using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDenemeler
{
    public class Asena : Human,IPlay
    {
        public string Toy { get; set; }
        public void Play()
        {
            Console.WriteLine($"{Name} plays with {Toy}");
        }

    }
}
