using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOPLAYAN_CIKARAN_CARPAN_BOLEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1=0, sayi2=0;
            string islem;
            do
            {
                Console.WriteLine("Lütfen 1. sayıyı giriniz.");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen 2. sayıyı giriniz.");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("topla / çıkart / çarp / böl.");
                islem = Console.ReadLine();
                if (islem =="topla") 
                {
                    Console.WriteLine("Sonuc: " + (sayi1 + sayi2));
                }
                if (islem == "çıkart")
                {
                    Console.WriteLine("Sonuc: " + (sayi1 - sayi2));
                }
                if (islem == "çarp")
                {
                    Console.WriteLine("Sonuc: " + (sayi1 * sayi2));
                }
                if (islem == "böl")
                {
                    if (sayi2==0)
                    {
                        Console.WriteLine(sayi1 + " " + sayi2 + "'a bölünemez!");
                    }
                    else
                    {
                        Console.WriteLine("Sonuc: " + (sayi1 / sayi2));
                    }
                    
                }


            } while (true);
        }
    }
}
