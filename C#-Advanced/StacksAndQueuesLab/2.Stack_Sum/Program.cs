using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();


            foreach(int number in inputNumbers)
            {
                numbers.Push(number);
            }

            string command = string.Empty;

            while((command = Console.ReadLine()?.ToUpper()) != "END")
            {
                string[] commandArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if(commandArr[0]?.ToUpper() == "ADD")
                {
                    numbers.Push(int.Parse(commandArr[1]));
                    numbers.Push(int.Parse(commandArr[2]));
                }
                else if(commandArr[0]?.ToUpper() == "REMOVE")
                {
                    if (numbers.Count < int.Parse(commandArr[1])) continue;

                    for(int i = 0; i < int.Parse(commandArr[1]); i++)
                    {
                        numbers.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
