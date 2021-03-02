using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public static class Validator
    {
        public static void ThrowIfNumberIsNotInRange(int min, int max, int value, string exceptionMessage)
        {
            if(value < min || value > max)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
