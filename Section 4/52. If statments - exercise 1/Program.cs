using System;

namespace HelloDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string usernameRegister, passwordRegister, usernameLogin, passwordLogin;

            Console.WriteLine("Enter the username you want to register with: ");
            usernameRegister = Console.ReadLine();

            Console.WriteLine("Enter the password you want to register with: ");
            passwordRegister = Console.ReadLine();

            Console.WriteLine("You have registered your account");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("To login, enter your username: ");
            usernameLogin = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            passwordLogin = Console.ReadLine();

            if (usernameLogin.Equals(usernameRegister) && passwordLogin.Equals(passwordRegister))
            {
                Console.WriteLine("You have logged in successfuly");
            }
            else
            {
                Console.WriteLine("Login failed.");
            }

            

        }
    }
}