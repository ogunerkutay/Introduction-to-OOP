using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsayidanNsayiya_cift_sayilari_yaz_topla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 0;
            int sayi2 = 0;
            int toplam = 0;
            do
            {
                Console.WriteLine("birinci sayiyi yaz, sayalim toplayalım");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ikinci sayiyi yaz, sayalim toplayalım ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                if (sayi1 < sayi2)
                {
                    for (int i = sayi1; i <= sayi2; i++)
                    {
                        if (i % 2 == 0)
                            toplam = toplam + i;
                    }
                }
                else if (sayi1 > sayi2)
                {
                    for (int i = sayi1; i >= sayi2; i--)
                    {
                        if (i % 2 == 0)
                            toplam = toplam + i;
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }

                Console.WriteLine(toplam);
                toplam = 0;
            } while (true);
        }
    }
}
