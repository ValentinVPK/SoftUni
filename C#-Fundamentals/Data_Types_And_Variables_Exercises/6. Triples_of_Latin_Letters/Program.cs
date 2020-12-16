using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstLetterIndex = 'a'; firstLetterIndex < 'a' + n; firstLetterIndex++)
            {
                for (int secondLetterIndex = 'a'; secondLetterIndex < 'a' + n; secondLetterIndex++)
                {
                    for (int thirdLetterIndex = 'a'; thirdLetterIndex < 'a' + n; thirdLetterIndex++)
                    {
                        Console.Write("{0}{1}{2}", (char)firstLetterIndex, (char)secondLetterIndex, (char)thirdLetterIndex);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
