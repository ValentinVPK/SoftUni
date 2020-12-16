using System;

namespace _11._Encrypt_Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            long[] sums = new long[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                long sum = 0;
                string word = Console.ReadLine();

                foreach (char letter in word)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {
                        sum += (int)letter * word.Length;
                    }
                    else
                    {
                        sum += (int)letter / word.Length;
                    }
                }
                sums[i] = sum;
            }
            Array.Sort(sums);
            foreach (long sum in sums)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
