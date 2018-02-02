using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(' ')
                            .ToArray();
            Stack<string> stack = new Stack<string>();
            int sum = 0;

            foreach (string str in input.Reverse())
            {
                stack.Push(str);
            }
            int currentDigit =  int.Parse(stack.Pop());
            sum += currentDigit;
            string sign;
            while (stack.Count != 0)
            {
                    sign = stack.Pop();
                    currentDigit = int.Parse(stack.Pop());
                    if (sign == "-")
                    {
                        sum -= currentDigit;
                    }
                    else
                    {
                        sum += currentDigit;
                    }
                    
            }
            Console.WriteLine(sum);

        }
    }
}
