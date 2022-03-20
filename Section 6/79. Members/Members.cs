using System;

namespace MemversC
{
    class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;
        // member public fields
        public int age;

        // member property - exposes jobTitle safely - properties start with a capital letter.
        public string JobTitle 
        { 
            get
            {
                return jobTitle;
            } 
            set
            {
                jobTitle = value;
            }
        }

        // public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0} and my job is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }



        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Stan";
            salary = 60000;
            JobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            Console.WriteLine("Deconstruction of Members object");
        }
    }
}