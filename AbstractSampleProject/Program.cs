using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSampleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aralik _aralik = new Aralik();
            _aralik.AyAdi();
            _aralik.KacinciAy();
            _aralik.KacGun();
            _aralik.YilKacAydir();

        }
    }
}
