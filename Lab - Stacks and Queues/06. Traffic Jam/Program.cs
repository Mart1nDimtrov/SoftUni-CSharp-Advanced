using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carPass = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            int carCount = 0;
            while (input != "end")
            {
                
                if (input == "green")
                {
                    if (carPass > queue.Count)
                    {
                        int carQue = queue.Count;
                        for (int i = 0; i < carQue; i++)
                        {
                            carCount++;
                            Console.WriteLine("{0} passed!", queue.Dequeue());
                        }
                    } else
                    {
                        for (int i = 0; i < carPass; i++)
                        {
                            carCount++;
                            Console.WriteLine("{0} passed!", queue.Dequeue());
                        }
                    }
                    
                } else
                {
                    queue.Enqueue(input);
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("{0} cars passed the crossroads.", carCount);
        }
    }
}
