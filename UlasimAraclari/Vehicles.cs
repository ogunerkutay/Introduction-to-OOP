using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimAraclari
{
    public abstract class Vehicles
    {
        public string Name { get; set; }
        public int YolcuKapasitesi { get; set; }
        public string Motor { get; set; }
        public int Yakit { get; set; }
        public string Renk { get; set; }
        public void StartEngine()
        {
            Console.WriteLine($"{Name} motor çalıştı har har gurul gürül brum");
        }
    }
}
