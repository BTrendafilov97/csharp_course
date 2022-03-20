using System;

namespace Classes_basics
{
    // this class is a blueprint
    class Human
    {
        // member variable
        private string firstName,lastName,eyeColour;
        private int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;     
        }

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi I'm {0} {1}", firstName, lastName);
        }

    }
}