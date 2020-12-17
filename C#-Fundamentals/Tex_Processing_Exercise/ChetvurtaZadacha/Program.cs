using System;

namespace ChetvurtaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            foreach(char ch in input)
            {
                result += (char)(ch + 3);
            }

            Console.WriteLine(result);
        }
    }
}
