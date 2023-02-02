using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDenemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat tekir = new Cat();
            tekir.Name = "Garfield";
            tekir.Sleep();
            tekir.Sound();
            tekir.Eat();
            Console.WriteLine($"{tekir.Name} id: {tekir.Id}");


            Dog dog = new Dog();
            dog.Name = "Snoopy";
            dog.Sleep();
            dog.Sound();
            dog.Eat();
            Console.WriteLine($"{dog.Name} id: {dog.Id}");

            Dolphin dolphin = new Dolphin();
            dolphin.Name = "Free Willie";
            dolphin.Toy = "ball";
            dolphin.Play();

            Feed(dog);
            Feed(dolphin);
            
            PlayWithInterFace(dolphin);
            PlayWithInterFace(dog);

            Animal dog2 = new Dog();
            IPlay animal = new Dolphin();
            //animal.toy
            
            List<Animal> animals = new List<Animal>();
            animals.Add(tekir);
            animals.Add(dog);
            animals.Add(dolphin);

            List<IPlay> animals2 = new List<IPlay>();
            //animals2.Add(tekir);
            animals2.Add(dog);
            animals2.Add(dolphin);

            Asena asena = new Asena();
            asena.Name = "Asena";
            asena.Toy = "Play Station 5";
            PlayWithInterFace(asena);


        }

        static void Feed(Animal animal)
        {
            Console.WriteLine($"{animal.Name} is fed");
        
        }
    
        static void PlayWithInterFace(IPlay animal)
        {
            animal.Toy = "ball";
            animal.Play();
            ((Animal)animal).Name = "a";
            if (animal.GetType() == typeof(Dog))
            {
                ((Dog)animal).AsiSayisi = 5;
            }

        }
    }
}
