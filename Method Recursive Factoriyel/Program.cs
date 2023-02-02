using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Recursive_Factoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = FaktoriyelHesapla(5);
            Console.WriteLine(sonuc);
        }
        static int FaktoriyelHesapla(int sayi)
        {
            int sonuc=1;

            if (sayi == 0)
            {
                sonuc = 1;
            }
            else
            {
                sonuc = sayi * FaktoriyelHesapla(sayi-1);
            }

            return sonuc;       
        }
    }
}
