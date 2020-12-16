using System;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            int originalValueOfN = N;
            var M = int.Parse(Console.ReadLine());
            var Y = int.Parse(Console.ReadLine());
            int pokedCount = 0;

            while (N >= M)
            {
                N = N - M;
                pokedCount++;
                if (N == originalValueOfN / 2 && Y > 0)
                {
                    N = N / Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokedCount);
        }
    }
}
