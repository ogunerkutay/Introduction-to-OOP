using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_INSTANCE_SAMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //    Animal _animal = new Animal();
            //    Animal _animalCat = new Animal("Cat");

            //    _animal.setAnimal("Dog");

            //    Console.WriteLine($"Animal Type : {_animal.getAnimal()}");

            //    _animal.setAnimalSpeed(100);

            //    Console.WriteLine($"Animal Speed : {_animal.getAnimalSpeed()}");
            
            //Garbage Collector çalışsın diye 
            for (int i = 0; i < 100000; i++)
            {
                Animal _animal = new Animal();
                _animal = null; //Deconstructor çalışsın diye

            }

        }
    }
}