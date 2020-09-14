using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: admin
             * password: pass1234
             * create a program that asks user's login credentials
             * Check if the user entered the correct login and password
             * If the login and password are correct, display "Welcome"
             * If the login or password are incorrect, display "try again"
             
             */
            string login;
            string password;
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            if ((login == "admin") && (password == "pass1234"))
            {
                Console.WriteLine("Welcome");
            }
            else if ((login == "admin") && (password != "pass1234"))
            {
                Console.WriteLine("Your password is incorrect");
            }
            else if ((login != "admin") && (password == "pass1234"))
            {
                Console.WriteLine("Jedi scum");
            }
            else
            {
                Console.WriteLine("So it's treason then?");
            }
             

            



        }
    }
}
