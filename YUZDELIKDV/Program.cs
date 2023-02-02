using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YUZDELIKDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("KDV'si hesaplanacak sayıyı giriniz: ");
            double sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("KDV yüzdesini giriniz: ");
            double yuzde = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuc {0}", sayi * (1+(yuzde/100)));

        }
    }
}
