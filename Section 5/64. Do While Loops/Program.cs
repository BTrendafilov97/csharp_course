using System;

namespace HelloDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int lenthoftext = 0;


            do
            {
                Console.WriteLine("Please enter the name of a friend.");
                string nameOfFriend = Console.ReadLine();
                lenthoftext = nameOfFriend.Length;

            } while ( lenthoftext < 20 );
            Console.WriteLine("Thanks");
        }
    }
}