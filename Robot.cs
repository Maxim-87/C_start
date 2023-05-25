using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1
{
    abstract class Robot : IRun, IJump  {
        // public /* доступно везеде */
        // protected /* доступен внутри класса и классах наследниках */
        // private /* досутпен только внутри этого класса */

        public static int count; // can use it directly (without creating new object Robot) Robot.count = 12 / don't use this

        // -------------------- ACCESSORS (get / set)

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


        public static void Show() {
            Console.WriteLine("Show method is invoking");
        }

        // public string name;
        // public int weight;
        // public byte[] coodrinates;
        private string name;
        private int weight;
        private byte[] coodrinates;
        protected string surname;
        public Robot(string name, int weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coodrinates = coordinates;
            setValues(name, weight, coodrinates);
        }

        public Robot() { }

        public string Name { get {
            return name;
        } set {

        }}
        public byte[] Coodrinates { get {
            return coodrinates;
        } set {

        }}

        public float speed { get; set; }
        public float y { get; set; }

        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coodrinates = coordinates;
        }

        public void setValues(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public abstract void printValues();

        public void RobotRun() {
            Console.WriteLine("Robot is now running");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is now jumping");;
        }
    }
}
