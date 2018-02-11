using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", arr.Sum());
            Console.WriteLine("Min = {0}", arr.Min());
            Console.WriteLine("Max = {0}", arr.Max());
            Console.WriteLine("Average = {0}", arr.Average());
   
        }
    }
}
