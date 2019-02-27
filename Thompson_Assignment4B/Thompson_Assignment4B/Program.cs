using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment4B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in decimal: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a base (between 2 and 36): ");
            int baseNumber = Int32.Parse(Console.ReadLine());

            string result = convertToBase(number, baseNumber);
            Console.WriteLine(number + " converted to base " + baseNumber + " is: " + result);
        }

        static string convertToBase (int num, int baseNum)
        {
            char [] digits = new char[36] {'0','1','2','3','4','5','6','7','8','9',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','Q','X','Y','Z'};

            if (num == 0)
                return "";
            else
                return convertToBase(num / baseNum, baseNum) + (digits[num % baseNum]);
        }
    }
}
