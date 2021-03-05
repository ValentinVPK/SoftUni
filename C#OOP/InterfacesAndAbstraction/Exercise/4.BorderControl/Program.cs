using System;
using System.Collections.Generic;

namespace _4.BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            List<Iid> ids = new List<Iid>();
            while((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if(tokens.Length == 3)
                {
                    ids.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else if(tokens.Length == 2)
                {
                    ids.Add(new Robot(tokens[0], tokens[1]));
                }
            }

            string lastNumber = Console.ReadLine();

            foreach(var id in ids)
            {
                if(id.Id.Substring(id.Id.Length - lastNumber.Length) == lastNumber)
                {
                    Console.WriteLine(id.Id);
                }
            }
        }
    }
}
