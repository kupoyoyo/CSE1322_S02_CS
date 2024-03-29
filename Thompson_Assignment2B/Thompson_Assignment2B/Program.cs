﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment2B
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("All Inclusive Vacation\nInput a budget: $");
            double bdgt = double.Parse(Console.ReadLine());
            Console.Write("Input a destination: ");
            string dest = Console.ReadLine();
            Console.Write("Input the destination hotel's brand name: ");
            string brnd = Console.ReadLine();
            Console.Write("Input the hotel rating: ");
            int rting = Int32.Parse(Console.ReadLine());
            Console.Write("Input vacation cost: $");
            double prce = double.Parse(Console.ReadLine());

            AllInclusiveVacation av1 = new AllInclusiveVacation(bdgt, dest, brnd, rting, prce);
            Console.WriteLine("\nBudget: $" + bdgt + "\nDestination: " + dest + "\nBrand: " + brnd + "\nRating: " + rting + "\nPrice: $" + prce + "\nCompare Budget: $" + av1.BudgetCheck());

            Console.Write("\nPiecemeal Vacation\nInput a budget: $");
            double bdgt1 = double.Parse(Console.ReadLine());
            Console.Write("Input a destination: ");
            string dest1 = Console.ReadLine();

            List<string> item = new List<string>();
            List<double> cost = new List<double>();
            Console.Write("How many vacation items are you getting? ");
            int count = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Item: ");
                item.Add(Console.ReadLine());
                Console.Write("Price: $");
                cost.Add(double.Parse(Console.ReadLine()));
            }

            PiecemealVacation pv1 = new PiecemealVacation(bdgt1, dest1, item, cost);
            Console.WriteLine("\nBudget: $" + bdgt1 + "\nDestination: " + dest1);
            var itemsAndCost = item.Zip(cost, (first, second) => first + ": $" + second); //combines each element of the two lists to display as a string like "Hotel: $500"
            foreach (var i in itemsAndCost)
                Console.WriteLine(i);
            Console.WriteLine("Compare Budget: $" + pv1.BudgetCheck());
        }
    }
}
