using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1
{
    class Bot : Robot
    {
        public Bot() { }

        // accepting and passing arguments to parent
        public Bot(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates) {

        }

        public override void printValues() {
             {
            Console.WriteLine("name: " + this.Name + " weight: " + this.Weight, "coordinate: ");
            foreach (int item in this.Coodrinates)
            {
                Console.WriteLine(item);
            }
        }

        }
    }
}
