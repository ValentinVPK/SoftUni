using System;
using System.Linq;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

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

            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < tokens.Length; i++)
            {
                int currBombRow = tokens[i][0] - '0';
                int currBombCol = tokens[i][2] - '0';

                if (matrix[currBombRow, currBombCol] <= 0) continue;

                if (currBombCol - 1 >= 0) if(matrix[currBombRow, currBombCol - 1] > 0) matrix[currBombRow , currBombCol - 1] -= matrix[currBombRow, currBombCol];
                if (currBombCol + 1 < size) if (matrix[currBombRow, currBombCol + 1] > 0) matrix[currBombRow , currBombCol + 1] -= matrix[currBombRow, currBombCol];

                if (currBombRow - 1 >= 0)
                {
                    if (matrix[currBombRow - 1, currBombCol] > 0) matrix[currBombRow - 1, currBombCol] -= matrix[currBombRow, currBombCol];
                    if (currBombCol - 1 >= 0) if (matrix[currBombRow - 1, currBombCol - 1] > 0) matrix[currBombRow - 1, currBombCol - 1] -= matrix[currBombRow, currBombCol];
                    if(currBombCol + 1 < size) if (matrix[currBombRow - 1, currBombCol + 1] > 0) matrix[currBombRow - 1, currBombCol + 1] -= matrix[currBombRow, currBombCol];
                }
                
                if(currBombRow + 1 < size)
                {
                    if (matrix[currBombRow + 1, currBombCol] > 0) matrix[currBombRow + 1, currBombCol] -= matrix[currBombRow, currBombCol];
                    if (currBombCol - 1 >= 0) if (matrix[currBombRow + 1, currBombCol - 1] > 0) matrix[currBombRow + 1, currBombCol - 1] -= matrix[currBombRow, currBombCol];
                    if (currBombCol + 1 < size) if (matrix[currBombRow + 1, currBombCol + 1] > 0) matrix[currBombRow + 1, currBombCol + 1] -= matrix[currBombRow, currBombCol];
                }

                matrix[currBombRow, currBombCol] = 0;
            }


            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] > 0)
                    {
                        sum += matrix[row, col];
                        aliveCells++;
                    }
                }
            }


            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
