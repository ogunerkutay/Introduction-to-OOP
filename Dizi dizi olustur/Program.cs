using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_dizi_olustur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamsayi = 0;
            bool isNumeric = false;
            int[] sayilar = { 435, 43, 543, 53, 53, 7, 645, 3, 5, 435, 46, 5, 56, 435, 3, 443, 565, 5, 654, 53 };
            do
            {

                Console.WriteLine("Diziyi kaça böleceksiniz yazin, Lütfen 0'dan büyük pozitif değer giriniz! {0}'i tam bölmeli!",sayilar.Length);
                isNumeric = int.TryParse(Console.ReadLine(), out tamsayi);
            } while (!isNumeric || tamsayi <= 0 || sayilar.Length % tamsayi != 0);
            int elemanadedi = sayilar.Length / tamsayi;
            int[,] dizilerim = new int[tamsayi, elemanadedi];
            for (int i = 0; i < tamsayi; i++)
            {
                for (int j = 0; j < elemanadedi; j++)
                {
                    dizilerim[i,j] = sayilar[j+(i*elemanadedi)];
                }
            }
            for (int i = 0; i < tamsayi; i++)
            {
                for (int j = 0; j < elemanadedi; j++)
                {
                    Console.Write(dizilerim[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
