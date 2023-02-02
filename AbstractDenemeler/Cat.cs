using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDenemeler
{
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat constructor");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} drinks milk");
        }
    }
}
