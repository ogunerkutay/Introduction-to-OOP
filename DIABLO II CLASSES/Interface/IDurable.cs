using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES.Interface
{
    internal interface IDurable
    {
        int MaxDurability { get; set; }  
        int CurrentDurability { get; set; }
    }
}
