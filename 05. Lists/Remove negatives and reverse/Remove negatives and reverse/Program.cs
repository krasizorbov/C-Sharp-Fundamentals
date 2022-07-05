using System;
using System.Linq;
using System.Collections.Generic;

namespace Remove_negatives_and_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }

            numbers.Reverse();

            if (!numbers.Any())
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
