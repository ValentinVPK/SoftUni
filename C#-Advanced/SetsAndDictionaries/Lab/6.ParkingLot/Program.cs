using System;
using System.Collections.Generic;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string input;

            while((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "IN") carNumbers.Add(tokens[1]);
                else if (tokens[0] == "OUT") carNumbers.Remove(tokens[1]);
            }

            if(carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var number in carNumbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
