using System;
using System.Collections.Generic;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userManager = new UserManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nUser Management System");
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser(userManager);
                        break;
                    case "2":
                        LoginUser(userManager);
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void RegisterUser(UserManager userManager)
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            try
            {
                var result = userManager.Register(username, password);
                Console.WriteLine(result ? "Registration successful!" : "Username already exists!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Registration failed: {ex.Message}");
            }
        }

        static void LoginUser(UserManager userManager)
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            try
            {
                var result = userManager.Login(username, password);
                Console.WriteLine(result ? "Login successful!" : "Invalid username or password!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Login failed: {ex.Message}");
            }
        }
    }
}
