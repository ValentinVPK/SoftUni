using System;

namespace _5._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endingNumber = int.Parse(Console.ReadLine());

            for (int symbolIndex = startingNumber; symbolIndex <= endingNumber; symbolIndex++)
            {
                Console.Write((char)symbolIndex + " ");
            }
        }
    }
}
