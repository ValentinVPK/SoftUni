using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locksInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int prize = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Stack<int> locks = new Stack<int>(locksInput.Reverse());

            int barrelCount = 0;
            while(true)
            {
                if (barrelCount == barrelSize && bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                    barrelCount = 0;
                }

                if (bullets.Count >= 0 && locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${prize - (bulletsInput.Length - bullets.Count) * bulletPrice}");
                    break;
                }
                else if (locks.Count > 0 && bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }

                int currBullet = bullets.Pop();
                barrelCount++;
                int currLock = locks.Peek();

                if(currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
            }
        }
    }
}
