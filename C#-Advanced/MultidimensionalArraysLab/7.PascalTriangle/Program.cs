using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            for(int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[row + 1];

                for(int col = 0; col < row + 1; col++)
                {
                    if (row == 0 || row == 1)
                    {
                        pascal[row][col] = 1;
                        continue;
                    }

                    if(col >= 0 && col < pascal[row - 1].Length && col - 1 >= 0 && col < pascal[row - 1].Length)
                    {
                        pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                    }
                    else
                    {
                        pascal[row][col] = 1;
                    }
                }
            }


            for(int row = 0; row < pascal.Length; row++)
            {
                for(int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
