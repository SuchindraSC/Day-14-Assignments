using System;

namespace UC7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(70);
            list.Add(30);
            list.Add(56);
            int a=list.SearchNode(70);
            int b=list.SearchNode(30);
            int c=list.SearchNode(56);
            if (b == 0)
            {
                Console.WriteLine("element not found");
            }
            else
            {
                Console.WriteLine("The Position of 70 is "+a+", 30 is "+b+", & 56 is "+c);
            }
            list.Display();
        }
    }
}
