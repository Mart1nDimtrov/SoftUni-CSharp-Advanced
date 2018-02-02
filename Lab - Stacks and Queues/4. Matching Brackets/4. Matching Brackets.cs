using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string arithmExp = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < arithmExp.Length; i++)
            {
                if (arithmExp[i] == '(')
                {
                    pushExpression(ref stack, arithmExp.Substring(i));
                }
            }

            while(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }

        public static void pushExpression(ref Stack<string> stack, string arithmExp)
        {
            bool isEnd = true;
            int lastIndex = 0;
            for (int i = 1; i < arithmExp.Length; i++)
            {
                if (arithmExp[i] == ')')
                {
                    if (isEnd == true)
                    {
                        lastIndex = i;
                        break;
                    }
                    isEnd = true;
                }
                else if (arithmExp[i] == '(')
                {
                    isEnd = false;
                }
            }
            stack.Push(arithmExp.Substring(0, lastIndex + 1));
        }
    }
}
