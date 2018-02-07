using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _4.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger count = BigInteger.Parse(Console.ReadLine());
            BigInteger[][] jaggedArray = new BigInteger[(int)(count)][];
            jaggedArray[0] = new BigInteger[1] { 1 };
            for (int row = 1; row < count; row++)
            {
                jaggedArray[row] = new BigInteger[row + 1];
                for (int col = 0; col < row + 1; col++)
                {
                    if (col < row && col > 0)
                    {
                        jaggedArray[row][col] = jaggedArray[row - 1][col] + jaggedArray[row - 1][col - 1];
                    }
                    else
                    {
                        if (col == 0)
                        {
                            jaggedArray[row][col] = jaggedArray[row - 1][col];
                        } else
                        {
                            jaggedArray[row][col] = jaggedArray[row - 1][col - 1];
                        }
                        
                    }
                }
            }

            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
