using System;

namespace Datatypes
{
        class Program
        {
            static void Main(string[] args)
            {
                string myname = "Kevin";

                Console.WriteLine("My name is: " + myname);

                string message = "My name is:" + myname;

                Console.WriteLine(message);

                string capsMessage = message.ToUpper();
                Console.WriteLine(capsMessage);
            }
        }
}
