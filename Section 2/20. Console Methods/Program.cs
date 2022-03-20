using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //change text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("Test on a new line");

            Console.Write("Text on the same line");

            // waits for us to press a key before moving on.
            Console.ReadKey();

            
        }
    }
}