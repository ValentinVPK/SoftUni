﻿using System;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 7)
                Console.WriteLine(days[number - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
