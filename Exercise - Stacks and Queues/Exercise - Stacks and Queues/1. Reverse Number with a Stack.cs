using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToArray());
            if (stack.Count == 0)
            {
                return;
            }
            while (stack.Count != 0)
            {
                Console.Write("{0} ", stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
