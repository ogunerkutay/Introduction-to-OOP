using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimariSample
{
    public class OracleOperations : IDBOperations
    {
        public void Delete()
        {
            Console.WriteLine("Oracle Server =>> Delete İşlemi");
        }

        public void Insert()
        {
            Console.WriteLine("Oracle Server =>> Insert İşlemi");
        }

        public void Read()
        {
            Console.WriteLine("Oracle Server =>> Select İşlemi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server =>> Update İşlemi");
        }
    }
}
