using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                          .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            int [] maxPos = new int[2];
            int maxSum = 0;
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine()
                                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col + 1 < cols && row + 1 < rows)
                    {
                        int tempSum = 0;
                        tempSum += matrix[row, col];
                        tempSum += matrix[row + 1, col];
                        tempSum += matrix[row, col + 1];
                        tempSum += matrix[row + 1, col + 1];
                        if (maxSum < tempSum)
                        {
                            maxPos[0] = row;
                            maxPos[1] = col;
                            maxSum = tempSum;
                        }
                    }
                }
            }
            Console.WriteLine("{0} {1}", matrix[maxPos[0], maxPos[1]], matrix[maxPos[0], maxPos[1] + 1]);
            Console.WriteLine("{0} {1}", matrix[maxPos[0] + 1, maxPos[1]], matrix[maxPos[0] + 1, maxPos[1] + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
