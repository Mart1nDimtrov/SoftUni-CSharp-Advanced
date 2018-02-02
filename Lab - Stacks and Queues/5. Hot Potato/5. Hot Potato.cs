using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                           .Split(' ')
                           .ToArray();
            int turn = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);
            int count = 1;
            while (queue.Count != 1)
            {
                for (int i = 1; i < turn; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine("Removed {0}", queue.Dequeue()); 
            }
            Console.WriteLine("Last is {0}", queue.Dequeue());
        }
    }
}
