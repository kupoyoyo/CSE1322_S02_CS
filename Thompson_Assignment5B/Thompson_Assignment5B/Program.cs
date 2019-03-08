using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment5B
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList BirdSurvey = new LinkedList();
            Console.WriteLine("Please enter bird names. Enter 'done' when finished.");
            string birdName = "";

            do
            {
                Console.Write("Bird name: ");
                birdName = Console.ReadLine();

                if (birdName == "")
                    Console.WriteLine("Bird name cannot be blank. Please enter a valid bird name.");
                else if (birdName != "done")
                {
                    BirdSurvey.add(birdName);
                }
            } while (birdName != "done");

            Console.WriteLine("\nPlease enter a bird name that you would like to search. Enter 'done' when finished.");
            string birbSearch = "";
            do
            {
                Console.Write("Bird name: ");
                birbSearch = Console.ReadLine();

                if (birdName == "")
                    Console.WriteLine("Bird name cannot be blank. Please enter a valid bird name.");
                else if (birbSearch != "done")
                {
                    Console.WriteLine("Counted " + BirdSurvey.getCount(birbSearch) + " " + birbSearch + "(s)");
                }
            } while (birbSearch != "done");

            BirdSurvey.getReport();
        }
    }
}
