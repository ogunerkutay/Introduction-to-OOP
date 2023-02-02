using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negatifmipozitifmi
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
                if (sayi < 0)
                {
                    Console.WriteLine($"{sayi} negatiftir");
                }
                else if (sayi == 0)
                {
                    Console.WriteLine($"{sayi} pozitif/negatif değildir");
                }
                else
                {
                    Console.WriteLine($"{sayi} pozitiftir");
                }


            } while (true);
        }
    }
}
