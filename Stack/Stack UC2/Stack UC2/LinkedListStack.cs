using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_UC2
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} Is Pushed To Stack",value);
        }
        internal void display()
        {
            Node temp = this.top;

            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.next;
            }
        }
        internal void peek()
        {
            if (top == null)
            {
                Console.WriteLine("stack Is Empty");
                return;
            }
            Console.WriteLine("{0} Is At The Top Of The Stack", this.top.data);
        }
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void isempty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
