using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment5B
{
    class LinkedList
    {
        private Node head;
        
        class Node
        {
            public string birbName;
            public int numBirbs = 0;
            public Node next;

            public Node() { }
        }

        public LinkedList()
        {
            head = null;
        }

        public void add (string birb)
        {
            Node current = head;
            Node temp = new Node();
            temp.birbName = birb;

            if (head == null)
            {

                head = temp;
                head.numBirbs = 1;
                current = head;
            }
            else
            {
                if (getCount(temp.birbName) == 0)
                {
                    temp.numBirbs = 1;
                    while (current.next != null)
                        current = current.next;
                    current.next = temp;
                    current = current.next;
                }
                else
                {
                    while (current.birbName != temp.birbName)
                    {
                        current = current.next;
                    }
                    current.numBirbs += 1;

                }
            }
            Console.WriteLine("Added '" + current.birbName + "' there is now " + current.numBirbs + " of them");
        }

        public int getCount(string birb)
        {
            Node current = head;
            while (current.birbName != birb && current.next != null)
                current = current.next;

            if (current.birbName == birb)
                return current.numBirbs;
            else
                return 0;
        }

        public void getReport()
        {
            Node current = head;
            Console.WriteLine("\n***Final Report***");
            while(current != null)
            {
                Console.WriteLine("Species: " + current.birbName + ", Count: " + current.numBirbs);
                current = current.next;
            }
        }
    }
}
