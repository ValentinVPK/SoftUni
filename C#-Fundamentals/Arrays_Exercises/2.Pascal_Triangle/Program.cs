using System;

namespace _2.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] lastRowArr = { };

            for (int i = 1; i <= rows; i++)
            {
                int[] nextRowArr = new int[i];
                if (i == 1) nextRowArr[0] = 1;
                else
                {
                    for (int j = 0; j < nextRowArr.Length; j++)
                    {
                        if (j == 0 || j == nextRowArr.Length - 1)
                        {
                            nextRowArr[j] = 1;
                        }
                        else
                        {
                            nextRowArr[j] = lastRowArr[j] + lastRowArr[j - 1];
                        }

                    }
                }
                Console.WriteLine(string.Join(" ", nextRowArr));
                lastRowArr = nextRowArr;
            }
        }
    }
}
