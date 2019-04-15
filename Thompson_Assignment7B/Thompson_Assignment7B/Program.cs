using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Thompson_Assignment7B
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 10000;
            int[] normalArray = new int[10000];
            int[] parallelArray = new int[10000];

            Random randNum = new Random();
            for(int i = 0; i < normalArray.Length; i++)
            {
                normalArray[i] = randNum.Next(min, max);
                parallelArray[i] = normalArray[i];
            }

            int temp;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int j = 0; j <= normalArray.Length - 2; j++)
            {
                for (int i = 0; i <= normalArray.Length - 2; i++)
                {
                    if (normalArray[i] > normalArray[i+1])
                    {
                        temp = normalArray[i+1];
                        normalArray[i+1] = normalArray[i];
                        normalArray[i] = temp;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time for normal bubble sort: " + stopwatch.ElapsedMilliseconds + "ms");

            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Parallel.For(0, parallelArray.Length - 2, j =>
            {
                Parallel.For(0, parallelArray.Length - 2, i =>
                {
                    if (parallelArray[i] > parallelArray[i + 1])
                    {
                        temp = parallelArray[i + 1];
                        parallelArray[i + 1] = parallelArray[i];
                        parallelArray[i] = temp;
                    }
                });
            });
            stopwatch2.Stop();
            Console.WriteLine("Elapsed time for parallel processed bubble sort: " + stopwatch2.ElapsedMilliseconds + "ms");
        }
    }
}
