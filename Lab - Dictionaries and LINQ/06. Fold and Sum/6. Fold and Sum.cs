using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            int k = arr.Length / 4;
            int[] arrTwo = arr.Take(k)
                             .Reverse()
                             .ToArray();
            int[] arrThree = arr.Skip(k + k * 2)
                             .Reverse()
                             .ToArray();
            int[] secondArr = arrTwo.Concat(arrThree)
                             .ToArray();

            int[] result = arr
                            .Skip(k)
                            .Take(k * 2)
                            .Select((x, index) => x + secondArr[index])
                            .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
