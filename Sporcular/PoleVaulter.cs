using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    internal class PoleVaulter :HighJumper
    {
        public string Pole { get; set; }
        public int RunningSpeed { get; set; }

        public int JumpingHeight { get; set; }

        public void Run()
        {
            Console.WriteLine($"{Name} {RunningSpeed} m/s ile koşuyor");
        }
        public override void Jump()
        {
            Console.WriteLine($"{Name} {JumpingHeight} cm yüksekliğe zıpladı");
        }
    }
}
