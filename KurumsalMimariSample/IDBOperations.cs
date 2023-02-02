using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimariSample
{
    public interface IDBOperations
    {
        void Insert();
        void Delete();
        void Update();

        void Read();
    }
}
