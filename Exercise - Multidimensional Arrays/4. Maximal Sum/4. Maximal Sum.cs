using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int rows = parameters[0];
            int cols = parameters[1];
            int maxSum = 0;
            int[] maxIndex = new int[2];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowLine = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowLine[col];
                }
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int tempSum = 0;
                    if (CheckSquare(matrix, rows, cols, row, col))
                    {
                        tempSum += matrix[row, col];
                        tempSum += matrix[row, col + 1];
                        tempSum += matrix[row, col + 2];
                        tempSum += matrix[row + 1, col];
                        tempSum += matrix[row + 1, col + 1];
                        tempSum += matrix[row + 1, col + 2];
                        tempSum += matrix[row + 2, col];
                        tempSum += matrix[row + 2, col + 1];
                        tempSum += matrix[row + 2, col + 2];

                        if (tempSum > maxSum)
                        {
                            maxSum = tempSum;
                            maxIndex[0] = row;
                            maxIndex[1] = col;
                        }
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maxSum);

            for (int r = maxIndex[0]; r < maxIndex[0] + 3; r++)
            {
                for (int c = maxIndex[1]; c < maxIndex[1] + 3; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }

        }

        public static bool CheckSquare(int[,] matrix, int rows, int cols, int row, int col)
        {
            if (row + 2 < rows && col + 2 < cols)
            {
                return true;
            }
            return false;
        }

    }
}