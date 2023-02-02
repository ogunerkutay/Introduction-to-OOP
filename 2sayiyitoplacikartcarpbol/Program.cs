using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sayiyitoplacikartcarpbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 1. sayiyi giriniz: ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. sayiyi giriniz: ");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"2 sayinin toplami: {sayi1 + sayi2}");
            Console.WriteLine($"2 sayinin farki: {sayi1 - sayi2}");
            Console.WriteLine($"2 sayinin çarpimi: {sayi1 * sayi2}");
            if (sayi2 == 0)
            {
                Console.WriteLine("Tanımsız");
            }
            else
            {
                Console.WriteLine($"2 sayinin bölümü: {sayi1 / sayi2}");
            }


        }

    }
}
