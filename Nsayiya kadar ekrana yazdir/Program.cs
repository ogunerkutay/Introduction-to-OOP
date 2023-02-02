using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsayiya_kadar_ekrana_yazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            do
            {
                Console.WriteLine("bir sayi yaz, sayalim");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    for (int i = 0; i >= sayi; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (sayi > 0)
                {
                    for (int i = 0; i <= sayi; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }


            } while (true);


        }
    }
}
