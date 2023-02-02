using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekmiCiftMiSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Console.WriteLine("Lütfen bir sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi % 2)
            {
                case 0:
                    Console.WriteLine("Girdiğiniz sayı {0} çifttir.",sayi);
                    break;
                case 1:
                    Console.WriteLine("Girdiğiniz sayı {0} tektir.", sayi);
                    break;
            }
        
        
        }
    }
}
