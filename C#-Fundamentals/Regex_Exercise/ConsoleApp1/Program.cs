using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {     
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Demon> allDemons = new List<Demon>();

            var pattern = @"-?\d+\.?\d*";
            var regex = new Regex(pattern);

            foreach (string demon in demons)
            {
                // Finding the health:
                var health = demon
                    .Where(s => !char.IsDigit(s)
                    && s != '+' && s != '-' && s != '*' && s != '/' && s != '.')
                    .Sum(s => (int)s);

                // Finding the damage

                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var value = match.Value;
                    damage += double.Parse(value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                //Adding the demon to the list:

                allDemons.Add(new Demon(demon, health, damage));
            } 
            
            foreach(Demon demon in allDemons.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
