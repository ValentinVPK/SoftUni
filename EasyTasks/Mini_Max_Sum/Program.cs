using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static long[] miniMaxSum(List<int> inputList)
        {
            long min = 0;
            long max = 0;

            int maxIndex = inputList.IndexOf(inputList.Max());
            int minIndex = inputList.IndexOf(inputList.Min());

            for (int i = 0; i < inputList.Count; i++)
            {
                if(i == maxIndex)
                {
                    continue;
                }

                min += inputList[i];
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                if (i == minIndex)
                {
                    continue;
                }

                max += inputList[i];
            }

            return new long[2] { min, max };
        }
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var resList = miniMaxSum(list);
            Console.WriteLine($"{resList[0]} {resList[1]}");
        }
    }
}
