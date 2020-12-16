using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)numberOfPeople / capacity);
            Console.WriteLine(courses);
        }
    }
}
