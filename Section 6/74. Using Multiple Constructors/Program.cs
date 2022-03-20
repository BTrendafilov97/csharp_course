using System;

namespace Classes_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of human
            Human denis = new Human("Denis","Petrov","Blue",25);
            denis.IntroduceMyself();
            Human michael = new Human("Michael","Ivanov","Brown",16);
            michael.IntroduceMyself();
        }
    }
}