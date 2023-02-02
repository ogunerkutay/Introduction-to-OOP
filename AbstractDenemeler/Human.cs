using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDenemeler
{
    public class Human : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats chicken burger");
        }
    }
}
