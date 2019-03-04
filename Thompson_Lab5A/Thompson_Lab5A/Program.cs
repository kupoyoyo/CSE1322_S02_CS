using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Thompson_Lab5A
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            Console.Write("How many integers would you like to add to the list? (1 to 10 entries): ");
            int entries = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= entries; i++)
            {
                Console.Write("Entry " + i + ": ");
                myArrayList.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nSum: " + arrayListSum(myArrayList));


            LinkedList<int> myLinkedList = new LinkedList<int>();

            Console.Write("\nHow many integers would you like to add to the list? (1 to 10 entries): ");
            int entries2 = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= entries2; i++)
            {
                Console.Write("Entry " + i + ": ");
                myLinkedList.AddLast(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nSum: " + linkedListSum(myLinkedList));

        }

        static int arrayListSum (ArrayList arrayL)
        {
            int sum = 0;

            Console.Write("\nEntries in ArrayList: ");

            foreach(int num in arrayL)
            {
                Console.Write(num + " ");
                sum += num;
            }
            return sum;
        }

        static int linkedListSum (LinkedList<int> linkedL)
        {
            int sum = 0;

            Console.Write("\nEntries in LinkedList: ");

            foreach (int num in linkedL)
            {
                Console.Write(num + " ");
                sum += num;
            }

            return sum;
        }
    }
}
