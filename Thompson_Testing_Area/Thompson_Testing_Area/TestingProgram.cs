using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Testing_Area
{
    public class TestingProgram
    {
        public static void Test()
        {
            Console.WriteLine("The Test() was called...");
            TestClass.run();
        }

        public static void Main(string[] args)
        {
            /*
            string hello = "Hello class\nWelcome to CSE1322!";
            Console.WriteLine(hello);

            char ch = 'A';
            //char ch = 65; will not work in C#
            Console.WriteLine(ch);

            int x = 4; //Uses 4 bytes to store the number
            byte b = 127; //Uses 1 byte in memory to store number. Used for short numbers. (-128 to 127)
            short s = 3412; //Uses 2 bytes
            long l = 45345; //Uses 8 bytes. Only for very large numbers
            Console.WriteLine(x);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(l);

            double d = 23.50; //Uses 8 bytes
            float f = 45.50f; //Uses 4 bytes. Requires f after the number
            Console.WriteLine(d);
            Console.WriteLine(f);

            Console.WriteLine("Is d == f? " + (d == f)); //An equivalency test returning a boolean value

            bool bl = true;
            Console.WriteLine(!bl);
            */

            /*
            int number = 5;
            int count = 0;
            bool flag = false;
            int[,] grid = new int[,] { { 5, 7, 4, 7 }, { 5, 7, 7, 7 }, { 3, 1, 9, 0 } };
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                    if (grid[i,j] == number)
                    {
                        flag = true;
                        count += 1;
                    }
            }
            if (flag == true)
                Console.WriteLine("My number " + number + " is found " + count + " time(s)");
            else
                Console.WriteLine("My number " + number + " is NOT found");
            */

            
            TestClass v1 = new TestClass(); //Creates a new instance of the class testClass
            TestClass v2 = new TestClass();
            TestClass v3 = new TestClass();
            TestClass v4 = new TestClass();

            v1.Doors = 4;
            v2.Doors = 2;
            v3.Doors = 3;
            v1.Color = "Red";
            v2.Color = "White";

            TestClass.run();
            TestingProgram.Test();

            Console.WriteLine("v1.door = " + v1.Doors);
            


            
        }
    }
}
