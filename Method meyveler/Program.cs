using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_meyveler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = { "portakal", "elma", "mandalina", "muz" };
            double[] costsPerKg = { 12.5, 5, 15.5, 17 };
            double[] kilolar = { 10, 2, 3, 4 };

            Console.WriteLine("Toplam masraf " + Topla(fruits, kilolar, costsPerKg));
            
        }
        static double Topla(string[] meyveler, double[] kilolar, double[] fiyatlar)
        {
            double toplam = 0;
            int index = 0;
            foreach (string item in meyveler)
            {
                toplam += kilolar[index]*fiyatlar[index];
                index++;
            }
            if (kilolar.Sum() > 10)
            {
                toplam = toplam * 0.75;
            }


            return toplam;
        }

    }
}
