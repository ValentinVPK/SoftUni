using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Dragon_Army
{
    class DragonStats
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }

        public DragonStats(string name, double damage, double health, double armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<DragonStats>> dragons = new Dictionary<string, List<DragonStats>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string name = tokens[1];
                string damage = tokens[2];
                string health = tokens[3];
                string armor = tokens[4];

                if (damage == "null") damage = "45";
                if (health == "null") health = "250";
                if (armor == "null") armor = "10";

                if (dragons.ContainsKey(type))
                {
                    if (dragons[type].Any(x => x.Name == name))
                    {
                        int dragonIndex = dragons[type].FindIndex(x => x.Name == name);
                        dragons[type][dragonIndex].Damage = double.Parse(damage);
                        dragons[type][dragonIndex].Health = double.Parse(health);
                        dragons[type][dragonIndex].Armor = double.Parse(armor);
                    }
                    else
                    {
                        dragons[type].Add(new DragonStats(name, double.Parse(damage), double.Parse(health), double.Parse(armor)));
                    }
                }
                else
                {
                    dragons.Add(type, new List<DragonStats>());
                    dragons[type].Add(new DragonStats(name, double.Parse(damage), double.Parse(health), double.Parse(armor)));
                }
            }

            foreach (var dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.Key}::({(dragons[dragonType.Key].Sum(x => x.Damage) / dragons[dragonType.Key].Count()):f2}" +
                    $"/{(dragons[dragonType.Key].Sum(x => x.Health) / dragons[dragonType.Key].Count()):f2}" +
                    $"/{(dragons[dragonType.Key].Sum(x => x.Armor) / dragons[dragonType.Key].Count()):f2})");
                foreach (var dragon in dragons[dragonType.Key].OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
