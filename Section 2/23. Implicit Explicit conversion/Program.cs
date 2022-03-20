using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;


            // Cast double to int - explicit
            myInt = (int)myDouble;

            Console.WriteLine(myInt);        
            

            //Implicit conversion
            int num = 123905231;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            //typeConversion
            string myString = myDouble.ToString();

            Console.WriteLine(myString);

            string myFloatString = myFloat.ToString();

            Console.WriteLine(myFloatString);
            
            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);

            
        }
    }
}