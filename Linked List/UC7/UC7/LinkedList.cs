using System;
using System.Collections.Generic;
using System.Text;

namespace UC7
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Is Inserted In The Linked List", node.data);
        }

        internal int SearchNode(int data)
        {
            int i = 1;
            Node temp = head;
            while (temp != null)
            {


                if (temp.data != data)
                {
                    temp = temp.next;
                    i++;
                }
                else
                {
                    Console.WriteLine("The Position Of The Added Value To Linked List is " + i);
                    return i;
                }
            }
            return 0;
        }

            internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
