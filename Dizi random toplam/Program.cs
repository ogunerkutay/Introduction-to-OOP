using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_random_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgelesayilar = new Random();
            int toplam = 0;
            int[] sayilar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rastgelesayilar.Next(0, 1000);
            }

            for (int i = 0; i < 10; i++)
            {
                toplam += sayilar[i];
            }

        }
    }
}
