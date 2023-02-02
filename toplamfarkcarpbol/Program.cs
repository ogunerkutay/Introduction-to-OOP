using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplamfarkmod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 1. sayiyi giriniz: ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. sayiyi giriniz: ");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            double toplam = sayi1 + sayi2;
            double fark = sayi1 - sayi2;
            if (fark == 0)
            {
                Console.WriteLine("Tanımsız");
            }
            else
            {
                Console.WriteLine($"2 sayinin toplamlarının farklarına bölümünden kalan: {toplam % fark}");
            }

        }
    }
}
