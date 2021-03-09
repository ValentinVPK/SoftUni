using System;
using System.Collections.Generic;

namespace _3.Raiding
{
    public class Program
    {
        public static BaseHero CreateHero(string type, string name)
        {
            BaseHero hero = null;

            if(type == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if(type == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (type == nameof(Warrior))
            {
                hero = new Warrior(name);
            }
            else if (type == nameof(Rogue))
            {
                hero = new Rogue(name);
            }

            return hero;
        }

        public static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            while(heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero hero = CreateHero(type, name);

                if(hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                heroes.Add(hero);
            }

            int bossHealth = int.Parse(Console.ReadLine());

            foreach(var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility()); 
                bossHealth -= hero.Power;
            }

            if(bossHealth <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
