using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Testing_Area
{
    public class TestingProgram
    {
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

            int x = 5;
            while (x < 10)
            {
                x *= -2;
                Console.WriteLine(x);
            }
        }
    }
}
