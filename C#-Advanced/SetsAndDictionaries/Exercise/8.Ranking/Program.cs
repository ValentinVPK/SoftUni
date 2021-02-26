using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsAndPasswords = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (!contestsAndPasswords.ContainsKey(tokens[0]))
                {
                    contestsAndPasswords.Add(tokens[0], tokens[1]);
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];
                string password = tokens[1];
                string userName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contestsAndPasswords.ContainsKey(contest)) continue;

                if (contestsAndPasswords[contest] != password) continue;

                if (!users.ContainsKey(userName)) users.Add(userName, new Dictionary<string, int>());

                if (users[userName].ContainsKey(contest))
                {
                    if (points > users[userName][contest]) users[userName][contest] = points;
                }
                else
                {
                    users[userName].Add(contest, points);
                }
            }

            int maxPoints = users.Max(x => x.Value.Values.Sum());
            string maxKey = users.FirstOrDefault(x => x.Value.Values.Sum() == maxPoints).Key;

            Console.WriteLine($"Best candidate is {maxKey} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach(var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach(var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
