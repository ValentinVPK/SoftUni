using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numberQueue = new Queue<int>(numbers);

            for(int i = 0; i < commands[1]; i++)
            {
                numberQueue.Dequeue();
            }

            if(numberQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int minElement = numberQueue.Sum();
                bool isElementFound = false;

                while (numberQueue.Count > 0)
                {
                    int currElement = numberQueue.Dequeue();
                    if (currElement == commands[2])
                    {
                        isElementFound = true;
                        break;
                    }

                    if (currElement <= minElement)
                    {
                        minElement = currElement;
                    }
                }


                if (isElementFound) Console.WriteLine("true");
                else
                {
                    Console.WriteLine(minElement);
                }
            }
        }
    }
}
