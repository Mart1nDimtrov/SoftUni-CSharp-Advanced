using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Largest_3_Nums
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray()
                                .OrderByDescending(x => x)
                                .Take(3)
                                .ToList()
                                .ForEach(x => Console.Write(x + " "));
        }
    }
}
