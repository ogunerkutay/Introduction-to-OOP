using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0ve100arasindami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 0 & sayi<=100)
                {
                    Console.WriteLine("{0} 0-100 arasındadır.", sayi);
                }
                else
                {
                    Console.WriteLine("{0} 0-100 arasında değildir.", sayi);
                }


            } while (true);
        }
    }
}
