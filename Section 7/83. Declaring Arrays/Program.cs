using System;

namespace ArraysSection
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing an array
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 30;
            grades[3] = 40;
            grades[4] = 7;


            System.Console.WriteLine("grades at 0: {0}", grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            System.Console.WriteLine("grades at 0: {0}", grades[0]);

            // another way to initialize an array
            int[] gradesOfMathStudentsA = { 20, 13, 13, 8, 8 };

            // another way to initialize an array
            int[] gradesOfMathStudentsB = new int[] {15, 20, 3, 17, 18, 15 };

            System.Console.WriteLine(gradesOfMathStudentsA.Length);
        }
    }
}