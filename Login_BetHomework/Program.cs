
using System;
using System.Collections.Generic;

namespace Login_BetHomework
{
    class Program
    {
        private static Dictionary<string, User> AllUsers = new Dictionary<string, User>();
        static void Main(string[] args)
        {
            AllUsers.Add("jack", new User("jack", "brown", "jack", "jack123"));
            AllUsers.Add("willsmith", new User("will", "smith", "willsmith", "smith321"));

            int input;
            do
            {
                Console.WriteLine("\nChoose one of the following:");
                Console.WriteLine("1: Registration: Create a new Username and Password");
                Console.WriteLine("2: Login");
                Console.WriteLine("3: Exit\n");

                input = Convert.ToInt32(Console.ReadLine());

                string username, pass, name, surname;
                switch (input)
                {
                    case 1:

                        Console.WriteLine("Enter a new Username");
                        username = Console.ReadLine();

                        while (AllUsers.ContainsKey(username))
                        {
                            Console.WriteLine("Username already exists. Enter a different Username");
                            username = Console.ReadLine();
                        }

                        Console.WriteLine("Enter a new Password");
                        pass = Console.ReadLine();

                        Console.WriteLine("Enter your name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter your surname");
                        surname = Console.ReadLine();

                        AllUsers.Add(username, new User(name, surname, username, pass));
                        break;
                    case 2:
                        Console.WriteLine("Enter your Username");
                        username = Console.ReadLine();

                        Console.WriteLine("Enter your Password");
                        pass = Console.ReadLine();

                        if (AllUsers.ContainsKey(username) && AllUsers[username].Password == pass)
                        {
                            Console.WriteLine($"Welocme, {AllUsers[username].Name} {AllUsers[username].Surname}. Congratulations, you are now logged in!");
                        }
                        else
                        {
                            Console.WriteLine("Login failed!");
                        }
                        break;
                }
            } while (input != 3);
        }
    }

}
