using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static int diagonalDifference(int[,] inputMatrix)
        {
            int mainDiagSum = 0;
            int secondDiagSum = 0;
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    if(i == j) mainDiagSum += inputMatrix[i, j];

                    if(j == inputMatrix.GetLength(0) - i - 1)
                    {
                        secondDiagSum += inputMatrix[i, j];
                    }
                }
            }

            return Math.Abs(mainDiagSum - secondDiagSum);
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                var row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i,j] = row[j];
                }
            }

            Console.WriteLine(diagonalDifference(matrix));
        }
    }
}
