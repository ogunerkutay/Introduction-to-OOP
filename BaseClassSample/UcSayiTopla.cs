using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSample
{
    public class UcSayiTopla : ToplaBase
    {
        public UcSayiTopla() : base(4,5)
        {
            Console.WriteLine("UcSayiTopla Class Parametresiz Constructor");
        }
        public UcSayiTopla(int a,int b, int c) : base(b,c)
        {
            Console.WriteLine("UcSayiTopla Class Parametre Constructor");
            base.Sayi1 = a;
            base.Sayi2 = b;

            Console.WriteLine($"Base Toplam Sonuc : {base.Toplam()}");

            base.Sayi1 = 100;
            base.Sayi2 = 200;

            Console.WriteLine($"Türetilmiş Sınıf için Toplam Sonuc : {this.Toplam()}");
        }
    }
}
