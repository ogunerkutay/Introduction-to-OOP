using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamamartikortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double kacadet = 0;
            double okunan;
            double ortalama = 0;
            bool isNumeric = false;
            string okuyorum;
            do
            {
                Console.WriteLine("Lütfen sayıları giriniz, çıkmak için tamam yazın");
                okuyorum = Console.ReadLine();
                isNumeric = double.TryParse(okuyorum, out okunan);
                if (!isNumeric)
                {
                    if (okuyorum=="tamam")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen bir sayı giriniz!");
                    }
                }
                else
                {
                    ortalama = ortalama + okunan;
                    kacadet++;
                }

            } while (true);

            Console.WriteLine("{0} adet sayının ortalaması : {1}", kacadet, ortalama / kacadet);
        }
    }
}

