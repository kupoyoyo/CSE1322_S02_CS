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
            do
            {
                Console.Write("First Name: ");
                

                Console.Write("Continue inputting students? y/n ");
                run = Console.ReadLine();
            } while (run == "y");
        }
    }
}
