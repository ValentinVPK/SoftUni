using System;
using System.Collections.Generic;

namespace _6.SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nameList = new Queue<string>();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "End")
            {
                if(command == "Paid")
                {
                    while(nameList.Count > 0)
                    {
                        Console.WriteLine(nameList.Dequeue());
                    }
                    continue;
                }

                nameList.Enqueue(command);
            }

            Console.WriteLine($"{nameList.Count} people remaining.");
        }
    }
}
