using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Berkay");
            Human human2 = new Human();
            //human.Name = "Berkay";

            human.BirthDate = new DateTime(1999, 07, 22);

            human.Job = "10 Numara Yazılımcı";

            human2.BirthDate = new DateTime(2020,07,22);

            human2.Job = "9.8 numara yazılımcı";

            Console.WriteLine(human.Name + " isimli vatandaş " + human.Age + " yaşındadır. Id= " + human.Id + " İşi= " + human.Job);
            
            Console.WriteLine(human2.Name + " isimli vatandaş " + human2.Age + " yaşındadır. Id= " + human2.Id + " İşi= " + human2.Job);

            Fruit elma = new Fruit();
            elma.Name = "elma";

            human.Eat(elma);

            Game game = human.CreateGame("Şu an yok");
            
            //Game game = new Game();
            //game.Name = "Farketmez";

            human2.Play(game);

            Game game1 = human2.Update(game, "Artık var");

            human.Play(game1);
            
        }
    }
}
