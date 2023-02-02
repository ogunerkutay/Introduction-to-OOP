using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sayidanbuyukolan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birincisayi = 0;
            int ikincisayi = 0;
            do
            {
                Console.WriteLine("Lütfen 2 sayıdan 1. sayıyı giriniz.");
                birincisayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen 2 sayıdan 2. sayıyı giriniz.");
                ikincisayi = Convert.ToInt32(Console.ReadLine());

                if (birincisayi>ikincisayi)
                {
                    Console.WriteLine("Birinci sayı {0} ikinci {1} sayısından büyüktür.",birincisayi,ikincisayi);

                }
                else if (ikincisayi>birincisayi)
                {
                    Console.WriteLine("İkinci sayı {1} birinci {0} sayısından büyüktür.", birincisayi, ikincisayi);

                }
                else
                {
                    Console.WriteLine("Birinci sayı {0} ikinci {1} sayıya eşittir.", birincisayi, ikincisayi);

                }
            } while (true);
        }
    }
}
