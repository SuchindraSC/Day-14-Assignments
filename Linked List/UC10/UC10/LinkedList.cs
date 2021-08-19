using System;
using System.Collections.Generic;
using System.Text;

namespace UC10
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
            Console.WriteLine("{0} is inserted into linkedlist", node.data);
        }

        public void sorting()
        {
            Node temp = head;

            //Node dummy;
            while (temp.next != null)
            {
                if (temp.data > temp.next.data)
                {
                    temp.data = (temp.data) + (temp.next.data);
                    temp.next.data = (temp.data) - (temp.next.data);
                    temp.data = (temp.data) - (temp.next.data);
                }
                temp = temp.next;

            }
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
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
