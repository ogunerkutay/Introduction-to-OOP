using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsayininortalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kacadet;
            double okunan;
            double ortalama = 0;
            bool isNumeric = false;
            Console.WriteLine("Lütfen kac adet sayı gireceğinizi rakamla yazın");
            do
            {
                isNumeric = double.TryParse(Console.ReadLine(), out kacadet);
                if (!isNumeric)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz!");
                }
            } while (isNumeric == false || kacadet<=0);

            for (int i = 1; i < kacadet+1;)
            {
                Console.WriteLine("Lütfen sayıları giriniz");
                isNumeric = double.TryParse(Console.ReadLine(),out okunan);
                if (!isNumeric)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz!");
                }
                else
                {
                    ortalama = ortalama + okunan;
                    i++;
                }
            }
           
            Console.WriteLine("{0} adet sayının ortalaması : {1}", kacadet, ortalama/kacadet);


        }
    }
}
