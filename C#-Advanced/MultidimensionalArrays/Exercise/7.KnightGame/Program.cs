using System;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                string currRow = Console.ReadLine();
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int minSum = 0;
            int knightAttacks = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] == 'K')
                    {
                        if(row - 2 >= 0)
                        {
                            if (col - 1 >= 0) if (matrix[row - 2, col - 1] == 'K') knightAttacks++;
                            if(col + 1 < size) if (matrix[row - 2, col + 1] == 'K') knightAttacks++;
                        }

                        if(row + 2 < size)
                        {
                            if (col - 1 >= 0) if (matrix[row + 2, col - 1] == 'K') knightAttacks++;
                            if (col + 1 < size) if (matrix[row + 2, col + 1] == 'K') knightAttacks++;
                        }

                        if(col - 2 >= 0)
                        {
                            if (row - 1 >= 0) if (matrix[row - 1, col - 2] == 'K') knightAttacks++;
                            if(row + 1 < size) if (matrix[row + 1, col - 2] == 'K') knightAttacks++;
                        }

                        if(col + 2 < size)
                        {
                            if (row - 1 >= 0) if (matrix[row - 1, col + 2] == 'K') knightAttacks++;
                            if (row + 1 < size) if (matrix[row + 1, col + 2] == 'K') knightAttacks++;
                        }
                    }
                }
            }
            knightAttacks /= 2;

            while(knightAttacks > 0)
            {
                int maxKnightRow = 0;
                int maxKnightCol = 0;
                int maxKnightAttacks = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currKnightAttacks = 0;
                        if (matrix[row, col] == 'K')
                        {
                            if (row - 2 >= 0)
                            {
                                if (col - 1 >= 0) if (matrix[row - 2, col - 1] == 'K') currKnightAttacks++;
                                if (col + 1 < size) if (matrix[row - 2, col + 1] == 'K') currKnightAttacks++;
                            }

                            if (row + 2 < size)
                            {
                                if (col - 1 >= 0) if (matrix[row + 2, col - 1] == 'K') currKnightAttacks++;
                                if (col + 1 < size) if (matrix[row + 2, col + 1] == 'K') currKnightAttacks++;
                            }

                            if (col - 2 >= 0)
                            {
                                if (row - 1 >= 0) if (matrix[row - 1, col - 2] == 'K') currKnightAttacks++;
                                if (row + 1 < size) if (matrix[row + 1, col - 2] == 'K') currKnightAttacks++;
                            }

                            if (col + 2 < size)
                            {
                                if (row - 1 >= 0) if (matrix[row - 1, col + 2] == 'K') currKnightAttacks++;
                                if (row + 1 < size) if (matrix[row + 1, col + 2] == 'K') currKnightAttacks++;
                            }
                        }

                        if(currKnightAttacks > maxKnightAttacks)
                        {
                            maxKnightAttacks = currKnightAttacks;
                            maxKnightRow = row;
                            maxKnightCol = col;
                        }
                    }
                }

                knightAttacks -= maxKnightAttacks;
                minSum++;
                matrix[maxKnightRow, maxKnightCol] = '0';
            }

            Console.WriteLine(minSum);
        }
    }
}
