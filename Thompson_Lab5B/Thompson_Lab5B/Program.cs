using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab5B
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(); //Stack code begins

            Clothes c1 = new Clothes("Shirt", "Black", false);
            stack.push(c1);
            Clothes c2 = new Clothes("Pants", "Black", true);
            stack.push(c2);
            Clothes c3 = new Clothes("Shirt", "Blue", true);
            stack.push(c3);
            Clothes c4 = new Clothes("Jacket", "Pink", false);
            stack.push(c4);
            Clothes c5 = new Clothes("Pants", "Blue", true);
            stack.push(c5);
            Clothes c6 = new Clothes("Shirt", "White", true);
            stack.push(c6);
            Clothes c7 = new Clothes("Skirt", "Black", false);
            stack.push(c7);
            Clothes c8 = new Clothes("Hat", "Red", true);
            stack.push(c8);
            Clothes c9 = new Clothes("Shirt", "Black", true);
            stack.push(c9);
            Clothes c10 = new Clothes("Jacket", "Green", false);
            stack.push(c10);

            Console.WriteLine("The clothes with the color black in the stack are:");
            foreach (Clothes clothes in stack.returnColor("Black"))
                Console.WriteLine(clothes);

            Console.WriteLine("\nThe number of clothes that can be washed at high temp: " + stack.highTempOnly());

            Console.WriteLine("\nPop: " + stack.pop());
            Console.WriteLine("Peek: " + stack.peek()); //Stack code ends


            MyQueue queue = new MyQueue(); //Queue code begins

            Food f1 = new Food("Burger", 700, 2);
            queue.enqueue(f1);
            Food f2 = new Food("Ham", 300, 4);
            queue.enqueue(f2);
            Food f3 = new Food("Salad", 200, 2);
            queue.enqueue(f3);
            Food f4 = new Food("Corn", 100, 1);
            queue.enqueue(f4);
            Food f5 = new Food("Pie", 300, 6);
            queue.enqueue(f5);
            Food f6 = new Food("Steak", 800, 5);
            queue.enqueue(f6);
            Food f7 = new Food("Fish", 300, 2);
            queue.enqueue(f7);
            Food f8 = new Food("Rice", 100, 5);
            queue.enqueue(f8);
            Food f9 = new Food("Ice Cream", 400, 2);
            queue.enqueue(f9);
            Food f10 = new Food("Ramen", 200, 1);
            queue.enqueue(f10);

            Console.WriteLine("\nAverage Calories per serving in queue: " + queue.averageCal());

            Console.WriteLine("\nThe food item with the highest total calories is:\n" + queue.mostCalories());

            Console.WriteLine("\nPeek: " + queue.peek());
            queue.dequeue();
            Console.WriteLine("Dequeue");
            Console.WriteLine("Peek: " + queue.peek());
        }
    }
}
