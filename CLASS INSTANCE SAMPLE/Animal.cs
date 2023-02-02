using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_INSTANCE_SAMPLE
{
    internal class Animal
    {   
        //public string _animalType; //Field
        //internal string _animalType; //Field
        string _animalType; //Field
        int _animalSpeed;
        public Animal() //Constructor
        {

            Console.WriteLine("Animal Begin");

        }

        public Animal(string AnimalType) //Constructor
        {
            Console.WriteLine($"Animal Begin : {AnimalType}");

        }

        public void setAnimal(string animalType)
        {
            this._animalType = animalType;
        }

        public string getAnimal()
        {
            return this._animalType;
        }
        public void setAnimalSpeed(int animalSpeed)
        {
            this._animalSpeed = animalSpeed;
        }

        public int getAnimalSpeed()
        {
            return this._animalSpeed;
        }

        ~Animal() //Destructor
        {
            Console.WriteLine("Animal Stop");
        }
    }
}
