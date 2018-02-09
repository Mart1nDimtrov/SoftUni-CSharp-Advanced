using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();



            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine()
                                    .Split()
                                    .ToArray();
                string continent = line[0];
                string country = line[1];
                string city = line[2];

                if (dict.ContainsKey(continent))
                {
                    if (dict[continent].ContainsKey(country))
                    {
                            dict[continent][country].Add(city);
                    }
                    else
                    {
                        dict[continent][country] = new List<string>();
                        dict[continent][country].Add(city);
                    }
                   
                }
                else
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                    dict[continent][country] = new List<string>();
                    dict[continent][country].Add(city);
                }

            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> continent in dict)
            {
                Console.WriteLine("{0}:", continent.Key);
                foreach (KeyValuePair<string, List<string>> country in continent.Value)
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }

            }

        }
    }
}
