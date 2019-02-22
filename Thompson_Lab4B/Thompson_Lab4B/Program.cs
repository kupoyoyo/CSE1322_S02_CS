using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab4B
{
    class Program
    {
        public static bool Palindrome(string word)
        {
            if (word.Length <= 1)
                return true;
            else
            {
                if (word[0] != word[word.Length - 1])
                    return false;
                else
                    return Palindrome(word.Substring(1, word.Length - 2));
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string string1 = Console.ReadLine();
            bool check = Palindrome(string1);

            if (check == true)
                Console.WriteLine("The string is a palindrome.");
            else
                Console.WriteLine("The string is not a palindrom.");
        }
    }
}
