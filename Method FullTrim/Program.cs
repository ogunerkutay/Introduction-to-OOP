using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_FullTrim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FullTrim(" ali ata      bak   "));
        }
        static string FullTrim(string stringIfade)
        {
            var demo = stringIfade.Split(' ').Where(ifade => !string.IsNullOrWhiteSpace(ifade));
            return stringIfade = string.Join(" ", demo);
        }
    }
}
