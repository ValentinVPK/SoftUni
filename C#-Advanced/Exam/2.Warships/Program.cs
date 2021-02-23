using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] coordinates = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[size, size];

            int playerOneShips = 0;
            int playerTwoShips = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                    if (matrix[row, col] == '<') playerOneShips++;
                    if (matrix[row, col] == '>') playerTwoShips++;
                }
            }


            int totalShipsSunk = 0;
            for(int i = 0; i < coordinates.Length; i++)
            {
                int[] tokens = coordinates[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currRow = tokens[0];
                int currCol = tokens[1];
                if(!isPositionValid(currRow, currCol, size))
                {
                    continue;
                }

                if (matrix[currRow, currCol] == '#')
                {
                    matrix[currRow, currCol] = 'X';
                    if (isPositionValid(currRow, currCol + 1, size))
                    {
                        if (matrix[currRow, currCol + 1] == '<')
                        {
                            matrix[currRow, currCol + 1] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow, currCol + 1] == '>')
                        {
                            matrix[currRow, currCol + 1] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }

                    if (isPositionValid(currRow, currCol - 1, size))
                    {
                        if (matrix[currRow, currCol - 1] == '<')
                        {
                            matrix[currRow, currCol - 1] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow, currCol - 1] == '>')
                        {
                            matrix[currRow, currCol - 1] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }

                    if (isPositionValid(currRow + 1, currCol, size))
                    {
                        if (matrix[currRow + 1, currCol] == '<')
                        {
                            matrix[currRow + 1, currCol] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow + 1, currCol] == '>')
                        {
                            matrix[currRow + 1, currCol] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }
                    if (isPositionValid(currRow - 1, currCol, size))
                    {
                        if (matrix[currRow - 1, currCol] == '<')
                        {
                            matrix[currRow - 1, currCol] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow - 1, currCol] == '>')
                        {
                            matrix[currRow - 1, currCol] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }

                    if (isPositionValid(currRow + 1, currCol - 1, size))
                    {
                        if (matrix[currRow + 1, currCol - 1] == '<')
                        {
                            matrix[currRow + 1, currCol - 1] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow + 1, currCol - 1] == '>')
                        {
                            matrix[currRow + 1, currCol - 1] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }

                    if (isPositionValid(currRow + 1, currCol + 1, size))
                    {
                        if (matrix[currRow + 1, currCol + 1] == '<')
                        {
                            matrix[currRow + 1, currCol + 1] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow + 1, currCol + 1] == '>')
                        {
                            matrix[currRow + 1, currCol + 1] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }

                    if (isPositionValid(currRow - 1, currCol + 1, size))
                    {
                        if (matrix[currRow - 1, currCol + 1] == '<')
                        {
                            matrix[currRow - 1, currCol + 1] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow - 1, currCol + 1] == '>')
                        {
                            matrix[currRow - 1, currCol + 1] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }

                    if (isPositionValid(currRow - 1, currCol - 1, size))
                    {
                        if (matrix[currRow - 1, currCol - 1] == '<')
                        {
                            matrix[currRow - 1, currCol - 1] = 'X';
                            playerOneShips--;
                            totalShipsSunk++;
                        }
                        if (matrix[currRow - 1, currCol - 1] == '>')
                        {
                            matrix[currRow - 1, currCol - 1] = 'X';
                            playerTwoShips--;
                            totalShipsSunk++;
                        }
                    }   
                }
                else if (i % 2 == 0)
                {
                    if(matrix[currRow,currCol] == '>')
                    {
                        matrix[currRow, currCol] = 'X';
                        playerTwoShips--;
                        totalShipsSunk++;
                    }
                }
                else if(i % 2 == 1)
                {
                    if (matrix[currRow, currCol] == '<')
                    {
                        matrix[currRow, currCol] = 'X';
                        playerOneShips--;
                        totalShipsSunk++;
                    }
                }



                if (playerOneShips == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {totalShipsSunk} ships have been sunk in the battle.");
                    break;
                }
                else if(playerTwoShips == 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalShipsSunk} ships have been sunk in the battle.");
                    break;
                }
            }

            if(playerOneShips > 0 && playerTwoShips > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }
        }

        public static bool isPositionValid(int row, int col, int size)
        {
            if (row < 0 || row >= size) return false;

            if (col < 0 || col >= size) return false;

            return true;
        }     
    }
}
