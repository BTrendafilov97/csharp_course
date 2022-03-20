using System;

namespace HelloOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 3, num3;

            //unary operators;
            num3 = -num1;
            Console.WriteLine("Num3 is {0}", num3);

            
            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);


            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("Num is {0}", num);
            Console.WriteLine("Num is {0}", ++num);
            Console.WriteLine("Num is {0}", ++num);
            
            // decrement operator
            num--;
            Console.WriteLine("Num is {0}", num);
            Console.WriteLine("Num is {0}", --num);
            Console.WriteLine("Num is {0}", --num);


            int result;
            //Add/substract
            result = num1 + num2;
            result = num1 - num2;

            // Multiply
            result = num1 * num2;

            //Divide
            result = num1 / num2;

            //Modular operator, returns the remainder
            result  = num1 % num2;


            // Relational and type operators
            bool isLower;
            isLower = num1 < num2;

            bool isHigher;
            isHigher = num1 > num2;

            bool isEqual;
            // = assigns value, == compares value
            isEqual = num1 == num2;

            isEqual = num1 != num2;


            // conditional operators
            bool isLowerAndSunny;

            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result is {0}", isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Result is {0}", isLowerAndSunny);

        }
    }
}