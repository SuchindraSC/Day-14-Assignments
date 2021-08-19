using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_UC4
{
    public class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;

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
        }

        internal void Dequeue()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue Is Empty");
                return;
            }
            Console.WriteLine("Dequeue Value : {0}", this.head.data);
            this.head = this.head.next;
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
