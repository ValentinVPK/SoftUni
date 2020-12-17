using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _7.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allTickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string ticket in allTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                StringBuilder firstHalf = new StringBuilder();
                StringBuilder secondHalf = new StringBuilder();

                for (int i = 0; i < ticket.Length; i++)
                {
                    if (i < 10) firstHalf.Append(ticket[i]);
                    else secondHalf.Append(ticket[i]);
                }


                string winningPattern = @"(\${6,10}|#{6,10}|\^{6,10}|@{6,10})";
                if (Regex.IsMatch(firstHalf.ToString(), winningPattern) && Regex.IsMatch(secondHalf.ToString(), winningPattern))
                {
                    Match firstHalfMatch = Regex.Match(firstHalf.ToString(), winningPattern);
                    Match secondHalfMatch = Regex.Match(secondHalf.ToString(), winningPattern);
                    if (firstHalfMatch.Groups[1].Value[0] == secondHalfMatch.Groups[1].Value[0])
                    {
                        char winningSymbol = firstHalfMatch.Groups[1].Value[0];
                        int minLength = Math.Min(firstHalfMatch.Groups[1].Value.Length, secondHalfMatch.Groups[1].Value.Length);
                        if (minLength == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{winningSymbol} Jackpot!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minLength}{winningSymbol}");
                            continue;
                        }
                    }
                }
                Console.WriteLine($"ticket \"{ticket}\" - no match")
        }
    }
}
