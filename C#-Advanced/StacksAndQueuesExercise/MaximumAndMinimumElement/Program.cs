using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numberStack = new Stack<int>();

            for(int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (commands[0])
                {
                    case 1:
                        numberStack.Push(commands[1]);
                        break;
                    case 2:
                        if(numberStack.Count > 0) numberStack.Pop();
                        break;
                    case 3:
                        if (numberStack.Count > 0) Console.WriteLine(numberStack.Max());
                        break;
                    case 4:
                        if (numberStack.Count > 0) Console.WriteLine(numberStack.Min());
                        break;       
                }
            }

            Console.WriteLine(string.Join(", ", numberStack));
        }
    }
}
