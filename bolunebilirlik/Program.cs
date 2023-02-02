using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolunebilirlik
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
                if (sayi == 0)
                {
                    Console.WriteLine("0 / {0} ", sayi);
                }
                else
                {
                    if ((sayi % 4) == 0 & (sayi % 7) == 0)
                    {
                        Console.WriteLine("{0} sayisi 4'e ve 7'ye tam bölünür.", sayi);
                    }
                    else
                    {

                        if ((sayi % 4) == 0)
                        {
                            Console.WriteLine("{0} sayisi 4'e tam bölünür.", sayi);

                        }
                        else if ((sayi % 7) == 0)
                        {
                            Console.WriteLine("{0} sayisi 7'e tam bölünür.", sayi);

                        }
                        else
                        {
                            Console.WriteLine("{0} sayisi 4'e  ve 7'e tam bölünemez.", sayi);
                        }
                    }
                }

                
            } while (true);
        }
    }
}
