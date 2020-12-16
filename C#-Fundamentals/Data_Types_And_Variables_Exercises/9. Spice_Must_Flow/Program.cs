using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingYield = int.Parse(Console.ReadLine());
            int spicesCollected = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                days++;
                spicesCollected = spicesCollected + startingYield - 26;
                startingYield = startingYield - 10;
            }
            if (spicesCollected > 0) spicesCollected -= 26;
            Console.WriteLine(days);
            Console.WriteLine(spicesCollected);
        }
    }
}
