using System;

namespace _8.Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Town {0} has population of {1} and area {2} square km.", townName, population, area);
        }
    }
}
