using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_metodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result =0;
            Console.WriteLine("5'in 3e bölümü : " + Math.DivRem(5, 3, out result));
            Console.WriteLine("5'in 3e bölümünden kalan : " + result);
            Console.WriteLine("5.3'ün aşağı yuvarlanması : " + Math.Floor(5.3d));
            Console.WriteLine("5.3'ün yukarı yuvarlanması : " + Math.Ceiling(5.3d));
            Console.WriteLine("5.3'ün normal yuvarlanması : " + Math.Round(5.3d));
            Console.WriteLine("5 ve 3'ün hangisinin ufak olduğu : " + Math.Min(5,3));
            Console.WriteLine("5 ve 3'ün hangisinin büyük olduğu : " + Math.Max(5, 3));
            Console.WriteLine("5'in kare kökü : " + Math.Sqrt(5));
            Console.WriteLine("5'in 3. kuvveti : " + Math.Pow(5, 3));
            Console.WriteLine("25'in 5 tabanında logaritması : " + Math.Log(25, 2));
        }
    }
}
