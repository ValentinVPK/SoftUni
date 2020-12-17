using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> followers = new Dictionary<string, int>();

            string input;

            while((input = Console.ReadLine()) != "Log out")
            {
                string[] tokens = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string username = tokens[1];

                switch (command)
                {
                    case "New follower":
                        if(!followers.ContainsKey(username)) followers.Add(username, 0);
                        break;
                    case "Like":
                        int amount = int.Parse(tokens[2]);
                        if (followers.ContainsKey(username)) followers[username] += amount;
                        else followers.Add(username, amount);                      
                        break;
                    case "Comment":
                        if (followers.ContainsKey(username)) followers[username] += 1;
                        else followers.Add(username, 1);
                        break;
                    case "Blocked":
                        if (followers.ContainsKey(username)) followers.Remove(username);
                        else Console.WriteLine($"{username} doesn't exist.");
                        break;
                }
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach(var follower in followers.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}
