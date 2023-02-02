using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavNotuGectiMiKaldiMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sınav notunu giriniz: ");
            double sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sınav notunu giriniz: ");
            double sinav2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sınav notunu giriniz: ");
            double sinav3 = Convert.ToInt32(Console.ReadLine());
            double ortalama = 0;
            if (sinav1 <0 || sinav2 <0 || sinav3 < 0 || sinav1>100 || sinav2>100|| sinav3>100)
            {
                Console.WriteLine("Sınav notları 0-100 aralığında olmalıdır");
            }
            else
            {
                ortalama = (sinav1 + sinav2 + sinav3) / 3;
                if (ortalama<45)
                {
                    Console.WriteLine("Öğrenci: Kalmıştır!");
                }
                else
                {
                    Console.WriteLine("Öğrenci: Geçmiştir!");
                }


            }
        }
    }
}
