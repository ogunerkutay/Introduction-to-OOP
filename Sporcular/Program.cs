using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighJumper highJumper = new HighJumper();
            highJumper.Name = "Halil";
            highJumper.Age = 30;
            highJumper.Gender = "Erkek";
            highJumper.RunningSpeed = 5;
            highJumper.JumpingHeight = 50;
            highJumper.Run();
            highJumper.Jump();
        }
    }
}
