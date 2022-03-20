using System;

namespace InterfaceDemo
{
    class Program
    {


        static void Main(string[] args)
        {

        }



    }

    class Dog
    {
        public string Name { get; set; }

        public bool IsNaugtyDog { get; set; }

        public Dog(strin name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaugtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            System.Console.WriteLine("Dog ...." + numberOfTreats);
        }
        
    }
}