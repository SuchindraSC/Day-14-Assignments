﻿using System;

namespace Queue_UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue Queue = new LinkedListQueue();

            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();
        }
    }
}
