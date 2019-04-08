using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab7A
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 10;
            int sumParallel = 0;

            int[] array = new int[100000];

            Random randNum = new Random();

            Parallel.ForEach(array, i =>
            {
                array[i] = randNum.Next(min, max);
                sumParallel += array[i];
            }
            );

            Console.WriteLine("Sum via multithreading: " + sumParallel);
        }
    }
}
