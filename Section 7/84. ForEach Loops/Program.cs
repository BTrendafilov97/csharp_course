using System;

namespace ArraysSection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }
            
            foreach (int k in nums)
            {
                System.Console.WriteLine(nums[k]);
            }

        }
    }
}