using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    internal class MarathonRunner : Insanlar, IRun
    {

        public int RunningSpeed { get; set; }

        public int RunningDistance { get; set; }

        public void Run()
        {
            Console.WriteLine($"{Name} {RunningSpeed} m/s ile koşuyor");
        }

    }

}
