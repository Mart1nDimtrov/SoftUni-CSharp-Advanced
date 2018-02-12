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
            public List<string> dataSizes { get; set; }
            public bool exists { get; set; }
            public int total { get; set; }

            public DataSet (string name)
            {
                this.name = name;
                this.total = 0;
                dataSizes = new List<string>();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
