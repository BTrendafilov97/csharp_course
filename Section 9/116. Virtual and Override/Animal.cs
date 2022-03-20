using System;

namespace VirtualOverrideDemo
{
    class Animal
    {
        public string Name{ get; set; }
        public int Age{ get; set; }
        public bool IsHungry{ get; set;}
        

        public Animal(string name, int age)
        {
            age = Age; 
            name = Name;
            IsHungry = true;
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                System.Console.WriteLine($"{Name} is eating");
            }
            else
            {
                System.Console.WriteLine($"{Name} is not hungry");
            }
        }
        public virtual void MakeSound()
        {

        }

        public virtual void Play()
        {
            System.Console.WriteLine($"{Name} is playing");
        }

    }
}