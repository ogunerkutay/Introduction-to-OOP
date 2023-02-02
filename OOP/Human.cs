using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Human
    {
        public Human()
        {
            Console.WriteLine("Parametresiz constructor çalıştı");
            _id = Guid.NewGuid();
        }

        public Human(string _name)
        {
            Console.WriteLine("Parametresiz constructor çalıştı");
            Name = _name;
            _id = Guid.NewGuid();
        }

        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            //set { _id = value; }
        }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthDate.Year } }
        
        private string job;
        public string Job 
        {
            get { return job; } 
            set {
                if (Age < 18) { job = "18 yaşından küçük çalışamaz"; }
                else { job = value; }
            }
        }
        
        public void Eat(Fruit fruit)
        {
            Console.WriteLine($"{Name} {fruit.Name} yedi");
        }
        public void Play(Game game)
        {
            Console.WriteLine($"{Name} {game.Name} oynuyor");
        }

        public Game CreateGame(string name)
        {
            Game game = new Game();
            game.Name = name;
            return game;
        }


        //public string Yenistring(char[] array)
        //{
        //    string a = new string(array);
        //return a;
        //}
       
        public Game Update(Game game, string name)
        {
            game.Name = name;
            return game;

        }
            
    }
}
