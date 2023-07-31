using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Assignement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            string username, password;
            bool loggedIn = false;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();

                Console.Write("Enter password: ");
                password = Console.ReadLine();

                if (username == "john" && password == "pass123")
                {
                    Console.WriteLine("Login successful");
                    loggedIn = true;
                    break;
                }
                else if (username == "john")
                {
                    Console.WriteLine("Invalid password");

                }
                else
                {
                    Console.WriteLine("Invalid username");
                }

                attempts++;
            }

            if (!loggedIn)
            {
                Console.WriteLine("Login failed");
            }
            Console.ReadKey();
        }
    }
}
