using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int[,] maxSquare = new int[3, 3];
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum = 0;
                    for(int i = row; i < row + 3; i++)
                    {
                        for(int j = col; j < col + 3; j++)
                        {
                            currSum += matrix[i, j];
                        }
                    }

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                maxSquare[i, j] = matrix[row + i, col + j];
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (int row = 0; row < maxSquare.GetLength(0); row++)
            {
                for (int col = 0; col < maxSquare.GetLength(1); col++)
                {
                    Console.Write(maxSquare[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
