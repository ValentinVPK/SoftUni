using System;
using System.Collections.Generic;
using System.Text;

namespace _5.FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
            this.Skill = (this.Stats.Endurance + this.Stats.Sprint + this.Stats.Dribble +
                this.Stats.Passing + this.Stats.Shooting) / 5.0;
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
        public Stats Stats { get; private set; }

        public double Skill { get; private set; }
    }
}
