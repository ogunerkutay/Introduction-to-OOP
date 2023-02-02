using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES.Concrete
{
    internal class AncientArmor
    {
        public int MaxDurability { get; set; }
    
    
        public void AddSockets()
        {
            Sockets++;
            Console.WriteLine("1 adet soket eklendi");
        }
    }
}
