using System;

namespace HelloDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0,score = 0,counter = 0;


            while (score != -1)
            {
                score = int.Parse(Console.ReadLine());
                if (score < 0 || score > 20)
                {
                    Console.WriteLine("Wrong number entered or -1 entered, please enter numbers between 0 and 20!");
                }
                else
                {
                    totalScore = totalScore + score;
                    counter++;
                }
            }
            Console.WriteLine("Student average score is: " + totalScore/counter);

        }
    }
}