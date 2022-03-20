using System;

namespace ArraysSection
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2d array
            string[,] matrix;

            // declare 3d array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,] 
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            System.Console.WriteLine("Central value is: "+ array2D[2,0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"},
                    {"020","021"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"120", "121"}
                }
            };

            System.Console.WriteLine(array3D[0,2,1]);

        }
    }
}