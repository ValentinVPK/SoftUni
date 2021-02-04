using System;
using System.Linq;

namespace _9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[size, size];

            int minerRow = 0;
            int minerCol = 0;
            int coalsCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    else if (matrix[row, col] == 'c') coalsCount++;
                }
            }

            int coalsCollected = 0;
            bool isGameOver = false;
            for(int i = 0; i < commands.Length; i++)
            {
               if(commands[i] == "up")
               {
                    if (minerRow - 1 < 0) continue;
                    minerRow--;
               }
               else if(commands[i] == "down")
               {
                    if (minerRow + 1 >= size) continue;
                    minerRow++;
               }
               else if(commands[i] == "right")
               {
                    if (minerCol + 1 >= size) continue;
                    minerCol++;
               }
               else if(commands[i] == "left")
               {
                    if (minerCol - 1 < 0) continue;
                    minerCol--;
               }

               if (matrix[minerRow, minerCol] == 'c')
               {
                   coalsCollected++;
                   matrix[minerRow, minerCol] = '*';
                   if(coalsCollected == coalsCount)
                   {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        break;
                   }
               }
               else if(matrix[minerRow,minerCol] == 'e')
               {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    isGameOver = true;
                    break;
               }
            }

            if(!isGameOver && (coalsCount - coalsCollected) > 0)
            {
                Console.WriteLine($"{coalsCount - coalsCollected} coals left. ({minerRow}, {minerCol})");
            }
        }
    }
}
