using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameters = int.Parse(Console.ReadLine());
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < parameters; row++)
            {
                int[] line = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
                for (int col = 0; col < parameters; col++)
                {
                    if (row == col)
                    {
                        primaryDiagonal += line[col];
                    }
                    if (col == (parameters - row) - 1)
                    {
                        secondaryDiagonal += line[col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
