using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] size = Console.ReadLine()
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int rows = size[0];
            int cols = size[1];
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine()
                                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    sum += nums[col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
