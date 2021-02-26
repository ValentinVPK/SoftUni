using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];

            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                    if(matrix[row,col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();


            bool isWon = false;
            bool isDead = false;
            
            foreach(char direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if(direction == 'U')
                {
                    newPlayerRow--;
                }
                else if (direction == 'D')
                {
                    newPlayerRow++;
                }
                else if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }

                if (!IsValidCell(newPlayerRow, newPlayerCol, sizes[0], sizes[1]))
                {
                    isWon = true;
                    matrix[playerRow, playerCol] = '.';
                }
                else if(matrix[newPlayerRow,newPlayerCol] == '.')
                {
                    matrix[playerRow, playerCol] = '.';
                    matrix[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;         
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    matrix[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    
                    if(matrix[playerRow,playerCol] == 'B')
                    {
                        isDead = true;
                    }
                }

                List<int[]> bunniesPosition = GetBunniesCoordinates(matrix);
                SpreadBunnies(bunniesPosition, matrix);

                if(isDead || isWon)
                {
                    break;
                }
            }

            PrintMatrix(matrix);

            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }

            if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesPosition, char[,] matrix)
        {
            foreach (int[] bunnyPosition in bunniesPosition)
            {
                int row = bunnyPosition[0];
                int col = bunnyPosition[1];

                SpreadBunny(row - 1,col, matrix);

                SpreadBunny(row + 1, col, matrix);

                SpreadBunny(row , col - 1, matrix);

                SpreadBunny(row , col + 1, matrix);
            }
        }

        private static void SpreadBunny(int row, int col, char[,] matrix)
        {
            if(IsValidCell(row , col , matrix.GetLength(0), matrix.GetLength(1)))
            {
                matrix[row, col] = 'B';
            }
        }

        public static List<int[]> GetBunniesCoordinates(char[,] matrix)
        {
            List<int[]> bunniesPosition = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesPosition.Add(new int[] { row, col });
                    }
                }
            }

            return bunniesPosition;
        }
        public static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
