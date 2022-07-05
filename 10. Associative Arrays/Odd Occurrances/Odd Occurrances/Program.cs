using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurrances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word.ToLower()))
                {
                    counts[word.ToLower()]++;
                }
                else
                {
                    counts.Add(word.ToLower(), 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
