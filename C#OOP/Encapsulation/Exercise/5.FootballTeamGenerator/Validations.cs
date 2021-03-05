using System;

namespace _5.FootballTeamGenerator
{
    public static class Validations
    {
        public static void ThrowIfStatIsNotInRange(int minValue, int maxValue, int value, string message)
        {
            if(value < minValue || value > maxValue)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ThrowIfNameIsIncorrect(string name)
        {
            if(name == null || name == "" || name == " ")
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }
    }
}
