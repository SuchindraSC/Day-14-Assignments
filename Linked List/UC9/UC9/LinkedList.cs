using System;
using System.Collections.Generic;
using System.Text;

namespace UC9
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

        public void delete(int data)
        {
            var newNode = new Node(data);

            Node temp = head;
            Node front = temp.next;
            while (temp != null)
            {
                if (front.data == data)
                {
                    temp.next = front.next; ;
                }
                temp = temp.next;
                front = front.next;


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
