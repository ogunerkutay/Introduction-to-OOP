using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sample
{
    public class Animal
    {
        public Animal()
        {

            Console.WriteLine($"Ortak Özelliklerin bulunduğu animal sınıfı . Type : {typeof(Animal)}");
        }

        #region Properties
        private int _footCount;
        private int _age;
        private DateTime _birthDate;
        private List<HealthCare> _healthCareHistory;
        private double _weight;

        public int FootCount
        { get => _footCount; set => _footCount = value; }
        public int Age
        { get => _age; set => _age = value; }
        public DateTime BirthDate
        { get => _birthDate; set => _birthDate = value; }
        public List<HealthCare> HealthCareHistory
        { get => _healthCareHistory; set => _healthCareHistory = value; }
        public double Weight
        { get => _weight; set => _weight = value; }


        #endregion

        #region Procedures

        public void Eat()
        {
        Console.WriteLine("Animal Eat");
        }

        public int Run(int minute, int distance, out int cal)
        {
            int _result;
            _result = minute * distance;

            cal = _result/100;
            return _result;
        }
        
        public TimeSpan Rest(DateTime beginDate, DateTime endDate)
        {
            TimeSpan _result;
            _result = endDate.Subtract(beginDate);
            return _result;
        }
        #endregion

        private string _animalInfo;
        public string AnimalInfo
        {
            get
            {
                string _result;
                StringBuilder _str = new StringBuilder();
                _str.Append($"FootCount : {_footCount}\n");
                _str.Append($"Age: { _age}\n");
                _str.Append($"BirthDate: { _birthDate}\n");
                _str.Append($"Weight: { _weight}\n");
                _str.Append($"Health Care History : " + $"{GetHealthCareHistory(HealthCareHistory)}");

                _result = _str.ToString();
                return _result;

            }
        }
    
            private string GetHealthCareHistory(List<HealthCare> HealthCareHistory)
        {
            string _result;
            StringBuilder _str = new StringBuilder();
            foreach (HealthCare item in HealthCareHistory)
            {
                _str.Append($"{item.Date.ToString("yyyy-MM-dd")} - {item.Notes}");
                _str.Append(";");

            }
            
            _result = _str.ToString();
            return _result;
        }
    
    }
}

