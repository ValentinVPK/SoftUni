using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int primeDiagSum = 0;
            int secondDiagSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                    if (row == col) primeDiagSum += matrix[row, col];
                    if (col == (size - 1 - row)) secondDiagSum += matrix[row, col];     
                }
            }

            Console.WriteLine(Math.Abs(primeDiagSum - secondDiagSum));
        }
    }
}
