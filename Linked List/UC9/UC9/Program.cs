using System;

namespace UC9
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
            list.Display();
            Console.WriteLine("\n");
            list.delete(30);
            list.Display();
        }
    }
}
