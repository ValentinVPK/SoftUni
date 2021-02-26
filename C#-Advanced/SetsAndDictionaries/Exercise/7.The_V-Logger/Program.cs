using System;
using System.Collections.Generic;
using System.Linq;


namespace _7.The_V_Logger
{
    
    class Program
    {
        class VloggerStats
        {
            public int Following { get; set; }
            public HashSet<string> Followers { get; set; }

            public VloggerStats()
            {
                Followers = new HashSet<string>();
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, VloggerStats> vloggers = new Dictionary<string, VloggerStats>();

            string input;

            while((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string vloggerName = tokens[0];

                if(tokens[1] == "joined")
                {
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new VloggerStats());
                    }
                }
                else if(tokens[1] == "followed")
                {
                    string followedName = tokens[2];
                    if(vloggers.ContainsKey(vloggerName) == false || vloggers.ContainsKey(followedName) == false) continue;
                   
                    if (vloggerName == followedName) continue;

                    if (vloggers[followedName].Followers.Contains(vloggerName)) continue;

                    vloggers[followedName].Followers.Add(vloggerName);
                    vloggers[vloggerName].Following++;
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int index = 1;
            foreach(var vlogger in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following))
            {
                Console.WriteLine($"{index}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following} following");
                if(index == 1)
                {
                    foreach(string name in vlogger.Value.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {name}");
                    }
                }
                index++;
            }
             
        }
    }
}
