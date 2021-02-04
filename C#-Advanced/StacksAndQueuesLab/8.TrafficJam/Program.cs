using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> carLine = new Queue<string>();

            int totalCount = 0;

            string command = string.Empty;
            while((command = Console.ReadLine()) != "end")
            {
                if(command == "green")
                {
                    for(int i = 0; i < n; i++)
                    {
                        if (carLine.Count == 0) break;

                        Console.WriteLine($"{carLine.Dequeue()} passed!");
                        totalCount++;
                    }
                  
                }
                else
                {
                    carLine.Enqueue(command);
                }
            }

            Console.WriteLine($"{totalCount} cars passed the crossroads.");
        }
    }
}
