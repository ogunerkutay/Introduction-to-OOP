using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10luktanbinariye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2lik sisteme çevrilecek 10luk sayıyı giriniz:   ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string ekranayazilan="";
            double asd = 0;
            double basd = 0;
            int i = 0;

            while (basd<sayi)
            {
                asd = Math.Pow(2, i);
                basd = basd + asd;
                ekranayazilan = asd + ekranayazilan;
                Console.WriteLine(basd);
                i++;
                
            }
            basd = basd - asd;
            i--;
            //while (i>0)
            //{
            //    asd = Math.Pow(2, i);
            //    basd = basd + asd;
            //    if (basd > sayi)
            //    { 
            //        basd = basd - asd;
            //        ekranayazilan = ekranayazilan + 0;
            //    }
            //    if (basd<sayi)
            //    {
            //        ekranayazilan = ekranayazilan + 1;
            //    }
            //    i--;
            //}

            Console.WriteLine(ekranayazilan);

        }
    }
}
