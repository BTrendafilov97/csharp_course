using System;

namespace ArraysSection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ParamsMethod("this", "is", "a", "long","tesT");
            ParamsMethod2(2, "5", 3.555 );

        }
        
        public static void ParamsMethod(params string[] sentance)
        {
            for (int i = 0; i < sentance.Length; i++)
            {
                Console.WriteLine(sentance[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                System.Console.WriteLine(obj + " ");
            }
        }
    }
}