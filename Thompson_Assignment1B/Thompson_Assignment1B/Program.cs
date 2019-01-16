using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will compute the test score average and grade for each student");

            string run = "y";
            //int count = 1;
            do
            {
                Console.Write("First Name: ");
                string frstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lstName = Console.ReadLine();

                Console.Write("Enter each test score: ");
                float[] tsts = new float[5];
                for (int i = 0; i < tsts.Length; i++)
                {
                    tsts[i] = float.Parse(Console.ReadLine());
                }

                Tests s1 = new Tests(frstName, lstName, tsts);
                //count++;
                Console.Write("Continue inputting students? (y/n) ");
                run = Console.ReadLine();
            } while (run == "y");
        }
    }
}
