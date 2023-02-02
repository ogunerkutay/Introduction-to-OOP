using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimariSample
{
    public class DBOperationManager : IDBOperations
    {
        private IDBOperations db;
        public DBOperationManager(IDBOperations _db)
        {
            db = _db;
        }
        public void Delete()
        {
            db.Delete();
        }

        public void Insert()
        {
            db.Insert();
        }

        public void Read()
        {
            db.Read();
        }

        public void Update()
        {
            db.Update();
        }
    }
}
