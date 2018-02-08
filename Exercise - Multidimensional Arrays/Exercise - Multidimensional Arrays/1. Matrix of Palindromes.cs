using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();

            int rows = parameters[0];
            int cols = parameters[1];

            for (int row = 0; row < rows; row++)
            {
                char ch = Convert.ToChar(row + 97);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0}{1}{2} ", ch, Convert.ToChar(ch + col), ch);
                }
                Console.WriteLine();
            }

        }
    }
}
