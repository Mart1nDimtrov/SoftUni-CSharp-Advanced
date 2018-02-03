using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nFib = decimal.Parse(Console.ReadLine());
            if (nFib == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (nFib == 1 || nFib == 2)
            {
                Console.WriteLine("1");
                return;
            }
            Queue<decimal> queue = new Queue<decimal>();
            queue.Enqueue(1);
            queue.Enqueue(1);
            Stack<decimal> stack = new Stack<decimal>();
            for (int i = 0; i < nFib - 2; i++)
            {
                stack.Push(queue.Dequeue() + queue.Peek());
                queue.Enqueue(stack.Peek());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
