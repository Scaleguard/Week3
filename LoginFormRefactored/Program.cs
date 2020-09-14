using System;

namespace LoginFormRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            if(login == "Palpatine" && password == "Sith")
            {
                Console.WriteLine("Welcome, Chancolor");
            }
            else
            {
                Console.WriteLine("Login failed. You are not the senate");
            }



        }
    }
}
