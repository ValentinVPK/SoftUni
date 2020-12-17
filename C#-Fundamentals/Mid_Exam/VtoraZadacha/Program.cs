using System;
using System.Collections.Generic;
using System.Linq;

namespace VtoraZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> seriesOfStrings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
          
            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string method = commandArr[0];

                if(method == "remove")
                {
                    int count = int.Parse(commandArr[1]);
                    for(int i = 1; i <= count; i++)
                    {
                        seriesOfStrings.RemoveAt(0);
                    }
                }
                else if(method == "reverse")
                {
                    int startIndex = int.Parse(commandArr[2]);
                    int count = int.Parse(commandArr[4]);

                    List<string> resultList = new List<string>();
                    for(int i = startIndex; i <= startIndex + count - 1; i++)
                    {
                        resultList.Add(seriesOfStrings[i]);
                    }

                    resultList.Reverse();

                    int resultListIndexCount = 0;
                    for(int i = startIndex; i <= startIndex + count - 1; i++)
                    {
                        seriesOfStrings[i] = resultList[resultListIndexCount];
                        resultListIndexCount++;
                    }
                }
                else if(method == "sort")
                {
                    int startIndex = int.Parse(commandArr[2]);
                    int count = int.Parse(commandArr[4]);

                    List<string> resultList = new List<string>();
                    for (int i = startIndex; i <= startIndex + count - 1; i++)
                    {
                        resultList.Add(seriesOfStrings[i]);
                    }

                    resultList.Sort();

                    int resultListIndexCount = 0;
                    for (int i = startIndex; i <= startIndex + count - 1; i++)
                    {
                        seriesOfStrings[i] = resultList[resultListIndexCount];
                        resultListIndexCount++;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", seriesOfStrings));
        }
    }
}
