using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OsmaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            double result = 0;
            
            foreach(string input in strings)
            {
                // Setting up the variables
                StringBuilder currentNumberString = new StringBuilder();
                double currentResult;
                char firstLetter = input[0];
                char lastLetter = input[input.Length - 1];
                int firstLetterPosition = char.ToUpper(firstLetter) - 64;
                int lastLetterPosition = char.ToUpper(lastLetter) - 64;

                // Finding the number
                foreach (char ch in input)
                {
                    if (char.IsDigit(ch))
                    {
                        currentNumberString.Append(ch);
                    }
                }
                int currentNumber = int.Parse(currentNumberString.ToString());

                // FirstLetter:
                if (char.IsUpper(firstLetter)) currentResult = (currentNumber * 1.0) / firstLetterPosition;
                else currentResult = currentNumber * firstLetterPosition;

                // LastLetter

                if (char.IsUpper(lastLetter)) currentResult -= lastLetterPosition;
                else currentResult += lastLetterPosition;

                result += currentResult;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
