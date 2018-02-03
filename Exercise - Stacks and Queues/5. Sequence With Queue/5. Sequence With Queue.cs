using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            Queue<decimal> queue = new Queue<decimal>();
            Queue<decimal> firstElement = new Queue<decimal>();
            decimal count = 0;
            queue.Enqueue(num);
            while (count < 50)
            {
                queue.Enqueue(num + 1);
                queue.Enqueue(2 * num + 1);
                queue.Enqueue(num + 2);
                firstElement.Enqueue(queue.Dequeue());
                num = queue.Peek();
                count++;
            }

            while (firstElement.Count != 0)
            {
                Console.Write(firstElement.Dequeue() + " ");
            }
        }
    }
}
