using System;
using System.Linq;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> farm = new Dictionary<string, long>();

            Dictionary<string, long> junk = new Dictionary<string, long>();

            farm.Add("shards", 0);
            farm.Add("fragments", 0);
            farm.Add("motes", 0);
            
            string[] input = null;
            input = Console.ReadLine().ToLower().Split().ToArray();

            while (true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        int number = int.Parse(input[i]);
                        string word = input[i + 1];
                        if (word == "shards" || word == "fragments" || word == "motes")
                        {
                            farm[word] = farm[word] + number;
                            if (farm[word] >= 250)
                            {
                                farm[word] = farm[word] - 250;
                                if (word == "shards")
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                    Print(farm, junk);
                                }
                                else if (word == "fragments")
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                    Print(farm, junk);
                                }
                                else if (word == "motes")
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                    Print(farm, junk);
                                }
                                return;
                            }
                        }
                        else
                        {
                            if (!junk.ContainsKey(word))
                            {
                                junk.Add(word, number);
                            }
                            else
                            {
                                junk[word] += number;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }//forloop ends here.

                input = Console.ReadLine().ToLower().Split().ToArray();

            }//while loop ends here.
            
        }//End of main method.
        static void Print(Dictionary<string, long> farm, Dictionary<string, long> junk)
        {
            var farmList = farm.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in farmList)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

            var junkList = junk.OrderBy(x => x.Key).ToList();

            foreach (var item in junkList)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

            return;
        }
    }
}
