using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> pumpsData = new Queue<string>();

            for(int i = 0; i < n; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());     
            }

            for(int i = 0; i < n; i++)
            {
                bool isSuccessful = true;
                int currPetrol = 0;
                for(int j = 0; j < n; j++)
                {
                    string currPump = pumpsData.Dequeue();
                    pumpsData.Enqueue(currPump);

                    if (isSuccessful)
                    {
                        string[] tokens = currPump.Split();
                        int amount = int.Parse(tokens[0]);
                        int distance = int.Parse(tokens[1]);

                        currPetrol += amount - distance;
                        if(currPetrol < 0)
                        {
                            isSuccessful = false;
                        }
                    }
                }

                if(isSuccessful == true)
                {
                    Console.WriteLine(i);
                    break;
                }

                pumpsData.Enqueue(pumpsData.Dequeue());
            }
        }
    }
}
