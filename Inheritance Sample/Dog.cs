using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sample
{
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine($"Class Dog Constructor. Type : {typeof(Dog)}");
        }

        private int _foodPacketCount;
        private double _foodPackedPrice;

        public int FoodPacketCount { get => _foodPacketCount; set => _foodPacketCount = value; }
        public double FoodPackedPrice { get => _foodPackedPrice; set => _foodPackedPrice = value; }

        public double CalculateFoodPrice(int feedCountDaily)
        {
            double _result;
            _result = feedCountDaily * _foodPacketCount * _foodPackedPrice; 
            return _result;

        }
    
    
    
    
    
    }


}
