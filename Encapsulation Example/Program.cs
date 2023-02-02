using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John"; //atama set
            person.LastName = "Doe";
            person.BirthDate = DateTime.Now.AddYears(-30);
            person.Email = "john.doe@contoso.com";
            person.Phone = "3454353535";
            person.Gender = "Male";
            person.Adress = "USA";

            Console.WriteLine(person.PersonInfo);
            //string _firstname = person.FirstName; //okuma get
        }
    }
}
