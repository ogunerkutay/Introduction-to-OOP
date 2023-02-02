using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimAraclari
{
    internal class Ucak : AirVehicles, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Uçuyorum geri dönmem, Tek rakibim Türk Hava Yolları");
        }

        public void Land()
        {
            Console.WriteLine("Kaptan bizi sağda indir");
        }
    }
}
