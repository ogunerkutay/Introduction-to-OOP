using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCTIONLAR_PARAMS_RETURN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Toplama(2, 5);
            toplam = Toplama(2, 3, 4, 5);
            double alanhesapla = DaireninAlani(5);
        
        }

        private static double DaireninAlani(int yaricap, double pi = Math.PI)
        {
            double alan = pi * Math.Pow(yaricap, 2);
            return alan;
        }

        private static int Toplama(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            return result;

        }
        private static int Toplama(params int[] sayilar)
        {
            int result = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                result += sayilar[i];
            }
            return result;

        }
    }
}
