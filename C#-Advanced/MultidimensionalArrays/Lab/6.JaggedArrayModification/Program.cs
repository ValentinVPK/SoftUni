using System;
using System.Linq;

namespace _6.JaggedArrayModification
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

            string command = string.Empty;

            while((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if(row < 0 || row >= size || col < 0 || col >= size)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if(tokens[0] == "Add")
                {
                    matrix[row, col] += int.Parse(tokens[3]);
                }
                else if(tokens[0] == "Subtract")
                {
                    matrix[row, col] -= int.Parse(tokens[3]);
                }
            }


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
