using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            Console.WriteLine("Please enter your name and press enter");
            myString = Console.ReadLine();

            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Trim());
            Console.WriteLine(myString.Substring(5));         
        }
    }
}