using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToList();
                StringBuilder name = new StringBuilder();
                StringBuilder age = new StringBuilder();

                int firstIndex = Math.Min(input.IndexOf('@'), input.IndexOf('|'));
                int secondIndex = Math.Max(input.IndexOf('@'), input.IndexOf('|'));
                for (int j = firstIndex + 1; j < secondIndex; j++)
                {
                    name.Append(input[j]);
                }

                int thirdIndex = Math.Min(input.IndexOf('#'), input.IndexOf('*'));
                int fourthIndex = Math.Max(input.IndexOf('#'), input.IndexOf('*'));

                for (int t = thirdIndex + 1; t < fourthIndex; t++)
                {
                    age.Append(input[t]);
                }

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
