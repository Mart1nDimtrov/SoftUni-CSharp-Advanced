using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            int [] numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            Stack<int> stack = new Stack<int>();

            int countOfPush = commands[0];
            int countOfPop = commands[1];
            int valueToCheck = commands[2];

            for (int i = 0; i < countOfPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < countOfPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(valueToCheck))
            {
                Console.WriteLine("true");
            } else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            } else
            {
                Console.WriteLine(0);
            }

        }
    }
}
