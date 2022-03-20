using System;

namespace HelloDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What tempretaure is it outside?");
            int temperature = int.Parse(Console.ReadLine());



            if (temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }else if (temperature == 10)
            {
                Console.WriteLine("Is 10 degrees C");
            }else
            {
                Console.WriteLine("Cozy and warm");
            }
        }
    }
}