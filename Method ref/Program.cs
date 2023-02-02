using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double sayi1 = 10;
            double sayi2 = 5;
            double sonuc = 0;

            BolmeIslemi(ref sayi1,ref sayi2, ref sonuc);

            Console.WriteLine("sonuc : " + sonuc);
        }
        static void BolmeIslemi(ref double sayi1, ref double sayi2,ref double sonuc)
        {
            sonuc = 0;
            if (sayi2 == 0)
            {    
                sonuc = 0;
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }
        }
    }
}
