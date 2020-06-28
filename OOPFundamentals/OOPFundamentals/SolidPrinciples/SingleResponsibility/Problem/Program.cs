using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            Person user = new Person();

            Console.WriteLine("What's your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What's your last name: ");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrEmpty(user.FirstName))
            {
                Console.WriteLine("You didn't enter a valid first name!");
                Console.ReadKey();
                return;
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                Console.WriteLine("You didn't enter a valid last name!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            Console.ReadKey();
        }
    }
}