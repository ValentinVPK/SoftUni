using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double sumLeftCar = 0;
            double sumRightCar = 0;

            int middleIndex = (arrayOfNumbers.Length / 2);

            // Left Car Sum

            for (int i = 0; i < middleIndex; i++)
            {
                if (arrayOfNumbers[i] == 0) sumLeftCar = sumLeftCar - 20 / 100.0 * sumLeftCar;
                else sumLeftCar += arrayOfNumbers[i];
            }

            // Right Car Sum

            for (int i = arrayOfNumbers.Length - 1; i > middleIndex; i--)
            {
                if (arrayOfNumbers[i] == 0) sumRightCar = sumRightCar - 20 / 100.0 * sumRightCar;
                else sumRightCar += arrayOfNumbers[i];
            }

            // Which is with bigger result

            if (sumLeftCar < sumRightCar)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeftCar}");
            }
            else if (sumRightCar < sumLeftCar)
            {
                Console.WriteLine($"The winner is right with total time: {sumRightCar}");
            }
        }
    }
}
