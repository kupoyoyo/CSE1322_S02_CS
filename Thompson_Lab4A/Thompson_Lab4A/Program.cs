using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab4A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string strng = Console.ReadLine();
            Console.WriteLine("Vowels: " + vowels(strng, strng.Length));
        }

        static int vowels (string str, int n)
        {
            if (n == 1)
                return vowelCheck(str[n - 1]);
            return vowels(str, n - 1) + vowelCheck(str[n - 1]);
        }

        static int vowelCheck (char ch)
        {
            ch = char.ToUpper(ch);
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                return 1;
            else
                return 0;
        }
    }
}
