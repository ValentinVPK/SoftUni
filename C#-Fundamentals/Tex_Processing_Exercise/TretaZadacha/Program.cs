using System;

namespace TretaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int lastSign = input.LastIndexOf("\\");
            input = input.Substring(lastSign + 1);
            string[] nameAndExtension = input.Split('.', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {nameAndExtension[0]}\nFile extension: {nameAndExtension[1]}");
        }
    }
}
