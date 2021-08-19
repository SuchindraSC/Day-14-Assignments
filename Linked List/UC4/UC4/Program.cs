using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("\n\nLinked List After Insertion At Particular Position Is: ");
            list.Display();
        }
    }
}
