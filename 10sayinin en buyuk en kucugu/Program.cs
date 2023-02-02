using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10sayinin_en_buyuk_en_kucugu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double enkucuk;
            double enbuyuk;
            double okunan;
            bool isNumeric=false;

            do
            {
                Console.WriteLine("Lütfen sayilari giriniz");
                isNumeric = double.TryParse(Console.ReadLine(), out okunan);
                if (!isNumeric)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz!");
                }
            } while (isNumeric==false);

            enkucuk = okunan;
            enbuyuk = okunan;

            for (int sayac = 0; sayac < 9;)
            {
                Console.WriteLine("Lütfen sayilari giriniz");
                isNumeric = double.TryParse(Console.ReadLine(), out okunan);
                if (isNumeric)
                {
                    if (enkucuk > okunan)
                    {
                        enkucuk = okunan;
                    }
                    if (enbuyuk < okunan)
                    {
                        enbuyuk = okunan;
                    }
                    sayac++;
                }
                else
                {
                    Console.WriteLine("Lütfen bir sayı giriniz!");
                }
            }
            Console.WriteLine("Enbüyük sayı : " + enbuyuk);
            Console.WriteLine("Enküçük sayı : " + enkucuk);

        }
    }
}
