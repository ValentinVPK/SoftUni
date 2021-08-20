using System;
using System.Collections.Generic;

namespace _5.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> nameAndAge = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                nameAndAge.Add(tokens[0], int.Parse(tokens[1]));
            }


            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if(condition == "younger")
            {
                nameAndAge = CustomWhere(x => x < age, nameAndAge);
            }
            else if(condition == "older")
            {
                nameAndAge = CustomWhere(x => x > age, nameAndAge);
            }

            Print(nameAndAge, format);
        }

        static Dictionary<string,int> CustomWhere(Func<int, bool> condition, Dictionary<string, int> nameAndAge)
        {
            Dictionary<string, int> filtered = new Dictionary<string, int>();
            foreach(var element in nameAndAge)
            {
                if (condition(element.Value))
                {
                    filtered.Add(element.Key, element.Value);
                }
            }

            return filtered;
        }

        static void Print(Dictionary<string, int> nameAndAge, string format)
        {
            if(format == "name")
            {
                foreach(var element in nameAndAge)
                {
                    Console.WriteLine(element.Key);
                }
            }
            else if (format == "age")
            {
                foreach (var element in nameAndAge)
                {
                    Console.WriteLine(element.Value);
                }
            }
            else
            {
                foreach (var element in nameAndAge)
                {
                    Console.WriteLine($"{element.Key} - {element.Value}");
                }
            }
        }
    }
}
