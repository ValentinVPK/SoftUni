using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Ranking
{
    class User
    {
        public User(string name, string contestName, int points)
        {
            Name = name;
            ContestAndPoints = new Dictionary<string, int>();
            ContestAndPoints.Add(contestName, points);

        }
        public string Name { get; set; }
        public Dictionary<string, int> ContestAndPoints { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contestName = tokens[0];
                string contestPassword = tokens[1];

                if (contests.ContainsKey(contestName) == false)
                {
                    contests.Add(contestName, contestPassword);
                }
            }

            List<User> users = new List<User>();

            // Registering the users:
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = tokens[0];
                string contestPassword = tokens[1];
                string userName = tokens[2];
                int userPoints = int.Parse(tokens[3]);

                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName] == contestPassword)
                    {
                        bool doesUserExists = false;
                        foreach (User user in users)
                        {
                            if (user.Name == userName)
                            {
                                if (user.ContestAndPoints.ContainsKey(contestName))
                                {
                                    if (user.ContestAndPoints[contestName] < userPoints) user.ContestAndPoints[contestName] = userPoints;
                                }
                                else
                                {
                                    user.ContestAndPoints.Add(contestName, userPoints);
                                }
                                doesUserExists = true;
                                break;
                            }
                        }
                        if (doesUserExists == false)
                        {
                            users.Add(new User(userName, contestName, userPoints));
                        }
                    }
                }
            }
            int maxPoints = users.Max(p => p.ContestAndPoints.Sum(x => x.Value));
            string maxPointsUser = users.Find(u => u.ContestAndPoints.Sum(x => x.Value) == maxPoints).Name;
            Console.WriteLine($"Best candidate is {maxPointsUser} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (User user in users.OrderBy(u => u.Name))
            {
                Console.WriteLine(user.Name);
                foreach (var points in user.ContestAndPoints.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
