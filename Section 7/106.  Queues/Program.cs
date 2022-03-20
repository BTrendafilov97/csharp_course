using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysSection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            System.Console.WriteLine(queue.Peek());
            queue.Enqueue(2);
            System.Console.WriteLine(queue.Peek());
            queue.Enqueue(3);
            System.Console.WriteLine(queue.Peek());
            queue.Dequeue();
            System.Console.WriteLine(queue.Peek());

            while (queue.Count > 0 )
            {
                queue.Dequeue();
                System.Console.WriteLine(queue.Count);
            }

             
        }
        
    }
}