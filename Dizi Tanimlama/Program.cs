using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Tanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int numberCount1 = numbers.Length;
            int numberCount2 = numbers.GetLength(0);
            int numberCount3 = numbers.GetLength(1);
            Console.WriteLine(numberCount1);
            Console.WriteLine(numberCount2);
            Console.WriteLine(numberCount3);
        }
    }
}
