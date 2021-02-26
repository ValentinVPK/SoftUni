using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[][] jagged = new double[size][];

            for(int row = 0; row < jagged.Length; row++)
            {
                double[] colInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jagged[row] = new double[colInput.Length];
                for(int col = 0; col < colInput.Length; col++)
                {
                    jagged[row][col] = colInput[col];
                }
            }


            for(int row = 0; row < jagged.Length - 1; row++)
            {
                if(jagged[row].Length == jagged[row + 1].Length)
                {
                    for(int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2.0;
                    }
                }
            }

            string command = string.Empty;
            while((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int currRow = int.Parse(tokens[1]);
                int currCol = int.Parse(tokens[2]);

                if(currRow < 0 || currRow >= jagged.Length) continue;             
                if (currCol < 0 || currCol >= jagged[currRow].Length) continue;

                if(tokens[0] == "Add")
                {
                    jagged[currRow][currCol] += int.Parse(tokens[3]);
                }
                else if(tokens[0] == "Subtract")
                {
                    jagged[currRow][currCol] -= int.Parse(tokens[3]);
                }
            }


            for(int row = 0; row < jagged.Length; row++)
            {
                for(int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
