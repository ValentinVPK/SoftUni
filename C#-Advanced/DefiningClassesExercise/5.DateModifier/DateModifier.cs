using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int CalculateDifference(string input1, string input2)
        {
            string[] tokens1 = input1.Split();
            string[] tokens2 = input2.Split();

            DateTime date1 = new DateTime(int.Parse(tokens1[0]), int.Parse(tokens1[1]), int.Parse(tokens1[2]));
            DateTime date2 = new DateTime(int.Parse(tokens2[0]), int.Parse(tokens2[1]), int.Parse(tokens2[2]));

            return Math.Abs((date1 - date2).Days);
        }
    }
}
