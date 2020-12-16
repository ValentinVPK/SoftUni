using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());
            if (stopNumber <= 10)
            {
                for (int i = stopNumber; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {i * number}");
                }
            }
            else
            {
                Console.WriteLine($"{number} X {stopNumber} = {stopNumber * number}");
            }
        }
    }
}
