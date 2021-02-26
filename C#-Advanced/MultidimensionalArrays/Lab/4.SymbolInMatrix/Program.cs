using System;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            bool symbolFound = false;
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                string currRow = Console.ReadLine();
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (symbolFound) break;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        symbolFound = true;
                        break;
                    }
                }
            }

            if (!symbolFound) Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
