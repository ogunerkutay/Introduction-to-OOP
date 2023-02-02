using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_EkranaYaz_BelliFormatta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime moment = new System.DateTime();
            moment = DateTime.Now;
            Console.WriteLine($"Bugün {moment.ToString("yyyy")} yılının {moment.ToString("MMMM")} ayının {moment.ToString("dd")}.günü Saat{moment.ToString(" HH:mm:ss")}");
        }
    }
}
