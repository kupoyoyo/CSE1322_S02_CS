using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Thompson_Assignment1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will compute the test score average and grade for each student");
            Tests[] testArray = new Tests[10];
            int count = 0;
            while (count != testArray.Length)
            {
                Console.Write("First Name: ");
                string FirstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter each test score: ");
                float[] Test = new float[5];
                for (int i = 0; i < Test.Length; i++)
                {
                    Test[i] = float.Parse(Console.ReadLine());
                }

                testArray[count] = new Tests(FirstName, LastName, Test);
                testArray[count].ComputeAverage();
                testArray[count].GetGrade();

                count++;
            }

            float classTotal = 0f;
            Console.WriteLine("First Name\tLast Name\tTest1\tTest2\tTest3\tTest4\tTest5\tAverage\tGrade");

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
                classTotal += testArray[i].TestAvg;
            }
            float classAverage = classTotal / testArray.Length;
            Console.WriteLine("\nClass Average = " + classAverage.ToString("F", CultureInfo.InvariantCulture));
        }
    }
}
