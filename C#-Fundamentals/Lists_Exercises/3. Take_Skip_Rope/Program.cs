using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();


            // split the input string into numbers and non-numbers
            foreach (char character in input)
            {
                if (character == '0' || character == '1' || character == '2' || character == '3' || character == '4' || character == '5' || character == '6' || character == '7' || character == '8' || character == '9')
                {
                    numbersList.Add(character - '0');
                }
                else
                {
                    nonNumbersList.Add(character);
                }
            }

            // Split the numbersList

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0) takeList.Add(numbersList[i]);
                else if (i % 2 == 1) skipList.Add(numbersList[i]);
            }

            string result = string.Empty;
            int skipCounter = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                if (skipCounter >= nonNumbersList.Count) break;
                for (int j = skipCounter; j < skipCounter + takeList[i]; j++)
                {
                    if (j >= nonNumbersList.Count) break;
                    result = result + nonNumbersList[j];
                }

                skipCounter += takeList[i];
                skipCounter += skipList[i];
            }

            Console.WriteLine(result);
        }
    }
}
