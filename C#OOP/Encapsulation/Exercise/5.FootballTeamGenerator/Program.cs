using System;
using System.Collections.Generic;

namespace _5.FootballTeamGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Team> teamsByName = new Dictionary<string, Team>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(';');

                string teamName = tokens[1];
                string command = tokens[0];

                if (!teamsByName.ContainsKey(teamName) && command != "Team")
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }

                try
                {
                    if (command == "Team")
                    {
                        teamsByName.Add(teamName, new Team(teamName));
                    }
                    else if (command == "Add")
                    {
                        teamsByName[teamName].AddPlayer(new Player(tokens[2], new Stats(int.Parse(tokens[3]),
                           int.Parse(tokens[4]),
                           int.Parse(tokens[5]),
                           int.Parse(tokens[6]),
                           int.Parse(tokens[7]))));
                    }
                    else if (command == "Remove")
                    {
                        string playerName = tokens[2];
                        teamsByName[teamName].RemovePlayer(playerName);
                    }
                    else if (command == "Rating")
                    {
                        Console.WriteLine(teamsByName[teamName]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
