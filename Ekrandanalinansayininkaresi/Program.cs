using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekrandanalinansayininkaresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi ver karesini alalim");
            int karesialinacak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(karesialinacak*karesialinacak);
        }
    }
}
