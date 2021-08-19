using System;

namespace UC10
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(40);
            list.Add(56);
            list.sorting();
            list.Display();
        }
    }
}
