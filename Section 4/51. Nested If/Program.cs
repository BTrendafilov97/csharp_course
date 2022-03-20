using System;

namespace HelloDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistred = true;
            string username = Console.ReadLine();

            if (isRegistred)
            {
                Console.WriteLine("Hi there, registered user");
                if (username != "")
                {
                    Console.WriteLine("Hi there, " + username);
                    if (username.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
        }
    }
}