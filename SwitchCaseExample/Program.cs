using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strGender = string.Empty;
            char chrGendeR = 'A';
            string msg = string.Empty;
            Console.Write("Cinsiyetinizi giriniz.[Erkek/Kadın/Diğer] : ");
            strGender = Console.ReadLine().Trim().ToLower();
            switch (strGender)
            {
                case "erkek":
                    chrGendeR = 'E';
                    break;
                case "kadın":
                    chrGendeR = 'K';
                break;
                default:
                    chrGendeR = 'D';
                    break;
            }
            Console.WriteLine("Cinsiyetinizin kodu: " + chrGendeR);
        }
    }
}
