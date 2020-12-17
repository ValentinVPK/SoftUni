using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = command.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string hatColor = tokens[1];
                int physics = int.Parse(tokens[2]);

                string ID = name + ":" + hatColor;

                if (dwarfs.ContainsKey(ID) == false)
                {
                    dwarfs.Add(ID, physics);
                }
                else
                {
                    dwarfs[ID] = Math.Max(dwarfs[ID], physics);
                }
            }

            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1]).Count()))
            {
                Console.WriteLine($"({dwarf.Key.Split(':')[1]}) {dwarf.Key.Split(':')[0]} <-> {dwarf.Value}");
            }
        }
    }
}
