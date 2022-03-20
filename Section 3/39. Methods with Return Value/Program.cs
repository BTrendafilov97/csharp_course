using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine(Add(1,1231));
            Console.WriteLine(Multiply(11231,1231));
            Console.WriteLine(Divide(11231,1231));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1*num2;
        }

        public static double Divide(double num1,double num2)
        {
            return num1/num2;
        }
    }
}