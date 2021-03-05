using System;
using System.Collections.Generic;

namespace _5.BirthdayCelebrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            List<IBirthdate> birthdates = new List<IBirthdate>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Citizen")
                {
                    birthdates.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    birthdates.Add(new Pet(tokens[1], tokens[2]));
                }
            }

            string year = Console.ReadLine();

            foreach (var birthdate in birthdates)
            {
                if (birthdate.Birthdate.Substring(birthdate.Birthdate.Length - 4) == year)
                {
                    Console.WriteLine(birthdate.Birthdate);
                }
            }
        }
    }
}
