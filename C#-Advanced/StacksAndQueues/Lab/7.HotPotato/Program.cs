using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int tosses = int.Parse(Console.ReadLine());

            Queue<string> hotPotato = new Queue<string>(kids);

            int count = 0;
            while(hotPotato.Count > 1)
            {
                count++;
                string currChild = hotPotato.Dequeue();
                if (count == tosses)
                {
                    count = 0;
                    Console.WriteLine($"Removed {currChild}");
                    continue;
                }

                hotPotato.Enqueue(currChild);
            }

            Console.WriteLine($"Last is {hotPotato.Peek()}");
        }
    }
}
