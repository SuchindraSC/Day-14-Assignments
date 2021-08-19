using System;

namespace Stack_UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack Stack = new LinkedListStack();
            Stack.push(70);
            Stack.push(30);
            Stack.push(56);
            Stack.display();
            Console.WriteLine("\n");
            Stack.peek();
            Stack.pop();
            Stack.isempty();
        }
    }
}
