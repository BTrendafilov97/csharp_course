using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog  = new Dog("Mark", 5);
            System.Console.WriteLine($"{dog.Name} is {dog.Age}");
            dog.Play();
            dog.Eat();
        }
    }
}