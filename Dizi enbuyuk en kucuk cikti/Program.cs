using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_enbuyuk_en_kucuk_cikti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 435, 43, 543, 53, 53, 7, 645, 3, 5, 435, 46, 5, 56, 435, 3, 443, 565, 5, 654, 53 };

           Console.WriteLine(sayilar.Max());
           Console.WriteLine(sayilar.Min());
        }
    }
}
