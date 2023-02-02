using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    class Job
    {
        public string Name { get; set; }

        public void Work(Worker c)
        {
            Console.WriteLine($"{c.Ad} isimli çalışan {Name} işinde çalışıyor");
        }

        public void IkametgahAl(Person p)
        {
            Console.WriteLine($"{p.Ad} isimli vatandaş ikametgahını aldı");

        }


    }
}
