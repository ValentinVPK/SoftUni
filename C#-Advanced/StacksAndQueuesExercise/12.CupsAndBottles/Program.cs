using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottlesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> cups = new Stack<int>(cupsInput.Reverse());
            Stack<int> bottles = new Stack<int>(bottlesInput);


            int wastedLiters = 0;
            while (true)
            {
                if(bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(' ', cups)}");
                    Console.WriteLine($"Wasted litters of water: {wastedLiters}");
                    break;
                }
                if(cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(' ', bottles.Reverse())}");
                    Console.WriteLine($"Wasted litters of water: {wastedLiters}");
                    break;
                }

                int currBottle = bottles.Pop();
                int currCup = cups.Pop();

                if(currBottle >= currCup)
                {
                    wastedLiters += currBottle - currCup;
                }
                else
                {
                    currCup -= currBottle;
                    cups.Push(currCup);
                }
            }
        }
    }
}
