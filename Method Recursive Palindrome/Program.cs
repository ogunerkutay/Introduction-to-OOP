using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Recursive_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sonuc = Palindrome("kek");
            Console.WriteLine(sonuc);
        }
        static bool Palindrome(string kelime)
        {
            bool sonuc = true;
            if (kelime.Length<=1)
            {
                sonuc = true;
            }
            else
            {
                if (kelime[0] != kelime[kelime.Length-1])
                {
                    sonuc = false;
                }
                else
                {
                    sonuc = Palindrome(kelime.Substring(1, kelime.Length - 2));
                }
                
            }

            return sonuc;
        }
    }
}
