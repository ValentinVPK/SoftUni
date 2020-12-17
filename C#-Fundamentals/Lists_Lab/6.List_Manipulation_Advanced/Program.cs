using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            bool changesMade = false;

            while (command[0] != "end")
            {
                string method = command[0];

                switch (method)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        changesMade = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        changesMade = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        changesMade = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        changesMade = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1]))) Console.WriteLine("Yes");
                        else Console.WriteLine("No such number");
                        break;
                    case "PrintEven":
                        foreach (int number in numbers)
                        {
                            if (number % 2 == 0) Console.Write($"{number} ");
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int number in numbers)
                        {
                            if (number % 2 == 1) Console.Write($"{number} ");
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = command[1];
                        switch (condition)
                        {
                            case "<":
                                foreach (int number in numbers)
                                {
                                    if (number < int.Parse(command[2])) Console.Write($"{number} ");
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                foreach (int number in numbers)
                                {
                                    if (number > int.Parse(command[2])) Console.Write($"{number} ");
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                foreach (int number in numbers)
                                {
                                    if (number <= int.Parse(command[2])) Console.Write($"{number} ");
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                foreach (int number in numbers)
                                {
                                    if (number >= int.Parse(command[2])) Console.Write($"{number} ");
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            if (changesMade) Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
