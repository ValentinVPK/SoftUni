using System;
using System.Collections.Generic;
using System.Linq;

namespace DevetaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            string command = string.Empty;

            while((command = Console.ReadLine()) != "Lumpawaroo")
            {
              
                if (command.Contains("|"))
                {
                    string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (sides.ContainsKey(forceSide) == false)
                    {
                        sides.Add(forceSide, new List<string>());
                    }
                    if (sides[forceSide].Contains(forceUser) == false &&
                        sides.Values.Any(x => x.Contains(forceUser)) == false)
                    {
                        sides[forceSide].Add(forceUser);

                    }
                }
                else if(command.Contains("->"))
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];
                    
                    foreach(var side in sides)
                    {
                        for(int i = 0; i < side.Value.Count; i++)
                        {
                            if (side.Value[i] == forceUser)
                            { 
                                side.Value.RemoveAt(i);
                            }
                        }
                    }

                    
                    if (sides.ContainsKey(forceSide))
                    {
                        sides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        sides.Add(forceSide, new List<string>());
                        sides[forceSide].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            foreach(var side in sides.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
            {
                if(side.Value.Count == 0) continue;
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach(string user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
