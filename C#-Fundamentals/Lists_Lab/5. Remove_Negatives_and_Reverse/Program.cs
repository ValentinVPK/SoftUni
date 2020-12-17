using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> negativeNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0) negativeNumbers.Add(numbers[i]);
            }

            foreach (int negativeNumber in negativeNumbers)
            {
                numbers.Remove(negativeNumber);
            }

            numbers.Reverse();

            if (numbers.Count == 0) Console.WriteLine("empty");
            else Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
