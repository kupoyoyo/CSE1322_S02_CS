using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linear Search
            int[] linearArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int search = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < linearArray.Length; i++)
            {
                if (linearArray[i] == search)
                {
                    Console.WriteLine(search + " found at array position " + i);
                    break;
                }   
            }

            //Binary Search
            int[] binaryArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int search2 = Int32.Parse(Console.ReadLine());
            int low = 0;
            int high = binaryArray.Length;
            int mid = 0;
            bool found = false;
            while (!found)
            {
                mid = (low + high) / 2;
                if (search2 == binaryArray[mid])
                {
                    found = true;
                    Console.WriteLine(search2 + " found at array position " + mid);
                }
                else if (search2 < binaryArray[mid])
                    high = mid;
                else
                    low = mid;
                if (low >= high - 1)
                    break;
            }

            //Bubble Sort
            int[] bubbleArray = new int[10] { 3, 6, 1, 2, 9, 7, 8, 5, 0, 4 };
            for (int i = 0; i < bubbleArray.Length; i++)
                for (int j = i+1; j< bubbleArray.Length; j++)
                    if (bubbleArray[j] < bubbleArray[i])
                    {
                        int temp = bubbleArray[j];
                        bubbleArray[j] = bubbleArray[i];
                        bubbleArray[i] = temp;
                    }
            for (int i = 0; i < bubbleArray.Length; i++)
                Console.Write(bubbleArray[i] + " ");

            Console.WriteLine("");

            //Selection Sort
            int[] selectionArray = new int[10] { 3, 6, 1, 2, 9, 7, 8, 5, 0, 4 };
            for (int i = 0; i < selectionArray.Length; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < selectionArray.Length; j++)
                    if (selectionArray[j] < selectionArray[minPos])
                        minPos = j;
                if (i != minPos && minPos < selectionArray.Length)
                {
                    int temp = selectionArray[minPos];
                    selectionArray[minPos] = selectionArray[i];
                    selectionArray[i] = temp;
                }
            }
            for (int i = 0; i < selectionArray.Length; i++)
                Console.Write(selectionArray[i] + " ");

            Console.WriteLine("");

            //Insertion Sort
            int[] insertionArray = new int[10] { 3, 6, 1, 2, 9, 7, 8, 5, 0, 4 };
            for (int i = 1; i < insertionArray.Length; i++)
            {
                int key = insertionArray[i];
                int position = i;
                //shift larger values to the right
                while (position > 0 && key < insertionArray[position - 1])
                {
                    insertionArray[position] = insertionArray[position - 1];
                    position--;
                }
                insertionArray[position] = key;
            }
            for (int i = 0; i < insertionArray.Length; i++)
                Console.Write(insertionArray[i] + " ");

            //Switch Statement
            int n = 1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
