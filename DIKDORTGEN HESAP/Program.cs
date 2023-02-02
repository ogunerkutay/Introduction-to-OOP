using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIKDORTGEN_HESAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dikdörtgenin 1. kenarını giriniz: ");
            double kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin 2. kenarını giriniz: ");
            double kenar2 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2)
            {
                Console.WriteLine("Kenarların boyutları eşit olmamalıdır!");
            }
            else
            {
                if (kenar1 <= 0 || kenar2 <= 0)
                {
                    Console.WriteLine("Dikdörtgenin Alanı: 0");
                }
                else
                {
                    if (kenar1 > kenar2)
                    {
                        Console.WriteLine("Dikdörtgenin Uzun Kenarı: {0}", kenar1);
                        Console.WriteLine("Dikdörtgenin Kısa Kenarı: {0}", kenar2);
                    }
                    else
                    {
                        Console.WriteLine("Dikdörtgenin Uzun Kenarı: {0}", kenar2);
                        Console.WriteLine("Dikdörtgenin Kısa Kenarı: {0}", kenar1);
                    }
                    Console.WriteLine("Dikdörtgenin Alanı: {0} Dikdörtgenin Çevresi: {1}", kenar1 * kenar2, 2 * (kenar1 + kenar2));
                }
            }


        }
    }
}
