using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] name = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!students.ContainsKey(name[0]))
                {
                    students.Add(name[0], new List<double>());
                }
                students[name[0]].Add(double.Parse(name[1]));
            }

            foreach(var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
