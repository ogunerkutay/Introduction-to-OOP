using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSampleProject
{
    public class Aralik : Ay
    {
        public override void AyAdi()
        {
            Console.WriteLine("Aralık");
        }

        public override void KacinciAy()
        {
            Console.WriteLine("12. Ay");
        }

        public override void KacGun()
        {
            Console.WriteLine("31 Gün");
        }

    }
}
