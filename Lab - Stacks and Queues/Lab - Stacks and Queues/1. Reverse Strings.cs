using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> wordsReversed = new Stack<char>();

            foreach (char ch in input)
            {
                wordsReversed.Push(ch);
            }

            foreach(char ch in wordsReversed)
            {
                Console.Write(ch);
            }
            Console.WriteLine();

        }
    }
}
