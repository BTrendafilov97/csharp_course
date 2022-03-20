using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("This is the second method");
        }

        // access modifier -> public
        // modifier -> static
        // return type -> void
        // name -> WriteSomething
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from the method");
            Console.Read();
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
    }
}