using System;
using System.Collections.Generic;
using System.Linq;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            int[] platesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> plates = new List<int>(platesInput);
            
            for (int i = 1; i <= waves; i++)
            {
                int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                Stack<int> orcWave = new Stack<int>();

                if (plates.Count == 0)
                {
                    break;
                }

                if (i % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }

                foreach (int number in input) orcWave.Push(number);

                while (true)
                {
                    if(orcWave.Count == 0)
                    {
                        break;
                    }
                    if(plates.Count == 0)
                    {
                        Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                        Console.WriteLine($"Orcs left: {string.Join(", ", orcWave)}");
                        break;
                    }

                    int currOrc = orcWave.Pop();

                    if(currOrc == plates[0])
                    {
                        plates.RemoveAt(0);
                    }
                    else if(currOrc > plates[0])
                    {
                        currOrc = currOrc - plates[0];
                        orcWave.Push(currOrc);
                        plates.RemoveAt(0);
                    }
                    else
                    {
                        plates[0] -= currOrc;
                    }

                }
            }

            if(plates.Count > 0)
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
