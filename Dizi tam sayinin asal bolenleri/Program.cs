using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_tam_sayinin_asal_bolenleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamsayi = 0;
            bool isNumeric = false;
            int[] asalsayilar = new int[0];
            do
            {

                Console.WriteLine("Asal bölenleri bulunacak tam sayıyı giriniz! 0'dan büyük pozitif bir sayı olmalı.");
                isNumeric = int.TryParse(Console.ReadLine(), out tamsayi);
            } while (!isNumeric || tamsayi <= 0);

            for (int i = 2; i < tamsayi + 1; i++)
            {
                if (tamsayi % i == 0)
                {
                    Array.Resize(ref asalsayilar, asalsayilar.Length + 1);
                    asalsayilar[asalsayilar.Length - 1] = i;
                    do
                    {
                        tamsayi /= i;
                    } while (tamsayi % i == 0);
                }

            }


            for (int i = 0; i < asalsayilar.Length; i++)
            {
                Console.WriteLine(asalsayilar[i]);
            }
        }
    }
}
