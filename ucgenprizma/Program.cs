using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgenprizma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kenar1 = 0, kenar2 = 0, kenar3 = 0, prizmayuksekligi, semiperimeter = 0;
            double area;

            do
            {
                {
                    Console.WriteLine("Lütfen 1. kenar uzunluğunu giriniz.");
                    kenar1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen 2. kenar uzunluğunu giriniz.");
                    kenar2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen 3. kenar uzunluğunu giriniz.");
                    kenar3 = Convert.ToInt32(Console.ReadLine());
                    if (kenar1<=0 || kenar2<=0 || kenar3<=0)
                    {
                        Console.WriteLine("Kenarı 0 olan veya negatif kenarlı bir üçgen oluşturulamaz!");
                    }
                    else
                    {
                        if ((kenar1 + kenar2) > kenar3 && (kenar1 + kenar3) > kenar2 && (kenar2 + kenar3) > kenar1)
                        {
                            Console.WriteLine("Böyle bir üçgen oluşturulabilir!");
                            Console.WriteLine("Üçgenin çevresi: " + (kenar1 + kenar2 + kenar3));
                            semiperimeter = (kenar1 + kenar2 + kenar3) / 2;
                            area = Math.Sqrt(semiperimeter * (semiperimeter - kenar1) * (semiperimeter - kenar2) * (semiperimeter - kenar3));
                            Console.WriteLine("Üçgenin alanı: " + area);
                            Console.WriteLine("Lütfen bir yükseklik giriniz.");
                            prizmayuksekligi = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgen prizmanın hacmi: " + area * prizmayuksekligi);

                        }
                        else
                        {
                            Console.WriteLine("Böyle bir üçgen oluşturulamaz!");
                        }
                    }

                }
            } while (true);

        }
    }
}
