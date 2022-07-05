using System;
using System.Linq;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mydic = new Dictionary<string, int>();

            string input = string.Empty;

            while (input != "stop")
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int num = int.Parse(Console.ReadLine());

                if (mydic.ContainsKey(input))
                {
                    mydic[input] = num + mydic[input];
                }
                else
                {
                    mydic.Add(input, num);
                }

            }

            foreach (var item in mydic)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
