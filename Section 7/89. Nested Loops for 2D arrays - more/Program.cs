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

            System.Console.WriteLine();
            System.Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        System.Console.WriteLine(matrix[i,j]);
                    }
                    
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

                        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        System.Console.WriteLine(matrix[i,j]);
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                    
                }
            }
        }
    }
}