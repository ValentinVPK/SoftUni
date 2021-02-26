using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] clothesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(clothesInput);

            int count = 1;
            int rackCapacityTmp = rackCapacity;
            while(clothes.Count > 0)
            {
                int currClothing = clothes.Pop();

                rackCapacityTmp -= currClothing;

                if(rackCapacityTmp < 0)
                {
                    ++count;
                    rackCapacityTmp = rackCapacity - currClothing;
                }
            }

            Console.WriteLine(count);
        }
    }
}
