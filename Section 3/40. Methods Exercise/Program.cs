using System;

namespace HelloMethods
{
    class Program
    {
        static string friend1 = "Mark",friend2 = "Joel", friend3 = "Tim";
        
        static void Main(string[] args)
        {
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }
    }
}