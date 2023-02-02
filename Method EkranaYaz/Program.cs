using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_EkranaYaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz("Merhaba Dünya");
        }
        static void EkranaYaz(string yazilacakMetin)
        {
            Console.WriteLine(yazilacakMetin);
        }
    }
}
