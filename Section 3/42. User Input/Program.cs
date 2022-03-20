using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number you want:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number you want:");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: " + Add(num1, num2));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}