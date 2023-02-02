using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Example
{
    internal class Person
    {

        /*Access Modifiers
        * private: Aynı class içerisinde erişilebilen değişken,field, method, function tanımlamak için kullanılıyor
        * 
        * internal: Aynı projede kullanılacak değişken, field, method, function tanımlamak için kullanılıyor
        * 
        * protected: Inherit(Miras, Kalıtım)yapılarak türettiğimiz sınıflarda kullanmak istediğimiz değişken, field, method, function 'lar için kullanılır.
        * 
        * internal protected: Aynı projede türetilerek(Kalıtım alınarak) oluşturulan sınıflarda kullanılacak değişken, metot, field ve function 'lar için kullanılır.
        * 
        * public: Her projeden çağrılarak kullanılabilecek değişkenler, field, method ve functionlar için kullanılır
        * 
        */


        public Person()
        {
            Console.WriteLine("Init Person");
        }
        public Person(int age)
        {
            Console.WriteLine($"Age : {age}");
        }

        private string firstName;
         
        public string FirstName
        {
            get 
            {
                return firstName; 
            }
            set 
            {
                firstName = value; 
            }
        }

        private string lastName;
        //public string LastName { get => lastName; set => lastName = value; }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate { get; set; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }

        private string gender;
        private string email;
        private string phone;
        private string adress;

        private string personInfo;
        public string PersonInfo
        {
            get
            {
                personInfo = $"Name : {firstName} {lastName}\n" + $"Gender : {gender}\n" + $"Email : {email}\n" + $"Phone : {phone}\n" + $"Adress : {adress}\n" + $"Birth Date : {BirthDate}"; 
                return personInfo;
            }
        }

    }
}
