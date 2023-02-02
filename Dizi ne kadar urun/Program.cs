using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_ne_kadar_urun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int urunadedi = 0;
            bool isNumeric =false;
            
            do
            {

                Console.WriteLine("Ne kadar ürün gireceksiniz ? 0'dan büyük pozitif bir sayı olmalı.");
                isNumeric = int.TryParse(Console.ReadLine(), out urunadedi);
            } while (!isNumeric || urunadedi <=0);
            string[] urunler = new string[urunadedi];
            for (int i = 0; i < urunadedi; i++)
            {
                Console.WriteLine("Ürününüzün adı : ");
                urunler[i] = Console.ReadLine();
            }
            Console.WriteLine(new string('*', 100));
            for (int i = 0; i < urunadedi; i++)
            {
                Console.WriteLine(urunler[i]);  
            }
        }
    }
}
