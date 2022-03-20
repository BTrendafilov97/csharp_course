using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysSection
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            System.Console.WriteLine(stack.Peek());
            stack.Push(11);
            System.Console.WriteLine(stack.Peek());
            stack.Push(111);
            System.Console.WriteLine(stack.Peek());

            while (stack.Count > 0 )
            {
                stack.Pop();
            }

            System.Console.WriteLine(stack.Peek());
        }
        
    }
}