using System;

namespace _9.ExplicitInterfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            while((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                Citizen citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
