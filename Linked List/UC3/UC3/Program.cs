using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}
