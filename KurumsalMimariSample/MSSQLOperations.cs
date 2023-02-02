using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimariSample
{
    public class MSSQLOperations : IDBOperations
    {
        public void Delete()
        {
            Console.WriteLine("MSSQL Server =>> Delete İşlemi");
        }

        public void Insert()
        {
            Console.WriteLine("MSSQL Server =>> Insert İşlemi");
        }

        public void Read()
        {
            Console.WriteLine("MSSQL Server =>> Select İşlemi");
        }

        public void Update()
        {
            Console.WriteLine("MSSQL Server =>> Update İşlemi");
        }
    }
}
