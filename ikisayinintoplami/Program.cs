using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikisayinintoplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int sum = num1 + num2 + num3;
            Console.WriteLine($"{num1}+{num2}+{num3}={sum}");
            Console.WriteLine("üç sayının toplamı: " + sum);
        }
    }
}
