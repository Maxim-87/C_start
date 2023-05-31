using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1
{
    enum Type { Enemy, Hero, Traitor}
    class Terminator : Robot
    {
        public Type type;
        public Terminator() { }

        // accepting and passing arguments to parent
        public Terminator(string name, int weight, byte[] coordinates, int health, Type type) : base(name, weight, coordinates)
        {
            this.Health = health;
            this.type = type;

        }

        public override void printValues()  {
           Console.WriteLine("name: " + this.Name + " weight: " + this.Weight, "coordinate: ");
           Console.WriteLine("Health: " + this.Health);
        }
        public int Health { get; set; }

        public void Lazer()
        {
            Console.WriteLine("Lazer shouting");
            this.surname = "Olla";
            Console.WriteLine(surname);
        }
    }
}
