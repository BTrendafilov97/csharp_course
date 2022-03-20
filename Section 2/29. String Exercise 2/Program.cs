using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string userString = Console.ReadLine();
            
            Console.WriteLine("Enter the character you want to search: ");
            char userChar = Console.ReadLine()[0];
            
            Console.WriteLine(userString.IndexOf(userChar));


            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is: {0}", firstName + lastName);
        }
    }
}