using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            string oop = "I like Object-Oriented Programming";
            Console.WriteLine(oop.Substring(7, 14));

            string s = "Object Orientation";
            s = s + s.Length();
        }
    }
}
