using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            Queue<int[]> tempQue = new Queue<int[]>();

            for (int i = 0; i < countOfPumps; i++)
            {
                int[] pump = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
                queue.Enqueue(new int [] { pump[0], pump[1], i});
            }

            int firstPos = -1;

            for (int i = 0; i < countOfPumps; i++)
            {
                bool enoughFuel = true;
                int tank = 0;
                for (int j = 0; j < countOfPumps; j++)
                {
                    int[] pump = queue.Peek();
                    int amountOfPetrol = pump[0];
                    int distance = pump[1];
                    tank += amountOfPetrol;
                    if (j == 0)
                    {
                        firstPos = pump[2];
                    }
                    if (distance <= tank)
                    {
                        tank -= distance;
                    }
                    else
                    {
                        enoughFuel = false;
                    }
                    tempQue.Enqueue(queue.Dequeue());
                }
                if (enoughFuel == true)
                {
                    Console.WriteLine(firstPos);
                    break;
                }
                tempQue.Enqueue(tempQue.Dequeue());
                queue = tempQue;
            }

        }
    }
}
