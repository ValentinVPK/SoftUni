using System;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            char[,] matrix = new char[sizes[0], sizes[1]];

            int currCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if(row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currCount > snake.Length - 1) currCount = 0;
                        matrix[row, col] = snake[currCount];
                        ++currCount;
                    }
                }
                else if(row % 2 == 1)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currCount > snake.Length - 1) currCount = 0;
                        matrix[row, col] = snake[currCount];
                        ++currCount;
                    }
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
