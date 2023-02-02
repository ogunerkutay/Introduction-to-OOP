using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Struct new ile birlikte kullanıldığında özelliklerin veri tiplerinin initial değerlerini alır
            //Person person = new Person();
            //Console.WriteLine(person.Id);
            //Console.WriteLine(person.Ad);
            //Console.WriteLine(person.Soyad);
            //Console.WriteLine(person.Gender);

            //New kullanılmadan struct tanımı. Özelliklerin ilk değerlerinin atanması gerekmekte
            //Person person;
            //person.Id = 1;
            //person.Ad = "John";
            //person.Soyad = "Doe";
            //person.Gender = true;
            //Console.WriteLine(person.Id);
            //Console.WriteLine(person.Ad);
            //Console.WriteLine(person.Soyad);
            //Console.WriteLine(person.Gender);


            //Struct içerisinde property ve metot kullanılabilir. Property kullanılabilmesi için mutlaka struct new kullanılarak örneği üretilmeli.
            //Person person = new Person();
            //person.Id = 1;
            //person.Ad = "John";
            //person.Soyad = "Doe";
            //person.Gender = true;
            //Console.WriteLine(person.ToString());


            //Struct içerisinde tanımlanan sınıf kullanımı
            //Person person = new Person();
            //person.Id = 1;
            //person.Ad = "John";
            //person.Soyad = "Doe";
            //person.Gender = true;
            //Person.Adres _adres = new Person.Adres();
            //_adres.AdresId = 1;
            //_adres.AdresBilgisi = "Kadıköy";
            //_adres.Il = "İstanbul";
            //_adres.Ilce = "Kadıköy";
            //Console.WriteLine(person.ToString());


            //bir Class içerisindeki struct yapısının kullanımı
            //User.UserDetail _userDetail = new User.UserDetail();
            //_userDetail.FirstName = "Jeyn";
            //_userDetail.LastName = "Doe";
            //_userDetail.Email = "jeyn.doe@contoso.com";
            //_userDetail.Phone = "878375849543";


            //DEEP COPY
            Console.WriteLine("***********Struct Yapısı*********");
            PointInfoStruct _point1 = new PointInfoStruct();
            _point1.x = 3;
            _point1.y = 5;

            PointInfoStruct _point2 = _point1;
            _point2.x = 13;
            _point2.y = 15;
            
            string _str = $"Point1 : {_point1.x} - {_point1.y}\n" + $"Point1 : {_point2.x} - {_point2.y}";
            Console.WriteLine(_str);

            //SHALLOW COPY
            Console.WriteLine("***********Class Yapısı*********");
            PointInfoClass _point3 = new PointInfoClass();
            _point3.x = 30;
            _point3.y = 50;

            PointInfoClass _point4 = _point3;
            _point4.x = 130;
            _point4.y = 150;

            string _str1 = $"Point1 : {_point3.x} - {_point3.y}\n" + $"Point1 : {_point4.x} - {_point4.y}";
            Console.WriteLine(_str1);


        }
    }

    class PointInfoClass
    {
        public int x;
        public int y;
    }

    struct PointInfoStruct
    {
        public int x;
        public int y;
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public struct UserDetail
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }


        }

    }


    struct Person
    {
        private int ıd;
        private string ad;
        private string soyad;
        private bool gender;

        public int Id { get => ıd; set => ıd = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public bool Gender { get => gender; set => gender = value; }

        public override string ToString()
        {
            StringBuilder _str = new StringBuilder();
            _str.Append($"Person ID : {Id}\n");
            _str.Append($"Name : {Ad} {Soyad}");
            _str.Append($"Person ID : {Gender}");
            return _str.ToString();

        }
        public class Adres
        {
            public string AdresId { get; set; }
            public string AdresBilgisi { get; set; }
            public string Il { get; set; }
            public string Ilce { get; set; }


        }
    
    }

    #region Struct için Inheritance Yapısı
    //Bir struct başka bir struct ya da sınıf kullanılarak türetilemez
    //struct PointInfo : OneDimensionPoint
    //{
    //    int x;
    //    int y;
    //}
    //struct DimensionPoint : PointInfo
    //{
    //    int x;
    //    int y;
    //    int z;
    //}

    //class OneDimensionPoint
    //{
    //    int x;

    //}



    //Struct sadece Interface kullanılarak inherit alabilir
    //struct PointInfo : IPointInfo
    //{
    //    public int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    void IPointInfo.PointInfo(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //interface IPointInfo
    //{
    //    int x { get; set; }
    //    int y { get; set; }

    //    void PointInfo(int x, int y);
    //}


    #endregion



}
