using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            List<int> remainderZero = new List<int>();
            List<int> remainderOne = new List<int>();
            List<int> remainderTwo = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) % 3 == 0)
                {
                    remainderZero.Add(nums[i]);
                }
                else if (Math.Abs(nums[i]) % 3 == 1)
                {
                    remainderOne.Add(nums[i]);
                }
                else if (Math.Abs(nums[i]) % 3 == 2)
                {
                    remainderTwo.Add(nums[i]);
                }
            }
          
            for (int i = 0; i < remainderZero.Count; i++)
            {
                Console.Write(remainderZero[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < remainderOne.Count; i++)
            {
                Console.Write(remainderOne[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < remainderTwo.Count; i++)
            {
                Console.Write(remainderTwo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
