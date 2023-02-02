using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_mi_Cift_mi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int kalan;
            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
                sayi = Convert.ToInt32(Console.ReadLine());
                kalan = sayi % 2;
                if (kalan>0)
                {
                    Console.WriteLine($"{sayi} tektir");
                }
                else
                {
                    Console.WriteLine($"{sayi} çifttir");
                }


            } while (true);
        }
    }
}
