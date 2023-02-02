using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporcular
{
    internal class HighJumper : Jumper, IRun, IJump
    {
        public int RunningSpeed { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} {RunningSpeed} m/s ile koşuyor");
        }
        public void Jump()
        {
            Console.WriteLine($"{Name} {JumpingHeight} cm yüksekliğe zıpladı");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} çok yedi");
        }
    }
}
