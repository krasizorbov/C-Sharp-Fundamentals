using System;
using System.Linq;
using System.Collections.Generic;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            //color.Key dictionary.Value(name.Key, phisics.Value)
            var colors = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" <:> ").ToArray();

                if (input[0] == "Once upon a time")
                {
                    break;
                }

                string name = input[0];
                string color = input[1];
                int phisics = int.Parse(input[2]);

                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());
                    colors[color][name] = phisics;
                }
                else
                {
                    if (colors[color].ContainsKey(name))
                    {
                        if (colors[color][name] < phisics)
                        {
                            colors[color][name] = phisics;
                        }
                    }
                }

            }//while loop ends here

            foreach (var color in colors.OrderBy(x => x.Key))
            {
                Console.Write($"({color.Key}) ");
                foreach (var name in color.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{name.Key} <-> {name.Value}");
                }
            }
        }
    }
}
 