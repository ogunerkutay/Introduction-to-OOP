using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_sayilarin_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberCount;
            int toplam = 0;
            Console.WriteLine("Kaç adet sayı girişi yapacaksınız?");
            numberCount = int.Parse(Console.ReadLine().Trim());

            int[] sayilar = new int[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < numberCount; i++)
            {
                toplam += sayilar[i];
            }

            Console.WriteLine("Toplam : " + toplam);
        }
    }
}
