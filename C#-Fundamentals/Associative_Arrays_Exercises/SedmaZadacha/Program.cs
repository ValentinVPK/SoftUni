using System;
using System.Collections.Generic;
using System.Linq;

namespace SedmaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> students = new Dictionary<string, double>();

            for(int i = 1; i <= n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName] = (students[studentName] + grade) / 2;
                }
                else
                {
                    students.Add(studentName, grade);
                }
            }

            var studentsFiltered = students.Where(g => g.Value >= 4.50).OrderByDescending(g => g.Value).ToDictionary(s => s.Key , s => s.Value);

            foreach(var student in studentsFiltered)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
