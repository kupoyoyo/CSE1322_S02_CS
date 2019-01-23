using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Logan Thompson
//CSE 1322L
//C# Lab 1B

namespace Thompson_Lab1B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 4, 13, 43, -25, 17, 22, -37, 29 };

            int largestSum = FindLargest(nums);

            int[] data = new int[20];
            var rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(-100, 100);
            }

            largestSum += FindLargest(data);

            Console.WriteLine("The sum of the largest values from each array is: " + largestSum);
            Console.WriteLine("Array nums:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("Array data:");
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            int count = 0;
            int countLongest = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] > 0)
                {
                    count++;
                    if (count > countLongest)
                        countLongest = count;
                }
                else
                    count = 0;
            }

            Console.WriteLine("The length of the longest continuous series of positive numbers is: " + countLongest);
        }

        static int FindLargest (int [] array)
        {
            int largest = -99999999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                    largest = array[i];
            }
            if (largest != -99999999)
                Console.WriteLine("The largest number in the array is: " + largest);
            else
                Console.WriteLine("ERROR, NO VALID INPUT");
            return largest;
        }
    }
}
