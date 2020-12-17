using System;
using System.Collections.Generic;
using System.Linq;

namespace PetaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for(int i = 1; i <= numberOfCommands; i++)
            {
                string[] newRegistry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string method = newRegistry[0];
                string username = newRegistry[1];

                if(method == "register")
                {
                    string licensePlate = newRegistry[2];
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                        users.Add(username, licensePlate);
                    }
                }
                else if(method == "unregister")
                {
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                }
            }

            foreach(var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
