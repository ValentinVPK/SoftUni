using System;
using System.Linq;

namespace _5.SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int[,] maxSquare = new int[2, 2];
            int maxSum = int.MinValue;

            for(int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for(int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if(currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSquare[0, 0] = matrix[row, col];
                        maxSquare[0, 1] = matrix[row, col + 1];
                        maxSquare[1, 0] = matrix[row + 1, col];
                        maxSquare[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            for(int row = 0; row < maxSquare.GetLength(0); row++)
            {
                for(int col = 0; col < maxSquare.GetLength(1); col++)
                {
                    Console.Write(maxSquare[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
