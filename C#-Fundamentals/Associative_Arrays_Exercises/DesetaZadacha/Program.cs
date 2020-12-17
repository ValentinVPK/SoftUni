using System;
using System.Collections.Generic;
using System.Linq;

namespace DesetaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userAndPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageAndSubmisions = new Dictionary<string, int>();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[1] == "banned")
                {
                    userAndPoints.Remove(tokens[0]);
                    continue;
                }

                string user = tokens[0];
                string language = tokens[1];
                int points = int.Parse(tokens[2]);

                // add the submissions for the language 

                if (languageAndSubmisions.ContainsKey(language)) languageAndSubmisions[language]++;
                else languageAndSubmisions.Add(language, 1);

                // add the user and his points to the dictionary

                if (userAndPoints.ContainsKey(user))
                {
                    if (points > userAndPoints[user]) userAndPoints[user] = points;
                }
                else userAndPoints.Add(user, points);
    
            }

            Console.WriteLine("Results:");
            foreach(var user in userAndPoints.OrderByDescending(p => p.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in languageAndSubmisions.OrderByDescending(s => s.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
