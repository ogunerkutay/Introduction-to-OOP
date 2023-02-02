using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES.Abstract
{
    abstract class Weapon
    {
        public WeaponType WeaponType { get;set }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int MinDexterity { get; set; }
        public int HitSpeet { get; set; }   
    }
}
