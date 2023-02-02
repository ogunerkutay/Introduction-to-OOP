using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToplaBase _toplam = new ToplaBase();
            //UcSayiTopla _topla = new UcSayiTopla();
            UcSayiTopla _topla = new UcSayiTopla(5,8,10);
        }
    }
}
