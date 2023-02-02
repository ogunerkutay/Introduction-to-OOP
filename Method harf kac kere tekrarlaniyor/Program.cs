using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_harf_kac_kere_tekrarlaniyor
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            Console.WriteLine(KacKere(Kelime(), Harf()));
        }

        private static char Harf()
        {
            char okunanHarf;
            bool isChar = false;
            do
            {
                Console.WriteLine("bir harf yazin");
                isChar = char.TryParse(Console.ReadLine(),out okunanHarf);
            } while (isChar==false);

            return okunanHarf;
        }

        private static string Kelime()
        {
            Console.WriteLine("bir kelime yazin");
            return Console.ReadLine();
        }

        static int KacKere(string kelime,char harf)
        {
            int kackere = 0;
                foreach (char harfler in kelime)
                {
                    if (harfler == harf)
                    {
                        kackere++;
                    }
                }
            return kackere;
        }
    }
}
