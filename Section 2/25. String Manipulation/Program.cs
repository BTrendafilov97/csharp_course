using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            string name = "Kevin";
            string job = "monkey";

            // String Concatinaion
            Console.WriteLine("String Concatinaion");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            // String Formatting
            Console.WriteLine("String Fromatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old and I am a {2}", name, age, job);

            // String Interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old and I am a {job}");

            // Verbatim String
            // Using "@" tells the complier to ignore any spaces or special characters
            Console.WriteLine("Verbatim String");
            Console.WriteLine(@"Hello my name is {name}, I am {age} years old and I am a {job}");
        }
    }
}