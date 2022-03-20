using System;

namespace HelloTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, please enter the correct type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number was too long, please enter a smaller number");
            }
            finally
            {
                 Console.WriteLine("This is the end of the program, called always");
            }

            int num1 = 45, num2 = 0;
            try
            {
                int result=num1/num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant devide by zero");
            }
        }
    }
}