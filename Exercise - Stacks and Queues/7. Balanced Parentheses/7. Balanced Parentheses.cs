using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parantheses = Console.ReadLine();

            Queue<char> queue = new Queue<char>(parantheses.Substring(0, parantheses.Length / 2));
            Stack<char> stack = new Stack<char>(parantheses.Substring(parantheses.Length / 2));

            for (int i = 0; i < parantheses.Length / 2; i++)
            {
                char first = queue.Dequeue();
                char last = stack.Pop();
                if (first == '[' && last == ']')
                {

                }
                else if (first == '(' && last == ')')
                {

                }
                else if (first == '{' && last == '}')
                {

                } else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
