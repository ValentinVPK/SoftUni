using System;
using System.Collections.Generic;

namespace _7.SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string input;

            while((input = Console.ReadLine()) != "PARTY")
            {
                if(input[0] >= '0' && input[0] <= '9')
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            while((input = Console.ReadLine()) != "END")
            {
                if (input[0] >= '0' && input[0] <= '9')
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    regularGuests.Remove(input);
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach(var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }
            foreach(var regularGuest in regularGuests)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}
