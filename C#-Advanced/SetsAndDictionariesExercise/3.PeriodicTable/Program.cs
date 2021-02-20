using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for(int j = 0; j < tokens.Length; j++)
                {
                    elements.Add(tokens[j]);
                }
            }

            foreach(string element in elements.OrderBy(x => x))
            {
                Console.Write(element + " ");
            }
        }
    }
}
