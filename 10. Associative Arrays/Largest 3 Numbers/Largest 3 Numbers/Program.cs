using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sorted = numbers.OrderByDescending(x => x).ToArray();

            if (sorted.Length >= 3)
            {
                Console.WriteLine(string.Join(" ", sorted.Take(3)));
            }
            else if (sorted.Length == 2)
            {
                Console.WriteLine(string.Join(" ", sorted.Take(2)));
            }
            else if (sorted.Length == 1)
            {
                Console.WriteLine(string.Join(" ", sorted.Take(1)));
            }
        }
    }
}
