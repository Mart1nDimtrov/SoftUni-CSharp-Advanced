using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            int[] numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            Queue<int> queue = new Queue<int>();

            int countOfPush = commands[0];
            int countOfPop = commands[1];
            int valueToCheck = commands[2];

            for (int i = 0; i < countOfPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < countOfPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(valueToCheck))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
