﻿using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openingBracketIndexes = new Stack<int>();

            for(int i = 0; i < input.Length;  i++)
            {
                if (input[i] == '(') openingBracketIndexes.Push(i);

                if(input[i] == ')')
                {
                    int startIndex = openingBracketIndexes.Pop();
                    Console.WriteLine(input.Substring(startIndex,i - startIndex + 1));
                }
            }
        }
    }
}
