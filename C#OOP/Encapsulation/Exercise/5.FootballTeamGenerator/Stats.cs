using System;
using System.Collections.Generic;
using System.Text;

namespace _5.FootballTeamGenerator
{
    public class Stats
    {
        private const int minValue = 0;
        private const int maxValue = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance,
            int sprint,
            int dribble,
            int passing,
            int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public int Endurance
        {
            get => this.endurance;
            set
            {
                Validations.ThrowIfStatIsNotInRange(minValue, maxValue, value,
                    $"Endurance should be between {minValue} and {maxValue}.");

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            set
            {
                Validations.ThrowIfStatIsNotInRange(minValue, maxValue, value,
                    $"Sprint should be between {minValue} and {maxValue}.");

                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            set
            {
                Validations.ThrowIfStatIsNotInRange(minValue, maxValue, value,
                    $"Dribble should be between {minValue} and {maxValue}.");

                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            set
            {
                Validations.ThrowIfStatIsNotInRange(minValue, maxValue, value,
                    $"Passing should be between {minValue} and {maxValue}.");

                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            set
            {
                Validations.ThrowIfStatIsNotInRange(minValue, maxValue, value,
                    $"Shooting should be between {minValue} and {maxValue}.");

                this.shooting = value;
            }
        }
    }
}
