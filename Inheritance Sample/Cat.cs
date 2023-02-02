using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sample
{
    public enum HouseType
    {
        small,
        normal,
        big
    }
    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine($"Class Cat Constructor. Type : {typeof(Cat)}");
        }

        private string _catHouse;

        public string CatHouse { get => _catHouse; set => _catHouse = value; }
    
        
        public double CatHousePrice(HouseType _houseType)
        {
            double _result = 0.0;
            switch (_houseType)
            {
                case HouseType.small:
                    _result = 300;
                    break;
                case HouseType.normal:
                    _result = 500;
                    break;
                case HouseType.big:
                    _result = 1000;
                    break;
            }
            return _result;
        }
    
    }
}
