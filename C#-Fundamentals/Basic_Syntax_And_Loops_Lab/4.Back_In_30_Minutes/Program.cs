using System;

namespace _4.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int timeMinutes = arrivalHours * 60 + arrivalMinutes + 30;
            int hours = timeMinutes / 60;
            int minutes = timeMinutes % 60;
            if (hours == 24)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
