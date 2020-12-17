using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> userAndHisPoints = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest].ContainsKey(username))
                    {
                        if (contests[contest][username] < points)
                        {
                            userAndHisPoints[username] = userAndHisPoints[username] - contests[contest][username] + points;
                            contests[contest][username] = points;
                        }
                    }
                    else
                    {
                        contests[contest].Add(username, points);
                        if (userAndHisPoints.ContainsKey(username))
                        {
                            userAndHisPoints[username] += points;
                        }
                        else
                        {
                            userAndHisPoints.Add(username, points);
                        }
                    }
                }
                else
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(username, points);
                    if (userAndHisPoints.ContainsKey(username))
                    {
                        userAndHisPoints[username] += points;
                    }
                    else
                    {
                        userAndHisPoints.Add(username, points);
                    }
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int index = 1;
                foreach (var user in contest.Value.OrderByDescending(p => p.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{index}. {user.Key} <::> {user.Value}");
                    index++;
                }
            }

            Console.WriteLine("Individual standings:");
            int order = 1;
            foreach (var user in userAndHisPoints.OrderByDescending(p => p.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{order}. {user.Key} -> {user.Value}");
                order++;
            }
        }
    }
}
