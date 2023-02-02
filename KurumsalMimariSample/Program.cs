using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimariSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (_type == "MSSQL")
            //{
            //    MSSQLOperations _sql = new MSSQLOperations();
            //    _sql.Insert();
            //}
            //else if (_type == "ORACLE")
            //{
            //    OracleOperations _oracle = new OracleOperations();
            //    _oracle.Insert();
            //}

            Console.WriteLine("*************** MSSQL Server *********");
            DBOperationManager _sqlManager = new DBOperationManager(new MSSQLOperations);
            _sqlManager.Update();
            _sqlManager.Insert();
            _sqlManager.Delete();
            _sqlManager.Read();


            Console.WriteLine("*************** ORACLE Server *********");
            DBOperationManager _oracleManager = new DBOperationManager(new OracleOperations);
            _oracleManager.Insert();
            _oracleManager.Update();
            _oracleManager.Read();
            _oracleManager.Delete();


        }
    }
}
