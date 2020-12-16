using System;

namespace _2.Grades
{
    class Program
    {
        static void Grades(double grade)
        {
            if (grade >= 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
        static void Main(string[] args)
        {
            double inputGrade = double.Parse(Console.ReadLine());
            Grades(inputGrade);
        }
    }
}
