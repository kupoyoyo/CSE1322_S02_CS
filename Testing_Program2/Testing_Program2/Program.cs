using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Program2
{
    class Program
    {
        public static void PrintNumbers(int n)
        {
            if (n > 0)
            {
                Console.Write(n + " ");
                PrintNumbers(n - 1);
                Console.Write(n + " ");
            }
        }

        static void Main(string[] args)
        {
            int num = 10;
            PrintNumbers(num);
        }
    }
}