using System;

namespace Datatypes
{
        class Program
        {
            static void Main(string[] args)
            {
                // Devlare Varialbe
                int num1;

                // assing value to variable
                num1 = 13;

                Console.WriteLine(num1);
                Console.Read();
                
                //initializing and assinging a value on the same line. 
                int num2 = 23;
                int sum = num1 + num2; 

                Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);


                // declare multiple variables at once
                int num3, num4, num5;



                double d1 = 3.1415;
                double d2 = 5.1;

                double dDiv = d1 / d2;
                Console.WriteLine(dDiv);

                float f1 = 3.1415f;
                float f2 = 5.1f;
                float fDiv = f1/f2;
                Console.WriteLine(fDiv);

                double dIDiv = d1 / num1;
                Console.WriteLine(dIDiv);
                
            }
        }
}
