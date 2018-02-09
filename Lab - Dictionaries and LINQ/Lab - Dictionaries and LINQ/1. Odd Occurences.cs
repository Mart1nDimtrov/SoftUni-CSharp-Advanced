using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Dictionaries_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i].ToLower()))
                {
                    dict[words[i].ToLower()]++;
                }
                else
                {
                    dict[words[i].ToLower()] = 1;
                }
            }

            int count = 0;
            Dictionary<string, int> newDict = dict
                                                .Where(x => x.Value % 2 == 1)
                                                .ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, int> word in newDict)
            {
                if (word.Value % 2 == 1)
                {
                    if (count == newDict.Count - 1)
                    {
                        Console.WriteLine(word.Key);
                    }
                    else
                    {
                        Console.Write(word.Key + ", ");
                    }
                }
                count++;
                
            }

        }
    }
}
