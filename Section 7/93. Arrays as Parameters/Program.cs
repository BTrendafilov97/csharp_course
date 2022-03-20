Using System;

namespace ArraysSection
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int[] studentGrades = new int[] { 15, 13, 8, 12, 6, 16 };
           double averageResult = GetAverage(studentGrades);
           System.Console.WriteLine(averageResult);

        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum/size;
            return average;
        }

    }
}