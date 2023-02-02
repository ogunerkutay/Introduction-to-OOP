using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sample
{
    public class HealthCare
    {
        public HealthCare()
        {
            Console.WriteLine("Sağlık Bilgilerinini tutulduğu sınıf. " + $"Type : {typeof(HealthCare)}");
        }

        private DateTime _date;
        private string _notes;

        public DateTime Date { get => _date; set => _date = value; }
        public string Notes { get => _notes; set => _notes = value; }
    
    
    }
}
