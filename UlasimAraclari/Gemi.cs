using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimAraclari
{
    internal class Gemi:SeaVehicles,IRide
    {
        public void Accelerate()
        {
            Console.WriteLine("Bas gaza aşkım bas gaza");
        }

        public void Brake()
        {
            Console.WriteLine("dur");
        }
    }
}
