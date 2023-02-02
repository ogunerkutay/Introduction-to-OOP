using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Recursive_Yildiz_Cizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YildizCiz(5);
        }
        static void YildizCiz(int adet)
        {
            if (adet!=0)
            {
                YildizCiz(adet - 1);
                for (int i = 0; i < adet; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
