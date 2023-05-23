using System;

namespace project1
{
    class Program
    {
        static void Main()
        {
            /*
            byte c; // maximum 255, use less memory than int
            short d; // maximum 32650, if need large number instead of byte
            long f; // great number
            int a;
            uint b;  // negative number
            float num = 4.231321f; // if not integer number;
            double num1 = 4.231321d; // large not integer number;
            string word = "dsfsdfsdfsdf";
            bool isHappy;
            isHappy = true;
            // char j = "s"; // only one symbol
            a = 24;
            Console.WriteLine("Hello 1");
            // Console.Write("Hello 2");
            // Console.WriteLine("Hello 3");
            Console.WriteLine("Variable " + a + ".");
            Console.WriteLine(isHappy);
            // Console.ReadLine();
            // Console.Read();
*/
            /* if else//
                       int num_1 = 0, num_2 = 0;
                       int[] arr = new int[2] {1,2}; // arr[0] = 1; arr[1] = 2;
                       int[] arr1 = arr;

                       num_1 = Convert.ToInt32(Console.ReadLine());
                       num_2 = Convert.ToInt32(Console.ReadLine());

                       Console.WriteLine(num_1 + "" + num_2);

                       string name = "Max", surname = "Pov";
                       Console.WriteLine($"{name} + {surname}" );

                    int a = 0;
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 5) {
                         Console.WriteLine("a = " + a);
                    }
                    else Console.WriteLine("a != 5");
                    */

            // switch case
            /*
            Console.WriteLine("Enter any number");
            short user_input = Convert.ToInt16(Console.ReadLine());
            switch (user_input)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                default:
                    Console.WriteLine("Other number");
                    break;

            }
*/
            /*
                        double user_input;
                        user_input = Convert.ToDouble(Console.ReadLine());
                        // user_input = float.Parse(Console.ReadLine());
                        double result;
                        result = user_input;
                        result--;
                        Console.WriteLine("Variable: " + result);
            */
            /*
           Console.WriteLine("Enter radius of circle");
           int radius;
           radius = Convert.ToInt32(Console.ReadLine());
           int square = Convert.ToInt32(Math.PI * Math.Pow(radius,2));
           Console.WriteLine("Square of circle with radius {0} equals {1}", radius, square);
           */

            // Arrays
            /*
            byte[] nums = new byte[4];
            Console.WriteLine(nums.Length);
            nums[0] = 5;
            nums[0] = 16;
            Console.WriteLine(nums);

            string[] letters = new string[] { "Artur", "Alex", "Elena" };
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i]);
            }

            short[] numbers = new short[5];
            int sum = 0;
            Random random = new Random();
            for (var i = 0; i < numbers.Length; i++) {
                numbers[i] = Convert.ToInt16(random.Next(1,6));
                Console.WriteLine(numbers[i]);
                sum = sum + numbers[i];
                Console.WriteLine(sum);
            }
            */

            // multivariate array
            /*
    char[,] letter = new char[2,3]; // === char[,] letter = {{4,5}, {1,2,3}}
    */

            // dynamic array
            /*
            List<int> numbers = new List<int> () {4,5,6};
            numbers.Add(50);
            numbers.Remove(4);
            numbers.Sort();
            numbers.Reverse();
            //numbers.Clear();
            */

            // forEach
            /*
    short[] nums = {5,6,7,8,9,2};

    foreach(short el in nums) {
        short element = Convert.ToInt16(el + 100);
        Console.WriteLine(element);
    }
*/

//                                   *** FUNCTIONS ***
/*
            int[] numbers = new int[]{1,5,6,8,6,8};
            Print(numbers);
            string name = Word("Alex", "Wolf");
            Console.WriteLine(name);


        public static void Print(int[] Arr)
        {
            int sum = 0;
            foreach(int el in Arr) {
            sum = sum + el;
             }
            Console.WriteLine(sum);
        }

        public static string Word ( string a, string b) {
              return a + " " + b;
        }
 */

 //                                  *** working with string ***
     /* string word = "Hello";
      word += "!!!";
      word  = String.Concat(word, "Bro!!!");

      // Compare two strings; 0 === true, 1 === false
      Console.WriteLine(String.Compare(word, "Hello!!!Bro!!!"));
      Console.WriteLine(word);
    //Console.WriteLine(word[4]);


      string people = "Anton,Ivan,Anna";
       // --------------------------------------- Split
      string[] names = people.Split(new char[]{','});
      foreach(string el in names) {
        Console.WriteLine(el);
      }
      people = String.Join(' ', people);
      Console.WriteLine(people);
      */

//                                  *** working with files ***

    // Console.WriteLine("Enter file name ...");
    // string fileName = Console.ReadLine() + ".txt";
    // Console.WriteLine("Enter text for file ...");
    // string text = Console.ReadLine();

    // Create new text file
    // using(FileStream stream = new FileStream($"{fileName}", FileMode.OpenOrCreate)) {
    //     byte[] array = System.Text.Encoding.Default.GetBytes(text);
    //     stream.Write(array, 0, array.Length);
    // } // Create file and writing text inside

    // Reading information from created files
    // using(FileStream stream1 = File.OpenRead(fileName)) {
    //     byte[] array = new byte[stream1.Length];
    //     stream1.Read(array, 0, array.Length);

    //     string textFromFile = System.Text.Encoding.Default.GetString(array);
    //     Console.WriteLine(textFromFile);
    // }

    //                     *** try / catch ***
    // try
    // {
    //     int num = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(num);
    // }
    // catch (FormatException)
    // {
    //     Console.WriteLine("Error: Incorrect format");
    // }
    // catch (DivideByZeroException)
    // {
    //     Console.WriteLine("Error: You entered 0");
    // }
    // finally {
    //     Console.WriteLine("Program is finished");
    // }

    //              *** Classes and Objects ***

        Robot bot = new Robot();
        // bot.name = "Vally";
        // bot.weight = 500;
        // bot.coodrinates = new byte[] {0,15,12};
        // Console.WriteLine(bot.name);
        bot.setValues("John", 650, new byte[] {12,15,5});
        bot.printValues();
        }

    }

}
