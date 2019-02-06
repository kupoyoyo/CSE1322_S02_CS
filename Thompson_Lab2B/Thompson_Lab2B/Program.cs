using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side length: ");
            double side = double.Parse(Console.ReadLine());

            Octagon o1 = new Octagon(side);
            Console.WriteLine("\nOctagon\nSide Length: " + side + "\nArea: " + o1.Area().ToString("F", CultureInfo.InvariantCulture) + "\nPerimeter: " + o1.Perimeter().ToString("F", CultureInfo.InvariantCulture));

            Octagon o2 = o1.Clone() as Octagon;
            Console.WriteLine("\nOctagon Clone\nSide Length: " + side + "\nArea: " + o2.Area().ToString("F", CultureInfo.InvariantCulture) + "\nPerimeter: " + o2.Perimeter().ToString("F", CultureInfo.InvariantCulture));

            if (o1.CompareTo(o2) == 0)
                Console.WriteLine("\nThe octagons are the same");
            else
                Console.WriteLine("\nThe octagons are different");
        }
    }
}