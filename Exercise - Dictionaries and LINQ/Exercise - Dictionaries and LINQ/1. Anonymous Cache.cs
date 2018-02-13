using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Dictionaries_and_LINQ
{
    class Program
    {
        public class DataSet
        {
            public string name { get; set; }
            public List<string> dataKeys { get; set; }
            public bool exists { get; set; }
            public int total  { get; set; }

            public DataSet (string name)
            {
                this.exists = false;
                this.name = name;
                dataKeys = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            List<DataSet> dataSetList = new List<DataSet>();
            string input = Console.ReadLine();
            char[] chars = new char[] { '|', '>', '-', ' ' };

            while (input != "thetinggoesskrra")
            {
                string[] inputParsed = input
                                     .Split(chars, StringSplitOptions.RemoveEmptyEntries)
                                     .ToArray();
                if (inputParsed.Length == 1)
                {
                    DataSet ds = dataSetList
                                 .Where(d => d.name == input)
                                 .FirstOrDefault();
                    if (ds == null)
                    {
                        DataSet newDS = new DataSet(input);
                        newDS.exists = true;
                        dataSetList.Add(newDS);
                    }
                    else
                    {
                        ds.exists = true;
                    }
                                 
                }
                else
                {
                    string dataKey = inputParsed[0];
                    int dataSize = int.Parse(inputParsed[1]);
                    string name = inputParsed[2];
                    DataSet ds = dataSetList
                                 .Where(d => d.name == name)
                                 .FirstOrDefault();
                    if (ds == null)
                    {
                        DataSet newDS = new DataSet(name);
                        newDS.dataKeys.Add(dataKey);
                        newDS.total += dataSize;
                        dataSetList.Add(newDS);
                    }
                    else
                    {
                        ds.total += dataSize;
                        ds.dataKeys.Add(dataKey);
                    }

                }

                input = Console.ReadLine();
            }

            DataSet dsFinal = dataSetList.Where(d => d.exists == true)
                       .OrderByDescending(ds => ds.total)
                       .FirstOrDefault();
            if (dsFinal == null)
            {

            }
            else
            {
                Console.WriteLine("Data Set: {0}, Total Size: {1}", dsFinal.name, dsFinal.total);
                foreach (string dataKey in dsFinal.dataKeys)
                {
                    Console.WriteLine("$." + dataKey);
                }
            }
            

        }
    }
}
