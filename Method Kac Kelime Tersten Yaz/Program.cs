using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Kac_Kelime_Tersten_Yaz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "Bu cümlede kaç kelime var acaba?";
            Console.WriteLine(KacKelime(str));
            Console.WriteLine(TersiniVer(str));
            Console.WriteLine(IsPalindrome(str));
        }
        static int KacKelime(string args)
        {
            string [] dizi = args.Split(' ');
            return dizi.Length;
        }
        static string TersiniVer(string args)
        {
            char[] c = args.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        static bool IsPalindrome(string args)
        {
            string kiyas = TersiniVer(args);
            if (kiyas == args) return true;
            else return false;
        }


    }
}
