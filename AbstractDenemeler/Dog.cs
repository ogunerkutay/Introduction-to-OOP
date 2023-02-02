using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDenemeler
{
    class Dog : Animal, IMove ,IPlay
    {
        public string Toy { get; set; }
        public int AsiSayisi { get; set; }
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats bone");
        }
        
        public void Move()
        {
        Console.WriteLine($"{Name} runs");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} plays with {Toy}");
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} says houf houf");
        }


    }
}
