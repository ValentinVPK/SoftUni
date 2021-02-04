using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> carLine = new Queue<string>();

            string input = string.Empty;
            int totalCount = 0;
            bool crash = false;
            while((input = Console.ReadLine()) != "END")
            {
                if(input == "green")
                {
                    int currCount = greenLightDuration;
                    int currWindow = freeWindowDuration;

                    while(currCount > 0)
                    {
                        if (carLine.Count == 0) break;
                        string currCar = carLine.Dequeue();
                        if(currCount + freeWindowDuration < currCar.Length)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currCar} was hit at {currCar[currCount + freeWindowDuration]}.");
                            crash = true;
                            break;
                        }
                        currCount -= currCar.Length;
                        totalCount++;
                    }
                }
                else
                {
                    carLine.Enqueue(input);
                }

                if (crash) break;
            }

            if(!crash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCount} total cars passed the crossroads.");
            }
        }
    }
}
