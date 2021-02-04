using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            string command = string.Empty;

            while((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if(tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (tokens[0] != "swap" || (int.Parse(tokens[1]) < 0 || int.Parse(tokens[1]) >= sizes[0]) ||(int.Parse(tokens[3]) < 0 || int.Parse(tokens[3]) >= sizes[0]) || (int.Parse(tokens[2]) < 0 || int.Parse(tokens[2]) >= sizes[1]) || (int.Parse(tokens[4]) < 0 || int.Parse(tokens[4]) >= sizes[1]))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string tmp = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tmp;

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
}
