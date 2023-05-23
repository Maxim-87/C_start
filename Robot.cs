using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1
{
    public class Robot
    {
        // public /* доступно везеде */
        // protected /* доступен внутри класса и классах наследниках */
        // private /* досутпен только внутри этого класса */

        public static int count; // can use it directly (without creating new object Robot) Robot.count = 12 / don't use this

        // -------------------- ACCESSORS (get / set)
/*
        public int Weight {
            get {
                Console.Write("Value: ");
                return this.weight;
            }
            set {
                if (value < 1)
                this.weight = 1;
                else
                this.weight = value;
            }
        }

        public int Width {private get; set; }

*/
        public static void Show() {
            Console.WriteLine("Show method is invoking");
        }

        // public string name;
        // public int weight;
        // public byte[] coodrinates;
        private string name;
        private int weight;
        private byte[] coodrinates;
        public Robot(string name, int weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coodrinates = coordinates;
            setValues(name, weight, coodrinates);
        }

        public Robot() { }

        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coodrinates = coordinates;
        }

        public void printValues()
        {
            Console.WriteLine("name: " + name + " weight: " + weight, "coordinate: ");
            foreach (int item in coodrinates)
            {
                Console.WriteLine(item);
            }
        }



    }
}
