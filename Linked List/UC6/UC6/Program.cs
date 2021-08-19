using System;

namespace UC6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.RemoveLastNode();
            list.Display();
        }
    }
}
