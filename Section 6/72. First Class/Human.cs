using System;

namespace Classes_basics
{
    // this class is a blueprint
    class Human
    {
        // member variable
        public string firstName;

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi I'm {0}", firstName);
        }

    }
}