using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDenemeler
{
    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Abstract Constructor Çalıştı");
            id = Guid.NewGuid();
        }
        private Guid id;
        public Guid Id
        {
        get { return id; }
        }
        public string Name { get; set; }    
        public int Age { get; set; }


        public void Sleep()
        {
            Console.WriteLine($"{Name} sleeps ZZzzzZZ");
        }

        public abstract void Eat();

        public virtual void Sound()
        {
            Console.WriteLine($"{Name} says meow");
        }


}

}
