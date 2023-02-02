using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Day of Week : {DayofWeek.Monday} - {(int)DayofWeek.Monday}");
            //Console.WriteLine($"Day of Week : {DayofWeek.Tuesday} - {(int)DayofWeek.Tuesday}");
            //Console.WriteLine($"Day of Week : {DayofWeek.Wednesday} - {(int)DayofWeek.Wednesday}");
            //Console.WriteLine($"Day of Week : {DayofWeek.Thursday} - {(int)DayofWeek.Thursday}");
            //Console.WriteLine($"Day of Week : {DayofWeek.Friday} - {(int)DayofWeek.Friday}");
            //Console.WriteLine($"Day of Week : {DayofWeek.Saturday} - {(int)DayofWeek.Saturday}");
            //Console.WriteLine($"Day of Week : {DayofWeek.Sunday} - {(int)DayofWeek.Sunday}");
        
            Console.WriteLine("Enum Type Names")
            string[] days = Enum.GetNames(typeof(DayofWeek));
            foreach (string day in days)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("Enum Type Values");
            int[] dayValues = (int[])Enum.GetValues(typeof(DayofWeek));
            foreach (int dayValue in dayValues)
            {
                Console.WriteLine(dayValue);
            }

            int secim = 1;
            string secilenGun = Enum.GetName(typeof(DayofWeek), secim);
            Console.WriteLine(secilenGun);

        }
    }

    enum DayofWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum DayofWeek_1
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum DayofWeek_2
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
    }
    enum DayofWeek_3 :byte
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum DayofWeek_4 : short
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
