using System;
using System.Linq;
using System.Collections.Generic;

namespace Drum_set
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumSetCopy = drumSet.ToList();
            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] = drumSet[i] - hitPower;
                }
                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= 0)
                    {
                        if (totalMoney - drumSetCopy[i] * 3 >=0)
                        {
                            totalMoney = totalMoney - drumSetCopy[i] * 3;
                            drumSet[i] = drumSetCopy[i];
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumSetCopy.RemoveAt(i);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine("Gabsy has {0:F2}lv.", totalMoney);
        }
    }
}
