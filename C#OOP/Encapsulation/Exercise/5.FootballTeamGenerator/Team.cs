using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validations.ThrowIfNameIsIncorrect(value);

                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (players.Count == 0) return 0;

                return (int)Math.Round(players.Sum(p => p.Skill) / players.Count);
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var currPlayer = players.FirstOrDefault(p => p.Name == playerName);
            if (currPlayer == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            players.Remove(currPlayer);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
