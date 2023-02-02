using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal _animal = new Animal();

            //Cat _cat = new Cat();

            #region String "+" ile birleştirme ve StringBuilder ile birleştirme farkı
            //string _str = string.Empty;
            //DateTime _dtBegin = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    _str = _str + i.ToString();
            //    Console.WriteLine(_str);
            //}
            //DateTime _dtEnd = DateTime.Now;

            //Console.WriteLine($"{_dtEnd - _dtBegin}");

            //StringBuilder _strBuilder = mew StringBuilder();
            //DateTime _dtBegin_1 = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    _strBuilder.Append(i.ToString());
            //    Console.WriteLine(_strBuilder.ToString());
            //}
            //DateTime _dtEnd_1 = DateTime.Now;
            //Console.WriteLine($"{_dtEnd_1 - _dtBegin_1}");
            #endregion


            //Animal _animal = new Animal();
            //_animal.FootCount = 4;
            //_animal.Age = 2;
            //_animal.BirthDate = new DateTime(2020, 5, 5);
            //_animal.Weight = 10;
            //_animal.Eat();
            //int _cal;
            //_animal.Run(20, 100, out _cal);
            //TimeSpan _restTime = _animal.Rest(DateTime.Now, DateTime.Now.AddMinutes(30));

            //List<HealthCare> _healthCareList = new List<HealthCare>();
            //for( int i = 0; i <=100; i=i+15)
            //{
            //    HealthCare _healthCare = new HealthCare();
            //    _healthCare.Date = DateTime.Today.AddDays(-180).AddDays(i);
            //    _healthCare.Notes = $"Date : {_healthCare.Date.ToString("yyyy-MM-dd")} - " + $"{i.ToString()}";
            
            //    _healthCareList.Add(_healthCare);
            
            //}

            //_animal.HealthCareHistory = _healthCareList;

            //Console.WriteLine("-------------Animal Bilgiler------------------");
            //Console.WriteLine(_animal.AnimalInfo);
            //Console.WriteLine("-------------Animal Bilgiler Bitiş------------------");

            Cat _cat = new Cat();
            _cat.FootCount = 4;
            _cat.Age = 3;
            _cat.BirthDate = new DateTime(2019, 3, 3);
            _cat.Weight = 8;
            _cat.Eat();
            int _calCat;
            int _resultCat = _cat.Run(20,100, out _calCat);
            TimeSpan _restTimeCat = _cat.Rest(DateTime.Now,DateTime.Now.AddDays(20));

            _cat.CatHouse = "Büyük Bir Kedi Evi";
            double _catHousePrice = _cat.CatHousePrice(HouseType.big);


            List<HealthCare> _healthCareList = new List<HealthCare>();
            for (int i = 0; i <= 100; i = i + 15)
            {
                HealthCare _healthCare = new HealthCare();
                _healthCare.Date = DateTime.Today.AddDays(-180).AddDays(i);
                _healthCare.Notes = $"Date : {_healthCare.Date.ToString("yyyy-MM-dd")} - " + $"{i.ToString()}";

                _healthCareList.Add(_healthCare);

            }

            _cat.HealthCareHistory = _healthCareList;

            Console.WriteLine("---------Türetilmiş Cat Sınıfı Bilgileri--------------");
            Console.WriteLine(_cat.AnimalInfo);
            Console.WriteLine(_cat.CatHouse);
            Console.WriteLine(_catHousePrice.ToString());

        }
    }
}
