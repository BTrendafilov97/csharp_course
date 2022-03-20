using System;

namespace ArraysSection
{
    class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {6,7,8}
        };
        
        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                System.Console.Write(item + " ");

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.WriteLine(matrix[i,j]);
                }
            }
        }
    }
}