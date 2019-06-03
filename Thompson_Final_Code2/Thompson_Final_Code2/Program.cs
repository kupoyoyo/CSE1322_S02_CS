using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Final_Code2
{
    class Program
    {
        static string printNumbers (int n)
        {
            if (n <= 0)
            {
                return "";
            }
            else
            {
                return printNumbers(n-1) + " " + (n*n);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(printNumbers(10));
        }
    }
}
