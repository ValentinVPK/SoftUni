using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAdding = int.Parse(Console.ReadLine());
            int litersAvailable = 255;

            for (int i = 1; i <= numberOfAdding; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > litersAvailable)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else litersAvailable -= liters;
            }
            Console.WriteLine(255 - litersAvailable);
        }
    }
}
