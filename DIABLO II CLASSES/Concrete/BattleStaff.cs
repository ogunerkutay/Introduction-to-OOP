using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES.Concrete
{
    internal class BattleStaff
    {

        //Weapon, IDurable,ISockets,IRangeAdder,IHit

    public int MaxDurability { get; set;}
    public int CurrentDurability { get; set;}
    public int Sockets { get; set;} 
     public int RangeAdder { get; set;} 

    public void AddSockets()
        {
            Sockets++;
        
        }
    public void Hit()
        {

        }

    }
}
