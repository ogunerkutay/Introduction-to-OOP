using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO_II_CLASSES
{
    public abstract class Character
    {
        private int strength;
        private int dexterity;
        private int vitality;
        private int energy;
        private int life;
        private int stamina;
        private int mana;

        public virtual int Strength { get => strength;}
        public virtual int Dexterity { get => dexterity;}
        public virtual int Vitality { get => vitality;}
        public virtual int Energy { get => energy;}
        public virtual int Life { get => life;}
        public virtual int Stamina { get => stamina;}
        public virtual int Mana { get => mana;}


        public virtual void DrinkLifePotion()
        {
            Console.WriteLine($"{this.GetType().Name} drank health potion");
        }
        public virtual void DrinkManaPotion()
        {
            Console.WriteLine($"{this.GetType().Name} drank mana potion");
        }
    }



}
