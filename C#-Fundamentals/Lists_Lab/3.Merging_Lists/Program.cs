using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            int biggerLength = 0;
            if (firstList.Count >= secondList.Count) biggerLength = firstList.Count;
            else biggerLength = secondList.Count;

            for (int i = 0; i < biggerLength; i++)
            {
                if (i >= firstList.Count)
                {
                    resultList.Add(secondList[i]);
                }
                else if (i >= secondList.Count)
                {
                    resultList.Add(firstList[i]);
                }
                else
                {
                    resultList.Add(firstList[i]);
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
