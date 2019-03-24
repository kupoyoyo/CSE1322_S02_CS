using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Program3
{
    class SinglyLinkedList
    {
        private Node head;

        public class Node
        {
            public int id;
            public Node next;
            public Node(int id) { this.id = id; }
        }

        public SinglyLinkedList()
        {
            head = null;
        }

        public void append(int id)
        {
            Node current = head;
            Node temp = new Node(id);
            if (head == null)
            {
                head = temp;
                current = head;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = temp;
                current = current.next;
            }
        }

        public void prepend(int id)
        {
            Node temp = new Node(id);
            temp.next = head;
            head = temp;
        }

        public void removeFirstNode()
        {
            Node temp = head;


        }
    }
}
