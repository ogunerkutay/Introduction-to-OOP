using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimAraclari
{
    internal class DenizAlti:SeaVehicles,IRide,IDive
    {
        public void Accelerate()
        {
            Console.WriteLine("Bas gaza aşkım bas gaza");
        }

        public void Brake()
        {
            Console.WriteLine("dur");
        }

        public void Dive()
        {
            Console.WriteLine("dal babam dal, denizden ne çıksa yerim");
        }

        public void Surface()
        {
            Console.WriteLine("bir nefes alalım");
        }
    }
}
