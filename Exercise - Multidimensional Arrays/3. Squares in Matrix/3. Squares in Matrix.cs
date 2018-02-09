using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Squares_in_Matrix
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
            int squareCount = 0;
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] rowLine = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(char.Parse)
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
                    if (CheckSquare(matrix, rows, cols, row, col))
                    {
                        squareCount++;
                    }
                }
            }

            Console.WriteLine(squareCount);

        }

        public static bool CheckSquare (char[,] matrix, int rows, int cols, int row, int col)
        {
            if (row + 1 < rows && col + 1 < cols)
            {
                if (matrix[row,col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1] && matrix[row + 1, col + 1] == matrix[row + 1, col])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
