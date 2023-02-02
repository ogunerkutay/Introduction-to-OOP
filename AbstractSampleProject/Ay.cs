using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSampleProject
{
    public abstract class Ay
    {
        public Ay()
        {
            Console.WriteLine("Yılın aylarını temsil eden Abstract Sınıf");
        }

        public abstract void KacinciAy();
        public abstract void AyAdi();
        public virtual void KacGun()
        {
            Console.WriteLine("30 Gün");
        }

        public void YilKacAydir()
        {
            Console.WriteLine("Yıl 12 aydan oluşur");
        }
    }
}
