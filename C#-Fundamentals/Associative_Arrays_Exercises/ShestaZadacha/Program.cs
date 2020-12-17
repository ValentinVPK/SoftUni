using System;
using System.Collections.Generic;
using System.Linq;

namespace ShestaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while((command = Console.ReadLine()) != "end")
            {
                string[] courseAndStudent = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = courseAndStudent[0];
                string studentName = courseAndStudent[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
            }

            foreach(var course in courses.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                
                foreach(var student in course.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
