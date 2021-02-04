using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStackOperations
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

            Stack<int> numberStack = new Stack<int>(numbers);

            for(int i = 0; i < commands[1]; i++)
            {
                numberStack.Pop();
            }

            if(numberStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int minElement = numberStack.Sum();
                bool isElementFound = false;

                while (numberStack.Count > 0)
                {
                    int currElement = numberStack.Pop();
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
